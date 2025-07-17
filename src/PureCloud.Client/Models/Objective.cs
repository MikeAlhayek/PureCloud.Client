using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Objective
{
    /// <summary>
    /// A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".
    /// </summary>
    /// <value>A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".</value>
    public ObjectiveTopicIdsFilterTypeEnum? TopicIdsFilterType { get; set; }

    /// <summary>
    /// The initial direction to filter on
    /// </summary>
    /// <value>The initial direction to filter on</value>
    public ObjectiveInitialDirectionEnum? InitialDirection { get; set; }

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
    public IEnumerable<ObjectiveMediaTypesEnum> MediaTypes { get; set; }

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

    /// <summary>
    /// start date of the objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>start date of the objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStart { get; set; }
}
