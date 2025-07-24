using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class ResponseAssetSearchRequest
{
    /// <summary>
    /// The sort order for results
    /// </summary>
    /// <value>The sort order for results</value>
    public ResponseAssetSearchRequestSortOrder? SortOrder { get; set; }

    /// <summary>
    /// The number of results per page. Default: 25, Maximum: 100.
    /// </summary>
    /// <value>The number of results per page. Default: 25, Maximum: 100.</value>
    public int? PageSize { get; set; }

    /// <summary>
    /// The page of resources you want to retrieve
    /// </summary>
    /// <value>The page of resources you want to retrieve</value>
    public int? PageNumber { get; set; }

    /// <summary>
    /// The field in the resource that you want to sort the results by
    /// </summary>
    /// <value>The field in the resource that you want to sort the results by</value>
    public string SortBy { get; set; }

    /// <summary>
    /// Filter the query results.
    /// </summary>
    /// <value>Filter the query results.</value>
    public IEnumerable<ResponseAssetFilter> Query { get; set; }
}
