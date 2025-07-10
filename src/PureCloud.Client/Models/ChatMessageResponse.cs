using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ChatMessageResponse
{
    /// <summary>
    /// The id of the message
    /// </summary>
    /// <value>The id of the message</value>
    public string Id { get; set; }

    /// <summary>
    /// Message&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Message&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Message&#39;s last updated time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Message&#39;s last updated time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Jid of message&#39;s recipient (roomJid or userJid)
    /// </summary>
    /// <value>Jid of message&#39;s recipient (roomJid or userJid)</value>
    public string ToJid { get; set; }

    /// <summary>
    /// Jid of message&#39;s sender (userJid)
    /// </summary>
    /// <value>Jid of message&#39;s sender (userJid)</value>
    public string Jid { get; set; }

    /// <summary>
    /// Message&#39;s body
    /// </summary>
    /// <value>Message&#39;s body</value>
    public string Body { get; set; }

    /// <summary>
    /// Message&#39;s mentions
    /// </summary>
    /// <value>Message&#39;s mentions</value>
    public Dictionary<string, string> Mentions { get; set; }

    /// <summary>
    /// If message was edited
    /// </summary>
    /// <value>If message was edited</value>
    public bool? Edited { get; set; }

    /// <summary>
    /// If message&#39;s attachment was deleted
    /// </summary>
    /// <value>If message&#39;s attachment was deleted</value>
    public bool? AttachmentDeleted { get; set; }

    /// <summary>
    /// URI of file attachment
    /// </summary>
    /// <value>URI of file attachment</value>
    public string FileUri { get; set; }

    /// <summary>
    /// The id for a thread this message corresponds to
    /// </summary>
    /// <value>The id for a thread this message corresponds to</value>
    public Entity Thread { get; set; }

    /// <summary>
    /// Parent thread id for thread replies
    /// </summary>
    /// <value>Parent thread id for thread replies</value>
    public Entity ParentThread { get; set; }

    /// <summary>
    /// The user who sent the message
    /// </summary>
    /// <value>The user who sent the message</value>
    public AddressableEntityRef User { get; set; }

    /// <summary>
    /// The receiving user of the message
    /// </summary>
    /// <value>The receiving user of the message</value>
    public AddressableEntityRef ToUser { get; set; }

    /// <summary>
    /// The emoji reactions to this message
    /// </summary>
    /// <value>The emoji reactions to this message</value>
    public IEnumerable<ChatReaction> Reactions { get; set; }
}
