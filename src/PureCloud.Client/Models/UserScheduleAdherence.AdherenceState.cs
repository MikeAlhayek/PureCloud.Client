namespace PureCloud.Client.Models;

/// <summary>
/// The user's current adherence state
/// </summary>
public enum AdherenceState
{
    InAdherence,
    OutOfAdherence,
    Unscheduled,
    Unknown,
    Ignored,
    Explained
}