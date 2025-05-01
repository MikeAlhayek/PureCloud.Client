using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemDateBasedRuleUpdate
/// </summary>
[DataContract]
public partial class WorkitemDateBasedRuleUpdate : IEquatable<WorkitemDateBasedRuleUpdate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemDateBasedRuleUpdate" /> class.
    /// </summary>
    /// <param name="Name">The name of the rule..</param>
    /// <param name="Condition">The rules condition. If the condition criteria is met the rules action will be executed..</param>
    public WorkitemDateBasedRuleUpdate(string Name = null, WorkitemDateBasedConditionUpdate Condition = null)
    {
        this.Name = Name;
        this.Condition = Condition;

    }



    /// <summary>
    /// The name of the rule.
    /// </summary>
    /// <value>The name of the rule.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The rules condition. If the condition criteria is met the rules action will be executed.
    /// </summary>
    /// <value>The rules condition. If the condition criteria is met the rules action will be executed.</value>
    [DataMember(Name = "condition", EmitDefaultValue = false)]
    public WorkitemDateBasedConditionUpdate Condition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemDateBasedRuleUpdate {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Condition: ").Append(Condition).Append("\n");
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
        return Equals(obj as WorkitemDateBasedRuleUpdate);
    }

    /// <summary>
    /// Returns true if WorkitemDateBasedRuleUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemDateBasedRuleUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemDateBasedRuleUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Condition == other.Condition ||
                Condition != null &&
                Condition.Equals(other.Condition)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Condition != null)
            {
                hash = hash * 59 + Condition.GetHashCode();
            }

            return hash;
        }
    }
}
