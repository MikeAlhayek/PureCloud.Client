using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VoicemailMediaInfo
/// </summary>

public partial class VoicemailMediaInfo : IEquatable<VoicemailMediaInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailMediaInfo" /> class.
    /// </summary>
    /// <param name="MediaFileUri">MediaFileUri.</param>
    /// <param name="MediaImageUri">MediaImageUri.</param>
    /// <param name="WaveformData">WaveformData.</param>
    public VoicemailMediaInfo(string MediaFileUri = null, string MediaImageUri = null, List<float?> WaveformData = null)
    {
        this.MediaFileUri = MediaFileUri;
        this.MediaImageUri = MediaImageUri;
        this.WaveformData = WaveformData;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets MediaFileUri
    /// </summary>
    [JsonPropertyName("mediaFileUri")]
    public string MediaFileUri { get; set; }



    /// <summary>
    /// Gets or Sets MediaImageUri
    /// </summary>
    [JsonPropertyName("mediaImageUri")]
    public string MediaImageUri { get; set; }



    /// <summary>
    /// Gets or Sets WaveformData
    /// </summary>
    [JsonPropertyName("waveformData")]
    public List<float?> WaveformData { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailMediaInfo {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  MediaFileUri: ").Append(MediaFileUri).Append("\n");
        sb.Append("  MediaImageUri: ").Append(MediaImageUri).Append("\n");
        sb.Append("  WaveformData: ").Append(WaveformData).Append("\n");
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
        return Equals(obj as VoicemailMediaInfo);
    }

    /// <summary>
    /// Returns true if VoicemailMediaInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailMediaInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailMediaInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                MediaFileUri == other.MediaFileUri ||
                MediaFileUri != null &&
                MediaFileUri.Equals(other.MediaFileUri)
            ) &&
            (
                MediaImageUri == other.MediaImageUri ||
                MediaImageUri != null &&
                MediaImageUri.Equals(other.MediaImageUri)
            ) &&
            (
                WaveformData == other.WaveformData ||
                WaveformData != null &&
                WaveformData.SequenceEqual(other.WaveformData)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (MediaFileUri != null)
            {
                hash = hash * 59 + MediaFileUri.GetHashCode();
            }

            if (MediaImageUri != null)
            {
                hash = hash * 59 + MediaImageUri.GetHashCode();
            }

            if (WaveformData != null)
            {
                hash = hash * 59 + WaveformData.GetHashCode();
            }

            return hash;
        }
    }
}
