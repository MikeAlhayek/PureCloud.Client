using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueMediaSettings
/// </summary>
[DataContract]
public partial class QueueMediaSettings : IEquatable<QueueMediaSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueMediaSettings" /> class.
    /// </summary>
    /// <param name="Call">The queue media settings for call interactions..</param>
    /// <param name="Callback">The queue media settings for callback interactions..</param>
    /// <param name="Chat">The queue media settings for chat interactions..</param>
    /// <param name="Email">The queue media settings for email interactions..</param>
    /// <param name="Message">The queue media settings for message interactions..</param>
    public QueueMediaSettings(MediaSettings Call = null, CallbackMediaSettings Callback = null, MediaSettings Chat = null, EmailMediaSettings Email = null, MessageMediaSettings Message = null)
    {
        this.Call = Call;
        this.Callback = Callback;
        this.Chat = Chat;
        this.Email = Email;
        this.Message = Message;

    }



    /// <summary>
    /// The queue media settings for call interactions.
    /// </summary>
    /// <value>The queue media settings for call interactions.</value>
    [DataMember(Name = "call", EmitDefaultValue = false)]
    public MediaSettings Call { get; set; }



    /// <summary>
    /// The queue media settings for callback interactions.
    /// </summary>
    /// <value>The queue media settings for callback interactions.</value>
    [DataMember(Name = "callback", EmitDefaultValue = false)]
    public CallbackMediaSettings Callback { get; set; }



    /// <summary>
    /// The queue media settings for chat interactions.
    /// </summary>
    /// <value>The queue media settings for chat interactions.</value>
    [DataMember(Name = "chat", EmitDefaultValue = false)]
    public MediaSettings Chat { get; set; }



    /// <summary>
    /// The queue media settings for email interactions.
    /// </summary>
    /// <value>The queue media settings for email interactions.</value>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    public EmailMediaSettings Email { get; set; }



    /// <summary>
    /// The queue media settings for message interactions.
    /// </summary>
    /// <value>The queue media settings for message interactions.</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public MessageMediaSettings Message { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueMediaSettings {\n");

        sb.Append("  Call: ").Append(Call).Append("\n");
        sb.Append("  Callback: ").Append(Callback).Append("\n");
        sb.Append("  Chat: ").Append(Chat).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
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
        return Equals(obj as QueueMediaSettings);
    }

    /// <summary>
    /// Returns true if QueueMediaSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueMediaSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueMediaSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Call == other.Call ||
                Call != null &&
                Call.Equals(other.Call)
            ) &&
            (
                Callback == other.Callback ||
                Callback != null &&
                Callback.Equals(other.Callback)
            ) &&
            (
                Chat == other.Chat ||
                Chat != null &&
                Chat.Equals(other.Chat)
            ) &&
            (
                Email == other.Email ||
                Email != null &&
                Email.Equals(other.Email)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
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
            if (Call != null)
            {
                hash = hash * 59 + Call.GetHashCode();
            }

            if (Callback != null)
            {
                hash = hash * 59 + Callback.GetHashCode();
            }

            if (Chat != null)
            {
                hash = hash * 59 + Chat.GetHashCode();
            }

            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            return hash;
        }
    }
}
