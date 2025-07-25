namespace PureCloud.Client.Models;

/// <summary>
/// The assignment state of the workitem.
/// </summary>
public enum WorkitemAssignmentState
{
    Unknown,
    AcdStarted,
    Alerting,
    AlertTimeout,
    AcdCancelled,
    Terminated,
    Idle,
    Declined,
    Connected,
    Disconnected,
    Parked,
    Held
}