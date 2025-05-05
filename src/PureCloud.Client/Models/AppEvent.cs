using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AppEvent
/// </summary>

public partial class AppEvent : IEquatable<AppEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AppEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AppEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AppEvent" /> class.
    /// </summary>
    /// <param name="EventName">Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered). (required).</param>
    /// <param name="ScreenName">The name of the screen in the app that the event took place. (required).</param>
    /// <param name="App">Application that the customer is interacting with. (required).</param>
    /// <param name="Device">Customer&#39;s device. (required).</param>
    /// <param name="IpAddress">Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses..</param>
    /// <param name="IpOrganization">Customer&#39;s IP-based organization or ISP name..</param>
    /// <param name="Geolocation">Customer&#39;s geolocation..</param>
    /// <param name="SdkLibrary">SDK library used to generate the event..</param>
    /// <param name="NetworkConnectivity">Information relating to the device&#39;s network connectivity..</param>
    /// <param name="MktCampaign">Marketing / traffic source information..</param>
    /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
    /// <param name="Attributes">User-defined attributes associated with a particular event. (required).</param>
    /// <param name="Traits">Traits are attributes intrinsic to the customer that may be sent in selected events. Examples are email, name, phone. (required).</param>
    public AppEvent(string EventName = null, string ScreenName = null, JourneyApp App = null, Device Device = null, string IpAddress = null, string IpOrganization = null, JourneyGeolocation Geolocation = null, SdkLibrary SdkLibrary = null, NetworkConnectivity NetworkConnectivity = null, JourneyCampaign MktCampaign = null, string SearchQuery = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null)
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
    /// Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered).
    /// </summary>
    /// <value>Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered).</value>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }



    /// <summary>
    /// The name of the screen in the app that the event took place.
    /// </summary>
    /// <value>The name of the screen in the app that the event took place.</value>
    [JsonPropertyName("screenName")]
    public string ScreenName { get; set; }



    /// <summary>
    /// Application that the customer is interacting with.
    /// </summary>
    /// <value>Application that the customer is interacting with.</value>
    [JsonPropertyName("app")]
    public JourneyApp App { get; set; }



    /// <summary>
    /// Customer&#39;s device.
    /// </summary>
    /// <value>Customer&#39;s device.</value>
    [JsonPropertyName("device")]
    public Device Device { get; set; }



    /// <summary>
    /// Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses.
    /// </summary>
    /// <value>Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses.</value>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }



    /// <summary>
    /// Customer&#39;s IP-based organization or ISP name.
    /// </summary>
    /// <value>Customer&#39;s IP-based organization or ISP name.</value>
    [JsonPropertyName("ipOrganization")]
    public string IpOrganization { get; set; }



    /// <summary>
    /// Customer&#39;s geolocation.
    /// </summary>
    /// <value>Customer&#39;s geolocation.</value>
    [JsonPropertyName("geolocation")]
    public JourneyGeolocation Geolocation { get; set; }



    /// <summary>
    /// SDK library used to generate the event.
    /// </summary>
    /// <value>SDK library used to generate the event.</value>
    [JsonPropertyName("sdkLibrary")]
    public SdkLibrary SdkLibrary { get; set; }



    /// <summary>
    /// Information relating to the device&#39;s network connectivity.
    /// </summary>
    /// <value>Information relating to the device&#39;s network connectivity.</value>
    [JsonPropertyName("networkConnectivity")]
    public NetworkConnectivity NetworkConnectivity { get; set; }



    /// <summary>
    /// Marketing / traffic source information.
    /// </summary>
    /// <value>Marketing / traffic source information.</value>
    [JsonPropertyName("mktCampaign")]
    public JourneyCampaign MktCampaign { get; set; }



    /// <summary>
    /// Represents the keywords in a customer search query.
    /// </summary>
    /// <value>Represents the keywords in a customer search query.</value>
    [JsonPropertyName("searchQuery")]
    public string SearchQuery { get; set; }



    /// <summary>
    /// User-defined attributes associated with a particular event.
    /// </summary>
    /// <value>User-defined attributes associated with a particular event.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



    /// <summary>
    /// Traits are attributes intrinsic to the customer that may be sent in selected events. Examples are email, name, phone.
    /// </summary>
    /// <value>Traits are attributes intrinsic to the customer that may be sent in selected events. Examples are email, name, phone.</value>
    [JsonPropertyName("traits")]
    public Dictionary<string, CustomEventAttribute> Traits { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AppEvent {\n");

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
        return Equals(obj as AppEvent);
    }

    /// <summary>
    /// Returns true if AppEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of AppEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AppEvent other)
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
