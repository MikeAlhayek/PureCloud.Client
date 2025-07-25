namespace PureCloud.Client.Models;

/// <summary>
/// AddAdherenceExplanationAgentRequest
/// </summary>
public sealed class AddAdherenceExplanationAgentRequest
{
    /// <summary>
    /// The type of the adherence explanation
    /// </summary>
    public AdherenceExplanationType Type { get; set; }

    /// <summary>
    /// The start timestamp of the adherence explanation in ISO-8601 format
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The length of the adherence explanation in minutes
    /// </summary>
    public int? LengthMinutes { get; set; }

    /// <summary>
    /// Notes about the adherence explanation
    /// </summary>
    public string Notes { get; set; }
}