using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueryRequest
{
    /// <summary>
    /// Gets or Sets QueryPhrase
    /// </summary>
    public string QueryPhrase { get; set; }

    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets FacetNameRequests
    /// </summary>
    public IEnumerable<string> FacetNameRequests { get; set; }

    /// <summary>
    /// Gets or Sets Sort
    /// </summary>
    public IEnumerable<SortItem> Sort { get; set; }

    /// <summary>
    /// Gets or Sets Filters
    /// </summary>
    public IEnumerable<ContentFilterItem> Filters { get; set; }

    /// <summary>
    /// Gets or Sets AttributeFilters
    /// </summary>
    public IEnumerable<AttributeFilterItem> AttributeFilters { get; set; }

    /// <summary>
    /// Gets or Sets IncludeShares
    /// </summary>
    public bool? IncludeShares { get; set; }
}
