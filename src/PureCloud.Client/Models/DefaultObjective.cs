using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DefaultObjective
{
    /// <summary>
    /// A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".
    /// </summary>
    /// <value>A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".</value>
    public DefaultObjectiveTopicIdsFilterTypeEnum? TopicIdsFilterType { get; set; }

    /// <summary>
    /// The initial direction to filter on
    /// </summary>
    /// <value>The initial direction to filter on</value>
    public DefaultObjectiveInitialDirectionEnum? InitialDirection { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The id of this objective&#39;s base template
    /// </summary>
    /// <value>The id of this objective&#39;s base template</value>
    public string TemplateId { get; set; }

    /// <summary>
    /// Objective zone specifies min,max points and values for the associated metric
    /// </summary>
    /// <value>Objective zone specifies min,max points and values for the associated metric</value>
    public IEnumerable<ObjectiveZone> Zones { get; set; }

    /// <summary>
    /// A flag for whether this objective is enabled for the related metric
    /// </summary>
    /// <value>A flag for whether this objective is enabled for the related metric</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// A list of media types for the metric
    /// </summary>
    /// <value>A list of media types for the metric</value>
    public IEnumerable<DefaultObjectiveMediaTypesEnum> MediaTypes { get; set; }

    /// <summary>
    /// A list of queues for the metric
    /// </summary>
    /// <value>A list of queues for the metric</value>
    public IEnumerable<AddressableEntityRef> Queues { get; set; }

    /// <summary>
    /// A list of topic ids for detected topic metrics
    /// </summary>
    /// <value>A list of topic ids for detected topic metrics</value>
    public IEnumerable<AddressableEntityRef> Topics { get; set; }

    /// <summary>
    /// The ids of associated evaluation form context, for Quality Evaluation Score metrics
    /// </summary>
    /// <value>The ids of associated evaluation form context, for Quality Evaluation Score metrics</value>
    public IEnumerable<string> EvaluationFormContextIds { get; set; }
}
