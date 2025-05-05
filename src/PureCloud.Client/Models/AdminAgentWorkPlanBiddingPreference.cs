using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdminAgentWorkPlanBiddingPreference
/// </summary>

public partial class AdminAgentWorkPlanBiddingPreference : IEquatable<AdminAgentWorkPlanBiddingPreference>
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
    /// Initializes a new instance of the <see cref="AdminAgentWorkPlanBiddingPreference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AdminAgentWorkPlanBiddingPreference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AdminAgentWorkPlanBiddingPreference" /> class.
    /// </summary>
    /// <param name="Agent">The agent to whom this work plan bidding preference applies (required).</param>
    /// <param name="Submitted">Whether the preference is submitted (required).</param>
    /// <param name="AssignedWorkPlan">The work plan assigned to the agent by the bid process.</param>
    /// <param name="OverriddenWorkPlan">The work plan that overrides the assigned work plan for the agent.</param>
    /// <param name="OverrideReason">The reason why the assigned work plan has been overridden. This must be null without an override work plan.</param>
    /// <param name="Priorities">The agent priorities for the list of work plans. The index of the priorities should match with the list of work plans that belong to bid group. It contains null if priority is not set for the work plan.</param>
    public AdminAgentWorkPlanBiddingPreference(UserReference Agent = null, bool? Submitted = null, WorkPlanReference AssignedWorkPlan = null, WorkPlanReference OverriddenWorkPlan = null, OverrideReasonEnum? OverrideReason = null, List<int?> Priorities = null)
    {
        this.Agent = Agent;
        this.Submitted = Submitted;
        this.AssignedWorkPlan = AssignedWorkPlan;
        this.OverriddenWorkPlan = OverriddenWorkPlan;
        this.OverrideReason = OverrideReason;
        this.Priorities = Priorities;

    }



    /// <summary>
    /// The agent to whom this work plan bidding preference applies
    /// </summary>
    /// <value>The agent to whom this work plan bidding preference applies</value>
    [JsonPropertyName("agent")]
    public UserReference Agent { get; set; }



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
    /// The agent priorities for the list of work plans. The index of the priorities should match with the list of work plans that belong to bid group. It contains null if priority is not set for the work plan
    /// </summary>
    /// <value>The agent priorities for the list of work plans. The index of the priorities should match with the list of work plans that belong to bid group. It contains null if priority is not set for the work plan</value>
    [JsonPropertyName("priorities")]
    public List<int?> Priorities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdminAgentWorkPlanBiddingPreference {\n");

        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  Submitted: ").Append(Submitted).Append("\n");
        sb.Append("  AssignedWorkPlan: ").Append(AssignedWorkPlan).Append("\n");
        sb.Append("  OverriddenWorkPlan: ").Append(OverriddenWorkPlan).Append("\n");
        sb.Append("  OverrideReason: ").Append(OverrideReason).Append("\n");
        sb.Append("  Priorities: ").Append(Priorities).Append("\n");
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
        return Equals(obj as AdminAgentWorkPlanBiddingPreference);
    }

    /// <summary>
    /// Returns true if AdminAgentWorkPlanBiddingPreference instances are equal
    /// </summary>
    /// <param name="other">Instance of AdminAgentWorkPlanBiddingPreference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdminAgentWorkPlanBiddingPreference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
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
                Priorities == other.Priorities ||
                Priorities != null &&
                Priorities.SequenceEqual(other.Priorities)
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
            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
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

            if (Priorities != null)
            {
                hash = hash * 59 + Priorities.GetHashCode();
            }

            return hash;
        }
    }
}
