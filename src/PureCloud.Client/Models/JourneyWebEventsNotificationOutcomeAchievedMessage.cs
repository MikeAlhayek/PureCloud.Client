using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyWebEventsNotificationOutcomeAchievedMessage
{
    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    public JourneyWebEventsNotificationOutcome Outcome { get; set; }

    /// <summary>
    /// Gets or Sets Browser
    /// </summary>
    public JourneyWebEventsNotificationBrowser Browser { get; set; }

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
    public JourneyWebEventsNotificationDevice Device { get; set; }

    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    public JourneyWebEventsNotificationGeoLocation Geolocation { get; set; }

    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    public JourneyWebEventsNotificationMktCampaign MktCampaign { get; set; }

    /// <summary>
    /// Gets or Sets VisitReferrer
    /// </summary>
    public JourneyWebEventsNotificationReferrer VisitReferrer { get; set; }

    /// <summary>
    /// Gets or Sets AssociatedValue
    /// </summary>
    public JourneyWebEventsNotificationAssociatedValue AssociatedValue { get; set; }
}
