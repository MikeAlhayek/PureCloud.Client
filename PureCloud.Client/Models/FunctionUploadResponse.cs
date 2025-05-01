using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Action function create upload URL response.
/// </summary>
[DataContract]
public partial class FunctionUploadResponse : IEquatable<FunctionUploadResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FunctionUploadResponse" /> class.
    /// </summary>
    /// <param name="SignedUrlTimeoutSeconds">Upload time to live in seconds..</param>
    public FunctionUploadResponse(int? SignedUrlTimeoutSeconds = null)
    {
        this.SignedUrlTimeoutSeconds = SignedUrlTimeoutSeconds;

    }



    /// <summary>
    /// Presigned URL to PUT the file to
    /// </summary>
    /// <value>Presigned URL to PUT the file to</value>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; private set; }



    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL</value>
    [DataMember(Name = "headers", EmitDefaultValue = false)]
    public Dictionary<string, string> Headers { get; private set; }



    /// <summary>
    /// Upload time to live in seconds.
    /// </summary>
    /// <value>Upload time to live in seconds.</value>
    [DataMember(Name = "signedUrlTimeoutSeconds", EmitDefaultValue = false)]
    public int? SignedUrlTimeoutSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FunctionUploadResponse {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
        sb.Append("  SignedUrlTimeoutSeconds: ").Append(SignedUrlTimeoutSeconds).Append("\n");
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
        return Equals(obj as FunctionUploadResponse);
    }

    /// <summary>
    /// Returns true if FunctionUploadResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of FunctionUploadResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FunctionUploadResponse other)
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
                Headers == other.Headers ||
                Headers != null &&
                Headers.SequenceEqual(other.Headers)
            ) &&
            (
                SignedUrlTimeoutSeconds == other.SignedUrlTimeoutSeconds ||
                SignedUrlTimeoutSeconds != null &&
                SignedUrlTimeoutSeconds.Equals(other.SignedUrlTimeoutSeconds)
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

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            if (SignedUrlTimeoutSeconds != null)
            {
                hash = hash * 59 + SignedUrlTimeoutSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
