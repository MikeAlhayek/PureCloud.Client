using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CsvSettings
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Id of the external settings
    /// </summary>
    /// <value>Id of the external settings</value>
    public string ExternalSettingsId { get; set; }

    /// <summary>
    /// Mappings for the transformation
    /// </summary>
    /// <value>Mappings for the transformation</value>
    public IEnumerable<CsvMappingEntry> Mappings { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
