using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationEventTopicScoredAgent
/// </summary>
[DataContract]
public partial class QueueConversationEventTopicScoredAgent : IEquatable<QueueConversationEventTopicScoredAgent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationEventTopicScoredAgent" /> class.
    /// </summary>
    /// <param name="Agent">A UriReference for a resource.</param>
    /// <param name="Score">Agent&#39;s score for the current conversation, from 0 - 100, higher being better.</param>
    public QueueConversationEventTopicScoredAgent(QueueConversationEventTopicUriReference Agent = null, long? Score = null)
    {
        this.Agent = Agent;
        this.Score = Score;

    }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [DataMember(Name = "agent", EmitDefaultValue = false)]
    public QueueConversationEventTopicUriReference Agent { get; set; }



    /// <summary>
    /// Agent&#39;s score for the current conversation, from 0 - 100, higher being better
    /// </summary>
    /// <value>Agent&#39;s score for the current conversation, from 0 - 100, higher being better</value>
    [DataMember(Name = "score", EmitDefaultValue = false)]
    public long? Score { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationEventTopicScoredAgent {\n");

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
        return Equals(obj as QueueConversationEventTopicScoredAgent);
    }

    /// <summary>
    /// Returns true if QueueConversationEventTopicScoredAgent instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationEventTopicScoredAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationEventTopicScoredAgent other)
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
