using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SpeechTextAnalyticsSettingsResponse
/// </summary>

public partial class SpeechTextAnalyticsSettingsResponse : IEquatable<SpeechTextAnalyticsSettingsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpeechTextAnalyticsSettingsResponse" /> class.
    /// </summary>
    /// <param name="DefaultProgram">Setting to choose name for the default program for topic detection.</param>
    /// <param name="ExpectedDialects">Setting to choose expected dialects.</param>
    /// <param name="TextAnalyticsEnabled">Setting to enable/disable text analytics.</param>
    /// <param name="AgentEmpathyEnabled">Setting to enable/disable Agent Empathy setting.</param>
    public SpeechTextAnalyticsSettingsResponse(AddressableEntityRef DefaultProgram = null, List<string> ExpectedDialects = null, bool? TextAnalyticsEnabled = null, bool? AgentEmpathyEnabled = null)
    {
        this.DefaultProgram = DefaultProgram;
        this.ExpectedDialects = ExpectedDialects;
        this.TextAnalyticsEnabled = TextAnalyticsEnabled;
        this.AgentEmpathyEnabled = AgentEmpathyEnabled;

    }



    /// <summary>
    /// Setting to choose name for the default program for topic detection
    /// </summary>
    /// <value>Setting to choose name for the default program for topic detection</value>
    [JsonPropertyName("defaultProgram")]
    public AddressableEntityRef DefaultProgram { get; set; }



    /// <summary>
    /// Setting to choose expected dialects
    /// </summary>
    /// <value>Setting to choose expected dialects</value>
    [JsonPropertyName("expectedDialects")]
    public List<string> ExpectedDialects { get; set; }



    /// <summary>
    /// Setting to enable/disable text analytics
    /// </summary>
    /// <value>Setting to enable/disable text analytics</value>
    [JsonPropertyName("textAnalyticsEnabled")]
    public bool? TextAnalyticsEnabled { get; set; }



    /// <summary>
    /// Setting to enable/disable Agent Empathy setting
    /// </summary>
    /// <value>Setting to enable/disable Agent Empathy setting</value>
    [JsonPropertyName("agentEmpathyEnabled")]
    public bool? AgentEmpathyEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SpeechTextAnalyticsSettingsResponse {\n");

        sb.Append("  DefaultProgram: ").Append(DefaultProgram).Append("\n");
        sb.Append("  ExpectedDialects: ").Append(ExpectedDialects).Append("\n");
        sb.Append("  TextAnalyticsEnabled: ").Append(TextAnalyticsEnabled).Append("\n");
        sb.Append("  AgentEmpathyEnabled: ").Append(AgentEmpathyEnabled).Append("\n");
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
        return Equals(obj as SpeechTextAnalyticsSettingsResponse);
    }

    /// <summary>
    /// Returns true if SpeechTextAnalyticsSettingsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SpeechTextAnalyticsSettingsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SpeechTextAnalyticsSettingsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DefaultProgram == other.DefaultProgram ||
                DefaultProgram != null &&
                DefaultProgram.Equals(other.DefaultProgram)
            ) &&
            (
                ExpectedDialects == other.ExpectedDialects ||
                ExpectedDialects != null &&
                ExpectedDialects.SequenceEqual(other.ExpectedDialects)
            ) &&
            (
                TextAnalyticsEnabled == other.TextAnalyticsEnabled ||
                TextAnalyticsEnabled != null &&
                TextAnalyticsEnabled.Equals(other.TextAnalyticsEnabled)
            ) &&
            (
                AgentEmpathyEnabled == other.AgentEmpathyEnabled ||
                AgentEmpathyEnabled != null &&
                AgentEmpathyEnabled.Equals(other.AgentEmpathyEnabled)
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
            if (DefaultProgram != null)
            {
                hash = hash * 59 + DefaultProgram.GetHashCode();
            }

            if (ExpectedDialects != null)
            {
                hash = hash * 59 + ExpectedDialects.GetHashCode();
            }

            if (TextAnalyticsEnabled != null)
            {
                hash = hash * 59 + TextAnalyticsEnabled.GetHashCode();
            }

            if (AgentEmpathyEnabled != null)
            {
                hash = hash * 59 + AgentEmpathyEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
