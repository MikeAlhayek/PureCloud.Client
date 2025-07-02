using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Sets the role when viewing agent evaluations
/// </summary>
/// <value>Sets the role when viewing agent evaluations</value>

public enum ViewFilterEvaluationRoleEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Evaluator for "Evaluator"
    /// </summary>
    [EnumMember(Value = "Evaluator")]
    Evaluator,

    /// <summary>
    /// Enum Supervisor for "Supervisor"
    /// </summary>
    [EnumMember(Value = "Supervisor")]
    Supervisor
}
