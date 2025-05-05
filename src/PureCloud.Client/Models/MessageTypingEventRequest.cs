using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessageTypingEventRequest
/// </summary>

public partial class MessageTypingEventRequest : IEquatable<MessageTypingEventRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MessageTypingEventRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessageTypingEventRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageTypingEventRequest" /> class.
    /// </summary>
    /// <param name="Typing">Typing event (required).</param>
    /// <param name="DateSent">The time when the message typing event was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public MessageTypingEventRequest(ConversationEventTyping Typing = null, DateTime? DateSent = null)
    {
        this.Typing = Typing;
        this.DateSent = DateSent;

    }



    /// <summary>
    /// Typing event
    /// </summary>
    /// <value>Typing event</value>
    [JsonPropertyName("typing")]
    public ConversationEventTyping Typing { get; set; }



    /// <summary>
    /// The time when the message typing event was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the message typing event was sent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateSent")]
    public DateTime? DateSent { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessageTypingEventRequest {\n");

        sb.Append("  Typing: ").Append(Typing).Append("\n");
        sb.Append("  DateSent: ").Append(DateSent).Append("\n");
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
        return Equals(obj as MessageTypingEventRequest);
    }

    /// <summary>
    /// Returns true if MessageTypingEventRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of MessageTypingEventRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessageTypingEventRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Typing == other.Typing ||
                Typing != null &&
                Typing.Equals(other.Typing)
            ) &&
            (
                DateSent == other.DateSent ||
                DateSent != null &&
                DateSent.Equals(other.DateSent)
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
            if (Typing != null)
            {
                hash = hash * 59 + Typing.GetHashCode();
            }

            if (DateSent != null)
            {
                hash = hash * 59 + DateSent.GetHashCode();
            }

            return hash;
        }
    }
}
