using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaSummaryDetail
/// </summary>
[DataContract]
public partial class MediaSummaryDetail : IEquatable<MediaSummaryDetail>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaSummaryDetail" /> class.
    /// </summary>
    /// <param name="Active">Active.</param>
    /// <param name="Acw">Acw.</param>
    public MediaSummaryDetail(int? Active = null, int? Acw = null)
    {
        this.Active = Active;
        this.Acw = Acw;

    }



    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name = "active", EmitDefaultValue = false)]
    public int? Active { get; set; }



    /// <summary>
    /// Gets or Sets Acw
    /// </summary>
    [DataMember(Name = "acw", EmitDefaultValue = false)]
    public int? Acw { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaSummaryDetail {\n");

        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  Acw: ").Append(Acw).Append("\n");
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
        return Equals(obj as MediaSummaryDetail);
    }

    /// <summary>
    /// Returns true if MediaSummaryDetail instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaSummaryDetail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaSummaryDetail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
            ) &&
            (
                Acw == other.Acw ||
                Acw != null &&
                Acw.Equals(other.Acw)
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
            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (Acw != null)
            {
                hash = hash * 59 + Acw.GetHashCode();
            }

            return hash;
        }
    }
}
