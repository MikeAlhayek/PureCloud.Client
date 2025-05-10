namespace PureCloud.Client.Models;

public sealed class AdjustableLiveSpeakerDetection
{
    /// <summary>
    /// Modes to tune between speed to live speaker detection vs accuracy.
    /// </summary>
    /// <value>Modes to tune between speed to live speaker detection vs accuracy.</value>
    public AdjustableLiveSpeakerDetectionMode? Mode { get; set; }

    /// <summary>
    /// ISO 8601 formatted relative duration (e.g., PT30.8427419S for 30.8 seconds), calculated on line connect.
    /// </summary>
    /// <value>ISO 8601 formatted relative duration (e.g., PT30.8427419S for 30.8 seconds), calculated on line connect.</value>
    public string PreconnectDuration { get; set; }

    /// <summary>
    /// The name of the event that triggered the ALSD evaluation (e.g., line.connect, speech.generic).
    /// </summary>
    /// <value>The name of the event that triggered the ALSD evaluation (e.g., line.connect, speech.generic).</value>
    public string EventName { get; set; }

    /// <summary>
    /// The output of the ALSD detector, evaluating whether there is likely a person on the call based on the above inputs, and if so, a person is detected early (person disposition name and speech.person analyzer result) and the associated action taken (e.g., speech.person postconnect entry in the disposition table has the action to transfer to a queue).
    /// </summary>
    /// <value>The output of the ALSD detector, evaluating whether there is likely a person on the call based on the above inputs, and if so, a person is detected early (person disposition name and speech.person analyzer result) and the associated action taken (e.g., speech.person postconnect entry in the disposition table has the action to transfer to a queue).</value>
    public bool? IsPersonLikely { get; set; }

    /// <summary>
    /// Number of tone.ring.* analyzer events detected during the call (expected mostly during pre-connect but the last ringback tone detection could potentially complete after line connect, which will increment totalRingbacks still).
    /// </summary>
    /// <value>Number of tone.ring.* analyzer events detected during the call (expected mostly during pre-connect but the last ringback tone detection could potentially complete after line connect, which will increment totalRingbacks still).</value>
    public int? TotalRingbacks { get; set; }

    /// <summary>
    /// Protocol line connect received (answered by a person, machine, busy, fax).
    /// </summary>
    /// <value>Protocol line connect received (answered by a person, machine, busy, fax).</value>
    public bool? LineConnected { get; set; }
}
