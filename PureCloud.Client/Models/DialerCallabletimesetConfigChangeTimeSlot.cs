using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerCallabletimesetConfigChangeTimeSlot
/// </summary>
[DataContract]
public partial class DialerCallabletimesetConfigChangeTimeSlot : IEquatable<DialerCallabletimesetConfigChangeTimeSlot>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerCallabletimesetConfigChangeTimeSlot" /> class.
    /// </summary>
    /// <param name="StartTime">The start time of this time slot.</param>
    /// <param name="StopTime">The stop time of this time slot.</param>
    /// <param name="Day">The day this time slot applies.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerCallabletimesetConfigChangeTimeSlot(string StartTime = null, string StopTime = null, long? Day = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.StartTime = StartTime;
        this.StopTime = StopTime;
        this.Day = Day;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// The start time of this time slot
    /// </summary>
    /// <value>The start time of this time slot</value>
    [DataMember(Name = "startTime", EmitDefaultValue = false)]
    public string StartTime { get; set; }



    /// <summary>
    /// The stop time of this time slot
    /// </summary>
    /// <value>The stop time of this time slot</value>
    [DataMember(Name = "stopTime", EmitDefaultValue = false)]
    public string StopTime { get; set; }



    /// <summary>
    /// The day this time slot applies
    /// </summary>
    /// <value>The day this time slot applies</value>
    [DataMember(Name = "day", EmitDefaultValue = false)]
    public long? Day { get; set; }



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
        sb.Append("class DialerCallabletimesetConfigChangeTimeSlot {\n");

        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  StopTime: ").Append(StopTime).Append("\n");
        sb.Append("  Day: ").Append(Day).Append("\n");
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
        return Equals(obj as DialerCallabletimesetConfigChangeTimeSlot);
    }

    /// <summary>
    /// Returns true if DialerCallabletimesetConfigChangeTimeSlot instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerCallabletimesetConfigChangeTimeSlot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerCallabletimesetConfigChangeTimeSlot other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartTime == other.StartTime ||
                StartTime != null &&
                StartTime.Equals(other.StartTime)
            ) &&
            (
                StopTime == other.StopTime ||
                StopTime != null &&
                StopTime.Equals(other.StopTime)
            ) &&
            (
                Day == other.Day ||
                Day != null &&
                Day.Equals(other.Day)
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
            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (StopTime != null)
            {
                hash = hash * 59 + StopTime.GetHashCode();
            }

            if (Day != null)
            {
                hash = hash * 59 + Day.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
