namespace PureCloud.Client.Models.Users;

public class SearchRequest
{
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
    public List<SearchSort> Sort { get; set; }

    /// <summary>
    /// The sort order for results
    /// </summary>
    /// <value>The sort order for results</value>
    public SortOrderType? SortOrder { get; set; }
    /// <summary>
    /// Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \"expand\". When using this parameter the maximum number of users that can be returned is 100.
    /// </summary>
    /// <value>Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \"expand\". When using this parameter the maximum number of users that can be returned is 100.</value>
    public IntegrationPresenceSource? IntegrationPresenceSource { get; set; }

    /// <summary>
    /// Provides more details about a specified resource
    /// </summary>
    /// <value>Provides more details about a specified resource</value>
    public List<string> Expand { get; set; }

    /// <summary>
    /// Gets or Sets Query
    /// </summary>
    public List<SearchCriteria> Query { get; set; }
}
