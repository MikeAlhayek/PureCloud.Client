using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneyAppEventsNotificationAppMessage
{
    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    public string EventName { get; set; }

    /// <summary>
    /// Gets or Sets ScreenName
    /// </summary>
    public string ScreenName { get; set; }

    /// <summary>
    /// Gets or Sets App
    /// </summary>
    public JourneyAppEventsNotificationApp App { get; set; }

    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    public JourneyAppEventsNotificationDevice Device { get; set; }

    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    public string IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets IpOrganization
    /// </summary>
    public string IpOrganization { get; set; }

    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    public JourneyAppEventsNotificationGeoLocation Geolocation { get; set; }

    /// <summary>
    /// Gets or Sets SdkLibrary
    /// </summary>
    public JourneyAppEventsNotificationSdkLibrary SdkLibrary { get; set; }

    /// <summary>
    /// Gets or Sets NetworkConnectivity
    /// </summary>
    public JourneyAppEventsNotificationNetworkConnectivity NetworkConnectivity { get; set; }

    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    public JourneyAppEventsNotificationMktCampaign MktCampaign { get; set; }

    /// <summary>
    /// Gets or Sets SearchQuery
    /// </summary>
    public string SearchQuery { get; set; }

    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    public Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Attributes { get; set; }

    /// <summary>
    /// Gets or Sets Traits
    /// </summary>
    public Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Traits { get; set; }
}
