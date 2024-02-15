using Common;
using Domain;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/devices/{id:guid}/payload", (Guid id) => FakeDeviceFactory.Create(id, DeviceType.Blind));
app.MapGet("/devices/batchPayloads",
    (string ids) =>
    {
        return ids.Split(";", StringSplitOptions.RemoveEmptyEntries)
            .Select((x, i) =>
                FakeDeviceFactory.Create(Guid.Parse(x),
                    SeedHelper.GetRandomDeviceTypeBasedOnIndex(i))).ToList();
    });

    app.Run();

public static class FakeDeviceFactory
{
    public static DevicePayload Create(Guid deviceId, DeviceType deviceType) => deviceType switch
    {
        DeviceType.Switch => new SwitchPayload()
        {
            DeviceId = deviceId,
            InstallationId = SeedHelper.InstallationIds[0],
            Value = true,
            SoftwareVersion = "0.0.1"
        },
        DeviceType.Blind => new BlindPayload()
        {
            DeviceId = deviceId,
            InstallationId = SeedHelper.InstallationIds[0],
            OpenPercentage = 50,
            SoftwareVersion = "0.0.1"
        },
        _ => throw new ArgumentOutOfRangeException(nameof(deviceType), deviceType, null)
    };
}