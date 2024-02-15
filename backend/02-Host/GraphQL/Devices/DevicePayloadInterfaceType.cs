using _02_Domain;

namespace _02_Host.GraphQL.Devices;

public class DevicePayloadInterfaceType : InterfaceType<DevicePayload>
{
    protected override void Configure(IInterfaceTypeDescriptor<DevicePayload> descriptor)
    {
        base.Configure(descriptor);
    }
}