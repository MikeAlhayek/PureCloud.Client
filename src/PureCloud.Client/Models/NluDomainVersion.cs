using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NluDomainVersion
{
    /// <summary>
    /// The training status of the NLU domain version.
    /// </summary>
    /// <value>The training status of the NLU domain version.</value>
    public NluDomainVersionTrainingStatusEnum? TrainingStatus { get; set; }

    /// <summary>
    /// The evaluation status of the NLU domain version.
    /// </summary>
    /// <value>The evaluation status of the NLU domain version.</value>
    public NluDomainVersionEvaluationStatusEnum? EvaluationStatus { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The NLU domain of the version.
    /// </summary>
    /// <value>The NLU domain of the version.</value>
    public NluDomain Domain { get; set; }

    /// <summary>
    /// The description of the NLU domain version.
    /// </summary>
    /// <value>The description of the NLU domain version.</value>
    public string Description { get; set; }

    /// <summary>
    /// The language that the NLU domain version supports.
    /// </summary>
    /// <value>The language that the NLU domain version supports.</value>
    public string Language { get; set; }

    /// <summary>
    /// Whether this NLU domain version has been published.
    /// </summary>
    /// <value>Whether this NLU domain version has been published.</value>
    public bool? Published { get; set; }

    /// <summary>
    /// The date when the NLU domain version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The date when the NLU domain version was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain version was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The date when the NLU domain version was trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain version was trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateTrained { get; set; }

    /// <summary>
    /// The date when the NLU domain version was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain version was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DatePublished { get; set; }

    /// <summary>
    /// The intents defined for this NLU domain version.
    /// </summary>
    /// <value>The intents defined for this NLU domain version.</value>
    public IEnumerable<IntentDefinition> Intents { get; set; }

    /// <summary>
    /// The entity types defined for this NLU domain version.
    /// </summary>
    /// <value>The entity types defined for this NLU domain version.</value>
    public IEnumerable<NamedEntityTypeDefinition> EntityTypes { get; set; }

    /// <summary>
    /// The entities defined for this NLU domain version.This field is mutually exclusive with entityTypeBindings
    /// </summary>
    /// <value>The entities defined for this NLU domain version.This field is mutually exclusive with entityTypeBindings</value>
    public IEnumerable<NamedEntityDefinition> Entities { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
