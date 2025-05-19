using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationCobrowseEventTopicScoredAgent
{
    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public ConversationCobrowseEventTopicUriReference Agent { get; set; }

    /// <summary>
    /// Agent&#39;s score for the current conversation, from 0 - 100, higher being better
    /// </summary>
    /// <value>Agent&#39;s score for the current conversation, from 0 - 100, higher being better</value>
    public long? Score { get; set; }
}
