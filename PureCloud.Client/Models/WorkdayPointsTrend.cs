using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkdayPointsTrend
/// </summary>

public partial class WorkdayPointsTrend : IEquatable<WorkdayPointsTrend>
{
    /// <summary>
    /// Aggregated for same day comparison
    /// </summary>
    /// <value>Aggregated for same day comparison</value>
    
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
    [JsonPropertyName("dayOfWeek")]
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
    [JsonPropertyName("dateStartWorkday")]
    public string DateStartWorkday { get; private set; }



    /// <summary>
    /// The end workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The end workday for the query range for the gamification points trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEndWorkday")]
    public string DateEndWorkday { get; private set; }



    /// <summary>
    /// The targeted user for the query
    /// </summary>
    /// <value>The targeted user for the query</value>
    [JsonPropertyName("user")]
    public UserReference User { get; private set; }





    /// <summary>
    /// The total average points
    /// </summary>
    /// <value>The total average points</value>
    [JsonPropertyName("averagePoints")]
    public double? AveragePoints { get; private set; }



    /// <summary>
    /// Daily points trends
    /// </summary>
    /// <value>Daily points trends</value>
    [JsonPropertyName("trend")]
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
        return Equals(obj as WorkdayPointsTrend);
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
                DateStartWorkday == other.DateStartWorkday ||
                DateStartWorkday != null &&
                DateStartWorkday.Equals(other.DateStartWorkday)
            ) &&
            (
                DateEndWorkday == other.DateEndWorkday ||
                DateEndWorkday != null &&
                DateEndWorkday.Equals(other.DateEndWorkday)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                DayOfWeek == other.DayOfWeek ||
                DayOfWeek != null &&
                DayOfWeek.Equals(other.DayOfWeek)
            ) &&
            (
                AveragePoints == other.AveragePoints ||
                AveragePoints != null &&
                AveragePoints.Equals(other.AveragePoints)
            ) &&
            (
                Trend == other.Trend ||
                Trend != null &&
                Trend.SequenceEqual(other.Trend)
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
            if (DateStartWorkday != null)
            {
                hash = hash * 59 + DateStartWorkday.GetHashCode();
            }

            if (DateEndWorkday != null)
            {
                hash = hash * 59 + DateEndWorkday.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (DayOfWeek != null)
            {
                hash = hash * 59 + DayOfWeek.GetHashCode();
            }

            if (AveragePoints != null)
            {
                hash = hash * 59 + AveragePoints.GetHashCode();
            }

            if (Trend != null)
            {
                hash = hash * 59 + Trend.GetHashCode();
            }

            return hash;
        }
    }
}
