using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.
/// </summary>
/// <value>The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.</value>

public enum EvaluationResourceType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    [EnumMember(Value = "EMAIL")]
    Email
}
