using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactlistDownloadReadyExportUri
/// </summary>

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
    [JsonPropertyName("uri")]
    public string Uri { get; set; }



    /// <summary>
    /// Gets or Sets ExportTimestamp
    /// </summary>
    [JsonPropertyName("exportTimestamp")]
    public string ExportTimestamp { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
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
        return Equals(obj as ContactlistDownloadReadyExportUri);
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
                Uri == other.Uri ||
                Uri != null &&
                Uri.Equals(other.Uri)
            ) &&
            (
                ExportTimestamp == other.ExportTimestamp ||
                ExportTimestamp != null &&
                ExportTimestamp.Equals(other.ExportTimestamp)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (Uri != null)
            {
                hash = hash * 59 + Uri.GetHashCode();
            }

            if (ExportTimestamp != null)
            {
                hash = hash * 59 + ExportTimestamp.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
