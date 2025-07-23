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
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Hold for "Hold"
    /// </summary>
    Hold,

    /// <summary>
    /// Enum Securepause for "SecurePause"
    /// </summary>
    Securepause,

    /// <summary>
    /// Enum Floworqueue for "FlowOrQueue"
    /// </summary>
    Floworqueue,

    /// <summary>
    /// Enum Pause for "Pause"
    /// </summary>
    Pause
}