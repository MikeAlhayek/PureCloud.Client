using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Worktype
/// </summary>
[DataContract]
public partial class Worktype : IEquatable<Worktype>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Worktype" /> class.
    /// </summary>
    /// <param name="Name">The name of the Worktype..</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The description of the Worktype..</param>
    /// <param name="DateCreated">The creation date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">The modified date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DefaultWorkbin">The default Workbin for Workitems created from the Worktype..</param>
    /// <param name="DefaultStatus">The default status for Workitems created from the Worktype..</param>
    /// <param name="Statuses">The list of possible statuses for Workitems created from the Worktype..</param>
    /// <param name="DefaultDurationSeconds">The default duration in seconds for Workitems created from the Worktype..</param>
    /// <param name="DefaultExpirationSeconds">The default expiration time in seconds for Workitems created from the Worktype..</param>
    /// <param name="DefaultDueDurationSeconds">The default due duration in seconds for Workitems created from the Worktype..</param>
    /// <param name="DefaultPriority">The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000..</param>
    /// <param name="DefaultLanguage">The default language for Workitems created from the Worktype..</param>
    /// <param name="DefaultTtlSeconds">The default time to time to live in seconds for Workitems created from the Worktype..</param>
    /// <param name="ModifiedBy">The id of the User who modified the Worktype..</param>
    /// <param name="DefaultQueue">The default queue for Workitems created from the Worktype..</param>
    /// <param name="DefaultSkills">The default skills for Workitems created from the Worktype..</param>
    /// <param name="AssignmentEnabled">When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false..</param>
    /// <param name="Schema">The schema defining the custom attributes for Workitems created from the Worktype..</param>
    /// <param name="ServiceLevelTarget">The target service level for Workitems created from the Worktype. The default value is 100..</param>
    /// <param name="RuleSettings">Settings for the worktypes rules..</param>
    /// <param name="Flow">The flow associated with the Worktype..</param>
    /// <param name="DefaultScript">The default script for Workitems created from the Worktype..</param>
    public Worktype(string Name = null, Division Division = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, WorkbinReference DefaultWorkbin = null, WorkitemStatusReference DefaultStatus = null, List<WorkitemStatus> Statuses = null, int? DefaultDurationSeconds = null, int? DefaultExpirationSeconds = null, int? DefaultDueDurationSeconds = null, int? DefaultPriority = null, LanguageReference DefaultLanguage = null, int? DefaultTtlSeconds = null, UserReference ModifiedBy = null, WorkitemQueueReference DefaultQueue = null, List<RoutingSkillReference> DefaultSkills = null, bool? AssignmentEnabled = null, WorkitemSchema Schema = null, int? ServiceLevelTarget = null, WorkitemRuleSettings RuleSettings = null, WorkitemFlowReference Flow = null, WorkitemScriptReference DefaultScript = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.DefaultWorkbin = DefaultWorkbin;
        this.DefaultStatus = DefaultStatus;
        this.Statuses = Statuses;
        this.DefaultDurationSeconds = DefaultDurationSeconds;
        this.DefaultExpirationSeconds = DefaultExpirationSeconds;
        this.DefaultDueDurationSeconds = DefaultDueDurationSeconds;
        this.DefaultPriority = DefaultPriority;
        this.DefaultLanguage = DefaultLanguage;
        this.DefaultTtlSeconds = DefaultTtlSeconds;
        this.ModifiedBy = ModifiedBy;
        this.DefaultQueue = DefaultQueue;
        this.DefaultSkills = DefaultSkills;
        this.AssignmentEnabled = AssignmentEnabled;
        this.Schema = Schema;
        this.ServiceLevelTarget = ServiceLevelTarget;
        this.RuleSettings = RuleSettings;
        this.Flow = Flow;
        this.DefaultScript = DefaultScript;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the Worktype.
    /// </summary>
    /// <value>The name of the Worktype.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public Division Division { get; set; }



    /// <summary>
    /// The description of the Worktype.
    /// </summary>
    /// <value>The description of the Worktype.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The creation date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The modified date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The modified date of the Worktype. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The default Workbin for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default Workbin for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultWorkbin", EmitDefaultValue = false)]
    public WorkbinReference DefaultWorkbin { get; set; }



    /// <summary>
    /// The default status for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default status for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultStatus", EmitDefaultValue = false)]
    public WorkitemStatusReference DefaultStatus { get; set; }



    /// <summary>
    /// The list of possible statuses for Workitems created from the Worktype.
    /// </summary>
    /// <value>The list of possible statuses for Workitems created from the Worktype.</value>
    [DataMember(Name = "statuses", EmitDefaultValue = false)]
    public List<WorkitemStatus> Statuses { get; set; }



    /// <summary>
    /// The default duration in seconds for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default duration in seconds for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultDurationSeconds", EmitDefaultValue = false)]
    public int? DefaultDurationSeconds { get; set; }



    /// <summary>
    /// The default expiration time in seconds for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default expiration time in seconds for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultExpirationSeconds", EmitDefaultValue = false)]
    public int? DefaultExpirationSeconds { get; set; }



    /// <summary>
    /// The default due duration in seconds for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default due duration in seconds for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultDueDurationSeconds", EmitDefaultValue = false)]
    public int? DefaultDueDurationSeconds { get; set; }



    /// <summary>
    /// The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000.
    /// </summary>
    /// <value>The default priority for Workitems created from the Worktype. The valid range is between -25,000,000 and 25,000,000.</value>
    [DataMember(Name = "defaultPriority", EmitDefaultValue = false)]
    public int? DefaultPriority { get; set; }



    /// <summary>
    /// The default language for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default language for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultLanguage", EmitDefaultValue = false)]
    public LanguageReference DefaultLanguage { get; set; }



    /// <summary>
    /// The default time to time to live in seconds for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default time to time to live in seconds for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultTtlSeconds", EmitDefaultValue = false)]
    public int? DefaultTtlSeconds { get; set; }



    /// <summary>
    /// The id of the User who modified the Worktype.
    /// </summary>
    /// <value>The id of the User who modified the Worktype.</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The default queue for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default queue for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultQueue", EmitDefaultValue = false)]
    public WorkitemQueueReference DefaultQueue { get; set; }



    /// <summary>
    /// The default skills for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default skills for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultSkills", EmitDefaultValue = false)]
    public List<RoutingSkillReference> DefaultSkills { get; set; }



    /// <summary>
    /// When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false.
    /// </summary>
    /// <value>When set to true, Workitems will be sent to the queue of the Worktype as they are created. Default value is false.</value>
    [DataMember(Name = "assignmentEnabled", EmitDefaultValue = false)]
    public bool? AssignmentEnabled { get; set; }



    /// <summary>
    /// The schema defining the custom attributes for Workitems created from the Worktype.
    /// </summary>
    /// <value>The schema defining the custom attributes for Workitems created from the Worktype.</value>
    [DataMember(Name = "schema", EmitDefaultValue = false)]
    public WorkitemSchema Schema { get; set; }



    /// <summary>
    /// The target service level for Workitems created from the Worktype. The default value is 100.
    /// </summary>
    /// <value>The target service level for Workitems created from the Worktype. The default value is 100.</value>
    [DataMember(Name = "serviceLevelTarget", EmitDefaultValue = false)]
    public int? ServiceLevelTarget { get; set; }



    /// <summary>
    /// Settings for the worktypes rules.
    /// </summary>
    /// <value>Settings for the worktypes rules.</value>
    [DataMember(Name = "ruleSettings", EmitDefaultValue = false)]
    public WorkitemRuleSettings RuleSettings { get; set; }



    /// <summary>
    /// The flow associated with the Worktype.
    /// </summary>
    /// <value>The flow associated with the Worktype.</value>
    [DataMember(Name = "flow", EmitDefaultValue = false)]
    public WorkitemFlowReference Flow { get; set; }



    /// <summary>
    /// The default script for Workitems created from the Worktype.
    /// </summary>
    /// <value>The default script for Workitems created from the Worktype.</value>
    [DataMember(Name = "defaultScript", EmitDefaultValue = false)]
    public WorkitemScriptReference DefaultScript { get; set; }



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
        sb.Append("class Worktype {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DefaultWorkbin: ").Append(DefaultWorkbin).Append("\n");
        sb.Append("  DefaultStatus: ").Append(DefaultStatus).Append("\n");
        sb.Append("  Statuses: ").Append(Statuses).Append("\n");
        sb.Append("  DefaultDurationSeconds: ").Append(DefaultDurationSeconds).Append("\n");
        sb.Append("  DefaultExpirationSeconds: ").Append(DefaultExpirationSeconds).Append("\n");
        sb.Append("  DefaultDueDurationSeconds: ").Append(DefaultDueDurationSeconds).Append("\n");
        sb.Append("  DefaultPriority: ").Append(DefaultPriority).Append("\n");
        sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
        sb.Append("  DefaultTtlSeconds: ").Append(DefaultTtlSeconds).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DefaultQueue: ").Append(DefaultQueue).Append("\n");
        sb.Append("  DefaultSkills: ").Append(DefaultSkills).Append("\n");
        sb.Append("  AssignmentEnabled: ").Append(AssignmentEnabled).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  ServiceLevelTarget: ").Append(ServiceLevelTarget).Append("\n");
        sb.Append("  RuleSettings: ").Append(RuleSettings).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  DefaultScript: ").Append(DefaultScript).Append("\n");
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
        return Equals(obj as Worktype);
    }

    /// <summary>
    /// Returns true if Worktype instances are equal
    /// </summary>
    /// <param name="other">Instance of Worktype to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Worktype other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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
                DefaultWorkbin == other.DefaultWorkbin ||
                DefaultWorkbin != null &&
                DefaultWorkbin.Equals(other.DefaultWorkbin)
            ) &&
            (
                DefaultStatus == other.DefaultStatus ||
                DefaultStatus != null &&
                DefaultStatus.Equals(other.DefaultStatus)
            ) &&
            (
                Statuses == other.Statuses ||
                Statuses != null &&
                Statuses.SequenceEqual(other.Statuses)
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
                DefaultLanguage == other.DefaultLanguage ||
                DefaultLanguage != null &&
                DefaultLanguage.Equals(other.DefaultLanguage)
            ) &&
            (
                DefaultTtlSeconds == other.DefaultTtlSeconds ||
                DefaultTtlSeconds != null &&
                DefaultTtlSeconds.Equals(other.DefaultTtlSeconds)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DefaultQueue == other.DefaultQueue ||
                DefaultQueue != null &&
                DefaultQueue.Equals(other.DefaultQueue)
            ) &&
            (
                DefaultSkills == other.DefaultSkills ||
                DefaultSkills != null &&
                DefaultSkills.SequenceEqual(other.DefaultSkills)
            ) &&
            (
                AssignmentEnabled == other.AssignmentEnabled ||
                AssignmentEnabled != null &&
                AssignmentEnabled.Equals(other.AssignmentEnabled)
            ) &&
            (
                Schema == other.Schema ||
                Schema != null &&
                Schema.Equals(other.Schema)
            ) &&
            (
                ServiceLevelTarget == other.ServiceLevelTarget ||
                ServiceLevelTarget != null &&
                ServiceLevelTarget.Equals(other.ServiceLevelTarget)
            ) &&
            (
                RuleSettings == other.RuleSettings ||
                RuleSettings != null &&
                RuleSettings.Equals(other.RuleSettings)
            ) &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                DefaultScript == other.DefaultScript ||
                DefaultScript != null &&
                DefaultScript.Equals(other.DefaultScript)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DefaultWorkbin != null)
            {
                hash = hash * 59 + DefaultWorkbin.GetHashCode();
            }

            if (DefaultStatus != null)
            {
                hash = hash * 59 + DefaultStatus.GetHashCode();
            }

            if (Statuses != null)
            {
                hash = hash * 59 + Statuses.GetHashCode();
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

            if (DefaultLanguage != null)
            {
                hash = hash * 59 + DefaultLanguage.GetHashCode();
            }

            if (DefaultTtlSeconds != null)
            {
                hash = hash * 59 + DefaultTtlSeconds.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DefaultQueue != null)
            {
                hash = hash * 59 + DefaultQueue.GetHashCode();
            }

            if (DefaultSkills != null)
            {
                hash = hash * 59 + DefaultSkills.GetHashCode();
            }

            if (AssignmentEnabled != null)
            {
                hash = hash * 59 + AssignmentEnabled.GetHashCode();
            }

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (ServiceLevelTarget != null)
            {
                hash = hash * 59 + ServiceLevelTarget.GetHashCode();
            }

            if (RuleSettings != null)
            {
                hash = hash * 59 + RuleSettings.GetHashCode();
            }

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (DefaultScript != null)
            {
                hash = hash * 59 + DefaultScript.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
