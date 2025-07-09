using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowResultEntityListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<FlowExecutionDataQueryResult> Entities { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets PageNumber
    public int? PageNumber { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets FirstUri
    /// </summary>
    public string FirstUri { get; set; }

    /// <summary>
    /// Gets or Sets LastUri
    /// </summary>
    public string LastUri { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    public string NextUri { get; set; }

    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    public string PreviousUri { get; set; }

    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    public int? PageCount { get; set; }
}
