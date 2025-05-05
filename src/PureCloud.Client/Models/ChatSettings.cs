using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatSettings
/// </summary>

public partial class ChatSettings : IEquatable<ChatSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatSettings" /> class.
    /// </summary>
    /// <param name="MessageRetentionPeriodDays">Retention time for messages in days, expressed as int in the range [10,3650].</param>
    /// <param name="ReactionsEnabled">Reactions enabled for org.</param>
    public ChatSettings(int? MessageRetentionPeriodDays = null, bool? ReactionsEnabled = null)
    {
        this.MessageRetentionPeriodDays = MessageRetentionPeriodDays;
        this.ReactionsEnabled = ReactionsEnabled;

    }



    /// <summary>
    /// Retention time for messages in days, expressed as int in the range [10,3650]
    /// </summary>
    /// <value>Retention time for messages in days, expressed as int in the range [10,3650]</value>
    [JsonPropertyName("messageRetentionPeriodDays")]
    public int? MessageRetentionPeriodDays { get; set; }



    /// <summary>
    /// Reactions enabled for org
    /// </summary>
    /// <value>Reactions enabled for org</value>
    [JsonPropertyName("reactionsEnabled")]
    public bool? ReactionsEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatSettings {\n");

        sb.Append("  MessageRetentionPeriodDays: ").Append(MessageRetentionPeriodDays).Append("\n");
        sb.Append("  ReactionsEnabled: ").Append(ReactionsEnabled).Append("\n");
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
        return Equals(obj as ChatSettings);
    }

    /// <summary>
    /// Returns true if ChatSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MessageRetentionPeriodDays == other.MessageRetentionPeriodDays ||
                MessageRetentionPeriodDays != null &&
                MessageRetentionPeriodDays.Equals(other.MessageRetentionPeriodDays)
            ) &&
            (
                ReactionsEnabled == other.ReactionsEnabled ||
                ReactionsEnabled != null &&
                ReactionsEnabled.Equals(other.ReactionsEnabled)
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
            if (MessageRetentionPeriodDays != null)
            {
                hash = hash * 59 + MessageRetentionPeriodDays.GetHashCode();
            }

            if (ReactionsEnabled != null)
            {
                hash = hash * 59 + ReactionsEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
