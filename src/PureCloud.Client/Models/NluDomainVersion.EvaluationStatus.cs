using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The evaluation status of the NLU domain version.
/// </summary>
/// <value>The evaluation status of the NLU domain version.</value>

public enum NluDomainVersionEvaluationStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unevaluated for "Unevaluated"
    /// </summary>
    [EnumMember(Value = "Unevaluated")]
    Unevaluated,

    /// <summary>
    /// Enum Evaluating for "Evaluating"
    /// </summary>
    [EnumMember(Value = "Evaluating")]
    Evaluating,

    /// <summary>
    /// Enum Evaluated for "Evaluated"
    /// </summary>
    [EnumMember(Value = "Evaluated")]
    Evaluated,

    /// <summary>
    /// Enum Error for "Error"
    /// </summary>
    [EnumMember(Value = "Error")]
    Error
}
