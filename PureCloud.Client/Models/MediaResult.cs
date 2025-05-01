using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaResult
/// </summary>
[DataContract]
public partial class MediaResult : IEquatable<MediaResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaResult" /> class.
    /// </summary>
    /// <param name="MediaUri">MediaUri.</param>
    /// <param name="WaveformData">WaveformData.</param>
    public MediaResult(string MediaUri = null, List<float?> WaveformData = null)
    {
        this.MediaUri = MediaUri;
        this.WaveformData = WaveformData;

    }



    /// <summary>
    /// Gets or Sets MediaUri
    /// </summary>
    [DataMember(Name = "mediaUri", EmitDefaultValue = false)]
    public string MediaUri { get; set; }



    /// <summary>
    /// Gets or Sets WaveformData
    /// </summary>
    [DataMember(Name = "waveformData", EmitDefaultValue = false)]
    public List<float?> WaveformData { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaResult {\n");

        sb.Append("  MediaUri: ").Append(MediaUri).Append("\n");
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
        return Equals(obj as MediaResult);
    }

    /// <summary>
    /// Returns true if MediaResult instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MediaUri == other.MediaUri ||
                MediaUri != null &&
                MediaUri.Equals(other.MediaUri)
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
            if (MediaUri != null)
            {
                hash = hash * 59 + MediaUri.GetHashCode();
            }

            if (WaveformData != null)
            {
                hash = hash * 59 + WaveformData.GetHashCode();
            }

            return hash;
        }
    }
}
