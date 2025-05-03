using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QuestionSettings
/// </summary>

public partial class QuestionSettings : IEquatable<QuestionSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QuestionSettings" /> class.
    /// </summary>
    /// <param name="QuestionContextId">The context id of the question in the group.</param>
    /// <param name="Settings">Settings.</param>
    public QuestionSettings(string QuestionContextId = null, AiScoringSetting Settings = null)
    {
        this.QuestionContextId = QuestionContextId;
        this.Settings = Settings;

    }



    /// <summary>
    /// The context id of the question in the group
    /// </summary>
    /// <value>The context id of the question in the group</value>
    [JsonPropertyName("questionContextId")]
    public string QuestionContextId { get; set; }



    /// <summary>
    /// Gets or Sets Settings
    /// </summary>
    [JsonPropertyName("settings")]
    public AiScoringSetting Settings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QuestionSettings {\n");

        sb.Append("  QuestionContextId: ").Append(QuestionContextId).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
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
        return Equals(obj as QuestionSettings);
    }

    /// <summary>
    /// Returns true if QuestionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of QuestionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QuestionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QuestionContextId == other.QuestionContextId ||
                QuestionContextId != null &&
                QuestionContextId.Equals(other.QuestionContextId)
            ) &&
            (
                Settings == other.Settings ||
                Settings != null &&
                Settings.Equals(other.Settings)
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
            if (QuestionContextId != null)
            {
                hash = hash * 59 + QuestionContextId.GetHashCode();
            }

            if (Settings != null)
            {
                hash = hash * 59 + Settings.GetHashCode();
            }

            return hash;
        }
    }
}
