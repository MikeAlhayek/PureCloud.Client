using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ExternalContactTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Ephemeral for "Ephemeral"
    /// </summary>
    [EnumMember(Value = "Ephemeral")]
    Ephemeral,

    /// <summary>
    /// Enum Identified for "Identified"
    /// </summary>
    [EnumMember(Value = "Identified")]
    Identified,

    /// <summary>
    /// Enum Curated for "Curated"
    /// </summary>
    [EnumMember(Value = "Curated")]
    Curated
}
