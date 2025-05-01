using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectFlowNotificationFlowNotification
/// </summary>
[DataContract]
public partial class ArchitectFlowNotificationFlowNotification : IEquatable<ArchitectFlowNotificationFlowNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectFlowNotificationFlowNotification" /> class.
    /// </summary>
    /// <param name="Id">The flow ID.</param>
    /// <param name="Name">The flow name.</param>
    /// <param name="Description">The flow description.</param>
    /// <param name="Deleted">The flow deleted state.</param>
    /// <param name="CheckedInVersion">CheckedInVersion.</param>
    /// <param name="SavedVersion">A bare-bones flow version object.</param>
    /// <param name="PublishedVersion">A bare-bones flow version object.</param>
    /// <param name="CurrentOperation">CurrentOperation.</param>
    public ArchitectFlowNotificationFlowNotification(string Id = null, string Name = null, string Description = null, bool? Deleted = null, ArchitectFlowNotificationFlowVersion CheckedInVersion = null, ArchitectFlowNotificationFlowVersion SavedVersion = null, ArchitectFlowNotificationFlowVersion PublishedVersion = null, ArchitectFlowNotificationArchitectOperation CurrentOperation = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Deleted = Deleted;
        this.CheckedInVersion = CheckedInVersion;
        this.SavedVersion = SavedVersion;
        this.PublishedVersion = PublishedVersion;
        this.CurrentOperation = CurrentOperation;

    }



    /// <summary>
    /// The flow ID
    /// </summary>
    /// <value>The flow ID</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The flow name
    /// </summary>
    /// <value>The flow name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The flow description
    /// </summary>
    /// <value>The flow description</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The flow deleted state
    /// </summary>
    /// <value>The flow deleted state</value>
    [DataMember(Name = "deleted", EmitDefaultValue = false)]
    public bool? Deleted { get; set; }



    /// <summary>
    /// Gets or Sets CheckedInVersion
    /// </summary>
    [DataMember(Name = "checkedInVersion", EmitDefaultValue = false)]
    public ArchitectFlowNotificationFlowVersion CheckedInVersion { get; set; }



    /// <summary>
    /// A bare-bones flow version object
    /// </summary>
    /// <value>A bare-bones flow version object</value>
    [DataMember(Name = "savedVersion", EmitDefaultValue = false)]
    public ArchitectFlowNotificationFlowVersion SavedVersion { get; set; }



    /// <summary>
    /// A bare-bones flow version object
    /// </summary>
    /// <value>A bare-bones flow version object</value>
    [DataMember(Name = "publishedVersion", EmitDefaultValue = false)]
    public ArchitectFlowNotificationFlowVersion PublishedVersion { get; set; }



    /// <summary>
    /// Gets or Sets CurrentOperation
    /// </summary>
    [DataMember(Name = "currentOperation", EmitDefaultValue = false)]
    public ArchitectFlowNotificationArchitectOperation CurrentOperation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectFlowNotificationFlowNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Deleted: ").Append(Deleted).Append("\n");
        sb.Append("  CheckedInVersion: ").Append(CheckedInVersion).Append("\n");
        sb.Append("  SavedVersion: ").Append(SavedVersion).Append("\n");
        sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
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
        return Equals(obj as ArchitectFlowNotificationFlowNotification);
    }

    /// <summary>
    /// Returns true if ArchitectFlowNotificationFlowNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectFlowNotificationFlowNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectFlowNotificationFlowNotification other)
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
                Deleted == other.Deleted ||
                Deleted != null &&
                Deleted.Equals(other.Deleted)
            ) &&
            (
                CheckedInVersion == other.CheckedInVersion ||
                CheckedInVersion != null &&
                CheckedInVersion.Equals(other.CheckedInVersion)
            ) &&
            (
                SavedVersion == other.SavedVersion ||
                SavedVersion != null &&
                SavedVersion.Equals(other.SavedVersion)
            ) &&
            (
                PublishedVersion == other.PublishedVersion ||
                PublishedVersion != null &&
                PublishedVersion.Equals(other.PublishedVersion)
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

            if (Deleted != null)
            {
                hash = hash * 59 + Deleted.GetHashCode();
            }

            if (CheckedInVersion != null)
            {
                hash = hash * 59 + CheckedInVersion.GetHashCode();
            }

            if (SavedVersion != null)
            {
                hash = hash * 59 + SavedVersion.GetHashCode();
            }

            if (PublishedVersion != null)
            {
                hash = hash * 59 + PublishedVersion.GetHashCode();
            }

            if (CurrentOperation != null)
            {
                hash = hash * 59 + CurrentOperation.GetHashCode();
            }

            return hash;
        }
    }
}
