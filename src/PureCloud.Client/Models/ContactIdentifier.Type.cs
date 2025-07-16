using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContactIdentifierTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Socialline for "SocialLine"
    /// </summary>
    [EnumMember(Value = "SocialLine")]
    Socialline,

    /// <summary>
    /// Enum Socialfacebook for "SocialFacebook"
    /// </summary>
    [EnumMember(Value = "SocialFacebook")]
    Socialfacebook,

    /// <summary>
    /// Enum Socialtwitter for "SocialTwitter"
    /// </summary>
    [EnumMember(Value = "SocialTwitter")]
    Socialtwitter,

    /// <summary>
    /// Enum Socialwhatsapp for "SocialWhatsapp"
    /// </summary>
    [EnumMember(Value = "SocialWhatsapp")]
    Socialwhatsapp,

    /// <summary>
    /// Enum Socialinstagram for "SocialInstagram"
    /// </summary>
    [EnumMember(Value = "SocialInstagram")]
    Socialinstagram,

    /// <summary>
    /// Enum Email for "Email"
    /// </summary>
    [EnumMember(Value = "Email")]
    Email,

    /// <summary>
    /// Enum Phone for "Phone"
    /// </summary>
    [EnumMember(Value = "Phone")]
    Phone,

    /// <summary>
    /// Enum Cookie for "Cookie"
    /// </summary>
    [EnumMember(Value = "Cookie")]
    Cookie,

    /// <summary>
    /// Enum Externalid for "ExternalId"
    /// </summary>
    [EnumMember(Value = "ExternalId")]
    Externalid
}
