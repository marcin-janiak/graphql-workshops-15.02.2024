namespace _02_Domain;

public class Group
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid OwnerId { get; set; }
    public ICollection<UserDevice> UserDevices { get; set; }
}