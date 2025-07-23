namespace PureCloud.Client.Models;

/// <summary>
/// BatchDownloadJobStatusResult
/// </summary>
public sealed class BatchDownloadJobStatusResult
{
    /// <summary>
    /// Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.
    /// </summary>
    public BatchDownloadJobStatus? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// JobId returned when job was initially submitted.
    /// </summary>
    public string JobId { get; set; }

    /// <summary>
    /// Number of results expected when job is completed, this includes both success and error results. This number could change as recordings are being discovered and processed.
    /// </summary>
    public int? ExpectedResultCount { get; set; }

    /// <summary>
    /// Current number of results available, this includes both success and error results.
    /// </summary>
    public int? ResultCount { get; set; }

    /// <summary>
    /// Current number of error results.
    /// </summary>
    public int? ErrorCount { get; set; }

    /// <summary>
    /// Current set of results for the job.
    /// </summary>
    public IEnumerable<BatchDownloadJobResult> Results { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}