using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SuggestSearchRequest
{
    /// <summary>
    /// Provides more details about a specified resource
    /// </summary>
    /// <value>Provides more details about a specified resource</value>
    public IEnumerable<string> Expand { get; set; }

    /// <summary>
    /// Resource domain type to search
    /// </summary>
    /// <value>Resource domain type to search</value>
    public IEnumerable<string> Types { get; set; }

    /// <summary>
    /// Suggest query
    /// </summary>
    /// <value>Suggest query</value>
    public IEnumerable<SuggestSearchCriteria> Query { get; set; }
}
