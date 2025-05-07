using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Work plan bid reference
/// </summary>

public partial class AgentWorkPlanBid : IEquatable<AgentWorkPlanBid>
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
    /// Initializes a new instance of the <see cref="AgentWorkPlanBid" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentWorkPlanBid() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanBid" /> class.
    /// </summary>
    /// <param name="Id">The ID of the work plan bid (required).</param>
    /// <param name="Name">Name.</param>
    /// <param name="BidWindowStartDate">The date when agents can start participating in work plan bidding. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="BidWindowEndDate">The inclusive end date of a bid window. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="EffectiveDate">The date when agents will be assigned to the new work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="Status">The state of the bid (required).</param>
    /// <param name="WorkPlanFieldsVisibleToAgents">The work plan fields visible to agents whenever work plan preferences are made (required).</param>
    public AgentWorkPlanBid(string Id = null, string Name = null, string BidWindowStartDate = null, string BidWindowEndDate = null, string EffectiveDate = null, StatusEnum? Status = null, List<WorkPlanFieldsVisibleToAgentsEnum> WorkPlanFieldsVisibleToAgents = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.BidWindowStartDate = BidWindowStartDate;
        this.BidWindowEndDate = BidWindowEndDate;
        this.EffectiveDate = EffectiveDate;
        this.Status = Status;
        this.WorkPlanFieldsVisibleToAgents = WorkPlanFieldsVisibleToAgents;

    }



    /// <summary>
    /// The ID of the work plan bid
    /// </summary>
    /// <value>The ID of the work plan bid</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The date when agents can start participating in work plan bidding. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date when agents can start participating in work plan bidding. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("bidWindowStartDate")]
    public string BidWindowStartDate { get; set; }



    /// <summary>
    /// The inclusive end date of a bid window. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The inclusive end date of a bid window. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("bidWindowEndDate")]
    public string BidWindowEndDate { get; set; }



    /// <summary>
    /// The date when agents will be assigned to the new work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The date when agents will be assigned to the new work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("effectiveDate")]
    public string EffectiveDate { get; set; }





    /// <summary>
    /// The work plan fields visible to agents whenever work plan preferences are made
    /// </summary>
    /// <value>The work plan fields visible to agents whenever work plan preferences are made</value>
    [JsonPropertyName("workPlanFieldsVisibleToAgents")]
    public List<WorkPlanFieldsVisibleToAgentsEnum> WorkPlanFieldsVisibleToAgents { get; set; }



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
        sb.Append("class AgentWorkPlanBid {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  BidWindowStartDate: ").Append(BidWindowStartDate).Append("\n");
        sb.Append("  BidWindowEndDate: ").Append(BidWindowEndDate).Append("\n");
        sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  WorkPlanFieldsVisibleToAgents: ").Append(WorkPlanFieldsVisibleToAgents).Append("\n");
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
        return Equals(obj as AgentWorkPlanBid);
    }

    /// <summary>
    /// Returns true if AgentWorkPlanBid instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentWorkPlanBid to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentWorkPlanBid other)
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
                WorkPlanFieldsVisibleToAgents == other.WorkPlanFieldsVisibleToAgents ||
                WorkPlanFieldsVisibleToAgents != null &&
                WorkPlanFieldsVisibleToAgents.SequenceEqual(other.WorkPlanFieldsVisibleToAgents)
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

            if (WorkPlanFieldsVisibleToAgents != null)
            {
                hash = hash * 59 + WorkPlanFieldsVisibleToAgents.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
