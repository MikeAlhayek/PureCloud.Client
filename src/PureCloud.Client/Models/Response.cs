using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// Contains information about a response.
/// </summary>
public sealed class Response
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Version number required for updates.
    /// </summary>
    /// <value>Version number required for updates.</value>
    public int? Version { get; set; }

    /// <summary>
    /// One or more libraries response is associated with.
    /// </summary>
    /// <value>One or more libraries response is associated with.</value>
    public IEnumerable<DomainEntityRef> Libraries { get; set; }

    /// <summary>
    /// One or more texts associated with the response.
    /// </summary>
    /// <value>One or more texts associated with the response.</value>
    public IEnumerable<ResponseText> Texts { get; set; }

    /// <summary>
    /// User that created the response
    /// </summary>
    /// <value>User that created the response</value>
    public User CreatedBy { get; set; }

    /// <summary>
    /// The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The interaction type for this response.
    /// </summary>
    /// <value>The interaction type for this response.</value>
    public InteractionType? InteractionType { get; set; }

    /// <summary>
    /// Details about any text substitutions used in the texts for this response.
    /// </summary>
    /// <value>Details about any text substitutions used in the texts for this response.</value>
    public IEnumerable<ResponseSubstitution> Substitutions { get; set; }

    /// <summary>
    /// Metadata about the text substitutions in json schema format.
    /// </summary>
    /// <value>Metadata about the text substitutions in json schema format.</value>
    public JsonSchemaDocument SubstitutionsSchema { get; set; }

    /// <summary>
    /// The response type represented by the response.
    /// </summary>
    /// <value>The response type represented by the response.</value>
    public ResponseType? ResponseType { get; set; }

    /// <summary>
    /// Assets used in the response
    /// </summary>
    /// <value>Assets used in the response</value>
    public IEnumerable<AddressableEntityRef> Assets { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}