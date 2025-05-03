using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PolicyErrors
/// </summary>

public partial class PolicyErrors : IEquatable<PolicyErrors>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyErrors" /> class.
    /// </summary>
    /// <param name="PolicyErrorMessages">PolicyErrorMessages.</param>
    public PolicyErrors(List<PolicyErrorMessage> PolicyErrorMessages = null)
    {
        this.PolicyErrorMessages = PolicyErrorMessages;

    }



    /// <summary>
    /// Gets or Sets PolicyErrorMessages
    /// </summary>
    [JsonPropertyName("policyErrorMessages")]
    public List<PolicyErrorMessage> PolicyErrorMessages { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PolicyErrors {\n");

        sb.Append("  PolicyErrorMessages: ").Append(PolicyErrorMessages).Append("\n");
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
        return Equals(obj as PolicyErrors);
    }

    /// <summary>
    /// Returns true if PolicyErrors instances are equal
    /// </summary>
    /// <param name="other">Instance of PolicyErrors to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PolicyErrors other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PolicyErrorMessages == other.PolicyErrorMessages ||
                PolicyErrorMessages != null &&
                PolicyErrorMessages.SequenceEqual(other.PolicyErrorMessages)
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
            if (PolicyErrorMessages != null)
            {
                hash = hash * 59 + PolicyErrorMessages.GetHashCode();
            }

            return hash;
        }
    }
}
