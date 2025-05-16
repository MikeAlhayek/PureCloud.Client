using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CreateGeneralProgramTestPhraseMatchedTranscriptMediaTypeEnum
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
    /// Enum Call for "call"
    /// </summary>
    [EnumMember(Value = "call")]
    Call,

    /// <summary>
    /// Enum Message for "message"
    /// </summary>
    [EnumMember(Value = "message")]
    Message,

    /// <summary>
    /// Enum Email for "email"
    /// </summary>
    [EnumMember(Value = "email")]
    Email,

    /// <summary>
    /// Enum Chat for "chat"
    /// </summary>
    [EnumMember(Value = "chat")]
    Chat,

    /// <summary>
    /// Enum Callback for "callback"
    /// </summary>
    [EnumMember(Value = "callback")]
    Callback,

    /// <summary>
    /// Enum All for "all"
    /// </summary>
    [EnumMember(Value = "all")]
    All
}
