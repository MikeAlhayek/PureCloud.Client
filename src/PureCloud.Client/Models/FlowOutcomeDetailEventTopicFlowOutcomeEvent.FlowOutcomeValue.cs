using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets FlowOutcomeValue
/// </summary>

public enum FlowOutcomeDetailEventTopicFlowOutcomeEventFlowOutcomeValueEnum
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
    /// Enum Success for "SUCCESS"
    /// </summary>
    [EnumMember(Value = "SUCCESS")]
    Success,

    /// <summary>
    /// Enum Failure for "FAILURE"
    /// </summary>
    [EnumMember(Value = "FAILURE")]
    Failure
}
