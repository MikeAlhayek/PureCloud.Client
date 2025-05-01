using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The client who initiated the change.
/// </summary>
[DataContract]
public partial class ArchitectPromptNotificationClient : IEquatable<ArchitectPromptNotificationClient>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectPromptNotificationClient" /> class.
    /// </summary>
    /// <param name="Id">The ID of the client..</param>
    /// <param name="Name">The name of the client, if available..</param>
    public ArchitectPromptNotificationClient(string Id = null, string Name = null)
    {
        this.Id = Id;
        this.Name = Name;

    }



    /// <summary>
    /// The ID of the client.
    /// </summary>
    /// <value>The ID of the client.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The name of the client, if available.
    /// </summary>
    /// <value>The name of the client, if available.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectPromptNotificationClient {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return this.Equals(obj as ArchitectPromptNotificationClient);
    }

    /// <summary>
    /// Returns true if ArchitectPromptNotificationClient instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectPromptNotificationClient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectPromptNotificationClient other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            return hash;
        }
    }
}
