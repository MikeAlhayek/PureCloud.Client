namespace PureCloud.Client.Models;

/// <summary>
/// The status of the data ingestion rule.
/// </summary>
public enum OpenDataIngestionRuleResponseStatus
{
    /// <summary>
    /// Active
    /// </summary>
    Active,

    /// <summary>
    /// Deleted
    /// </summary>
    Deleted,

    /// <summary>
    /// Error
    /// </summary>
    Error,

    /// <summary>
    /// Paused
    /// </summary>
    Paused
}