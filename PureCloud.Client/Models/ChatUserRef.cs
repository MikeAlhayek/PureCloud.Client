using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatUserRef
/// </summary>

public partial class ChatUserRef : IEquatable<ChatUserRef>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatUserRef" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="Jid">Jid.</param>
    /// <param name="Inactive">Inactive.</param>
    /// <param name="Integrations">Integrations.</param>
    /// <param name="Presence">Presence.</param>
    public ChatUserRef(string Id = null, string Name = null, string SelfUri = null, string Jid = null, bool? Inactive = null, List<Contact> Integrations = null, ChatPresence Presence = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SelfUri = SelfUri;
        this.Jid = Jid;
        this.Inactive = Inactive;
        this.Integrations = Integrations;
        this.Presence = Presence;

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
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets Jid
    /// </summary>
    [JsonPropertyName("jid")]
    public string Jid { get; set; }



    /// <summary>
    /// Gets or Sets Inactive
    /// </summary>
    [JsonPropertyName("inactive")]
    public bool? Inactive { get; set; }



    /// <summary>
    /// Gets or Sets Integrations
    /// </summary>
    [JsonPropertyName("integrations")]
    public List<Contact> Integrations { get; set; }



    /// <summary>
    /// Gets or Sets Presence
    /// </summary>
    [JsonPropertyName("presence")]
    public ChatPresence Presence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatUserRef {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Jid: ").Append(Jid).Append("\n");
        sb.Append("  Inactive: ").Append(Inactive).Append("\n");
        sb.Append("  Integrations: ").Append(Integrations).Append("\n");
        sb.Append("  Presence: ").Append(Presence).Append("\n");
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
        return Equals(obj as ChatUserRef);
    }

    /// <summary>
    /// Returns true if ChatUserRef instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatUserRef to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatUserRef other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Jid == other.Jid ||
                Jid != null &&
                Jid.Equals(other.Jid)
            ) &&
            (
                Inactive == other.Inactive ||
                Inactive != null &&
                Inactive.Equals(other.Inactive)
            ) &&
            (
                Integrations == other.Integrations ||
                Integrations != null &&
                Integrations.SequenceEqual(other.Integrations)
            ) &&
            (
                Presence == other.Presence ||
                Presence != null &&
                Presence.Equals(other.Presence)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Jid != null)
            {
                hash = hash * 59 + Jid.GetHashCode();
            }

            if (Inactive != null)
            {
                hash = hash * 59 + Inactive.GetHashCode();
            }

            if (Integrations != null)
            {
                hash = hash * 59 + Integrations.GetHashCode();
            }

            if (Presence != null)
            {
                hash = hash * 59 + Presence.GetHashCode();
            }

            return hash;
        }
    }
}
