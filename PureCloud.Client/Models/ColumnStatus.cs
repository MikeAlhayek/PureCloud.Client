using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ColumnStatus
/// </summary>
[DataContract]
public partial class ColumnStatus : IEquatable<ColumnStatus>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ColumnStatus" /> class.
    /// </summary>
    /// <param name="Contactable">Indicates whether or not an individual contact method column is contactable..</param>
    public ColumnStatus(bool? Contactable = null)
    {
        this.Contactable = Contactable;

    }



    /// <summary>
    /// Indicates whether or not an individual contact method column is contactable.
    /// </summary>
    /// <value>Indicates whether or not an individual contact method column is contactable.</value>
    [DataMember(Name = "contactable", EmitDefaultValue = false)]
    public bool? Contactable { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ColumnStatus {\n");

        sb.Append("  Contactable: ").Append(Contactable).Append("\n");
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
        return Equals(obj as ColumnStatus);
    }

    /// <summary>
    /// Returns true if ColumnStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of ColumnStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ColumnStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Contactable == other.Contactable ||
                Contactable != null &&
                Contactable.Equals(other.Contactable)
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
            if (Contactable != null)
            {
                hash = hash * 59 + Contactable.GetHashCode();
            }

            return hash;
        }
    }
}
