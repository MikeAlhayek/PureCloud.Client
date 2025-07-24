using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class CreateResponseAssetRequest
{
    /// <summary>
    /// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|
    /// </summary>
    /// <value>Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|</value>
    public string Name { get; set; }

    /// <summary>
    /// Division to associate to this asset. Can only be used with this division.
    /// </summary>
    /// <value>Division to associate to this asset. Can only be used with this division.</value>
    public string DivisionId { get; set; }

    /// <summary>
    /// Content MD-5 of the file to upload
    /// </summary>
    /// <value>Content MD-5 of the file to upload</value>
    public string ContentMd5 { get; set; }
}
