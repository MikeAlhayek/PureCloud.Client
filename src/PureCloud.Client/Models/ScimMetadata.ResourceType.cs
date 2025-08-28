using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of SCIM resource.
/// </summary>
public enum ScimMetadataResourceTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum User for "User"
    /// </summary>
    [EnumMember(Value = "User")]
    User,

    /// <summary>
    /// Enum Group for "Group"
    /// </summary>
    [EnumMember(Value = "Group")]
    Group,

    /// <summary>
    /// Enum Serviceproviderconfig for "ServiceProviderConfig"
    /// </summary>
    [EnumMember(Value = "ServiceProviderConfig")]
    Serviceproviderconfig,

    /// <summary>
    /// Enum Resourcetype for "ResourceType"
    /// </summary>
    [EnumMember(Value = "ResourceType")]
    Resourcetype,

    /// <summary>
    /// Enum Schema for "Schema"
    /// </summary>
    [EnumMember(Value = "Schema")]
    Schema
}
