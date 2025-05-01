using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about the workflow.
/// </summary>
[DataContract]
public partial class QueueConversationVideoEventTopicWorkflow : IEquatable<QueueConversationVideoEventTopicWorkflow>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicWorkflow" /> class.
    /// </summary>
    /// <param name="WorkflowId">The id of the workflow.</param>
    public QueueConversationVideoEventTopicWorkflow(string WorkflowId = null)
    {
        this.WorkflowId = WorkflowId;

    }



    /// <summary>
    /// The id of the workflow
    /// </summary>
    /// <value>The id of the workflow</value>
    [DataMember(Name = "workflowId", EmitDefaultValue = false)]
    public string WorkflowId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicWorkflow {\n");

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
        return Equals(obj as QueueConversationVideoEventTopicWorkflow);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicWorkflow instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicWorkflow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicWorkflow other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WorkflowId == other.WorkflowId ||
                WorkflowId != null &&
                WorkflowId.Equals(other.WorkflowId)
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
            if (WorkflowId != null)
            {
                hash = hash * 59 + WorkflowId.GetHashCode();
            }

            return hash;
        }
    }
}
