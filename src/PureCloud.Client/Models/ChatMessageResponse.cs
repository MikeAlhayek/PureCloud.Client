using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatMessageResponse
/// </summary>

public partial class ChatMessageResponse : IEquatable<ChatMessageResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatMessageResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ChatMessageResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatMessageResponse" /> class.
    /// </summary>
    /// <param name="Id">The id of the message (required).</param>
    /// <param name="DateCreated">Message&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="DateModified">Message&#39;s last updated time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ToJid">Jid of message&#39;s recipient (roomJid or userJid) (required).</param>
    /// <param name="Jid">Jid of message&#39;s sender (userJid) (required).</param>
    /// <param name="Body">Message&#39;s body (required).</param>
    /// <param name="Mentions">Message&#39;s mentions.</param>
    /// <param name="Edited">If message was edited.</param>
    /// <param name="AttachmentDeleted">If message&#39;s attachment was deleted.</param>
    /// <param name="FileUri">URI of file attachment.</param>
    /// <param name="Thread">The id for a thread this message corresponds to (required).</param>
    /// <param name="ParentThread">Parent thread id for thread replies.</param>
    /// <param name="User">The user who sent the message.</param>
    /// <param name="ToUser">The receiving user of the message.</param>
    /// <param name="Reactions">The emoji reactions to this message.</param>
    public ChatMessageResponse(string Id = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ToJid = null, string Jid = null, string Body = null, Dictionary<string, string> Mentions = null, bool? Edited = null, bool? AttachmentDeleted = null, string FileUri = null, Entity Thread = null, Entity ParentThread = null, AddressableEntityRef User = null, AddressableEntityRef ToUser = null, List<ChatReaction> Reactions = null)
    {
        this.Id = Id;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.ToJid = ToJid;
        this.Jid = Jid;
        this.Body = Body;
        this.Mentions = Mentions;
        this.Edited = Edited;
        this.AttachmentDeleted = AttachmentDeleted;
        this.FileUri = FileUri;
        this.Thread = Thread;
        this.ParentThread = ParentThread;
        this.User = User;
        this.ToUser = ToUser;
        this.Reactions = Reactions;

    }



    /// <summary>
    /// The id of the message
    /// </summary>
    /// <value>The id of the message</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Message&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Message&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Message&#39;s last updated time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Message&#39;s last updated time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Jid of message&#39;s recipient (roomJid or userJid)
    /// </summary>
    /// <value>Jid of message&#39;s recipient (roomJid or userJid)</value>
    [JsonPropertyName("toJid")]
    public string ToJid { get; set; }



    /// <summary>
    /// Jid of message&#39;s sender (userJid)
    /// </summary>
    /// <value>Jid of message&#39;s sender (userJid)</value>
    [JsonPropertyName("jid")]
    public string Jid { get; set; }



    /// <summary>
    /// Message&#39;s body
    /// </summary>
    /// <value>Message&#39;s body</value>
    [JsonPropertyName("body")]
    public string Body { get; set; }



    /// <summary>
    /// Message&#39;s mentions
    /// </summary>
    /// <value>Message&#39;s mentions</value>
    [JsonPropertyName("mentions")]
    public Dictionary<string, string> Mentions { get; set; }



    /// <summary>
    /// If message was edited
    /// </summary>
    /// <value>If message was edited</value>
    [JsonPropertyName("edited")]
    public bool? Edited { get; set; }



    /// <summary>
    /// If message&#39;s attachment was deleted
    /// </summary>
    /// <value>If message&#39;s attachment was deleted</value>
    [JsonPropertyName("attachmentDeleted")]
    public bool? AttachmentDeleted { get; set; }



    /// <summary>
    /// URI of file attachment
    /// </summary>
    /// <value>URI of file attachment</value>
    [JsonPropertyName("fileUri")]
    public string FileUri { get; set; }



    /// <summary>
    /// The id for a thread this message corresponds to
    /// </summary>
    /// <value>The id for a thread this message corresponds to</value>
    [JsonPropertyName("thread")]
    public Entity Thread { get; set; }



    /// <summary>
    /// Parent thread id for thread replies
    /// </summary>
    /// <value>Parent thread id for thread replies</value>
    [JsonPropertyName("parentThread")]
    public Entity ParentThread { get; set; }



    /// <summary>
    /// The user who sent the message
    /// </summary>
    /// <value>The user who sent the message</value>
    [JsonPropertyName("user")]
    public AddressableEntityRef User { get; set; }



    /// <summary>
    /// The receiving user of the message
    /// </summary>
    /// <value>The receiving user of the message</value>
    [JsonPropertyName("toUser")]
    public AddressableEntityRef ToUser { get; set; }



    /// <summary>
    /// The emoji reactions to this message
    /// </summary>
    /// <value>The emoji reactions to this message</value>
    [JsonPropertyName("reactions")]
    public List<ChatReaction> Reactions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatMessageResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ToJid: ").Append(ToJid).Append("\n");
        sb.Append("  Jid: ").Append(Jid).Append("\n");
        sb.Append("  Body: ").Append(Body).Append("\n");
        sb.Append("  Mentions: ").Append(Mentions).Append("\n");
        sb.Append("  Edited: ").Append(Edited).Append("\n");
        sb.Append("  AttachmentDeleted: ").Append(AttachmentDeleted).Append("\n");
        sb.Append("  FileUri: ").Append(FileUri).Append("\n");
        sb.Append("  Thread: ").Append(Thread).Append("\n");
        sb.Append("  ParentThread: ").Append(ParentThread).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  ToUser: ").Append(ToUser).Append("\n");
        sb.Append("  Reactions: ").Append(Reactions).Append("\n");
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
        return Equals(obj as ChatMessageResponse);
    }

    /// <summary>
    /// Returns true if ChatMessageResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatMessageResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatMessageResponse other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                ToJid == other.ToJid ||
                ToJid != null &&
                ToJid.Equals(other.ToJid)
            ) &&
            (
                Jid == other.Jid ||
                Jid != null &&
                Jid.Equals(other.Jid)
            ) &&
            (
                Body == other.Body ||
                Body != null &&
                Body.Equals(other.Body)
            ) &&
            (
                Mentions == other.Mentions ||
                Mentions != null &&
                Mentions.SequenceEqual(other.Mentions)
            ) &&
            (
                Edited == other.Edited ||
                Edited != null &&
                Edited.Equals(other.Edited)
            ) &&
            (
                AttachmentDeleted == other.AttachmentDeleted ||
                AttachmentDeleted != null &&
                AttachmentDeleted.Equals(other.AttachmentDeleted)
            ) &&
            (
                FileUri == other.FileUri ||
                FileUri != null &&
                FileUri.Equals(other.FileUri)
            ) &&
            (
                Thread == other.Thread ||
                Thread != null &&
                Thread.Equals(other.Thread)
            ) &&
            (
                ParentThread == other.ParentThread ||
                ParentThread != null &&
                ParentThread.Equals(other.ParentThread)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                ToUser == other.ToUser ||
                ToUser != null &&
                ToUser.Equals(other.ToUser)
            ) &&
            (
                Reactions == other.Reactions ||
                Reactions != null &&
                Reactions.SequenceEqual(other.Reactions)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ToJid != null)
            {
                hash = hash * 59 + ToJid.GetHashCode();
            }

            if (Jid != null)
            {
                hash = hash * 59 + Jid.GetHashCode();
            }

            if (Body != null)
            {
                hash = hash * 59 + Body.GetHashCode();
            }

            if (Mentions != null)
            {
                hash = hash * 59 + Mentions.GetHashCode();
            }

            if (Edited != null)
            {
                hash = hash * 59 + Edited.GetHashCode();
            }

            if (AttachmentDeleted != null)
            {
                hash = hash * 59 + AttachmentDeleted.GetHashCode();
            }

            if (FileUri != null)
            {
                hash = hash * 59 + FileUri.GetHashCode();
            }

            if (Thread != null)
            {
                hash = hash * 59 + Thread.GetHashCode();
            }

            if (ParentThread != null)
            {
                hash = hash * 59 + ParentThread.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (ToUser != null)
            {
                hash = hash * 59 + ToUser.GetHashCode();
            }

            if (Reactions != null)
            {
                hash = hash * 59 + Reactions.GetHashCode();
            }

            return hash;
        }
    }
}
