using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UserConversationSummary
/// </summary>
[DataContract]
public partial class UserConversationSummary : IEquatable<UserConversationSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserConversationSummary" /> class.
    /// </summary>
    /// <param name="UserId">UserId.</param>
    /// <param name="Call">Call.</param>
    /// <param name="Callback">Callback.</param>
    /// <param name="Email">Email.</param>
    /// <param name="Message">Message.</param>
    /// <param name="Chat">Chat.</param>
    /// <param name="SocialExpression">SocialExpression.</param>
    /// <param name="Video">Video.</param>
    public UserConversationSummary(string UserId = null, MediaSummary Call = null, MediaSummary Callback = null, MediaSummary Email = null, MediaSummary Message = null, MediaSummary Chat = null, MediaSummary SocialExpression = null, MediaSummary Video = null)
    {
        this.UserId = UserId;
        this.Call = Call;
        this.Callback = Callback;
        this.Email = Email;
        this.Message = Message;
        this.Chat = Chat;
        this.SocialExpression = SocialExpression;
        this.Video = Video;

    }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets Call
    /// </summary>
    [DataMember(Name = "call", EmitDefaultValue = false)]
    public MediaSummary Call { get; set; }



    /// <summary>
    /// Gets or Sets Callback
    /// </summary>
    [DataMember(Name = "callback", EmitDefaultValue = false)]
    public MediaSummary Callback { get; set; }



    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    public MediaSummary Email { get; set; }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public MediaSummary Message { get; set; }



    /// <summary>
    /// Gets or Sets Chat
    /// </summary>
    [DataMember(Name = "chat", EmitDefaultValue = false)]
    public MediaSummary Chat { get; set; }



    /// <summary>
    /// Gets or Sets SocialExpression
    /// </summary>
    [DataMember(Name = "socialExpression", EmitDefaultValue = false)]
    public MediaSummary SocialExpression { get; set; }



    /// <summary>
    /// Gets or Sets Video
    /// </summary>
    [DataMember(Name = "video", EmitDefaultValue = false)]
    public MediaSummary Video { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserConversationSummary {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Call: ").Append(Call).Append("\n");
        sb.Append("  Callback: ").Append(Callback).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Chat: ").Append(Chat).Append("\n");
        sb.Append("  SocialExpression: ").Append(SocialExpression).Append("\n");
        sb.Append("  Video: ").Append(Video).Append("\n");
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
        return Equals(obj as UserConversationSummary);
    }

    /// <summary>
    /// Returns true if UserConversationSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of UserConversationSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserConversationSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
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
                Email == other.Email ||
                Email != null &&
                Email.Equals(other.Email)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Chat == other.Chat ||
                Chat != null &&
                Chat.Equals(other.Chat)
            ) &&
            (
                SocialExpression == other.SocialExpression ||
                SocialExpression != null &&
                SocialExpression.Equals(other.SocialExpression)
            ) &&
            (
                Video == other.Video ||
                Video != null &&
                Video.Equals(other.Video)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (Call != null)
            {
                hash = hash * 59 + Call.GetHashCode();
            }

            if (Callback != null)
            {
                hash = hash * 59 + Callback.GetHashCode();
            }

            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Chat != null)
            {
                hash = hash * 59 + Chat.GetHashCode();
            }

            if (SocialExpression != null)
            {
                hash = hash * 59 + SocialExpression.GetHashCode();
            }

            if (Video != null)
            {
                hash = hash * 59 + Video.GetHashCode();
            }

            return hash;
        }
    }
}
