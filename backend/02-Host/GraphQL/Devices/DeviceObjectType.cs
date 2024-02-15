using _02_Domain;

namespace _02_Host.GraphQL.Devices;

public class DeviceObjectType : ObjectType<Device>
{
    protected override void Configure(IObjectTypeDescriptor<Device> descriptor)
    {
        base.Configure(descriptor);
        descriptor.Field(x => x.DeviceType).IsProjected();
        descriptor.Field(x => x.DeviceId).IsProjected();

        // descriptor.Field(x => x.Name).Ignore();
        // descriptor.BindFieldsExplicitly();
        // descriptor.BindFieldsImplicitly();
        // descriptor.Field(x => x.DeviceId);
        // descriptor.Field("hello")
        //     .Resolve(_ => "hello")
        //     .Type<StringType>()
        //     .Authorize();

    }
}