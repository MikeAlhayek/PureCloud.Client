using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkResult
{
    /// <summary>
    /// Error details if the operation failed.
    /// </summary>
    /// <value>Error details if the operation failed.</value>
    public BulkError Error { get; set; }

    /// <summary>
    /// The result of the operation if it succeeded.
    /// </summary>
    /// <value>The result of the operation if it succeeded.</value>
    public object Entity { get; set; }
}
