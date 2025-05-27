using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PagingSpec
{
    /// <summary>
    /// How many results per page
    /// </summary>
    /// <value>How many results per page</value>
    public int? PageSize { get; set; }

    /// <summary>
    /// How many pages in
    /// </summary>
    /// <value>How many pages in</value>
    public int? PageNumber { get; set; }
}
