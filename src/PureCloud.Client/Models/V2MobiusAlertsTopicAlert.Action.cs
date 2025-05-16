using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2MobiusAlertsTopicAlertActionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum Create for "CREATE"
    /// </summary>
    [EnumMember(Value = "CREATE")]
    Create,

    /// <summary>
    /// Enum Update for "UPDATE"
    /// </summary>
    [EnumMember(Value = "UPDATE")]
    Update,

    /// <summary>
    /// Enum Delete for "DELETE"
    /// </summary>
    [EnumMember(Value = "DELETE")]
    Delete,

    /// <summary>
    /// Enum Close for "CLOSE"
    /// </summary>
    [EnumMember(Value = "CLOSE")]
    Close,

    /// <summary>
    /// Enum Renotify for "RENOTIFY"
    /// </summary>
    [EnumMember(Value = "RENOTIFY")]
    Renotify,

    /// <summary>
    /// Enum BulkDelete for "BULK_DELETE"
    /// </summary>
    [EnumMember(Value = "BULK_DELETE")]
    BulkDelete,

    /// <summary>
    /// Enum BulkUpdate for "BULK_UPDATE"
    /// </summary>
    [EnumMember(Value = "BULK_UPDATE")]
    BulkUpdate,

    /// <summary>
    /// Enum UnreadCountUpdate for "UNREAD_COUNT_UPDATE"
    /// </summary>
    [EnumMember(Value = "UNREAD_COUNT_UPDATE")]
    UnreadCountUpdate
}
