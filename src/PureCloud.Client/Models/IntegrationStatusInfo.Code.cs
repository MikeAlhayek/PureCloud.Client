using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum IntegrationStatusInfoCodeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Active for "ACTIVE"
    /// </summary>
    [EnumMember(Value = "ACTIVE")]
    Active,

    /// <summary>
    /// Enum Activating for "ACTIVATING"
    /// </summary>
    [EnumMember(Value = "ACTIVATING")]
    Activating,

    /// <summary>
    /// Enum Inactive for "INACTIVE"
    /// </summary>
    [EnumMember(Value = "INACTIVE")]
    Inactive,

    /// <summary>
    /// Enum Deactivating for "DEACTIVATING"
    /// </summary>
    [EnumMember(Value = "DEACTIVATING")]
    Deactivating,

    /// <summary>
    /// Enum Error for "ERROR"
    /// </summary>
    [EnumMember(Value = "ERROR")]
    Error
}
