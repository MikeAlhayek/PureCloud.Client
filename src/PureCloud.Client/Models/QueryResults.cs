using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueryResults
{
    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    public DomainEntityListingQueryResult Results { get; set; }

    /// <summary>
    /// Gets or Sets FacetInfo
    /// </summary>
    public QueryFacetInfo FacetInfo { get; set; }
}
