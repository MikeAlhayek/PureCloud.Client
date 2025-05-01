using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateResponseAssetResponse
/// </summary>
[DataContract]
public partial class CreateResponseAssetResponse : IEquatable<CreateResponseAssetResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateResponseAssetResponse" /> class.
    /// </summary>
    public CreateResponseAssetResponse()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Pre-signed URL to PUT the file to
    /// </summary>
    /// <value>Pre-signed URL to PUT the file to</value>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; private set; }



    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL</value>
    [DataMember(Name = "headers", EmitDefaultValue = false)]
    public Dictionary<string, string> Headers { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateResponseAssetResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
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
        return Equals(obj as CreateResponseAssetResponse);
    }

    /// <summary>
    /// Returns true if CreateResponseAssetResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateResponseAssetResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateResponseAssetResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                Headers == other.Headers ||
                Headers != null &&
                Headers.SequenceEqual(other.Headers)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            return hash;
        }
    }
}
