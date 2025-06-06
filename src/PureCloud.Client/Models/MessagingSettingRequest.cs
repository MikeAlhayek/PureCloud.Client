using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Messaging setting for messaging platform integrations
/// </summary>

public partial class MessagingSettingRequest : IEquatable<MessagingSettingRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingSettingRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessagingSettingRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingSettingRequest" /> class.
    /// </summary>
    /// <param name="Name">The messaging Setting profile name (required).</param>
    /// <param name="Content">Settings relating to message contents.</param>
    /// <param name="Event">Settings relating to events which may occur.</param>
    public MessagingSettingRequest(string Name = null, ContentSetting Content = null, EventSetting Event = null)
    {
        this.Name = Name;
        this.Content = Content;
        this.Event = Event;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The messaging Setting profile name
    /// </summary>
    /// <value>The messaging Setting profile name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Settings relating to message contents
    /// </summary>
    /// <value>Settings relating to message contents</value>
    [JsonPropertyName("content")]
    public ContentSetting Content { get; set; }



    /// <summary>
    /// Settings relating to events which may occur
    /// </summary>
    /// <value>Settings relating to events which may occur</value>
    [JsonPropertyName("event")]
    public EventSetting Event { get; set; }



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
        sb.Append("class MessagingSettingRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Event: ").Append(Event).Append("\n");
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
        return Equals(obj as MessagingSettingRequest);
    }

    /// <summary>
    /// Returns true if MessagingSettingRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingSettingRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingSettingRequest other)
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
                Content == other.Content ||
                Content != null &&
                Content.Equals(other.Content)
            ) &&
            (
                Event == other.Event ||
                Event != null &&
                Event.Equals(other.Event)
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

            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            if (Event != null)
            {
                hash = hash * 59 + Event.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
