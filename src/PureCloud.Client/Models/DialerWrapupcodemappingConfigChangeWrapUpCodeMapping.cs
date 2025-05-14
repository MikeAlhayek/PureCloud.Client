using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerWrapupcodemappingConfigChangeWrapUpCodeMapping
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    public string Name { get; set; }

    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    public long? Version { get; set; }

    /// <summary>
    /// Gets or Sets DefaultSet
    /// </summary>
    public IEnumerable<DialerWrapupcodemappingConfigChangeWrapUpCodeMappingDefaultSetEnum> DefaultSet { get; set; }



    /// <summary>
    /// Gets or Sets Mapping
    /// </summary>
    public Dictionary<string, List<string>> Mapping { get; set; }
}
