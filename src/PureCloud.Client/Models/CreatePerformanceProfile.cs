using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreatePerformanceProfile
/// </summary>

public partial class CreatePerformanceProfile : IEquatable<CreatePerformanceProfile>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreatePerformanceProfile" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreatePerformanceProfile() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreatePerformanceProfile" /> class.
    /// </summary>
    /// <param name="Name">A name for this performance profile (required).</param>
    /// <param name="Division">The associated division for this Performance Profile (required).</param>
    /// <param name="Description">A description about this performance profile (required).</param>
    /// <param name="ReportingIntervals">The reporting interval periods for this performance profile (required).</param>
    /// <param name="Active">The flag for active profiles (required).</param>
    /// <param name="MaxLeaderboardRankSize">The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries (required).</param>
    public CreatePerformanceProfile(string Name = null, WritableDivision Division = null, string Description = null, List<ReportingInterval> ReportingIntervals = null, bool? Active = null, int? MaxLeaderboardRankSize = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.ReportingIntervals = ReportingIntervals;
        this.Active = Active;
        this.MaxLeaderboardRankSize = MaxLeaderboardRankSize;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// A name for this performance profile
    /// </summary>
    /// <value>A name for this performance profile</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The associated division for this Performance Profile
    /// </summary>
    /// <value>The associated division for this Performance Profile</value>
    [JsonPropertyName("division")]
    public WritableDivision Division { get; set; }



    /// <summary>
    /// A description about this performance profile
    /// </summary>
    /// <value>A description about this performance profile</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Order of the associated metrics. The list should contain valid ids for metrics
    /// </summary>
    /// <value>Order of the associated metrics. The list should contain valid ids for metrics</value>
    [JsonPropertyName("metricOrders")]
    public List<string> MetricOrders { get; private set; }



    /// <summary>
    /// Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The reporting interval periods for this performance profile
    /// </summary>
    /// <value>The reporting interval periods for this performance profile</value>
    [JsonPropertyName("reportingIntervals")]
    public List<ReportingInterval> ReportingIntervals { get; set; }



    /// <summary>
    /// The flag for active profiles
    /// </summary>
    /// <value>The flag for active profiles</value>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }



    /// <summary>
    /// The number of members in this performance profile
    /// </summary>
    /// <value>The number of members in this performance profile</value>
    [JsonPropertyName("memberCount")]
    public int? MemberCount { get; private set; }



    /// <summary>
    /// The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries
    /// </summary>
    /// <value>The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries</value>
    [JsonPropertyName("maxLeaderboardRankSize")]
    public int? MaxLeaderboardRankSize { get; set; }



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
        sb.Append("class CreatePerformanceProfile {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  MetricOrders: ").Append(MetricOrders).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ReportingIntervals: ").Append(ReportingIntervals).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
        sb.Append("  MaxLeaderboardRankSize: ").Append(MaxLeaderboardRankSize).Append("\n");
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
        return Equals(obj as CreatePerformanceProfile);
    }

    /// <summary>
    /// Returns true if CreatePerformanceProfile instances are equal
    /// </summary>
    /// <param name="other">Instance of CreatePerformanceProfile to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreatePerformanceProfile other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                MetricOrders == other.MetricOrders ||
                MetricOrders != null &&
                MetricOrders.SequenceEqual(other.MetricOrders)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ReportingIntervals == other.ReportingIntervals ||
                ReportingIntervals != null &&
                ReportingIntervals.SequenceEqual(other.ReportingIntervals)
            ) &&
            (
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
            ) &&
            (
                MemberCount == other.MemberCount ||
                MemberCount != null &&
                MemberCount.Equals(other.MemberCount)
            ) &&
            (
                MaxLeaderboardRankSize == other.MaxLeaderboardRankSize ||
                MaxLeaderboardRankSize != null &&
                MaxLeaderboardRankSize.Equals(other.MaxLeaderboardRankSize)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (MetricOrders != null)
            {
                hash = hash * 59 + MetricOrders.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ReportingIntervals != null)
            {
                hash = hash * 59 + ReportingIntervals.GetHashCode();
            }

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (MemberCount != null)
            {
                hash = hash * 59 + MemberCount.GetHashCode();
            }

            if (MaxLeaderboardRankSize != null)
            {
                hash = hash * 59 + MaxLeaderboardRankSize.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
