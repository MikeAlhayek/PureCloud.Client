using System.Collections;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class LibraryBatchRequest
{
    /// <summary>
    /// List of Library IDs
    /// </summary>
    /// <value>List of Library IDs</value>
    public IEnumerable<string> LibraryIds { get; set; }
}
