using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserInsightsTrend
/// </summary>
[DataContract]
public partial class UserInsightsTrend : IEquatable<UserInsightsTrend>
{
    /// <summary>
    /// Granularity
    /// </summary>
    /// <value>Granularity</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GranularityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Daily for "Daily"
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily,

        /// <summary>
        /// Enum Weekly for "Weekly"
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly,

        /// <summary>
        /// Enum Monthly for "Monthly"
        /// </summary>
        [EnumMember(Value = "Monthly")]
        Monthly
    }
    /// <summary>
    /// Granularity
    /// </summary>
    /// <value>Granularity</value>
    [DataMember(Name = "granularity", EmitDefaultValue = false)]
    public GranularityEnum? Granularity { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInsightsTrend" /> class.
    /// </summary>
    /// <param name="PerformanceProfile">The performance profile.</param>
    /// <param name="Division">The division.</param>
    /// <param name="Granularity">Granularity.</param>
    /// <param name="ComparativePeriod">The comparative period work day date range.</param>
    /// <param name="PrimaryPeriod">The primary period work day date range.</param>
    /// <param name="User">The query user.</param>
    /// <param name="Entities">The list of insights trend for each metric.</param>
    /// <param name="Total">The insights trend in total.</param>
    public UserInsightsTrend(AddressableEntityRef PerformanceProfile = null, DivisionReference Division = null, GranularityEnum? Granularity = null, WorkdayPeriod ComparativePeriod = null, WorkdayPeriod PrimaryPeriod = null, UserReference User = null, List<UserInsightsTrendMetricItem> Entities = null, UserInsightsTrendTotalItem Total = null)
    {
        this.PerformanceProfile = PerformanceProfile;
        this.Division = Division;
        this.Granularity = Granularity;
        this.ComparativePeriod = ComparativePeriod;
        this.PrimaryPeriod = PrimaryPeriod;
        this.User = User;
        this.Entities = Entities;
        this.Total = Total;

    }



    /// <summary>
    /// The performance profile
    /// </summary>
    /// <value>The performance profile</value>
    [DataMember(Name = "performanceProfile", EmitDefaultValue = false)]
    public AddressableEntityRef PerformanceProfile { get; set; }



    /// <summary>
    /// The division
    /// </summary>
    /// <value>The division</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public DivisionReference Division { get; set; }





    /// <summary>
    /// The comparative period work day date range
    /// </summary>
    /// <value>The comparative period work day date range</value>
    [DataMember(Name = "comparativePeriod", EmitDefaultValue = false)]
    public WorkdayPeriod ComparativePeriod { get; set; }



    /// <summary>
    /// The primary period work day date range
    /// </summary>
    /// <value>The primary period work day date range</value>
    [DataMember(Name = "primaryPeriod", EmitDefaultValue = false)]
    public WorkdayPeriod PrimaryPeriod { get; set; }



    /// <summary>
    /// The query user
    /// </summary>
    /// <value>The query user</value>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public UserReference User { get; set; }



    /// <summary>
    /// The list of insights trend for each metric
    /// </summary>
    /// <value>The list of insights trend for each metric</value>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<UserInsightsTrendMetricItem> Entities { get; set; }



    /// <summary>
    /// The insights trend in total
    /// </summary>
    /// <value>The insights trend in total</value>
    [DataMember(Name = "total", EmitDefaultValue = false)]
    public UserInsightsTrendTotalItem Total { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserInsightsTrend {\n");

        sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
        sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
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
        return Equals(obj as UserInsightsTrend);
    }

    /// <summary>
    /// Returns true if UserInsightsTrend instances are equal
    /// </summary>
    /// <param name="other">Instance of UserInsightsTrend to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserInsightsTrend other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PerformanceProfile == other.PerformanceProfile ||
                PerformanceProfile != null &&
                PerformanceProfile.Equals(other.PerformanceProfile)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Granularity == other.Granularity ||
                Granularity != null &&
                Granularity.Equals(other.Granularity)
            ) &&
            (
                ComparativePeriod == other.ComparativePeriod ||
                ComparativePeriod != null &&
                ComparativePeriod.Equals(other.ComparativePeriod)
            ) &&
            (
                PrimaryPeriod == other.PrimaryPeriod ||
                PrimaryPeriod != null &&
                PrimaryPeriod.Equals(other.PrimaryPeriod)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
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
            if (PerformanceProfile != null)
            {
                hash = hash * 59 + PerformanceProfile.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
            }

            if (ComparativePeriod != null)
            {
                hash = hash * 59 + ComparativePeriod.GetHashCode();
            }

            if (PrimaryPeriod != null)
            {
                hash = hash * 59 + PrimaryPeriod.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            return hash;
        }
    }
}
