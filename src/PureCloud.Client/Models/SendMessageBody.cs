using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SendMessageBody
/// </summary>

public partial class SendMessageBody : IEquatable<SendMessageBody>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SendMessageBody" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SendMessageBody() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SendMessageBody" /> class.
    /// </summary>
    /// <param name="Message">The body of the message (required).</param>
    /// <param name="Mentions">user ids to be notified.</param>
    /// <param name="ThreadId">The thread id of the message.</param>
    public SendMessageBody(string Message = null, List<string> Mentions = null, string ThreadId = null)
    {
        this.Message = Message;
        this.Mentions = Mentions;
        this.ThreadId = ThreadId;

    }



    /// <summary>
    /// The body of the message
    /// </summary>
    /// <value>The body of the message</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// user ids to be notified
    /// </summary>
    /// <value>user ids to be notified</value>
    [JsonPropertyName("mentions")]
    public List<string> Mentions { get; set; }



    /// <summary>
    /// The thread id of the message
    /// </summary>
    /// <value>The thread id of the message</value>
    [JsonPropertyName("threadId")]
    public string ThreadId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SendMessageBody {\n");

        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Mentions: ").Append(Mentions).Append("\n");
        sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
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
        return Equals(obj as SendMessageBody);
    }

    /// <summary>
    /// Returns true if SendMessageBody instances are equal
    /// </summary>
    /// <param name="other">Instance of SendMessageBody to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SendMessageBody other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Mentions == other.Mentions ||
                Mentions != null &&
                Mentions.SequenceEqual(other.Mentions)
            ) &&
            (
                ThreadId == other.ThreadId ||
                ThreadId != null &&
                ThreadId.Equals(other.ThreadId)
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
            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Mentions != null)
            {
                hash = hash * 59 + Mentions.GetHashCode();
            }

            if (ThreadId != null)
            {
                hash = hash * 59 + ThreadId.GetHashCode();
            }

            return hash;
        }
    }
}
