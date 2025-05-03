using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Locations;

public enum LocationEmergencyNumberType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Default for "default"
    /// </summary>
    [EnumMember(Value = "default")]
    Default,

    /// <summary>
    /// Enum Elin for "elin"
    /// </summary>
    [EnumMember(Value = "elin")]
    Elin
}
