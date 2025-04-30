using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// WorkitemOnAttributeChangeRuleCreate
/// </summary>
[DataContract]
public partial class WorkitemOnAttributeChangeRuleCreate : IEquatable<WorkitemOnAttributeChangeRuleCreate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeRuleCreate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkitemOnAttributeChangeRuleCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeRuleCreate" /> class.
    /// </summary>
    /// <param name="Name">The name of the rule. (required).</param>
    /// <param name="Condition">The rules condition. If the condition criteria is met the rules action will be executed. (required).</param>
    public WorkitemOnAttributeChangeRuleCreate(string Name = null, WorkitemOnAttributeChangeCondition Condition = null)
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
    public WorkitemOnAttributeChangeCondition Condition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemOnAttributeChangeRuleCreate {\n");

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
        return this.Equals(obj as WorkitemOnAttributeChangeRuleCreate);
    }

    /// <summary>
    /// Returns true if WorkitemOnAttributeChangeRuleCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemOnAttributeChangeRuleCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemOnAttributeChangeRuleCreate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Condition == other.Condition ||
                this.Condition != null &&
                this.Condition.Equals(other.Condition)
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
            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Condition != null)
            {
                hash = hash * 59 + this.Condition.GetHashCode();
            }

            return hash;
        }
    }
}
