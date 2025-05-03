using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailThreadingSettings
/// </summary>

public partial class EmailThreadingSettings : IEquatable<EmailThreadingSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailThreadingSettings" /> class.
    /// </summary>
    /// <param name="StartNewConversationOnSubjectChange">This setting controls whether a new conversation is started if the subject of an inbound email is different from the subject of the current conversation. RE: and FWD: prefixes in any language are ignored..</param>
    /// <param name="TimeoutInMinutes">In minutes, how long an email conversation should keep being threaded after being disconnected..</param>
    public EmailThreadingSettings(bool? StartNewConversationOnSubjectChange = null, long? TimeoutInMinutes = null)
    {
        this.StartNewConversationOnSubjectChange = StartNewConversationOnSubjectChange;
        this.TimeoutInMinutes = TimeoutInMinutes;

    }



    /// <summary>
    /// This setting controls whether a new conversation is started if the subject of an inbound email is different from the subject of the current conversation. RE: and FWD: prefixes in any language are ignored.
    /// </summary>
    /// <value>This setting controls whether a new conversation is started if the subject of an inbound email is different from the subject of the current conversation. RE: and FWD: prefixes in any language are ignored.</value>
    [JsonPropertyName("startNewConversationOnSubjectChange")]
    public bool? StartNewConversationOnSubjectChange { get; set; }



    /// <summary>
    /// In minutes, how long an email conversation should keep being threaded after being disconnected.
    /// </summary>
    /// <value>In minutes, how long an email conversation should keep being threaded after being disconnected.</value>
    [JsonPropertyName("timeoutInMinutes")]
    public long? TimeoutInMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmailThreadingSettings {\n");

        sb.Append("  StartNewConversationOnSubjectChange: ").Append(StartNewConversationOnSubjectChange).Append("\n");
        sb.Append("  TimeoutInMinutes: ").Append(TimeoutInMinutes).Append("\n");
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
        return Equals(obj as EmailThreadingSettings);
    }

    /// <summary>
    /// Returns true if EmailThreadingSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailThreadingSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailThreadingSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartNewConversationOnSubjectChange == other.StartNewConversationOnSubjectChange ||
                StartNewConversationOnSubjectChange != null &&
                StartNewConversationOnSubjectChange.Equals(other.StartNewConversationOnSubjectChange)
            ) &&
            (
                TimeoutInMinutes == other.TimeoutInMinutes ||
                TimeoutInMinutes != null &&
                TimeoutInMinutes.Equals(other.TimeoutInMinutes)
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
            if (StartNewConversationOnSubjectChange != null)
            {
                hash = hash * 59 + StartNewConversationOnSubjectChange.GetHashCode();
            }

            if (TimeoutInMinutes != null)
            {
                hash = hash * 59 + TimeoutInMinutes.GetHashCode();
            }

            return hash;
        }
    }
}
