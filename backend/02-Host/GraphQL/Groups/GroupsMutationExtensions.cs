using System.Security.Claims;
using _02_Database;
using _02_Domain;
using _02_Domain.Groups;
using HotChocolate.Authorization;
using HotChocolate.Resolvers;
using Microsoft.EntityFrameworkCore;

namespace _02_Host.GraphQL.Groups;

[ExtendObjectType<Mutation>]
public class GroupsMutationExtensions
{
    [UseMutationConvention(Disable = false)]
    [Authorize]
    [Error<GroupAlreadyExistsException>]
    [Error<GroupCannotBeEmptyException>]
    public Group CreateGroup(WorkshopsDbContext dbContext, IResolverContext resolverContext,
        CreateGroupInput input)
    {
        var userId = Guid.Parse(resolverContext.GetUser()!.FindFirst(ClaimTypes.NameIdentifier)!.Value);
        var name = input.Name;

        if (
            dbContext.Groups.Any(x =>
                EF.Functions.ILike(x.Name, name)))
        {
            throw new GroupAlreadyExistsException(name);
        }

        var group = new Group()
        {
            Name = name,
            OwnerId = userId,
            Id = Guid.NewGuid(),
            UserDevices = new List<UserDevice>()
        };

        dbContext.Groups.Add(group);
        dbContext.SaveChanges();
        return group;
    }

    public record CreateGroupInput(string Name);
}