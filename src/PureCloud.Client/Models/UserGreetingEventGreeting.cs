using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserGreetingEventGreeting
/// </summary>

public partial class UserGreetingEventGreeting : IEquatable<UserGreetingEventGreeting>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserGreetingEventGreeting" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Type">Type.</param>
    /// <param name="OwnerType">OwnerType.</param>
    /// <param name="Owner">Owner.</param>
    /// <param name="GreetingAudioFile">GreetingAudioFile.</param>
    /// <param name="AudioTTS">AudioTTS.</param>
    public UserGreetingEventGreeting(string Id = null, string Name = null, string Type = null, string OwnerType = null, UserGreetingEventGreetingOwner Owner = null, UserGreetingEventGreetingAudioFile GreetingAudioFile = null, string AudioTTS = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Type = Type;
        this.OwnerType = OwnerType;
        this.Owner = Owner;
        this.GreetingAudioFile = GreetingAudioFile;
        this.AudioTTS = AudioTTS;

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
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets OwnerType
    /// </summary>
    [JsonPropertyName("ownerType")]
    public string OwnerType { get; set; }



    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [JsonPropertyName("owner")]
    public UserGreetingEventGreetingOwner Owner { get; set; }



    /// <summary>
    /// Gets or Sets GreetingAudioFile
    /// </summary>
    [JsonPropertyName("greetingAudioFile")]
    public UserGreetingEventGreetingAudioFile GreetingAudioFile { get; set; }



    /// <summary>
    /// Gets or Sets AudioTTS
    /// </summary>
    [JsonPropertyName("audioTTS")]
    public string AudioTTS { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserGreetingEventGreeting {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
        sb.Append("  Owner: ").Append(Owner).Append("\n");
        sb.Append("  GreetingAudioFile: ").Append(GreetingAudioFile).Append("\n");
        sb.Append("  AudioTTS: ").Append(AudioTTS).Append("\n");
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
        return Equals(obj as UserGreetingEventGreeting);
    }

    /// <summary>
    /// Returns true if UserGreetingEventGreeting instances are equal
    /// </summary>
    /// <param name="other">Instance of UserGreetingEventGreeting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserGreetingEventGreeting other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                OwnerType == other.OwnerType ||
                OwnerType != null &&
                OwnerType.Equals(other.OwnerType)
            ) &&
            (
                Owner == other.Owner ||
                Owner != null &&
                Owner.Equals(other.Owner)
            ) &&
            (
                GreetingAudioFile == other.GreetingAudioFile ||
                GreetingAudioFile != null &&
                GreetingAudioFile.Equals(other.GreetingAudioFile)
            ) &&
            (
                AudioTTS == other.AudioTTS ||
                AudioTTS != null &&
                AudioTTS.Equals(other.AudioTTS)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (OwnerType != null)
            {
                hash = hash * 59 + OwnerType.GetHashCode();
            }

            if (Owner != null)
            {
                hash = hash * 59 + Owner.GetHashCode();
            }

            if (GreetingAudioFile != null)
            {
                hash = hash * 59 + GreetingAudioFile.GetHashCode();
            }

            if (AudioTTS != null)
            {
                hash = hash * 59 + AudioTTS.GetHashCode();
            }

            return hash;
        }
    }
}
