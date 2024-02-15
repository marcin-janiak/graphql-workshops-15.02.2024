using Domain;

namespace _01_PersonalizationApi;

public class BrokerApiClient
{
    private readonly HttpClient _client;

    public BrokerApiClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<DevicePayload> GetDevicePayload(Guid deviceId)
    {
        var response = await _client.GetFromJsonAsync<DevicePayload>($"devices/{deviceId}/payload");
        if (response is not null)
        {
            return response;
        }
        else
        {
            throw new Exception("Device not found");
        }
    }

    public async Task<List<DevicePayload>> GetDevicePayloadsBatch(List<Guid> ids)
    {
        var param = string.Join(";", ids);
        var response = await _client.GetFromJsonAsync<List<DevicePayload>>($"devices/batchPayloads?ids={param}");
        if (response is not null)
        {
            return response;
        }
        else
        {
            throw new Exception("Device not found");
        }
    }
}