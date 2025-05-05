using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkBaseAssignment
/// </summary>

public partial class TrunkBaseAssignment : IEquatable<TrunkBaseAssignment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkBaseAssignment" /> class.
    /// </summary>
    /// <param name="Family">The address family to use with the trunk base settings. 2&#x3D;IPv4, 23&#x3D;IPv6.</param>
    /// <param name="TrunkBase">A trunk base settings reference..</param>
    public TrunkBaseAssignment(int? Family = null, TrunkBase TrunkBase = null)
    {
        this.Family = Family;
        this.TrunkBase = TrunkBase;

    }



    /// <summary>
    /// The address family to use with the trunk base settings. 2&#x3D;IPv4, 23&#x3D;IPv6
    /// </summary>
    /// <value>The address family to use with the trunk base settings. 2&#x3D;IPv4, 23&#x3D;IPv6</value>
    [JsonPropertyName("family")]
    public int? Family { get; set; }



    /// <summary>
    /// A trunk base settings reference.
    /// </summary>
    /// <value>A trunk base settings reference.</value>
    [JsonPropertyName("trunkBase")]
    public TrunkBase TrunkBase { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkBaseAssignment {\n");

        sb.Append("  Family: ").Append(Family).Append("\n");
        sb.Append("  TrunkBase: ").Append(TrunkBase).Append("\n");
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
        return Equals(obj as TrunkBaseAssignment);
    }

    /// <summary>
    /// Returns true if TrunkBaseAssignment instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkBaseAssignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkBaseAssignment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Family == other.Family ||
                Family != null &&
                Family.Equals(other.Family)
            ) &&
            (
                TrunkBase == other.TrunkBase ||
                TrunkBase != null &&
                TrunkBase.Equals(other.TrunkBase)
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
            if (Family != null)
            {
                hash = hash * 59 + Family.GetHashCode();
            }

            if (TrunkBase != null)
            {
                hash = hash * 59 + TrunkBase.GetHashCode();
            }

            return hash;
        }
    }
}
