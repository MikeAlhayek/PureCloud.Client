using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class KnowledgeAnswerConfig
{
    /// <summary>
    /// Knowledge answer is enabled.
    /// </summary>
    /// <value>Knowledge answer is enabled.</value>
    public bool? Enabled { get; set; }
}
