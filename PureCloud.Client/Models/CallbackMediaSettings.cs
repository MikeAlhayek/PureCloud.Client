namespace PureCloud.Client.Models;

public sealed class CallbackMediaSettings
{
    /// <summary>
    /// The mode callbacks will use on this queue.
    /// </summary>
    /// <value>The mode callbacks will use on this queue.</value>
    public CallbackMediaMode? Mode { get; set; }

    /// <summary>
    /// The action to take if a live voice is detected during the outbound call of a customer first callback.
    /// </summary>
    /// <value>The action to take if a live voice is detected during the outbound call of a customer first callback.</value>
    public LiveVoiceReactionType? LiveVoiceReactionType { get; set; }

    /// <summary>
    /// The action to take if an answering machine is detected during the outbound call of a customer first callback.
    /// </summary>
    /// <value>The action to take if an answering machine is detected during the outbound call of a customer first callback.</value>
    public AnsweringMachineReactionType? AnsweringMachineReactionType { get; set; }

    /// <summary>
    /// Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.
    /// </summary>
    /// <value>Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.</value>
    public bool? EnableAutoAnswer { get; set; }

    /// <summary>
    /// The alerting timeout for the media type, in seconds
    /// </summary>
    /// <value>The alerting timeout for the media type, in seconds</value>
    public int? AlertingTimeoutSeconds { get; set; }

    /// <summary>
    /// The targeted service level for the media type
    /// </summary>
    /// <value>The targeted service level for the media type</value>
    public ServiceLevel ServiceLevel { get; set; }

    /// <summary>
    /// How long to play the alerting tone for an auto-answer interaction
    /// </summary>
    /// <value>How long to play the alerting tone for an auto-answer interaction</value>
    public double? AutoAnswerAlertToneSeconds { get; set; }

    /// <summary>
    /// How long to play the alerting tone for a manual-answer interaction
    /// </summary>
    /// <value>How long to play the alerting tone for a manual-answer interaction</value>
    public double? ManualAnswerAlertToneSeconds { get; set; }

    /// <summary>
    /// Map of media subtype to media subtype specific settings.
    /// </summary>
    /// <value>Map of media subtype to media subtype specific settings.</value>
    public Dictionary<string, BaseMediaSettings> SubTypeSettings { get; set; }

    /// <summary>
    /// Flag to enable Auto-Dial and Auto-End automation for callbacks on this queue.
    /// </summary>
    /// <value>Flag to enable Auto-Dial and Auto-End automation for callbacks on this queue.</value>
    public bool? EnableAutoDialAndEnd { get; set; }

    /// <summary>
    /// Time in seconds after agent connects to callback before outgoing call is auto-dialed. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.
    /// </summary>
    /// <value>Time in seconds after agent connects to callback before outgoing call is auto-dialed. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.</value>
    public int? AutoDialDelaySeconds { get; set; }

    /// <summary>
    /// Time in seconds after agent disconnects from the outgoing call before the encasing callback is auto-ended. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.
    /// </summary>
    /// <value>Time in seconds after agent disconnects from the outgoing call before the encasing callback is auto-ended. Allowable values in range 0 - 1200 seconds. Defaults to 300 seconds.</value>
    public int? AutoEndDelaySeconds { get; set; }

    /// <summary>
    /// Controls the maximum number of outbound calls at one time when mode is CustomerFirst.
    /// </summary>
    /// <value>Controls the maximum number of outbound calls at one time when mode is CustomerFirst.</value>
    public double? PacingModifier { get; set; }

    /// <summary>
    /// The inbound flow to transfer to if a live voice is detected during the outbound call of a customer first callback.
    /// </summary>
    /// <value>The inbound flow to transfer to if a live voice is detected during the outbound call of a customer first callback.</value>
    public DomainEntityRef LiveVoiceFlow { get; set; }

    /// <summary>
    /// The inbound flow to transfer to if an answering machine is detected during the outbound call of a customer first callback when answeringMachineReactionType is set to TransferToFlow.
    /// </summary>
    /// <value>The inbound flow to transfer to if an answering machine is detected during the outbound call of a customer first callback when answeringMachineReactionType is set to TransferToFlow.</value>
    public DomainEntityRef AnsweringMachineFlow { get; set; }
}
