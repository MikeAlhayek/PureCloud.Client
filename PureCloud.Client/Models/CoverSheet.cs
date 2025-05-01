using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CoverSheet
/// </summary>
[DataContract]
public partial class CoverSheet : IEquatable<CoverSheet>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CoverSheet" /> class.
    /// </summary>
    /// <param name="Notes">Text to be added to the coversheet.</param>
    /// <param name="Locale">Locale, e.g. &#x3D; en-US.</param>
    public CoverSheet(string Notes = null, string Locale = null)
    {
        this.Notes = Notes;
        this.Locale = Locale;

    }



    /// <summary>
    /// Text to be added to the coversheet
    /// </summary>
    /// <value>Text to be added to the coversheet</value>
    [DataMember(Name = "notes", EmitDefaultValue = false)]
    public string Notes { get; set; }



    /// <summary>
    /// Locale, e.g. &#x3D; en-US
    /// </summary>
    /// <value>Locale, e.g. &#x3D; en-US</value>
    [DataMember(Name = "locale", EmitDefaultValue = false)]
    public string Locale { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CoverSheet {\n");

        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  Locale: ").Append(Locale).Append("\n");
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
        return Equals(obj as CoverSheet);
    }

    /// <summary>
    /// Returns true if CoverSheet instances are equal
    /// </summary>
    /// <param name="other">Instance of CoverSheet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoverSheet other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                Locale == other.Locale ||
                Locale != null &&
                Locale.Equals(other.Locale)
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
            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (Locale != null)
            {
                hash = hash * 59 + Locale.GetHashCode();
            }

            return hash;
        }
    }
}
