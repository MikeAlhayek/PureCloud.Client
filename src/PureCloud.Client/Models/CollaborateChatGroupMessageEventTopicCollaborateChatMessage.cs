using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CollaborateChatGroupMessageEventTopicCollaborateChatMessage
/// </summary>

public partial class CollaborateChatGroupMessageEventTopicCollaborateChatMessage : IEquatable<CollaborateChatGroupMessageEventTopicCollaborateChatMessage>
{
    /// <summary>
    /// Gets or Sets ActionType
    /// </summary>
    
    public enum ActionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Create for "Create"
        /// </summary>
        [EnumMember(Value = "Create")]
        Create,

        /// <summary>
        /// Enum Edit for "Edit"
        /// </summary>
        [EnumMember(Value = "Edit")]
        Edit,

        /// <summary>
        /// Enum Delete for "Delete"
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete
    }
    /// <summary>
    /// Gets or Sets ActionType
    /// </summary>
    [JsonPropertyName("actionType")]
    public ActionTypeEnum? ActionType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CollaborateChatGroupMessageEventTopicCollaborateChatMessage" /> class.
    /// </summary>
    /// <param name="MessageId">MessageId.</param>
    /// <param name="Created">Created.</param>
    /// <param name="ActionType">ActionType.</param>
    /// <param name="Body">Body.</param>
    /// <param name="From">From.</param>
    /// <param name="To">To.</param>
    /// <param name="Mentions">Mentions.</param>
    /// <param name="NotifyAll">NotifyAll.</param>
    /// <param name="Reactions">Reactions.</param>
    public CollaborateChatGroupMessageEventTopicCollaborateChatMessage(string MessageId = null, string Created = null, ActionTypeEnum? ActionType = null, string Body = null, CollaborateChatGroupMessageEventTopicCollaborateChatEntity From = null, CollaborateChatGroupMessageEventTopicCollaborateChatEntity To = null, List<CollaborateChatGroupMessageEventTopicCollaborateChatEntity> Mentions = null, bool? NotifyAll = null, Dictionary<string, List<string>> Reactions = null)
    {
        this.MessageId = MessageId;
        this.Created = Created;
        this.ActionType = ActionType;
        this.Body = Body;
        this.From = From;
        this.To = To;
        this.Mentions = Mentions;
        this.NotifyAll = NotifyAll;
        this.Reactions = Reactions;

    }



    /// <summary>
    /// Gets or Sets MessageId
    /// </summary>
    [JsonPropertyName("messageId")]
    public string MessageId { get; set; }



    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [JsonPropertyName("created")]
    public string Created { get; set; }





    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    [JsonPropertyName("body")]
    public string Body { get; set; }



    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [JsonPropertyName("from")]
    public CollaborateChatGroupMessageEventTopicCollaborateChatEntity From { get; set; }



    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [JsonPropertyName("to")]
    public CollaborateChatGroupMessageEventTopicCollaborateChatEntity To { get; set; }



    /// <summary>
    /// Gets or Sets Mentions
    /// </summary>
    [JsonPropertyName("mentions")]
    public List<CollaborateChatGroupMessageEventTopicCollaborateChatEntity> Mentions { get; set; }



    /// <summary>
    /// Gets or Sets NotifyAll
    /// </summary>
    [JsonPropertyName("notifyAll")]
    public bool? NotifyAll { get; set; }



    /// <summary>
    /// Gets or Sets Reactions
    /// </summary>
    [JsonPropertyName("reactions")]
    public Dictionary<string, List<string>> Reactions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CollaborateChatGroupMessageEventTopicCollaborateChatMessage {\n");

        sb.Append("  MessageId: ").Append(MessageId).Append("\n");
        sb.Append("  Created: ").Append(Created).Append("\n");
        sb.Append("  ActionType: ").Append(ActionType).Append("\n");
        sb.Append("  Body: ").Append(Body).Append("\n");
        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  Mentions: ").Append(Mentions).Append("\n");
        sb.Append("  NotifyAll: ").Append(NotifyAll).Append("\n");
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
        return Equals(obj as CollaborateChatGroupMessageEventTopicCollaborateChatMessage);
    }

    /// <summary>
    /// Returns true if CollaborateChatGroupMessageEventTopicCollaborateChatMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of CollaborateChatGroupMessageEventTopicCollaborateChatMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CollaborateChatGroupMessageEventTopicCollaborateChatMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MessageId == other.MessageId ||
                MessageId != null &&
                MessageId.Equals(other.MessageId)
            ) &&
            (
                Created == other.Created ||
                Created != null &&
                Created.Equals(other.Created)
            ) &&
            (
                ActionType == other.ActionType ||
                ActionType != null &&
                ActionType.Equals(other.ActionType)
            ) &&
            (
                Body == other.Body ||
                Body != null &&
                Body.Equals(other.Body)
            ) &&
            (
                From == other.From ||
                From != null &&
                From.Equals(other.From)
            ) &&
            (
                To == other.To ||
                To != null &&
                To.Equals(other.To)
            ) &&
            (
                Mentions == other.Mentions ||
                Mentions != null &&
                Mentions.SequenceEqual(other.Mentions)
            ) &&
            (
                NotifyAll == other.NotifyAll ||
                NotifyAll != null &&
                NotifyAll.Equals(other.NotifyAll)
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
            if (MessageId != null)
            {
                hash = hash * 59 + MessageId.GetHashCode();
            }

            if (Created != null)
            {
                hash = hash * 59 + Created.GetHashCode();
            }

            if (ActionType != null)
            {
                hash = hash * 59 + ActionType.GetHashCode();
            }

            if (Body != null)
            {
                hash = hash * 59 + Body.GetHashCode();
            }

            if (From != null)
            {
                hash = hash * 59 + From.GetHashCode();
            }

            if (To != null)
            {
                hash = hash * 59 + To.GetHashCode();
            }

            if (Mentions != null)
            {
                hash = hash * 59 + Mentions.GetHashCode();
            }

            if (NotifyAll != null)
            {
                hash = hash * 59 + NotifyAll.GetHashCode();
            }

            if (Reactions != null)
            {
                hash = hash * 59 + Reactions.GetHashCode();
            }

            return hash;
        }
    }
}
