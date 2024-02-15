using _02_Domain;
using Bogus;
using Common;
using Microsoft.EntityFrameworkCore;

namespace _02_Database;

public class WorkshopsDbContext : DbContext
{
    public DbSet<Group> Groups => Set<Group>();
    public DbSet<UserDevice> UserDevices => Set<UserDevice>();
    public DbSet<Device> Devices => Set<Device>();

    public WorkshopsDbContext(DbContextOptions<WorkshopsDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var defaultJsonBObjectValue = "'{}'::jsonb";
        var defaultJsonBArrayValue = "'[]'::jsonb";

        modelBuilder.Entity<UserDevice>().HasKey(x => new { x.DeviceId, x.UserId });
        modelBuilder.Entity<UserDevice>().HasOne<Device>(x => x.Device).WithMany();
        modelBuilder.Entity<Device>().HasKey(x => x.DeviceId);

        modelBuilder.Entity<Device>()
            .Property(x => x.Payload)
            .HasColumnType("jsonb")
            .HasConversion(
                v => JsonSerializerHelper.Serialize(v),
                v => JsonSerializerHelper.Deserialize<DevicePayload>(v))
            .HasDefaultValueSql(defaultJsonBObjectValue);

        modelBuilder.Entity<Group>().HasKey(x => x.Id);
        modelBuilder.Entity<Group>().HasMany(x => x.UserDevices).WithMany();


        var userId = new Guid("F2E9E523-E78F-436D-B7B1-7BAA330C4DAD");


        var userDeviceFaker = new Faker<UserDevice>()
            .RuleFor(x => x.DeviceId, faker => faker.Random.Guid())
            .RuleFor(x => x.Alias, faker => faker.Internet.DomainName())
            .RuleFor(x => x.UserId, userId);

        var faker = new Faker<Group>()
            .RuleFor(x => x.Id, faker => faker.Random.Guid())
            .RuleFor(x => x.Name, faker => faker.Address.Country())
            .RuleFor(x => x.OwnerId, userId);

        // GroupId = table.Column<Guid>(type: "uuid", nullable: false),
        // UserDevicesDeviceId = table.Column<Guid>(type: "uuid", nullable: false),
        // UserDevicesUserId = table.Column<Guid>(type: "uuid", nullable: false)

        var groups = faker.Generate(3);
        modelBuilder.Entity<Group>().HasData(groups);
        foreach (var group in groups)
        {
            var devices = userDeviceFaker.Generate(3);
            modelBuilder.Entity<UserDevice>().HasData(devices);
            modelBuilder.Entity<Device>().HasData(devices.Select(userDevice => new Device()
            {
                DeviceId = userDevice.DeviceId,
                Name = userDevice.Alias,
                Payload = new ThermometerPayload()
                {
                    DeviceId = userDevice.DeviceId,
                    SoftwareVersion = "0.0.1"
                },
                DeviceType = DeviceType.Thermometer
            }));
            modelBuilder.Entity("GroupUserDevice").HasData(devices.Select(x => new
            {
                GroupId = group.Id,
                UserDevicesDeviceId = x.DeviceId,
                UserDevicesUserId = x.UserId
            }));
        }
    }
}