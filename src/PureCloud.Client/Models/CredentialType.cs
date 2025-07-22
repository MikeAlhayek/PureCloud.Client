using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CredentialType
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
    /// Properties describing credentials of this type.
    /// </summary>
    /// <value>Properties describing credentials of this type.</value>
    public object Properties { get; set; }

    /// <summary>
    /// Order in which properties should be displayed in the UI.
    /// </summary>
    /// <value>Order in which properties should be displayed in the UI.</value>
    public IEnumerable<string> DisplayOrder { get; set; }

    /// <summary>
    /// Properties that are required fields.
    /// </summary>
    /// <value>Properties that are required fields.</value>
    public IEnumerable<string> Required { get; set; }
}
