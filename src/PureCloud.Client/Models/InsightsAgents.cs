using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InsightsAgents
/// </summary>

public partial class InsightsAgents : IEquatable<InsightsAgents>
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
    /// Initializes a new instance of the <see cref="InsightsAgents" /> class.
    /// </summary>
    /// <param name="PerformanceProfile">The performance profile.</param>
    /// <param name="Division">The division.</param>
    /// <param name="Granularity">Granularity.</param>
    /// <param name="DateStartWorkday">Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="DateEndWorkday">End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="Entities">The list of insights agents.</param>
    public InsightsAgents(AddressableEntityRef PerformanceProfile = null, DivisionReference Division = null, GranularityEnum? Granularity = null, string DateStartWorkday = null, string DateEndWorkday = null, List<InsightsAgentItem> Entities = null)
    {
        this.PerformanceProfile = PerformanceProfile;
        this.Division = Division;
        this.Granularity = Granularity;
        this.DateStartWorkday = DateStartWorkday;
        this.DateEndWorkday = DateEndWorkday;
        this.Entities = Entities;

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
    /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStartWorkday")]
    public string DateStartWorkday { get; set; }



    /// <summary>
    /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEndWorkday")]
    public string DateEndWorkday { get; set; }



    /// <summary>
    /// The list of insights agents
    /// </summary>
    /// <value>The list of insights agents</value>
    [JsonPropertyName("entities")]
    public List<InsightsAgentItem> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InsightsAgents {\n");

        sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
        sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as InsightsAgents);
    }

    /// <summary>
    /// Returns true if InsightsAgents instances are equal
    /// </summary>
    /// <param name="other">Instance of InsightsAgents to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InsightsAgents other)
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
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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

            if (DateStartWorkday != null)
            {
                hash = hash * 59 + DateStartWorkday.GetHashCode();
            }

            if (DateEndWorkday != null)
            {
                hash = hash * 59 + DateEndWorkday.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}
