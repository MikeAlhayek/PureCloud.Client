namespace PureCloud.Client.Models;

public sealed class IdleTokenTimeout
{
    /// <summary>
    /// Token timeout length in seconds. Must be at least 5 minutes and 8 hours or less (if HIPAA is disabled) or 15 minutes or less (if HIPAA is enabled).
    /// </summary>
    public int? IdleTokenTimeoutSeconds { get; set; }

    /// <summary>
    /// Indicates whether the Token Timeout should be enabled or disabled.
    /// </summary>
    public bool? EnableIdleTokenTimeout { get; set; }
}
