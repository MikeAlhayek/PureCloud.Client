using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportCenterLabelFilter
/// </summary>
[DataContract]
public partial class SupportCenterLabelFilter : IEquatable<SupportCenterLabelFilter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterLabelFilter" /> class.
    /// </summary>
    /// <param name="Labels">Labels to filter by..</param>
    public SupportCenterLabelFilter(List<AddressableEntityRef> Labels = null)
    {
        this.Labels = Labels;

    }



    /// <summary>
    /// Labels to filter by.
    /// </summary>
    /// <value>Labels to filter by.</value>
    [DataMember(Name = "labels", EmitDefaultValue = false)]
    public List<AddressableEntityRef> Labels { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportCenterLabelFilter {\n");

        sb.Append("  Labels: ").Append(Labels).Append("\n");
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
        return Equals(obj as SupportCenterLabelFilter);
    }

    /// <summary>
    /// Returns true if SupportCenterLabelFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportCenterLabelFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportCenterLabelFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Labels == other.Labels ||
                Labels != null &&
                Labels.SequenceEqual(other.Labels)
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
            if (Labels != null)
            {
                hash = hash * 59 + Labels.GetHashCode();
            }

            return hash;
        }
    }
}
