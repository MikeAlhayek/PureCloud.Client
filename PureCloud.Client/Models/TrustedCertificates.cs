using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about trusted certificates
/// </summary>
[DataContract]
public partial class TrustedCertificates : IEquatable<TrustedCertificates>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrustedCertificates" /> class.
    /// </summary>
    /// <param name="Entities">The list of trusted certificates.</param>
    /// <param name="Total">The total number of trusted certificates.</param>
    public TrustedCertificates(List<TrustedCertificateInfo> Entities = null, int? Total = null)
    {
        this.Entities = Entities;
        this.Total = Total;

    }



    /// <summary>
    /// The list of trusted certificates
    /// </summary>
    /// <value>The list of trusted certificates</value>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<TrustedCertificateInfo> Entities { get; set; }



    /// <summary>
    /// The total number of trusted certificates
    /// </summary>
    /// <value>The total number of trusted certificates</value>
    [DataMember(Name = "total", EmitDefaultValue = false)]
    public int? Total { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrustedCertificates {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
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
        return Equals(obj as TrustedCertificates);
    }

    /// <summary>
    /// Returns true if TrustedCertificates instances are equal
    /// </summary>
    /// <param name="other">Instance of TrustedCertificates to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrustedCertificates other)
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
            ) &&
            (
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
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

            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            return hash;
        }
    }
}
