using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemDelta
/// </summary>
[DataContract]
public partial class WorkitemDelta : IEquatable<WorkitemDelta>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemDelta" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="LanguageId">LanguageId.</param>
    /// <param name="UtilizationLabelId">UtilizationLabelId.</param>
    /// <param name="Priority">Priority.</param>
    /// <param name="SkillIds">SkillIds.</param>
    /// <param name="PreferredAgentIds">PreferredAgentIds.</param>
    /// <param name="DateDue">DateDue.</param>
    /// <param name="DateExpires">DateExpires.</param>
    /// <param name="DurationSeconds">DurationSeconds.</param>
    /// <param name="StatusId">StatusId.</param>
    /// <param name="ReporterId">ReporterId.</param>
    /// <param name="ExternalContactId">ExternalContactId.</param>
    /// <param name="AssigneeId">AssigneeId.</param>
    /// <param name="WorkbinId">WorkbinId.</param>
    /// <param name="QueueId">QueueId.</param>
    /// <param name="ExternalTag">ExternalTag.</param>
    /// <param name="WrapupId">WrapupId.</param>
    /// <param name="Wrapup">Wrapup.</param>
    /// <param name="Ttl">Ttl.</param>
    /// <param name="DateClosed">DateClosed.</param>
    /// <param name="AssignmentState">AssignmentState.</param>
    /// <param name="AutoStatusTransition">AutoStatusTransition.</param>
    /// <param name="CustomFields">CustomFields.</param>
    /// <param name="DateModified">DateModified.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="StatusCategory">StatusCategory.</param>
    /// <param name="ScriptId">ScriptId.</param>
    public WorkitemDelta(WorkitemsAttributeChangeString Name = null, WorkitemsAttributeChangeString Description = null, WorkitemsAttributeChangeString LanguageId = null, WorkitemsAttributeChangeString UtilizationLabelId = null, WorkitemsAttributeChangeInteger Priority = null, WorkitemsAttributeChangeList SkillIds = null, WorkitemsAttributeChangeList PreferredAgentIds = null, WorkitemsAttributeChangeInstant DateDue = null, WorkitemsAttributeChangeInstant DateExpires = null, WorkitemsAttributeChangeInteger DurationSeconds = null, WorkitemsAttributeChangeString StatusId = null, WorkitemsAttributeChangeString ReporterId = null, WorkitemsAttributeChangeString ExternalContactId = null, WorkitemsAttributeChangeString AssigneeId = null, WorkitemsAttributeChangeString WorkbinId = null, WorkitemsAttributeChangeString QueueId = null, WorkitemsAttributeChangeString ExternalTag = null, WorkitemsAttributeChangeString WrapupId = null, WorkitemsAttributeChangeWrapupDelta Wrapup = null, WorkitemsAttributeChangeInteger Ttl = null, WorkitemsAttributeChangeInstant DateClosed = null, WorkitemsAttributeChangeString AssignmentState = null, WorkitemsAttributeChangeBoolean AutoStatusTransition = null, WorkitemsAttributeChangeMap CustomFields = null, WorkitemsAttributeChangeInstant DateModified = null, WorkitemsAttributeChangeString ModifiedBy = null, WorkitemsAttributeChangeWorkitemStatusCategory StatusCategory = null, WorkitemsAttributeChangeString ScriptId = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.LanguageId = LanguageId;
        this.UtilizationLabelId = UtilizationLabelId;
        this.Priority = Priority;
        this.SkillIds = SkillIds;
        this.PreferredAgentIds = PreferredAgentIds;
        this.DateDue = DateDue;
        this.DateExpires = DateExpires;
        this.DurationSeconds = DurationSeconds;
        this.StatusId = StatusId;
        this.ReporterId = ReporterId;
        this.ExternalContactId = ExternalContactId;
        this.AssigneeId = AssigneeId;
        this.WorkbinId = WorkbinId;
        this.QueueId = QueueId;
        this.ExternalTag = ExternalTag;
        this.WrapupId = WrapupId;
        this.Wrapup = Wrapup;
        this.Ttl = Ttl;
        this.DateClosed = DateClosed;
        this.AssignmentState = AssignmentState;
        this.AutoStatusTransition = AutoStatusTransition;
        this.CustomFields = CustomFields;
        this.DateModified = DateModified;
        this.ModifiedBy = ModifiedBy;
        this.StatusCategory = StatusCategory;
        this.ScriptId = ScriptId;

    }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString Description { get; set; }



    /// <summary>
    /// Gets or Sets LanguageId
    /// </summary>
    [DataMember(Name = "languageId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString LanguageId { get; set; }



    /// <summary>
    /// Gets or Sets UtilizationLabelId
    /// </summary>
    [DataMember(Name = "utilizationLabelId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString UtilizationLabelId { get; set; }



    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInteger Priority { get; set; }



    /// <summary>
    /// Gets or Sets SkillIds
    /// </summary>
    [DataMember(Name = "skillIds", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeList SkillIds { get; set; }



    /// <summary>
    /// Gets or Sets PreferredAgentIds
    /// </summary>
    [DataMember(Name = "preferredAgentIds", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeList PreferredAgentIds { get; set; }



    /// <summary>
    /// Gets or Sets DateDue
    /// </summary>
    [DataMember(Name = "dateDue", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInstant DateDue { get; set; }



    /// <summary>
    /// Gets or Sets DateExpires
    /// </summary>
    [DataMember(Name = "dateExpires", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInstant DateExpires { get; set; }



    /// <summary>
    /// Gets or Sets DurationSeconds
    /// </summary>
    [DataMember(Name = "durationSeconds", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInteger DurationSeconds { get; set; }



    /// <summary>
    /// Gets or Sets StatusId
    /// </summary>
    [DataMember(Name = "statusId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString StatusId { get; set; }



    /// <summary>
    /// Gets or Sets ReporterId
    /// </summary>
    [DataMember(Name = "reporterId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString ReporterId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContactId
    /// </summary>
    [DataMember(Name = "externalContactId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString ExternalContactId { get; set; }



    /// <summary>
    /// Gets or Sets AssigneeId
    /// </summary>
    [DataMember(Name = "assigneeId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString AssigneeId { get; set; }



    /// <summary>
    /// Gets or Sets WorkbinId
    /// </summary>
    [DataMember(Name = "workbinId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString WorkbinId { get; set; }



    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString QueueId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalTag
    /// </summary>
    [DataMember(Name = "externalTag", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString ExternalTag { get; set; }



    /// <summary>
    /// Gets or Sets WrapupId
    /// </summary>
    [DataMember(Name = "wrapupId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString WrapupId { get; set; }



    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    [DataMember(Name = "wrapup", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeWrapupDelta Wrapup { get; set; }



    /// <summary>
    /// Gets or Sets Ttl
    /// </summary>
    [DataMember(Name = "ttl", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInteger Ttl { get; set; }



    /// <summary>
    /// Gets or Sets DateClosed
    /// </summary>
    [DataMember(Name = "dateClosed", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInstant DateClosed { get; set; }



    /// <summary>
    /// Gets or Sets AssignmentState
    /// </summary>
    [DataMember(Name = "assignmentState", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString AssignmentState { get; set; }



    /// <summary>
    /// Gets or Sets AutoStatusTransition
    /// </summary>
    [DataMember(Name = "autoStatusTransition", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeBoolean AutoStatusTransition { get; set; }



    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name = "customFields", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeMap CustomFields { get; set; }



    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInstant DateModified { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString ModifiedBy { get; set; }



    /// <summary>
    /// Gets or Sets StatusCategory
    /// </summary>
    [DataMember(Name = "statusCategory", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeWorkitemStatusCategory StatusCategory { get; set; }



    /// <summary>
    /// Gets or Sets ScriptId
    /// </summary>
    [DataMember(Name = "scriptId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString ScriptId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemDelta {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
        sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
        sb.Append("  PreferredAgentIds: ").Append(PreferredAgentIds).Append("\n");
        sb.Append("  DateDue: ").Append(DateDue).Append("\n");
        sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
        sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
        sb.Append("  StatusId: ").Append(StatusId).Append("\n");
        sb.Append("  ReporterId: ").Append(ReporterId).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
        sb.Append("  WorkbinId: ").Append(WorkbinId).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
        sb.Append("  WrapupId: ").Append(WrapupId).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  Ttl: ").Append(Ttl).Append("\n");
        sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
        sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
        sb.Append("  AutoStatusTransition: ").Append(AutoStatusTransition).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  StatusCategory: ").Append(StatusCategory).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
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
        return Equals(obj as WorkitemDelta);
    }

    /// <summary>
    /// Returns true if WorkitemDelta instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemDelta to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemDelta other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                LanguageId == other.LanguageId ||
                LanguageId != null &&
                LanguageId.Equals(other.LanguageId)
            ) &&
            (
                UtilizationLabelId == other.UtilizationLabelId ||
                UtilizationLabelId != null &&
                UtilizationLabelId.Equals(other.UtilizationLabelId)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                SkillIds == other.SkillIds ||
                SkillIds != null &&
                SkillIds.Equals(other.SkillIds)
            ) &&
            (
                PreferredAgentIds == other.PreferredAgentIds ||
                PreferredAgentIds != null &&
                PreferredAgentIds.Equals(other.PreferredAgentIds)
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
                StatusId == other.StatusId ||
                StatusId != null &&
                StatusId.Equals(other.StatusId)
            ) &&
            (
                ReporterId == other.ReporterId ||
                ReporterId != null &&
                ReporterId.Equals(other.ReporterId)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                AssigneeId == other.AssigneeId ||
                AssigneeId != null &&
                AssigneeId.Equals(other.AssigneeId)
            ) &&
            (
                WorkbinId == other.WorkbinId ||
                WorkbinId != null &&
                WorkbinId.Equals(other.WorkbinId)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                ExternalTag == other.ExternalTag ||
                ExternalTag != null &&
                ExternalTag.Equals(other.ExternalTag)
            ) &&
            (
                WrapupId == other.WrapupId ||
                WrapupId != null &&
                WrapupId.Equals(other.WrapupId)
            ) &&
            (
                Wrapup == other.Wrapup ||
                Wrapup != null &&
                Wrapup.Equals(other.Wrapup)
            ) &&
            (
                Ttl == other.Ttl ||
                Ttl != null &&
                Ttl.Equals(other.Ttl)
            ) &&
            (
                DateClosed == other.DateClosed ||
                DateClosed != null &&
                DateClosed.Equals(other.DateClosed)
            ) &&
            (
                AssignmentState == other.AssignmentState ||
                AssignmentState != null &&
                AssignmentState.Equals(other.AssignmentState)
            ) &&
            (
                AutoStatusTransition == other.AutoStatusTransition ||
                AutoStatusTransition != null &&
                AutoStatusTransition.Equals(other.AutoStatusTransition)
            ) &&
            (
                CustomFields == other.CustomFields ||
                CustomFields != null &&
                CustomFields.Equals(other.CustomFields)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                StatusCategory == other.StatusCategory ||
                StatusCategory != null &&
                StatusCategory.Equals(other.StatusCategory)
            ) &&
            (
                ScriptId == other.ScriptId ||
                ScriptId != null &&
                ScriptId.Equals(other.ScriptId)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (LanguageId != null)
            {
                hash = hash * 59 + LanguageId.GetHashCode();
            }

            if (UtilizationLabelId != null)
            {
                hash = hash * 59 + UtilizationLabelId.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (SkillIds != null)
            {
                hash = hash * 59 + SkillIds.GetHashCode();
            }

            if (PreferredAgentIds != null)
            {
                hash = hash * 59 + PreferredAgentIds.GetHashCode();
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

            if (StatusId != null)
            {
                hash = hash * 59 + StatusId.GetHashCode();
            }

            if (ReporterId != null)
            {
                hash = hash * 59 + ReporterId.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (AssigneeId != null)
            {
                hash = hash * 59 + AssigneeId.GetHashCode();
            }

            if (WorkbinId != null)
            {
                hash = hash * 59 + WorkbinId.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (ExternalTag != null)
            {
                hash = hash * 59 + ExternalTag.GetHashCode();
            }

            if (WrapupId != null)
            {
                hash = hash * 59 + WrapupId.GetHashCode();
            }

            if (Wrapup != null)
            {
                hash = hash * 59 + Wrapup.GetHashCode();
            }

            if (Ttl != null)
            {
                hash = hash * 59 + Ttl.GetHashCode();
            }

            if (DateClosed != null)
            {
                hash = hash * 59 + DateClosed.GetHashCode();
            }

            if (AssignmentState != null)
            {
                hash = hash * 59 + AssignmentState.GetHashCode();
            }

            if (AutoStatusTransition != null)
            {
                hash = hash * 59 + AutoStatusTransition.GetHashCode();
            }

            if (CustomFields != null)
            {
                hash = hash * 59 + CustomFields.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (StatusCategory != null)
            {
                hash = hash * 59 + StatusCategory.GetHashCode();
            }

            if (ScriptId != null)
            {
                hash = hash * 59 + ScriptId.GetHashCode();
            }

            return hash;
        }
    }
}
