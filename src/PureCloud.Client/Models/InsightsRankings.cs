using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InsightsRankings
/// </summary>

public partial class InsightsRankings : IEquatable<InsightsRankings>
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
    /// Initializes a new instance of the <see cref="InsightsRankings" /> class.
    /// </summary>
    /// <param name="PerformanceProfile">The performance profile.</param>
    /// <param name="Division">The division.</param>
    /// <param name="Granularity">Granularity.</param>
    /// <param name="ComparativePeriod">The comparative period work day date range.</param>
    /// <param name="PrimaryPeriod">The primary period work day date range.</param>
    /// <param name="Leaders">The leaders users.</param>
    /// <param name="Trailers">The trailing users.</param>
    public InsightsRankings(AddressableEntityRef PerformanceProfile = null, DivisionReference Division = null, GranularityEnum? Granularity = null, WorkdayPeriod ComparativePeriod = null, WorkdayPeriod PrimaryPeriod = null, List<InsightsSummaryUserItem> Leaders = null, List<InsightsSummaryUserItem> Trailers = null)
    {
        this.PerformanceProfile = PerformanceProfile;
        this.Division = Division;
        this.Granularity = Granularity;
        this.ComparativePeriod = ComparativePeriod;
        this.PrimaryPeriod = PrimaryPeriod;
        this.Leaders = Leaders;
        this.Trailers = Trailers;

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
    /// The leaders users
    /// </summary>
    /// <value>The leaders users</value>
    [JsonPropertyName("leaders")]
    public List<InsightsSummaryUserItem> Leaders { get; set; }



    /// <summary>
    /// The trailing users
    /// </summary>
    /// <value>The trailing users</value>
    [JsonPropertyName("trailers")]
    public List<InsightsSummaryUserItem> Trailers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InsightsRankings {\n");

        sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
        sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
        sb.Append("  Leaders: ").Append(Leaders).Append("\n");
        sb.Append("  Trailers: ").Append(Trailers).Append("\n");
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
        return Equals(obj as InsightsRankings);
    }

    /// <summary>
    /// Returns true if InsightsRankings instances are equal
    /// </summary>
    /// <param name="other">Instance of InsightsRankings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InsightsRankings other)
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
                Leaders == other.Leaders ||
                Leaders != null &&
                Leaders.SequenceEqual(other.Leaders)
            ) &&
            (
                Trailers == other.Trailers ||
                Trailers != null &&
                Trailers.SequenceEqual(other.Trailers)
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

            if (Leaders != null)
            {
                hash = hash * 59 + Leaders.GetHashCode();
            }

            if (Trailers != null)
            {
                hash = hash * 59 + Trailers.GetHashCode();
            }

            return hash;
        }
    }
}
