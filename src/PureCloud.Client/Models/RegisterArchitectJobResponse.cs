using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RegisterArchitectJobResponse
/// </summary>

public partial class RegisterArchitectJobResponse : IEquatable<RegisterArchitectJobResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegisterArchitectJobResponse" /> class.
    /// </summary>
    public RegisterArchitectJobResponse()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Presigned URL to upload the file in S3
    /// </summary>
    /// <value>Presigned URL to upload the file in S3</value>
    [JsonPropertyName("presignedUrl")]
    public string PresignedUrl { get; private set; }



    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL</value>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RegisterArchitectJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  PresignedUrl: ").Append(PresignedUrl).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as RegisterArchitectJobResponse);
    }

    /// <summary>
    /// Returns true if RegisterArchitectJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of RegisterArchitectJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RegisterArchitectJobResponse other)
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
                PresignedUrl == other.PresignedUrl ||
                PresignedUrl != null &&
                PresignedUrl.Equals(other.PresignedUrl)
            ) &&
            (
                Headers == other.Headers ||
                Headers != null &&
                Headers.SequenceEqual(other.Headers)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (PresignedUrl != null)
            {
                hash = hash * 59 + PresignedUrl.GetHashCode();
            }

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
