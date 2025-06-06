using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CsvUploadPreviewResponse
/// </summary>

public partial class CsvUploadPreviewResponse : IEquatable<CsvUploadPreviewResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CsvUploadPreviewResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CsvUploadPreviewResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CsvUploadPreviewResponse" /> class.
    /// </summary>
    /// <param name="UploadId">Id for the upload (required).</param>
    /// <param name="Headers">List of headers in the CSV (required).</param>
    /// <param name="Entries">List of entries in the CSV (required).</param>
    public CsvUploadPreviewResponse(string UploadId = null, List<string> Headers = null, List<List<string>> Entries = null)
    {
        this.UploadId = UploadId;
        this.Headers = Headers;
        this.Entries = Entries;

    }



    /// <summary>
    /// Id for the upload
    /// </summary>
    /// <value>Id for the upload</value>
    [JsonPropertyName("uploadId")]
    public string UploadId { get; set; }



    /// <summary>
    /// List of headers in the CSV
    /// </summary>
    /// <value>List of headers in the CSV</value>
    [JsonPropertyName("headers")]
    public List<string> Headers { get; set; }



    /// <summary>
    /// List of entries in the CSV
    /// </summary>
    /// <value>List of entries in the CSV</value>
    [JsonPropertyName("entries")]
    public List<List<string>> Entries { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CsvUploadPreviewResponse {\n");

        sb.Append("  UploadId: ").Append(UploadId).Append("\n");
        sb.Append("  Headers: ").Append(Headers).Append("\n");
        sb.Append("  Entries: ").Append(Entries).Append("\n");
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
        return Equals(obj as CsvUploadPreviewResponse);
    }

    /// <summary>
    /// Returns true if CsvUploadPreviewResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CsvUploadPreviewResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CsvUploadPreviewResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UploadId == other.UploadId ||
                UploadId != null &&
                UploadId.Equals(other.UploadId)
            ) &&
            (
                Headers == other.Headers ||
                Headers != null &&
                Headers.SequenceEqual(other.Headers)
            ) &&
            (
                Entries == other.Entries ||
                Entries != null &&
                Entries.SequenceEqual(other.Entries)
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
            if (UploadId != null)
            {
                hash = hash * 59 + UploadId.GetHashCode();
            }

            if (Headers != null)
            {
                hash = hash * 59 + Headers.GetHashCode();
            }

            if (Entries != null)
            {
                hash = hash * 59 + Entries.GetHashCode();
            }

            return hash;
        }
    }
}
