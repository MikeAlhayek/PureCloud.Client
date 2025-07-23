using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause
/// </summary>
public enum AnnotationReason
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Hold for "Hold"
    /// </summary>
    [EnumMember(Value = "Hold")]
    Hold,

    /// <summary>
    /// Enum Securepause for "SecurePause"
    /// </summary>
    [EnumMember(Value = "SecurePause")]
    Securepause,

    /// <summary>
    /// Enum Floworqueue for "FlowOrQueue"
    /// </summary>
    [EnumMember(Value = "FlowOrQueue")]
    Floworqueue,

    /// <summary>
    /// Enum Pause for "Pause"
    /// </summary>
    [EnumMember(Value = "Pause")]
    Pause
}