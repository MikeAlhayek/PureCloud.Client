using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CsvUploadRequest
/// </summary>

public partial class CsvUploadRequest : IEquatable<CsvUploadRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CsvUploadRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CsvUploadRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CsvUploadRequest" /> class.
    /// </summary>
    /// <param name="FileName">Name of the file to upload.</param>
    /// <param name="FileSize">The size of the upload file (required).</param>
    public CsvUploadRequest(string FileName = null, long? FileSize = null)
    {
        this.FileName = FileName;
        this.FileSize = FileSize;

    }



    /// <summary>
    /// Name of the file to upload
    /// </summary>
    /// <value>Name of the file to upload</value>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; }



    /// <summary>
    /// The size of the upload file
    /// </summary>
    /// <value>The size of the upload file</value>
    [JsonPropertyName("fileSize")]
    public long? FileSize { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CsvUploadRequest {\n");

        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  FileSize: ").Append(FileSize).Append("\n");
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
        return Equals(obj as CsvUploadRequest);
    }

    /// <summary>
    /// Returns true if CsvUploadRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CsvUploadRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CsvUploadRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
            ) &&
            (
                FileSize == other.FileSize ||
                FileSize != null &&
                FileSize.Equals(other.FileSize)
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
            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (FileSize != null)
            {
                hash = hash * 59 + FileSize.GetHashCode();
            }

            return hash;
        }
    }
}
