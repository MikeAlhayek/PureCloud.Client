using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets EvaluationStatuses
/// </summary>

public enum ViewFilterEvaluationStatusesEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Finished for "Finished"
    /// </summary>
    [EnumMember(Value = "Finished")]
    Finished,

    /// <summary>
    /// Enum Inprogress for "InProgress"
    /// </summary>
    [EnumMember(Value = "InProgress")]
    Inprogress,

    /// <summary>
    /// Enum Inreview for "InReview"
    /// </summary>
    [EnumMember(Value = "InReview")]
    Inreview,

    /// <summary>
    /// Enum Pending for "Pending"
    /// </summary>
    [EnumMember(Value = "Pending")]
    Pending,

    /// <summary>
    /// Enum Retracted for "Retracted"
    /// </summary>
    [EnumMember(Value = "Retracted")]
    Retracted
}
