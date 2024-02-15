using System.Text.Json;
using System.Text.Json.Serialization;
using Bogus;
using Domain;

namespace Common;

public static class SeedHelper
{
    public static Dictionary<int, Guid> DeviceIds = new Dictionary<int, Guid>();
    public static Dictionary<int, Guid> InstallationIds = new Dictionary<int, Guid>();

    public static DeviceType GetRandomDeviceTypeBasedOnIndex(int i)
    {
        return (DeviceType)(i % 2 + 1);
    }
    
    static SeedHelper()
    {
        Randomizer.Seed = new Random(420);
        var faker = new Faker();

        for (var i = 0; i < 3; i++)
        {
            DeviceIds[i] = faker.Random.Guid();
            InstallationIds[i] = Guid.Parse("4BAC3BB4-B859-4DC2-B38D-F1D1E431CFD7");
        }
    }
}

public static class JsonSerializerHelper
{
    // only use single instance
    // https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/configure-options
    private static readonly JsonSerializerOptions settings;

    static JsonSerializerHelper()
    {
        settings = new JsonSerializerOptions();
    }

    public static string Serialize<T>(T data)
    {
        return JsonSerializer.Serialize(data, settings);
    }

    public static T Deserialize<T>(string json)
    {
        var result = JsonSerializer.Deserialize<T>(json, settings);
        if (result is null)
        {
            throw new InvalidDataException($"Unable to deserialize type {typeof(T).FullName}");
        }

        return result;
    }
}