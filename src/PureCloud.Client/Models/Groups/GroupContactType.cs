using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Groups;

public enum GroupContactType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Groupring for "GROUPRING"
    /// </summary>
    [EnumMember(Value = "GROUPRING")]
    Groupring,

    /// <summary>
    /// Enum Groupphone for "GROUPPHONE"
    /// </summary>
    [EnumMember(Value = "GROUPPHONE")]
    Groupphone,
}
