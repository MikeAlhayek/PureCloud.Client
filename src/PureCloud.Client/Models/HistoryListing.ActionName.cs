using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum HistoryListingActionNameEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Create for "CREATE"
    /// </summary>
    [EnumMember(Value = "CREATE")]
    Create,

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
    /// Enum History for "HISTORY"
    /// </summary>
    [EnumMember(Value = "HISTORY")]
    History,

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
    /// Enum StateChange for "STATE_CHANGE"
    /// </summary>
    [EnumMember(Value = "STATE_CHANGE")]
    StateChange,

    /// <summary>
    /// Enum Update for "UPDATE"
    /// </summary>
    [EnumMember(Value = "UPDATE")]
    Update,

    /// <summary>
    /// Enum Validate for "VALIDATE"
    /// </summary>
    [EnumMember(Value = "VALIDATE")]
    Validate
}
