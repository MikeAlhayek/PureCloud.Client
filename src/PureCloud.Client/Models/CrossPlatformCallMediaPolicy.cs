using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CrossPlatformCallMediaPolicy
/// </summary>

public partial class CrossPlatformCallMediaPolicy : IEquatable<CrossPlatformCallMediaPolicy>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CrossPlatformCallMediaPolicy" /> class.
    /// </summary>
    /// <param name="Actions">Actions applied when specified conditions are met.</param>
    /// <param name="Conditions">Conditions for when actions should be applied.</param>
    public CrossPlatformCallMediaPolicy(CrossPlatformPolicyActions Actions = null, CallMediaPolicyConditions Conditions = null)
    {
        this.Actions = Actions;
        this.Conditions = Conditions;

    }



    /// <summary>
    /// Actions applied when specified conditions are met
    /// </summary>
    /// <value>Actions applied when specified conditions are met</value>
    [JsonPropertyName("actions")]
    public CrossPlatformPolicyActions Actions { get; set; }



    /// <summary>
    /// Conditions for when actions should be applied
    /// </summary>
    /// <value>Conditions for when actions should be applied</value>
    [JsonPropertyName("conditions")]
    public CallMediaPolicyConditions Conditions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CrossPlatformCallMediaPolicy {\n");

        sb.Append("  Actions: ").Append(Actions).Append("\n");
        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
        return Equals(obj as CrossPlatformCallMediaPolicy);
    }

    /// <summary>
    /// Returns true if CrossPlatformCallMediaPolicy instances are equal
    /// </summary>
    /// <param name="other">Instance of CrossPlatformCallMediaPolicy to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CrossPlatformCallMediaPolicy other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Actions == other.Actions ||
                Actions != null &&
                Actions.Equals(other.Actions)
            ) &&
            (
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.Equals(other.Conditions)
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
            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            return hash;
        }
    }
}
