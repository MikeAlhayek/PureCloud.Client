using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A link between elements in a journey view
/// </summary>

public partial class JourneyViewLink : IEquatable<JourneyViewLink>
{
    /// <summary>
    /// The type of events that will be counted. Note: Concurrent will override any JourneyViewLinkTimeConstraint. Default is Sequential.
    /// </summary>
    /// <value>The type of events that will be counted. Note: Concurrent will override any JourneyViewLinkTimeConstraint. Default is Sequential.</value>
    
    public enum EventCountTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All,

        /// <summary>
        /// Enum Concurrent for "Concurrent"
        /// </summary>
        [EnumMember(Value = "Concurrent")]
        Concurrent,

        /// <summary>
        /// Enum Sequential for "Sequential"
        /// </summary>
        [EnumMember(Value = "Sequential")]
        Sequential
    }
    /// <summary>
    /// The type of events that will be counted. Note: Concurrent will override any JourneyViewLinkTimeConstraint. Default is Sequential.
    /// </summary>
    /// <value>The type of events that will be counted. Note: Concurrent will override any JourneyViewLinkTimeConstraint. Default is Sequential.</value>
    [JsonPropertyName("eventCountType")]
    public EventCountTypeEnum? EventCountType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewLink" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewLink() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewLink" /> class.
    /// </summary>
    /// <param name="Id">The identifier of the element downstream (required).</param>
    /// <param name="ConstraintWithin">A time constraint on this link, which requires a customer to complete the downstream element within this amount of time to be counted..</param>
    /// <param name="ConstraintAfter">A time constraint on this link, which requires a customer must complete the downstream element after this amount of time to be counted..</param>
    /// <param name="EventCountType">The type of events that will be counted. Note: Concurrent will override any JourneyViewLinkTimeConstraint. Default is Sequential..</param>
    /// <param name="JoinAttributes">Other (secondary) attributes on which this link should join the customers being counted.</param>
    public JourneyViewLink(string Id = null, JourneyViewLinkTimeConstraint ConstraintWithin = null, JourneyViewLinkTimeConstraint ConstraintAfter = null, EventCountTypeEnum? EventCountType = null, List<string> JoinAttributes = null)
    {
        this.Id = Id;
        this.ConstraintWithin = ConstraintWithin;
        this.ConstraintAfter = ConstraintAfter;
        this.EventCountType = EventCountType;
        this.JoinAttributes = JoinAttributes;

    }



    /// <summary>
    /// The identifier of the element downstream
    /// </summary>
    /// <value>The identifier of the element downstream</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// A time constraint on this link, which requires a customer to complete the downstream element within this amount of time to be counted.
    /// </summary>
    /// <value>A time constraint on this link, which requires a customer to complete the downstream element within this amount of time to be counted.</value>
    [JsonPropertyName("constraintWithin")]
    public JourneyViewLinkTimeConstraint ConstraintWithin { get; set; }



    /// <summary>
    /// A time constraint on this link, which requires a customer must complete the downstream element after this amount of time to be counted.
    /// </summary>
    /// <value>A time constraint on this link, which requires a customer must complete the downstream element after this amount of time to be counted.</value>
    [JsonPropertyName("constraintAfter")]
    public JourneyViewLinkTimeConstraint ConstraintAfter { get; set; }





    /// <summary>
    /// Other (secondary) attributes on which this link should join the customers being counted
    /// </summary>
    /// <value>Other (secondary) attributes on which this link should join the customers being counted</value>
    [JsonPropertyName("joinAttributes")]
    public List<string> JoinAttributes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewLink {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ConstraintWithin: ").Append(ConstraintWithin).Append("\n");
        sb.Append("  ConstraintAfter: ").Append(ConstraintAfter).Append("\n");
        sb.Append("  EventCountType: ").Append(EventCountType).Append("\n");
        sb.Append("  JoinAttributes: ").Append(JoinAttributes).Append("\n");
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
        return Equals(obj as JourneyViewLink);
    }

    /// <summary>
    /// Returns true if JourneyViewLink instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewLink to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewLink other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                ConstraintWithin == other.ConstraintWithin ||
                ConstraintWithin != null &&
                ConstraintWithin.Equals(other.ConstraintWithin)
            ) &&
            (
                ConstraintAfter == other.ConstraintAfter ||
                ConstraintAfter != null &&
                ConstraintAfter.Equals(other.ConstraintAfter)
            ) &&
            (
                EventCountType == other.EventCountType ||
                EventCountType != null &&
                EventCountType.Equals(other.EventCountType)
            ) &&
            (
                JoinAttributes == other.JoinAttributes ||
                JoinAttributes != null &&
                JoinAttributes.SequenceEqual(other.JoinAttributes)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (ConstraintWithin != null)
            {
                hash = hash * 59 + ConstraintWithin.GetHashCode();
            }

            if (ConstraintAfter != null)
            {
                hash = hash * 59 + ConstraintAfter.GetHashCode();
            }

            if (EventCountType != null)
            {
                hash = hash * 59 + EventCountType.GetHashCode();
            }

            if (JoinAttributes != null)
            {
                hash = hash * 59 + JoinAttributes.GetHashCode();
            }

            return hash;
        }
    }
}
