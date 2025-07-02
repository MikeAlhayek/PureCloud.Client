using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowExecutionAggregationQueryGroupByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Divisionid for "divisionId"
    /// </summary>
    [EnumMember(Value = "divisionId")]
    Divisionid,

    /// <summary>
    /// Enum Flowid for "flowId"
    /// </summary>
    [EnumMember(Value = "flowId")]
    Flowid,

    /// <summary>
    /// Enum Flowobjectid for "flowObjectId"
    /// </summary>
    [EnumMember(Value = "flowObjectId")]
    Flowobjectid,

    /// <summary>
    /// Enum Flowversion for "flowVersion"
    /// </summary>
    [EnumMember(Value = "flowVersion")]
    Flowversion
}
