using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metrics
/// </summary>

public enum FlowAggregationQueryMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nflow for "nFlow"
    /// </summary>
    [EnumMember(Value = "nFlow")]
    Nflow,

    /// <summary>
    /// Enum Nflowmilestone for "nFlowMilestone"
    /// </summary>
    [EnumMember(Value = "nFlowMilestone")]
    Nflowmilestone,

    /// <summary>
    /// Enum Nflowoutcome for "nFlowOutcome"
    /// </summary>
    [EnumMember(Value = "nFlowOutcome")]
    Nflowoutcome,

    /// <summary>
    /// Enum Nflowoutcomefailed for "nFlowOutcomeFailed"
    /// </summary>
    [EnumMember(Value = "nFlowOutcomeFailed")]
    Nflowoutcomefailed,

    /// <summary>
    /// Enum Oflowmilestone for "oFlowMilestone"
    /// </summary>
    [EnumMember(Value = "oFlowMilestone")]
    Oflowmilestone,

    /// <summary>
    /// Enum Tflow for "tFlow"
    /// </summary>
    [EnumMember(Value = "tFlow")]
    Tflow,

    /// <summary>
    /// Enum Tflowdisconnect for "tFlowDisconnect"
    /// </summary>
    [EnumMember(Value = "tFlowDisconnect")]
    Tflowdisconnect,

    /// <summary>
    /// Enum Tflowexit for "tFlowExit"
    /// </summary>
    [EnumMember(Value = "tFlowExit")]
    Tflowexit,

    /// <summary>
    /// Enum Tflowoutcome for "tFlowOutcome"
    /// </summary>
    [EnumMember(Value = "tFlowOutcome")]
    Tflowoutcome
}
