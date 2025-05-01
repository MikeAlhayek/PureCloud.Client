using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActivityPlanListItem
/// </summary>
[DataContract]
public partial class ActivityPlanListItem : IEquatable<ActivityPlanListItem>
{
    /// <summary>
    /// The type of the activity plan
    /// </summary>
    /// <value>The type of the activity plan</value>
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
        /// Enum Individual for "Individual"
        /// </summary>
        [EnumMember(Value = "Individual")]
        Individual,

        /// <summary>
        /// Enum Group for "Group"
        /// </summary>
        [EnumMember(Value = "Group")]
        Group
    }
    /// <summary>
    /// The optimization objective of this activity plan
    /// </summary>
    /// <value>The optimization objective of this activity plan</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OptimizationObjectiveEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Favorservicegoals for "FavorServiceGoals"
        /// </summary>
        [EnumMember(Value = "FavorServiceGoals")]
        Favorservicegoals,

        /// <summary>
        /// Enum Favorschedulingall for "FavorSchedulingAll"
        /// </summary>
        [EnumMember(Value = "FavorSchedulingAll")]
        Favorschedulingall
    }
    /// <summary>
    /// The state of this activity plan
    /// </summary>
    /// <value>The state of this activity plan</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive
    }
    /// <summary>
    /// The type of the activity plan
    /// </summary>
    /// <value>The type of the activity plan</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The optimization objective of this activity plan
    /// </summary>
    /// <value>The optimization objective of this activity plan</value>
    [DataMember(Name = "optimizationObjective", EmitDefaultValue = false)]
    public OptimizationObjectiveEnum? OptimizationObjective { get; set; }
    /// <summary>
    /// The state of this activity plan
    /// </summary>
    /// <value>The state of this activity plan</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityPlanListItem" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ActivityPlanListItem() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityPlanListItem" /> class.
    /// </summary>
    /// <param name="Name">The name of the activity plan (required).</param>
    /// <param name="ManagementUnits">The management units to which this activity plan applies. Empty list or null means this activity plan applies to all management units in the business unit.</param>
    /// <param name="Description">The description of this activity plan (required).</param>
    /// <param name="ActivityCode">The activity code to which this activity plan applies. Note: It is recommended to load and cache the entire list of activity codes rather than look up individual codes (required).</param>
    /// <param name="Type">The type of the activity plan (required).</param>
    /// <param name="OptimizationObjective">The optimization objective of this activity plan (required).</param>
    /// <param name="RecurrenceSettings">Recurrence settings for this activity plan.</param>
    /// <param name="State">The state of this activity plan (required).</param>
    /// <param name="LastRunDate">The date the activity plan was last run, in ISO-8601 format.</param>
    /// <param name="LastRunBy">The last user to run this activity plan.</param>
    /// <param name="CreatedDate">The date the activity plan was created, in ISO-8601 format (required).</param>
    /// <param name="CreatedBy">The user who created this activity plan (required).</param>
    /// <param name="ModifiedDate">The date the activity plan was modified, in ISO-8601 format (required).</param>
    /// <param name="ModifiedBy">The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process (required).</param>
    public ActivityPlanListItem(string Name = null, List<ManagementUnitReference> ManagementUnits = null, string Description = null, ActivityCodeReference ActivityCode = null, TypeEnum? Type = null, OptimizationObjectiveEnum? OptimizationObjective = null, RecurrenceSettings RecurrenceSettings = null, StateEnum? State = null, DateTime? LastRunDate = null, UserReference LastRunBy = null, DateTime? CreatedDate = null, UserReference CreatedBy = null, DateTime? ModifiedDate = null, UserReference ModifiedBy = null)
    {
        this.Name = Name;
        this.ManagementUnits = ManagementUnits;
        this.Description = Description;
        this.ActivityCode = ActivityCode;
        this.Type = Type;
        this.OptimizationObjective = OptimizationObjective;
        this.RecurrenceSettings = RecurrenceSettings;
        this.State = State;
        this.LastRunDate = LastRunDate;
        this.LastRunBy = LastRunBy;
        this.CreatedDate = CreatedDate;
        this.CreatedBy = CreatedBy;
        this.ModifiedDate = ModifiedDate;
        this.ModifiedBy = ModifiedBy;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the activity plan
    /// </summary>
    /// <value>The name of the activity plan</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The management units to which this activity plan applies. Empty list or null means this activity plan applies to all management units in the business unit
    /// </summary>
    /// <value>The management units to which this activity plan applies. Empty list or null means this activity plan applies to all management units in the business unit</value>
    [DataMember(Name = "managementUnits", EmitDefaultValue = false)]
    public List<ManagementUnitReference> ManagementUnits { get; set; }



    /// <summary>
    /// The description of this activity plan
    /// </summary>
    /// <value>The description of this activity plan</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The activity code to which this activity plan applies. Note: It is recommended to load and cache the entire list of activity codes rather than look up individual codes
    /// </summary>
    /// <value>The activity code to which this activity plan applies. Note: It is recommended to load and cache the entire list of activity codes rather than look up individual codes</value>
    [DataMember(Name = "activityCode", EmitDefaultValue = false)]
    public ActivityCodeReference ActivityCode { get; set; }







    /// <summary>
    /// Recurrence settings for this activity plan
    /// </summary>
    /// <value>Recurrence settings for this activity plan</value>
    [DataMember(Name = "recurrenceSettings", EmitDefaultValue = false)]
    public RecurrenceSettings RecurrenceSettings { get; set; }





    /// <summary>
    /// The date the activity plan was last run, in ISO-8601 format
    /// </summary>
    /// <value>The date the activity plan was last run, in ISO-8601 format</value>
    [DataMember(Name = "lastRunDate", EmitDefaultValue = false)]
    public DateTime? LastRunDate { get; set; }



    /// <summary>
    /// The last user to run this activity plan
    /// </summary>
    /// <value>The last user to run this activity plan</value>
    [DataMember(Name = "lastRunBy", EmitDefaultValue = false)]
    public UserReference LastRunBy { get; set; }



    /// <summary>
    /// The date the activity plan was created, in ISO-8601 format
    /// </summary>
    /// <value>The date the activity plan was created, in ISO-8601 format</value>
    [DataMember(Name = "createdDate", EmitDefaultValue = false)]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// The user who created this activity plan
    /// </summary>
    /// <value>The user who created this activity plan</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The date the activity plan was modified, in ISO-8601 format
    /// </summary>
    /// <value>The date the activity plan was modified, in ISO-8601 format</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The last user to modify this activity plan. The id may be &#39;System&#39; if it was an automated process</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public UserReference ModifiedBy { get; set; }



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
        sb.Append("class ActivityPlanListItem {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ManagementUnits: ").Append(ManagementUnits).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  OptimizationObjective: ").Append(OptimizationObjective).Append("\n");
        sb.Append("  RecurrenceSettings: ").Append(RecurrenceSettings).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  LastRunDate: ").Append(LastRunDate).Append("\n");
        sb.Append("  LastRunBy: ").Append(LastRunBy).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
        return Equals(obj as ActivityPlanListItem);
    }

    /// <summary>
    /// Returns true if ActivityPlanListItem instances are equal
    /// </summary>
    /// <param name="other">Instance of ActivityPlanListItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActivityPlanListItem other)
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
                ManagementUnits == other.ManagementUnits ||
                ManagementUnits != null &&
                ManagementUnits.SequenceEqual(other.ManagementUnits)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ActivityCode == other.ActivityCode ||
                ActivityCode != null &&
                ActivityCode.Equals(other.ActivityCode)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                OptimizationObjective == other.OptimizationObjective ||
                OptimizationObjective != null &&
                OptimizationObjective.Equals(other.OptimizationObjective)
            ) &&
            (
                RecurrenceSettings == other.RecurrenceSettings ||
                RecurrenceSettings != null &&
                RecurrenceSettings.Equals(other.RecurrenceSettings)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                LastRunDate == other.LastRunDate ||
                LastRunDate != null &&
                LastRunDate.Equals(other.LastRunDate)
            ) &&
            (
                LastRunBy == other.LastRunBy ||
                LastRunBy != null &&
                LastRunBy.Equals(other.LastRunBy)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
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

            if (ManagementUnits != null)
            {
                hash = hash * 59 + ManagementUnits.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ActivityCode != null)
            {
                hash = hash * 59 + ActivityCode.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (OptimizationObjective != null)
            {
                hash = hash * 59 + OptimizationObjective.GetHashCode();
            }

            if (RecurrenceSettings != null)
            {
                hash = hash * 59 + RecurrenceSettings.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (LastRunDate != null)
            {
                hash = hash * 59 + LastRunDate.GetHashCode();
            }

            if (LastRunBy != null)
            {
                hash = hash * 59 + LastRunBy.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
