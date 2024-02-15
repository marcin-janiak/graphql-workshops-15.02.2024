namespace _03_PQ;

public class Query
{
    public Device GetDevice()
    {
        return new Device()
        {
            Id = Guid.NewGuid()
        };
    }
}

public class Device
{
    public Guid Id { get; set; }
}