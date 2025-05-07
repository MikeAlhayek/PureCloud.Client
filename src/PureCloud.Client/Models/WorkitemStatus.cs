using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemStatus
/// </summary>

public partial class WorkitemStatus : IEquatable<WorkitemStatus>
{
    /// <summary>
    /// The Category of the Status.
    /// </summary>
    /// <value>The Category of the Status.</value>
    
    public enum CategoryEnum
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
    /// The Category of the Status.
    /// </summary>
    /// <value>The Category of the Status.</value>
    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemStatus" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Category">The Category of the Status..</param>
    /// <param name="DestinationStatuses">The Statuses the Status can transition to..</param>
    /// <param name="Description">The description of the Status..</param>
    /// <param name="DefaultDestinationStatus">Default destination status to which this Status will transition to if auto status transition enabled..</param>
    /// <param name="StatusTransitionDelaySeconds">Delay in seconds for auto status transition.</param>
    /// <param name="StatusTransitionTime">Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS.</param>
    /// <param name="Worktype">The Worktype containing the Status..</param>
    /// <param name="AutoTerminateWorkitem">Terminate workitem on selection of status. Applicable only for statuses in the Closed category..</param>
    public WorkitemStatus(string Name = null, CategoryEnum? Category = null, List<WorkitemStatusReference> DestinationStatuses = null, string Description = null, WorkitemStatusReference DefaultDestinationStatus = null, int? StatusTransitionDelaySeconds = null, string StatusTransitionTime = null, WorktypeReference Worktype = null, bool? AutoTerminateWorkitem = null)
    {
        this.Name = Name;
        this.Category = Category;
        this.DestinationStatuses = DestinationStatuses;
        this.Description = Description;
        this.DefaultDestinationStatus = DefaultDestinationStatus;
        this.StatusTransitionDelaySeconds = StatusTransitionDelaySeconds;
        this.StatusTransitionTime = StatusTransitionTime;
        this.Worktype = Worktype;
        this.AutoTerminateWorkitem = AutoTerminateWorkitem;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// The Statuses the Status can transition to.
    /// </summary>
    /// <value>The Statuses the Status can transition to.</value>
    [JsonPropertyName("destinationStatuses")]
    public List<WorkitemStatusReference> DestinationStatuses { get; set; }



    /// <summary>
    /// The description of the Status.
    /// </summary>
    /// <value>The description of the Status.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Default destination status to which this Status will transition to if auto status transition enabled.
    /// </summary>
    /// <value>Default destination status to which this Status will transition to if auto status transition enabled.</value>
    [JsonPropertyName("defaultDestinationStatus")]
    public WorkitemStatusReference DefaultDestinationStatus { get; set; }



    /// <summary>
    /// Delay in seconds for auto status transition
    /// </summary>
    /// <value>Delay in seconds for auto status transition</value>
    [JsonPropertyName("statusTransitionDelaySeconds")]
    public int? StatusTransitionDelaySeconds { get; set; }



    /// <summary>
    /// Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS
    /// </summary>
    /// <value>Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS</value>
    [JsonPropertyName("statusTransitionTime")]
    public string StatusTransitionTime { get; set; }



    /// <summary>
    /// The Worktype containing the Status.
    /// </summary>
    /// <value>The Worktype containing the Status.</value>
    [JsonPropertyName("worktype")]
    public WorktypeReference Worktype { get; set; }



    /// <summary>
    /// Terminate workitem on selection of status. Applicable only for statuses in the Closed category.
    /// </summary>
    /// <value>Terminate workitem on selection of status. Applicable only for statuses in the Closed category.</value>
    [JsonPropertyName("autoTerminateWorkitem")]
    public bool? AutoTerminateWorkitem { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemStatus {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  DestinationStatuses: ").Append(DestinationStatuses).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DefaultDestinationStatus: ").Append(DefaultDestinationStatus).Append("\n");
        sb.Append("  StatusTransitionDelaySeconds: ").Append(StatusTransitionDelaySeconds).Append("\n");
        sb.Append("  StatusTransitionTime: ").Append(StatusTransitionTime).Append("\n");
        sb.Append("  Worktype: ").Append(Worktype).Append("\n");
        sb.Append("  AutoTerminateWorkitem: ").Append(AutoTerminateWorkitem).Append("\n");
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
        return Equals(obj as WorkitemStatus);
    }

    /// <summary>
    /// Returns true if WorkitemStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemStatus other)
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
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                DestinationStatuses == other.DestinationStatuses ||
                DestinationStatuses != null &&
                DestinationStatuses.SequenceEqual(other.DestinationStatuses)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DefaultDestinationStatus == other.DefaultDestinationStatus ||
                DefaultDestinationStatus != null &&
                DefaultDestinationStatus.Equals(other.DefaultDestinationStatus)
            ) &&
            (
                StatusTransitionDelaySeconds == other.StatusTransitionDelaySeconds ||
                StatusTransitionDelaySeconds != null &&
                StatusTransitionDelaySeconds.Equals(other.StatusTransitionDelaySeconds)
            ) &&
            (
                StatusTransitionTime == other.StatusTransitionTime ||
                StatusTransitionTime != null &&
                StatusTransitionTime.Equals(other.StatusTransitionTime)
            ) &&
            (
                Worktype == other.Worktype ||
                Worktype != null &&
                Worktype.Equals(other.Worktype)
            ) &&
            (
                AutoTerminateWorkitem == other.AutoTerminateWorkitem ||
                AutoTerminateWorkitem != null &&
                AutoTerminateWorkitem.Equals(other.AutoTerminateWorkitem)
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

            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (DestinationStatuses != null)
            {
                hash = hash * 59 + DestinationStatuses.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DefaultDestinationStatus != null)
            {
                hash = hash * 59 + DefaultDestinationStatus.GetHashCode();
            }

            if (StatusTransitionDelaySeconds != null)
            {
                hash = hash * 59 + StatusTransitionDelaySeconds.GetHashCode();
            }

            if (StatusTransitionTime != null)
            {
                hash = hash * 59 + StatusTransitionTime.GetHashCode();
            }

            if (Worktype != null)
            {
                hash = hash * 59 + Worktype.GetHashCode();
            }

            if (AutoTerminateWorkitem != null)
            {
                hash = hash * 59 + AutoTerminateWorkitem.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
