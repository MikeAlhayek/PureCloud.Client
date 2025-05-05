using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAppEventsNotificationAppMessage
/// </summary>

public partial class JourneyAppEventsNotificationAppMessage : IEquatable<JourneyAppEventsNotificationAppMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAppEventsNotificationAppMessage" /> class.
    /// </summary>
    /// <param name="EventName">EventName.</param>
    /// <param name="ScreenName">ScreenName.</param>
    /// <param name="App">App.</param>
    /// <param name="Device">Device.</param>
    /// <param name="IpAddress">IpAddress.</param>
    /// <param name="IpOrganization">IpOrganization.</param>
    /// <param name="Geolocation">Geolocation.</param>
    /// <param name="SdkLibrary">SdkLibrary.</param>
    /// <param name="NetworkConnectivity">NetworkConnectivity.</param>
    /// <param name="MktCampaign">MktCampaign.</param>
    /// <param name="SearchQuery">SearchQuery.</param>
    /// <param name="Attributes">Attributes.</param>
    /// <param name="Traits">Traits.</param>
    public JourneyAppEventsNotificationAppMessage(string EventName = null, string ScreenName = null, JourneyAppEventsNotificationApp App = null, JourneyAppEventsNotificationDevice Device = null, string IpAddress = null, string IpOrganization = null, JourneyAppEventsNotificationGeoLocation Geolocation = null, JourneyAppEventsNotificationSdkLibrary SdkLibrary = null, JourneyAppEventsNotificationNetworkConnectivity NetworkConnectivity = null, JourneyAppEventsNotificationMktCampaign MktCampaign = null, string SearchQuery = null, Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Attributes = null, Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Traits = null)
    {
        this.EventName = EventName;
        this.ScreenName = ScreenName;
        this.App = App;
        this.Device = Device;
        this.IpAddress = IpAddress;
        this.IpOrganization = IpOrganization;
        this.Geolocation = Geolocation;
        this.SdkLibrary = SdkLibrary;
        this.NetworkConnectivity = NetworkConnectivity;
        this.MktCampaign = MktCampaign;
        this.SearchQuery = SearchQuery;
        this.Attributes = Attributes;
        this.Traits = Traits;

    }



    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }



    /// <summary>
    /// Gets or Sets ScreenName
    /// </summary>
    [JsonPropertyName("screenName")]
    public string ScreenName { get; set; }



    /// <summary>
    /// Gets or Sets App
    /// </summary>
    [JsonPropertyName("app")]
    public JourneyAppEventsNotificationApp App { get; set; }



    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    [JsonPropertyName("device")]
    public JourneyAppEventsNotificationDevice Device { get; set; }



    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }



    /// <summary>
    /// Gets or Sets IpOrganization
    /// </summary>
    [JsonPropertyName("ipOrganization")]
    public string IpOrganization { get; set; }



    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    [JsonPropertyName("geolocation")]
    public JourneyAppEventsNotificationGeoLocation Geolocation { get; set; }



    /// <summary>
    /// Gets or Sets SdkLibrary
    /// </summary>
    [JsonPropertyName("sdkLibrary")]
    public JourneyAppEventsNotificationSdkLibrary SdkLibrary { get; set; }



    /// <summary>
    /// Gets or Sets NetworkConnectivity
    /// </summary>
    [JsonPropertyName("networkConnectivity")]
    public JourneyAppEventsNotificationNetworkConnectivity NetworkConnectivity { get; set; }



    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    [JsonPropertyName("mktCampaign")]
    public JourneyAppEventsNotificationMktCampaign MktCampaign { get; set; }



    /// <summary>
    /// Gets or Sets SearchQuery
    /// </summary>
    [JsonPropertyName("searchQuery")]
    public string SearchQuery { get; set; }



    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Attributes { get; set; }



    /// <summary>
    /// Gets or Sets Traits
    /// </summary>
    [JsonPropertyName("traits")]
    public Dictionary<string, JourneyAppEventsNotificationCustomEventAttribute> Traits { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAppEventsNotificationAppMessage {\n");

        sb.Append("  EventName: ").Append(EventName).Append("\n");
        sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
        sb.Append("  App: ").Append(App).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  SdkLibrary: ").Append(SdkLibrary).Append("\n");
        sb.Append("  NetworkConnectivity: ").Append(NetworkConnectivity).Append("\n");
        sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
        sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Traits: ").Append(Traits).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as JourneyAppEventsNotificationAppMessage);
    }

    /// <summary>
    /// Returns true if JourneyAppEventsNotificationAppMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAppEventsNotificationAppMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAppEventsNotificationAppMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventName == other.EventName ||
                EventName != null &&
                EventName.Equals(other.EventName)
            ) &&
            (
                ScreenName == other.ScreenName ||
                ScreenName != null &&
                ScreenName.Equals(other.ScreenName)
            ) &&
            (
                App == other.App ||
                App != null &&
                App.Equals(other.App)
            ) &&
            (
                Device == other.Device ||
                Device != null &&
                Device.Equals(other.Device)
            ) &&
            (
                IpAddress == other.IpAddress ||
                IpAddress != null &&
                IpAddress.Equals(other.IpAddress)
            ) &&
            (
                IpOrganization == other.IpOrganization ||
                IpOrganization != null &&
                IpOrganization.Equals(other.IpOrganization)
            ) &&
            (
                Geolocation == other.Geolocation ||
                Geolocation != null &&
                Geolocation.Equals(other.Geolocation)
            ) &&
            (
                SdkLibrary == other.SdkLibrary ||
                SdkLibrary != null &&
                SdkLibrary.Equals(other.SdkLibrary)
            ) &&
            (
                NetworkConnectivity == other.NetworkConnectivity ||
                NetworkConnectivity != null &&
                NetworkConnectivity.Equals(other.NetworkConnectivity)
            ) &&
            (
                MktCampaign == other.MktCampaign ||
                MktCampaign != null &&
                MktCampaign.Equals(other.MktCampaign)
            ) &&
            (
                SearchQuery == other.SearchQuery ||
                SearchQuery != null &&
                SearchQuery.Equals(other.SearchQuery)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                Traits == other.Traits ||
                Traits != null &&
                Traits.SequenceEqual(other.Traits)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (EventName != null)
            {
                hash = hash * 59 + EventName.GetHashCode();
            }

            if (ScreenName != null)
            {
                hash = hash * 59 + ScreenName.GetHashCode();
            }

            if (App != null)
            {
                hash = hash * 59 + App.GetHashCode();
            }

            if (Device != null)
            {
                hash = hash * 59 + Device.GetHashCode();
            }

            if (IpAddress != null)
            {
                hash = hash * 59 + IpAddress.GetHashCode();
            }

            if (IpOrganization != null)
            {
                hash = hash * 59 + IpOrganization.GetHashCode();
            }

            if (Geolocation != null)
            {
                hash = hash * 59 + Geolocation.GetHashCode();
            }

            if (SdkLibrary != null)
            {
                hash = hash * 59 + SdkLibrary.GetHashCode();
            }

            if (NetworkConnectivity != null)
            {
                hash = hash * 59 + NetworkConnectivity.GetHashCode();
            }

            if (MktCampaign != null)
            {
                hash = hash * 59 + MktCampaign.GetHashCode();
            }

            if (SearchQuery != null)
            {
                hash = hash * 59 + SearchQuery.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (Traits != null)
            {
                hash = hash * 59 + Traits.GetHashCode();
            }

            return hash;
        }
    }
}
