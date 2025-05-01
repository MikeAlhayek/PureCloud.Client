using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorktypeDelta
/// </summary>
[DataContract]
public partial class WorktypeDelta : IEquatable<WorktypeDelta>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorktypeDelta" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Statuses">Statuses.</param>
    /// <param name="DefaultWorkbinId">DefaultWorkbinId.</param>
    /// <param name="DefaultDurationSeconds">DefaultDurationSeconds.</param>
    /// <param name="DefaultExpirationSeconds">DefaultExpirationSeconds.</param>
    /// <param name="DefaultDueDurationSeconds">DefaultDueDurationSeconds.</param>
    /// <param name="DefaultPriority">DefaultPriority.</param>
    /// <param name="DefaultSkillIds">DefaultSkillIds.</param>
    /// <param name="DefaultStatusId">DefaultStatusId.</param>
    /// <param name="DefaultLanguageId">DefaultLanguageId.</param>
    /// <param name="DefaultTtlSeconds">DefaultTtlSeconds.</param>
    /// <param name="AssignmentEnabled">AssignmentEnabled.</param>
    /// <param name="DefaultQueueId">DefaultQueueId.</param>
    /// <param name="SchemaId">SchemaId.</param>
    /// <param name="SchemaVersion">SchemaVersion.</param>
    /// <param name="ServiceLevelTarget">ServiceLevelTarget.</param>
    /// <param name="DateModified">DateModified.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="DefaultScriptId">DefaultScriptId.</param>
    public WorktypeDelta(WorkitemsAttributeChangeString Name = null, WorkitemsAttributeChangeString Description = null, WorkitemsAttributeChangeList Statuses = null, WorkitemsAttributeChangeString DefaultWorkbinId = null, WorkitemsAttributeChangeInteger DefaultDurationSeconds = null, WorkitemsAttributeChangeInteger DefaultExpirationSeconds = null, WorkitemsAttributeChangeInteger DefaultDueDurationSeconds = null, WorkitemsAttributeChangeInteger DefaultPriority = null, WorkitemsAttributeChangeList DefaultSkillIds = null, WorkitemsAttributeChangeString DefaultStatusId = null, WorkitemsAttributeChangeString DefaultLanguageId = null, WorkitemsAttributeChangeInteger DefaultTtlSeconds = null, WorkitemsAttributeChangeBoolean AssignmentEnabled = null, WorkitemsAttributeChangeString DefaultQueueId = null, WorkitemsAttributeChangeString SchemaId = null, WorkitemsAttributeChangeString SchemaVersion = null, WorkitemsAttributeChangeInteger ServiceLevelTarget = null, WorkitemsAttributeChangeInstant DateModified = null, WorkitemsAttributeChangeString ModifiedBy = null, WorkitemsAttributeChangeString DefaultScriptId = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Statuses = Statuses;
        this.DefaultWorkbinId = DefaultWorkbinId;
        this.DefaultDurationSeconds = DefaultDurationSeconds;
        this.DefaultExpirationSeconds = DefaultExpirationSeconds;
        this.DefaultDueDurationSeconds = DefaultDueDurationSeconds;
        this.DefaultPriority = DefaultPriority;
        this.DefaultSkillIds = DefaultSkillIds;
        this.DefaultStatusId = DefaultStatusId;
        this.DefaultLanguageId = DefaultLanguageId;
        this.DefaultTtlSeconds = DefaultTtlSeconds;
        this.AssignmentEnabled = AssignmentEnabled;
        this.DefaultQueueId = DefaultQueueId;
        this.SchemaId = SchemaId;
        this.SchemaVersion = SchemaVersion;
        this.ServiceLevelTarget = ServiceLevelTarget;
        this.DateModified = DateModified;
        this.ModifiedBy = ModifiedBy;
        this.DefaultScriptId = DefaultScriptId;

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
    /// Gets or Sets Statuses
    /// </summary>
    [DataMember(Name = "statuses", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeList Statuses { get; set; }



    /// <summary>
    /// Gets or Sets DefaultWorkbinId
    /// </summary>
    [DataMember(Name = "defaultWorkbinId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString DefaultWorkbinId { get; set; }



    /// <summary>
    /// Gets or Sets DefaultDurationSeconds
    /// </summary>
    [DataMember(Name = "defaultDurationSeconds", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInteger DefaultDurationSeconds { get; set; }



    /// <summary>
    /// Gets or Sets DefaultExpirationSeconds
    /// </summary>
    [DataMember(Name = "defaultExpirationSeconds", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInteger DefaultExpirationSeconds { get; set; }



    /// <summary>
    /// Gets or Sets DefaultDueDurationSeconds
    /// </summary>
    [DataMember(Name = "defaultDueDurationSeconds", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInteger DefaultDueDurationSeconds { get; set; }



    /// <summary>
    /// Gets or Sets DefaultPriority
    /// </summary>
    [DataMember(Name = "defaultPriority", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInteger DefaultPriority { get; set; }



    /// <summary>
    /// Gets or Sets DefaultSkillIds
    /// </summary>
    [DataMember(Name = "defaultSkillIds", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeList DefaultSkillIds { get; set; }



    /// <summary>
    /// Gets or Sets DefaultStatusId
    /// </summary>
    [DataMember(Name = "defaultStatusId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString DefaultStatusId { get; set; }



    /// <summary>
    /// Gets or Sets DefaultLanguageId
    /// </summary>
    [DataMember(Name = "defaultLanguageId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString DefaultLanguageId { get; set; }



    /// <summary>
    /// Gets or Sets DefaultTtlSeconds
    /// </summary>
    [DataMember(Name = "defaultTtlSeconds", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInteger DefaultTtlSeconds { get; set; }



    /// <summary>
    /// Gets or Sets AssignmentEnabled
    /// </summary>
    [DataMember(Name = "assignmentEnabled", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeBoolean AssignmentEnabled { get; set; }



    /// <summary>
    /// Gets or Sets DefaultQueueId
    /// </summary>
    [DataMember(Name = "defaultQueueId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString DefaultQueueId { get; set; }



    /// <summary>
    /// Gets or Sets SchemaId
    /// </summary>
    [DataMember(Name = "schemaId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString SchemaId { get; set; }



    /// <summary>
    /// Gets or Sets SchemaVersion
    /// </summary>
    [DataMember(Name = "schemaVersion", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString SchemaVersion { get; set; }



    /// <summary>
    /// Gets or Sets ServiceLevelTarget
    /// </summary>
    [DataMember(Name = "serviceLevelTarget", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeInteger ServiceLevelTarget { get; set; }



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
    /// Gets or Sets DefaultScriptId
    /// </summary>
    [DataMember(Name = "defaultScriptId", EmitDefaultValue = false)]
    public WorkitemsAttributeChangeString DefaultScriptId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorktypeDelta {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Statuses: ").Append(Statuses).Append("\n");
        sb.Append("  DefaultWorkbinId: ").Append(DefaultWorkbinId).Append("\n");
        sb.Append("  DefaultDurationSeconds: ").Append(DefaultDurationSeconds).Append("\n");
        sb.Append("  DefaultExpirationSeconds: ").Append(DefaultExpirationSeconds).Append("\n");
        sb.Append("  DefaultDueDurationSeconds: ").Append(DefaultDueDurationSeconds).Append("\n");
        sb.Append("  DefaultPriority: ").Append(DefaultPriority).Append("\n");
        sb.Append("  DefaultSkillIds: ").Append(DefaultSkillIds).Append("\n");
        sb.Append("  DefaultStatusId: ").Append(DefaultStatusId).Append("\n");
        sb.Append("  DefaultLanguageId: ").Append(DefaultLanguageId).Append("\n");
        sb.Append("  DefaultTtlSeconds: ").Append(DefaultTtlSeconds).Append("\n");
        sb.Append("  AssignmentEnabled: ").Append(AssignmentEnabled).Append("\n");
        sb.Append("  DefaultQueueId: ").Append(DefaultQueueId).Append("\n");
        sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
        sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
        sb.Append("  ServiceLevelTarget: ").Append(ServiceLevelTarget).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DefaultScriptId: ").Append(DefaultScriptId).Append("\n");
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
        return Equals(obj as WorktypeDelta);
    }

    /// <summary>
    /// Returns true if WorktypeDelta instances are equal
    /// </summary>
    /// <param name="other">Instance of WorktypeDelta to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorktypeDelta other)
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
                Statuses == other.Statuses ||
                Statuses != null &&
                Statuses.Equals(other.Statuses)
            ) &&
            (
                DefaultWorkbinId == other.DefaultWorkbinId ||
                DefaultWorkbinId != null &&
                DefaultWorkbinId.Equals(other.DefaultWorkbinId)
            ) &&
            (
                DefaultDurationSeconds == other.DefaultDurationSeconds ||
                DefaultDurationSeconds != null &&
                DefaultDurationSeconds.Equals(other.DefaultDurationSeconds)
            ) &&
            (
                DefaultExpirationSeconds == other.DefaultExpirationSeconds ||
                DefaultExpirationSeconds != null &&
                DefaultExpirationSeconds.Equals(other.DefaultExpirationSeconds)
            ) &&
            (
                DefaultDueDurationSeconds == other.DefaultDueDurationSeconds ||
                DefaultDueDurationSeconds != null &&
                DefaultDueDurationSeconds.Equals(other.DefaultDueDurationSeconds)
            ) &&
            (
                DefaultPriority == other.DefaultPriority ||
                DefaultPriority != null &&
                DefaultPriority.Equals(other.DefaultPriority)
            ) &&
            (
                DefaultSkillIds == other.DefaultSkillIds ||
                DefaultSkillIds != null &&
                DefaultSkillIds.Equals(other.DefaultSkillIds)
            ) &&
            (
                DefaultStatusId == other.DefaultStatusId ||
                DefaultStatusId != null &&
                DefaultStatusId.Equals(other.DefaultStatusId)
            ) &&
            (
                DefaultLanguageId == other.DefaultLanguageId ||
                DefaultLanguageId != null &&
                DefaultLanguageId.Equals(other.DefaultLanguageId)
            ) &&
            (
                DefaultTtlSeconds == other.DefaultTtlSeconds ||
                DefaultTtlSeconds != null &&
                DefaultTtlSeconds.Equals(other.DefaultTtlSeconds)
            ) &&
            (
                AssignmentEnabled == other.AssignmentEnabled ||
                AssignmentEnabled != null &&
                AssignmentEnabled.Equals(other.AssignmentEnabled)
            ) &&
            (
                DefaultQueueId == other.DefaultQueueId ||
                DefaultQueueId != null &&
                DefaultQueueId.Equals(other.DefaultQueueId)
            ) &&
            (
                SchemaId == other.SchemaId ||
                SchemaId != null &&
                SchemaId.Equals(other.SchemaId)
            ) &&
            (
                SchemaVersion == other.SchemaVersion ||
                SchemaVersion != null &&
                SchemaVersion.Equals(other.SchemaVersion)
            ) &&
            (
                ServiceLevelTarget == other.ServiceLevelTarget ||
                ServiceLevelTarget != null &&
                ServiceLevelTarget.Equals(other.ServiceLevelTarget)
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
                DefaultScriptId == other.DefaultScriptId ||
                DefaultScriptId != null &&
                DefaultScriptId.Equals(other.DefaultScriptId)
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

            if (Statuses != null)
            {
                hash = hash * 59 + Statuses.GetHashCode();
            }

            if (DefaultWorkbinId != null)
            {
                hash = hash * 59 + DefaultWorkbinId.GetHashCode();
            }

            if (DefaultDurationSeconds != null)
            {
                hash = hash * 59 + DefaultDurationSeconds.GetHashCode();
            }

            if (DefaultExpirationSeconds != null)
            {
                hash = hash * 59 + DefaultExpirationSeconds.GetHashCode();
            }

            if (DefaultDueDurationSeconds != null)
            {
                hash = hash * 59 + DefaultDueDurationSeconds.GetHashCode();
            }

            if (DefaultPriority != null)
            {
                hash = hash * 59 + DefaultPriority.GetHashCode();
            }

            if (DefaultSkillIds != null)
            {
                hash = hash * 59 + DefaultSkillIds.GetHashCode();
            }

            if (DefaultStatusId != null)
            {
                hash = hash * 59 + DefaultStatusId.GetHashCode();
            }

            if (DefaultLanguageId != null)
            {
                hash = hash * 59 + DefaultLanguageId.GetHashCode();
            }

            if (DefaultTtlSeconds != null)
            {
                hash = hash * 59 + DefaultTtlSeconds.GetHashCode();
            }

            if (AssignmentEnabled != null)
            {
                hash = hash * 59 + AssignmentEnabled.GetHashCode();
            }

            if (DefaultQueueId != null)
            {
                hash = hash * 59 + DefaultQueueId.GetHashCode();
            }

            if (SchemaId != null)
            {
                hash = hash * 59 + SchemaId.GetHashCode();
            }

            if (SchemaVersion != null)
            {
                hash = hash * 59 + SchemaVersion.GetHashCode();
            }

            if (ServiceLevelTarget != null)
            {
                hash = hash * 59 + ServiceLevelTarget.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DefaultScriptId != null)
            {
                hash = hash * 59 + DefaultScriptId.GetHashCode();
            }

            return hash;
        }
    }
}
