using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// The quality context that invoked this.
/// </summary>
[DataContract]
public partial class V2FlowExecutionDataFlowidTopicQuality : IEquatable<V2FlowExecutionDataFlowidTopicQuality>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicQuality" /> class.
    /// </summary>
    /// <param name="PolicyId">The identifier of the quality policy that invoked this flow..</param>
    /// <param name="PolicyName">The name of the quality policy that invoked this flow..</param>
    public V2FlowExecutionDataFlowidTopicQuality(string PolicyId = null, string PolicyName = null)
    {
        this.PolicyId = PolicyId;
        this.PolicyName = PolicyName;

    }



    /// <summary>
    /// The identifier of the quality policy that invoked this flow.
    /// </summary>
    /// <value>The identifier of the quality policy that invoked this flow.</value>
    [DataMember(Name = "policyId", EmitDefaultValue = false)]
    public string PolicyId { get; set; }



    /// <summary>
    /// The name of the quality policy that invoked this flow.
    /// </summary>
    /// <value>The name of the quality policy that invoked this flow.</value>
    [DataMember(Name = "policyName", EmitDefaultValue = false)]
    public string PolicyName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2FlowExecutionDataFlowidTopicQuality {\n");

        sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
        sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
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
        return this.Equals(obj as V2FlowExecutionDataFlowidTopicQuality);
    }

    /// <summary>
    /// Returns true if V2FlowExecutionDataFlowidTopicQuality instances are equal
    /// </summary>
    /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicQuality to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2FlowExecutionDataFlowidTopicQuality other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.PolicyId == other.PolicyId ||
                this.PolicyId != null &&
                this.PolicyId.Equals(other.PolicyId)
            ) &&
            (
                this.PolicyName == other.PolicyName ||
                this.PolicyName != null &&
                this.PolicyName.Equals(other.PolicyName)
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
            if (this.PolicyId != null)
            {
                hash = hash * 59 + this.PolicyId.GetHashCode();
            }

            if (this.PolicyName != null)
            {
                hash = hash * 59 + this.PolicyName.GetHashCode();
            }

            return hash;
        }
    }
}
