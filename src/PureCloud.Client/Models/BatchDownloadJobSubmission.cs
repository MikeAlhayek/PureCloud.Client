namespace PureCloud.Client.Models;

/// <summary>
/// BatchDownloadJobSubmission
/// </summary>
public sealed class BatchDownloadJobSubmission
{
    /// <summary>
    /// List of up to 100 items requested
    /// </summary>
    public IEnumerable<BatchDownloadRequest> BatchDownloadRequestList { get; set; }
}