using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationMessageEventTopicScoredAgent
/// </summary>

public partial class QueueConversationMessageEventTopicScoredAgent : IEquatable<QueueConversationMessageEventTopicScoredAgent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationMessageEventTopicScoredAgent" /> class.
    /// </summary>
    /// <param name="Agent">A UriReference for a resource.</param>
    /// <param name="Score">Agent&#39;s score for the current conversation, from 0 - 100, higher being better.</param>
    public QueueConversationMessageEventTopicScoredAgent(QueueConversationMessageEventTopicUriReference Agent = null, long? Score = null)
    {
        this.Agent = Agent;
        this.Score = Score;

    }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("agent")]
    public QueueConversationMessageEventTopicUriReference Agent { get; set; }



    /// <summary>
    /// Agent&#39;s score for the current conversation, from 0 - 100, higher being better
    /// </summary>
    /// <value>Agent&#39;s score for the current conversation, from 0 - 100, higher being better</value>
    [JsonPropertyName("score")]
    public long? Score { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationMessageEventTopicScoredAgent {\n");

        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  Score: ").Append(Score).Append("\n");
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
        return Equals(obj as QueueConversationMessageEventTopicScoredAgent);
    }

    /// <summary>
    /// Returns true if QueueConversationMessageEventTopicScoredAgent instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationMessageEventTopicScoredAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationMessageEventTopicScoredAgent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                Score == other.Score ||
                Score != null &&
                Score.Equals(other.Score)
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
            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            return hash;
        }
    }
}
