using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets AcdOutcome
/// </summary>

public enum AcdEndDetailEventTopicAcdEndEventAcdOutcomeEnum
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
    /// Enum Abandon for "ABANDON"
    /// </summary>
    [EnumMember(Value = "ABANDON")]
    Abandon,

    /// <summary>
    /// Enum Answered for "ANSWERED"
    /// </summary>
    [EnumMember(Value = "ANSWERED")]
    Answered,

    /// <summary>
    /// Enum FlowOut for "FLOW_OUT"
    /// </summary>
    [EnumMember(Value = "FLOW_OUT")]
    FlowOut
}
