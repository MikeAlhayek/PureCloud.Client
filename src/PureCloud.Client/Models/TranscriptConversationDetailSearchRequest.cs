using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TranscriptConversationDetailSearchRequest
{
    /// <summary>
    /// The sort order for results
    /// </summary>
    /// <value>The sort order for results</value>
    public TranscriptConversationDetailSearchRequestSortOrderEnum? SortOrder { get; set; }

    /// <summary>
    /// The field in the resource that you want to sort the results by
    /// </summary>
    /// <value>The field in the resource that you want to sort the results by</value>
    public string SortBy { get; set; }

    /// <summary>
    /// The number of results per page
    /// </summary>
    /// <value>The number of results per page</value>
    public int? PageSize { get; set; }

    /// <summary>
    /// The page of resources you want to retrieve
    /// </summary>
    /// <value>The page of resources you want to retrieve</value>
    public int? PageNumber { get; set; }

    /// <summary>
    /// Multi-value sort order, list of multiple sort values
    /// </summary>
    /// <value>Multi-value sort order, list of multiple sort values</value>
    public IEnumerable<SearchSort> Sort { get; set; }

    /// <summary>
    /// Resource domain type to search
    /// </summary>
    /// <value>Resource domain type to search</value>
    public IEnumerable<string> Types { get; set; }

    /// <summary>
    /// The search criteria
    /// </summary>
    /// <value>The search criteria</value>
    public IEnumerable<TranscriptConversationDetailSearchCriteria> Query { get; set; }
}
