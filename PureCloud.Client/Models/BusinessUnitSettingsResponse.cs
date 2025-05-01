using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BusinessUnitSettingsResponse
/// </summary>
[DataContract]
public partial class BusinessUnitSettingsResponse : IEquatable<BusinessUnitSettingsResponse>
{
    /// <summary>
    /// The start day of week for this business unit
    /// </summary>
    /// <value>The start day of week for this business unit</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "startDayOfWeek", EmitDefaultValue = false)]
    public StartDayOfWeekEnum? StartDayOfWeek { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessUnitSettingsResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BusinessUnitSettingsResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessUnitSettingsResponse" /> class.
    /// </summary>
    /// <param name="StartDayOfWeek">The start day of week for this business unit (required).</param>
    /// <param name="TimeZone">The time zone for this business unit, using the Olsen tz database format (required).</param>
    /// <param name="ShortTermForecasting">Short term forecasting settings.</param>
    /// <param name="Scheduling">Scheduling settings.</param>
    /// <param name="Notifications">Notification settings.</param>
    /// <param name="Metadata">Version metadata for this business unit (required).</param>
    public BusinessUnitSettingsResponse(StartDayOfWeekEnum? StartDayOfWeek = null, string TimeZone = null, BuShortTermForecastingSettings ShortTermForecasting = null, BuSchedulingSettingsResponse Scheduling = null, BuNotificationSettingsResponse Notifications = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.StartDayOfWeek = StartDayOfWeek;
        this.TimeZone = TimeZone;
        this.ShortTermForecasting = ShortTermForecasting;
        this.Scheduling = Scheduling;
        this.Notifications = Notifications;
        this.Metadata = Metadata;

    }





    /// <summary>
    /// The time zone for this business unit, using the Olsen tz database format
    /// </summary>
    /// <value>The time zone for this business unit, using the Olsen tz database format</value>
    [DataMember(Name = "timeZone", EmitDefaultValue = false)]
    public string TimeZone { get; set; }



    /// <summary>
    /// Short term forecasting settings
    /// </summary>
    /// <value>Short term forecasting settings</value>
    [DataMember(Name = "shortTermForecasting", EmitDefaultValue = false)]
    public BuShortTermForecastingSettings ShortTermForecasting { get; set; }



    /// <summary>
    /// Scheduling settings
    /// </summary>
    /// <value>Scheduling settings</value>
    [DataMember(Name = "scheduling", EmitDefaultValue = false)]
    public BuSchedulingSettingsResponse Scheduling { get; set; }



    /// <summary>
    /// Notification settings
    /// </summary>
    /// <value>Notification settings</value>
    [DataMember(Name = "notifications", EmitDefaultValue = false)]
    public BuNotificationSettingsResponse Notifications { get; set; }



    /// <summary>
    /// Version metadata for this business unit
    /// </summary>
    /// <value>Version metadata for this business unit</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BusinessUnitSettingsResponse {\n");

        sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  ShortTermForecasting: ").Append(ShortTermForecasting).Append("\n");
        sb.Append("  Scheduling: ").Append(Scheduling).Append("\n");
        sb.Append("  Notifications: ").Append(Notifications).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as BusinessUnitSettingsResponse);
    }

    /// <summary>
    /// Returns true if BusinessUnitSettingsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BusinessUnitSettingsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BusinessUnitSettingsResponse other)
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
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
