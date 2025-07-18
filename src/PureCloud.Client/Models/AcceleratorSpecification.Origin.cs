using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AcceleratorSpecificationOriginEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Community for "Community"
    /// </summary>
    [EnumMember(Value = "Community")]
    Community,

    /// <summary>
    /// Enum Partner for "Partner"
    /// </summary>
    [EnumMember(Value = "Partner")]
    Partner,

    /// <summary>
    /// Enum Genesys for "Genesys"
    /// </summary>
    [EnumMember(Value = "Genesys")]
    Genesys
}
