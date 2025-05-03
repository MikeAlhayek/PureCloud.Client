using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ManagementUnit
/// </summary>

public partial class ManagementUnit : IEquatable<ManagementUnit>
{
    /// <summary>
    /// Start day of week for scheduling and forecasting purposes. Moving to Business Unit
    /// </summary>
    /// <value>Start day of week for scheduling and forecasting purposes. Moving to Business Unit</value>
    
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
    /// Start day of week for scheduling and forecasting purposes. Moving to Business Unit
    /// </summary>
    /// <value>Start day of week for scheduling and forecasting purposes. Moving to Business Unit</value>
    [JsonPropertyName("startDayOfWeek")]
    public StartDayOfWeekEnum? StartDayOfWeek { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ManagementUnit" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="BusinessUnit">The business unit to which this management unit belongs.</param>
    /// <param name="StartDayOfWeek">Start day of week for scheduling and forecasting purposes. Moving to Business Unit.</param>
    /// <param name="TimeZone">The time zone for the management unit in standard Olson format.  Moving to Business Unit.</param>
    /// <param name="Settings">The configuration settings for this management unit.</param>
    /// <param name="Metadata">Version info metadata for this management unit. Deprecated, use settings.metadata.</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    public ManagementUnit(string Name = null, BusinessUnitReference BusinessUnit = null, StartDayOfWeekEnum? StartDayOfWeek = null, string TimeZone = null, ManagementUnitSettingsResponse Settings = null, WfmVersionedEntityMetadata Metadata = null, DivisionReference Division = null)
    {
        this.Name = Name;
        this.BusinessUnit = BusinessUnit;
        this.StartDayOfWeek = StartDayOfWeek;
        this.TimeZone = TimeZone;
        this.Settings = Settings;
        this.Metadata = Metadata;
        this.Division = Division;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The business unit to which this management unit belongs
    /// </summary>
    /// <value>The business unit to which this management unit belongs</value>
    [JsonPropertyName("businessUnit")]
    public BusinessUnitReference BusinessUnit { get; set; }





    /// <summary>
    /// The time zone for the management unit in standard Olson format.  Moving to Business Unit
    /// </summary>
    /// <value>The time zone for the management unit in standard Olson format.  Moving to Business Unit</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }



    /// <summary>
    /// The configuration settings for this management unit
    /// </summary>
    /// <value>The configuration settings for this management unit</value>
    [JsonPropertyName("settings")]
    public ManagementUnitSettingsResponse Settings { get; set; }



    /// <summary>
    /// Version info metadata for this management unit. Deprecated, use settings.metadata
    /// </summary>
    /// <value>Version info metadata for this management unit. Deprecated, use settings.metadata</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public DivisionReference Division { get; set; }



    /// <summary>
    /// The version of the underlying entity.  Deprecated, use field from settings.metadata instead
    /// </summary>
    /// <value>The version of the underlying entity.  Deprecated, use field from settings.metadata instead</value>
    [JsonPropertyName("version")]
    public int? Version { get; private set; }



    /// <summary>
    /// The date and time at which this entity was last modified.  Deprecated, use field from settings.metadata instead. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time at which this entity was last modified.  Deprecated, use field from settings.metadata instead. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The user who last modified this entity.  Deprecated, use field from settings.metadata instead
    /// </summary>
    /// <value>The user who last modified this entity.  Deprecated, use field from settings.metadata instead</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ManagementUnit {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
        sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as ManagementUnit);
    }

    /// <summary>
    /// Returns true if ManagementUnit instances are equal
    /// </summary>
    /// <param name="other">Instance of ManagementUnit to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ManagementUnit other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                BusinessUnit == other.BusinessUnit ||
                BusinessUnit != null &&
                BusinessUnit.Equals(other.BusinessUnit)
            ) &&
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
                Settings == other.Settings ||
                Settings != null &&
                Settings.Equals(other.Settings)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (BusinessUnit != null)
            {
                hash = hash * 59 + BusinessUnit.GetHashCode();
            }

            if (StartDayOfWeek != null)
            {
                hash = hash * 59 + StartDayOfWeek.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (Settings != null)
            {
                hash = hash * 59 + Settings.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
