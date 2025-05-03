using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranslateSupportedLanguageList
/// </summary>

public partial class TranslateSupportedLanguageList : IEquatable<TranslateSupportedLanguageList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TranslateSupportedLanguageList" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    public TranslateSupportedLanguageList(List<TranslateSupportedLanguage> Entities = null)
    {
        this.Entities = Entities;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<TranslateSupportedLanguage> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranslateSupportedLanguageList {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as TranslateSupportedLanguageList);
    }

    /// <summary>
    /// Returns true if TranslateSupportedLanguageList instances are equal
    /// </summary>
    /// <param name="other">Instance of TranslateSupportedLanguageList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranslateSupportedLanguageList other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}
