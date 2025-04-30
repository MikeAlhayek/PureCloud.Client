using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// QueueConversationEventTopicMessageMetadataContent
    /// </summary>
    [DataContract]
    public partial class QueueConversationEventTopicMessageMetadataContent :  IEquatable<QueueConversationEventTopicMessageMetadataContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationEventTopicMessageMetadataContent" /> class.
        /// </summary>
        /// <param name="ContentType">Type of this content element..</param>
        /// <param name="SubType">Content subtype, if any.</param>
        public QueueConversationEventTopicMessageMetadataContent(string ContentType = null, string SubType = null)
        {
            this.ContentType = ContentType;
            this.SubType = SubType;
            
        }
        


        /// <summary>
        /// Type of this content element.
        /// </summary>
        /// <value>Type of this content element.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }



        /// <summary>
        /// Content subtype, if any
        /// </summary>
        /// <value>Content subtype, if any</value>
        [DataMember(Name="subType", EmitDefaultValue=false)]
        public string SubType { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationEventTopicMessageMetadataContent {\n");

            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
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
            return this.Equals(obj as QueueConversationEventTopicMessageMetadataContent);
        }

        /// <summary>
        /// Returns true if QueueConversationEventTopicMessageMetadataContent instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationEventTopicMessageMetadataContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationEventTopicMessageMetadataContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.SubType == other.SubType ||
                    this.SubType != null &&
                    this.SubType.Equals(other.SubType)
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
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.SubType != null)
                    hash = hash * 59 + this.SubType.GetHashCode();

                return hash;
            }
        }
    }

}
