namespace PureCloud.Client.Models;

/// <summary>
/// SipSearchResult
/// </summary>
public sealed class SipSearchResult
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Status of the search request.
    /// </summary>
    public int? Status { get; set; }

    /// <summary>
    /// Session id associated to the search request.
    /// </summary>
    public string Sid { get; set; }

    /// <summary>
    /// Auth token used for this search request.
    /// </summary>
    public string Auth { get; set; }

    /// <summary>
    /// Any messages returned from homer as part of the response.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Homer search data that is returned.
    /// </summary>
    public IEnumerable<HomerRecord> Data { get; set; }

    /// <summary>
    /// Number of records returned.
    /// </summary>
    public int? Count { get; set; }

    /// <summary>
    /// The URI for this object.
    /// </summary>
    public string SelfUri { get; set; }
}
