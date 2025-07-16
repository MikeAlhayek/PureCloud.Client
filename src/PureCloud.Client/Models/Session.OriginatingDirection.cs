using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum SessionOriginatingDirectionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Inbound for "Inbound"
    /// </summary>
    [EnumMember(Value = "Inbound")]
    Inbound,

    /// <summary>
    /// Enum Outbound for "Outbound"
    /// </summary>
    [EnumMember(Value = "Outbound")]
    Outbound
}
