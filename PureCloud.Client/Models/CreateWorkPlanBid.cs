using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Create work plan bid model
/// </summary>
[DataContract]
public partial class CreateWorkPlanBid : IEquatable<CreateWorkPlanBid>
{
    /// <summary>
    /// The type of agent ranking selected for this bid
    /// </summary>
    /// <value>The type of agent ranking selected for this bid</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Ranking tiebreaker to be used
    /// </summary>
    /// <value>Ranking tiebreaker to be used</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// The type of agent ranking selected for this bid
    /// </summary>
    /// <value>The type of agent ranking selected for this bid</value>
    [DataMember(Name = "agentRankingType", EmitDefaultValue = false)]
    public AgentRankingTypeEnum? AgentRankingType { get; set; }
    /// <summary>
    /// Ranking tiebreaker to be used
    /// </summary>
    /// <value>Ranking tiebreaker to be used</value>
    [DataMember(Name = "rankingTiebreakerType", EmitDefaultValue = false)]
    public RankingTiebreakerTypeEnum? RankingTiebreakerType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateWorkPlanBid" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateWorkPlanBid() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateWorkPlanBid" /> class.
    /// </summary>
    /// <param name="Name">The name of the work plan bid (required).</param>
    /// <param name="Forecast">The selected forecast in this work plan bid.</param>
    /// <param name="BidWindowStartDate">The bid start date where agents start participate in work plan bidding in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="BidWindowEndDate">The bid end date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="EffectiveDate">The date when agents will be assigned to the new work plan in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="AgentRankingType">The type of agent ranking selected for this bid (required).</param>
    /// <param name="RankingTiebreakerType">Ranking tiebreaker to be used (required).</param>
    /// <param name="WorkPlanFieldsVisibleToAgents">The work plan fields visible to agents whenever work plan preferences are made (required).</param>
    public CreateWorkPlanBid(string Name = null, BuShortTermForecastWeekReference Forecast = null, string BidWindowStartDate = null, string BidWindowEndDate = null, string EffectiveDate = null, AgentRankingTypeEnum? AgentRankingType = null, RankingTiebreakerTypeEnum? RankingTiebreakerType = null, List<WorkPlanFieldsVisibleToAgentsEnum> WorkPlanFieldsVisibleToAgents = null)
    {
        this.Name = Name;
        this.Forecast = Forecast;
        this.BidWindowStartDate = BidWindowStartDate;
        this.BidWindowEndDate = BidWindowEndDate;
        this.EffectiveDate = EffectiveDate;
        this.AgentRankingType = AgentRankingType;
        this.RankingTiebreakerType = RankingTiebreakerType;
        this.WorkPlanFieldsVisibleToAgents = WorkPlanFieldsVisibleToAgents;

    }



    /// <summary>
    /// The name of the work plan bid
    /// </summary>
    /// <value>The name of the work plan bid</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The selected forecast in this work plan bid
    /// </summary>
    /// <value>The selected forecast in this work plan bid</value>
    [DataMember(Name = "forecast", EmitDefaultValue = false)]
    public BuShortTermForecastWeekReference Forecast { get; set; }



    /// <summary>
    /// The bid start date where agents start participate in work plan bidding in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The bid start date where agents start participate in work plan bidding in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "bidWindowStartDate", EmitDefaultValue = false)]
    public string BidWindowStartDate { get; set; }



    /// <summary>
    /// The bid end date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The bid end date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "bidWindowEndDate", EmitDefaultValue = false)]
    public string BidWindowEndDate { get; set; }



    /// <summary>
    /// The date when agents will be assigned to the new work plan in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date when agents will be assigned to the new work plan in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "effectiveDate", EmitDefaultValue = false)]
    public string EffectiveDate { get; set; }







    /// <summary>
    /// The work plan fields visible to agents whenever work plan preferences are made
    /// </summary>
    /// <value>The work plan fields visible to agents whenever work plan preferences are made</value>
    [DataMember(Name = "workPlanFieldsVisibleToAgents", EmitDefaultValue = false)]
    public List<WorkPlanFieldsVisibleToAgentsEnum> WorkPlanFieldsVisibleToAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateWorkPlanBid {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Forecast: ").Append(Forecast).Append("\n");
        sb.Append("  BidWindowStartDate: ").Append(BidWindowStartDate).Append("\n");
        sb.Append("  BidWindowEndDate: ").Append(BidWindowEndDate).Append("\n");
        sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
        sb.Append("  AgentRankingType: ").Append(AgentRankingType).Append("\n");
        sb.Append("  RankingTiebreakerType: ").Append(RankingTiebreakerType).Append("\n");
        sb.Append("  WorkPlanFieldsVisibleToAgents: ").Append(WorkPlanFieldsVisibleToAgents).Append("\n");
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
        return Equals(obj as CreateWorkPlanBid);
    }

    /// <summary>
    /// Returns true if CreateWorkPlanBid instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateWorkPlanBid to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateWorkPlanBid other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                WorkPlanFieldsVisibleToAgents == other.WorkPlanFieldsVisibleToAgents ||
                WorkPlanFieldsVisibleToAgents != null &&
                WorkPlanFieldsVisibleToAgents.SequenceEqual(other.WorkPlanFieldsVisibleToAgents)
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

            if (AgentRankingType != null)
            {
                hash = hash * 59 + AgentRankingType.GetHashCode();
            }

            if (RankingTiebreakerType != null)
            {
                hash = hash * 59 + RankingTiebreakerType.GetHashCode();
            }

            if (WorkPlanFieldsVisibleToAgents != null)
            {
                hash = hash * 59 + WorkPlanFieldsVisibleToAgents.GetHashCode();
            }

            return hash;
        }
    }
}
