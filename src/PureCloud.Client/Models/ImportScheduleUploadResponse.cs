using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ImportScheduleUploadResponse
/// </summary>

public partial class ImportScheduleUploadResponse : IEquatable<ImportScheduleUploadResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ImportScheduleUploadResponse" /> class.
    /// </summary>
    /// <param name="UploadKey">The key to pass to the secondary request to start processing of the upload.</param>
    /// <param name="Url">The url to which to PUT the upload body.</param>
    /// <param name="Headers">Required headers for the PUT request to the url.</param>
    /// <param name="UploadBodySchema">Always null. Defines the schema of the json body to be PUT to the url. The json body should be gzip encoded before uploading.</param>
    public ImportScheduleUploadResponse(string UploadKey = null, string Url = null, Dictionary<string, string> Headers = null, ImportScheduleUploadSchema UploadBodySchema = null)
    {
        this.UploadKey = UploadKey;
        this.Url = Url;
        this.Headers = Headers;
        this.UploadBodySchema = UploadBodySchema;

    }



    /// <summary>
    /// The key to pass to the secondary request to start processing of the upload
    /// </summary>
    /// <value>The key to pass to the secondary request to start processing of the upload</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }



    /// <summary>
    /// The url to which to PUT the upload body
    /// </summary>
    /// <value>The url to which to PUT the upload body</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// Required headers for the PUT request to the url
    /// </summary>
    /// <value>Required headers for the PUT request to the url</value>
    [JsonPropertyName("headers")]
    public Dictionary<string, string> Headers { get; set; }



    /// <summary>
    /// Always null. Defines the schema of the json body to be PUT to the url. The json body should be gzip encoded before uploading
    /// </summary>
    /// <value>Always null. Defines the schema of the json body to be PUT to the url. The json body should be gzip encoded before uploading</value>
    [JsonPropertyName("uploadBodySchema")]
    public ImportScheduleUploadSchema UploadBodySchema { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ImportScheduleUploadResponse {\n");

        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
        sb.Append("  UploadBodySchema: ").Append(UploadBodySchema).Append("\n");
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
        return Equals(obj as ImportScheduleUploadResponse);
    }

    /// <summary>
    /// Returns true if ImportScheduleUploadResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ImportScheduleUploadResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ImportScheduleUploadResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
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
            ) &&
            (
                UploadBodySchema == other.UploadBodySchema ||
                UploadBodySchema != null &&
                UploadBodySchema.Equals(other.UploadBodySchema)
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
            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            if (UploadBodySchema != null)
            {
                hash = hash * 59 + UploadBodySchema.GetHashCode();
            }

            return hash;
        }
    }
}
