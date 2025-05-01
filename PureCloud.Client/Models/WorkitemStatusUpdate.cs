using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemStatusUpdate
/// </summary>
[DataContract]
public partial class WorkitemStatusUpdate : IEquatable<WorkitemStatusUpdate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemStatusUpdate" /> class.
    /// </summary>
    /// <param name="Name">The name of the Status. Valid length between 3 and 256 characters..</param>
    /// <param name="DestinationStatusIds">A list of destination Statuses where a Workitem with this Status can transition to. If the list is empty Workitems with this Status can transition to all other Statuses defined on the Worktype. A Status can have a maximum of 24 destinations..</param>
    /// <param name="Description">The description of the Status. Maximum length of 512 characters..</param>
    /// <param name="DefaultDestinationStatusId">Default destination status to which this Status will transition to if auto status transition enabled..</param>
    /// <param name="StatusTransitionDelaySeconds">Delay in seconds for auto status transition. Required if defaultDestinationStatusId is provided..</param>
    /// <param name="StatusTransitionTime">Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS.</param>
    /// <param name="AutoTerminateWorkitem">Terminate workitem on selection of status. Applicable only for statuses in the Closed category..</param>
    public WorkitemStatusUpdate(string Name = null, List<string> DestinationStatusIds = null, string Description = null, string DefaultDestinationStatusId = null, int? StatusTransitionDelaySeconds = null, string StatusTransitionTime = null, bool? AutoTerminateWorkitem = null)
    {
        this.Name = Name;
        this.DestinationStatusIds = DestinationStatusIds;
        this.Description = Description;
        this.DefaultDestinationStatusId = DefaultDestinationStatusId;
        this.StatusTransitionDelaySeconds = StatusTransitionDelaySeconds;
        this.StatusTransitionTime = StatusTransitionTime;
        this.AutoTerminateWorkitem = AutoTerminateWorkitem;

    }



    /// <summary>
    /// The name of the Status. Valid length between 3 and 256 characters.
    /// </summary>
    /// <value>The name of the Status. Valid length between 3 and 256 characters.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// A list of destination Statuses where a Workitem with this Status can transition to. If the list is empty Workitems with this Status can transition to all other Statuses defined on the Worktype. A Status can have a maximum of 24 destinations.
    /// </summary>
    /// <value>A list of destination Statuses where a Workitem with this Status can transition to. If the list is empty Workitems with this Status can transition to all other Statuses defined on the Worktype. A Status can have a maximum of 24 destinations.</value>
    [DataMember(Name = "destinationStatusIds", EmitDefaultValue = false)]
    public List<string> DestinationStatusIds { get; set; }



    /// <summary>
    /// The description of the Status. Maximum length of 512 characters.
    /// </summary>
    /// <value>The description of the Status. Maximum length of 512 characters.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Default destination status to which this Status will transition to if auto status transition enabled.
    /// </summary>
    /// <value>Default destination status to which this Status will transition to if auto status transition enabled.</value>
    [DataMember(Name = "defaultDestinationStatusId", EmitDefaultValue = false)]
    public string DefaultDestinationStatusId { get; set; }



    /// <summary>
    /// Delay in seconds for auto status transition. Required if defaultDestinationStatusId is provided.
    /// </summary>
    /// <value>Delay in seconds for auto status transition. Required if defaultDestinationStatusId is provided.</value>
    [DataMember(Name = "statusTransitionDelaySeconds", EmitDefaultValue = false)]
    public int? StatusTransitionDelaySeconds { get; set; }



    /// <summary>
    /// Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS
    /// </summary>
    /// <value>Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS</value>
    [DataMember(Name = "statusTransitionTime", EmitDefaultValue = false)]
    public string StatusTransitionTime { get; set; }



    /// <summary>
    /// Terminate workitem on selection of status. Applicable only for statuses in the Closed category.
    /// </summary>
    /// <value>Terminate workitem on selection of status. Applicable only for statuses in the Closed category.</value>
    [DataMember(Name = "autoTerminateWorkitem", EmitDefaultValue = false)]
    public bool? AutoTerminateWorkitem { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemStatusUpdate {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DestinationStatusIds: ").Append(DestinationStatusIds).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DefaultDestinationStatusId: ").Append(DefaultDestinationStatusId).Append("\n");
        sb.Append("  StatusTransitionDelaySeconds: ").Append(StatusTransitionDelaySeconds).Append("\n");
        sb.Append("  StatusTransitionTime: ").Append(StatusTransitionTime).Append("\n");
        sb.Append("  AutoTerminateWorkitem: ").Append(AutoTerminateWorkitem).Append("\n");
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
        return Equals(obj as WorkitemStatusUpdate);
    }

    /// <summary>
    /// Returns true if WorkitemStatusUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemStatusUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemStatusUpdate other)
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
                DestinationStatusIds == other.DestinationStatusIds ||
                DestinationStatusIds != null &&
                DestinationStatusIds.SequenceEqual(other.DestinationStatusIds)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DefaultDestinationStatusId == other.DefaultDestinationStatusId ||
                DefaultDestinationStatusId != null &&
                DefaultDestinationStatusId.Equals(other.DefaultDestinationStatusId)
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
                AutoTerminateWorkitem == other.AutoTerminateWorkitem ||
                AutoTerminateWorkitem != null &&
                AutoTerminateWorkitem.Equals(other.AutoTerminateWorkitem)
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

            if (DestinationStatusIds != null)
            {
                hash = hash * 59 + DestinationStatusIds.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DefaultDestinationStatusId != null)
            {
                hash = hash * 59 + DefaultDestinationStatusId.GetHashCode();
            }

            if (StatusTransitionDelaySeconds != null)
            {
                hash = hash * 59 + StatusTransitionDelaySeconds.GetHashCode();
            }

            if (StatusTransitionTime != null)
            {
                hash = hash * 59 + StatusTransitionTime.GetHashCode();
            }

            if (AutoTerminateWorkitem != null)
            {
                hash = hash * 59 + AutoTerminateWorkitem.GetHashCode();
            }

            return hash;
        }
    }
}
