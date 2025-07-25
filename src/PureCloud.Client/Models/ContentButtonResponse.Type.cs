using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Describes the button that resulted in the Button Response.
/// </summary>
public enum ContentButtonResponseType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Button for "Button"
    /// </summary>
    [EnumMember(Value = "Button")]
    Button,

    /// <summary>
    /// Enum Quickreply for "QuickReply"
    /// </summary>
    [EnumMember(Value = "QuickReply")]
    Quickreply,

    /// <summary>
    /// Enum Datepicker for "DatePicker"
    /// </summary>
    [EnumMember(Value = "DatePicker")]
    Datepicker
}
