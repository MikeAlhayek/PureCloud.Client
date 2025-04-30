using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// BuNotificationSettingsRequest
/// </summary>
[DataContract]
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
    [DataMember(Name = "scheduling", EmitDefaultValue = false)]
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
        return this.Equals(obj as BuNotificationSettingsRequest);
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
                this.Scheduling == other.Scheduling ||
                this.Scheduling != null &&
                this.Scheduling.Equals(other.Scheduling)
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
            if (this.Scheduling != null)
            {
                hash = hash * 59 + this.Scheduling.GetHashCode();
            }

            return hash;
        }
    }
}
