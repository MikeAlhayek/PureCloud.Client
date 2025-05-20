using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationSummaryTopicConversationWrapUpCode
{
    /// <summary>
    /// Gets or Sets WrapUpCodeId
    /// </summary>
    public string WrapUpCodeId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    public double? Score { get; set; }
}
