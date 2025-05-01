using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemsEventsNotificationWorkitem
/// </summary>
[DataContract]
public partial class WorkitemsEventsNotificationWorkitem : IEquatable<WorkitemsEventsNotificationWorkitem>
{
    /// <summary>
    /// Gets or Sets StatusCategory
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusCategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Waiting for "Waiting"
        /// </summary>
        [EnumMember(Value = "Waiting")]
        Waiting,

        /// <summary>
        /// Enum Closed for "Closed"
        /// </summary>
        [EnumMember(Value = "Closed")]
        Closed
    }
    /// <summary>
    /// Gets or Sets Operation
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Add for "add"
        /// </summary>
        [EnumMember(Value = "add")]
        Add,

        /// <summary>
        /// Enum Edit for "edit"
        /// </summary>
        [EnumMember(Value = "edit")]
        Edit,

        /// <summary>
        /// Enum Delete for "delete"
        /// </summary>
        [EnumMember(Value = "delete")]
        Delete,

        /// <summary>
        /// Enum View for "view"
        /// </summary>
        [EnumMember(Value = "view")]
        View,

        /// <summary>
        /// Enum Upload for "upload"
        /// </summary>
        [EnumMember(Value = "upload")]
        Upload,

        /// <summary>
        /// Enum Download for "download"
        /// </summary>
        [EnumMember(Value = "download")]
        Download,

        /// <summary>
        /// Enum Activate for "activate"
        /// </summary>
        [EnumMember(Value = "activate")]
        Activate,

        /// <summary>
        /// Enum Deactivate for "deactivate"
        /// </summary>
        [EnumMember(Value = "deactivate")]
        Deactivate,

        /// <summary>
        /// Enum Purge for "purge"
        /// </summary>
        [EnumMember(Value = "purge")]
        Purge,

        /// <summary>
        /// Enum Processed for "processed"
        /// </summary>
        [EnumMember(Value = "processed")]
        Processed,

        /// <summary>
        /// Enum Published for "published"
        /// </summary>
        [EnumMember(Value = "published")]
        Published,

        /// <summary>
        /// Enum Assigned for "assigned"
        /// </summary>
        [EnumMember(Value = "assigned")]
        Assigned,

        /// <summary>
        /// Enum Unassigned for "unassigned"
        /// </summary>
        [EnumMember(Value = "unassigned")]
        Unassigned,

        /// <summary>
        /// Enum Reset for "reset"
        /// </summary>
        [EnumMember(Value = "reset")]
        Reset,

        /// <summary>
        /// Enum Reassigned for "reassigned"
        /// </summary>
        [EnumMember(Value = "reassigned")]
        Reassigned,

        /// <summary>
        /// Enum Reassign for "reassign"
        /// </summary>
        [EnumMember(Value = "reassign")]
        Reassign,

        /// <summary>
        /// Enum Archive for "archive"
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,

        /// <summary>
        /// Enum Unarchive for "unarchive"
        /// </summary>
        [EnumMember(Value = "unarchive")]
        Unarchive,

        /// <summary>
        /// Enum Reschedule for "reschedule"
        /// </summary>
        [EnumMember(Value = "reschedule")]
        Reschedule
    }
    /// <summary>
    /// Gets or Sets AssignmentState
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AssignmentStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Idle for "Idle"
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle,

        /// <summary>
        /// Enum Acdstarted for "AcdStarted"
        /// </summary>
        [EnumMember(Value = "AcdStarted")]
        Acdstarted,

        /// <summary>
        /// Enum Alerting for "Alerting"
        /// </summary>
        [EnumMember(Value = "Alerting")]
        Alerting,

        /// <summary>
        /// Enum Alerttimeout for "AlertTimeout"
        /// </summary>
        [EnumMember(Value = "AlertTimeout")]
        Alerttimeout,

        /// <summary>
        /// Enum Declined for "Declined"
        /// </summary>
        [EnumMember(Value = "Declined")]
        Declined,

        /// <summary>
        /// Enum Connected for "Connected"
        /// </summary>
        [EnumMember(Value = "Connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "Disconnected"
        /// </summary>
        [EnumMember(Value = "Disconnected")]
        Disconnected,

        /// <summary>
        /// Enum Parked for "Parked"
        /// </summary>
        [EnumMember(Value = "Parked")]
        Parked,

        /// <summary>
        /// Enum Held for "Held"
        /// </summary>
        [EnumMember(Value = "Held")]
        Held,

        /// <summary>
        /// Enum Acdcancelled for "AcdCancelled"
        /// </summary>
        [EnumMember(Value = "AcdCancelled")]
        Acdcancelled,

        /// <summary>
        /// Enum Terminated for "Terminated"
        /// </summary>
        [EnumMember(Value = "Terminated")]
        Terminated,

        /// <summary>
        /// Enum Acdexpired for "AcdExpired"
        /// </summary>
        [EnumMember(Value = "AcdExpired")]
        Acdexpired
    }
    /// <summary>
    /// Gets or Sets StatusCategory
    /// </summary>
    [DataMember(Name = "statusCategory", EmitDefaultValue = false)]
    public StatusCategoryEnum? StatusCategory { get; set; }
    /// <summary>
    /// Gets or Sets Operation
    /// </summary>
    [DataMember(Name = "operation", EmitDefaultValue = false)]
    public OperationEnum? Operation { get; set; }
    /// <summary>
    /// Gets or Sets AssignmentState
    /// </summary>
    [DataMember(Name = "assignmentState", EmitDefaultValue = false)]
    public AssignmentStateEnum? AssignmentState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemsEventsNotificationWorkitem" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="TypeId">TypeId.</param>
    /// <param name="Description">Description.</param>
    /// <param name="LanguageId">LanguageId.</param>
    /// <param name="Priority">Priority.</param>
    /// <param name="DateCreated">DateCreated.</param>
    /// <param name="DateModified">DateModified.</param>
    /// <param name="DateDue">DateDue.</param>
    /// <param name="DateExpires">DateExpires.</param>
    /// <param name="DateAssignmentStateChanged">DateAssignmentStateChanged.</param>
    /// <param name="DurationSeconds">DurationSeconds.</param>
    /// <param name="Ttl">Ttl.</param>
    /// <param name="StatusId">StatusId.</param>
    /// <param name="StatusCategory">StatusCategory.</param>
    /// <param name="DateClosed">DateClosed.</param>
    /// <param name="WorkbinId">WorkbinId.</param>
    /// <param name="ReporterId">ReporterId.</param>
    /// <param name="AssigneeId">AssigneeId.</param>
    /// <param name="ExternalContactId">ExternalContactId.</param>
    /// <param name="ExternalTag">ExternalTag.</param>
    /// <param name="WrapupId">WrapupId.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="Operation">Operation.</param>
    /// <param name="Changes">Changes.</param>
    /// <param name="AssignmentState">AssignmentState.</param>
    /// <param name="AssignmentId">AssignmentId.</param>
    /// <param name="AlertTimeoutSeconds">AlertTimeoutSeconds.</param>
    /// <param name="QueueId">QueueId.</param>
    /// <param name="CustomFields">CustomFields.</param>
    /// <param name="Wrapup">Wrapup.</param>
    /// <param name="Sessions">Sessions.</param>
    /// <param name="SkillIds">SkillIds.</param>
    /// <param name="ScriptId">ScriptId.</param>
    public WorkitemsEventsNotificationWorkitem(string Id = null, string Name = null, string TypeId = null, string Description = null, string LanguageId = null, long? Priority = null, string DateCreated = null, string DateModified = null, string DateDue = null, string DateExpires = null, string DateAssignmentStateChanged = null, long? DurationSeconds = null, long? Ttl = null, string StatusId = null, StatusCategoryEnum? StatusCategory = null, string DateClosed = null, string WorkbinId = null, string ReporterId = null, string AssigneeId = null, string ExternalContactId = null, string ExternalTag = null, string WrapupId = null, string ModifiedBy = null, OperationEnum? Operation = null, List<WorkitemsEventsNotificationDelta> Changes = null, AssignmentStateEnum? AssignmentState = null, string AssignmentId = null, long? AlertTimeoutSeconds = null, string QueueId = null, Dictionary<string, WorkitemsEventsNotificationCustomAttribute> CustomFields = null, WorkitemsEventsNotificationWrapup Wrapup = null, List<WorkitemsEventsNotificationSession> Sessions = null, List<Guid?> SkillIds = null, string ScriptId = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.TypeId = TypeId;
        this.Description = Description;
        this.LanguageId = LanguageId;
        this.Priority = Priority;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.DateDue = DateDue;
        this.DateExpires = DateExpires;
        this.DateAssignmentStateChanged = DateAssignmentStateChanged;
        this.DurationSeconds = DurationSeconds;
        this.Ttl = Ttl;
        this.StatusId = StatusId;
        this.StatusCategory = StatusCategory;
        this.DateClosed = DateClosed;
        this.WorkbinId = WorkbinId;
        this.ReporterId = ReporterId;
        this.AssigneeId = AssigneeId;
        this.ExternalContactId = ExternalContactId;
        this.ExternalTag = ExternalTag;
        this.WrapupId = WrapupId;
        this.ModifiedBy = ModifiedBy;
        this.Operation = Operation;
        this.Changes = Changes;
        this.AssignmentState = AssignmentState;
        this.AssignmentId = AssignmentId;
        this.AlertTimeoutSeconds = AlertTimeoutSeconds;
        this.QueueId = QueueId;
        this.CustomFields = CustomFields;
        this.Wrapup = Wrapup;
        this.Sessions = Sessions;
        this.SkillIds = SkillIds;
        this.ScriptId = ScriptId;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets TypeId
    /// </summary>
    [DataMember(Name = "typeId", EmitDefaultValue = false)]
    public string TypeId { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets LanguageId
    /// </summary>
    [DataMember(Name = "languageId", EmitDefaultValue = false)]
    public string LanguageId { get; set; }



    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public long? Priority { get; set; }



    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public string DateCreated { get; set; }



    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public string DateModified { get; set; }



    /// <summary>
    /// Gets or Sets DateDue
    /// </summary>
    [DataMember(Name = "dateDue", EmitDefaultValue = false)]
    public string DateDue { get; set; }



    /// <summary>
    /// Gets or Sets DateExpires
    /// </summary>
    [DataMember(Name = "dateExpires", EmitDefaultValue = false)]
    public string DateExpires { get; set; }



    /// <summary>
    /// Gets or Sets DateAssignmentStateChanged
    /// </summary>
    [DataMember(Name = "dateAssignmentStateChanged", EmitDefaultValue = false)]
    public string DateAssignmentStateChanged { get; set; }



    /// <summary>
    /// Gets or Sets DurationSeconds
    /// </summary>
    [DataMember(Name = "durationSeconds", EmitDefaultValue = false)]
    public long? DurationSeconds { get; set; }



    /// <summary>
    /// Gets or Sets Ttl
    /// </summary>
    [DataMember(Name = "ttl", EmitDefaultValue = false)]
    public long? Ttl { get; set; }



    /// <summary>
    /// Gets or Sets StatusId
    /// </summary>
    [DataMember(Name = "statusId", EmitDefaultValue = false)]
    public string StatusId { get; set; }





    /// <summary>
    /// Gets or Sets DateClosed
    /// </summary>
    [DataMember(Name = "dateClosed", EmitDefaultValue = false)]
    public string DateClosed { get; set; }



    /// <summary>
    /// Gets or Sets WorkbinId
    /// </summary>
    [DataMember(Name = "workbinId", EmitDefaultValue = false)]
    public string WorkbinId { get; set; }



    /// <summary>
    /// Gets or Sets ReporterId
    /// </summary>
    [DataMember(Name = "reporterId", EmitDefaultValue = false)]
    public string ReporterId { get; set; }



    /// <summary>
    /// Gets or Sets AssigneeId
    /// </summary>
    [DataMember(Name = "assigneeId", EmitDefaultValue = false)]
    public string AssigneeId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContactId
    /// </summary>
    [DataMember(Name = "externalContactId", EmitDefaultValue = false)]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalTag
    /// </summary>
    [DataMember(Name = "externalTag", EmitDefaultValue = false)]
    public string ExternalTag { get; set; }



    /// <summary>
    /// Gets or Sets WrapupId
    /// </summary>
    [DataMember(Name = "wrapupId", EmitDefaultValue = false)]
    public string WrapupId { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public string ModifiedBy { get; set; }





    /// <summary>
    /// Gets or Sets Changes
    /// </summary>
    [DataMember(Name = "changes", EmitDefaultValue = false)]
    public List<WorkitemsEventsNotificationDelta> Changes { get; set; }





    /// <summary>
    /// Gets or Sets AssignmentId
    /// </summary>
    [DataMember(Name = "assignmentId", EmitDefaultValue = false)]
    public string AssignmentId { get; set; }



    /// <summary>
    /// Gets or Sets AlertTimeoutSeconds
    /// </summary>
    [DataMember(Name = "alertTimeoutSeconds", EmitDefaultValue = false)]
    public long? AlertTimeoutSeconds { get; set; }



    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name = "customFields", EmitDefaultValue = false)]
    public Dictionary<string, WorkitemsEventsNotificationCustomAttribute> CustomFields { get; set; }



    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    [DataMember(Name = "wrapup", EmitDefaultValue = false)]
    public WorkitemsEventsNotificationWrapup Wrapup { get; set; }



    /// <summary>
    /// Gets or Sets Sessions
    /// </summary>
    [DataMember(Name = "sessions", EmitDefaultValue = false)]
    public List<WorkitemsEventsNotificationSession> Sessions { get; set; }



    /// <summary>
    /// Gets or Sets SkillIds
    /// </summary>
    [DataMember(Name = "skillIds", EmitDefaultValue = false)]
    public List<Guid?> SkillIds { get; set; }



    /// <summary>
    /// Gets or Sets ScriptId
    /// </summary>
    [DataMember(Name = "scriptId", EmitDefaultValue = false)]
    public string ScriptId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemsEventsNotificationWorkitem {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TypeId: ").Append(TypeId).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateDue: ").Append(DateDue).Append("\n");
        sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
        sb.Append("  DateAssignmentStateChanged: ").Append(DateAssignmentStateChanged).Append("\n");
        sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
        sb.Append("  Ttl: ").Append(Ttl).Append("\n");
        sb.Append("  StatusId: ").Append(StatusId).Append("\n");
        sb.Append("  StatusCategory: ").Append(StatusCategory).Append("\n");
        sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
        sb.Append("  WorkbinId: ").Append(WorkbinId).Append("\n");
        sb.Append("  ReporterId: ").Append(ReporterId).Append("\n");
        sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
        sb.Append("  WrapupId: ").Append(WrapupId).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  Operation: ").Append(Operation).Append("\n");
        sb.Append("  Changes: ").Append(Changes).Append("\n");
        sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
        sb.Append("  AssignmentId: ").Append(AssignmentId).Append("\n");
        sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  Sessions: ").Append(Sessions).Append("\n");
        sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
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
        return Equals(obj as WorkitemsEventsNotificationWorkitem);
    }

    /// <summary>
    /// Returns true if WorkitemsEventsNotificationWorkitem instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemsEventsNotificationWorkitem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemsEventsNotificationWorkitem other)
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
                TypeId == other.TypeId ||
                TypeId != null &&
                TypeId.Equals(other.TypeId)
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
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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
                DateAssignmentStateChanged == other.DateAssignmentStateChanged ||
                DateAssignmentStateChanged != null &&
                DateAssignmentStateChanged.Equals(other.DateAssignmentStateChanged)
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
                StatusCategory == other.StatusCategory ||
                StatusCategory != null &&
                StatusCategory.Equals(other.StatusCategory)
            ) &&
            (
                DateClosed == other.DateClosed ||
                DateClosed != null &&
                DateClosed.Equals(other.DateClosed)
            ) &&
            (
                WorkbinId == other.WorkbinId ||
                WorkbinId != null &&
                WorkbinId.Equals(other.WorkbinId)
            ) &&
            (
                ReporterId == other.ReporterId ||
                ReporterId != null &&
                ReporterId.Equals(other.ReporterId)
            ) &&
            (
                AssigneeId == other.AssigneeId ||
                AssigneeId != null &&
                AssigneeId.Equals(other.AssigneeId)
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
                WrapupId == other.WrapupId ||
                WrapupId != null &&
                WrapupId.Equals(other.WrapupId)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                Operation == other.Operation ||
                Operation != null &&
                Operation.Equals(other.Operation)
            ) &&
            (
                Changes == other.Changes ||
                Changes != null &&
                Changes.SequenceEqual(other.Changes)
            ) &&
            (
                AssignmentState == other.AssignmentState ||
                AssignmentState != null &&
                AssignmentState.Equals(other.AssignmentState)
            ) &&
            (
                AssignmentId == other.AssignmentId ||
                AssignmentId != null &&
                AssignmentId.Equals(other.AssignmentId)
            ) &&
            (
                AlertTimeoutSeconds == other.AlertTimeoutSeconds ||
                AlertTimeoutSeconds != null &&
                AlertTimeoutSeconds.Equals(other.AlertTimeoutSeconds)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                CustomFields == other.CustomFields ||
                CustomFields != null &&
                CustomFields.SequenceEqual(other.CustomFields)
            ) &&
            (
                Wrapup == other.Wrapup ||
                Wrapup != null &&
                Wrapup.Equals(other.Wrapup)
            ) &&
            (
                Sessions == other.Sessions ||
                Sessions != null &&
                Sessions.SequenceEqual(other.Sessions)
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

            if (TypeId != null)
            {
                hash = hash * 59 + TypeId.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (LanguageId != null)
            {
                hash = hash * 59 + LanguageId.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DateDue != null)
            {
                hash = hash * 59 + DateDue.GetHashCode();
            }

            if (DateExpires != null)
            {
                hash = hash * 59 + DateExpires.GetHashCode();
            }

            if (DateAssignmentStateChanged != null)
            {
                hash = hash * 59 + DateAssignmentStateChanged.GetHashCode();
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

            if (StatusCategory != null)
            {
                hash = hash * 59 + StatusCategory.GetHashCode();
            }

            if (DateClosed != null)
            {
                hash = hash * 59 + DateClosed.GetHashCode();
            }

            if (WorkbinId != null)
            {
                hash = hash * 59 + WorkbinId.GetHashCode();
            }

            if (ReporterId != null)
            {
                hash = hash * 59 + ReporterId.GetHashCode();
            }

            if (AssigneeId != null)
            {
                hash = hash * 59 + AssigneeId.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (ExternalTag != null)
            {
                hash = hash * 59 + ExternalTag.GetHashCode();
            }

            if (WrapupId != null)
            {
                hash = hash * 59 + WrapupId.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (Operation != null)
            {
                hash = hash * 59 + Operation.GetHashCode();
            }

            if (Changes != null)
            {
                hash = hash * 59 + Changes.GetHashCode();
            }

            if (AssignmentState != null)
            {
                hash = hash * 59 + AssignmentState.GetHashCode();
            }

            if (AssignmentId != null)
            {
                hash = hash * 59 + AssignmentId.GetHashCode();
            }

            if (AlertTimeoutSeconds != null)
            {
                hash = hash * 59 + AlertTimeoutSeconds.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (CustomFields != null)
            {
                hash = hash * 59 + CustomFields.GetHashCode();
            }

            if (Wrapup != null)
            {
                hash = hash * 59 + Wrapup.GetHashCode();
            }

            if (Sessions != null)
            {
                hash = hash * 59 + Sessions.GetHashCode();
            }

            if (SkillIds != null)
            {
                hash = hash * 59 + SkillIds.GetHashCode();
            }

            if (ScriptId != null)
            {
                hash = hash * 59 + ScriptId.GetHashCode();
            }

            return hash;
        }
    }
}
