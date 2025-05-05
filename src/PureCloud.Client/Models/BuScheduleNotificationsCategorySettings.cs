using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuScheduleNotificationsCategorySettings
/// </summary>

public partial class BuScheduleNotificationsCategorySettings : IEquatable<BuScheduleNotificationsCategorySettings>
{
    /// <summary>
    /// The activity category
    /// </summary>
    /// <value>The activity category</value>
    
    public enum ActivityCategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Onqueuework for "OnQueueWork"
        /// </summary>
        [EnumMember(Value = "OnQueueWork")]
        Onqueuework,

        /// <summary>
        /// Enum Break for "Break"
        /// </summary>
        [EnumMember(Value = "Break")]
        Break,

        /// <summary>
        /// Enum Meal for "Meal"
        /// </summary>
        [EnumMember(Value = "Meal")]
        Meal,

        /// <summary>
        /// Enum Meeting for "Meeting"
        /// </summary>
        [EnumMember(Value = "Meeting")]
        Meeting,

        /// <summary>
        /// Enum Offqueuework for "OffQueueWork"
        /// </summary>
        [EnumMember(Value = "OffQueueWork")]
        Offqueuework,

        /// <summary>
        /// Enum Timeoff for "TimeOff"
        /// </summary>
        [EnumMember(Value = "TimeOff")]
        Timeoff,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Unavailable for "Unavailable"
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,

        /// <summary>
        /// Enum Unscheduled for "Unscheduled"
        /// </summary>
        [EnumMember(Value = "Unscheduled")]
        Unscheduled
    }
    /// <summary>
    /// The activity category
    /// </summary>
    /// <value>The activity category</value>
    [JsonPropertyName("activityCategory")]
    public ActivityCategoryEnum? ActivityCategory { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BuScheduleNotificationsCategorySettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuScheduleNotificationsCategorySettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuScheduleNotificationsCategorySettings" /> class.
    /// </summary>
    /// <param name="ActivityCategory">The activity category (required).</param>
    /// <param name="EarlyReminderEnabled">Indicates if agents should receive early schedule reminder notifications. (required).</param>
    /// <param name="OnTimeReminderEnabled">Indicates if agents should receive out of adherence notifications. (required).</param>
    public BuScheduleNotificationsCategorySettings(ActivityCategoryEnum? ActivityCategory = null, bool? EarlyReminderEnabled = null, bool? OnTimeReminderEnabled = null)
    {
        this.ActivityCategory = ActivityCategory;
        this.EarlyReminderEnabled = EarlyReminderEnabled;
        this.OnTimeReminderEnabled = OnTimeReminderEnabled;

    }





    /// <summary>
    /// Indicates if agents should receive early schedule reminder notifications.
    /// </summary>
    /// <value>Indicates if agents should receive early schedule reminder notifications.</value>
    [JsonPropertyName("earlyReminderEnabled")]
    public bool? EarlyReminderEnabled { get; set; }



    /// <summary>
    /// Indicates if agents should receive out of adherence notifications.
    /// </summary>
    /// <value>Indicates if agents should receive out of adherence notifications.</value>
    [JsonPropertyName("onTimeReminderEnabled")]
    public bool? OnTimeReminderEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuScheduleNotificationsCategorySettings {\n");

        sb.Append("  ActivityCategory: ").Append(ActivityCategory).Append("\n");
        sb.Append("  EarlyReminderEnabled: ").Append(EarlyReminderEnabled).Append("\n");
        sb.Append("  OnTimeReminderEnabled: ").Append(OnTimeReminderEnabled).Append("\n");
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
        return Equals(obj as BuScheduleNotificationsCategorySettings);
    }

    /// <summary>
    /// Returns true if BuScheduleNotificationsCategorySettings instances are equal
    /// </summary>
    /// <param name="other">Instance of BuScheduleNotificationsCategorySettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuScheduleNotificationsCategorySettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActivityCategory == other.ActivityCategory ||
                ActivityCategory != null &&
                ActivityCategory.Equals(other.ActivityCategory)
            ) &&
            (
                EarlyReminderEnabled == other.EarlyReminderEnabled ||
                EarlyReminderEnabled != null &&
                EarlyReminderEnabled.Equals(other.EarlyReminderEnabled)
            ) &&
            (
                OnTimeReminderEnabled == other.OnTimeReminderEnabled ||
                OnTimeReminderEnabled != null &&
                OnTimeReminderEnabled.Equals(other.OnTimeReminderEnabled)
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
            if (ActivityCategory != null)
            {
                hash = hash * 59 + ActivityCategory.GetHashCode();
            }

            if (EarlyReminderEnabled != null)
            {
                hash = hash * 59 + EarlyReminderEnabled.GetHashCode();
            }

            if (OnTimeReminderEnabled != null)
            {
                hash = hash * 59 + OnTimeReminderEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
