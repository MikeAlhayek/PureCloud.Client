using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Status
/// </summary>

public enum EvaluationStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pending for "PENDING"
    /// </summary>
    [EnumMember(Value = "PENDING")]
    Pending,

    /// <summary>
    /// Enum Inprogress for "INPROGRESS"
    /// </summary>
    [EnumMember(Value = "INPROGRESS")]
    Inprogress,

    /// <summary>
    /// Enum Finished for "FINISHED"
    /// </summary>
    [EnumMember(Value = "FINISHED")]
    Finished,

    /// <summary>
    /// Enum Inreview for "INREVIEW"
    /// </summary>
    [EnumMember(Value = "INREVIEW")]
    Inreview,

    /// <summary>
    /// Enum Retracted for "RETRACTED"
    /// </summary>
    [EnumMember(Value = "RETRACTED")]
    Retracted
}
