using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CsvMappingEntry
{
    /// <summary>
    /// CSV field to map data from
    /// </summary>
    /// <value>CSV field to map data from</value>
    public string SourceField { get; set; }

    /// <summary>
    /// Json path to map data to
    /// </summary>
    /// <value>Json path to map data to</value>
    public string TargetField { get; set; }
}
