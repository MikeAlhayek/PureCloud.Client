using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BotMessengerProfile
/// </summary>

public partial class BotMessengerProfile : IEquatable<BotMessengerProfile>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BotMessengerProfile" /> class.
    /// </summary>
    /// <param name="Name">Name of the Bot.</param>
    /// <param name="AvatarUrl">Avatar for Bot.</param>
    public BotMessengerProfile(string Name = null, string AvatarUrl = null)
    {
        this.Name = Name;
        this.AvatarUrl = AvatarUrl;

    }



    /// <summary>
    /// Name of the Bot
    /// </summary>
    /// <value>Name of the Bot</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Avatar for Bot
    /// </summary>
    /// <value>Avatar for Bot</value>
    [JsonPropertyName("avatarUrl")]
    public string AvatarUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BotMessengerProfile {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
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
        return Equals(obj as BotMessengerProfile);
    }

    /// <summary>
    /// Returns true if BotMessengerProfile instances are equal
    /// </summary>
    /// <param name="other">Instance of BotMessengerProfile to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BotMessengerProfile other)
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
                AvatarUrl == other.AvatarUrl ||
                AvatarUrl != null &&
                AvatarUrl.Equals(other.AvatarUrl)
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

            if (AvatarUrl != null)
            {
                hash = hash * 59 + AvatarUrl.GetHashCode();
            }

            return hash;
        }
    }
}
