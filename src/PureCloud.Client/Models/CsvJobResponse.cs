using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class CsvJobResponse
{
    /// <summary>
    /// Job for the import
    /// </summary>
    /// <value>Job for the import</value>
    public AddressableEntityRef Job { get; set; }
}
