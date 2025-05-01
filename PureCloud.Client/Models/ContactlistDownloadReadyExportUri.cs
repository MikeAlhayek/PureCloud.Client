using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactlistDownloadReadyExportUri
/// </summary>
[DataContract]
public partial class ContactlistDownloadReadyExportUri : IEquatable<ContactlistDownloadReadyExportUri>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactlistDownloadReadyExportUri" /> class.
    /// </summary>
    /// <param name="Uri">Uri.</param>
    /// <param name="ExportTimestamp">ExportTimestamp.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public ContactlistDownloadReadyExportUri(string Uri = null, string ExportTimestamp = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Uri = Uri;
        this.ExportTimestamp = ExportTimestamp;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    [DataMember(Name = "uri", EmitDefaultValue = false)]
    public string Uri { get; set; }



    /// <summary>
    /// Gets or Sets ExportTimestamp
    /// </summary>
    [DataMember(Name = "exportTimestamp", EmitDefaultValue = false)]
    public string ExportTimestamp { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactlistDownloadReadyExportUri {\n");

        sb.Append("  Uri: ").Append(Uri).Append("\n");
        sb.Append("  ExportTimestamp: ").Append(ExportTimestamp).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return this.Equals(obj as ContactlistDownloadReadyExportUri);
    }

    /// <summary>
    /// Returns true if ContactlistDownloadReadyExportUri instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactlistDownloadReadyExportUri to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactlistDownloadReadyExportUri other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Uri == other.Uri ||
                this.Uri != null &&
                this.Uri.Equals(other.Uri)
            ) &&
            (
                this.ExportTimestamp == other.ExportTimestamp ||
                this.ExportTimestamp != null &&
                this.ExportTimestamp.Equals(other.ExportTimestamp)
            ) &&
            (
                this.AdditionalProperties == other.AdditionalProperties ||
                this.AdditionalProperties != null &&
                this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (this.Uri != null)
            {
                hash = hash * 59 + this.Uri.GetHashCode();
            }

            if (this.ExportTimestamp != null)
            {
                hash = hash * 59 + this.ExportTimestamp.GetHashCode();
            }

            if (this.AdditionalProperties != null)
            {
                hash = hash * 59 + this.AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
