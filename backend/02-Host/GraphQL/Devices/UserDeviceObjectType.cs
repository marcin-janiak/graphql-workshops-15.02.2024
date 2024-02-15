using _02_Domain;

namespace _02_Host.GraphQL.Devices;

public class UserDeviceObjectType : ObjectType<UserDevice>
{
    protected override void Configure(IObjectTypeDescriptor<UserDevice> descriptor)
    {
        base.Configure(descriptor);
        descriptor.Field(x => x.UserId).IsProjected();
        descriptor.Field(x => x.DeviceId).IsProjected();
        descriptor.Field(x => x.Device).Cost(3);
    }
}