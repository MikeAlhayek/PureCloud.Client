using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Type of the evaluation source.
/// </summary>
/// <value>Type of the evaluation source.</value>

public enum EvaluationSourceType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Policy for "Policy"
    /// </summary>
    [EnumMember(Value = "Policy")]
    Policy,

    /// <summary>
    /// Enum User for "User"
    /// </summary>
    [EnumMember(Value = "User")]
    User,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
