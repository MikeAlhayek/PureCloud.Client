using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ApiUsageOrganizationQueryGroupByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Oauthclientid for "OAuthClientId"
    /// </summary>
    [EnumMember(Value = "OAuthClientId")]
    Oauthclientid,

    /// <summary>
    /// Enum Organizationid for "OrganizationId"
    /// </summary>
    [EnumMember(Value = "OrganizationId")]
    Organizationid,

    /// <summary>
    /// Enum Userid for "UserId"
    /// </summary>
    [EnumMember(Value = "UserId")]
    Userid,

    /// <summary>
    /// Enum Templateuri for "TemplateUri"
    /// </summary>
    [EnumMember(Value = "TemplateUri")]
    Templateuri,

    /// <summary>
    /// Enum Httpmethod for "HttpMethod"
    /// </summary>
    [EnumMember(Value = "HttpMethod")]
    Httpmethod
}