using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets ExitReason
/// </summary>

public enum FlowEndDetailEventTopicFlowEndEventExitReasonEnum
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
    /// Enum Disconnect for "DISCONNECT"
    /// </summary>
    [EnumMember(Value = "DISCONNECT")]
    Disconnect,

    /// <summary>
    /// Enum FlowDisconnect for "FLOW_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "FLOW_DISCONNECT")]
    FlowDisconnect,

    /// <summary>
    /// Enum FlowErrorDisconnect for "FLOW_ERROR_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "FLOW_ERROR_DISCONNECT")]
    FlowErrorDisconnect,

    /// <summary>
    /// Enum Transfer for "TRANSFER"
    /// </summary>
    [EnumMember(Value = "TRANSFER")]
    Transfer,

    /// <summary>
    /// Enum SessionExpireDisconnect for "SESSION_EXPIRE_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "SESSION_EXPIRE_DISCONNECT")]
    SessionExpireDisconnect,

    /// <summary>
    /// Enum RecognitionFailureDisconnect for "RECOGNITION_FAILURE_DISCONNECT"
    /// </summary>
    [EnumMember(Value = "RECOGNITION_FAILURE_DISCONNECT")]
    RecognitionFailureDisconnect,

    /// <summary>
    /// Enum RecognitionFailureExit for "RECOGNITION_FAILURE_EXIT"
    /// </summary>
    [EnumMember(Value = "RECOGNITION_FAILURE_EXIT")]
    RecognitionFailureExit,

    /// <summary>
    /// Enum UserExit for "USER_EXIT"
    /// </summary>
    [EnumMember(Value = "USER_EXIT")]
    UserExit,

    /// <summary>
    /// Enum FlowExit for "FLOW_EXIT"
    /// </summary>
    [EnumMember(Value = "FLOW_EXIT")]
    FlowExit,

    /// <summary>
    /// Enum FlowErrorExit for "FLOW_ERROR_EXIT"
    /// </summary>
    [EnumMember(Value = "FLOW_ERROR_EXIT")]
    FlowErrorExit
}
