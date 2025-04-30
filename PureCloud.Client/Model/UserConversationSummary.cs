using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// UserConversationSummary
    /// </summary>
    [DataContract]
    public partial class UserConversationSummary :  IEquatable<UserConversationSummary>
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
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Gets or Sets Call
        /// </summary>
        [DataMember(Name="call", EmitDefaultValue=false)]
        public MediaSummary Call { get; set; }



        /// <summary>
        /// Gets or Sets Callback
        /// </summary>
        [DataMember(Name="callback", EmitDefaultValue=false)]
        public MediaSummary Callback { get; set; }



        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public MediaSummary Email { get; set; }



        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public MediaSummary Message { get; set; }



        /// <summary>
        /// Gets or Sets Chat
        /// </summary>
        [DataMember(Name="chat", EmitDefaultValue=false)]
        public MediaSummary Chat { get; set; }



        /// <summary>
        /// Gets or Sets SocialExpression
        /// </summary>
        [DataMember(Name="socialExpression", EmitDefaultValue=false)]
        public MediaSummary SocialExpression { get; set; }



        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
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
            return this.Equals(obj as UserConversationSummary);
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
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Call == other.Call ||
                    this.Call != null &&
                    this.Call.Equals(other.Call)
                ) &&
                (
                    this.Callback == other.Callback ||
                    this.Callback != null &&
                    this.Callback.Equals(other.Callback)
                ) &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Chat == other.Chat ||
                    this.Chat != null &&
                    this.Chat.Equals(other.Chat)
                ) &&
                (
                    this.SocialExpression == other.SocialExpression ||
                    this.SocialExpression != null &&
                    this.SocialExpression.Equals(other.SocialExpression)
                ) &&
                (
                    this.Video == other.Video ||
                    this.Video != null &&
                    this.Video.Equals(other.Video)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.Call != null)
                    hash = hash * 59 + this.Call.GetHashCode();

                if (this.Callback != null)
                    hash = hash * 59 + this.Callback.GetHashCode();

                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Chat != null)
                    hash = hash * 59 + this.Chat.GetHashCode();

                if (this.SocialExpression != null)
                    hash = hash * 59 + this.SocialExpression.GetHashCode();

                if (this.Video != null)
                    hash = hash * 59 + this.Video.GetHashCode();

                return hash;
            }
        }
    }

}
