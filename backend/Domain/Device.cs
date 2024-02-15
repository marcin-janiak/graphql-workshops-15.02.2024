using System.Text.Json.Serialization;

namespace Domain;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$")]
[JsonDerivedType(typeof(SwitchPayload), typeDiscriminator: nameof(DeviceType.Switch))]
[JsonDerivedType(typeof(BlindPayload), typeDiscriminator: nameof(DeviceType.Blind))]
public class DevicePayload
{
    public Guid DeviceId { get; set; }
    public Guid InstallationId { get; set; }
    public string SoftwareVersion { get; set; }
}

public class SwitchPayload : DevicePayload
{
    public bool Value { get; set; }
}

public class BlindPayload : DevicePayload
{
    public int OpenPercentage { get; set; }
}

public enum DeviceType
{
    Unknown = 0,
    Switch = 1,
    Blind = 2
}

public class Device
{
    public Guid DeviceId { get; set; }
    public Guid InstallationId { get; set; }
    public string Name { get; set; }
    public DeviceType DeviceType { get; set; }
    public DevicePayload Payload { get; set; }
}

public class UserDevice
{
    public Guid UserId { get; set; }
    public Guid DeviceId { get; set; }
    public Guid InstallationId { get; set; }
    public string Alias { get; set; }
    public Device Device { get; set; }
}