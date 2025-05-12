using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyAppEventsNotificationOutcomeAchievedMessage
{
    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    public JourneyAppEventsNotificationOutcome Outcome { get; set; }

    /// <summary>
    /// Gets or Sets Browser
    /// </summary>
    public JourneyAppEventsNotificationBrowser Browser { get; set; }

    /// <summary>
    /// Gets or Sets VisitCreatedDate
    /// </summary>
    public DateTime? VisitCreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    public string IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets IpOrganization
    /// </summary>
    public string IpOrganization { get; set; }

    /// <summary>
    /// Gets or Sets UserAgentString
    /// </summary>
    public string UserAgentString { get; set; }

    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    public JourneyAppEventsNotificationDevice Device { get; set; }

    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    public JourneyAppEventsNotificationGeoLocation Geolocation { get; set; }

    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    public JourneyAppEventsNotificationMktCampaign MktCampaign { get; set; }

    /// <summary>
    /// Gets or Sets VisitReferrer
    /// </summary>
    public JourneyAppEventsNotificationReferrer VisitReferrer { get; set; }

    /// <summary>
    /// Gets or Sets AssociatedValue
    /// </summary>
    public JourneyAppEventsNotificationAssociatedValue AssociatedValue { get; set; }
}
