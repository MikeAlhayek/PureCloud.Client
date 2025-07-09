using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NamedEntityTypeMechanism
{
    /// <summary>
    /// The type of the mechanism.
    /// </summary>
    /// <value>The type of the mechanism.</value>
    public NamedEntityTypeMechanismTypeEnum? Type { get; set; }

    /// <summary>
    /// Subtype of detection mechanism
    /// </summary>
    /// <value>Subtype of detection mechanism</value>
    public NamedEntityTypeMechanismSubTypeEnum? SubType { get; set; }

    /// <summary>
    /// The items that define the named entity type.
    /// </summary>
    /// <value>The items that define the named entity type.</value>
    public IEnumerable<NamedEntityTypeItem> Items { get; set; }

    /// <summary>
    /// Whether the named entity type is restricted to the items provided. Default: false
    /// </summary>
    /// <value>Whether the named entity type is restricted to the items provided. Default: false</value>
    public bool? Restricted { get; set; }

    /// <summary>
    /// The maximum length of the entity resolved value
    /// </summary>
    /// <value>The maximum length of the entity resolved value</value>
    public int? MaxLength { get; set; }

    /// <summary>
    /// The minimum length of the entity resolved value
    /// </summary>
    /// <value>The minimum length of the entity resolved value</value>
    public int? MinLength { get; set; }

    /// <summary>
    /// Examples for entity detection
    /// </summary>
    /// <value>Examples for entity detection</value>
    public IEnumerable<NamedEntityTypeMechanismExample> Examples { get; set; }
}
