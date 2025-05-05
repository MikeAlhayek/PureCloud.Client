using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyWebActionEventsNotificationActionMapPageUrlCondition
/// </summary>

public partial class JourneyWebActionEventsNotificationActionMapPageUrlCondition : IEquatable<JourneyWebActionEventsNotificationActionMapPageUrlCondition>
{
    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Equal for "equal"
        /// </summary>
        [EnumMember(Value = "equal")]
        Equal,

        /// <summary>
        /// Enum Notequal for "notEqual"
        /// </summary>
        [EnumMember(Value = "notEqual")]
        Notequal,

        /// <summary>
        /// Enum Like for "like"
        /// </summary>
        [EnumMember(Value = "like")]
        Like,

        /// <summary>
        /// Enum Notlike for "notLike"
        /// </summary>
        [EnumMember(Value = "notLike")]
        Notlike,

        /// <summary>
        /// Enum Greaterthan for "greaterThan"
        /// </summary>
        [EnumMember(Value = "greaterThan")]
        Greaterthan,

        /// <summary>
        /// Enum Greaterthanorequal for "greaterThanOrEqual"
        /// </summary>
        [EnumMember(Value = "greaterThanOrEqual")]
        Greaterthanorequal,

        /// <summary>
        /// Enum Lessthan for "lessThan"
        /// </summary>
        [EnumMember(Value = "lessThan")]
        Lessthan,

        /// <summary>
        /// Enum Lessthanorequal for "lessThanOrEqual"
        /// </summary>
        [EnumMember(Value = "lessThanOrEqual")]
        Lessthanorequal,

        /// <summary>
        /// Enum Startswith for "startsWith"
        /// </summary>
        [EnumMember(Value = "startsWith")]
        Startswith,

        /// <summary>
        /// Enum Endswith for "endsWith"
        /// </summary>
        [EnumMember(Value = "endsWith")]
        Endswith,

        /// <summary>
        /// Enum Containsany for "containsAny"
        /// </summary>
        [EnumMember(Value = "containsAny")]
        Containsany,

        /// <summary>
        /// Enum Notcontainsany for "notContainsAny"
        /// </summary>
        [EnumMember(Value = "notContainsAny")]
        Notcontainsany,

        /// <summary>
        /// Enum Containsall for "containsAll"
        /// </summary>
        [EnumMember(Value = "containsAll")]
        Containsall,

        /// <summary>
        /// Enum Notcontainsal for "notContainsAl"
        /// </summary>
        [EnumMember(Value = "notContainsAl")]
        Notcontainsal
    }
    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyWebActionEventsNotificationActionMapPageUrlCondition" /> class.
    /// </summary>
    /// <param name="Values">Values.</param>
    /// <param name="Operator">Operator.</param>
    public JourneyWebActionEventsNotificationActionMapPageUrlCondition(List<string> Values = null, OperatorEnum? Operator = null)
    {
        this.Values = Values;
        this.Operator = Operator;

    }



    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyWebActionEventsNotificationActionMapPageUrlCondition {\n");

        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
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
        return Equals(obj as JourneyWebActionEventsNotificationActionMapPageUrlCondition);
    }

    /// <summary>
    /// Returns true if JourneyWebActionEventsNotificationActionMapPageUrlCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyWebActionEventsNotificationActionMapPageUrlCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyWebActionEventsNotificationActionMapPageUrlCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
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
            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            return hash;
        }
    }
}
