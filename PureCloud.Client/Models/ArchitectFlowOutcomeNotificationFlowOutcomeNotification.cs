using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectFlowOutcomeNotificationFlowOutcomeNotification
/// </summary>

public partial class ArchitectFlowOutcomeNotificationFlowOutcomeNotification : IEquatable<ArchitectFlowOutcomeNotificationFlowOutcomeNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectFlowOutcomeNotificationFlowOutcomeNotification" /> class.
    /// </summary>
    /// <param name="Id">The flow outcome ID.</param>
    /// <param name="Name">The flow outcome name.</param>
    /// <param name="Description">The flow outcome description.</param>
    /// <param name="CurrentOperation">CurrentOperation.</param>
    public ArchitectFlowOutcomeNotificationFlowOutcomeNotification(string Id = null, string Name = null, string Description = null, ArchitectFlowOutcomeNotificationArchitectOperation CurrentOperation = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.CurrentOperation = CurrentOperation;

    }



    /// <summary>
    /// The flow outcome ID
    /// </summary>
    /// <value>The flow outcome ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The flow outcome name
    /// </summary>
    /// <value>The flow outcome name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The flow outcome description
    /// </summary>
    /// <value>The flow outcome description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets CurrentOperation
    /// </summary>
    [JsonPropertyName("currentOperation")]
    public ArchitectFlowOutcomeNotificationArchitectOperation CurrentOperation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectFlowOutcomeNotificationFlowOutcomeNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  CurrentOperation: ").Append(CurrentOperation).Append("\n");
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
        return Equals(obj as ArchitectFlowOutcomeNotificationFlowOutcomeNotification);
    }

    /// <summary>
    /// Returns true if ArchitectFlowOutcomeNotificationFlowOutcomeNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectFlowOutcomeNotificationFlowOutcomeNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectFlowOutcomeNotificationFlowOutcomeNotification other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                CurrentOperation == other.CurrentOperation ||
                CurrentOperation != null &&
                CurrentOperation.Equals(other.CurrentOperation)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (CurrentOperation != null)
            {
                hash = hash * 59 + CurrentOperation.GetHashCode();
            }

            return hash;
        }
    }
}
