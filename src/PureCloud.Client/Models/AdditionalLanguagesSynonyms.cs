using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdditionalLanguagesSynonyms
/// </summary>

public partial class AdditionalLanguagesSynonyms : IEquatable<AdditionalLanguagesSynonyms>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AdditionalLanguagesSynonyms" /> class.
    /// </summary>
    public AdditionalLanguagesSynonyms()
    {

    }



    /// <summary>
    /// Synonyms for additional language
    /// </summary>
    /// <value>Synonyms for additional language</value>
    [JsonPropertyName("synonyms")]
    public List<string> Synonyms { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdditionalLanguagesSynonyms {\n");

        sb.Append("  Synonyms: ").Append(Synonyms).Append("\n");
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
        return Equals(obj as AdditionalLanguagesSynonyms);
    }

    /// <summary>
    /// Returns true if AdditionalLanguagesSynonyms instances are equal
    /// </summary>
    /// <param name="other">Instance of AdditionalLanguagesSynonyms to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdditionalLanguagesSynonyms other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Synonyms == other.Synonyms ||
                Synonyms != null &&
                Synonyms.SequenceEqual(other.Synonyms)
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
            if (Synonyms != null)
            {
                hash = hash * 59 + Synonyms.GetHashCode();
            }

            return hash;
        }
    }
}
