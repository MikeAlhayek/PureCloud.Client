using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FacetEntry
{
    /// <summary>
    /// Gets or Sets TermType
    /// </summary>
    public FacetEntryTermTypeEnum? TermType { get; set; }

    /// <summary>
    /// Gets or Sets Attribute
    /// </summary>
    public TermAttribute Attribute { get; set; }

    /// <summary>
    /// Gets or Sets Statistics
    /// </summary>
    public FacetStatistics Statistics { get; set; }

    /// <summary>
    /// Gets or Sets Other
    /// </summary>
    public long? Other { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets Missing
    /// </summary>
    public long? Missing { get; set; }

    /// <summary>
    /// Gets or Sets TermCount
    /// </summary>
    public int? TermCount { get; set; }

    /// <summary>
    /// Gets or Sets Terms
    /// </summary>
    public IEnumerable<FacetTerm> Terms { get; set; }
}
