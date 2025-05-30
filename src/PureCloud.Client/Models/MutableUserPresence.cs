using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MutableUserPresence
/// </summary>

public partial class MutableUserPresence : IEquatable<MutableUserPresence>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MutableUserPresence" /> class.
    /// </summary>
    /// <param name="Id">The user&#39;s id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Source">Deprecated - The sourceID field should be used as a replacement..</param>
    /// <param name="SourceId">Represents the ID of a registered source.</param>
    /// <param name="Primary">A boolean used to tell whether or not to set this presence source as the primary on a PATCH.</param>
    /// <param name="PresenceDefinition">PresenceDefinition.</param>
    /// <param name="Message">Message.</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public MutableUserPresence(string Id = null, string Name = null, string Source = null, string SourceId = null, bool? Primary = null, PresenceDefinition PresenceDefinition = null, string Message = null, DateTime? ModifiedDate = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Source = Source;
        this.SourceId = SourceId;
        this.Primary = Primary;
        this.PresenceDefinition = PresenceDefinition;
        this.Message = Message;
        this.ModifiedDate = ModifiedDate;

    }



    /// <summary>
    /// The user&#39;s id
    /// </summary>
    /// <value>The user&#39;s id</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Deprecated - The sourceID field should be used as a replacement.
    /// </summary>
    /// <value>Deprecated - The sourceID field should be used as a replacement.</value>
    [JsonPropertyName("source")]
    public string Source { get; set; }



    /// <summary>
    /// Represents the ID of a registered source
    /// </summary>
    /// <value>Represents the ID of a registered source</value>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; }



    /// <summary>
    /// A boolean used to tell whether or not to set this presence source as the primary on a PATCH
    /// </summary>
    /// <value>A boolean used to tell whether or not to set this presence source as the primary on a PATCH</value>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }



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
        sb.Append("class MutableUserPresence {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  SourceId: ").Append(SourceId).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
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
        return Equals(obj as MutableUserPresence);
    }

    /// <summary>
    /// Returns true if MutableUserPresence instances are equal
    /// </summary>
    /// <param name="other">Instance of MutableUserPresence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MutableUserPresence other)
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
                Primary == other.Primary ||
                Primary != null &&
                Primary.Equals(other.Primary)
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

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (SourceId != null)
            {
                hash = hash * 59 + SourceId.GetHashCode();
            }

            if (Primary != null)
            {
                hash = hash * 59 + Primary.GetHashCode();
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
