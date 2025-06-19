using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkError
{
    /// <summary>
    /// Error message of the bulk operation result.
    /// </summary>
    /// <value>Error message of the bulk operation result.</value>
    public string Message { get; set; }

    /// <summary>
    /// Error code of the bulk operation result.
    /// </summary>
    /// <value>Error code of the bulk operation result.</value>
    public string Code { get; set; }
}
