using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PerformanceProfile
/// </summary>
[DataContract]
public partial class PerformanceProfile : IEquatable<PerformanceProfile>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PerformanceProfile" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PerformanceProfile() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PerformanceProfile" /> class.
    /// </summary>
    /// <param name="Name">A name for this performance profile (required).</param>
    /// <param name="Description">A description about this performance profile (required).</param>
    /// <param name="MetricOrders">Order of the associated metrics. The list should contain valid ids for metrics (required).</param>
    /// <param name="ReportingIntervals">The reporting interval periods for this performance profile.</param>
    /// <param name="MaxLeaderboardRankSize">The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries.</param>
    public PerformanceProfile(string Name = null, string Description = null, List<string> MetricOrders = null, List<ReportingInterval> ReportingIntervals = null, int? MaxLeaderboardRankSize = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.MetricOrders = MetricOrders;
        this.ReportingIntervals = ReportingIntervals;
        this.MaxLeaderboardRankSize = MaxLeaderboardRankSize;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// A name for this performance profile
    /// </summary>
    /// <value>A name for this performance profile</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The division for this performance profile associate to
    /// </summary>
    /// <value>The division for this performance profile associate to</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public Division Division { get; private set; }



    /// <summary>
    /// A description about this performance profile
    /// </summary>
    /// <value>A description about this performance profile</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Order of the associated metrics. The list should contain valid ids for metrics
    /// </summary>
    /// <value>Order of the associated metrics. The list should contain valid ids for metrics</value>
    [DataMember(Name = "metricOrders", EmitDefaultValue = false)]
    public List<string> MetricOrders { get; set; }



    /// <summary>
    /// Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation date for this performance profile. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The reporting interval periods for this performance profile
    /// </summary>
    /// <value>The reporting interval periods for this performance profile</value>
    [DataMember(Name = "reportingIntervals", EmitDefaultValue = false)]
    public List<ReportingInterval> ReportingIntervals { get; set; }



    /// <summary>
    /// The flag for active profiles
    /// </summary>
    /// <value>The flag for active profiles</value>
    [DataMember(Name = "active", EmitDefaultValue = false)]
    public bool? Active { get; private set; }



    /// <summary>
    /// The number of members in this performance profile
    /// </summary>
    /// <value>The number of members in this performance profile</value>
    [DataMember(Name = "memberCount", EmitDefaultValue = false)]
    public int? MemberCount { get; private set; }



    /// <summary>
    /// The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries
    /// </summary>
    /// <value>The maximum rank size for the leaderboard. This counts the number of ranks can be retrieved in a leaderboard queries</value>
    [DataMember(Name = "maxLeaderboardRankSize", EmitDefaultValue = false)]
    public int? MaxLeaderboardRankSize { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PerformanceProfile {\n");

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
        return Equals(obj as PerformanceProfile);
    }

    /// <summary>
    /// Returns true if PerformanceProfile instances are equal
    /// </summary>
    /// <param name="other">Instance of PerformanceProfile to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PerformanceProfile other)
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
