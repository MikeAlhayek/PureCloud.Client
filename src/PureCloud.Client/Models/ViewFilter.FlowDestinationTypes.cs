using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets FlowDestinationTypes
/// </summary>

public enum ViewFilterFlowDestinationTypesEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Acd for "ACD"
    /// </summary>
    [EnumMember(Value = "ACD")]
    Acd,

    /// <summary>
    /// Enum User for "USER"
    /// </summary>
    [EnumMember(Value = "USER")]
    User,

    /// <summary>
    /// Enum Group for "GROUP"
    /// </summary>
    [EnumMember(Value = "GROUP")]
    Group,

    /// <summary>
    /// Enum Number for "NUMBER"
    /// </summary>
    [EnumMember(Value = "NUMBER")]
    Number,

    /// <summary>
    /// Enum Flow for "FLOW"
    /// </summary>
    [EnumMember(Value = "FLOW")]
    Flow,

    /// <summary>
    /// Enum SecureFlow for "SECURE_FLOW"
    /// </summary>
    [EnumMember(Value = "SECURE_FLOW")]
    SecureFlow,

    /// <summary>
    /// Enum AcdVoicemail for "ACD_VOICEMAIL"
    /// </summary>
    [EnumMember(Value = "ACD_VOICEMAIL")]
    AcdVoicemail,

    /// <summary>
    /// Enum UserVoicemail for "USER_VOICEMAIL"
    /// </summary>
    [EnumMember(Value = "USER_VOICEMAIL")]
    UserVoicemail,

    /// <summary>
    /// Enum GroupVoicemail for "GROUP_VOICEMAIL"
    /// </summary>
    [EnumMember(Value = "GROUP_VOICEMAIL")]
    GroupVoicemail,

    /// <summary>
    /// Enum ReturnToAgent for "RETURN_TO_AGENT"
    /// </summary>
    [EnumMember(Value = "RETURN_TO_AGENT")]
    ReturnToAgent
}
