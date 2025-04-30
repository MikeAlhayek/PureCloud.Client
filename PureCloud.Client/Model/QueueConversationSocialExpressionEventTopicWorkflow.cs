using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Information about the workflow.
    /// </summary>
    [DataContract]
    public partial class QueueConversationSocialExpressionEventTopicWorkflow :  IEquatable<QueueConversationSocialExpressionEventTopicWorkflow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicWorkflow" /> class.
        /// </summary>
        /// <param name="WorkflowId">The id of the workflow.</param>
        public QueueConversationSocialExpressionEventTopicWorkflow(string WorkflowId = null)
        {
            this.WorkflowId = WorkflowId;
            
        }
        


        /// <summary>
        /// The id of the workflow
        /// </summary>
        /// <value>The id of the workflow</value>
        [DataMember(Name="workflowId", EmitDefaultValue=false)]
        public string WorkflowId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationSocialExpressionEventTopicWorkflow {\n");

            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
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
            return this.Equals(obj as QueueConversationSocialExpressionEventTopicWorkflow);
        }

        /// <summary>
        /// Returns true if QueueConversationSocialExpressionEventTopicWorkflow instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationSocialExpressionEventTopicWorkflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationSocialExpressionEventTopicWorkflow other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WorkflowId == other.WorkflowId ||
                    this.WorkflowId != null &&
                    this.WorkflowId.Equals(other.WorkflowId)
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
                if (this.WorkflowId != null)
                    hash = hash * 59 + this.WorkflowId.GetHashCode();

                return hash;
            }
        }
    }

}
