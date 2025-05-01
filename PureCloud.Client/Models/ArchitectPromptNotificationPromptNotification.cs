using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectPromptNotificationPromptNotification
/// </summary>
[DataContract]
public partial class ArchitectPromptNotificationPromptNotification : IEquatable<ArchitectPromptNotificationPromptNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectPromptNotificationPromptNotification" /> class.
    /// </summary>
    /// <param name="Id">The prompt ID.</param>
    /// <param name="Name">The prompt name.</param>
    /// <param name="Description">The prompt description.</param>
    /// <param name="CurrentOperation">CurrentOperation.</param>
    public ArchitectPromptNotificationPromptNotification(string Id = null, string Name = null, string Description = null, ArchitectPromptNotificationArchitectOperation CurrentOperation = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.CurrentOperation = CurrentOperation;

    }



    /// <summary>
    /// The prompt ID
    /// </summary>
    /// <value>The prompt ID</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The prompt name
    /// </summary>
    /// <value>The prompt name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The prompt description
    /// </summary>
    /// <value>The prompt description</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets CurrentOperation
    /// </summary>
    [DataMember(Name = "currentOperation", EmitDefaultValue = false)]
    public ArchitectPromptNotificationArchitectOperation CurrentOperation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectPromptNotificationPromptNotification {\n");

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
        return Equals(obj as ArchitectPromptNotificationPromptNotification);
    }

    /// <summary>
    /// Returns true if ArchitectPromptNotificationPromptNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectPromptNotificationPromptNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectPromptNotificationPromptNotification other)
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
