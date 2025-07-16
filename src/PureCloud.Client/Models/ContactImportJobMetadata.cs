using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactImportJobMetadata
{
    /// <summary>
    /// Gets or Sets FileName
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Gets or Sets DryRunFailedCount
    /// </summary>
    public int? DryRunFailedCount { get; set; }

    /// <summary>
    /// Gets or Sets DryRunSuccessCount
    /// </summary>
    public int? DryRunSuccessCount { get; set; }

    /// <summary>
    /// Gets or Sets DryRunReportDownloadUrl
    /// </summary>
    public string DryRunReportDownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets ImportFailedCount
    /// </summary>
    public int? ImportFailedCount { get; set; }

    /// <summary>
    /// Gets or Sets ImportSuccessCount
    /// </summary>
    public int? ImportSuccessCount { get; set; }

    /// <summary>
    /// Gets or Sets ImportReportDownloadUrl
    /// </summary>
    public string ImportReportDownloadUrl { get; set; }
}
