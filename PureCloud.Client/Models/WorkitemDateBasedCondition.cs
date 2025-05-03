using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemDateBasedCondition
/// </summary>

public partial class WorkitemDateBasedCondition : IEquatable<WorkitemDateBasedCondition>
{
    /// <summary>
    /// The name of the workitem date attribute.
    /// </summary>
    /// <value>The name of the workitem date attribute.</value>
    
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
        /// Enum Datedue for "dateDue"
        /// </summary>
        [EnumMember(Value = "dateDue")]
        Datedue,

        /// <summary>
        /// Enum Dateexpires for "dateExpires"
        /// </summary>
        [EnumMember(Value = "dateExpires")]
        Dateexpires,

        /// <summary>
        /// Enum Ttl for "ttl"
        /// </summary>
        [EnumMember(Value = "ttl")]
        Ttl
    }
    /// <summary>
    /// The name of the workitem date attribute.
    /// </summary>
    /// <value>The name of the workitem date attribute.</value>
    [JsonPropertyName("attribute")]
    public AttributeEnum? Attribute { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemDateBasedCondition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkitemDateBasedCondition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemDateBasedCondition" /> class.
    /// </summary>
    /// <param name="Attribute">The name of the workitem date attribute. (required).</param>
    /// <param name="RelativeMinutesToInvocation">The time in minutes before or after the date attribute. (required).</param>
    public WorkitemDateBasedCondition(AttributeEnum? Attribute = null, int? RelativeMinutesToInvocation = null)
    {
        this.Attribute = Attribute;
        this.RelativeMinutesToInvocation = RelativeMinutesToInvocation;

    }





    /// <summary>
    /// The time in minutes before or after the date attribute.
    /// </summary>
    /// <value>The time in minutes before or after the date attribute.</value>
    [JsonPropertyName("relativeMinutesToInvocation")]
    public int? RelativeMinutesToInvocation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemDateBasedCondition {\n");

        sb.Append("  Attribute: ").Append(Attribute).Append("\n");
        sb.Append("  RelativeMinutesToInvocation: ").Append(RelativeMinutesToInvocation).Append("\n");
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
        return Equals(obj as WorkitemDateBasedCondition);
    }

    /// <summary>
    /// Returns true if WorkitemDateBasedCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemDateBasedCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemDateBasedCondition other)
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
                RelativeMinutesToInvocation == other.RelativeMinutesToInvocation ||
                RelativeMinutesToInvocation != null &&
                RelativeMinutesToInvocation.Equals(other.RelativeMinutesToInvocation)
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

            if (RelativeMinutesToInvocation != null)
            {
                hash = hash * 59 + RelativeMinutesToInvocation.GetHashCode();
            }

            return hash;
        }
    }
}
