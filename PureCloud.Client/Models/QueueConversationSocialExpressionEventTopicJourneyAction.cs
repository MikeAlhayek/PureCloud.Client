using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A subset of the Journey System&#39;s action data relevant to a part of a conversation (for external linkage and internal usage/context)
/// </summary>

public partial class QueueConversationSocialExpressionEventTopicJourneyAction : IEquatable<QueueConversationSocialExpressionEventTopicJourneyAction>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicJourneyAction" /> class.
    /// </summary>
    /// <param name="Id">The ID of an action from the Journey System (an action is spawned from an actionMap).</param>
    /// <param name="ActionMap">ActionMap.</param>
    public QueueConversationSocialExpressionEventTopicJourneyAction(string Id = null, QueueConversationSocialExpressionEventTopicJourneyActionMap ActionMap = null)
    {
        this.Id = Id;
        this.ActionMap = ActionMap;

    }



    /// <summary>
    /// The ID of an action from the Journey System (an action is spawned from an actionMap)
    /// </summary>
    /// <value>The ID of an action from the Journey System (an action is spawned from an actionMap)</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets ActionMap
    /// </summary>
    [JsonPropertyName("actionMap")]
    public QueueConversationSocialExpressionEventTopicJourneyActionMap ActionMap { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationSocialExpressionEventTopicJourneyAction {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
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
        return Equals(obj as QueueConversationSocialExpressionEventTopicJourneyAction);
    }

    /// <summary>
    /// Returns true if QueueConversationSocialExpressionEventTopicJourneyAction instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationSocialExpressionEventTopicJourneyAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationSocialExpressionEventTopicJourneyAction other)
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
                ActionMap == other.ActionMap ||
                ActionMap != null &&
                ActionMap.Equals(other.ActionMap)
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

            if (ActionMap != null)
            {
                hash = hash * 59 + ActionMap.GetHashCode();
            }

            return hash;
        }
    }
}
