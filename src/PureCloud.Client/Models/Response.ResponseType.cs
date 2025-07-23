using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The response type represented by the response.
/// </summary>
public enum ResponseType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Messagingtemplate for "MessagingTemplate"
    /// </summary>
    [EnumMember(Value = "MessagingTemplate")]
    Messagingtemplate,

    /// <summary>
    /// Enum Campaignsmstemplate for "CampaignSmsTemplate"
    /// </summary>
    [EnumMember(Value = "CampaignSmsTemplate")]
    Campaignsmstemplate,

    /// <summary>
    /// Enum Campaignemailtemplate for "CampaignEmailTemplate"
    /// </summary>
    [EnumMember(Value = "CampaignEmailTemplate")]
    Campaignemailtemplate,

    /// <summary>
    /// Enum Footer for "Footer"
    /// </summary>
    [EnumMember(Value = "Footer")]
    Footer
}