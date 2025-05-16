using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Operation
/// </summary>

public enum WorkitemsUserEventsNotificationWorkitemOperationEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "unknown"
    /// </summary>
    [EnumMember(Value = "unknown")]
    Unknown,

    /// <summary>
    /// Enum Add for "add"
    /// </summary>
    [EnumMember(Value = "add")]
    Add,

    /// <summary>
    /// Enum Edit for "edit"
    /// </summary>
    [EnumMember(Value = "edit")]
    Edit,

    /// <summary>
    /// Enum Delete for "delete"
    /// </summary>
    [EnumMember(Value = "delete")]
    Delete,

    /// <summary>
    /// Enum View for "view"
    /// </summary>
    [EnumMember(Value = "view")]
    View,

    /// <summary>
    /// Enum Upload for "upload"
    /// </summary>
    [EnumMember(Value = "upload")]
    Upload,

    /// <summary>
    /// Enum Download for "download"
    /// </summary>
    [EnumMember(Value = "download")]
    Download,

    /// <summary>
    /// Enum Activate for "activate"
    /// </summary>
    [EnumMember(Value = "activate")]
    Activate,

    /// <summary>
    /// Enum Deactivate for "deactivate"
    /// </summary>
    [EnumMember(Value = "deactivate")]
    Deactivate,

    /// <summary>
    /// Enum Purge for "purge"
    /// </summary>
    [EnumMember(Value = "purge")]
    Purge,

    /// <summary>
    /// Enum Processed for "processed"
    /// </summary>
    [EnumMember(Value = "processed")]
    Processed,

    /// <summary>
    /// Enum Published for "published"
    /// </summary>
    [EnumMember(Value = "published")]
    Published,

    /// <summary>
    /// Enum Assigned for "assigned"
    /// </summary>
    [EnumMember(Value = "assigned")]
    Assigned,

    /// <summary>
    /// Enum Unassigned for "unassigned"
    /// </summary>
    [EnumMember(Value = "unassigned")]
    Unassigned,

    /// <summary>
    /// Enum Reset for "reset"
    /// </summary>
    [EnumMember(Value = "reset")]
    Reset,

    /// <summary>
    /// Enum Reassigned for "reassigned"
    /// </summary>
    [EnumMember(Value = "reassigned")]
    Reassigned,

    /// <summary>
    /// Enum Reassign for "reassign"
    /// </summary>
    [EnumMember(Value = "reassign")]
    Reassign,

    /// <summary>
    /// Enum Archive for "archive"
    /// </summary>
    [EnumMember(Value = "archive")]
    Archive,

    /// <summary>
    /// Enum Unarchive for "unarchive"
    /// </summary>
    [EnumMember(Value = "unarchive")]
    Unarchive,

    /// <summary>
    /// Enum Reschedule for "reschedule"
    /// </summary>
    [EnumMember(Value = "reschedule")]
    Reschedule
}
