using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EntityType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Person for "person"
    /// </summary>
    [EnumMember(Value = "person")]
    Person,

    /// <summary>
    /// Enum Group for "group"
    /// </summary>
    [EnumMember(Value = "group")]
    Group,

    /// <summary>
    /// Enum Org for "org"
    /// </summary>
    [EnumMember(Value = "org")]
    Org,
}
