using _02_Domain;

namespace _02_Host.GraphQL.Devices;

public class DeviceObjectType : ObjectType<Device>
{
    protected override void Configure(IObjectTypeDescriptor<Device> descriptor)
    {
        base.Configure(descriptor);
        descriptor.Field(x => x.DeviceType).IsProjected();
        descriptor.Field(x => x.DeviceId).IsProjected();
    }
}