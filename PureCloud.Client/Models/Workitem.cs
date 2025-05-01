using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Workitem
/// </summary>
[DataContract]
public partial class Workitem : IEquatable<Workitem>
{
    /// <summary>
    /// The Category of the current Status of the Workitem.
    /// </summary>
    /// <value>The Category of the current Status of the Workitem.</value>
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
        Closed,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The assignment state of the workitem.
    /// </summary>
    /// <value>The assignment state of the workitem.</value>
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
        /// Enum Idle for "Idle"
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle,

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
        /// Enum Acdexpired for "AcdExpired"
        /// </summary>
        [EnumMember(Value = "AcdExpired")]
        Acdexpired
    }
    /// <summary>
    /// The Category of the current Status of the Workitem.
    /// </summary>
    /// <value>The Category of the current Status of the Workitem.</value>
    [DataMember(Name = "statusCategory", EmitDefaultValue = false)]
    public StatusCategoryEnum? StatusCategory { get; set; }
    /// <summary>
    /// The assignment state of the workitem.
    /// </summary>
    /// <value>The assignment state of the workitem.</value>
    [DataMember(Name = "assignmentState", EmitDefaultValue = false)]
    public AssignmentStateEnum? AssignmentState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Workitem" /> class.
    /// </summary>
    /// <param name="Name">The name of the Workitem..</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Type">The Worktype of the Workitem..</param>
    /// <param name="Description">The description of the Workitem..</param>
    /// <param name="Language">The language of the Workitem..</param>
    /// <param name="UtilizationLabel">The utilization label of the Workitem..</param>
    /// <param name="Priority">The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000..</param>
    /// <param name="DateCreated">The creation date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">The modified date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateDue">The due date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateExpires">The expiry date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DurationSeconds">The estimated duration in seconds to complete the workitem..</param>
    /// <param name="Ttl">The time to live of the Workitem in seconds..</param>
    /// <param name="Status">The current Status of the Workitem..</param>
    /// <param name="StatusCategory">The Category of the current Status of the Workitem..</param>
    /// <param name="DateStatusChanged">The State change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateClosed">The date the Workitem was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Workbin">The Workbin that contains the Workitem..</param>
    /// <param name="Reporter">The reporter of the Workitem..</param>
    /// <param name="Assignee">The assignee of the Workitem..</param>
    /// <param name="ExternalContact">The external contact of the Workitem..</param>
    /// <param name="ExternalTag">The external tag of the Workitem..</param>
    /// <param name="ModifiedBy">The User who modified the Workitem..</param>
    /// <param name="Queue">The Workitems queue..</param>
    /// <param name="AssignmentState">The assignment state of the workitem..</param>
    /// <param name="DateAssignmentStateChanged">The assignment state change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AlertTimeoutSeconds">The duration in seconds before an alert will timeout..</param>
    /// <param name="Skills">The skills of the Workitem..</param>
    /// <param name="PreferredAgents">The preferred agents of the Workitem..</param>
    /// <param name="AutoStatusTransition">Set it to false to disable auto status transition. By default, it is enabled..</param>
    /// <param name="Schema">The schema defining the custom fields of the Workitem. The schema is inherited from the Workitems Worktype at creation time..</param>
    /// <param name="CustomFields">Custom fields defined in the schema referenced by the Workitem..</param>
    /// <param name="AutoStatusTransitionDetail">Auto status transition details of Workitem..</param>
    /// <param name="ScoredAgents">A list of scored agents for the Workitem..</param>
    /// <param name="Script">The script that will be executed for the Workitem..</param>
    public Workitem(string Name = null, Division Division = null, WorktypeReference Type = null, string Description = null, LanguageReference Language = null, WorkitemUtilizationLabelReference UtilizationLabel = null, int? Priority = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DateDue = null, DateTime? DateExpires = null, int? DurationSeconds = null, int? Ttl = null, WorkitemStatusReference Status = null, StatusCategoryEnum? StatusCategory = null, DateTime? DateStatusChanged = null, DateTime? DateClosed = null, WorkbinReference Workbin = null, UserReferenceWithName Reporter = null, UserReferenceWithName Assignee = null, ExternalContactReference ExternalContact = null, string ExternalTag = null, UserReference ModifiedBy = null, WorkitemQueueReference Queue = null, AssignmentStateEnum? AssignmentState = null, DateTime? DateAssignmentStateChanged = null, int? AlertTimeoutSeconds = null, List<RoutingSkillReference> Skills = null, List<UserReference> PreferredAgents = null, bool? AutoStatusTransition = null, WorkitemSchema Schema = null, Dictionary<string, object> CustomFields = null, AutoStatusTransitionDetail AutoStatusTransitionDetail = null, List<WorkitemScoredAgent> ScoredAgents = null, WorkitemScriptReference Script = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Type = Type;
        this.Description = Description;
        this.Language = Language;
        this.UtilizationLabel = UtilizationLabel;
        this.Priority = Priority;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.DateDue = DateDue;
        this.DateExpires = DateExpires;
        this.DurationSeconds = DurationSeconds;
        this.Ttl = Ttl;
        this.Status = Status;
        this.StatusCategory = StatusCategory;
        this.DateStatusChanged = DateStatusChanged;
        this.DateClosed = DateClosed;
        this.Workbin = Workbin;
        this.Reporter = Reporter;
        this.Assignee = Assignee;
        this.ExternalContact = ExternalContact;
        this.ExternalTag = ExternalTag;
        this.ModifiedBy = ModifiedBy;
        this.Queue = Queue;
        this.AssignmentState = AssignmentState;
        this.DateAssignmentStateChanged = DateAssignmentStateChanged;
        this.AlertTimeoutSeconds = AlertTimeoutSeconds;
        this.Skills = Skills;
        this.PreferredAgents = PreferredAgents;
        this.AutoStatusTransition = AutoStatusTransition;
        this.Schema = Schema;
        this.CustomFields = CustomFields;
        this.AutoStatusTransitionDetail = AutoStatusTransitionDetail;
        this.ScoredAgents = ScoredAgents;
        this.Script = Script;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the Workitem.
    /// </summary>
    /// <value>The name of the Workitem.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public Division Division { get; set; }



    /// <summary>
    /// The Worktype of the Workitem.
    /// </summary>
    /// <value>The Worktype of the Workitem.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public WorktypeReference Type { get; set; }



    /// <summary>
    /// The description of the Workitem.
    /// </summary>
    /// <value>The description of the Workitem.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The language of the Workitem.
    /// </summary>
    /// <value>The language of the Workitem.</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public LanguageReference Language { get; set; }



    /// <summary>
    /// The utilization label of the Workitem.
    /// </summary>
    /// <value>The utilization label of the Workitem.</value>
    [DataMember(Name = "utilizationLabel", EmitDefaultValue = false)]
    public WorkitemUtilizationLabelReference UtilizationLabel { get; set; }



    /// <summary>
    /// The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.
    /// </summary>
    /// <value>The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public int? Priority { get; set; }



    /// <summary>
    /// The creation date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The modified date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The modified date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The due date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The due date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateDue", EmitDefaultValue = false)]
    public DateTime? DateDue { get; set; }



    /// <summary>
    /// The expiry date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The expiry date of the Workitem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateExpires", EmitDefaultValue = false)]
    public DateTime? DateExpires { get; set; }



    /// <summary>
    /// The estimated duration in seconds to complete the workitem.
    /// </summary>
    /// <value>The estimated duration in seconds to complete the workitem.</value>
    [DataMember(Name = "durationSeconds", EmitDefaultValue = false)]
    public int? DurationSeconds { get; set; }



    /// <summary>
    /// The time to live of the Workitem in seconds.
    /// </summary>
    /// <value>The time to live of the Workitem in seconds.</value>
    [DataMember(Name = "ttl", EmitDefaultValue = false)]
    public int? Ttl { get; set; }



    /// <summary>
    /// The current Status of the Workitem.
    /// </summary>
    /// <value>The current Status of the Workitem.</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public WorkitemStatusReference Status { get; set; }





    /// <summary>
    /// The State change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The State change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateStatusChanged", EmitDefaultValue = false)]
    public DateTime? DateStatusChanged { get; set; }



    /// <summary>
    /// The date the Workitem was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the Workitem was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateClosed", EmitDefaultValue = false)]
    public DateTime? DateClosed { get; set; }



    /// <summary>
    /// The Workbin that contains the Workitem.
    /// </summary>
    /// <value>The Workbin that contains the Workitem.</value>
    [DataMember(Name = "workbin", EmitDefaultValue = false)]
    public WorkbinReference Workbin { get; set; }



    /// <summary>
    /// The reporter of the Workitem.
    /// </summary>
    /// <value>The reporter of the Workitem.</value>
    [DataMember(Name = "reporter", EmitDefaultValue = false)]
    public UserReferenceWithName Reporter { get; set; }



    /// <summary>
    /// The assignee of the Workitem.
    /// </summary>
    /// <value>The assignee of the Workitem.</value>
    [DataMember(Name = "assignee", EmitDefaultValue = false)]
    public UserReferenceWithName Assignee { get; set; }



    /// <summary>
    /// The external contact of the Workitem.
    /// </summary>
    /// <value>The external contact of the Workitem.</value>
    [DataMember(Name = "externalContact", EmitDefaultValue = false)]
    public ExternalContactReference ExternalContact { get; set; }



    /// <summary>
    /// The external tag of the Workitem.
    /// </summary>
    /// <value>The external tag of the Workitem.</value>
    [DataMember(Name = "externalTag", EmitDefaultValue = false)]
    public string ExternalTag { get; set; }



    /// <summary>
    /// The User who modified the Workitem.
    /// </summary>
    /// <value>The User who modified the Workitem.</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The Workitems queue.
    /// </summary>
    /// <value>The Workitems queue.</value>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public WorkitemQueueReference Queue { get; set; }





    /// <summary>
    /// The assignment state change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The assignment state change date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateAssignmentStateChanged", EmitDefaultValue = false)]
    public DateTime? DateAssignmentStateChanged { get; set; }



    /// <summary>
    /// The duration in seconds before an alert will timeout.
    /// </summary>
    /// <value>The duration in seconds before an alert will timeout.</value>
    [DataMember(Name = "alertTimeoutSeconds", EmitDefaultValue = false)]
    public int? AlertTimeoutSeconds { get; set; }



    /// <summary>
    /// The skills of the Workitem.
    /// </summary>
    /// <value>The skills of the Workitem.</value>
    [DataMember(Name = "skills", EmitDefaultValue = false)]
    public List<RoutingSkillReference> Skills { get; set; }



    /// <summary>
    /// The preferred agents of the Workitem.
    /// </summary>
    /// <value>The preferred agents of the Workitem.</value>
    [DataMember(Name = "preferredAgents", EmitDefaultValue = false)]
    public List<UserReference> PreferredAgents { get; set; }



    /// <summary>
    /// Set it to false to disable auto status transition. By default, it is enabled.
    /// </summary>
    /// <value>Set it to false to disable auto status transition. By default, it is enabled.</value>
    [DataMember(Name = "autoStatusTransition", EmitDefaultValue = false)]
    public bool? AutoStatusTransition { get; set; }



    /// <summary>
    /// The schema defining the custom fields of the Workitem. The schema is inherited from the Workitems Worktype at creation time.
    /// </summary>
    /// <value>The schema defining the custom fields of the Workitem. The schema is inherited from the Workitems Worktype at creation time.</value>
    [DataMember(Name = "schema", EmitDefaultValue = false)]
    public WorkitemSchema Schema { get; set; }



    /// <summary>
    /// Custom fields defined in the schema referenced by the Workitem.
    /// </summary>
    /// <value>Custom fields defined in the schema referenced by the Workitem.</value>
    [DataMember(Name = "customFields", EmitDefaultValue = false)]
    public Dictionary<string, object> CustomFields { get; set; }



    /// <summary>
    /// Auto status transition details of Workitem.
    /// </summary>
    /// <value>Auto status transition details of Workitem.</value>
    [DataMember(Name = "autoStatusTransitionDetail", EmitDefaultValue = false)]
    public AutoStatusTransitionDetail AutoStatusTransitionDetail { get; set; }



    /// <summary>
    /// A list of scored agents for the Workitem.
    /// </summary>
    /// <value>A list of scored agents for the Workitem.</value>
    [DataMember(Name = "scoredAgents", EmitDefaultValue = false)]
    public List<WorkitemScoredAgent> ScoredAgents { get; set; }



    /// <summary>
    /// The script that will be executed for the Workitem.
    /// </summary>
    /// <value>The script that will be executed for the Workitem.</value>
    [DataMember(Name = "script", EmitDefaultValue = false)]
    public WorkitemScriptReference Script { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Workitem {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  UtilizationLabel: ").Append(UtilizationLabel).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateDue: ").Append(DateDue).Append("\n");
        sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
        sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
        sb.Append("  Ttl: ").Append(Ttl).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  StatusCategory: ").Append(StatusCategory).Append("\n");
        sb.Append("  DateStatusChanged: ").Append(DateStatusChanged).Append("\n");
        sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
        sb.Append("  Workbin: ").Append(Workbin).Append("\n");
        sb.Append("  Reporter: ").Append(Reporter).Append("\n");
        sb.Append("  Assignee: ").Append(Assignee).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
        sb.Append("  DateAssignmentStateChanged: ").Append(DateAssignmentStateChanged).Append("\n");
        sb.Append("  AlertTimeoutSeconds: ").Append(AlertTimeoutSeconds).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
        sb.Append("  PreferredAgents: ").Append(PreferredAgents).Append("\n");
        sb.Append("  AutoStatusTransition: ").Append(AutoStatusTransition).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
        sb.Append("  AutoStatusTransitionDetail: ").Append(AutoStatusTransitionDetail).Append("\n");
        sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
        sb.Append("  Script: ").Append(Script).Append("\n");
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
        return Equals(obj as Workitem);
    }

    /// <summary>
    /// Returns true if Workitem instances are equal
    /// </summary>
    /// <param name="other">Instance of Workitem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Workitem other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                UtilizationLabel == other.UtilizationLabel ||
                UtilizationLabel != null &&
                UtilizationLabel.Equals(other.UtilizationLabel)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                StatusCategory == other.StatusCategory ||
                StatusCategory != null &&
                StatusCategory.Equals(other.StatusCategory)
            ) &&
            (
                DateStatusChanged == other.DateStatusChanged ||
                DateStatusChanged != null &&
                DateStatusChanged.Equals(other.DateStatusChanged)
            ) &&
            (
                DateClosed == other.DateClosed ||
                DateClosed != null &&
                DateClosed.Equals(other.DateClosed)
            ) &&
            (
                Workbin == other.Workbin ||
                Workbin != null &&
                Workbin.Equals(other.Workbin)
            ) &&
            (
                Reporter == other.Reporter ||
                Reporter != null &&
                Reporter.Equals(other.Reporter)
            ) &&
            (
                Assignee == other.Assignee ||
                Assignee != null &&
                Assignee.Equals(other.Assignee)
            ) &&
            (
                ExternalContact == other.ExternalContact ||
                ExternalContact != null &&
                ExternalContact.Equals(other.ExternalContact)
            ) &&
            (
                ExternalTag == other.ExternalTag ||
                ExternalTag != null &&
                ExternalTag.Equals(other.ExternalTag)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                AssignmentState == other.AssignmentState ||
                AssignmentState != null &&
                AssignmentState.Equals(other.AssignmentState)
            ) &&
            (
                DateAssignmentStateChanged == other.DateAssignmentStateChanged ||
                DateAssignmentStateChanged != null &&
                DateAssignmentStateChanged.Equals(other.DateAssignmentStateChanged)
            ) &&
            (
                AlertTimeoutSeconds == other.AlertTimeoutSeconds ||
                AlertTimeoutSeconds != null &&
                AlertTimeoutSeconds.Equals(other.AlertTimeoutSeconds)
            ) &&
            (
                Skills == other.Skills ||
                Skills != null &&
                Skills.SequenceEqual(other.Skills)
            ) &&
            (
                PreferredAgents == other.PreferredAgents ||
                PreferredAgents != null &&
                PreferredAgents.SequenceEqual(other.PreferredAgents)
            ) &&
            (
                AutoStatusTransition == other.AutoStatusTransition ||
                AutoStatusTransition != null &&
                AutoStatusTransition.Equals(other.AutoStatusTransition)
            ) &&
            (
                Schema == other.Schema ||
                Schema != null &&
                Schema.Equals(other.Schema)
            ) &&
            (
                CustomFields == other.CustomFields ||
                CustomFields != null &&
                CustomFields.SequenceEqual(other.CustomFields)
            ) &&
            (
                AutoStatusTransitionDetail == other.AutoStatusTransitionDetail ||
                AutoStatusTransitionDetail != null &&
                AutoStatusTransitionDetail.Equals(other.AutoStatusTransitionDetail)
            ) &&
            (
                ScoredAgents == other.ScoredAgents ||
                ScoredAgents != null &&
                ScoredAgents.SequenceEqual(other.ScoredAgents)
            ) &&
            (
                Script == other.Script ||
                Script != null &&
                Script.Equals(other.Script)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (UtilizationLabel != null)
            {
                hash = hash * 59 + UtilizationLabel.GetHashCode();
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

            if (DurationSeconds != null)
            {
                hash = hash * 59 + DurationSeconds.GetHashCode();
            }

            if (Ttl != null)
            {
                hash = hash * 59 + Ttl.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (StatusCategory != null)
            {
                hash = hash * 59 + StatusCategory.GetHashCode();
            }

            if (DateStatusChanged != null)
            {
                hash = hash * 59 + DateStatusChanged.GetHashCode();
            }

            if (DateClosed != null)
            {
                hash = hash * 59 + DateClosed.GetHashCode();
            }

            if (Workbin != null)
            {
                hash = hash * 59 + Workbin.GetHashCode();
            }

            if (Reporter != null)
            {
                hash = hash * 59 + Reporter.GetHashCode();
            }

            if (Assignee != null)
            {
                hash = hash * 59 + Assignee.GetHashCode();
            }

            if (ExternalContact != null)
            {
                hash = hash * 59 + ExternalContact.GetHashCode();
            }

            if (ExternalTag != null)
            {
                hash = hash * 59 + ExternalTag.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (AssignmentState != null)
            {
                hash = hash * 59 + AssignmentState.GetHashCode();
            }

            if (DateAssignmentStateChanged != null)
            {
                hash = hash * 59 + DateAssignmentStateChanged.GetHashCode();
            }

            if (AlertTimeoutSeconds != null)
            {
                hash = hash * 59 + AlertTimeoutSeconds.GetHashCode();
            }

            if (Skills != null)
            {
                hash = hash * 59 + Skills.GetHashCode();
            }

            if (PreferredAgents != null)
            {
                hash = hash * 59 + PreferredAgents.GetHashCode();
            }

            if (AutoStatusTransition != null)
            {
                hash = hash * 59 + AutoStatusTransition.GetHashCode();
            }

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (CustomFields != null)
            {
                hash = hash * 59 + CustomFields.GetHashCode();
            }

            if (AutoStatusTransitionDetail != null)
            {
                hash = hash * 59 + AutoStatusTransitionDetail.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            if (Script != null)
            {
                hash = hash * 59 + Script.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
