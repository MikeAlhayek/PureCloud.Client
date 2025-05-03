using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TargetAttributes
/// </summary>

public partial class TargetAttributes : IEquatable<TargetAttributes>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TargetAttributes" /> class.
    /// </summary>
    /// <param name="BaseAttributes">A set of base attributes which may be used in policies for any target..</param>
    /// <param name="_TargetAttributes">A map of policy targets to any additional attributes which are valid for that target..</param>
    public TargetAttributes(List<PolicyAttribute> BaseAttributes = null, Dictionary<string, TargetAttributeValue> _TargetAttributes = null)
    {
        this.BaseAttributes = BaseAttributes;
        this._TargetAttributes = _TargetAttributes;

    }



    /// <summary>
    /// A set of base attributes which may be used in policies for any target.
    /// </summary>
    /// <value>A set of base attributes which may be used in policies for any target.</value>
    [JsonPropertyName("baseAttributes")]
    public List<PolicyAttribute> BaseAttributes { get; set; }



    /// <summary>
    /// A map of policy targets to any additional attributes which are valid for that target.
    /// </summary>
    /// <value>A map of policy targets to any additional attributes which are valid for that target.</value>
    [JsonPropertyName("targetAttributes")]
    public Dictionary<string, TargetAttributeValue> _TargetAttributes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TargetAttributes {\n");

        sb.Append("  BaseAttributes: ").Append(BaseAttributes).Append("\n");
        sb.Append("  _TargetAttributes: ").Append(_TargetAttributes).Append("\n");
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
        return Equals(obj as TargetAttributes);
    }

    /// <summary>
    /// Returns true if TargetAttributes instances are equal
    /// </summary>
    /// <param name="other">Instance of TargetAttributes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TargetAttributes other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BaseAttributes == other.BaseAttributes ||
                BaseAttributes != null &&
                BaseAttributes.SequenceEqual(other.BaseAttributes)
            ) &&
            (
                _TargetAttributes == other._TargetAttributes ||
                _TargetAttributes != null &&
                _TargetAttributes.SequenceEqual(other._TargetAttributes)
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
            if (BaseAttributes != null)
            {
                hash = hash * 59 + BaseAttributes.GetHashCode();
            }

            if (_TargetAttributes != null)
            {
                hash = hash * 59 + _TargetAttributes.GetHashCode();
            }

            return hash;
        }
    }
}
