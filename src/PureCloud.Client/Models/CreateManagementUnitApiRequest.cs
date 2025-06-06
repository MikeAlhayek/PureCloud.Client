using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateManagementUnitApiRequest
/// </summary>

public partial class CreateManagementUnitApiRequest : IEquatable<CreateManagementUnitApiRequest>
{
    /// <summary>
    /// The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit
    /// </summary>
    /// <value>The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit</value>
    
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
    /// The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit
    /// </summary>
    /// <value>The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit</value>
    [JsonPropertyName("startDayOfWeek")]
    public StartDayOfWeekEnum? StartDayOfWeek { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateManagementUnitApiRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateManagementUnitApiRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateManagementUnitApiRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the management unit (required).</param>
    /// <param name="TimeZone">The default time zone to use for this management unit.  Moving to Business Unit.</param>
    /// <param name="StartDayOfWeek">The configured first day of the week for scheduling and forecasting purposes. Moving to Business Unit.</param>
    /// <param name="Settings">The configuration for the management unit.  If omitted, reasonable defaults will be assigned.</param>
    /// <param name="DivisionId">The id of the division to which this management unit belongs.  Defaults to home division ID.</param>
    /// <param name="BusinessUnitId">The id of the business unit to which this management unit belongs (required).</param>
    public CreateManagementUnitApiRequest(string Name = null, string TimeZone = null, StartDayOfWeekEnum? StartDayOfWeek = null, CreateManagementUnitSettingsRequest Settings = null, string DivisionId = null, string BusinessUnitId = null)
    {
        this.Name = Name;
        this.TimeZone = TimeZone;
        this.StartDayOfWeek = StartDayOfWeek;
        this.Settings = Settings;
        this.DivisionId = DivisionId;
        this.BusinessUnitId = BusinessUnitId;

    }



    /// <summary>
    /// The name of the management unit
    /// </summary>
    /// <value>The name of the management unit</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The default time zone to use for this management unit.  Moving to Business Unit
    /// </summary>
    /// <value>The default time zone to use for this management unit.  Moving to Business Unit</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }





    /// <summary>
    /// The configuration for the management unit.  If omitted, reasonable defaults will be assigned
    /// </summary>
    /// <value>The configuration for the management unit.  If omitted, reasonable defaults will be assigned</value>
    [JsonPropertyName("settings")]
    public CreateManagementUnitSettingsRequest Settings { get; set; }



    /// <summary>
    /// The id of the division to which this management unit belongs.  Defaults to home division ID
    /// </summary>
    /// <value>The id of the division to which this management unit belongs.  Defaults to home division ID</value>
    [JsonPropertyName("divisionId")]
    public string DivisionId { get; set; }



    /// <summary>
    /// The id of the business unit to which this management unit belongs
    /// </summary>
    /// <value>The id of the business unit to which this management unit belongs</value>
    [JsonPropertyName("businessUnitId")]
    public string BusinessUnitId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateManagementUnitApiRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
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
        return Equals(obj as CreateManagementUnitApiRequest);
    }

    /// <summary>
    /// Returns true if CreateManagementUnitApiRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateManagementUnitApiRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateManagementUnitApiRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                StartDayOfWeek == other.StartDayOfWeek ||
                StartDayOfWeek != null &&
                StartDayOfWeek.Equals(other.StartDayOfWeek)
            ) &&
            (
                Settings == other.Settings ||
                Settings != null &&
                Settings.Equals(other.Settings)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                BusinessUnitId == other.BusinessUnitId ||
                BusinessUnitId != null &&
                BusinessUnitId.Equals(other.BusinessUnitId)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (StartDayOfWeek != null)
            {
                hash = hash * 59 + StartDayOfWeek.GetHashCode();
            }

            if (Settings != null)
            {
                hash = hash * 59 + Settings.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (BusinessUnitId != null)
            {
                hash = hash * 59 + BusinessUnitId.GetHashCode();
            }

            return hash;
        }
    }
}
