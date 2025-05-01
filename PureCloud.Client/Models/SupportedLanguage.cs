using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportedLanguage
/// </summary>
[DataContract]
public partial class SupportedLanguage : IEquatable<SupportedLanguage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportedLanguage" /> class.
    /// </summary>
    public SupportedLanguage()
    {

    }



    /// <summary>
    /// Architect supported language tag, e.g. en-us, es-us
    /// </summary>
    /// <value>Architect supported language tag, e.g. en-us, es-us</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; private set; }



    /// <summary>
    /// Whether or not this language is the default language
    /// </summary>
    /// <value>Whether or not this language is the default language</value>
    [DataMember(Name = "isDefault", EmitDefaultValue = false)]
    public bool? IsDefault { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportedLanguage {\n");

        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
        return Equals(obj as SupportedLanguage);
    }

    /// <summary>
    /// Returns true if SupportedLanguage instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportedLanguage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportedLanguage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                IsDefault == other.IsDefault ||
                IsDefault != null &&
                IsDefault.Equals(other.IsDefault)
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
            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (IsDefault != null)
            {
                hash = hash * 59 + IsDefault.GetHashCode();
            }

            return hash;
        }
    }
}
