using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemCreate
/// </summary>

public partial class WorkitemCreate : IEquatable<WorkitemCreate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemCreate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkitemCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemCreate" /> class.
    /// </summary>
    /// <param name="Name">The name of the Workitem. Valid length between 3 and 256 characters. (required).</param>
    /// <param name="Priority">The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000..</param>
    /// <param name="DateDue">The due date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateExpires">The expiry date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DurationSeconds">The estimated duration in seconds to complete the Workitem. Maximum of 365 days..</param>
    /// <param name="Ttl">The epoch timestamp in seconds specifying the time to live for the Workitem. Can not be greater than 365 days from the current time..</param>
    /// <param name="StatusId">The ID of the Status of the Workitem..</param>
    /// <param name="WorkbinId">The ID of Workbin that contains the Workitem..</param>
    /// <param name="AutoStatusTransition">Set it to false to disable auto status transition. By default, it is enabled..</param>
    /// <param name="Description">The description of the Workitem. Maximum length of 512 characters..</param>
    /// <param name="TypeId">The ID of the Worktype of the Workitem. (required).</param>
    /// <param name="CustomFields">Custom fields defined in the schema referenced by the worktype of the workitem..</param>
    /// <param name="QueueId">The ID of the Workitems queue. Must be a valid UUID..</param>
    /// <param name="AssigneeId">The ID of the assignee of the Workitem. Must be a valid UUID..</param>
    /// <param name="LanguageId">The ID of language of the Workitem. Must be a valid UUID..</param>
    /// <param name="ExternalContactId">The ID of the external contact of the Workitem. Must be a valid UUID..</param>
    /// <param name="ExternalTag">The external tag of the Workitem..</param>
    /// <param name="SkillIds">The skill IDs of the Workitem. Must be valid UUIDs..</param>
    /// <param name="ScriptId">The ID of the Workitems script. Must be a valid UUID..</param>
    /// <param name="WrapupCode">The ID of the wrapup. Must be a valid UUID..</param>
    /// <param name="UtilizationLabelId">The ID of utilization label of the Workitem. Must be a valid UUID..</param>
    /// <param name="ScoredAgents">A list of scored agents for the Workitem. A workitem can have a maximum of 20 scored agents..</param>
    /// <param name="PreferredAgentIds">The preferred agent IDs of the Workitem. Must be valid UUIDs..</param>
    public WorkitemCreate(string Name = null, int? Priority = null, DateTime? DateDue = null, DateTime? DateExpires = null, int? DurationSeconds = null, int? Ttl = null, string StatusId = null, string WorkbinId = null, bool? AutoStatusTransition = null, string Description = null, string TypeId = null, Dictionary<string, object> CustomFields = null, string QueueId = null, string AssigneeId = null, string LanguageId = null, string ExternalContactId = null, string ExternalTag = null, List<string> SkillIds = null, string ScriptId = null, string WrapupCode = null, string UtilizationLabelId = null, List<WorkitemScoredAgentRequest> ScoredAgents = null, List<string> PreferredAgentIds = null)
    {
        this.Name = Name;
        this.Priority = Priority;
        this.DateDue = DateDue;
        this.DateExpires = DateExpires;
        this.DurationSeconds = DurationSeconds;
        this.Ttl = Ttl;
        this.StatusId = StatusId;
        this.WorkbinId = WorkbinId;
        this.AutoStatusTransition = AutoStatusTransition;
        this.Description = Description;
        this.TypeId = TypeId;
        this.CustomFields = CustomFields;
        this.QueueId = QueueId;
        this.AssigneeId = AssigneeId;
        this.LanguageId = LanguageId;
        this.ExternalContactId = ExternalContactId;
        this.ExternalTag = ExternalTag;
        this.SkillIds = SkillIds;
        this.ScriptId = ScriptId;
        this.WrapupCode = WrapupCode;
        this.UtilizationLabelId = UtilizationLabelId;
        this.ScoredAgents = ScoredAgents;
        this.PreferredAgentIds = PreferredAgentIds;

    }



    /// <summary>
    /// The name of the Workitem. Valid length between 3 and 256 characters.
    /// </summary>
    /// <value>The name of the Workitem. Valid length between 3 and 256 characters.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.
    /// </summary>
    /// <value>The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.</value>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }



    /// <summary>
    /// The due date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The due date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateDue")]
    public DateTime? DateDue { get; set; }



    /// <summary>
    /// The expiry date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The expiry date of the Workitem. Can not be greater than 365 days from the current time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateExpires")]
    public DateTime? DateExpires { get; set; }



    /// <summary>
    /// The estimated duration in seconds to complete the Workitem. Maximum of 365 days.
    /// </summary>
    /// <value>The estimated duration in seconds to complete the Workitem. Maximum of 365 days.</value>
    [JsonPropertyName("durationSeconds")]
    public int? DurationSeconds { get; set; }



    /// <summary>
    /// The epoch timestamp in seconds specifying the time to live for the Workitem. Can not be greater than 365 days from the current time.
    /// </summary>
    /// <value>The epoch timestamp in seconds specifying the time to live for the Workitem. Can not be greater than 365 days from the current time.</value>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }



    /// <summary>
    /// The ID of the Status of the Workitem.
    /// </summary>
    /// <value>The ID of the Status of the Workitem.</value>
    [JsonPropertyName("statusId")]
    public string StatusId { get; set; }



    /// <summary>
    /// The ID of Workbin that contains the Workitem.
    /// </summary>
    /// <value>The ID of Workbin that contains the Workitem.</value>
    [JsonPropertyName("workbinId")]
    public string WorkbinId { get; set; }



    /// <summary>
    /// Set it to false to disable auto status transition. By default, it is enabled.
    /// </summary>
    /// <value>Set it to false to disable auto status transition. By default, it is enabled.</value>
    [JsonPropertyName("autoStatusTransition")]
    public bool? AutoStatusTransition { get; set; }



    /// <summary>
    /// The description of the Workitem. Maximum length of 512 characters.
    /// </summary>
    /// <value>The description of the Workitem. Maximum length of 512 characters.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The ID of the Worktype of the Workitem.
    /// </summary>
    /// <value>The ID of the Worktype of the Workitem.</value>
    [JsonPropertyName("typeId")]
    public string TypeId { get; set; }



    /// <summary>
    /// Custom fields defined in the schema referenced by the worktype of the workitem.
    /// </summary>
    /// <value>Custom fields defined in the schema referenced by the worktype of the workitem.</value>
    [JsonPropertyName("customFields")]
    public Dictionary<string, object> CustomFields { get; set; }



    /// <summary>
    /// The ID of the Workitems queue. Must be a valid UUID.
    /// </summary>
    /// <value>The ID of the Workitems queue. Must be a valid UUID.</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// The ID of the assignee of the Workitem. Must be a valid UUID.
    /// </summary>
    /// <value>The ID of the assignee of the Workitem. Must be a valid UUID.</value>
    [JsonPropertyName("assigneeId")]
    public string AssigneeId { get; set; }



    /// <summary>
    /// The ID of language of the Workitem. Must be a valid UUID.
    /// </summary>
    /// <value>The ID of language of the Workitem. Must be a valid UUID.</value>
    [JsonPropertyName("languageId")]
    public string LanguageId { get; set; }



    /// <summary>
    /// The ID of the external contact of the Workitem. Must be a valid UUID.
    /// </summary>
    /// <value>The ID of the external contact of the Workitem. Must be a valid UUID.</value>
    [JsonPropertyName("externalContactId")]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// The external tag of the Workitem.
    /// </summary>
    /// <value>The external tag of the Workitem.</value>
    [JsonPropertyName("externalTag")]
    public string ExternalTag { get; set; }



    /// <summary>
    /// The skill IDs of the Workitem. Must be valid UUIDs.
    /// </summary>
    /// <value>The skill IDs of the Workitem. Must be valid UUIDs.</value>
    [JsonPropertyName("skillIds")]
    public List<string> SkillIds { get; set; }



    /// <summary>
    /// The ID of the Workitems script. Must be a valid UUID.
    /// </summary>
    /// <value>The ID of the Workitems script. Must be a valid UUID.</value>
    [JsonPropertyName("scriptId")]
    public string ScriptId { get; set; }



    /// <summary>
    /// The ID of the wrapup. Must be a valid UUID.
    /// </summary>
    /// <value>The ID of the wrapup. Must be a valid UUID.</value>
    [JsonPropertyName("wrapupCode")]
    public string WrapupCode { get; set; }



    /// <summary>
    /// The ID of utilization label of the Workitem. Must be a valid UUID.
    /// </summary>
    /// <value>The ID of utilization label of the Workitem. Must be a valid UUID.</value>
    [JsonPropertyName("utilizationLabelId")]
    public string UtilizationLabelId { get; set; }



    /// <summary>
    /// A list of scored agents for the Workitem. A workitem can have a maximum of 20 scored agents.
    /// </summary>
    /// <value>A list of scored agents for the Workitem. A workitem can have a maximum of 20 scored agents.</value>
    [JsonPropertyName("scoredAgents")]
    public List<WorkitemScoredAgentRequest> ScoredAgents { get; set; }



    /// <summary>
    /// The preferred agent IDs of the Workitem. Must be valid UUIDs.
    /// </summary>
    /// <value>The preferred agent IDs of the Workitem. Must be valid UUIDs.</value>
    [JsonPropertyName("preferredAgentIds")]
    public List<string> PreferredAgentIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemCreate {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  DateDue: ").Append(DateDue).Append("\n");
        sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
        sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
        sb.Append("  Ttl: ").Append(Ttl).Append("\n");
        sb.Append("  StatusId: ").Append(StatusId).Append("\n");
        sb.Append("  WorkbinId: ").Append(WorkbinId).Append("\n");
        sb.Append("  AutoStatusTransition: ").Append(AutoStatusTransition).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  TypeId: ").Append(TypeId).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
        sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
        sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  WrapupCode: ").Append(WrapupCode).Append("\n");
        sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
        sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
        sb.Append("  PreferredAgentIds: ").Append(PreferredAgentIds).Append("\n");
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
        return Equals(obj as WorkitemCreate);
    }

    /// <summary>
    /// Returns true if WorkitemCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemCreate other)
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
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                DateDue == other.DateDue ||
                DateDue != null &&
                DateDue.Equals(other.DateDue)
            ) &&
            (
                DateExpires == other.DateExpires ||
                DateExpires != null &&
                DateExpires.Equals(other.DateExpires)
            ) &&
            (
                DurationSeconds == other.DurationSeconds ||
                DurationSeconds != null &&
                DurationSeconds.Equals(other.DurationSeconds)
            ) &&
            (
                Ttl == other.Ttl ||
                Ttl != null &&
                Ttl.Equals(other.Ttl)
            ) &&
            (
                StatusId == other.StatusId ||
                StatusId != null &&
                StatusId.Equals(other.StatusId)
            ) &&
            (
                WorkbinId == other.WorkbinId ||
                WorkbinId != null &&
                WorkbinId.Equals(other.WorkbinId)
            ) &&
            (
                AutoStatusTransition == other.AutoStatusTransition ||
                AutoStatusTransition != null &&
                AutoStatusTransition.Equals(other.AutoStatusTransition)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                TypeId == other.TypeId ||
                TypeId != null &&
                TypeId.Equals(other.TypeId)
            ) &&
            (
                CustomFields == other.CustomFields ||
                CustomFields != null &&
                CustomFields.SequenceEqual(other.CustomFields)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                AssigneeId == other.AssigneeId ||
                AssigneeId != null &&
                AssigneeId.Equals(other.AssigneeId)
            ) &&
            (
                LanguageId == other.LanguageId ||
                LanguageId != null &&
                LanguageId.Equals(other.LanguageId)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                ExternalTag == other.ExternalTag ||
                ExternalTag != null &&
                ExternalTag.Equals(other.ExternalTag)
            ) &&
            (
                SkillIds == other.SkillIds ||
                SkillIds != null &&
                SkillIds.SequenceEqual(other.SkillIds)
            ) &&
            (
                ScriptId == other.ScriptId ||
                ScriptId != null &&
                ScriptId.Equals(other.ScriptId)
            ) &&
            (
                WrapupCode == other.WrapupCode ||
                WrapupCode != null &&
                WrapupCode.Equals(other.WrapupCode)
            ) &&
            (
                UtilizationLabelId == other.UtilizationLabelId ||
                UtilizationLabelId != null &&
                UtilizationLabelId.Equals(other.UtilizationLabelId)
            ) &&
            (
                ScoredAgents == other.ScoredAgents ||
                ScoredAgents != null &&
                ScoredAgents.SequenceEqual(other.ScoredAgents)
            ) &&
            (
                PreferredAgentIds == other.PreferredAgentIds ||
                PreferredAgentIds != null &&
                PreferredAgentIds.SequenceEqual(other.PreferredAgentIds)
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

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (DateDue != null)
            {
                hash = hash * 59 + DateDue.GetHashCode();
            }

            if (DateExpires != null)
            {
                hash = hash * 59 + DateExpires.GetHashCode();
            }

            if (DurationSeconds != null)
            {
                hash = hash * 59 + DurationSeconds.GetHashCode();
            }

            if (Ttl != null)
            {
                hash = hash * 59 + Ttl.GetHashCode();
            }

            if (StatusId != null)
            {
                hash = hash * 59 + StatusId.GetHashCode();
            }

            if (WorkbinId != null)
            {
                hash = hash * 59 + WorkbinId.GetHashCode();
            }

            if (AutoStatusTransition != null)
            {
                hash = hash * 59 + AutoStatusTransition.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (TypeId != null)
            {
                hash = hash * 59 + TypeId.GetHashCode();
            }

            if (CustomFields != null)
            {
                hash = hash * 59 + CustomFields.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (AssigneeId != null)
            {
                hash = hash * 59 + AssigneeId.GetHashCode();
            }

            if (LanguageId != null)
            {
                hash = hash * 59 + LanguageId.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (ExternalTag != null)
            {
                hash = hash * 59 + ExternalTag.GetHashCode();
            }

            if (SkillIds != null)
            {
                hash = hash * 59 + SkillIds.GetHashCode();
            }

            if (ScriptId != null)
            {
                hash = hash * 59 + ScriptId.GetHashCode();
            }

            if (WrapupCode != null)
            {
                hash = hash * 59 + WrapupCode.GetHashCode();
            }

            if (UtilizationLabelId != null)
            {
                hash = hash * 59 + UtilizationLabelId.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            if (PreferredAgentIds != null)
            {
                hash = hash * 59 + PreferredAgentIds.GetHashCode();
            }

            return hash;
        }
    }
}
