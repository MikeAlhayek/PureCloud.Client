using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueryResponseGroupedData
{
    /// <summary>
    /// The group values for this data
    /// </summary>
    /// <value>The group values for this data</value>
    public Dictionary<string, string> Group { get; set; }

    /// <summary>
    /// The metrics in this group
    /// </summary>
    /// <value>The metrics in this group</value>
    public IEnumerable<QueryResponseData> Data { get; set; }

}
