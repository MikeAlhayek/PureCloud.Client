using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAsyncScheduleResponseStatus
/// </summary>
public enum BuAsyncScheduleResponseStatus
{
    /// <summary>
    /// Processing
    /// </summary>
    [JsonPropertyName("Processing")]
    Processing,

    /// <summary>
    /// Complete
    /// </summary>
    [JsonPropertyName("Complete")]
    Complete,

    /// <summary>
    /// Canceled
    /// </summary>
    [JsonPropertyName("Canceled")]
    Canceled,

    /// <summary>
    /// Error
    /// </summary>
    [JsonPropertyName("Error")]
    Error
}
