using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentWorkPlanBiddingPreferenceResponse
/// </summary>

public partial class AgentWorkPlanBiddingPreferenceResponse : IEquatable<AgentWorkPlanBiddingPreferenceResponse>
{
    /// <summary>
    /// The reason why the assigned work plan has been overridden. This must be null without an override work plan
    /// </summary>
    /// <value>The reason why the assigned work plan has been overridden. This must be null without an override work plan</value>
    
    public enum OverrideReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unabletobid for "UnableToBid"
        /// </summary>
        [EnumMember(Value = "UnableToBid")]
        Unabletobid,

        /// <summary>
        /// Enum Changeofcircumstance for "ChangeOfCircumstance"
        /// </summary>
        [EnumMember(Value = "ChangeOfCircumstance")]
        Changeofcircumstance,

        /// <summary>
        /// Enum Newhire for "NewHire"
        /// </summary>
        [EnumMember(Value = "NewHire")]
        Newhire,

        /// <summary>
        /// Enum Employeemove for "EmployeeMove"
        /// </summary>
        [EnumMember(Value = "EmployeeMove")]
        Employeemove
    }
    /// <summary>
    /// The reason why the assigned work plan has been overridden. This must be null without an override work plan
    /// </summary>
    /// <value>The reason why the assigned work plan has been overridden. This must be null without an override work plan</value>
    [JsonPropertyName("overrideReason")]
    public OverrideReasonEnum? OverrideReason { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanBiddingPreferenceResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentWorkPlanBiddingPreferenceResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentWorkPlanBiddingPreferenceResponse" /> class.
    /// </summary>
    /// <param name="Submitted">Whether the preference is submitted (required).</param>
    /// <param name="AssignedWorkPlan">The work plan assigned to the agent by the bid process.</param>
    /// <param name="OverriddenWorkPlan">The work plan that overrides the assigned work plan for the agent.</param>
    /// <param name="OverrideReason">The reason why the assigned work plan has been overridden. This must be null without an override work plan.</param>
    /// <param name="AgentWorkPlanBidPreferences">The list of work plan bidding preferences (required).</param>
    public AgentWorkPlanBiddingPreferenceResponse(bool? Submitted = null, WorkPlanReference AssignedWorkPlan = null, WorkPlanReference OverriddenWorkPlan = null, OverrideReasonEnum? OverrideReason = null, List<AgentWorkPlanBiddingPreference> AgentWorkPlanBidPreferences = null)
    {
        this.Submitted = Submitted;
        this.AssignedWorkPlan = AssignedWorkPlan;
        this.OverriddenWorkPlan = OverriddenWorkPlan;
        this.OverrideReason = OverrideReason;
        this.AgentWorkPlanBidPreferences = AgentWorkPlanBidPreferences;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Whether the preference is submitted
    /// </summary>
    /// <value>Whether the preference is submitted</value>
    [JsonPropertyName("submitted")]
    public bool? Submitted { get; set; }



    /// <summary>
    /// The work plan assigned to the agent by the bid process
    /// </summary>
    /// <value>The work plan assigned to the agent by the bid process</value>
    [JsonPropertyName("assignedWorkPlan")]
    public WorkPlanReference AssignedWorkPlan { get; set; }



    /// <summary>
    /// The work plan that overrides the assigned work plan for the agent
    /// </summary>
    /// <value>The work plan that overrides the assigned work plan for the agent</value>
    [JsonPropertyName("overriddenWorkPlan")]
    public WorkPlanReference OverriddenWorkPlan { get; set; }





    /// <summary>
    /// The list of work plan bidding preferences
    /// </summary>
    /// <value>The list of work plan bidding preferences</value>
    [JsonPropertyName("agentWorkPlanBidPreferences")]
    public List<AgentWorkPlanBiddingPreference> AgentWorkPlanBidPreferences { get; set; }



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
        sb.Append("class AgentWorkPlanBiddingPreferenceResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Submitted: ").Append(Submitted).Append("\n");
        sb.Append("  AssignedWorkPlan: ").Append(AssignedWorkPlan).Append("\n");
        sb.Append("  OverriddenWorkPlan: ").Append(OverriddenWorkPlan).Append("\n");
        sb.Append("  OverrideReason: ").Append(OverrideReason).Append("\n");
        sb.Append("  AgentWorkPlanBidPreferences: ").Append(AgentWorkPlanBidPreferences).Append("\n");
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
        return Equals(obj as AgentWorkPlanBiddingPreferenceResponse);
    }

    /// <summary>
    /// Returns true if AgentWorkPlanBiddingPreferenceResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentWorkPlanBiddingPreferenceResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentWorkPlanBiddingPreferenceResponse other)
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
                Submitted == other.Submitted ||
                Submitted != null &&
                Submitted.Equals(other.Submitted)
            ) &&
            (
                AssignedWorkPlan == other.AssignedWorkPlan ||
                AssignedWorkPlan != null &&
                AssignedWorkPlan.Equals(other.AssignedWorkPlan)
            ) &&
            (
                OverriddenWorkPlan == other.OverriddenWorkPlan ||
                OverriddenWorkPlan != null &&
                OverriddenWorkPlan.Equals(other.OverriddenWorkPlan)
            ) &&
            (
                OverrideReason == other.OverrideReason ||
                OverrideReason != null &&
                OverrideReason.Equals(other.OverrideReason)
            ) &&
            (
                AgentWorkPlanBidPreferences == other.AgentWorkPlanBidPreferences ||
                AgentWorkPlanBidPreferences != null &&
                AgentWorkPlanBidPreferences.SequenceEqual(other.AgentWorkPlanBidPreferences)
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

            if (Submitted != null)
            {
                hash = hash * 59 + Submitted.GetHashCode();
            }

            if (AssignedWorkPlan != null)
            {
                hash = hash * 59 + AssignedWorkPlan.GetHashCode();
            }

            if (OverriddenWorkPlan != null)
            {
                hash = hash * 59 + OverriddenWorkPlan.GetHashCode();
            }

            if (OverrideReason != null)
            {
                hash = hash * 59 + OverrideReason.GetHashCode();
            }

            if (AgentWorkPlanBidPreferences != null)
            {
                hash = hash * 59 + AgentWorkPlanBidPreferences.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
