using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallbackMediaSettings
/// </summary>
[DataContract]
public partial class CallbackMediaSettings : IEquatable<CallbackMediaSettings>
{
    /// <summary>
    /// The mode callbacks will use on this queue.
    /// </summary>
    /// <value>The mode callbacks will use on this queue.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Agentfirst for "AgentFirst"
        /// </summary>
        [EnumMember(Value = "AgentFirst")]
        Agentfirst,

        /// <summary>
        /// Enum Customerfirst for "CustomerFirst"
        /// </summary>
        [EnumMember(Value = "CustomerFirst")]
        Customerfirst
    }
    /// <summary>
    /// The action to take if a live voice is detected during the outbound call of a customer first callback.
    /// </summary>
    /// <value>The action to take if a live voice is detected during the outbound call of a customer first callback.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LiveVoiceReactionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Hangup for "HangUp"
        /// </summary>
        [EnumMember(Value = "HangUp")]
        Hangup,

        /// <summary>
        /// Enum Transfertoqueue for "TransferToQueue"
        /// </summary>
        [EnumMember(Value = "TransferToQueue")]
        Transfertoqueue,

        /// <summary>
        /// Enum Transfertoflow for "TransferToFlow"
        /// </summary>
        [EnumMember(Value = "TransferToFlow")]
        Transfertoflow
    }
    /// <summary>
    /// The action to take if an answering machine is detected during the outbound call of a customer first callback.
    /// </summary>
    /// <value>The action to take if an answering machine is detected during the outbound call of a customer first callback.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AnsweringMachineReactionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Hangup for "HangUp"
        /// </summary>
        [EnumMember(Value = "HangUp")]
        Hangup,

        /// <summary>
        /// Enum Transfertoqueue for "TransferToQueue"
        /// </summary>
        [EnumMember(Value = "TransferToQueue")]
        Transfertoqueue,

        /// <summary>
        /// Enum Transfertoflow for "TransferToFlow"
        /// </summary>
        [EnumMember(Value = "TransferToFlow")]
        Transfertoflow
    }
    /// <summary>
    /// The mode callbacks will use on this queue.
    /// </summary>
    /// <value>The mode callbacks will use on this queue.</value>
    [DataMember(Name = "mode", EmitDefaultValue = false)]
    public ModeEnum? Mode { get; set; }
    /// <summary>
    /// The action to take if a live voice is detected during the outbound call of a customer first callback.
    /// </summary>
    /// <value>The action to take if a live voice is detected during the outbound call of a customer first callback.</value>
    [DataMember(Name = "liveVoiceReactionType", EmitDefaultValue = false)]
    public LiveVoiceReactionTypeEnum? LiveVoiceReactionType { get; set; }
    /// <summary>
    /// The action to take if an answering machine is detected during the outbound call of a customer first callback.
    /// </summary>
    /// <value>The action to take if an answering machine is detected during the outbound call of a customer first callback.</value>
    [DataMember(Name = "answeringMachineReactionType", EmitDefaultValue = false)]
    public AnsweringMachineReactionTypeEnum? AnsweringMachineReactionType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CallbackMediaSettings" /> class.
    /// </summary>
    /// <param name="EnableAutoAnswer">Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings..</param>
    /// <param name="AlertingTimeoutSeconds">The alerting timeout for the media type, in seconds.</param>
    /// <param name="ServiceLevel">The targeted service level for the media type.</param>
    /// <param name="AutoAnswerAlertToneSeconds">How long to play the alerting tone for an auto-answer interaction.</param>
    /// <param name="ManualAnswerAlertToneSeconds">How long to play the alerting tone for a manual-answer interaction.</param>
    /// <param name="SubTypeSettings">Map of media subtype to media subtype specific settings..</param>
    /// <param name="Mode">The mode callbacks will use on this queue..</param>
    /// <param name="EnableAutoDialAndEnd">Flag to enable Auto-Dial and Auto-End automation for callbacks on this queue..</param>
    /// <param name="AutoDialDelaySeconds">Time in seconds after agent connects to callback before outgoing call is auto-dialed. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds..</param>
    /// <param name="AutoEndDelaySeconds">Time in seconds after agent disconnects from the outgoing call before the encasing callback is auto-ended. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds..</param>
    /// <param name="PacingModifier">Controls the maximum number of outbound calls at one time when mode is CustomerFirst..</param>
    /// <param name="LiveVoiceReactionType">The action to take if a live voice is detected during the outbound call of a customer first callback..</param>
    /// <param name="LiveVoiceFlow">The inbound flow to transfer to if a live voice is detected during the outbound call of a customer first callback..</param>
    /// <param name="AnsweringMachineReactionType">The action to take if an answering machine is detected during the outbound call of a customer first callback..</param>
    /// <param name="AnsweringMachineFlow">The inbound flow to transfer to if an answering machine is detected during the outbound call of a customer first callback when answeringMachineReactionType is set to TransferToFlow..</param>
    public CallbackMediaSettings(bool? EnableAutoAnswer = null, int? AlertingTimeoutSeconds = null, ServiceLevel ServiceLevel = null, double? AutoAnswerAlertToneSeconds = null, double? ManualAnswerAlertToneSeconds = null, Dictionary<string, BaseMediaSettings> SubTypeSettings = null, ModeEnum? Mode = null, bool? EnableAutoDialAndEnd = null, int? AutoDialDelaySeconds = null, int? AutoEndDelaySeconds = null, double? PacingModifier = null, LiveVoiceReactionTypeEnum? LiveVoiceReactionType = null, DomainEntityRef LiveVoiceFlow = null, AnsweringMachineReactionTypeEnum? AnsweringMachineReactionType = null, DomainEntityRef AnsweringMachineFlow = null)
    {
        this.EnableAutoAnswer = EnableAutoAnswer;
        this.AlertingTimeoutSeconds = AlertingTimeoutSeconds;
        this.ServiceLevel = ServiceLevel;
        this.AutoAnswerAlertToneSeconds = AutoAnswerAlertToneSeconds;
        this.ManualAnswerAlertToneSeconds = ManualAnswerAlertToneSeconds;
        this.SubTypeSettings = SubTypeSettings;
        this.Mode = Mode;
        this.EnableAutoDialAndEnd = EnableAutoDialAndEnd;
        this.AutoDialDelaySeconds = AutoDialDelaySeconds;
        this.AutoEndDelaySeconds = AutoEndDelaySeconds;
        this.PacingModifier = PacingModifier;
        this.LiveVoiceReactionType = LiveVoiceReactionType;
        this.LiveVoiceFlow = LiveVoiceFlow;
        this.AnsweringMachineReactionType = AnsweringMachineReactionType;
        this.AnsweringMachineFlow = AnsweringMachineFlow;

    }



    /// <summary>
    /// Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.
    /// </summary>
    /// <value>Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.</value>
    [DataMember(Name = "enableAutoAnswer", EmitDefaultValue = false)]
    public bool? EnableAutoAnswer { get; set; }



    /// <summary>
    /// The alerting timeout for the media type, in seconds
    /// </summary>
    /// <value>The alerting timeout for the media type, in seconds</value>
    [DataMember(Name = "alertingTimeoutSeconds", EmitDefaultValue = false)]
    public int? AlertingTimeoutSeconds { get; set; }



    /// <summary>
    /// The targeted service level for the media type
    /// </summary>
    /// <value>The targeted service level for the media type</value>
    [DataMember(Name = "serviceLevel", EmitDefaultValue = false)]
    public ServiceLevel ServiceLevel { get; set; }



    /// <summary>
    /// How long to play the alerting tone for an auto-answer interaction
    /// </summary>
    /// <value>How long to play the alerting tone for an auto-answer interaction</value>
    [DataMember(Name = "autoAnswerAlertToneSeconds", EmitDefaultValue = false)]
    public double? AutoAnswerAlertToneSeconds { get; set; }



    /// <summary>
    /// How long to play the alerting tone for a manual-answer interaction
    /// </summary>
    /// <value>How long to play the alerting tone for a manual-answer interaction</value>
    [DataMember(Name = "manualAnswerAlertToneSeconds", EmitDefaultValue = false)]
    public double? ManualAnswerAlertToneSeconds { get; set; }



    /// <summary>
    /// Map of media subtype to media subtype specific settings.
    /// </summary>
    /// <value>Map of media subtype to media subtype specific settings.</value>
    [DataMember(Name = "subTypeSettings", EmitDefaultValue = false)]
    public Dictionary<string, BaseMediaSettings> SubTypeSettings { get; set; }





    /// <summary>
    /// Flag to enable Auto-Dial and Auto-End automation for callbacks on this queue.
    /// </summary>
    /// <value>Flag to enable Auto-Dial and Auto-End automation for callbacks on this queue.</value>
    [DataMember(Name = "enableAutoDialAndEnd", EmitDefaultValue = false)]
    public bool? EnableAutoDialAndEnd { get; set; }



    /// <summary>
    /// Time in seconds after agent connects to callback before outgoing call is auto-dialed. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.
    /// </summary>
    /// <value>Time in seconds after agent connects to callback before outgoing call is auto-dialed. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.</value>
    [DataMember(Name = "autoDialDelaySeconds", EmitDefaultValue = false)]
    public int? AutoDialDelaySeconds { get; set; }



    /// <summary>
    /// Time in seconds after agent disconnects from the outgoing call before the encasing callback is auto-ended. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.
    /// </summary>
    /// <value>Time in seconds after agent disconnects from the outgoing call before the encasing callback is auto-ended. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.</value>
    [DataMember(Name = "autoEndDelaySeconds", EmitDefaultValue = false)]
    public int? AutoEndDelaySeconds { get; set; }



    /// <summary>
    /// Controls the maximum number of outbound calls at one time when mode is CustomerFirst.
    /// </summary>
    /// <value>Controls the maximum number of outbound calls at one time when mode is CustomerFirst.</value>
    [DataMember(Name = "pacingModifier", EmitDefaultValue = false)]
    public double? PacingModifier { get; set; }





    /// <summary>
    /// The inbound flow to transfer to if a live voice is detected during the outbound call of a customer first callback.
    /// </summary>
    /// <value>The inbound flow to transfer to if a live voice is detected during the outbound call of a customer first callback.</value>
    [DataMember(Name = "liveVoiceFlow", EmitDefaultValue = false)]
    public DomainEntityRef LiveVoiceFlow { get; set; }





    /// <summary>
    /// The inbound flow to transfer to if an answering machine is detected during the outbound call of a customer first callback when answeringMachineReactionType is set to TransferToFlow.
    /// </summary>
    /// <value>The inbound flow to transfer to if an answering machine is detected during the outbound call of a customer first callback when answeringMachineReactionType is set to TransferToFlow.</value>
    [DataMember(Name = "answeringMachineFlow", EmitDefaultValue = false)]
    public DomainEntityRef AnsweringMachineFlow { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallbackMediaSettings {\n");

        sb.Append("  EnableAutoAnswer: ").Append(EnableAutoAnswer).Append("\n");
        sb.Append("  AlertingTimeoutSeconds: ").Append(AlertingTimeoutSeconds).Append("\n");
        sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
        sb.Append("  AutoAnswerAlertToneSeconds: ").Append(AutoAnswerAlertToneSeconds).Append("\n");
        sb.Append("  ManualAnswerAlertToneSeconds: ").Append(ManualAnswerAlertToneSeconds).Append("\n");
        sb.Append("  SubTypeSettings: ").Append(SubTypeSettings).Append("\n");
        sb.Append("  Mode: ").Append(Mode).Append("\n");
        sb.Append("  EnableAutoDialAndEnd: ").Append(EnableAutoDialAndEnd).Append("\n");
        sb.Append("  AutoDialDelaySeconds: ").Append(AutoDialDelaySeconds).Append("\n");
        sb.Append("  AutoEndDelaySeconds: ").Append(AutoEndDelaySeconds).Append("\n");
        sb.Append("  PacingModifier: ").Append(PacingModifier).Append("\n");
        sb.Append("  LiveVoiceReactionType: ").Append(LiveVoiceReactionType).Append("\n");
        sb.Append("  LiveVoiceFlow: ").Append(LiveVoiceFlow).Append("\n");
        sb.Append("  AnsweringMachineReactionType: ").Append(AnsweringMachineReactionType).Append("\n");
        sb.Append("  AnsweringMachineFlow: ").Append(AnsweringMachineFlow).Append("\n");
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
        return Equals(obj as CallbackMediaSettings);
    }

    /// <summary>
    /// Returns true if CallbackMediaSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of CallbackMediaSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallbackMediaSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EnableAutoAnswer == other.EnableAutoAnswer ||
                EnableAutoAnswer != null &&
                EnableAutoAnswer.Equals(other.EnableAutoAnswer)
            ) &&
            (
                AlertingTimeoutSeconds == other.AlertingTimeoutSeconds ||
                AlertingTimeoutSeconds != null &&
                AlertingTimeoutSeconds.Equals(other.AlertingTimeoutSeconds)
            ) &&
            (
                ServiceLevel == other.ServiceLevel ||
                ServiceLevel != null &&
                ServiceLevel.Equals(other.ServiceLevel)
            ) &&
            (
                AutoAnswerAlertToneSeconds == other.AutoAnswerAlertToneSeconds ||
                AutoAnswerAlertToneSeconds != null &&
                AutoAnswerAlertToneSeconds.Equals(other.AutoAnswerAlertToneSeconds)
            ) &&
            (
                ManualAnswerAlertToneSeconds == other.ManualAnswerAlertToneSeconds ||
                ManualAnswerAlertToneSeconds != null &&
                ManualAnswerAlertToneSeconds.Equals(other.ManualAnswerAlertToneSeconds)
            ) &&
            (
                SubTypeSettings == other.SubTypeSettings ||
                SubTypeSettings != null &&
                SubTypeSettings.SequenceEqual(other.SubTypeSettings)
            ) &&
            (
                Mode == other.Mode ||
                Mode != null &&
                Mode.Equals(other.Mode)
            ) &&
            (
                EnableAutoDialAndEnd == other.EnableAutoDialAndEnd ||
                EnableAutoDialAndEnd != null &&
                EnableAutoDialAndEnd.Equals(other.EnableAutoDialAndEnd)
            ) &&
            (
                AutoDialDelaySeconds == other.AutoDialDelaySeconds ||
                AutoDialDelaySeconds != null &&
                AutoDialDelaySeconds.Equals(other.AutoDialDelaySeconds)
            ) &&
            (
                AutoEndDelaySeconds == other.AutoEndDelaySeconds ||
                AutoEndDelaySeconds != null &&
                AutoEndDelaySeconds.Equals(other.AutoEndDelaySeconds)
            ) &&
            (
                PacingModifier == other.PacingModifier ||
                PacingModifier != null &&
                PacingModifier.Equals(other.PacingModifier)
            ) &&
            (
                LiveVoiceReactionType == other.LiveVoiceReactionType ||
                LiveVoiceReactionType != null &&
                LiveVoiceReactionType.Equals(other.LiveVoiceReactionType)
            ) &&
            (
                LiveVoiceFlow == other.LiveVoiceFlow ||
                LiveVoiceFlow != null &&
                LiveVoiceFlow.Equals(other.LiveVoiceFlow)
            ) &&
            (
                AnsweringMachineReactionType == other.AnsweringMachineReactionType ||
                AnsweringMachineReactionType != null &&
                AnsweringMachineReactionType.Equals(other.AnsweringMachineReactionType)
            ) &&
            (
                AnsweringMachineFlow == other.AnsweringMachineFlow ||
                AnsweringMachineFlow != null &&
                AnsweringMachineFlow.Equals(other.AnsweringMachineFlow)
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
            if (EnableAutoAnswer != null)
            {
                hash = hash * 59 + EnableAutoAnswer.GetHashCode();
            }

            if (AlertingTimeoutSeconds != null)
            {
                hash = hash * 59 + AlertingTimeoutSeconds.GetHashCode();
            }

            if (ServiceLevel != null)
            {
                hash = hash * 59 + ServiceLevel.GetHashCode();
            }

            if (AutoAnswerAlertToneSeconds != null)
            {
                hash = hash * 59 + AutoAnswerAlertToneSeconds.GetHashCode();
            }

            if (ManualAnswerAlertToneSeconds != null)
            {
                hash = hash * 59 + ManualAnswerAlertToneSeconds.GetHashCode();
            }

            if (SubTypeSettings != null)
            {
                hash = hash * 59 + SubTypeSettings.GetHashCode();
            }

            if (Mode != null)
            {
                hash = hash * 59 + Mode.GetHashCode();
            }

            if (EnableAutoDialAndEnd != null)
            {
                hash = hash * 59 + EnableAutoDialAndEnd.GetHashCode();
            }

            if (AutoDialDelaySeconds != null)
            {
                hash = hash * 59 + AutoDialDelaySeconds.GetHashCode();
            }

            if (AutoEndDelaySeconds != null)
            {
                hash = hash * 59 + AutoEndDelaySeconds.GetHashCode();
            }

            if (PacingModifier != null)
            {
                hash = hash * 59 + PacingModifier.GetHashCode();
            }

            if (LiveVoiceReactionType != null)
            {
                hash = hash * 59 + LiveVoiceReactionType.GetHashCode();
            }

            if (LiveVoiceFlow != null)
            {
                hash = hash * 59 + LiveVoiceFlow.GetHashCode();
            }

            if (AnsweringMachineReactionType != null)
            {
                hash = hash * 59 + AnsweringMachineReactionType.GetHashCode();
            }

            if (AnsweringMachineFlow != null)
            {
                hash = hash * 59 + AnsweringMachineFlow.GetHashCode();
            }

            return hash;
        }
    }
}
