using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ReportingDataExportTopicDataExportNotificationStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Submitted for "SUBMITTED"
    /// </summary>
    [EnumMember(Value = "SUBMITTED")]
    Submitted,

    /// <summary>
    /// Enum Running for "RUNNING"
    /// </summary>
    [EnumMember(Value = "RUNNING")]
    Running,

    /// <summary>
    /// Enum Cancelling for "CANCELLING"
    /// </summary>
    [EnumMember(Value = "CANCELLING")]
    Cancelling,

    /// <summary>
    /// Enum Cancelled for "CANCELLED"
    /// </summary>
    [EnumMember(Value = "CANCELLED")]
    Cancelled,

    /// <summary>
    /// Enum Completed for "COMPLETED"
    /// </summary>
    [EnumMember(Value = "COMPLETED")]
    Completed,

    /// <summary>
    /// Enum CompletedWithPartialResults for "COMPLETED_WITH_PARTIAL_RESULTS"
    /// </summary>
    [EnumMember(Value = "COMPLETED_WITH_PARTIAL_RESULTS")]
    CompletedWithPartialResults,

    /// <summary>
    /// Enum Failed for "FAILED"
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed
}
