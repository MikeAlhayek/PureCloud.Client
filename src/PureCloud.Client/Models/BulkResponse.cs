using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkResponse
{
    /// <summary>
    /// A list of the results from the bulk operation.
    /// </summary>
    /// <value>A list of the results from the bulk operation.</value>
    public IEnumerable<BulkResult> Results { get; set; }

    /// <summary>
    /// The number of errors from the bulk operation.
    /// </summary>
    /// <value>The number of errors from the bulk operation.</value>
    public int? ErrorCount { get; set; }

    /// <summary>
    /// An index of where the errors are in the listing.
    /// </summary>
    /// <value>An index of where the errors are in the listing.</value>
    public IEnumerable<int?> ErrorIndexes { get; set; }
}
