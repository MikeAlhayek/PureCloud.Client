using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class KnowledgeBaseWithDialectReference
{
    /// <summary>
    /// The dialect for the knowledge base.
    /// </summary>
    /// <value>The dialect for the knowledge base.</value>
    public KnowledgeBaseWithDialectReferenceLanguageCodeEnum? LanguageCode { get; set; }

    /// <summary>
    /// The globally unique identifier for the knowledge base.
    /// </summary>
    /// <value>The globally unique identifier for the knowledge base.</value>
    public string Id { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
