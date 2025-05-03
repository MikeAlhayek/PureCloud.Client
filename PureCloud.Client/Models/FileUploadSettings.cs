using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// File upload settings for messenger
/// </summary>

public partial class FileUploadSettings : IEquatable<FileUploadSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FileUploadSettings" /> class.
    /// </summary>
    /// <param name="EnableAttachments">whether or not attachments are enabled.</param>
    /// <param name="Modes">The list of supported file upload modes.</param>
    public FileUploadSettings(bool? EnableAttachments = null, List<FileUploadMode> Modes = null)
    {
        this.EnableAttachments = EnableAttachments;
        this.Modes = Modes;

    }



    /// <summary>
    /// whether or not attachments are enabled
    /// </summary>
    /// <value>whether or not attachments are enabled</value>
    [JsonPropertyName("enableAttachments")]
    public bool? EnableAttachments { get; set; }



    /// <summary>
    /// The list of supported file upload modes
    /// </summary>
    /// <value>The list of supported file upload modes</value>
    [JsonPropertyName("modes")]
    public List<FileUploadMode> Modes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FileUploadSettings {\n");

        sb.Append("  EnableAttachments: ").Append(EnableAttachments).Append("\n");
        sb.Append("  Modes: ").Append(Modes).Append("\n");
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
        return Equals(obj as FileUploadSettings);
    }

    /// <summary>
    /// Returns true if FileUploadSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of FileUploadSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FileUploadSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EnableAttachments == other.EnableAttachments ||
                EnableAttachments != null &&
                EnableAttachments.Equals(other.EnableAttachments)
            ) &&
            (
                Modes == other.Modes ||
                Modes != null &&
                Modes.SequenceEqual(other.Modes)
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
            if (EnableAttachments != null)
            {
                hash = hash * 59 + EnableAttachments.GetHashCode();
            }

            if (Modes != null)
            {
                hash = hash * 59 + Modes.GetHashCode();
            }

            return hash;
        }
    }
}
