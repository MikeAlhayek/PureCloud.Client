namespace PureCloud.Client.Models;

public sealed class GetUploadSourceUrlJobStatusResponse
{
    /// <summary>
    /// Id of the upload from URL job.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Status of the upload job
    /// </summary>
    public GetUploadSourceUrlJobStatusResponseStatusEnum? Status { get; set; }

    /// <summary>
    /// Key that identifies the file in the storage including the file name
    /// </summary>
    public string UploadKey { get; set; }

    /// <summary>
    /// Any error information, or null of the processing is not in failed state.
    /// </summary>
    public ErrorBody ErrorInformation { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}