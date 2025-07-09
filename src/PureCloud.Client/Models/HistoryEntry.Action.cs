using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum HistoryEntryActionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Checkin for "CHECKIN"
    /// </summary>
    [EnumMember(Value = "CHECKIN")]
    Checkin,

    /// <summary>
    /// Enum Checkout for "CHECKOUT"
    /// </summary>
    [EnumMember(Value = "CHECKOUT")]
    Checkout,

    /// <summary>
    /// Enum Create for "CREATE"
    /// </summary>
    [EnumMember(Value = "CREATE")]
    Create,

    /// <summary>
    /// Enum Deactivate for "DEACTIVATE"
    /// </summary>
    [EnumMember(Value = "DEACTIVATE")]
    Deactivate,

    /// <summary>
    /// Enum Debug for "DEBUG"
    /// </summary>
    [EnumMember(Value = "DEBUG")]
    Debug,

    /// <summary>
    /// Enum Delete for "DELETE"
    /// </summary>
    [EnumMember(Value = "DELETE")]
    Delete,

    /// <summary>
    /// Enum Publish for "PUBLISH"
    /// </summary>
    [EnumMember(Value = "PUBLISH")]
    Publish,

    /// <summary>
    /// Enum Revert for "REVERT"
    /// </summary>
    [EnumMember(Value = "REVERT")]
    Revert,

    /// <summary>
    /// Enum Save for "SAVE"
    /// </summary>
    [EnumMember(Value = "SAVE")]
    Save,

    /// <summary>
    /// Enum Transcode for "TRANSCODE"
    /// </summary>
    [EnumMember(Value = "TRANSCODE")]
    Transcode,

    /// <summary>
    /// Enum Update for "UPDATE"
    /// </summary>
    [EnumMember(Value = "UPDATE")]
    Update,

    /// <summary>
    /// Enum Upload for "UPLOAD"
    /// </summary>
    [EnumMember(Value = "UPLOAD")]
    Upload
}
