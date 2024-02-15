using Domain;
using HotChocolate.Types.Descriptors;

namespace _01_PersonalizationApi.GraphQL;

public class DeviceObjectType : ObjectType<Device>
{
    protected override void Configure(IObjectTypeDescriptor<Device> descriptor)
    {
        base.Configure(descriptor);

        descriptor.Field("payloadBetter")
            .Resolve(resolverContext =>
            {
                var client = resolverContext.Services.GetRequiredService<BrokerApiClient>();
                var deviceId = resolverContext.Parent<Device>().DeviceId;

                return client.GetDevicePayload(deviceId);
            });

        descriptor.Field("payloadBest").Resolve(resolverContext =>
        {
            var client = resolverContext.Services.GetRequiredService<BrokerApiClient>();
            var deviceId = resolverContext.Parent<Device>().DeviceId;

            return resolverContext.BatchDataLoader<Guid, DevicePayload>(
                    async (keys, ct) =>
                    {
                        var result = await client.GetDevicePayloadsBatch(keys.ToList());
                        return result.ToDictionary(x => x.DeviceId);
                    })
                .LoadAsync(deviceId);
        });
    }
}

public class DevicePayloadInterfaceType : InterfaceType<DevicePayload>
{
}

public class SwitchPayloadObjectType : ObjectType<SwitchPayload>
{
    protected override void Configure(IObjectTypeDescriptor<SwitchPayload> descriptor)
    {
        base.Configure(descriptor);
        descriptor.Implements<DevicePayloadInterfaceType>();
    }
}

public class BlindPayloadObjectType : ObjectType<BlindPayload>
{
    protected override void Configure(IObjectTypeDescriptor<BlindPayload> descriptor)
    {
        base.Configure(descriptor);
        descriptor.Implements<DevicePayloadInterfaceType>();
    }
}