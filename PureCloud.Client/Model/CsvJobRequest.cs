using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// CsvJobRequest
/// </summary>
[DataContract]
public partial class CsvJobRequest : IEquatable<CsvJobRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CsvJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CsvJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CsvJobRequest" /> class.
    /// </summary>
    /// <param name="UploadId">Upload for the csv job (required).</param>
    /// <param name="SettingsId">Settings for the csv job (required).</param>
    public CsvJobRequest(string UploadId = null, string SettingsId = null)
    {
        this.UploadId = UploadId;
        this.SettingsId = SettingsId;

    }



    /// <summary>
    /// Upload for the csv job
    /// </summary>
    /// <value>Upload for the csv job</value>
    [DataMember(Name = "uploadId", EmitDefaultValue = false)]
    public string UploadId { get; set; }



    /// <summary>
    /// Settings for the csv job
    /// </summary>
    /// <value>Settings for the csv job</value>
    [DataMember(Name = "settingsId", EmitDefaultValue = false)]
    public string SettingsId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CsvJobRequest {\n");

        sb.Append("  UploadId: ").Append(UploadId).Append("\n");
        sb.Append("  SettingsId: ").Append(SettingsId).Append("\n");
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
        return this.Equals(obj as CsvJobRequest);
    }

    /// <summary>
    /// Returns true if CsvJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CsvJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CsvJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.UploadId == other.UploadId ||
                this.UploadId != null &&
                this.UploadId.Equals(other.UploadId)
            ) &&
            (
                this.SettingsId == other.SettingsId ||
                this.SettingsId != null &&
                this.SettingsId.Equals(other.SettingsId)
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
            if (this.UploadId != null)
            {
                hash = hash * 59 + this.UploadId.GetHashCode();
            }

            if (this.SettingsId != null)
            {
                hash = hash * 59 + this.SettingsId.GetHashCode();
            }

            return hash;
        }
    }
}
