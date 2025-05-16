using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsQueueEventsNotificationWorkitem
{
    /// <summary>
    /// Gets or Sets StatusCategory
    /// </summary>
    public WorkitemsQueueEventsNotificationWorkitemStatusCategoryEnum? StatusCategory { get; set; }

    /// <summary>
    /// Gets or Sets Operation
    /// </summary>
    public WorkitemsQueueEventsNotificationWorkitemOperationEnum? Operation { get; set; }

    /// <summary>
    /// Gets or Sets AssignmentState
    /// </summary>
    public WorkitemsQueueEventsNotificationWorkitemAssignmentStateEnum? AssignmentState { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets TypeId
    /// </summary>
    public string TypeId { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets LanguageId
    /// </summary>
    public string LanguageId { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    public long? Priority { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public string DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    public string DateModified { get; set; }

    /// <summary>
    /// Gets or Sets DateDue
    /// </summary>
    public string DateDue { get; set; }

    /// <summary>
    /// Gets or Sets DateExpires
    /// </summary>
    public string DateExpires { get; set; }

    /// <summary>
    /// Gets or Sets DateAssignmentStateChanged
    /// </summary>
    public string DateAssignmentStateChanged { get; set; }

    /// <summary>
    /// Gets or Sets DurationSeconds
    /// </summary>
    public long? DurationSeconds { get; set; }

    /// <summary>
    /// Gets or Sets Ttl
    /// </summary>
    public long? Ttl { get; set; }

    /// <summary>
    /// Gets or Sets StatusId
    /// </summary>
    public string StatusId { get; set; }

    /// <summary>
    /// Gets or Sets DateClosed
    /// </summary>
    public string DateClosed { get; set; }

    /// <summary>
    /// Gets or Sets WorkbinId
    /// </summary>
    public string WorkbinId { get; set; }

    /// <summary>
    /// Gets or Sets ReporterId
    /// </summary>
    public string ReporterId { get; set; }

    /// <summary>
    /// Gets or Sets AssigneeId
    /// </summary>
    public string AssigneeId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalContactId
    /// </summary>
    public string ExternalContactId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalTag
    /// </summary>
    public string ExternalTag { get; set; }

    /// <summary>
    /// Gets or Sets WrapupId
    /// </summary>
    public string WrapupId { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public string ModifiedBy { get; set; }

    /// <summary>
    /// Gets or Sets Changes
    /// </summary>
    public IEnumerable<WorkitemsQueueEventsNotificationDelta> Changes { get; set; }

    /// <summary>
    /// Gets or Sets AssignmentId
    /// </summary>
    public string AssignmentId { get; set; }

    /// <summary>
    /// Gets or Sets AlertTimeoutSeconds
    /// </summary>
    public long? AlertTimeoutSeconds { get; set; }

    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    public string QueueId { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    public Dictionary<string, WorkitemsQueueEventsNotificationCustomAttribute> CustomFields { get; set; }

    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    public WorkitemsQueueEventsNotificationWrapup Wrapup { get; set; }

    /// <summary>
    /// Gets or Sets Sessions
    /// </summary>
    public IEnumerable<WorkitemsQueueEventsNotificationSession> Sessions { get; set; }

    /// <summary>
    /// Gets or Sets SkillIds
    /// </summary>
    public IEnumerable<Guid?> SkillIds { get; set; }

    /// <summary>
    /// Gets or Sets ScriptId
    /// </summary>
    public string ScriptId { get; set; }
}
