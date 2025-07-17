using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ReplacementTermTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Name for "NAME"
    /// </summary>
    [EnumMember(Value = "NAME")]
    Name,

    /// <summary>
    /// Enum Address for "ADDRESS"
    /// </summary>
    [EnumMember(Value = "ADDRESS")]
    Address,

    /// <summary>
    /// Enum Phone for "PHONE"
    /// </summary>
    [EnumMember(Value = "PHONE")]
    Phone,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    [EnumMember(Value = "EMAIL")]
    Email,

    /// <summary>
    /// Enum Twitter for "TWITTER"
    /// </summary>
    [EnumMember(Value = "TWITTER")]
    Twitter,

    /// <summary>
    /// Enum Facebook for "FACEBOOK"
    /// </summary>
    [EnumMember(Value = "FACEBOOK")]
    Facebook,

    /// <summary>
    /// Enum Instagram for "INSTAGRAM"
    /// </summary>
    [EnumMember(Value = "INSTAGRAM")]
    Instagram
}
