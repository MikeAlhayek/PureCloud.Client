using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateWebChatConversationResponse
/// </summary>

public partial class CreateWebChatConversationResponse : IEquatable<CreateWebChatConversationResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateWebChatConversationResponse" /> class.
    /// </summary>
    /// <param name="Id">Chat Conversation identifier.</param>
    /// <param name="Jwt">The JWT that you can use to identify subsequent calls on this conversation.</param>
    /// <param name="EventStreamUri">The URI which provides the conversation event stream..</param>
    /// <param name="Member">Chat Member.</param>
    public CreateWebChatConversationResponse(string Id = null, string Jwt = null, string EventStreamUri = null, WebChatMemberInfo Member = null)
    {
        this.Id = Id;
        this.Jwt = Jwt;
        this.EventStreamUri = EventStreamUri;
        this.Member = Member;

    }



    /// <summary>
    /// Chat Conversation identifier
    /// </summary>
    /// <value>Chat Conversation identifier</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The JWT that you can use to identify subsequent calls on this conversation
    /// </summary>
    /// <value>The JWT that you can use to identify subsequent calls on this conversation</value>
    [JsonPropertyName("jwt")]
    public string Jwt { get; set; }



    /// <summary>
    /// The URI which provides the conversation event stream.
    /// </summary>
    /// <value>The URI which provides the conversation event stream.</value>
    [JsonPropertyName("eventStreamUri")]
    public string EventStreamUri { get; set; }



    /// <summary>
    /// Chat Member
    /// </summary>
    /// <value>Chat Member</value>
    [JsonPropertyName("member")]
    public WebChatMemberInfo Member { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateWebChatConversationResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Jwt: ").Append(Jwt).Append("\n");
        sb.Append("  EventStreamUri: ").Append(EventStreamUri).Append("\n");
        sb.Append("  Member: ").Append(Member).Append("\n");
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
        return Equals(obj as CreateWebChatConversationResponse);
    }

    /// <summary>
    /// Returns true if CreateWebChatConversationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateWebChatConversationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateWebChatConversationResponse other)
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
                Jwt == other.Jwt ||
                Jwt != null &&
                Jwt.Equals(other.Jwt)
            ) &&
            (
                EventStreamUri == other.EventStreamUri ||
                EventStreamUri != null &&
                EventStreamUri.Equals(other.EventStreamUri)
            ) &&
            (
                Member == other.Member ||
                Member != null &&
                Member.Equals(other.Member)
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

            if (Jwt != null)
            {
                hash = hash * 59 + Jwt.GetHashCode();
            }

            if (EventStreamUri != null)
            {
                hash = hash * 59 + EventStreamUri.GetHashCode();
            }

            if (Member != null)
            {
                hash = hash * 59 + Member.GetHashCode();
            }

            return hash;
        }
    }
}
