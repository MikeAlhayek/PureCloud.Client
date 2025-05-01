using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AvailableTranslations
/// </summary>
[DataContract]
public partial class AvailableTranslations : IEquatable<AvailableTranslations>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AvailableTranslations" /> class.
    /// </summary>
    /// <param name="OrgSpecific">OrgSpecific.</param>
    /// <param name="Builtin">Builtin.</param>
    public AvailableTranslations(List<string> OrgSpecific = null, List<string> Builtin = null)
    {
        this.OrgSpecific = OrgSpecific;
        this.Builtin = Builtin;

    }



    /// <summary>
    /// Gets or Sets OrgSpecific
    /// </summary>
    [DataMember(Name = "orgSpecific", EmitDefaultValue = false)]
    public List<string> OrgSpecific { get; set; }



    /// <summary>
    /// Gets or Sets Builtin
    /// </summary>
    [DataMember(Name = "builtin", EmitDefaultValue = false)]
    public List<string> Builtin { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AvailableTranslations {\n");

        sb.Append("  OrgSpecific: ").Append(OrgSpecific).Append("\n");
        sb.Append("  Builtin: ").Append(Builtin).Append("\n");
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
        return Equals(obj as AvailableTranslations);
    }

    /// <summary>
    /// Returns true if AvailableTranslations instances are equal
    /// </summary>
    /// <param name="other">Instance of AvailableTranslations to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AvailableTranslations other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OrgSpecific == other.OrgSpecific ||
                OrgSpecific != null &&
                OrgSpecific.SequenceEqual(other.OrgSpecific)
            ) &&
            (
                Builtin == other.Builtin ||
                Builtin != null &&
                Builtin.SequenceEqual(other.Builtin)
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
            if (OrgSpecific != null)
            {
                hash = hash * 59 + OrgSpecific.GetHashCode();
            }

            if (Builtin != null)
            {
                hash = hash * 59 + Builtin.GetHashCode();
            }

            return hash;
        }
    }
}
