using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Development Activity object
/// </summary>
[DataContract]
public partial class DevelopmentActivity : IEquatable<DevelopmentActivity>
{
    /// <summary>
    /// Module archive type
    /// </summary>
    /// <value>Module archive type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ArchivalModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Graceful for "Graceful"
        /// </summary>
        [EnumMember(Value = "Graceful")]
        Graceful,

        /// <summary>
        /// Enum Immediate for "Immediate"
        /// </summary>
        [EnumMember(Value = "Immediate")]
        Immediate
    }
    /// <summary>
    /// The type of activity
    /// </summary>
    /// <value>The type of activity</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Informational for "Informational"
        /// </summary>
        [EnumMember(Value = "Informational")]
        Informational,

        /// <summary>
        /// Enum Coaching for "Coaching"
        /// </summary>
        [EnumMember(Value = "Coaching")]
        Coaching,

        /// <summary>
        /// Enum Assessedcontent for "AssessedContent"
        /// </summary>
        [EnumMember(Value = "AssessedContent")]
        Assessedcontent,

        /// <summary>
        /// Enum Assessment for "Assessment"
        /// </summary>
        [EnumMember(Value = "Assessment")]
        Assessment,

        /// <summary>
        /// Enum External for "External"
        /// </summary>
        [EnumMember(Value = "External")]
        External,

        /// <summary>
        /// Enum Native for "Native"
        /// </summary>
        [EnumMember(Value = "Native")]
        Native
    }
    /// <summary>
    /// The status of the activity
    /// </summary>
    /// <value>The status of the activity</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Planned for "Planned"
        /// </summary>
        [EnumMember(Value = "Planned")]
        Planned,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Invalidschedule for "InvalidSchedule"
        /// </summary>
        [EnumMember(Value = "InvalidSchedule")]
        Invalidschedule,

        /// <summary>
        /// Enum Notcompleted for "NotCompleted"
        /// </summary>
        [EnumMember(Value = "NotCompleted")]
        Notcompleted
    }
    /// <summary>
    /// Module archive type
    /// </summary>
    /// <value>Module archive type</value>
    [DataMember(Name = "archivalMode", EmitDefaultValue = false)]
    public ArchivalModeEnum? ArchivalMode { get; set; }
    /// <summary>
    /// The type of activity
    /// </summary>
    /// <value>The type of activity</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The status of the activity
    /// </summary>
    /// <value>The status of the activity</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DevelopmentActivity" /> class.
    /// </summary>
    /// <param name="IsLatest">True if this is the latest version of assignment assigned to the user.</param>
    /// <param name="IsModuleArchived">True if the associated module is archived.</param>
    /// <param name="ArchivalMode">Module archive type.</param>
    /// <param name="Name">The name of the activity.</param>
    /// <param name="Type">The type of activity.</param>
    /// <param name="Status">The status of the activity.</param>
    /// <param name="DateDue">Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Facilitator">Facilitator of the activity.</param>
    /// <param name="Attendees">List of users attending the activity.</param>
    /// <param name="IsOverdue">Indicates if the activity is overdue.</param>
    public DevelopmentActivity(bool? IsLatest = null, bool? IsModuleArchived = null, ArchivalModeEnum? ArchivalMode = null, string Name = null, TypeEnum? Type = null, StatusEnum? Status = null, DateTime? DateDue = null, UserReference Facilitator = null, List<UserReference> Attendees = null, bool? IsOverdue = null)
    {
        this.IsLatest = IsLatest;
        this.IsModuleArchived = IsModuleArchived;
        this.ArchivalMode = ArchivalMode;
        this.Name = Name;
        this.Type = Type;
        this.Status = Status;
        this.DateDue = DateDue;
        this.Facilitator = Facilitator;
        this.Attendees = Attendees;
        this.IsOverdue = IsOverdue;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Date that activity was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date that activity was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCompleted", EmitDefaultValue = false)]
    public DateTime? DateCompleted { get; private set; }



    /// <summary>
    /// User that created activity
    /// </summary>
    /// <value>User that created activity</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public UserReference CreatedBy { get; private set; }



    /// <summary>
    /// Date activity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date activity was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The user&#39;s percentage score for this activity
    /// </summary>
    /// <value>The user&#39;s percentage score for this activity</value>
    [DataMember(Name = "percentageScore", EmitDefaultValue = false)]
    public float? PercentageScore { get; private set; }



    /// <summary>
    /// True if the activity was passed
    /// </summary>
    /// <value>True if the activity was passed</value>
    [DataMember(Name = "isPassed", EmitDefaultValue = false)]
    public bool? IsPassed { get; private set; }



    /// <summary>
    /// True if this is the latest version of assignment assigned to the user
    /// </summary>
    /// <value>True if this is the latest version of assignment assigned to the user</value>
    [DataMember(Name = "isLatest", EmitDefaultValue = false)]
    public bool? IsLatest { get; set; }



    /// <summary>
    /// True if the associated module is archived
    /// </summary>
    /// <value>True if the associated module is archived</value>
    [DataMember(Name = "isModuleArchived", EmitDefaultValue = false)]
    public bool? IsModuleArchived { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }



    /// <summary>
    /// The name of the activity
    /// </summary>
    /// <value>The name of the activity</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }







    /// <summary>
    /// Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Due date for completion of the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateDue", EmitDefaultValue = false)]
    public DateTime? DateDue { get; set; }



    /// <summary>
    /// Facilitator of the activity
    /// </summary>
    /// <value>Facilitator of the activity</value>
    [DataMember(Name = "facilitator", EmitDefaultValue = false)]
    public UserReference Facilitator { get; set; }



    /// <summary>
    /// List of users attending the activity
    /// </summary>
    /// <value>List of users attending the activity</value>
    [DataMember(Name = "attendees", EmitDefaultValue = false)]
    public List<UserReference> Attendees { get; set; }



    /// <summary>
    /// Indicates if the activity is overdue
    /// </summary>
    /// <value>Indicates if the activity is overdue</value>
    [DataMember(Name = "isOverdue", EmitDefaultValue = false)]
    public bool? IsOverdue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DevelopmentActivity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
        sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
        sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
        sb.Append("  IsModuleArchived: ").Append(IsModuleArchived).Append("\n");
        sb.Append("  ArchivalMode: ").Append(ArchivalMode).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DateDue: ").Append(DateDue).Append("\n");
        sb.Append("  Facilitator: ").Append(Facilitator).Append("\n");
        sb.Append("  Attendees: ").Append(Attendees).Append("\n");
        sb.Append("  IsOverdue: ").Append(IsOverdue).Append("\n");
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
        return Equals(obj as DevelopmentActivity);
    }

    /// <summary>
    /// Returns true if DevelopmentActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of DevelopmentActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DevelopmentActivity other)
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
                DateCompleted == other.DateCompleted ||
                DateCompleted != null &&
                DateCompleted.Equals(other.DateCompleted)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                PercentageScore == other.PercentageScore ||
                PercentageScore != null &&
                PercentageScore.Equals(other.PercentageScore)
            ) &&
            (
                IsPassed == other.IsPassed ||
                IsPassed != null &&
                IsPassed.Equals(other.IsPassed)
            ) &&
            (
                IsLatest == other.IsLatest ||
                IsLatest != null &&
                IsLatest.Equals(other.IsLatest)
            ) &&
            (
                IsModuleArchived == other.IsModuleArchived ||
                IsModuleArchived != null &&
                IsModuleArchived.Equals(other.IsModuleArchived)
            ) &&
            (
                ArchivalMode == other.ArchivalMode ||
                ArchivalMode != null &&
                ArchivalMode.Equals(other.ArchivalMode)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                DateDue == other.DateDue ||
                DateDue != null &&
                DateDue.Equals(other.DateDue)
            ) &&
            (
                Facilitator == other.Facilitator ||
                Facilitator != null &&
                Facilitator.Equals(other.Facilitator)
            ) &&
            (
                Attendees == other.Attendees ||
                Attendees != null &&
                Attendees.SequenceEqual(other.Attendees)
            ) &&
            (
                IsOverdue == other.IsOverdue ||
                IsOverdue != null &&
                IsOverdue.Equals(other.IsOverdue)
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

            if (DateCompleted != null)
            {
                hash = hash * 59 + DateCompleted.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (PercentageScore != null)
            {
                hash = hash * 59 + PercentageScore.GetHashCode();
            }

            if (IsPassed != null)
            {
                hash = hash * 59 + IsPassed.GetHashCode();
            }

            if (IsLatest != null)
            {
                hash = hash * 59 + IsLatest.GetHashCode();
            }

            if (IsModuleArchived != null)
            {
                hash = hash * 59 + IsModuleArchived.GetHashCode();
            }

            if (ArchivalMode != null)
            {
                hash = hash * 59 + ArchivalMode.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (DateDue != null)
            {
                hash = hash * 59 + DateDue.GetHashCode();
            }

            if (Facilitator != null)
            {
                hash = hash * 59 + Facilitator.GetHashCode();
            }

            if (Attendees != null)
            {
                hash = hash * 59 + Attendees.GetHashCode();
            }

            if (IsOverdue != null)
            {
                hash = hash * 59 + IsOverdue.GetHashCode();
            }

            return hash;
        }
    }
}
