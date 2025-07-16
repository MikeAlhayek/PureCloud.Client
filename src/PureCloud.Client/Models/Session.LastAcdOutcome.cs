using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Last ACD outcome for the conversation.
/// </summary>
/// <value>Last ACD outcome for the conversation.</value>

public enum SessionLastAcdOutcomeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Abandon for "Abandon"
    /// </summary>
    [EnumMember(Value = "Abandon")]
    Abandon,

    /// <summary>
    /// Enum Answered for "Answered"
    /// </summary>
    [EnumMember(Value = "Answered")]
    Answered,

    /// <summary>
    /// Enum Flowout for "FlowOut"
    /// </summary>
    [EnumMember(Value = "FlowOut")]
    Flowout
}
