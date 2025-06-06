using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateBusinessUnitSettingsRequest
/// </summary>

public partial class CreateBusinessUnitSettingsRequest : IEquatable<CreateBusinessUnitSettingsRequest>
{
    /// <summary>
    /// The start day of week for this business unit
    /// </summary>
    /// <value>The start day of week for this business unit</value>
    
    public enum StartDayOfWeekEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sunday for "Sunday"
        /// </summary>
        [EnumMember(Value = "Sunday")]
        Sunday,

        /// <summary>
        /// Enum Monday for "Monday"
        /// </summary>
        [EnumMember(Value = "Monday")]
        Monday,

        /// <summary>
        /// Enum Tuesday for "Tuesday"
        /// </summary>
        [EnumMember(Value = "Tuesday")]
        Tuesday,

        /// <summary>
        /// Enum Wednesday for "Wednesday"
        /// </summary>
        [EnumMember(Value = "Wednesday")]
        Wednesday,

        /// <summary>
        /// Enum Thursday for "Thursday"
        /// </summary>
        [EnumMember(Value = "Thursday")]
        Thursday,

        /// <summary>
        /// Enum Friday for "Friday"
        /// </summary>
        [EnumMember(Value = "Friday")]
        Friday,

        /// <summary>
        /// Enum Saturday for "Saturday"
        /// </summary>
        [EnumMember(Value = "Saturday")]
        Saturday
    }
    /// <summary>
    /// The start day of week for this business unit
    /// </summary>
    /// <value>The start day of week for this business unit</value>
    [JsonPropertyName("startDayOfWeek")]
    public StartDayOfWeekEnum? StartDayOfWeek { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateBusinessUnitSettingsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateBusinessUnitSettingsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateBusinessUnitSettingsRequest" /> class.
    /// </summary>
    /// <param name="StartDayOfWeek">The start day of week for this business unit (required).</param>
    /// <param name="TimeZone">The time zone for this business unit, using the Olsen tz database format (required).</param>
    /// <param name="ShortTermForecasting">Short term forecasting settings.</param>
    /// <param name="Scheduling">Scheduling settings.</param>
    /// <param name="Notifications">Notification settings.</param>
    public CreateBusinessUnitSettingsRequest(StartDayOfWeekEnum? StartDayOfWeek = null, string TimeZone = null, BuShortTermForecastingSettings ShortTermForecasting = null, BuSchedulingSettingsRequest Scheduling = null, BuNotificationSettingsRequest Notifications = null)
    {
        this.StartDayOfWeek = StartDayOfWeek;
        this.TimeZone = TimeZone;
        this.ShortTermForecasting = ShortTermForecasting;
        this.Scheduling = Scheduling;
        this.Notifications = Notifications;

    }





    /// <summary>
    /// The time zone for this business unit, using the Olsen tz database format
    /// </summary>
    /// <value>The time zone for this business unit, using the Olsen tz database format</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }



    /// <summary>
    /// Short term forecasting settings
    /// </summary>
    /// <value>Short term forecasting settings</value>
    [JsonPropertyName("shortTermForecasting")]
    public BuShortTermForecastingSettings ShortTermForecasting { get; set; }



    /// <summary>
    /// Scheduling settings
    /// </summary>
    /// <value>Scheduling settings</value>
    [JsonPropertyName("scheduling")]
    public BuSchedulingSettingsRequest Scheduling { get; set; }



    /// <summary>
    /// Notification settings
    /// </summary>
    /// <value>Notification settings</value>
    [JsonPropertyName("notifications")]
    public BuNotificationSettingsRequest Notifications { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateBusinessUnitSettingsRequest {\n");

        sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  ShortTermForecasting: ").Append(ShortTermForecasting).Append("\n");
        sb.Append("  Scheduling: ").Append(Scheduling).Append("\n");
        sb.Append("  Notifications: ").Append(Notifications).Append("\n");
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
        return Equals(obj as CreateBusinessUnitSettingsRequest);
    }

    /// <summary>
    /// Returns true if CreateBusinessUnitSettingsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateBusinessUnitSettingsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateBusinessUnitSettingsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartDayOfWeek == other.StartDayOfWeek ||
                StartDayOfWeek != null &&
                StartDayOfWeek.Equals(other.StartDayOfWeek)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                ShortTermForecasting == other.ShortTermForecasting ||
                ShortTermForecasting != null &&
                ShortTermForecasting.Equals(other.ShortTermForecasting)
            ) &&
            (
                Scheduling == other.Scheduling ||
                Scheduling != null &&
                Scheduling.Equals(other.Scheduling)
            ) &&
            (
                Notifications == other.Notifications ||
                Notifications != null &&
                Notifications.Equals(other.Notifications)
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
            if (StartDayOfWeek != null)
            {
                hash = hash * 59 + StartDayOfWeek.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (ShortTermForecasting != null)
            {
                hash = hash * 59 + ShortTermForecasting.GetHashCode();
            }

            if (Scheduling != null)
            {
                hash = hash * 59 + Scheduling.GetHashCode();
            }

            if (Notifications != null)
            {
                hash = hash * 59 + Notifications.GetHashCode();
            }

            return hash;
        }
    }
}
