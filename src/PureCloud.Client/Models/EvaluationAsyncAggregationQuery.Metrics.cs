using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metrics
/// </summary>

public enum EvaluationAsyncAggregationQueryMetricsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nevaluations for "nEvaluations"
    /// </summary>
    [EnumMember(Value = "nEvaluations")]
    Nevaluations,

    /// <summary>
    /// Enum Nevaluationsdeleted for "nEvaluationsDeleted"
    /// </summary>
    [EnumMember(Value = "nEvaluationsDeleted")]
    Nevaluationsdeleted,

    /// <summary>
    /// Enum Nevaluationsrescored for "nEvaluationsRescored"
    /// </summary>
    [EnumMember(Value = "nEvaluationsRescored")]
    Nevaluationsrescored,

    /// <summary>
    /// Enum Ototalcriticalscore for "oTotalCriticalScore"
    /// </summary>
    [EnumMember(Value = "oTotalCriticalScore")]
    Ototalcriticalscore,

    /// <summary>
    /// Enum Ototalscore for "oTotalScore"
    /// </summary>
    [EnumMember(Value = "oTotalScore")]
    Ototalscore
}
