using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Presence from a given source for a user
/// </summary>

public partial class UcUserPresence : IEquatable<UcUserPresence>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UcUserPresence" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="UserId">User ID of the associated Genesys Cloud user..</param>
    /// <param name="Source">Deprecated - The sourceID field should be used as a replacement..</param>
    /// <param name="SourceId">The registered source ID from where the presence was set.</param>
    /// <param name="PresenceDefinition">PresenceDefinition.</param>
    /// <param name="Message">Message.</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public UcUserPresence(string Name = null, string UserId = null, string Source = null, string SourceId = null, PresenceDefinition PresenceDefinition = null, string Message = null, DateTime? ModifiedDate = null)
    {
        this.Name = Name;
        this.UserId = UserId;
        this.Source = Source;
        this.SourceId = SourceId;
        this.PresenceDefinition = PresenceDefinition;
        this.Message = Message;
        this.ModifiedDate = ModifiedDate;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// User ID of the associated Genesys Cloud user.
    /// </summary>
    /// <value>User ID of the associated Genesys Cloud user.</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// Deprecated - The sourceID field should be used as a replacement.
    /// </summary>
    /// <value>Deprecated - The sourceID field should be used as a replacement.</value>
    [JsonPropertyName("source")]
    public string Source { get; set; }



    /// <summary>
    /// The registered source ID from where the presence was set
    /// </summary>
    /// <value>The registered source ID from where the presence was set</value>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; }



    /// <summary>
    /// Gets or Sets PresenceDefinition
    /// </summary>
    [JsonPropertyName("presenceDefinition")]
    public PresenceDefinition PresenceDefinition { get; set; }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UcUserPresence {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  SourceId: ").Append(SourceId).Append("\n");
        sb.Append("  PresenceDefinition: ").Append(PresenceDefinition).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as UcUserPresence);
    }

    /// <summary>
    /// Returns true if UcUserPresence instances are equal
    /// </summary>
    /// <param name="other">Instance of UcUserPresence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UcUserPresence other)
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
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                SourceId == other.SourceId ||
                SourceId != null &&
                SourceId.Equals(other.SourceId)
            ) &&
            (
                PresenceDefinition == other.PresenceDefinition ||
                PresenceDefinition != null &&
                PresenceDefinition.Equals(other.PresenceDefinition)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (SourceId != null)
            {
                hash = hash * 59 + SourceId.GetHashCode();
            }

            if (PresenceDefinition != null)
            {
                hash = hash * 59 + PresenceDefinition.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
