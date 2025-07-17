using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// the quality evaluation score status
/// </summary>
/// <value>the quality evaluation score status</value>

public enum AttendanceStatusHasEvaluationEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Hasqualityevaluation for "HasQualityEvaluation"
    /// </summary>
    [EnumMember(Value = "HasQualityEvaluation")]
    Hasqualityevaluation,

    /// <summary>
    /// Enum Noqualityevaluation for "NoQualityEvaluation"
    /// </summary>
    [EnumMember(Value = "NoQualityEvaluation")]
    Noqualityevaluation
}
