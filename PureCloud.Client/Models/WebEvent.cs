using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebEvent
/// </summary>

public partial class WebEvent : IEquatable<WebEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebEvent" /> class.
    /// </summary>
    /// <param name="EventName">Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. page_viewed, order_completed, user_registered). (required).</param>
    /// <param name="TotalEventCount">The total count of events performed by the customer across all sessions. (required).</param>
    /// <param name="TotalPageviewCount">The total count of pageviews performed by the customer across all sessions. (required).</param>
    /// <param name="Page">The webpage where the user interaction occurred. (required).</param>
    /// <param name="UserAgentString">HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). (required).</param>
    /// <param name="Browser">Customer&#39;s browser. (required).</param>
    /// <param name="Device">Customer&#39;s device. (required).</param>
    /// <param name="Geolocation">Customer&#39;s geolocation..</param>
    /// <param name="IpAddress">Customer&#39;s IP address. May be null if the business configures the tracker to not collect IP addresses..</param>
    /// <param name="IpOrganization">Customer&#39;s IP-based organization or ISP name..</param>
    /// <param name="MktCampaign">Marketing / traffic source information..</param>
    /// <param name="Referrer">Identifies the page URL that originally generated the request for the current page being viewed..</param>
    /// <param name="Attributes">User-defined attributes associated with a particular event. (required).</param>
    /// <param name="Traits">User-defined traits associated with a particular event. (required).</param>
    /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
    /// <param name="Authenticated">Indicates whether the event was produced during an authenticated session. (required).</param>
    public WebEvent(string EventName = null, int? TotalEventCount = null, int? TotalPageviewCount = null, JourneyPage Page = null, string UserAgentString = null, Browser Browser = null, Device Device = null, JourneyGeolocation Geolocation = null, string IpAddress = null, string IpOrganization = null, JourneyCampaign MktCampaign = null, Referrer Referrer = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null, string SearchQuery = null, bool? Authenticated = null)
    {
        this.EventName = EventName;
        this.TotalEventCount = TotalEventCount;
        this.TotalPageviewCount = TotalPageviewCount;
        this.Page = Page;
        this.UserAgentString = UserAgentString;
        this.Browser = Browser;
        this.Device = Device;
        this.Geolocation = Geolocation;
        this.IpAddress = IpAddress;
        this.IpOrganization = IpOrganization;
        this.MktCampaign = MktCampaign;
        this.Referrer = Referrer;
        this.Attributes = Attributes;
        this.Traits = Traits;
        this.SearchQuery = SearchQuery;
        this.Authenticated = Authenticated;

    }



    /// <summary>
    /// Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. page_viewed, order_completed, user_registered).
    /// </summary>
    /// <value>Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. page_viewed, order_completed, user_registered).</value>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }



    /// <summary>
    /// The total count of events performed by the customer across all sessions.
    /// </summary>
    /// <value>The total count of events performed by the customer across all sessions.</value>
    [JsonPropertyName("totalEventCount")]
    public int? TotalEventCount { get; set; }



    /// <summary>
    /// The total count of pageviews performed by the customer across all sessions.
    /// </summary>
    /// <value>The total count of pageviews performed by the customer across all sessions.</value>
    [JsonPropertyName("totalPageviewCount")]
    public int? TotalPageviewCount { get; set; }



    /// <summary>
    /// The webpage where the user interaction occurred.
    /// </summary>
    /// <value>The webpage where the user interaction occurred.</value>
    [JsonPropertyName("page")]
    public JourneyPage Page { get; set; }



    /// <summary>
    /// HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15).
    /// </summary>
    /// <value>HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15).</value>
    [JsonPropertyName("userAgentString")]
    public string UserAgentString { get; set; }



    /// <summary>
    /// Customer&#39;s browser.
    /// </summary>
    /// <value>Customer&#39;s browser.</value>
    [JsonPropertyName("browser")]
    public Browser Browser { get; set; }



    /// <summary>
    /// Customer&#39;s device.
    /// </summary>
    /// <value>Customer&#39;s device.</value>
    [JsonPropertyName("device")]
    public Device Device { get; set; }



    /// <summary>
    /// Customer&#39;s geolocation.
    /// </summary>
    /// <value>Customer&#39;s geolocation.</value>
    [JsonPropertyName("geolocation")]
    public JourneyGeolocation Geolocation { get; set; }



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
    /// Marketing / traffic source information.
    /// </summary>
    /// <value>Marketing / traffic source information.</value>
    [JsonPropertyName("mktCampaign")]
    public JourneyCampaign MktCampaign { get; set; }



    /// <summary>
    /// Identifies the page URL that originally generated the request for the current page being viewed.
    /// </summary>
    /// <value>Identifies the page URL that originally generated the request for the current page being viewed.</value>
    [JsonPropertyName("referrer")]
    public Referrer Referrer { get; set; }



    /// <summary>
    /// User-defined attributes associated with a particular event.
    /// </summary>
    /// <value>User-defined attributes associated with a particular event.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



    /// <summary>
    /// User-defined traits associated with a particular event.
    /// </summary>
    /// <value>User-defined traits associated with a particular event.</value>
    [JsonPropertyName("traits")]
    public Dictionary<string, CustomEventAttribute> Traits { get; set; }



    /// <summary>
    /// Represents the keywords in a customer search query.
    /// </summary>
    /// <value>Represents the keywords in a customer search query.</value>
    [JsonPropertyName("searchQuery")]
    public string SearchQuery { get; set; }



    /// <summary>
    /// Indicates whether the event was produced during an authenticated session.
    /// </summary>
    /// <value>Indicates whether the event was produced during an authenticated session.</value>
    [JsonPropertyName("authenticated")]
    public bool? Authenticated { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebEvent {\n");

        sb.Append("  EventName: ").Append(EventName).Append("\n");
        sb.Append("  TotalEventCount: ").Append(TotalEventCount).Append("\n");
        sb.Append("  TotalPageviewCount: ").Append(TotalPageviewCount).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
        sb.Append("  Browser: ").Append(Browser).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
        sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
        sb.Append("  Referrer: ").Append(Referrer).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Traits: ").Append(Traits).Append("\n");
        sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
        sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
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
        return Equals(obj as WebEvent);
    }

    /// <summary>
    /// Returns true if WebEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of WebEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebEvent other)
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
                TotalEventCount == other.TotalEventCount ||
                TotalEventCount != null &&
                TotalEventCount.Equals(other.TotalEventCount)
            ) &&
            (
                TotalPageviewCount == other.TotalPageviewCount ||
                TotalPageviewCount != null &&
                TotalPageviewCount.Equals(other.TotalPageviewCount)
            ) &&
            (
                Page == other.Page ||
                Page != null &&
                Page.Equals(other.Page)
            ) &&
            (
                UserAgentString == other.UserAgentString ||
                UserAgentString != null &&
                UserAgentString.Equals(other.UserAgentString)
            ) &&
            (
                Browser == other.Browser ||
                Browser != null &&
                Browser.Equals(other.Browser)
            ) &&
            (
                Device == other.Device ||
                Device != null &&
                Device.Equals(other.Device)
            ) &&
            (
                Geolocation == other.Geolocation ||
                Geolocation != null &&
                Geolocation.Equals(other.Geolocation)
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
                MktCampaign == other.MktCampaign ||
                MktCampaign != null &&
                MktCampaign.Equals(other.MktCampaign)
            ) &&
            (
                Referrer == other.Referrer ||
                Referrer != null &&
                Referrer.Equals(other.Referrer)
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
            ) &&
            (
                SearchQuery == other.SearchQuery ||
                SearchQuery != null &&
                SearchQuery.Equals(other.SearchQuery)
            ) &&
            (
                Authenticated == other.Authenticated ||
                Authenticated != null &&
                Authenticated.Equals(other.Authenticated)
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

            if (TotalEventCount != null)
            {
                hash = hash * 59 + TotalEventCount.GetHashCode();
            }

            if (TotalPageviewCount != null)
            {
                hash = hash * 59 + TotalPageviewCount.GetHashCode();
            }

            if (Page != null)
            {
                hash = hash * 59 + Page.GetHashCode();
            }

            if (UserAgentString != null)
            {
                hash = hash * 59 + UserAgentString.GetHashCode();
            }

            if (Browser != null)
            {
                hash = hash * 59 + Browser.GetHashCode();
            }

            if (Device != null)
            {
                hash = hash * 59 + Device.GetHashCode();
            }

            if (Geolocation != null)
            {
                hash = hash * 59 + Geolocation.GetHashCode();
            }

            if (IpAddress != null)
            {
                hash = hash * 59 + IpAddress.GetHashCode();
            }

            if (IpOrganization != null)
            {
                hash = hash * 59 + IpOrganization.GetHashCode();
            }

            if (MktCampaign != null)
            {
                hash = hash * 59 + MktCampaign.GetHashCode();
            }

            if (Referrer != null)
            {
                hash = hash * 59 + Referrer.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (Traits != null)
            {
                hash = hash * 59 + Traits.GetHashCode();
            }

            if (SearchQuery != null)
            {
                hash = hash * 59 + SearchQuery.GetHashCode();
            }

            if (Authenticated != null)
            {
                hash = hash * 59 + Authenticated.GetHashCode();
            }

            return hash;
        }
    }
}
