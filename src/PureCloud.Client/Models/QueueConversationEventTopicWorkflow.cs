using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about the workflow.
/// </summary>

public partial class QueueConversationEventTopicWorkflow : IEquatable<QueueConversationEventTopicWorkflow>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationEventTopicWorkflow" /> class.
    /// </summary>
    /// <param name="WorkflowId">The id of the workflow.</param>
    public QueueConversationEventTopicWorkflow(string WorkflowId = null)
    {
        this.WorkflowId = WorkflowId;

    }



    /// <summary>
    /// The id of the workflow
    /// </summary>
    /// <value>The id of the workflow</value>
    [JsonPropertyName("workflowId")]
    public string WorkflowId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationEventTopicWorkflow {\n");

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
        return Equals(obj as QueueConversationEventTopicWorkflow);
    }

    /// <summary>
    /// Returns true if QueueConversationEventTopicWorkflow instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationEventTopicWorkflow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationEventTopicWorkflow other)
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
