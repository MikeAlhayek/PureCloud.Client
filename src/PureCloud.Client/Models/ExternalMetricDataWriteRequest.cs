using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalMetricDataWriteRequest
{
    /// <summary>
    /// A list of external metric data items. A maximum of 100 items are allowed.
    /// </summary>
    /// <value>A list of external metric data items. A maximum of 100 items are allowed.</value>
    public IEnumerable<ExternalMetricDataItem> Items { get; set; }
}
