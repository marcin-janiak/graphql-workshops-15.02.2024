using _02_Domain;

namespace _02_Host.GraphQL.Devices;

public class ThermometerPayloadObjectType : ObjectType<ThermometerPayload>
{
    protected override void Configure(IObjectTypeDescriptor<ThermometerPayload> descriptor)
    {
        base.Configure(descriptor);
        descriptor.Field("currentTemperature").Resolve(async () =>
            {
                await Task.Delay(1000);
                return 18 + (Random.Shared.NextSingle() * 5);
            })
            .Type<FloatType>();

        descriptor.Field("currentTemperature").Cost(30, new MultiplierPathString());

        descriptor.Field("errorThrowingTemperature").Type<FloatType>()
            .Resolve(x => throw new GraphQLException("Just a random exception in query"));
    }
}