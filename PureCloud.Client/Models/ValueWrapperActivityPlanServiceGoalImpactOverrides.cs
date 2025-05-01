using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValueWrapperActivityPlanServiceGoalImpactOverrides
/// </summary>
[DataContract]
public partial class ValueWrapperActivityPlanServiceGoalImpactOverrides : IEquatable<ValueWrapperActivityPlanServiceGoalImpactOverrides>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValueWrapperActivityPlanServiceGoalImpactOverrides" /> class.
    /// </summary>
    /// <param name="Value">The value for the associated field.</param>
    public ValueWrapperActivityPlanServiceGoalImpactOverrides(ActivityPlanServiceGoalImpactOverrides Value = null)
    {
        this.Value = Value;

    }



    /// <summary>
    /// The value for the associated field
    /// </summary>
    /// <value>The value for the associated field</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public ActivityPlanServiceGoalImpactOverrides Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValueWrapperActivityPlanServiceGoalImpactOverrides {\n");

        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return this.Equals(obj as ValueWrapperActivityPlanServiceGoalImpactOverrides);
    }

    /// <summary>
    /// Returns true if ValueWrapperActivityPlanServiceGoalImpactOverrides instances are equal
    /// </summary>
    /// <param name="other">Instance of ValueWrapperActivityPlanServiceGoalImpactOverrides to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValueWrapperActivityPlanServiceGoalImpactOverrides other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Value == other.Value ||
                this.Value != null &&
                this.Value.Equals(other.Value)
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
            if (this.Value != null)
            {
                hash = hash * 59 + this.Value.GetHashCode();
            }

            return hash;
        }
    }
}
