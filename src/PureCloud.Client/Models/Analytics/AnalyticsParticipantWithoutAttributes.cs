namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsParticipantWithoutAttributes
{
    /// <summary>
    /// Reason for which participant flagged conversation
    /// </summary>
    /// <value>Reason for which participant flagged conversation</value>
    public AnalyticsParticipantWithoutAttributesFlaggedReason? FlaggedReason { get; set; }

    /// <summary>
    /// The participant's purpose
    /// </summary>
    /// <value>The participant's purpose</value>
    public AnalyticsParticipantWithoutAttributesPurpose? Purpose { get; set; }

    /// <summary>
    /// External contact identifier
    /// </summary>
    /// <value>External contact identifier</value>
    public string ExternalContactId { get; set; }

    /// <summary>
    /// External organization identifier
    /// </summary>
    /// <value>External organization identifier</value>
    public string ExternalOrganizationId { get; set; }

    /// <summary>
    /// Unique identifier for the participant
    /// </summary>
    /// <value>Unique identifier for the participant</value>
    public string ParticipantId { get; set; }

    /// <summary>
    /// A human readable name identifying the participant
    /// </summary>
    /// <value>A human readable name identifying the participant</value>
    public string ParticipantName { get; set; }

    /// <summary>
    /// Flag determining if a screen recording was started or not
    /// </summary>
    /// <value>Flag determining if a screen recording was started or not</value>
    public bool? ScreenRecording { get; set; }

    /// <summary>
    /// The team ID the user is a member of
    /// </summary>
    /// <value>The team ID the user is a member of</value>
    public string TeamId { get; set; }

    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    public string UserId { get; set; }

    /// <summary>
    /// List of sessions associated to this participant
    /// </summary>
    /// <value>List of sessions associated to this participant</value>
    public IEnumerable<AnalyticsSession> Sessions { get; set; }
}
