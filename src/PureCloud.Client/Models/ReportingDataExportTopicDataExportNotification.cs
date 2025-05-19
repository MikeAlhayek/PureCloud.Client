using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public enum InnerEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Sent for "Sent"
    /// </summary>
    [EnumMember(Value = "Sent")]
    Sent,

    /// <summary>
    /// Enum Pending for "Pending"
    /// </summary>
    [EnumMember(Value = "Pending")]
    Pending,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed
}

public sealed class ReportingDataExportTopicDataExportNotification
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public ReportingDataExportTopicDataExportNotificationStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets ExportFormat
    /// </summary>
    public ReportingDataExportTopicDataExportNotificationExportFormatEnum? ExportFormat { get; set; }

    /// <summary>
    /// Gets or Sets ViewType
    /// </summary>
    public ReportingDataExportTopicDataExportNotificationViewTypeEnum? ViewType { get; set; }

    /// <summary>
    /// Gets or Sets ExportErrorMessagesType
    /// </summary>
    public ReportingDataExportTopicDataExportNotificationExportErrorMessagesTypeEnum? ExportErrorMessagesType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets RunId
    /// </summary>
    public Guid? RunId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    public bool? Read { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateTime
    /// </summary>
    public DateTime? CreatedDateTime { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDateTime
    /// </summary>
    public DateTime? ModifiedDateTime { get; set; }

    /// <summary>
    /// Gets or Sets PercentageComplete
    /// </summary>
    public double? PercentageComplete { get; set; }

    /// <summary>
    /// Gets or Sets EmailStatuses
    /// </summary>
    public Dictionary<string, string> EmailStatuses { get; set; }

    /// <summary>
    /// Gets or Sets EmailErrorDescription
    /// </summary>
    public string EmailErrorDescription { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleExpression
    /// </summary>
    public string ScheduleExpression { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleStaticLinkUrl
    /// </summary>
    public string ScheduleStaticLinkUrl { get; set; }

    /// <summary>
    /// Gets or Sets ExportAllowedToRerun
    /// </summary>
    public bool? ExportAllowedToRerun { get; set; }
}
