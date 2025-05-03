using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemOnAttributeChangeCondition
/// </summary>

public partial class WorkitemOnAttributeChangeCondition : IEquatable<WorkitemOnAttributeChangeCondition>
{
    /// <summary>
    /// The name of the workitem attribute whose change will be evaluated as part of the rule.
    /// </summary>
    /// <value>The name of the workitem attribute whose change will be evaluated as part of the rule.</value>
    
    public enum AttributeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Statusid for "statusId"
        /// </summary>
        [EnumMember(Value = "statusId")]
        Statusid
    }
    /// <summary>
    /// The name of the workitem attribute whose change will be evaluated as part of the rule.
    /// </summary>
    /// <value>The name of the workitem attribute whose change will be evaluated as part of the rule.</value>
    [JsonPropertyName("attribute")]
    public AttributeEnum? Attribute { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeCondition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkitemOnAttributeChangeCondition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeCondition" /> class.
    /// </summary>
    /// <param name="Attribute">The name of the workitem attribute whose change will be evaluated as part of the rule. (required).</param>
    /// <param name="NewValue">The new value of the attribute. If the attribute is updated to this value this part of the condition will be met. (required).</param>
    /// <param name="OldValue">The old value of the attribute. If the attribute was updated from this value this part of the condition will be met..</param>
    public WorkitemOnAttributeChangeCondition(AttributeEnum? Attribute = null, string NewValue = null, string OldValue = null)
    {
        this.Attribute = Attribute;
        this.NewValue = NewValue;
        this.OldValue = OldValue;

    }





    /// <summary>
    /// The new value of the attribute. If the attribute is updated to this value this part of the condition will be met.
    /// </summary>
    /// <value>The new value of the attribute. If the attribute is updated to this value this part of the condition will be met.</value>
    [JsonPropertyName("newValue")]
    public string NewValue { get; set; }



    /// <summary>
    /// The old value of the attribute. If the attribute was updated from this value this part of the condition will be met.
    /// </summary>
    /// <value>The old value of the attribute. If the attribute was updated from this value this part of the condition will be met.</value>
    [JsonPropertyName("oldValue")]
    public string OldValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemOnAttributeChangeCondition {\n");

        sb.Append("  Attribute: ").Append(Attribute).Append("\n");
        sb.Append("  NewValue: ").Append(NewValue).Append("\n");
        sb.Append("  OldValue: ").Append(OldValue).Append("\n");
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
        return Equals(obj as WorkitemOnAttributeChangeCondition);
    }

    /// <summary>
    /// Returns true if WorkitemOnAttributeChangeCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemOnAttributeChangeCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemOnAttributeChangeCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Attribute == other.Attribute ||
                Attribute != null &&
                Attribute.Equals(other.Attribute)
            ) &&
            (
                NewValue == other.NewValue ||
                NewValue != null &&
                NewValue.Equals(other.NewValue)
            ) &&
            (
                OldValue == other.OldValue ||
                OldValue != null &&
                OldValue.Equals(other.OldValue)
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
            if (Attribute != null)
            {
                hash = hash * 59 + Attribute.GetHashCode();
            }

            if (NewValue != null)
            {
                hash = hash * 59 + NewValue.GetHashCode();
            }

            if (OldValue != null)
            {
                hash = hash * 59 + OldValue.GetHashCode();
            }

            return hash;
        }
    }
}
