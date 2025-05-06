using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class QueueConversationEventTopicWorkflow
{
    /// <summary>
    /// The id of the workflow
    /// </summary>
    /// <value>The id of the workflow</value>
    public string WorkflowId { get; set; }
}
