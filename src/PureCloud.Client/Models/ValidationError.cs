using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ValidationError
{
    /// <summary>
    /// Line number for the error in CSV
    /// </summary>
    /// <value>Line number for the error in CSV</value>
    public long? LineNumber { get; set; }

    /// <summary>
    /// Detail of the error in CSV
    /// </summary>
    /// <value>Detail of the error in CSV</value>
    public string Message { get; set; }
}
