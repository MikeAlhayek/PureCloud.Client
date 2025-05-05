using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InsightsDetails
/// </summary>

public partial class InsightsDetails : IEquatable<InsightsDetails>
{
    /// <summary>
    /// Granularity
    /// </summary>
    /// <value>Granularity</value>
    
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
    [JsonPropertyName("granularity")]
    public GranularityEnum? Granularity { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="InsightsDetails" /> class.
    /// </summary>
    /// <param name="PerformanceProfile">The performance profile.</param>
    /// <param name="Division">The division.</param>
    /// <param name="Granularity">Granularity.</param>
    /// <param name="ComparativePeriod">The comparative period work day date range.</param>
    /// <param name="PrimaryPeriod">The primary period work day date range.</param>
    /// <param name="User">The query user.</param>
    /// <param name="MetricData">The list of insights data for each metric of the user.</param>
    /// <param name="OverallData">Overall insights data of the user.</param>
    public InsightsDetails(AddressableEntityRef PerformanceProfile = null, DivisionReference Division = null, GranularityEnum? Granularity = null, WorkdayPeriod ComparativePeriod = null, WorkdayPeriod PrimaryPeriod = null, UserReference User = null, List<InsightsDetailsMetricItem> MetricData = null, InsightsDetailsOverallItem OverallData = null)
    {
        this.PerformanceProfile = PerformanceProfile;
        this.Division = Division;
        this.Granularity = Granularity;
        this.ComparativePeriod = ComparativePeriod;
        this.PrimaryPeriod = PrimaryPeriod;
        this.User = User;
        this.MetricData = MetricData;
        this.OverallData = OverallData;

    }



    /// <summary>
    /// The performance profile
    /// </summary>
    /// <value>The performance profile</value>
    [JsonPropertyName("performanceProfile")]
    public AddressableEntityRef PerformanceProfile { get; set; }



    /// <summary>
    /// The division
    /// </summary>
    /// <value>The division</value>
    [JsonPropertyName("division")]
    public DivisionReference Division { get; set; }





    /// <summary>
    /// The comparative period work day date range
    /// </summary>
    /// <value>The comparative period work day date range</value>
    [JsonPropertyName("comparativePeriod")]
    public WorkdayPeriod ComparativePeriod { get; set; }



    /// <summary>
    /// The primary period work day date range
    /// </summary>
    /// <value>The primary period work day date range</value>
    [JsonPropertyName("primaryPeriod")]
    public WorkdayPeriod PrimaryPeriod { get; set; }



    /// <summary>
    /// The query user
    /// </summary>
    /// <value>The query user</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The list of insights data for each metric of the user
    /// </summary>
    /// <value>The list of insights data for each metric of the user</value>
    [JsonPropertyName("metricData")]
    public List<InsightsDetailsMetricItem> MetricData { get; set; }



    /// <summary>
    /// Overall insights data of the user
    /// </summary>
    /// <value>Overall insights data of the user</value>
    [JsonPropertyName("overallData")]
    public InsightsDetailsOverallItem OverallData { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InsightsDetails {\n");

        sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
        sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  MetricData: ").Append(MetricData).Append("\n");
        sb.Append("  OverallData: ").Append(OverallData).Append("\n");
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
        return Equals(obj as InsightsDetails);
    }

    /// <summary>
    /// Returns true if InsightsDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of InsightsDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InsightsDetails other)
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
                MetricData == other.MetricData ||
                MetricData != null &&
                MetricData.SequenceEqual(other.MetricData)
            ) &&
            (
                OverallData == other.OverallData ||
                OverallData != null &&
                OverallData.Equals(other.OverallData)
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

            if (MetricData != null)
            {
                hash = hash * 59 + MetricData.GetHashCode();
            }

            if (OverallData != null)
            {
                hash = hash * 59 + OverallData.GetHashCode();
            }

            return hash;
        }
    }
}
