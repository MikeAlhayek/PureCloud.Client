using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingEventMediaResult
/// </summary>
[DataContract]
public partial class RecordingEventMediaResult : IEquatable<RecordingEventMediaResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingEventMediaResult" /> class.
    /// </summary>
    /// <param name="ChannelId">ChannelId.</param>
    /// <param name="WaveUri">WaveUri.</param>
    /// <param name="MediaUri">MediaUri.</param>
    /// <param name="WaveformData">WaveformData.</param>
    public RecordingEventMediaResult(string ChannelId = null, string WaveUri = null, string MediaUri = null, List<double?> WaveformData = null)
    {
        this.ChannelId = ChannelId;
        this.WaveUri = WaveUri;
        this.MediaUri = MediaUri;
        this.WaveformData = WaveformData;

    }



    /// <summary>
    /// Gets or Sets ChannelId
    /// </summary>
    [DataMember(Name = "channelId", EmitDefaultValue = false)]
    public string ChannelId { get; set; }



    /// <summary>
    /// Gets or Sets WaveUri
    /// </summary>
    [DataMember(Name = "waveUri", EmitDefaultValue = false)]
    public string WaveUri { get; set; }



    /// <summary>
    /// Gets or Sets MediaUri
    /// </summary>
    [DataMember(Name = "mediaUri", EmitDefaultValue = false)]
    public string MediaUri { get; set; }



    /// <summary>
    /// Gets or Sets WaveformData
    /// </summary>
    [DataMember(Name = "waveformData", EmitDefaultValue = false)]
    public List<double?> WaveformData { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingEventMediaResult {\n");

        sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
        sb.Append("  WaveUri: ").Append(WaveUri).Append("\n");
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
        return Equals(obj as RecordingEventMediaResult);
    }

    /// <summary>
    /// Returns true if RecordingEventMediaResult instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingEventMediaResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingEventMediaResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ChannelId == other.ChannelId ||
                ChannelId != null &&
                ChannelId.Equals(other.ChannelId)
            ) &&
            (
                WaveUri == other.WaveUri ||
                WaveUri != null &&
                WaveUri.Equals(other.WaveUri)
            ) &&
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
            if (ChannelId != null)
            {
                hash = hash * 59 + ChannelId.GetHashCode();
            }

            if (WaveUri != null)
            {
                hash = hash * 59 + WaveUri.GetHashCode();
            }

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
