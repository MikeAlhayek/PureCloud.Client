using System.Collections;
using System.Text;

namespace PureCloud.Client.Models;


public sealed class ResponseQueryRequest
{
    /// <summary>
    /// Query phrase to search response text and name. If not set will match all.
    /// </summary>
    /// <value>Query phrase to search response text and name. If not set will match all.</value>
    public string QueryPhrase { get; set; }

    /// <summary>
    /// The maximum number of hits to return. Default: 25, Maximum: 500.
    /// </summary>
    /// <value>The maximum number of hits to return. Default: 25, Maximum: 500.</value>
    public int? PageSize { get; set; }

    /// <summary>
    /// Page Number
    /// </summary>
    /// <value>Page Number</value>
    public int? PageNumber { get; set; }

    /// <summary>
    /// Filter the query results.
    /// </summary>
    /// <value>Filter the query results.</value>
    public IEnumerable<ResponseFilter> Filters { get; set; }
}
