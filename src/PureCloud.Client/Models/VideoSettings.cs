using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The settings to enable video chat
/// </summary>

public partial class VideoSettings : IEquatable<VideoSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VideoSettings" /> class.
    /// </summary>
    /// <param name="Enabled">whether or not video is enabled.</param>
    /// <param name="Agent">Video Settings for agent.</param>
    /// <param name="User">Video Settings for user.</param>
    public VideoSettings(bool? Enabled = null, AgentVideoSettings Agent = null, UserVideoSettings User = null)
    {
        this.Enabled = Enabled;
        this.Agent = Agent;
        this.User = User;

    }



    /// <summary>
    /// whether or not video is enabled
    /// </summary>
    /// <value>whether or not video is enabled</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Video Settings for agent
    /// </summary>
    /// <value>Video Settings for agent</value>
    [JsonPropertyName("agent")]
    public AgentVideoSettings Agent { get; set; }



    /// <summary>
    /// Video Settings for user
    /// </summary>
    /// <value>Video Settings for user</value>
    [JsonPropertyName("user")]
    public UserVideoSettings User { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VideoSettings {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as VideoSettings);
    }

    /// <summary>
    /// Returns true if VideoSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of VideoSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VideoSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            return hash;
        }
    }
}
