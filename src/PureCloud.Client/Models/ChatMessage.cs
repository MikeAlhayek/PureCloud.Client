using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatMessage
/// </summary>

public partial class ChatMessage : IEquatable<ChatMessage>
{
    /// <summary>
    /// Type of the message body (v2 chats only)
    /// </summary>
    /// <value>Type of the message body (v2 chats only)</value>
    
    public enum BodyTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Standard for "STANDARD"
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        Standard,

        /// <summary>
        /// Enum Activity for "ACTIVITY"
        /// </summary>
        [EnumMember(Value = "ACTIVITY")]
        Activity,

        /// <summary>
        /// Enum Typing for "TYPING"
        /// </summary>
        [EnumMember(Value = "TYPING")]
        Typing,

        /// <summary>
        /// Enum Notice for "NOTICE"
        /// </summary>
        [EnumMember(Value = "NOTICE")]
        Notice,

        /// <summary>
        /// Enum Memberjoin for "MEMBERJOIN"
        /// </summary>
        [EnumMember(Value = "MEMBERJOIN")]
        Memberjoin,

        /// <summary>
        /// Enum Memberleave for "MEMBERLEAVE"
        /// </summary>
        [EnumMember(Value = "MEMBERLEAVE")]
        Memberleave,

        /// <summary>
        /// Enum Mediarequest for "MEDIAREQUEST"
        /// </summary>
        [EnumMember(Value = "MEDIAREQUEST")]
        Mediarequest
    }
    /// <summary>
    /// Type of the message body (v2 chats only)
    /// </summary>
    /// <value>Type of the message body (v2 chats only)</value>
    [JsonPropertyName("bodyType")]
    public BodyTypeEnum? BodyType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatMessage" /> class.
    /// </summary>
    /// <param name="Body">The message body.</param>
    /// <param name="Id">Id.</param>
    /// <param name="To">The message recipient.</param>
    /// <param name="From">The message sender.</param>
    /// <param name="Utc">Utc.</param>
    /// <param name="Chat">The interaction id (if available).</param>
    /// <param name="Message">The message id.</param>
    /// <param name="Type">Type.</param>
    /// <param name="BodyType">Type of the message body (v2 chats only).</param>
    /// <param name="SenderCommunicationId">Communication of sender (v2 chats only).</param>
    /// <param name="ParticipantPurpose">Participant purpose of sender (v2 chats only).</param>
    /// <param name="User">The user information for the sender (if available).</param>
    public ChatMessage(string Body = null, string Id = null, string To = null, string From = null, string Utc = null, string Chat = null, string Message = null, string Type = null, BodyTypeEnum? BodyType = null, string SenderCommunicationId = null, string ParticipantPurpose = null, ChatMessageUser User = null)
    {
        this.Body = Body;
        this.Id = Id;
        this.To = To;
        this.From = From;
        this.Utc = Utc;
        this.Chat = Chat;
        this.Message = Message;
        this.Type = Type;
        this.BodyType = BodyType;
        this.SenderCommunicationId = SenderCommunicationId;
        this.ParticipantPurpose = ParticipantPurpose;
        this.User = User;

    }



    /// <summary>
    /// The message body
    /// </summary>
    /// <value>The message body</value>
    [JsonPropertyName("body")]
    public string Body { get; set; }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The message recipient
    /// </summary>
    /// <value>The message recipient</value>
    [JsonPropertyName("to")]
    public string To { get; set; }



    /// <summary>
    /// The message sender
    /// </summary>
    /// <value>The message sender</value>
    [JsonPropertyName("from")]
    public string From { get; set; }



    /// <summary>
    /// Gets or Sets Utc
    /// </summary>
    [JsonPropertyName("utc")]
    public string Utc { get; set; }



    /// <summary>
    /// The interaction id (if available)
    /// </summary>
    /// <value>The interaction id (if available)</value>
    [JsonPropertyName("chat")]
    public string Chat { get; set; }



    /// <summary>
    /// The message id
    /// </summary>
    /// <value>The message id</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }





    /// <summary>
    /// Communication of sender (v2 chats only)
    /// </summary>
    /// <value>Communication of sender (v2 chats only)</value>
    [JsonPropertyName("senderCommunicationId")]
    public string SenderCommunicationId { get; set; }



    /// <summary>
    /// Participant purpose of sender (v2 chats only)
    /// </summary>
    /// <value>Participant purpose of sender (v2 chats only)</value>
    [JsonPropertyName("participantPurpose")]
    public string ParticipantPurpose { get; set; }



    /// <summary>
    /// The user information for the sender (if available)
    /// </summary>
    /// <value>The user information for the sender (if available)</value>
    [JsonPropertyName("user")]
    public ChatMessageUser User { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatMessage {\n");

        sb.Append("  Body: ").Append(Body).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  Utc: ").Append(Utc).Append("\n");
        sb.Append("  Chat: ").Append(Chat).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  BodyType: ").Append(BodyType).Append("\n");
        sb.Append("  SenderCommunicationId: ").Append(SenderCommunicationId).Append("\n");
        sb.Append("  ParticipantPurpose: ").Append(ParticipantPurpose).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as ChatMessage);
    }

    /// <summary>
    /// Returns true if ChatMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Body == other.Body ||
                Body != null &&
                Body.Equals(other.Body)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                To == other.To ||
                To != null &&
                To.Equals(other.To)
            ) &&
            (
                From == other.From ||
                From != null &&
                From.Equals(other.From)
            ) &&
            (
                Utc == other.Utc ||
                Utc != null &&
                Utc.Equals(other.Utc)
            ) &&
            (
                Chat == other.Chat ||
                Chat != null &&
                Chat.Equals(other.Chat)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                BodyType == other.BodyType ||
                BodyType != null &&
                BodyType.Equals(other.BodyType)
            ) &&
            (
                SenderCommunicationId == other.SenderCommunicationId ||
                SenderCommunicationId != null &&
                SenderCommunicationId.Equals(other.SenderCommunicationId)
            ) &&
            (
                ParticipantPurpose == other.ParticipantPurpose ||
                ParticipantPurpose != null &&
                ParticipantPurpose.Equals(other.ParticipantPurpose)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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
            if (Body != null)
            {
                hash = hash * 59 + Body.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (To != null)
            {
                hash = hash * 59 + To.GetHashCode();
            }

            if (From != null)
            {
                hash = hash * 59 + From.GetHashCode();
            }

            if (Utc != null)
            {
                hash = hash * 59 + Utc.GetHashCode();
            }

            if (Chat != null)
            {
                hash = hash * 59 + Chat.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (BodyType != null)
            {
                hash = hash * 59 + BodyType.GetHashCode();
            }

            if (SenderCommunicationId != null)
            {
                hash = hash * 59 + SenderCommunicationId.GetHashCode();
            }

            if (ParticipantPurpose != null)
            {
                hash = hash * 59 + ParticipantPurpose.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            return hash;
        }
    }
}
