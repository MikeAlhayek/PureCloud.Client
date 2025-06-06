using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaEndpointStatistics
/// </summary>

public partial class MediaEndpointStatistics : IEquatable<MediaEndpointStatistics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaEndpointStatistics" /> class.
    /// </summary>
    /// <param name="Trunk">Trunk information utilized when creating the media endpoint.</param>
    /// <param name="Station">Station information associated with media endpoint.</param>
    /// <param name="User">User information associated media endpoint.</param>
    /// <param name="Ice">The ICE protocol statistics and details. Reference: https://www.rfc-editor.org/rfc/rfc5245.</param>
    /// <param name="Rtp">Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550.</param>
    /// <param name="ReconnectAttemptCount">Media reconnect attempt count.</param>
    public MediaEndpointStatistics(MediaStatisticsTrunkInfo Trunk = null, NamedEntity Station = null, NamedEntity User = null, MediaIceStatistics Ice = null, MediaRtpStatistics Rtp = null, int? ReconnectAttemptCount = null)
    {
        this.Trunk = Trunk;
        this.Station = Station;
        this.User = User;
        this.Ice = Ice;
        this.Rtp = Rtp;
        this.ReconnectAttemptCount = ReconnectAttemptCount;

    }



    /// <summary>
    /// Trunk information utilized when creating the media endpoint
    /// </summary>
    /// <value>Trunk information utilized when creating the media endpoint</value>
    [JsonPropertyName("trunk")]
    public MediaStatisticsTrunkInfo Trunk { get; set; }



    /// <summary>
    /// Station information associated with media endpoint
    /// </summary>
    /// <value>Station information associated with media endpoint</value>
    [JsonPropertyName("station")]
    public NamedEntity Station { get; set; }



    /// <summary>
    /// User information associated media endpoint
    /// </summary>
    /// <value>User information associated media endpoint</value>
    [JsonPropertyName("user")]
    public NamedEntity User { get; set; }



    /// <summary>
    /// The ICE protocol statistics and details. Reference: https://www.rfc-editor.org/rfc/rfc5245
    /// </summary>
    /// <value>The ICE protocol statistics and details. Reference: https://www.rfc-editor.org/rfc/rfc5245</value>
    [JsonPropertyName("ice")]
    public MediaIceStatistics Ice { get; set; }



    /// <summary>
    /// Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550
    /// </summary>
    /// <value>Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550</value>
    [JsonPropertyName("rtp")]
    public MediaRtpStatistics Rtp { get; set; }



    /// <summary>
    /// Media reconnect attempt count
    /// </summary>
    /// <value>Media reconnect attempt count</value>
    [JsonPropertyName("reconnectAttemptCount")]
    public int? ReconnectAttemptCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaEndpointStatistics {\n");

        sb.Append("  Trunk: ").Append(Trunk).Append("\n");
        sb.Append("  Station: ").Append(Station).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Ice: ").Append(Ice).Append("\n");
        sb.Append("  Rtp: ").Append(Rtp).Append("\n");
        sb.Append("  ReconnectAttemptCount: ").Append(ReconnectAttemptCount).Append("\n");
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
        return Equals(obj as MediaEndpointStatistics);
    }

    /// <summary>
    /// Returns true if MediaEndpointStatistics instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaEndpointStatistics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaEndpointStatistics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Trunk == other.Trunk ||
                Trunk != null &&
                Trunk.Equals(other.Trunk)
            ) &&
            (
                Station == other.Station ||
                Station != null &&
                Station.Equals(other.Station)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Ice == other.Ice ||
                Ice != null &&
                Ice.Equals(other.Ice)
            ) &&
            (
                Rtp == other.Rtp ||
                Rtp != null &&
                Rtp.Equals(other.Rtp)
            ) &&
            (
                ReconnectAttemptCount == other.ReconnectAttemptCount ||
                ReconnectAttemptCount != null &&
                ReconnectAttemptCount.Equals(other.ReconnectAttemptCount)
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
            if (Trunk != null)
            {
                hash = hash * 59 + Trunk.GetHashCode();
            }

            if (Station != null)
            {
                hash = hash * 59 + Station.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Ice != null)
            {
                hash = hash * 59 + Ice.GetHashCode();
            }

            if (Rtp != null)
            {
                hash = hash * 59 + Rtp.GetHashCode();
            }

            if (ReconnectAttemptCount != null)
            {
                hash = hash * 59 + ReconnectAttemptCount.GetHashCode();
            }

            return hash;
        }
    }
}
