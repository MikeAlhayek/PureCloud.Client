using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UploadUrlResponse
/// </summary>

public partial class UploadUrlResponse : IEquatable<UploadUrlResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UploadUrlResponse" /> class.
    /// </summary>
    public UploadUrlResponse()
    {

    }



    /// <summary>
    /// Presigned URL to PUT the file to
    /// </summary>
    /// <value>Presigned URL to PUT the file to</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// Key that identifies the file in the storage including the file name
    /// </summary>
    /// <value>Key that identifies the file in the storage including the file name</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }



    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL</value>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UploadUrlResponse {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
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
        return Equals(obj as UploadUrlResponse);
    }

    /// <summary>
    /// Returns true if UploadUrlResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of UploadUrlResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UploadUrlResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
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
            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            return hash;
        }
    }
}
