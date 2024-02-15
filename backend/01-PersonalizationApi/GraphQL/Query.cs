using Common;
using Domain;

namespace _01_PersonalizationApi.GraphQL;

public class Query
{
    public async Task<List<UserDevice>> GetAllDevices(
        [Service] DeviceRepository deviceRepository,
        [Service] BrokerApiClient brokerApiClient,
        Guid installationId)
    {
        var devices = deviceRepository.GetDevices(installationId).ToList();
     
        // foreach (var device in devices)
        // {
        //     var payload = await brokerApiClient.GetDevicePayload(device.DeviceId);
        //     device.Device.Payload = payload;
        // }

        return devices;
    }
}

public class DeviceRepository
{
    private readonly List<UserDevice> _userDevices;

    public DeviceRepository()
    {
        _userDevices = SeedHelper.DeviceIds.Select(x => new UserDevice()
        {
            DeviceId = x.Value,
            Alias = $"My_device_{x.Key}",
            InstallationId = SeedHelper.InstallationIds[0],
            UserId = Guid.NewGuid(),
            Device = new Device()
            {
                DeviceId = x.Value,
                DeviceType = SeedHelper.GetRandomDeviceTypeBasedOnIndex(x.Key),
                Name = $"device_{x.Key}",
                InstallationId = SeedHelper.InstallationIds[0],
            }
        }).ToList();
    }

    public UserDevice GetDevice(Guid deviceId)
    {
        return _userDevices.First(x => x.DeviceId == deviceId);
    }

    public IEnumerable<UserDevice> GetDevices(Guid installationId)
    {
        return _userDevices.Where(x => x.InstallationId == installationId);
    }
}