using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Greeting owner type
/// </summary>
/// <value>Greeting owner type</value>

public enum GreetingOwnerTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum User for "USER"
    /// </summary>
    [EnumMember(Value = "USER")]
    User,

    /// <summary>
    /// Enum Organization for "ORGANIZATION"
    /// </summary>
    [EnumMember(Value = "ORGANIZATION")]
    Organization,

    /// <summary>
    /// Enum Group for "GROUP"
    /// </summary>
    [EnumMember(Value = "GROUP")]
    Group
}
