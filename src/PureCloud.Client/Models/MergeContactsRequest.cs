using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MergeContactsRequest
{
    /// <summary>
    /// The IDs of all contacts involved in the merge operation (must be between 2 and 25).
    /// </summary>
    /// <value>The IDs of all contacts involved in the merge operation (must be between 2 and 25).</value>
    public IEnumerable<string> ContactIds { get; set; }

    /// <summary>
    /// Override data to set for specific Contact fields after a merge. Any null fields in &#x60;valueOverride&#x60; will not replace existing data.
    /// </summary>
    /// <value>Override data to set for specific Contact fields after a merge. Any null fields in &#x60;valueOverride&#x60; will not replace existing data.</value>
    public ExternalContact ValueOverride { get; set; }
}
