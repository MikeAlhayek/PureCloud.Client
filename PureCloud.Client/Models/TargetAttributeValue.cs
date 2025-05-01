using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// TargetAttributeValue
/// </summary>
[DataContract]
public partial class TargetAttributeValue : IEquatable<TargetAttributeValue>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TargetAttributeValue" /> class.
    /// </summary>
    /// <param name="Description">Description.</param>
    /// <param name="PolicyAttributes">PolicyAttributes.</param>
    public TargetAttributeValue(string Description = null, List<PolicyAttribute> PolicyAttributes = null)
    {
        this.Description = Description;
        this.PolicyAttributes = PolicyAttributes;

    }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets PolicyAttributes
    /// </summary>
    [DataMember(Name = "policyAttributes", EmitDefaultValue = false)]
    public List<PolicyAttribute> PolicyAttributes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TargetAttributeValue {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  PolicyAttributes: ").Append(PolicyAttributes).Append("\n");
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
        return Equals(obj as TargetAttributeValue);
    }

    /// <summary>
    /// Returns true if TargetAttributeValue instances are equal
    /// </summary>
    /// <param name="other">Instance of TargetAttributeValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TargetAttributeValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                PolicyAttributes == other.PolicyAttributes ||
                PolicyAttributes != null &&
                PolicyAttributes.SequenceEqual(other.PolicyAttributes)
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
            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (PolicyAttributes != null)
            {
                hash = hash * 59 + PolicyAttributes.GetHashCode();
            }

            return hash;
        }
    }
}
