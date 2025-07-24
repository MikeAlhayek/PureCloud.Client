namespace PureCloud.Client.Models;

/// <summary>
/// Defines a response for a list of SCIM users.
/// </summary>
public sealed class ScimUserListResponse
{
    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    public IEnumerable<string> Schemas { get; set; }

    /// <summary>
    /// The total number of results.
    /// </summary>
    /// <value>The total number of results.</value>
    public long? TotalResults { get; set; }

    /// <summary>
    /// The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results.
    /// </summary>
    /// <value>The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results.</value>
    public long? StartIndex { get; set; }

    /// <summary>
    /// The number of resources returned per page.
    /// </summary>
    /// <value>The number of resources returned per page.</value>
    public long? ItemsPerPage { get; set; }

    /// <summary>
    /// The list of requested resources. If \&quot;count\&quot; is 0, then the list will be empty.
    /// </summary>
    /// <value>The list of requested resources. If \&quot;count\&quot; is 0, then the list will be empty.</value>
    public IEnumerable<ScimV2User> Resources { get; set; }
}
