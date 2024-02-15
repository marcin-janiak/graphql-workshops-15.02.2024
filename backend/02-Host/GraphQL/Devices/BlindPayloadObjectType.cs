using _02_Domain;

namespace _02_Host.GraphQL.Devices;

public class BlindPayloadObjectType : ObjectType<BlindPayload>
{
    protected override void Configure(IObjectTypeDescriptor<BlindPayload> descriptor)
    {
        base.Configure(descriptor);
        descriptor.Implements<DevicePayloadInterfaceType>();
    }
}