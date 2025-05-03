using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaPolicies
/// </summary>

public partial class MediaPolicies : IEquatable<MediaPolicies>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaPolicies" /> class.
    /// </summary>
    /// <param name="CallPolicy">Conditions and actions for calls.</param>
    /// <param name="ChatPolicy">Conditions and actions for chats.</param>
    /// <param name="EmailPolicy">Conditions and actions for emails.</param>
    /// <param name="MessagePolicy">Conditions and actions for messages.</param>
    public MediaPolicies(CallMediaPolicy CallPolicy = null, ChatMediaPolicy ChatPolicy = null, EmailMediaPolicy EmailPolicy = null, MessageMediaPolicy MessagePolicy = null)
    {
        this.CallPolicy = CallPolicy;
        this.ChatPolicy = ChatPolicy;
        this.EmailPolicy = EmailPolicy;
        this.MessagePolicy = MessagePolicy;

    }



    /// <summary>
    /// Conditions and actions for calls
    /// </summary>
    /// <value>Conditions and actions for calls</value>
    [JsonPropertyName("callPolicy")]
    public CallMediaPolicy CallPolicy { get; set; }



    /// <summary>
    /// Conditions and actions for chats
    /// </summary>
    /// <value>Conditions and actions for chats</value>
    [JsonPropertyName("chatPolicy")]
    public ChatMediaPolicy ChatPolicy { get; set; }



    /// <summary>
    /// Conditions and actions for emails
    /// </summary>
    /// <value>Conditions and actions for emails</value>
    [JsonPropertyName("emailPolicy")]
    public EmailMediaPolicy EmailPolicy { get; set; }



    /// <summary>
    /// Conditions and actions for messages
    /// </summary>
    /// <value>Conditions and actions for messages</value>
    [JsonPropertyName("messagePolicy")]
    public MessageMediaPolicy MessagePolicy { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaPolicies {\n");

        sb.Append("  CallPolicy: ").Append(CallPolicy).Append("\n");
        sb.Append("  ChatPolicy: ").Append(ChatPolicy).Append("\n");
        sb.Append("  EmailPolicy: ").Append(EmailPolicy).Append("\n");
        sb.Append("  MessagePolicy: ").Append(MessagePolicy).Append("\n");
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
        return Equals(obj as MediaPolicies);
    }

    /// <summary>
    /// Returns true if MediaPolicies instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaPolicies to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaPolicies other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CallPolicy == other.CallPolicy ||
                CallPolicy != null &&
                CallPolicy.Equals(other.CallPolicy)
            ) &&
            (
                ChatPolicy == other.ChatPolicy ||
                ChatPolicy != null &&
                ChatPolicy.Equals(other.ChatPolicy)
            ) &&
            (
                EmailPolicy == other.EmailPolicy ||
                EmailPolicy != null &&
                EmailPolicy.Equals(other.EmailPolicy)
            ) &&
            (
                MessagePolicy == other.MessagePolicy ||
                MessagePolicy != null &&
                MessagePolicy.Equals(other.MessagePolicy)
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
            if (CallPolicy != null)
            {
                hash = hash * 59 + CallPolicy.GetHashCode();
            }

            if (ChatPolicy != null)
            {
                hash = hash * 59 + ChatPolicy.GetHashCode();
            }

            if (EmailPolicy != null)
            {
                hash = hash * 59 + EmailPolicy.GetHashCode();
            }

            if (MessagePolicy != null)
            {
                hash = hash * 59 + MessagePolicy.GetHashCode();
            }

            return hash;
        }
    }
}
