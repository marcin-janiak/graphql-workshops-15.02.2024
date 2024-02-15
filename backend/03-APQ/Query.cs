namespace _03_APQ;

public class Query
{
    public Device GetDevice()
    {
        return new Device()
        {
            Id = Guid.NewGuid(),
            Name = "test"
        };
    }
}

public class Device
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}