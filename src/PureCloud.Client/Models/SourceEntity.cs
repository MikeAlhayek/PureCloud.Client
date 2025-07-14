using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SourceEntity
{
    /// <summary>
    /// The type of the source entity
    /// </summary>
    /// <value>The type of the source entity</value>
    public SourceEntityTypeEnum? Type { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The contest data - Only supplied when celebration is of type ContestComplete
    /// </summary>
    /// <value>The contest data - Only supplied when celebration is of type ContestComplete</value>
    public ContestCompleteData ContestCompleteData { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }

}
