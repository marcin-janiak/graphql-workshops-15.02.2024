using System.Security.Claims;
using _02_Database;
using _02_Domain;
using HotChocolate.Authorization;
using HotChocolate.Resolvers;

namespace _02_Host.GraphQL.Groups;

[ExtendObjectType<Query>]
public class GroupsQueryExtensions
{
    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    [Authorize]
    [Cost(5, multipliers: "first")]
    public IQueryable<Group> AllGroups(WorkshopsDbContext dbContext, IResolverContext resolverContext)
    {
        var userId = Guid.Parse(resolverContext.GetUser()!.FindFirst(ClaimTypes.NameIdentifier)!.Value);
        return dbContext.Groups.Where(x => x.OwnerId == userId);
    }
}