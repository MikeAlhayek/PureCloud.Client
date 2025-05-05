using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptionTopicTranscriptResult
/// </summary>

public partial class TranscriptionTopicTranscriptResult : IEquatable<TranscriptionTopicTranscriptResult>
{
    /// <summary>
    /// Gets or Sets Channel
    /// </summary>
    
    public enum ChannelEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Internal for "INTERNAL"
        /// </summary>
        [EnumMember(Value = "INTERNAL")]
        Internal,

        /// <summary>
        /// Enum External for "EXTERNAL"
        /// </summary>
        [EnumMember(Value = "EXTERNAL")]
        External,

        /// <summary>
        /// Enum Both for "BOTH"
        /// </summary>
        [EnumMember(Value = "BOTH")]
        Both
    }
    /// <summary>
    /// Gets or Sets Channel
    /// </summary>
    [JsonPropertyName("channel")]
    public ChannelEnum? Channel { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptionTopicTranscriptResult" /> class.
    /// </summary>
    /// <param name="UtteranceId">UtteranceId.</param>
    /// <param name="IsFinal">IsFinal.</param>
    /// <param name="Channel">Channel.</param>
    /// <param name="Alternatives">Alternatives.</param>
    /// <param name="AgentAssistantId">AgentAssistantId.</param>
    /// <param name="EngineProvider">EngineProvider.</param>
    /// <param name="EngineId">EngineId.</param>
    /// <param name="EngineName">EngineName.</param>
    /// <param name="Dialect">Dialect.</param>
    /// <param name="SpeechTextAnalyticsProgramId">SpeechTextAnalyticsProgramId.</param>
    /// <param name="AgentAssistEnabled">AgentAssistEnabled.</param>
    /// <param name="VoiceTranscriptionEnabled">VoiceTranscriptionEnabled.</param>
    public TranscriptionTopicTranscriptResult(string UtteranceId = null, bool? IsFinal = null, ChannelEnum? Channel = null, List<TranscriptionTopicTranscriptAlternative> Alternatives = null, string AgentAssistantId = null, string EngineProvider = null, string EngineId = null, string EngineName = null, string Dialect = null, string SpeechTextAnalyticsProgramId = null, bool? AgentAssistEnabled = null, bool? VoiceTranscriptionEnabled = null)
    {
        this.UtteranceId = UtteranceId;
        this.IsFinal = IsFinal;
        this.Channel = Channel;
        this.Alternatives = Alternatives;
        this.AgentAssistantId = AgentAssistantId;
        this.EngineProvider = EngineProvider;
        this.EngineId = EngineId;
        this.EngineName = EngineName;
        this.Dialect = Dialect;
        this.SpeechTextAnalyticsProgramId = SpeechTextAnalyticsProgramId;
        this.AgentAssistEnabled = AgentAssistEnabled;
        this.VoiceTranscriptionEnabled = VoiceTranscriptionEnabled;

    }



    /// <summary>
    /// Gets or Sets UtteranceId
    /// </summary>
    [JsonPropertyName("utteranceId")]
    public string UtteranceId { get; set; }



    /// <summary>
    /// Gets or Sets IsFinal
    /// </summary>
    [JsonPropertyName("isFinal")]
    public bool? IsFinal { get; set; }





    /// <summary>
    /// Gets or Sets Alternatives
    /// </summary>
    [JsonPropertyName("alternatives")]
    public List<TranscriptionTopicTranscriptAlternative> Alternatives { get; set; }



    /// <summary>
    /// Gets or Sets AgentAssistantId
    /// </summary>
    [JsonPropertyName("agentAssistantId")]
    public string AgentAssistantId { get; set; }



    /// <summary>
    /// Gets or Sets EngineProvider
    /// </summary>
    [JsonPropertyName("engineProvider")]
    public string EngineProvider { get; set; }



    /// <summary>
    /// Gets or Sets EngineId
    /// </summary>
    [JsonPropertyName("engineId")]
    public string EngineId { get; set; }



    /// <summary>
    /// Gets or Sets EngineName
    /// </summary>
    [JsonPropertyName("engineName")]
    public string EngineName { get; set; }



    /// <summary>
    /// Gets or Sets Dialect
    /// </summary>
    [JsonPropertyName("dialect")]
    public string Dialect { get; set; }



    /// <summary>
    /// Gets or Sets SpeechTextAnalyticsProgramId
    /// </summary>
    [JsonPropertyName("speechTextAnalyticsProgramId")]
    public string SpeechTextAnalyticsProgramId { get; set; }



    /// <summary>
    /// Gets or Sets AgentAssistEnabled
    /// </summary>
    [JsonPropertyName("agentAssistEnabled")]
    public bool? AgentAssistEnabled { get; set; }



    /// <summary>
    /// Gets or Sets VoiceTranscriptionEnabled
    /// </summary>
    [JsonPropertyName("voiceTranscriptionEnabled")]
    public bool? VoiceTranscriptionEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranscriptionTopicTranscriptResult {\n");

        sb.Append("  UtteranceId: ").Append(UtteranceId).Append("\n");
        sb.Append("  IsFinal: ").Append(IsFinal).Append("\n");
        sb.Append("  Channel: ").Append(Channel).Append("\n");
        sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
        sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
        sb.Append("  EngineProvider: ").Append(EngineProvider).Append("\n");
        sb.Append("  EngineId: ").Append(EngineId).Append("\n");
        sb.Append("  EngineName: ").Append(EngineName).Append("\n");
        sb.Append("  Dialect: ").Append(Dialect).Append("\n");
        sb.Append("  SpeechTextAnalyticsProgramId: ").Append(SpeechTextAnalyticsProgramId).Append("\n");
        sb.Append("  AgentAssistEnabled: ").Append(AgentAssistEnabled).Append("\n");
        sb.Append("  VoiceTranscriptionEnabled: ").Append(VoiceTranscriptionEnabled).Append("\n");
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
        return Equals(obj as TranscriptionTopicTranscriptResult);
    }

    /// <summary>
    /// Returns true if TranscriptionTopicTranscriptResult instances are equal
    /// </summary>
    /// <param name="other">Instance of TranscriptionTopicTranscriptResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranscriptionTopicTranscriptResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UtteranceId == other.UtteranceId ||
                UtteranceId != null &&
                UtteranceId.Equals(other.UtteranceId)
            ) &&
            (
                IsFinal == other.IsFinal ||
                IsFinal != null &&
                IsFinal.Equals(other.IsFinal)
            ) &&
            (
                Channel == other.Channel ||
                Channel != null &&
                Channel.Equals(other.Channel)
            ) &&
            (
                Alternatives == other.Alternatives ||
                Alternatives != null &&
                Alternatives.SequenceEqual(other.Alternatives)
            ) &&
            (
                AgentAssistantId == other.AgentAssistantId ||
                AgentAssistantId != null &&
                AgentAssistantId.Equals(other.AgentAssistantId)
            ) &&
            (
                EngineProvider == other.EngineProvider ||
                EngineProvider != null &&
                EngineProvider.Equals(other.EngineProvider)
            ) &&
            (
                EngineId == other.EngineId ||
                EngineId != null &&
                EngineId.Equals(other.EngineId)
            ) &&
            (
                EngineName == other.EngineName ||
                EngineName != null &&
                EngineName.Equals(other.EngineName)
            ) &&
            (
                Dialect == other.Dialect ||
                Dialect != null &&
                Dialect.Equals(other.Dialect)
            ) &&
            (
                SpeechTextAnalyticsProgramId == other.SpeechTextAnalyticsProgramId ||
                SpeechTextAnalyticsProgramId != null &&
                SpeechTextAnalyticsProgramId.Equals(other.SpeechTextAnalyticsProgramId)
            ) &&
            (
                AgentAssistEnabled == other.AgentAssistEnabled ||
                AgentAssistEnabled != null &&
                AgentAssistEnabled.Equals(other.AgentAssistEnabled)
            ) &&
            (
                VoiceTranscriptionEnabled == other.VoiceTranscriptionEnabled ||
                VoiceTranscriptionEnabled != null &&
                VoiceTranscriptionEnabled.Equals(other.VoiceTranscriptionEnabled)
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
            if (UtteranceId != null)
            {
                hash = hash * 59 + UtteranceId.GetHashCode();
            }

            if (IsFinal != null)
            {
                hash = hash * 59 + IsFinal.GetHashCode();
            }

            if (Channel != null)
            {
                hash = hash * 59 + Channel.GetHashCode();
            }

            if (Alternatives != null)
            {
                hash = hash * 59 + Alternatives.GetHashCode();
            }

            if (AgentAssistantId != null)
            {
                hash = hash * 59 + AgentAssistantId.GetHashCode();
            }

            if (EngineProvider != null)
            {
                hash = hash * 59 + EngineProvider.GetHashCode();
            }

            if (EngineId != null)
            {
                hash = hash * 59 + EngineId.GetHashCode();
            }

            if (EngineName != null)
            {
                hash = hash * 59 + EngineName.GetHashCode();
            }

            if (Dialect != null)
            {
                hash = hash * 59 + Dialect.GetHashCode();
            }

            if (SpeechTextAnalyticsProgramId != null)
            {
                hash = hash * 59 + SpeechTextAnalyticsProgramId.GetHashCode();
            }

            if (AgentAssistEnabled != null)
            {
                hash = hash * 59 + AgentAssistEnabled.GetHashCode();
            }

            if (VoiceTranscriptionEnabled != null)
            {
                hash = hash * 59 + VoiceTranscriptionEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
