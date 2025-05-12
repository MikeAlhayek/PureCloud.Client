using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class JourneyWebActionEventsNotificationWebActionMessage
{
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    public JourneyWebActionEventsNotificationEventAction Action { get; set; }

    /// <summary>
    /// Gets or Sets ActionTarget
    /// </summary>
    public JourneyWebActionEventsNotificationActionTarget ActionTarget { get; set; }

    /// <summary>
    /// Gets or Sets ActionMap
    /// </summary>
    public JourneyWebActionEventsNotificationActionMap ActionMap { get; set; }

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
    public JourneyWebActionEventsNotificationBrowser Browser { get; set; }

    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    public JourneyWebActionEventsNotificationDevice Device { get; set; }

    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    public JourneyWebActionEventsNotificationGeoLocation Geolocation { get; set; }

    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    public JourneyWebActionEventsNotificationMktCampaign MktCampaign { get; set; }

    /// <summary>
    /// Gets or Sets VisitReferrer
    /// </summary>
    public JourneyWebActionEventsNotificationReferrer VisitReferrer { get; set; }

    /// <summary>
    /// Gets or Sets TimeToDisposition
    /// </summary>
    public long? TimeToDisposition { get; set; }
}
