namespace _02_Domain.Groups;

public class GroupAlreadyExistsException : Exception
{
    public string Name { get; }

    public GroupAlreadyExistsException(string name) : base($"Group with name {name} already exists!")
    {
        Name = name;
    }
}