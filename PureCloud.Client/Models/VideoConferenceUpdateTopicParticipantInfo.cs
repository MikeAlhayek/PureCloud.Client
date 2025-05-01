using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VideoConferenceUpdateTopicParticipantInfo
/// </summary>
[DataContract]
public partial class VideoConferenceUpdateTopicParticipantInfo : IEquatable<VideoConferenceUpdateTopicParticipantInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VideoConferenceUpdateTopicParticipantInfo" /> class.
    /// </summary>
    /// <param name="ActiveParticipantCount">ActiveParticipantCount.</param>
    /// <param name="Version">Version.</param>
    public VideoConferenceUpdateTopicParticipantInfo(long? ActiveParticipantCount = null, long? Version = null)
    {
        this.ActiveParticipantCount = ActiveParticipantCount;
        this.Version = Version;

    }



    /// <summary>
    /// Gets or Sets ActiveParticipantCount
    /// </summary>
    [DataMember(Name = "activeParticipantCount", EmitDefaultValue = false)]
    public long? ActiveParticipantCount { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VideoConferenceUpdateTopicParticipantInfo {\n");

        sb.Append("  ActiveParticipantCount: ").Append(ActiveParticipantCount).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as VideoConferenceUpdateTopicParticipantInfo);
    }

    /// <summary>
    /// Returns true if VideoConferenceUpdateTopicParticipantInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of VideoConferenceUpdateTopicParticipantInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VideoConferenceUpdateTopicParticipantInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActiveParticipantCount == other.ActiveParticipantCount ||
                ActiveParticipantCount != null &&
                ActiveParticipantCount.Equals(other.ActiveParticipantCount)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
            if (ActiveParticipantCount != null)
            {
                hash = hash * 59 + ActiveParticipantCount.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
