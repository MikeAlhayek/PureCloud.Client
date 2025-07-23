using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// Library
/// </summary>
public sealed class Library
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The library name.
    /// </summary>
    /// <value>The library name.</value>
    public string Name { get; set; }

    /// <summary>
    /// Current version for this resource.
    /// </summary>
    /// <value>Current version for this resource.</value>
    public int? Version { get; set; }

    /// <summary>
    /// User that created the library.
    /// </summary>
    /// <value>User that created the library.</value>
    public User CreatedBy { get; set; }

    /// <summary>
    /// The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// This value is deprecated. Responses representing message templates may be added to any library.
    /// </summary>
    /// <value>This value is deprecated. Responses representing message templates may be added to any library.</value>
    public LibraryResponseType? ResponseType { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}