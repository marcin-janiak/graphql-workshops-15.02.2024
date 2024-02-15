using _02_Domain;

namespace _02_Host.GraphQL.Devices;

public class SwitchPayloadObjectType : ObjectType<SwitchPayload>
{
    protected override void Configure(IObjectTypeDescriptor<SwitchPayload> descriptor)
    {
        base.Configure(descriptor);

        descriptor.Implements<DevicePayloadInterfaceType>();
    }
}