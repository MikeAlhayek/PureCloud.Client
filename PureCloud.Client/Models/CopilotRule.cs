using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CopilotRule
/// </summary>
[DataContract]
public partial class CopilotRule : IEquatable<CopilotRule>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CopilotRule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CopilotRule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CopilotRule" /> class.
    /// </summary>
    /// <param name="Conditions">List of conditions to execute actions, must have at least 1 element and maximum 100 elements. Operator in case of multiple conditions: &#39;OR&#39;. (required).</param>
    /// <param name="Actions">List of actions to execute, must have at least 1 element and maximum 100 elements. (required).</param>
    public CopilotRule(List<CopilotCondition> Conditions = null, List<CopilotAction> Actions = null)
    {
        this.Conditions = Conditions;
        this.Actions = Actions;

    }



    /// <summary>
    /// List of conditions to execute actions, must have at least 1 element and maximum 100 elements. Operator in case of multiple conditions: &#39;OR&#39;.
    /// </summary>
    /// <value>List of conditions to execute actions, must have at least 1 element and maximum 100 elements. Operator in case of multiple conditions: &#39;OR&#39;.</value>
    [DataMember(Name = "conditions", EmitDefaultValue = false)]
    public List<CopilotCondition> Conditions { get; set; }



    /// <summary>
    /// List of actions to execute, must have at least 1 element and maximum 100 elements.
    /// </summary>
    /// <value>List of actions to execute, must have at least 1 element and maximum 100 elements.</value>
    [DataMember(Name = "actions", EmitDefaultValue = false)]
    public List<CopilotAction> Actions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CopilotRule {\n");

        sb.Append("  Conditions: ").Append(Conditions).Append("\n");
        sb.Append("  Actions: ").Append(Actions).Append("\n");
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
        return Equals(obj as CopilotRule);
    }

    /// <summary>
    /// Returns true if CopilotRule instances are equal
    /// </summary>
    /// <param name="other">Instance of CopilotRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CopilotRule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conditions == other.Conditions ||
                Conditions != null &&
                Conditions.SequenceEqual(other.Conditions)
            ) &&
            (
                Actions == other.Actions ||
                Actions != null &&
                Actions.SequenceEqual(other.Actions)
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
            if (Conditions != null)
            {
                hash = hash * 59 + Conditions.GetHashCode();
            }

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            return hash;
        }
    }
}
