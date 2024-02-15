namespace _02_Domain.Groups;

public class GroupCannotBeEmptyException : Exception
{
    public string Name { get; }

    public GroupCannotBeEmptyException(string name) : base($"Group with name {name} already exists!")
    {
        Name = name;
    }
}