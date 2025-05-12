using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyAppEventsNotificationWebActionMessage
{
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    public JourneyAppEventsNotificationEventAction Action { get; set; }

    /// <summary>
    /// Gets or Sets ActionTarget
    /// </summary>
    public JourneyAppEventsNotificationActionTarget ActionTarget { get; set; }

    /// <summary>
    /// Gets or Sets ActionMap
    /// </summary>
    public JourneyAppEventsNotificationActionMap ActionMap { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    public string ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Gets or Sets UserAgentString
    /// </summary>
    public string UserAgentString { get; set; }

    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    public string IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets IpOrganization
    /// </summary>
    public string IpOrganization { get; set; }

    /// <summary>
    /// Gets or Sets Browser
    /// </summary>
    public JourneyAppEventsNotificationBrowser Browser { get; set; }

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
    /// Gets or Sets TimeToDisposition
    /// </summary>
    public long? TimeToDisposition { get; set; }
}
