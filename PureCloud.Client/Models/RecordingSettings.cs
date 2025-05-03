using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingSettings
/// </summary>

public partial class RecordingSettings : IEquatable<RecordingSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingSettings" /> class.
    /// </summary>
    /// <param name="MaxSimultaneousStreams">Maximum number of simultaneous screen recording streams.</param>
    /// <param name="MaxConfigurableScreenRecordingStreams">Upper limit that maxSimultaneousStreams can be configured.</param>
    /// <param name="RegionalRecordingStorageEnabled">Store call recordings in the region where they are intended to be recorded, otherwise in the organization&#39;s home region.</param>
    /// <param name="RecordingPlaybackUrlTtl">The duration in minutes for which the generated URL for recording playback remains valid.The default duration is set to 60 minutes, with a minimum allowable duration of 2 minutes and a maximum of 60 minutes..</param>
    /// <param name="RecordingBatchDownloadUrlTtl">The duration in minutes for which the generated URL for recording batch download remains valid.The default duration is set to 60 minutes, with a minimum allowable duration of 2 minutes and a maximum of 60 minutes..</param>
    public RecordingSettings(int? MaxSimultaneousStreams = null, int? MaxConfigurableScreenRecordingStreams = null, bool? RegionalRecordingStorageEnabled = null, int? RecordingPlaybackUrlTtl = null, int? RecordingBatchDownloadUrlTtl = null)
    {
        this.MaxSimultaneousStreams = MaxSimultaneousStreams;
        this.MaxConfigurableScreenRecordingStreams = MaxConfigurableScreenRecordingStreams;
        this.RegionalRecordingStorageEnabled = RegionalRecordingStorageEnabled;
        this.RecordingPlaybackUrlTtl = RecordingPlaybackUrlTtl;
        this.RecordingBatchDownloadUrlTtl = RecordingBatchDownloadUrlTtl;

    }



    /// <summary>
    /// Maximum number of simultaneous screen recording streams
    /// </summary>
    /// <value>Maximum number of simultaneous screen recording streams</value>
    [JsonPropertyName("maxSimultaneousStreams")]
    public int? MaxSimultaneousStreams { get; set; }



    /// <summary>
    /// Upper limit that maxSimultaneousStreams can be configured
    /// </summary>
    /// <value>Upper limit that maxSimultaneousStreams can be configured</value>
    [JsonPropertyName("maxConfigurableScreenRecordingStreams")]
    public int? MaxConfigurableScreenRecordingStreams { get; set; }



    /// <summary>
    /// Store call recordings in the region where they are intended to be recorded, otherwise in the organization&#39;s home region
    /// </summary>
    /// <value>Store call recordings in the region where they are intended to be recorded, otherwise in the organization&#39;s home region</value>
    [JsonPropertyName("regionalRecordingStorageEnabled")]
    public bool? RegionalRecordingStorageEnabled { get; set; }



    /// <summary>
    /// The duration in minutes for which the generated URL for recording playback remains valid.The default duration is set to 60 minutes, with a minimum allowable duration of 2 minutes and a maximum of 60 minutes.
    /// </summary>
    /// <value>The duration in minutes for which the generated URL for recording playback remains valid.The default duration is set to 60 minutes, with a minimum allowable duration of 2 minutes and a maximum of 60 minutes.</value>
    [JsonPropertyName("recordingPlaybackUrlTtl")]
    public int? RecordingPlaybackUrlTtl { get; set; }



    /// <summary>
    /// The duration in minutes for which the generated URL for recording batch download remains valid.The default duration is set to 60 minutes, with a minimum allowable duration of 2 minutes and a maximum of 60 minutes.
    /// </summary>
    /// <value>The duration in minutes for which the generated URL for recording batch download remains valid.The default duration is set to 60 minutes, with a minimum allowable duration of 2 minutes and a maximum of 60 minutes.</value>
    [JsonPropertyName("recordingBatchDownloadUrlTtl")]
    public int? RecordingBatchDownloadUrlTtl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingSettings {\n");

        sb.Append("  MaxSimultaneousStreams: ").Append(MaxSimultaneousStreams).Append("\n");
        sb.Append("  MaxConfigurableScreenRecordingStreams: ").Append(MaxConfigurableScreenRecordingStreams).Append("\n");
        sb.Append("  RegionalRecordingStorageEnabled: ").Append(RegionalRecordingStorageEnabled).Append("\n");
        sb.Append("  RecordingPlaybackUrlTtl: ").Append(RecordingPlaybackUrlTtl).Append("\n");
        sb.Append("  RecordingBatchDownloadUrlTtl: ").Append(RecordingBatchDownloadUrlTtl).Append("\n");
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
        return Equals(obj as RecordingSettings);
    }

    /// <summary>
    /// Returns true if RecordingSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MaxSimultaneousStreams == other.MaxSimultaneousStreams ||
                MaxSimultaneousStreams != null &&
                MaxSimultaneousStreams.Equals(other.MaxSimultaneousStreams)
            ) &&
            (
                MaxConfigurableScreenRecordingStreams == other.MaxConfigurableScreenRecordingStreams ||
                MaxConfigurableScreenRecordingStreams != null &&
                MaxConfigurableScreenRecordingStreams.Equals(other.MaxConfigurableScreenRecordingStreams)
            ) &&
            (
                RegionalRecordingStorageEnabled == other.RegionalRecordingStorageEnabled ||
                RegionalRecordingStorageEnabled != null &&
                RegionalRecordingStorageEnabled.Equals(other.RegionalRecordingStorageEnabled)
            ) &&
            (
                RecordingPlaybackUrlTtl == other.RecordingPlaybackUrlTtl ||
                RecordingPlaybackUrlTtl != null &&
                RecordingPlaybackUrlTtl.Equals(other.RecordingPlaybackUrlTtl)
            ) &&
            (
                RecordingBatchDownloadUrlTtl == other.RecordingBatchDownloadUrlTtl ||
                RecordingBatchDownloadUrlTtl != null &&
                RecordingBatchDownloadUrlTtl.Equals(other.RecordingBatchDownloadUrlTtl)
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
            if (MaxSimultaneousStreams != null)
            {
                hash = hash * 59 + MaxSimultaneousStreams.GetHashCode();
            }

            if (MaxConfigurableScreenRecordingStreams != null)
            {
                hash = hash * 59 + MaxConfigurableScreenRecordingStreams.GetHashCode();
            }

            if (RegionalRecordingStorageEnabled != null)
            {
                hash = hash * 59 + RegionalRecordingStorageEnabled.GetHashCode();
            }

            if (RecordingPlaybackUrlTtl != null)
            {
                hash = hash * 59 + RecordingPlaybackUrlTtl.GetHashCode();
            }

            if (RecordingBatchDownloadUrlTtl != null)
            {
                hash = hash * 59 + RecordingBatchDownloadUrlTtl.GetHashCode();
            }

            return hash;
        }
    }
}
