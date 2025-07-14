using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueryFacetInfo
{
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    public IEnumerable<FacetKeyAttribute> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets Facets
    /// </summary>
    public IEnumerable<FacetEntry> Facets { get; set; }
}
