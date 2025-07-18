using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MetadataResults
{
    /// <summary>
    /// list of resources
    /// </summary>
    /// <value>list of resources</value>
    public IEnumerable<MetadataResultEntity> Entities { get; set; }
}
