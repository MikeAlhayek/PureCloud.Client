using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserStationChangeTopicUserStation
/// </summary>
[DataContract]
public partial class UserStationChangeTopicUserStation : IEquatable<UserStationChangeTopicUserStation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserStationChangeTopicUserStation" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="AssociatedUser">AssociatedUser.</param>
    public UserStationChangeTopicUserStation(string Id = null, string Name = null, UserStationChangeTopicUser AssociatedUser = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.AssociatedUser = AssociatedUser;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets AssociatedUser
    /// </summary>
    [DataMember(Name = "associatedUser", EmitDefaultValue = false)]
    public UserStationChangeTopicUser AssociatedUser { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserStationChangeTopicUserStation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  AssociatedUser: ").Append(AssociatedUser).Append("\n");
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
        return Equals(obj as UserStationChangeTopicUserStation);
    }

    /// <summary>
    /// Returns true if UserStationChangeTopicUserStation instances are equal
    /// </summary>
    /// <param name="other">Instance of UserStationChangeTopicUserStation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserStationChangeTopicUserStation other)
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
                AssociatedUser == other.AssociatedUser ||
                AssociatedUser != null &&
                AssociatedUser.Equals(other.AssociatedUser)
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

            if (AssociatedUser != null)
            {
                hash = hash * 59 + AssociatedUser.GetHashCode();
            }

            return hash;
        }
    }
}
