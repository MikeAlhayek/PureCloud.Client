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
    /// Metadata information about a message.
    /// </summary>
    [DataContract]
    public partial class QueueConversationSocialExpressionEventTopicMessageMetadata :  IEquatable<QueueConversationSocialExpressionEventTopicMessageMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicMessageMetadata" /> class.
        /// </summary>
        /// <param name="Type">Message type..</param>
        /// <param name="Events">List of message events, if any.</param>
        /// <param name="Content">List of message content, if any.</param>
        public QueueConversationSocialExpressionEventTopicMessageMetadata(string Type = null, List<QueueConversationSocialExpressionEventTopicMessageMetadataEvent> Events = null, List<QueueConversationSocialExpressionEventTopicMessageMetadataContent> Content = null)
        {
            this.Type = Type;
            this.Events = Events;
            this.Content = Content;
            
        }
        


        /// <summary>
        /// Message type.
        /// </summary>
        /// <value>Message type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// List of message events, if any
        /// </summary>
        /// <value>List of message events, if any</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<QueueConversationSocialExpressionEventTopicMessageMetadataEvent> Events { get; set; }



        /// <summary>
        /// List of message content, if any
        /// </summary>
        /// <value>List of message content, if any</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<QueueConversationSocialExpressionEventTopicMessageMetadataContent> Content { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationSocialExpressionEventTopicMessageMetadata {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(obj as QueueConversationSocialExpressionEventTopicMessageMetadata);
        }

        /// <summary>
        /// Returns true if QueueConversationSocialExpressionEventTopicMessageMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationSocialExpressionEventTopicMessageMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationSocialExpressionEventTopicMessageMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Events == other.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(other.Events)
                ) &&
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(other.Content)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Events != null)
                    hash = hash * 59 + this.Events.GetHashCode();

                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                return hash;
            }
        }
    }

}
