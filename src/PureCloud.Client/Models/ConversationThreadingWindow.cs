using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationThreadingWindow
/// </summary>

public partial class ConversationThreadingWindow : IEquatable<ConversationThreadingWindow>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationThreadingWindow" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationThreadingWindow() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationThreadingWindow" /> class.
    /// </summary>
    /// <param name="Settings">The conversation threading window timeout (Minutes) for each messaging type (required).</param>
    public ConversationThreadingWindow(List<ConversationThreadingWindowSetting> Settings = null)
    {
        this.Settings = Settings;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The conversation threading window timeout (Minutes) for each messaging type
    /// </summary>
    /// <value>The conversation threading window timeout (Minutes) for each messaging type</value>
    [JsonPropertyName("settings")]
    public List<ConversationThreadingWindowSetting> Settings { get; set; }



    /// <summary>
    /// The default conversation threading window timeout (Minutes)
    /// </summary>
    /// <value>The default conversation threading window timeout (Minutes)</value>
    [JsonPropertyName("defaultTimeoutMinutes")]
    public long? DefaultTimeoutMinutes { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationThreadingWindow {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
        sb.Append("  DefaultTimeoutMinutes: ").Append(DefaultTimeoutMinutes).Append("\n");
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
        return Equals(obj as ConversationThreadingWindow);
    }

    /// <summary>
    /// Returns true if ConversationThreadingWindow instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationThreadingWindow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationThreadingWindow other)
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
                Settings == other.Settings ||
                Settings != null &&
                Settings.SequenceEqual(other.Settings)
            ) &&
            (
                DefaultTimeoutMinutes == other.DefaultTimeoutMinutes ||
                DefaultTimeoutMinutes != null &&
                DefaultTimeoutMinutes.Equals(other.DefaultTimeoutMinutes)
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

            if (Settings != null)
            {
                hash = hash * 59 + Settings.GetHashCode();
            }

            if (DefaultTimeoutMinutes != null)
            {
                hash = hash * 59 + DefaultTimeoutMinutes.GetHashCode();
            }

            return hash;
        }
    }
}
