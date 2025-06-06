using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatMessageUser
/// </summary>

public partial class ChatMessageUser : IEquatable<ChatMessageUser>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatMessageUser" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="DisplayName">DisplayName.</param>
    /// <param name="Username">Username.</param>
    /// <param name="Images">Images.</param>
    public ChatMessageUser(string Id = null, string Name = null, string DisplayName = null, string Username = null, List<Image> Images = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.DisplayName = DisplayName;
        this.Username = Username;
        this.Images = Images;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }



    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }



    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    [JsonPropertyName("images")]
    public List<Image> Images { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatMessageUser {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
        sb.Append("  Images: ").Append(Images).Append("\n");
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
        return Equals(obj as ChatMessageUser);
    }

    /// <summary>
    /// Returns true if ChatMessageUser instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatMessageUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatMessageUser other)
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
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                Username == other.Username ||
                Username != null &&
                Username.Equals(other.Username)
            ) &&
            (
                Images == other.Images ||
                Images != null &&
                Images.SequenceEqual(other.Images)
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

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (Username != null)
            {
                hash = hash * 59 + Username.GetHashCode();
            }

            if (Images != null)
            {
                hash = hash * 59 + Images.GetHashCode();
            }

            return hash;
        }
    }
}
