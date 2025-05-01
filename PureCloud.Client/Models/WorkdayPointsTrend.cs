using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkdayPointsTrend
/// </summary>
[DataContract]
public partial class WorkdayPointsTrend : IEquatable<WorkdayPointsTrend>
{
    /// <summary>
    /// Aggregated for same day comparison
    /// </summary>
    /// <value>Aggregated for same day comparison</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DayOfWeekEnum
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
    /// Aggregated for same day comparison
    /// </summary>
    /// <value>Aggregated for same day comparison</value>
    [DataMember(Name = "dayOfWeek", EmitDefaultValue = false)]
    public DayOfWeekEnum? DayOfWeek { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkdayPointsTrend" /> class.
    /// </summary>
    public WorkdayPointsTrend()
    {

    }



    /// <summary>
    /// The start workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateStartWorkday", EmitDefaultValue = false)]
    public string DateStartWorkday { get; private set; }



    /// <summary>
    /// The end workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The end workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateEndWorkday", EmitDefaultValue = false)]
    public string DateEndWorkday { get; private set; }



    /// <summary>
    /// The targeted user for the query
    /// </summary>
    /// <value>The targeted user for the query</value>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public UserReference User { get; private set; }





    /// <summary>
    /// The total average points
    /// </summary>
    /// <value>The total average points</value>
    [DataMember(Name = "averagePoints", EmitDefaultValue = false)]
    public double? AveragePoints { get; private set; }



    /// <summary>
    /// Daily points trends
    /// </summary>
    /// <value>Daily points trends</value>
    [DataMember(Name = "trend", EmitDefaultValue = false)]
    public List<WorkdayPointsTrendItem> Trend { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkdayPointsTrend {\n");

        sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
        sb.Append("  AveragePoints: ").Append(AveragePoints).Append("\n");
        sb.Append("  Trend: ").Append(Trend).Append("\n");
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
        return this.Equals(obj as WorkdayPointsTrend);
    }

    /// <summary>
    /// Returns true if WorkdayPointsTrend instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkdayPointsTrend to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkdayPointsTrend other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.DateStartWorkday == other.DateStartWorkday ||
                this.DateStartWorkday != null &&
                this.DateStartWorkday.Equals(other.DateStartWorkday)
            ) &&
            (
                this.DateEndWorkday == other.DateEndWorkday ||
                this.DateEndWorkday != null &&
                this.DateEndWorkday.Equals(other.DateEndWorkday)
            ) &&
            (
                this.User == other.User ||
                this.User != null &&
                this.User.Equals(other.User)
            ) &&
            (
                this.DayOfWeek == other.DayOfWeek ||
                this.DayOfWeek != null &&
                this.DayOfWeek.Equals(other.DayOfWeek)
            ) &&
            (
                this.AveragePoints == other.AveragePoints ||
                this.AveragePoints != null &&
                this.AveragePoints.Equals(other.AveragePoints)
            ) &&
            (
                this.Trend == other.Trend ||
                this.Trend != null &&
                this.Trend.SequenceEqual(other.Trend)
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
            if (this.DateStartWorkday != null)
            {
                hash = hash * 59 + this.DateStartWorkday.GetHashCode();
            }

            if (this.DateEndWorkday != null)
            {
                hash = hash * 59 + this.DateEndWorkday.GetHashCode();
            }

            if (this.User != null)
            {
                hash = hash * 59 + this.User.GetHashCode();
            }

            if (this.DayOfWeek != null)
            {
                hash = hash * 59 + this.DayOfWeek.GetHashCode();
            }

            if (this.AveragePoints != null)
            {
                hash = hash * 59 + this.AveragePoints.GetHashCode();
            }

            if (this.Trend != null)
            {
                hash = hash * 59 + this.Trend.GetHashCode();
            }

            return hash;
        }
    }
}
