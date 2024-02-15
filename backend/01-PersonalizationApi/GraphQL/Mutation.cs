using Domain;

namespace _01_PersonalizationApi.GraphQL;

public class Mutation
{
    public Guid CreateGroup(CreateGroupInput input)
    {
        return Guid.NewGuid();
    }

    public Group CreateGroupBetter(CreateGroupInput input)
    {
        return new Group()
        {
            Id = Guid.NewGuid(),
            Name = input.Name
        };
    }

    [UseMutationConvention(Disable = false)]
    [Error<GroupAlreadyExistsException>]
    // public Group CreateGroupBest(CreateGroupBestInput input)
    public Group CreateGroupBest(string name)
    {
        if (name.Contains("_"))
        {
            throw new GroupAlreadyExistsException(name);
        }

        return new Group()
        {
            Id = Guid.NewGuid(),
            Name = name
        };
    }

    [UseMutationConvention(Disable = false)]
    [Error<GroupAlreadyExistsException>]
    public Group CreateGroupBestWithFairyBread(CreateGroupBestWithFairyBreadInput input)
    {
        if (input.Name.Contains("$"))
        {
            throw new GroupAlreadyExistsException(input.Name);
        }

        return new Group()
        {
            Id = Guid.NewGuid(),
            Name = input.Name
        };
    }
}

public record CreateGroupInput(string Name);

public record CreateGroupBestWithFairyBreadInput(string Name);

public class GroupAlreadyExistsException : Exception
{
    public string Name { get; }

    public GroupAlreadyExistsException(string name) : base($"Group with name {name} already exists!")
    {
        Name = name;
    }
}

