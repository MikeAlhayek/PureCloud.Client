using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM PATCH request. See section 3.5.2 \&quot;Modifying with PATCH\&quot; in RFC 7644 for details.
/// </summary>

public partial class ScimV2PatchRequest : IEquatable<ScimV2PatchRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2PatchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScimV2PatchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2PatchRequest" /> class.
    /// </summary>
    /// <param name="Schemas">The list of schemas used in the PATCH request. (required).</param>
    /// <param name="Operations">The list of operations to perform for the PATCH request..</param>
    public ScimV2PatchRequest(List<string> Schemas = null, List<ScimV2PatchOperation> Operations = null)
    {
        this.Schemas = Schemas;
        this.Operations = Operations;

    }



    /// <summary>
    /// The list of schemas used in the PATCH request.
    /// </summary>
    /// <value>The list of schemas used in the PATCH request.</value>
    [JsonPropertyName("schemas")]
    public List<string> Schemas { get; set; }



    /// <summary>
    /// The list of operations to perform for the PATCH request.
    /// </summary>
    /// <value>The list of operations to perform for the PATCH request.</value>
    [JsonPropertyName("Operations")]
    public List<ScimV2PatchOperation> Operations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimV2PatchRequest {\n");

        sb.Append("  Schemas: ").Append(Schemas).Append("\n");
        sb.Append("  Operations: ").Append(Operations).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as ScimV2PatchRequest);
    }

    /// <summary>
    /// Returns true if ScimV2PatchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2PatchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimV2PatchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Schemas == other.Schemas ||
                Schemas != null &&
                Schemas.SequenceEqual(other.Schemas)
            ) &&
            (
                Operations == other.Operations ||
                Operations != null &&
                Operations.SequenceEqual(other.Operations)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Schemas != null)
            {
                hash = hash * 59 + Schemas.GetHashCode();
            }

            if (Operations != null)
            {
                hash = hash * 59 + Operations.GetHashCode();
            }

            return hash;
        }
    }
}
