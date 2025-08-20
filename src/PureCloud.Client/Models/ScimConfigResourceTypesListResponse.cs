namespace PureCloud.Client.Models;

/// <summary>
/// Defines a response for a list of SCIM resource types.
/// </summary>
public sealed class ScimConfigResourceTypesListResponse
{
    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    public IEnumerable<string> Schemas { get; set; }


    /// <summary>
    /// The total number of results.
    /// </summary>
    public long? TotalResults { get; set; }


    /// <summary>
    /// The 1-based index of the first result returned by this request. Add this to "itemsPerPage" when requesting the next page of results.
    /// </summary>
    public long? StartIndex { get; set; }


    /// <summary>
    /// The number of resources returned per page.
    /// </summary>
    public long? ItemsPerPage { get; set; }


    /// <summary>
    /// The list of requested resources.
    /// </summary>
    public IEnumerable<ScimConfigResourceType> Resources { get; set; }
}
