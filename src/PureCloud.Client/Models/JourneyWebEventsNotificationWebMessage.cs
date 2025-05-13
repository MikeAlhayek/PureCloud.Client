using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyWebEventsNotificationWebMessage
{
    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    public string EventName { get; set; }

    /// <summary>
    /// Gets or Sets TotalEventCount
    /// </summary>
    public long? TotalEventCount { get; set; }

    /// <summary>
    /// Gets or Sets TotalPageviewCount
    /// </summary>
    public long? TotalPageviewCount { get; set; }

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
    /// Gets or Sets SearchQuery
    /// </summary>
    public string SearchQuery { get; set; }

    /// <summary>
    /// Gets or Sets Authenticated
    /// </summary>
    public bool? Authenticated { get; set; }

    /// <summary>
    /// Gets or Sets Browser
    /// </summary>
    public JourneyWebEventsNotificationBrowser Browser { get; set; }

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
    /// Gets or Sets Page
    /// </summary>
    public JourneyWebEventsNotificationPage Page { get; set; }

    /// <summary>
    /// Gets or Sets Referrer
    /// </summary>
    public JourneyWebEventsNotificationReferrer Referrer { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    public Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets Traits
    /// </summary>
    public Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Traits { get; set; }

}
