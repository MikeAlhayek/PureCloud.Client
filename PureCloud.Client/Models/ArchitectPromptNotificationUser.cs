using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// The user who initiated the change.
/// </summary>
[DataContract]
public partial class ArchitectPromptNotificationUser : IEquatable<ArchitectPromptNotificationUser>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectPromptNotificationUser" /> class.
    /// </summary>
    /// <param name="Id">The ID of the user..</param>
    /// <param name="Name">The name of the user, if available..</param>
    /// <param name="HomeOrg">HomeOrg.</param>
    public ArchitectPromptNotificationUser(string Id = null, string Name = null, ArchitectPromptNotificationHomeOrganization HomeOrg = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.HomeOrg = HomeOrg;

    }



    /// <summary>
    /// The ID of the user.
    /// </summary>
    /// <value>The ID of the user.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The name of the user, if available.
    /// </summary>
    /// <value>The name of the user, if available.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets HomeOrg
    /// </summary>
    [DataMember(Name = "homeOrg", EmitDefaultValue = false)]
    public ArchitectPromptNotificationHomeOrganization HomeOrg { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectPromptNotificationUser {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  HomeOrg: ").Append(HomeOrg).Append("\n");
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
        return Equals(obj as ArchitectPromptNotificationUser);
    }

    /// <summary>
    /// Returns true if ArchitectPromptNotificationUser instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectPromptNotificationUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectPromptNotificationUser other)
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
                HomeOrg == other.HomeOrg ||
                HomeOrg != null &&
                HomeOrg.Equals(other.HomeOrg)
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

            if (HomeOrg != null)
            {
                hash = hash * 59 + HomeOrg.GetHashCode();
            }

            return hash;
        }
    }
}
