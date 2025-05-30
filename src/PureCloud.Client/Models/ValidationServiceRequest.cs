using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValidationServiceRequest
/// </summary>

public partial class ValidationServiceRequest : IEquatable<ValidationServiceRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationServiceRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ValidationServiceRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationServiceRequest" /> class.
    /// </summary>
    /// <param name="DateImportEnded">The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="UploadKey">S3 key for the uploaded file (required).</param>
    public ValidationServiceRequest(DateTime? DateImportEnded = null, string UploadKey = null)
    {
        this.DateImportEnded = DateImportEnded;
        this.UploadKey = UploadKey;

    }



    /// <summary>
    /// The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateImportEnded")]
    public DateTime? DateImportEnded { get; set; }



    /// <summary>
    /// S3 key for the uploaded file
    /// </summary>
    /// <value>S3 key for the uploaded file</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValidationServiceRequest {\n");

        sb.Append("  DateImportEnded: ").Append(DateImportEnded).Append("\n");
        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
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
        return Equals(obj as ValidationServiceRequest);
    }

    /// <summary>
    /// Returns true if ValidationServiceRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ValidationServiceRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValidationServiceRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateImportEnded == other.DateImportEnded ||
                DateImportEnded != null &&
                DateImportEnded.Equals(other.DateImportEnded)
            ) &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
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
            if (DateImportEnded != null)
            {
                hash = hash * 59 + DateImportEnded.GetHashCode();
            }

            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            return hash;
        }
    }
}
