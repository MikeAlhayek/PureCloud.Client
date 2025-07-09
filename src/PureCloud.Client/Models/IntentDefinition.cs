using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class IntentDefinition
{
    /// <summary>
    /// ID of the intent.
    /// </summary>
    /// <value>ID of the intent.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the intent.
    /// </summary>
    /// <value>The name of the intent.</value>
    public string Name { get; set; }

    /// <summary>
    /// The description of the intent.
    /// </summary>
    /// <value>The description of the intent.</value>
    public string Description { get; set; }

    /// <summary>
    /// The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities
    /// </summary>
    /// <value>The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities</value>
    public IEnumerable<NamedEntityTypeBinding> EntityTypeBindings { get; set; }

    /// <summary>
    /// The references for the named entity used in this intent.This field is mutually exclusive with entityTypeBindings
    /// </summary>
    /// <value>The references for the named entity used in this intent.This field is mutually exclusive with entityTypeBindings</value>
    public IEnumerable<string> EntityNameReferences { get; set; }

    /// <summary>
    /// The utterances that act as training phrases for the intent.
    /// </summary>
    /// <value>The utterances that act as training phrases for the intent.</value>
    public IEnumerable<NluUtterance> Utterances { get; set; }

    /// <summary>
    /// Additional languages for intents
    /// </summary>
    /// <value>Additional languages for intents</value>
    public Dictionary<string, AdditionalLanguagesIntent> AdditionalLanguages { get; set; }
}
