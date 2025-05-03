using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuNotificationSettingsResponse
/// </summary>

public partial class BuNotificationSettingsResponse : IEquatable<BuNotificationSettingsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuNotificationSettingsResponse" /> class.
    /// </summary>
    /// <param name="Scheduling">Schedule notification settings.</param>
    public BuNotificationSettingsResponse(BuScheduleNotificationsSettingsResponse Scheduling = null)
    {
        this.Scheduling = Scheduling;

    }



    /// <summary>
    /// Schedule notification settings
    /// </summary>
    /// <value>Schedule notification settings</value>
    [JsonPropertyName("scheduling")]
    public BuScheduleNotificationsSettingsResponse Scheduling { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuNotificationSettingsResponse {\n");

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
        return Equals(obj as BuNotificationSettingsResponse);
    }

    /// <summary>
    /// Returns true if BuNotificationSettingsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuNotificationSettingsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuNotificationSettingsResponse other)
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
