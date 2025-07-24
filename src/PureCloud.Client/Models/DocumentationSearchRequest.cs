using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public sealed class DocumentationSearchRequest
{
    /// <summary>
    /// The field in the resource that you want to sort the results by
    /// </summary>
    public string SortBy { get; set; }

    /// <summary>
    /// The number of results per page
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// The page of resources you want to retrieve
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// Multi-value sort order, list of multiple sort values
    /// </summary>
    public IEnumerable<SearchSort> Sort { get; set; }

    /// <summary>
    /// Gets or Sets Query
    /// </summary>
    public IEnumerable<DocumentationSearchCriteria> Query { get; set; }

    /// <summary>
    /// The sort order for results
    /// </summary>
    public DocumentationSearchRequestSortOrderEnum? SortOrder { get; set; }
}
