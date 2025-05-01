using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerCampaignScheduleConfigChangeScheduleInterval
/// </summary>
[DataContract]
public partial class DialerCampaignScheduleConfigChangeScheduleInterval : IEquatable<DialerCampaignScheduleConfigChangeScheduleInterval>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerCampaignScheduleConfigChangeScheduleInterval" /> class.
    /// </summary>
    /// <param name="Start">scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
    /// <param name="End">scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerCampaignScheduleConfigChangeScheduleInterval(string Start = null, string End = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Start = Start;
        this.End = End;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ
    /// </summary>
    /// <value>scheduled start time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ</value>
    [DataMember(Name = "start", EmitDefaultValue = false)]
    public string Start { get; set; }



    /// <summary>
    /// scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ
    /// </summary>
    /// <value>scheduled end time represented as an ISO-8601 string; for example, yyyy-MM-ddTHH:mm:ss.SSSZ</value>
    [DataMember(Name = "end", EmitDefaultValue = false)]
    public string End { get; set; }



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
        sb.Append("class DialerCampaignScheduleConfigChangeScheduleInterval {\n");

        sb.Append("  Start: ").Append(Start).Append("\n");
        sb.Append("  End: ").Append(End).Append("\n");
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
        return Equals(obj as DialerCampaignScheduleConfigChangeScheduleInterval);
    }

    /// <summary>
    /// Returns true if DialerCampaignScheduleConfigChangeScheduleInterval instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerCampaignScheduleConfigChangeScheduleInterval to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerCampaignScheduleConfigChangeScheduleInterval other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Start == other.Start ||
                Start != null &&
                Start.Equals(other.Start)
            ) &&
            (
                End == other.End ||
                End != null &&
                End.Equals(other.End)
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
            if (Start != null)
            {
                hash = hash * 59 + Start.GetHashCode();
            }

            if (End != null)
            {
                hash = hash * 59 + End.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
