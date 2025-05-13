using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyOutcomeEventsNotificationOutcomeAchievedMessage
{
    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    public JourneyOutcomeEventsNotificationOutcome Outcome { get; set; }

    /// <summary>
    /// Gets or Sets Browser
    /// </summary>
    public JourneyOutcomeEventsNotificationBrowser Browser { get; set; }

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
    public JourneyOutcomeEventsNotificationDevice Device { get; set; }

    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    public JourneyOutcomeEventsNotificationGeoLocation Geolocation { get; set; }

    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    public JourneyOutcomeEventsNotificationMktCampaign MktCampaign { get; set; }

    /// <summary>
    /// Gets or Sets VisitReferrer
    /// </summary>
    public JourneyOutcomeEventsNotificationReferrer VisitReferrer { get; set; }

    /// <summary>
    /// Gets or Sets AssociatedValue
    /// </summary>
    public JourneyOutcomeEventsNotificationAssociatedValue AssociatedValue { get; set; }
}
