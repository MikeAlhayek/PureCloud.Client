using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Indicates the content type for this message
/// </summary>
/// <value>Indicates the content type for this message</value>

public enum RecordingMessagingMessageContentType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Quickreply for "QuickReply"
    /// </summary>
    [EnumMember(Value = "QuickReply")]
    Quickreply,

    /// <summary>
    /// Enum Story for "Story"
    /// </summary>
    [EnumMember(Value = "Story")]
    Story,

    /// <summary>
    /// Enum Card for "Card"
    /// </summary>
    [EnumMember(Value = "Card")]
    Card,

    /// <summary>
    /// Enum Carousel for "Carousel"
    /// </summary>
    [EnumMember(Value = "Carousel")]
    Carousel,

    /// <summary>
    /// Enum Attachment for "Attachment"
    /// </summary>
    [EnumMember(Value = "Attachment")]
    Attachment,

    /// <summary>
    /// Enum Location for "Location"
    /// </summary>
    [EnumMember(Value = "Location")]
    Location,

    /// <summary>
    /// Enum Notification for "Notification"
    /// </summary>
    [EnumMember(Value = "Notification")]
    Notification,

    /// <summary>
    /// Enum Generictemplate for "GenericTemplate"
    /// </summary>
    [EnumMember(Value = "GenericTemplate")]
    Generictemplate,

    /// <summary>
    /// Enum Listtemplate for "ListTemplate"
    /// </summary>
    [EnumMember(Value = "ListTemplate")]
    Listtemplate,

    /// <summary>
    /// Enum Postback for "Postback"
    /// </summary>
    [EnumMember(Value = "Postback")]
    Postback,

    /// <summary>
    /// Enum Reactions for "Reactions"
    /// </summary>
    [EnumMember(Value = "Reactions")]
    Reactions,

    /// <summary>
    /// Enum Mention for "Mention"
    /// </summary>
    [EnumMember(Value = "Mention")]
    Mention,

    /// <summary>
    /// Enum Buttonresponse for "ButtonResponse"
    /// </summary>
    [EnumMember(Value = "ButtonResponse")]
    Buttonresponse,

    /// <summary>
    /// Enum Datepicker for "DatePicker"
    /// </summary>
    [EnumMember(Value = "DatePicker")]
    Datepicker
}
