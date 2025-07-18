using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MetadataDocumentation
{
    /// <summary>
    /// description of the documentation
    /// </summary>
    /// <value>description of the documentation</value>
    public string Description { get; set; }

    /// <summary>
    /// location where the documentation can be accessed
    /// </summary>
    /// <value>location where the documentation can be accessed</value>
    public string Location { get; set; }
}
