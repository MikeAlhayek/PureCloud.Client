using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// the schedule pattern
/// </summary>
[DataContract]
public partial class DialerCampaignScheduleConfigChangeRecurrencePattern : IEquatable<DialerCampaignScheduleConfigChangeRecurrencePattern>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Daily for "Daily"
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily,

        /// <summary>
        /// Enum Weekly for "Weekly"
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerCampaignScheduleConfigChangeRecurrencePattern" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="Interval">the amount of time in between occurrences.</param>
    /// <param name="DaysOfWeek">the day(s) of the week the occurrence happens.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerCampaignScheduleConfigChangeRecurrencePattern(TypeEnum? Type = null, long? Interval = null, List<string> DaysOfWeek = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Type = Type;
        this.Interval = Interval;
        this.DaysOfWeek = DaysOfWeek;
        this.AdditionalProperties = AdditionalProperties;

    }





    /// <summary>
    /// the amount of time in between occurrences
    /// </summary>
    /// <value>the amount of time in between occurrences</value>
    [DataMember(Name = "interval", EmitDefaultValue = false)]
    public long? Interval { get; set; }



    /// <summary>
    /// the day(s) of the week the occurrence happens
    /// </summary>
    /// <value>the day(s) of the week the occurrence happens</value>
    [DataMember(Name = "daysOfWeek", EmitDefaultValue = false)]
    public List<string> DaysOfWeek { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerCampaignScheduleConfigChangeRecurrencePattern {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as DialerCampaignScheduleConfigChangeRecurrencePattern);
    }

    /// <summary>
    /// Returns true if DialerCampaignScheduleConfigChangeRecurrencePattern instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerCampaignScheduleConfigChangeRecurrencePattern to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerCampaignScheduleConfigChangeRecurrencePattern other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                DaysOfWeek == other.DaysOfWeek ||
                DaysOfWeek != null &&
                DaysOfWeek.SequenceEqual(other.DaysOfWeek)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (DaysOfWeek != null)
            {
                hash = hash * 59 + DaysOfWeek.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
