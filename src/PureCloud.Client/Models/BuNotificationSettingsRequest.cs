using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuNotificationSettingsRequest
/// </summary>

public partial class BuNotificationSettingsRequest : IEquatable<BuNotificationSettingsRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuNotificationSettingsRequest" /> class.
    /// </summary>
    /// <param name="Scheduling">Schedule notification settings.</param>
    public BuNotificationSettingsRequest(BuScheduleNotificationsSettingsRequest Scheduling = null)
    {
        this.Scheduling = Scheduling;

    }



    /// <summary>
    /// Schedule notification settings
    /// </summary>
    /// <value>Schedule notification settings</value>
    [JsonPropertyName("scheduling")]
    public BuScheduleNotificationsSettingsRequest Scheduling { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuNotificationSettingsRequest {\n");

        sb.Append("  Scheduling: ").Append(Scheduling).Append("\n");
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
        return Equals(obj as BuNotificationSettingsRequest);
    }

    /// <summary>
    /// Returns true if BuNotificationSettingsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuNotificationSettingsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuNotificationSettingsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Scheduling == other.Scheduling ||
                Scheduling != null &&
                Scheduling.Equals(other.Scheduling)
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
            if (Scheduling != null)
            {
                hash = hash * 59 + Scheduling.GetHashCode();
            }

            return hash;
        }
    }
}
