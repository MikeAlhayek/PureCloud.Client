using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NluDomain
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the NLU domain.
    /// </summary>
    /// <value>The name of the NLU domain.</value>
    public string Name { get; set; }

    /// <summary>
    /// The language culture of the NLU domain, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;.
    /// </summary>
    /// <value>The language culture of the NLU domain, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;.</value>
    public string Language { get; set; }

    /// <summary>
    /// The draft version of that NLU domain.
    /// </summary>
    /// <value>The draft version of that NLU domain.</value>
    public NluDomainVersion DraftVersion { get; set; }

    /// <summary>
    /// The last published version of that NLU domain.
    /// </summary>
    /// <value>The last published version of that NLU domain.</value>
    public NluDomainVersion LastPublishedVersion { get; set; }

    /// <summary>
    /// The date when the NLU domain was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The date when the NLU domain was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The version of the NLU engine to use.
    /// </summary>
    /// <value>The version of the NLU engine to use.</value>
    public string EngineVersion { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
