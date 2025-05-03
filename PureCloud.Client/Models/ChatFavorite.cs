using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatFavorite
/// </summary>

public partial class ChatFavorite : IEquatable<ChatFavorite>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatFavorite" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ChatFavorite() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatFavorite" /> class.
    /// </summary>
    /// <param name="Id">The guid id of the favorite (required).</param>
    /// <param name="ExternalId">The external id of the favorite (required).</param>
    public ChatFavorite(string Id = null, string ExternalId = null)
    {
        this.Id = Id;
        this.ExternalId = ExternalId;

    }



    /// <summary>
    /// The guid id of the favorite
    /// </summary>
    /// <value>The guid id of the favorite</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The external id of the favorite
    /// </summary>
    /// <value>The external id of the favorite</value>
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatFavorite {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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
        return Equals(obj as ChatFavorite);
    }

    /// <summary>
    /// Returns true if ChatFavorite instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatFavorite to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatFavorite other)
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
                ExternalId == other.ExternalId ||
                ExternalId != null &&
                ExternalId.Equals(other.ExternalId)
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

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            return hash;
        }
    }
}
