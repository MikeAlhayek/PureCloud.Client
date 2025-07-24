using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The PATCH operation to perform.
/// </summary>
public enum ScimV2PatchOperationOpEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Add for "add"
    /// </summary>
    [EnumMember(Value = "add")]
    Add,

    /// <summary>
    /// Enum Replace for "replace"
    /// </summary>
    [EnumMember(Value = "replace")]
    Replace,

    /// <summary>
    /// Enum Remove for "remove"
    /// </summary>
    [EnumMember(Value = "remove")]
    Remove
}
