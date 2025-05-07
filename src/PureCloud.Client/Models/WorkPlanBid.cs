using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Work plan bid response
/// </summary>

public partial class WorkPlanBid : IEquatable<WorkPlanBid>
{
    /// <summary>
    /// The state of the bid
    /// </summary>
    /// <value>The state of the bid</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Draft for "Draft"
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft,

        /// <summary>
        /// Enum Locked for "Locked"
        /// </summary>
        [EnumMember(Value = "Locked")]
        Locked,

        /// <summary>
        /// Enum Optimized for "Optimized"
        /// </summary>
        [EnumMember(Value = "Optimized")]
        Optimized,

        /// <summary>
        /// Enum Scheduled for "Scheduled"
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Closed for "Closed"
        /// </summary>
        [EnumMember(Value = "Closed")]
        Closed,

        /// <summary>
        /// Enum Processed for "Processed"
        /// </summary>
        [EnumMember(Value = "Processed")]
        Processed,

        /// <summary>
        /// Enum Published for "Published"
        /// </summary>
        [EnumMember(Value = "Published")]
        Published
    }
    /// <summary>
    /// The type of agent ranking selected for this bid
    /// </summary>
    /// <value>The type of agent ranking selected for this bid</value>
    
    public enum AgentRankingTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Hiredate for "HireDate"
        /// </summary>
        [EnumMember(Value = "HireDate")]
        Hiredate,

        /// <summary>
        /// Enum Performance for "Performance"
        /// </summary>
        [EnumMember(Value = "Performance")]
        Performance
    }
    /// <summary>
    /// Ranking tiebreaker
    /// </summary>
    /// <value>Ranking tiebreaker</value>
    
    public enum RankingTiebreakerTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Hiredate for "HireDate"
        /// </summary>
        [EnumMember(Value = "HireDate")]
        Hiredate,

        /// <summary>
        /// Enum Performance for "Performance"
        /// </summary>
        [EnumMember(Value = "Performance")]
        Performance,

        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom,

        /// <summary>
        /// Enum Randomlyassign for "RandomlyAssign"
        /// </summary>
        [EnumMember(Value = "RandomlyAssign")]
        Randomlyassign
    }
    /// <summary>
    /// Gets or Sets WorkPlanFieldsVisibleToAgents
    /// </summary>
    
    public enum WorkPlanFieldsVisibleToAgentsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Name for "Name"
        /// </summary>
        [EnumMember(Value = "Name")]
        Name,

        /// <summary>
        /// Enum Paidhours for "PaidHours"
        /// </summary>
        [EnumMember(Value = "PaidHours")]
        Paidhours
    }
    /// <summary>
    /// The state of the bid
    /// </summary>
    /// <value>The state of the bid</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The type of agent ranking selected for this bid
    /// </summary>
    /// <value>The type of agent ranking selected for this bid</value>
    [JsonPropertyName("agentRankingType")]
    public AgentRankingTypeEnum? AgentRankingType { get; set; }
    /// <summary>
    /// Ranking tiebreaker
    /// </summary>
    /// <value>Ranking tiebreaker</value>
    [JsonPropertyName("rankingTiebreakerType")]
    public RankingTiebreakerTypeEnum? RankingTiebreakerType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanBid" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkPlanBid() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanBid" /> class.
    /// </summary>
    /// <param name="Id">The ID of the work plan bid (required).</param>
    /// <param name="Name">The name of the work plan bid (required).</param>
    /// <param name="Forecast">The selected forecast in this work plan bid.</param>
    /// <param name="BidWindowStartDate">The bid start date where agents start participate in work plan bidding. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="BidWindowEndDate">The bid end date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="EffectiveDate">The date when agents will be assigned to the new work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="Status">The state of the bid (required).</param>
    /// <param name="AgentRankingType">The type of agent ranking selected for this bid (required).</param>
    /// <param name="RankingTiebreakerType">Ranking tiebreaker (required).</param>
    /// <param name="PublishedDate">The date the work plan bid published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="WorkPlanFieldsVisibleToAgents">The work plan fields visible to agents whenever work plan preferences are made (required).</param>
    /// <param name="Metadata">The meta data of this bid.</param>
    public WorkPlanBid(string Id = null, string Name = null, BuShortTermForecastWeekReference Forecast = null, string BidWindowStartDate = null, string BidWindowEndDate = null, string EffectiveDate = null, StatusEnum? Status = null, AgentRankingTypeEnum? AgentRankingType = null, RankingTiebreakerTypeEnum? RankingTiebreakerType = null, DateTime? PublishedDate = null, List<WorkPlanFieldsVisibleToAgentsEnum> WorkPlanFieldsVisibleToAgents = null, WorkPlanBidMetadata Metadata = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Forecast = Forecast;
        this.BidWindowStartDate = BidWindowStartDate;
        this.BidWindowEndDate = BidWindowEndDate;
        this.EffectiveDate = EffectiveDate;
        this.Status = Status;
        this.AgentRankingType = AgentRankingType;
        this.RankingTiebreakerType = RankingTiebreakerType;
        this.PublishedDate = PublishedDate;
        this.WorkPlanFieldsVisibleToAgents = WorkPlanFieldsVisibleToAgents;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The ID of the work plan bid
    /// </summary>
    /// <value>The ID of the work plan bid</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the work plan bid
    /// </summary>
    /// <value>The name of the work plan bid</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The selected forecast in this work plan bid
    /// </summary>
    /// <value>The selected forecast in this work plan bid</value>
    [JsonPropertyName("forecast")]
    public BuShortTermForecastWeekReference Forecast { get; set; }



    /// <summary>
    /// The bid start date where agents start participate in work plan bidding. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The bid start date where agents start participate in work plan bidding. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("bidWindowStartDate")]
    public string BidWindowStartDate { get; set; }



    /// <summary>
    /// The bid end date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The bid end date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("bidWindowEndDate")]
    public string BidWindowEndDate { get; set; }



    /// <summary>
    /// The date when agents will be assigned to the new work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date when agents will be assigned to the new work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("effectiveDate")]
    public string EffectiveDate { get; set; }









    /// <summary>
    /// The date the work plan bid published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the work plan bid published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("publishedDate")]
    public DateTime? PublishedDate { get; set; }



    /// <summary>
    /// The work plan fields visible to agents whenever work plan preferences are made
    /// </summary>
    /// <value>The work plan fields visible to agents whenever work plan preferences are made</value>
    [JsonPropertyName("workPlanFieldsVisibleToAgents")]
    public List<WorkPlanFieldsVisibleToAgentsEnum> WorkPlanFieldsVisibleToAgents { get; set; }



    /// <summary>
    /// The meta data of this bid
    /// </summary>
    /// <value>The meta data of this bid</value>
    [JsonPropertyName("metadata")]
    public WorkPlanBidMetadata Metadata { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanBid {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Forecast: ").Append(Forecast).Append("\n");
        sb.Append("  BidWindowStartDate: ").Append(BidWindowStartDate).Append("\n");
        sb.Append("  BidWindowEndDate: ").Append(BidWindowEndDate).Append("\n");
        sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  AgentRankingType: ").Append(AgentRankingType).Append("\n");
        sb.Append("  RankingTiebreakerType: ").Append(RankingTiebreakerType).Append("\n");
        sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
        sb.Append("  WorkPlanFieldsVisibleToAgents: ").Append(WorkPlanFieldsVisibleToAgents).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as WorkPlanBid);
    }

    /// <summary>
    /// Returns true if WorkPlanBid instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanBid to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanBid other)
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
                Forecast == other.Forecast ||
                Forecast != null &&
                Forecast.Equals(other.Forecast)
            ) &&
            (
                BidWindowStartDate == other.BidWindowStartDate ||
                BidWindowStartDate != null &&
                BidWindowStartDate.Equals(other.BidWindowStartDate)
            ) &&
            (
                BidWindowEndDate == other.BidWindowEndDate ||
                BidWindowEndDate != null &&
                BidWindowEndDate.Equals(other.BidWindowEndDate)
            ) &&
            (
                EffectiveDate == other.EffectiveDate ||
                EffectiveDate != null &&
                EffectiveDate.Equals(other.EffectiveDate)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                AgentRankingType == other.AgentRankingType ||
                AgentRankingType != null &&
                AgentRankingType.Equals(other.AgentRankingType)
            ) &&
            (
                RankingTiebreakerType == other.RankingTiebreakerType ||
                RankingTiebreakerType != null &&
                RankingTiebreakerType.Equals(other.RankingTiebreakerType)
            ) &&
            (
                PublishedDate == other.PublishedDate ||
                PublishedDate != null &&
                PublishedDate.Equals(other.PublishedDate)
            ) &&
            (
                WorkPlanFieldsVisibleToAgents == other.WorkPlanFieldsVisibleToAgents ||
                WorkPlanFieldsVisibleToAgents != null &&
                WorkPlanFieldsVisibleToAgents.SequenceEqual(other.WorkPlanFieldsVisibleToAgents)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (Forecast != null)
            {
                hash = hash * 59 + Forecast.GetHashCode();
            }

            if (BidWindowStartDate != null)
            {
                hash = hash * 59 + BidWindowStartDate.GetHashCode();
            }

            if (BidWindowEndDate != null)
            {
                hash = hash * 59 + BidWindowEndDate.GetHashCode();
            }

            if (EffectiveDate != null)
            {
                hash = hash * 59 + EffectiveDate.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (AgentRankingType != null)
            {
                hash = hash * 59 + AgentRankingType.GetHashCode();
            }

            if (RankingTiebreakerType != null)
            {
                hash = hash * 59 + RankingTiebreakerType.GetHashCode();
            }

            if (PublishedDate != null)
            {
                hash = hash * 59 + PublishedDate.GetHashCode();
            }

            if (WorkPlanFieldsVisibleToAgents != null)
            {
                hash = hash * 59 + WorkPlanFieldsVisibleToAgents.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
