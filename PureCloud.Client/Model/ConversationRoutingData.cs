using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ConversationRoutingData
    /// </summary>
    [DataContract]
    public partial class ConversationRoutingData :  IEquatable<ConversationRoutingData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationRoutingData" /> class.
        /// </summary>
        /// <param name="Queue">The queue to use for routing decisions.</param>
        /// <param name="Language">The language to use for routing decisions.</param>
        /// <param name="Priority">The priority of the conversation to use for routing decisions.</param>
        /// <param name="Skills">The skills to use for routing decisions.</param>
        /// <param name="ScoredAgents">A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents.</param>
        /// <param name="Label">An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level.</param>
        public ConversationRoutingData(AddressableEntityRef Queue = null, AddressableEntityRef Language = null, int? Priority = null, List<AddressableEntityRef> Skills = null, List<ScoredAgent> ScoredAgents = null, string Label = null)
        {
            this.Queue = Queue;
            this.Language = Language;
            this.Priority = Priority;
            this.Skills = Skills;
            this.ScoredAgents = ScoredAgents;
            this.Label = Label;
            
        }
        


        /// <summary>
        /// The queue to use for routing decisions
        /// </summary>
        /// <value>The queue to use for routing decisions</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public AddressableEntityRef Queue { get; set; }



        /// <summary>
        /// The language to use for routing decisions
        /// </summary>
        /// <value>The language to use for routing decisions</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public AddressableEntityRef Language { get; set; }



        /// <summary>
        /// The priority of the conversation to use for routing decisions
        /// </summary>
        /// <value>The priority of the conversation to use for routing decisions</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }



        /// <summary>
        /// The skills to use for routing decisions
        /// </summary>
        /// <value>The skills to use for routing decisions</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Skills { get; set; }



        /// <summary>
        /// A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents
        /// </summary>
        /// <value>A collection of agents and their assigned scores for this conversation (0 - 100, higher being better), for use in routing to preferred agents</value>
        [DataMember(Name="scoredAgents", EmitDefaultValue=false)]
        public List<ScoredAgent> ScoredAgents { get; set; }



        /// <summary>
        /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
        /// </summary>
        /// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationRoutingData {\n");

            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConversationRoutingData);
        }

        /// <summary>
        /// Returns true if ConversationRoutingData instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationRoutingData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationRoutingData other)
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
                ) &&
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
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

                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();

                return hash;
            }
        }
    }

}
