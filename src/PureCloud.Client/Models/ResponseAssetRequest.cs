using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ResponseAssetRequest
/// </summary>

public partial class ResponseAssetRequest : IEquatable<ResponseAssetRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseAssetRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ResponseAssetRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseAssetRequest" /> class.
    /// </summary>
    /// <param name="Name">Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#| (required).</param>
    /// <param name="DivisionId">Division to associate to this asset. Can only be used with this division..</param>
    public ResponseAssetRequest(string Name = null, string DivisionId = null)
    {
        this.Name = Name;
        this.DivisionId = DivisionId;

    }



    /// <summary>
    /// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|
    /// </summary>
    /// <value>Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Division to associate to this asset. Can only be used with this division.
    /// </summary>
    /// <value>Division to associate to this asset. Can only be used with this division.</value>
    [JsonPropertyName("divisionId")]
    public string DivisionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResponseAssetRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
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
        return Equals(obj as ResponseAssetRequest);
    }

    /// <summary>
    /// Returns true if ResponseAssetRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ResponseAssetRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResponseAssetRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            return hash;
        }
    }
}
