using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebChatRoutingTarget
{
    /// <summary>
    /// The target type of the routing target, such as 'QUEUE'.
    /// </summary>
    /// <value>The target type of the routing target, such as 'QUEUE'.</value>
    public WebChatRoutingTargetTargetTypeEnum? TargetType { get; set; }

    /// <summary>
    /// The target of the route, in the format appropriate given the &#39;targetType&#39;.
    /// </summary>
    /// <value>The target of the route, in the format appropriate given the &#39;targetType&#39;.</value>
    public string TargetAddress { get; set; }

    /// <summary>
    /// The list of skill names to use for routing.
    /// </summary>
    /// <value>The list of skill names to use for routing.</value>
    public IEnumerable<string> Skills { get; set; }

    /// <summary>
    /// The language name to use for routing.
    /// </summary>
    /// <value>The language name to use for routing.</value>
    public string Language { get; set; }

    /// <summary>
    /// The priority to assign to the conversation for routing.
    /// </summary>
    /// <value>The priority to assign to the conversation for routing.</value>
    public long? Priority { get; set; }
}
