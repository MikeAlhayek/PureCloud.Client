using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NamedEntityTypeItem
/// </summary>

public partial class NamedEntityTypeItem : IEquatable<NamedEntityTypeItem>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityTypeItem" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NamedEntityTypeItem() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityTypeItem" /> class.
    /// </summary>
    /// <param name="Value">A value for an named entity type definition. (required).</param>
    /// <param name="Synonyms">Synonyms for the given named entity value..</param>
    /// <param name="AdditionalLanguages">Additional Language Synonyms for the given named entity value..</param>
    public NamedEntityTypeItem(string Value = null, List<string> Synonyms = null, Dictionary<string, AdditionalLanguagesSynonyms> AdditionalLanguages = null)
    {
        this.Value = Value;
        this.Synonyms = Synonyms;
        this.AdditionalLanguages = AdditionalLanguages;

    }



    /// <summary>
    /// A value for an named entity type definition.
    /// </summary>
    /// <value>A value for an named entity type definition.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// Synonyms for the given named entity value.
    /// </summary>
    /// <value>Synonyms for the given named entity value.</value>
    [JsonPropertyName("synonyms")]
    public List<string> Synonyms { get; set; }



    /// <summary>
    /// Additional Language Synonyms for the given named entity value.
    /// </summary>
    /// <value>Additional Language Synonyms for the given named entity value.</value>
    [JsonPropertyName("additionalLanguages")]
    public Dictionary<string, AdditionalLanguagesSynonyms> AdditionalLanguages { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NamedEntityTypeItem {\n");

        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Synonyms: ").Append(Synonyms).Append("\n");
        sb.Append("  AdditionalLanguages: ").Append(AdditionalLanguages).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as NamedEntityTypeItem);
    }

    /// <summary>
    /// Returns true if NamedEntityTypeItem instances are equal
    /// </summary>
    /// <param name="other">Instance of NamedEntityTypeItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NamedEntityTypeItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Synonyms == other.Synonyms ||
                Synonyms != null &&
                Synonyms.SequenceEqual(other.Synonyms)
            ) &&
            (
                AdditionalLanguages == other.AdditionalLanguages ||
                AdditionalLanguages != null &&
                AdditionalLanguages.SequenceEqual(other.AdditionalLanguages)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Synonyms != null)
            {
                hash = hash * 59 + Synonyms.GetHashCode();
            }

            if (AdditionalLanguages != null)
            {
                hash = hash * 59 + AdditionalLanguages.GetHashCode();
            }

            return hash;
        }
    }
}
