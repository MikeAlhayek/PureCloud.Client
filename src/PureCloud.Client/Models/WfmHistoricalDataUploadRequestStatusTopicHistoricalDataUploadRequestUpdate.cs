using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdateStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdateTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets RequestId
    /// </summary>
    public string RequestId { get; set; }

    /// <summary>
    /// Gets or Sets DateImportStarted
    /// </summary>
    public DateTime? DateImportStarted { get; set; }

    /// <summary>
    /// Gets or Sets DateImportEnded
    /// </summary>
    public DateTime? DateImportEnded { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    public string Error { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets FileName
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Gets or Sets FileSize
    /// </summary>
    public long? FileSize { get; set; }
}
