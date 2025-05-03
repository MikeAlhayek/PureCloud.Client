using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Conversation settings that handles chats within the messenger
/// </summary>

public partial class ConversationAppSettings : IEquatable<ConversationAppSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationAppSettings" /> class.
    /// </summary>
    /// <param name="Enabled">The toggle to enable or disable conversations.</param>
    /// <param name="ShowAgentTypingIndicator">The toggle to enable or disable typing indicator for messenger.</param>
    /// <param name="ShowUserTypingIndicator">The toggle to enable or disable typing indicator for messenger.</param>
    /// <param name="AutoStart">The auto start for the messenger conversation.</param>
    /// <param name="Markdown">The markdown for the messenger app.</param>
    /// <param name="ConversationDisconnect">The conversation disconnect settings for the messenger app.</param>
    /// <param name="ConversationClear">The conversation clear settings for the messenger app.</param>
    /// <param name="Humanize">The humanize conversations settings for the messenger app.</param>
    /// <param name="Notifications">The notification settings for messenger apps.</param>
    public ConversationAppSettings(bool? Enabled = null, bool? ShowAgentTypingIndicator = null, bool? ShowUserTypingIndicator = null, AutoStart AutoStart = null, Markdown Markdown = null, ConversationDisconnectSettings ConversationDisconnect = null, ConversationClearSettings ConversationClear = null, Humanize Humanize = null, NotificationsSettings Notifications = null)
    {
        this.Enabled = Enabled;
        this.ShowAgentTypingIndicator = ShowAgentTypingIndicator;
        this.ShowUserTypingIndicator = ShowUserTypingIndicator;
        this.AutoStart = AutoStart;
        this.Markdown = Markdown;
        this.ConversationDisconnect = ConversationDisconnect;
        this.ConversationClear = ConversationClear;
        this.Humanize = Humanize;
        this.Notifications = Notifications;

    }



    /// <summary>
    /// The toggle to enable or disable conversations
    /// </summary>
    /// <value>The toggle to enable or disable conversations</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The toggle to enable or disable typing indicator for messenger
    /// </summary>
    /// <value>The toggle to enable or disable typing indicator for messenger</value>
    [JsonPropertyName("showAgentTypingIndicator")]
    public bool? ShowAgentTypingIndicator { get; set; }



    /// <summary>
    /// The toggle to enable or disable typing indicator for messenger
    /// </summary>
    /// <value>The toggle to enable or disable typing indicator for messenger</value>
    [JsonPropertyName("showUserTypingIndicator")]
    public bool? ShowUserTypingIndicator { get; set; }



    /// <summary>
    /// The auto start for the messenger conversation
    /// </summary>
    /// <value>The auto start for the messenger conversation</value>
    [JsonPropertyName("autoStart")]
    public AutoStart AutoStart { get; set; }



    /// <summary>
    /// The markdown for the messenger app
    /// </summary>
    /// <value>The markdown for the messenger app</value>
    [JsonPropertyName("markdown")]
    public Markdown Markdown { get; set; }



    /// <summary>
    /// The conversation disconnect settings for the messenger app
    /// </summary>
    /// <value>The conversation disconnect settings for the messenger app</value>
    [JsonPropertyName("conversationDisconnect")]
    public ConversationDisconnectSettings ConversationDisconnect { get; set; }



    /// <summary>
    /// The conversation clear settings for the messenger app
    /// </summary>
    /// <value>The conversation clear settings for the messenger app</value>
    [JsonPropertyName("conversationClear")]
    public ConversationClearSettings ConversationClear { get; set; }



    /// <summary>
    /// The humanize conversations settings for the messenger app
    /// </summary>
    /// <value>The humanize conversations settings for the messenger app</value>
    [JsonPropertyName("humanize")]
    public Humanize Humanize { get; set; }



    /// <summary>
    /// The notification settings for messenger apps
    /// </summary>
    /// <value>The notification settings for messenger apps</value>
    [JsonPropertyName("notifications")]
    public NotificationsSettings Notifications { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationAppSettings {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  ShowAgentTypingIndicator: ").Append(ShowAgentTypingIndicator).Append("\n");
        sb.Append("  ShowUserTypingIndicator: ").Append(ShowUserTypingIndicator).Append("\n");
        sb.Append("  AutoStart: ").Append(AutoStart).Append("\n");
        sb.Append("  Markdown: ").Append(Markdown).Append("\n");
        sb.Append("  ConversationDisconnect: ").Append(ConversationDisconnect).Append("\n");
        sb.Append("  ConversationClear: ").Append(ConversationClear).Append("\n");
        sb.Append("  Humanize: ").Append(Humanize).Append("\n");
        sb.Append("  Notifications: ").Append(Notifications).Append("\n");
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
        return Equals(obj as ConversationAppSettings);
    }

    /// <summary>
    /// Returns true if ConversationAppSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationAppSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationAppSettings other)
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
                ShowAgentTypingIndicator == other.ShowAgentTypingIndicator ||
                ShowAgentTypingIndicator != null &&
                ShowAgentTypingIndicator.Equals(other.ShowAgentTypingIndicator)
            ) &&
            (
                ShowUserTypingIndicator == other.ShowUserTypingIndicator ||
                ShowUserTypingIndicator != null &&
                ShowUserTypingIndicator.Equals(other.ShowUserTypingIndicator)
            ) &&
            (
                AutoStart == other.AutoStart ||
                AutoStart != null &&
                AutoStart.Equals(other.AutoStart)
            ) &&
            (
                Markdown == other.Markdown ||
                Markdown != null &&
                Markdown.Equals(other.Markdown)
            ) &&
            (
                ConversationDisconnect == other.ConversationDisconnect ||
                ConversationDisconnect != null &&
                ConversationDisconnect.Equals(other.ConversationDisconnect)
            ) &&
            (
                ConversationClear == other.ConversationClear ||
                ConversationClear != null &&
                ConversationClear.Equals(other.ConversationClear)
            ) &&
            (
                Humanize == other.Humanize ||
                Humanize != null &&
                Humanize.Equals(other.Humanize)
            ) &&
            (
                Notifications == other.Notifications ||
                Notifications != null &&
                Notifications.Equals(other.Notifications)
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

            if (ShowAgentTypingIndicator != null)
            {
                hash = hash * 59 + ShowAgentTypingIndicator.GetHashCode();
            }

            if (ShowUserTypingIndicator != null)
            {
                hash = hash * 59 + ShowUserTypingIndicator.GetHashCode();
            }

            if (AutoStart != null)
            {
                hash = hash * 59 + AutoStart.GetHashCode();
            }

            if (Markdown != null)
            {
                hash = hash * 59 + Markdown.GetHashCode();
            }

            if (ConversationDisconnect != null)
            {
                hash = hash * 59 + ConversationDisconnect.GetHashCode();
            }

            if (ConversationClear != null)
            {
                hash = hash * 59 + ConversationClear.GetHashCode();
            }

            if (Humanize != null)
            {
                hash = hash * 59 + Humanize.GetHashCode();
            }

            if (Notifications != null)
            {
                hash = hash * 59 + Notifications.GetHashCode();
            }

            return hash;
        }
    }
}
