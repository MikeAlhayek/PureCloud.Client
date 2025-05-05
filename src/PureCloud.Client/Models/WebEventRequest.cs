using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebEventRequest
/// </summary>

public partial class WebEventRequest : IEquatable<WebEventRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebEventRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebEventRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebEventRequest" /> class.
    /// </summary>
    /// <param name="CustomerCookieId">A UUID representing the customer making the request. (required).</param>
    /// <param name="EventName">Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered. (required).</param>
    /// <param name="Page">The webpage where the user interaction occurred. (required).</param>
    /// <param name="UserAgentString">Override for HTTP User-Agent string from request header (see https://tools.ietf.org/html/rfc1945#section-10.15)..</param>
    /// <param name="Browser">Customer&#39;s browser..</param>
    /// <param name="Device">Customer&#39;s device..</param>
    /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
    /// <param name="IpAddress">Customer&#39;s IP address..</param>
    /// <param name="ReferrerUrl">Identifies the referrer URL that originally generated the request for the current page being viewed..</param>
    /// <param name="Attributes">User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level..</param>
    /// <param name="Traits">Traits are attributes intrinsic to the customer that may be sent in selected events, e.g. email, lastName, cellPhone. Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions..</param>
    /// <param name="CreatedDate">UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public WebEventRequest(string CustomerCookieId = null, string EventName = null, RequestPage Page = null, string UserAgentString = null, WebEventBrowser Browser = null, WebEventDevice Device = null, string SearchQuery = null, string IpAddress = null, string ReferrerUrl = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null, DateTime? CreatedDate = null)
    {
        this.CustomerCookieId = CustomerCookieId;
        this.EventName = EventName;
        this.Page = Page;
        this.UserAgentString = UserAgentString;
        this.Browser = Browser;
        this.Device = Device;
        this.SearchQuery = SearchQuery;
        this.IpAddress = IpAddress;
        this.ReferrerUrl = ReferrerUrl;
        this.Attributes = Attributes;
        this.Traits = Traits;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// A UUID representing the customer making the request.
    /// </summary>
    /// <value>A UUID representing the customer making the request.</value>
    [JsonPropertyName("customerCookieId")]
    public string CustomerCookieId { get; set; }



    /// <summary>
    /// Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered.
    /// </summary>
    /// <value>Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. page_viewed, order_completed, user_registered.</value>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }



    /// <summary>
    /// The webpage where the user interaction occurred.
    /// </summary>
    /// <value>The webpage where the user interaction occurred.</value>
    [JsonPropertyName("page")]
    public RequestPage Page { get; set; }



    /// <summary>
    /// Override for HTTP User-Agent string from request header (see https://tools.ietf.org/html/rfc1945#section-10.15).
    /// </summary>
    /// <value>Override for HTTP User-Agent string from request header (see https://tools.ietf.org/html/rfc1945#section-10.15).</value>
    [JsonPropertyName("userAgentString")]
    public string UserAgentString { get; set; }



    /// <summary>
    /// Customer&#39;s browser.
    /// </summary>
    /// <value>Customer&#39;s browser.</value>
    [JsonPropertyName("browser")]
    public WebEventBrowser Browser { get; set; }



    /// <summary>
    /// Customer&#39;s device.
    /// </summary>
    /// <value>Customer&#39;s device.</value>
    [JsonPropertyName("device")]
    public WebEventDevice Device { get; set; }



    /// <summary>
    /// Represents the keywords in a customer search query.
    /// </summary>
    /// <value>Represents the keywords in a customer search query.</value>
    [JsonPropertyName("searchQuery")]
    public string SearchQuery { get; set; }



    /// <summary>
    /// Customer&#39;s IP address.
    /// </summary>
    /// <value>Customer&#39;s IP address.</value>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }



    /// <summary>
    /// Identifies the referrer URL that originally generated the request for the current page being viewed.
    /// </summary>
    /// <value>Identifies the referrer URL that originally generated the request for the current page being viewed.</value>
    [JsonPropertyName("referrerUrl")]
    public string ReferrerUrl { get; set; }



    /// <summary>
    /// User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level.
    /// </summary>
    /// <value>User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



    /// <summary>
    /// Traits are attributes intrinsic to the customer that may be sent in selected events, e.g. email, lastName, cellPhone. Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions.
    /// </summary>
    /// <value>Traits are attributes intrinsic to the customer that may be sent in selected events, e.g. email, lastName, cellPhone. Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions.</value>
    [JsonPropertyName("traits")]
    public Dictionary<string, CustomEventAttribute> Traits { get; set; }



    /// <summary>
    /// UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebEventRequest {\n");

        sb.Append("  CustomerCookieId: ").Append(CustomerCookieId).Append("\n");
        sb.Append("  EventName: ").Append(EventName).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
        sb.Append("  Browser: ").Append(Browser).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  ReferrerUrl: ").Append(ReferrerUrl).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Traits: ").Append(Traits).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
        return Equals(obj as WebEventRequest);
    }

    /// <summary>
    /// Returns true if WebEventRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WebEventRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebEventRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CustomerCookieId == other.CustomerCookieId ||
                CustomerCookieId != null &&
                CustomerCookieId.Equals(other.CustomerCookieId)
            ) &&
            (
                EventName == other.EventName ||
                EventName != null &&
                EventName.Equals(other.EventName)
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
                SearchQuery == other.SearchQuery ||
                SearchQuery != null &&
                SearchQuery.Equals(other.SearchQuery)
            ) &&
            (
                IpAddress == other.IpAddress ||
                IpAddress != null &&
                IpAddress.Equals(other.IpAddress)
            ) &&
            (
                ReferrerUrl == other.ReferrerUrl ||
                ReferrerUrl != null &&
                ReferrerUrl.Equals(other.ReferrerUrl)
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
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
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
            if (CustomerCookieId != null)
            {
                hash = hash * 59 + CustomerCookieId.GetHashCode();
            }

            if (EventName != null)
            {
                hash = hash * 59 + EventName.GetHashCode();
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

            if (SearchQuery != null)
            {
                hash = hash * 59 + SearchQuery.GetHashCode();
            }

            if (IpAddress != null)
            {
                hash = hash * 59 + IpAddress.GetHashCode();
            }

            if (ReferrerUrl != null)
            {
                hash = hash * 59 + ReferrerUrl.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (Traits != null)
            {
                hash = hash * 59 + Traits.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}
