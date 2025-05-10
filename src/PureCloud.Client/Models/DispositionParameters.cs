namespace PureCloud.Client.Models;

public sealed class DispositionParameters
{
    /// <summary>
    /// ALSD evaluation inputs and output (isPersonalLikely) of the ALSD detector the last time it ran on the call (could be multiple times)
    /// </summary>
    /// <value>ALSD evaluation inputs and output (isPersonalLikely) of the ALSD detector the last time it ran on the call (could be multiple times)</value>
    public AdjustableLiveSpeakerDetection AdjustableLiveSpeakerDetection { get; set; }
}
