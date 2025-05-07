using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PolicyAttributeSet
/// </summary>

public partial class PolicyAttributeSet : IEquatable<PolicyAttributeSet>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyAttributeSet" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="PolicyAttributes">A set of the attributes checked by the requested policy..</param>
    /// <param name="PresetAttributes">Map of names and values of preset attributes used in this policy..</param>
    public PolicyAttributeSet(string Name = null, List<PolicyAttribute> PolicyAttributes = null, Dictionary<string, TypedAttribute> PresetAttributes = null)
    {
        this.Name = Name;
        this.PolicyAttributes = PolicyAttributes;
        this.PresetAttributes = PresetAttributes;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A set of the attributes checked by the requested policy.
    /// </summary>
    /// <value>A set of the attributes checked by the requested policy.</value>
    [JsonPropertyName("policyAttributes")]
    public List<PolicyAttribute> PolicyAttributes { get; set; }



    /// <summary>
    /// Map of names and values of preset attributes used in this policy.
    /// </summary>
    /// <value>Map of names and values of preset attributes used in this policy.</value>
    [JsonPropertyName("presetAttributes")]
    public Dictionary<string, TypedAttribute> PresetAttributes { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PolicyAttributeSet {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PolicyAttributes: ").Append(PolicyAttributes).Append("\n");
        sb.Append("  PresetAttributes: ").Append(PresetAttributes).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as PolicyAttributeSet);
    }

    /// <summary>
    /// Returns true if PolicyAttributeSet instances are equal
    /// </summary>
    /// <param name="other">Instance of PolicyAttributeSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PolicyAttributeSet other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                PolicyAttributes == other.PolicyAttributes ||
                PolicyAttributes != null &&
                PolicyAttributes.SequenceEqual(other.PolicyAttributes)
            ) &&
            (
                PresetAttributes == other.PresetAttributes ||
                PresetAttributes != null &&
                PresetAttributes.SequenceEqual(other.PresetAttributes)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (PolicyAttributes != null)
            {
                hash = hash * 59 + PolicyAttributes.GetHashCode();
            }

            if (PresetAttributes != null)
            {
                hash = hash * 59 + PresetAttributes.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
