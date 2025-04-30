using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Information on how a communication should be routed to an agent.
    /// </summary>
    [DataContract]
    public partial class QueueConversationEventTopicConversationRoutingData :  IEquatable<QueueConversationEventTopicConversationRoutingData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEventTopicConversationRoutingData" /> class.
        /// </summary>
        /// <param name="Queue">Queue.</param>
        /// <param name="Language">A UriReference for a resource.</param>
        /// <param name="Priority">The priority of the conversation to use for routing decisions.</param>
        /// <param name="Skills">The skills to use for routing decisions.</param>
        /// <param name="ScoredAgents">A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents.</param>
        public QueueConversationEventTopicConversationRoutingData(QueueConversationEventTopicUriReference Queue = null, QueueConversationEventTopicUriReference Language = null, long? Priority = null, List<QueueConversationEventTopicUriReference> Skills = null, List<QueueConversationEventTopicScoredAgent> ScoredAgents = null)
        {
            this.Queue = Queue;
            this.Language = Language;
            this.Priority = Priority;
            this.Skills = Skills;
            this.ScoredAgents = ScoredAgents;
            
        }
        


        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public QueueConversationEventTopicUriReference Queue { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public QueueConversationEventTopicUriReference Language { get; set; }



        /// <summary>
        /// The priority of the conversation to use for routing decisions
        /// </summary>
        /// <value>The priority of the conversation to use for routing decisions</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public long? Priority { get; set; }



        /// <summary>
        /// The skills to use for routing decisions
        /// </summary>
        /// <value>The skills to use for routing decisions</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicUriReference> Skills { get; set; }



        /// <summary>
        /// A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents
        /// </summary>
        /// <value>A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents</value>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<QueueConversationEventTopicScoredAgent> ScoredAgents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationEventTopicConversationRoutingData {\n");

            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
            return this.Equals(obj as QueueConversationEventTopicConversationRoutingData);
        }

        /// <summary>
        /// Returns true if QueueConversationEventTopicConversationRoutingData instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationEventTopicConversationRoutingData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationEventTopicConversationRoutingData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
                ) &&
                (
                    this.ScoredAgents == other.ScoredAgents ||
                    this.ScoredAgents != null &&
                    this.ScoredAgents.SequenceEqual(other.ScoredAgents)
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
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();

                if (this.ScoredAgents != null)
                    hash = hash * 59 + this.ScoredAgents.GetHashCode();

                return hash;
            }
        }
    }

}
