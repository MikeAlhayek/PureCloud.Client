using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// OrganizationPresence
/// </summary>

public sealed class OrganizationPresence
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
    /// The label used for the system presence in each specified language
    /// </summary>
    /// <value>The label used for the system presence in each specified language</value>
    public Dictionary<string, string> LanguageLabels { get; set; }

    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    public string SystemPresence { get; set; }

    /// <summary>
    /// Gets or Sets Deactivated
    /// </summary>
    public bool? Deactivated { get; set; }

    /// <summary>
    /// Gets or Sets Primary
    /// </summary>
    public bool? Primary { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public User CreatedBy { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public User ModifiedBy { get; set; }

    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
