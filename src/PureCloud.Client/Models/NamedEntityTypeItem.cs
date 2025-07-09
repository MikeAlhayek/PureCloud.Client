using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NamedEntityTypeItem
{
    /// <summary>
    /// A value for an named entity type definition.
    /// </summary>
    /// <value>A value for an named entity type definition.</value>
    public string Value { get; set; }

    /// <summary>
    /// Synonyms for the given named entity value.
    /// </summary>
    /// <value>Synonyms for the given named entity value.</value>
    public IEnumerable<string> Synonyms { get; set; }

    /// <summary>
    /// Additional Language Synonyms for the given named entity value.
    /// </summary>
    /// <value>Additional Language Synonyms for the given named entity value.</value>
    public Dictionary<string, AdditionalLanguagesSynonyms> AdditionalLanguages { get; set; }
}
