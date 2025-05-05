using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AppEventRequest
/// </summary>

public partial class AppEventRequest : IEquatable<AppEventRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AppEventRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AppEventRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AppEventRequest" /> class.
    /// </summary>
    /// <param name="EventName">Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. screen_viewed, search_performed, user_registered. (required).</param>
    /// <param name="ScreenName">The name of the screen, view, or fragment in the app where the event took place. (required).</param>
    /// <param name="App">Application that the customer is interacting with. (required).</param>
    /// <param name="Device">Customer&#39;s device. (required).</param>
    /// <param name="SdkLibrary">SDK library used to generate the event..</param>
    /// <param name="NetworkConnectivity">Information relating to the device&#39;s network connectivity..</param>
    /// <param name="ReferrerUrl">The referrer URL of the first event in the app session..</param>
    /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
    /// <param name="Attributes">User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level..</param>
    /// <param name="Traits">Traits are attributes intrinsic to the customer that may be sent in selected events, (e.g. email, lastName, cellPhone). Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions..</param>
    /// <param name="CustomerCookieId">A UUID representing the customer associated with the app event. This is expected to be set per application install or device and can be used to identify a single customer across multiple sessions. This identifier, along with others passed as traits, is used for identity resolution. (required).</param>
    /// <param name="CreatedDate">UTC timestamp indicating when the event actually took place, events older than an hour will be rejected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public AppEventRequest(string EventName = null, string ScreenName = null, JourneyApp App = null, RequestDevice Device = null, SdkLibrary SdkLibrary = null, NetworkConnectivity NetworkConnectivity = null, string ReferrerUrl = null, string SearchQuery = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null, string CustomerCookieId = null, DateTime? CreatedDate = null)
    {
        this.EventName = EventName;
        this.ScreenName = ScreenName;
        this.App = App;
        this.Device = Device;
        this.SdkLibrary = SdkLibrary;
        this.NetworkConnectivity = NetworkConnectivity;
        this.ReferrerUrl = ReferrerUrl;
        this.SearchQuery = SearchQuery;
        this.Attributes = Attributes;
        this.Traits = Traits;
        this.CustomerCookieId = CustomerCookieId;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. screen_viewed, search_performed, user_registered.
    /// </summary>
    /// <value>Represents the action the customer performed. Event types are created for each unique event name and can be faceted on in segment and outcome conditions. A valid event name must only contain alphanumeric characters and underscores. A good event name is typically an object followed by the action performed in past tense, e.g. screen_viewed, search_performed, user_registered.</value>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }



    /// <summary>
    /// The name of the screen, view, or fragment in the app where the event took place.
    /// </summary>
    /// <value>The name of the screen, view, or fragment in the app where the event took place.</value>
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
    public RequestDevice Device { get; set; }



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
    /// The referrer URL of the first event in the app session.
    /// </summary>
    /// <value>The referrer URL of the first event in the app session.</value>
    [JsonPropertyName("referrerUrl")]
    public string ReferrerUrl { get; set; }



    /// <summary>
    /// Represents the keywords in a customer search query.
    /// </summary>
    /// <value>Represents the keywords in a customer search query.</value>
    [JsonPropertyName("searchQuery")]
    public string SearchQuery { get; set; }



    /// <summary>
    /// User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level.
    /// </summary>
    /// <value>User-defined attributes associated with a particular event. These attributes provide additional context about the event. For example, items_in_cart or subscription_level.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



    /// <summary>
    /// Traits are attributes intrinsic to the customer that may be sent in selected events, (e.g. email, lastName, cellPhone). Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions.
    /// </summary>
    /// <value>Traits are attributes intrinsic to the customer that may be sent in selected events, (e.g. email, lastName, cellPhone). Traits are used to collect information for identity resolution. For example, the same person might be using an application on different devices which might create two sessions with different customerIds. Additional information can be provided as traits to help link those two sessions and customers to a single external contact through common identifiers that were submitted via a form fill, message, or other input in both sessions.</value>
    [JsonPropertyName("traits")]
    public Dictionary<string, CustomEventAttribute> Traits { get; set; }



    /// <summary>
    /// A UUID representing the customer associated with the app event. This is expected to be set per application install or device and can be used to identify a single customer across multiple sessions. This identifier, along with others passed as traits, is used for identity resolution.
    /// </summary>
    /// <value>A UUID representing the customer associated with the app event. This is expected to be set per application install or device and can be used to identify a single customer across multiple sessions. This identifier, along with others passed as traits, is used for identity resolution.</value>
    [JsonPropertyName("customerCookieId")]
    public string CustomerCookieId { get; set; }



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
        sb.Append("class AppEventRequest {\n");

        sb.Append("  EventName: ").Append(EventName).Append("\n");
        sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
        sb.Append("  App: ").Append(App).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  SdkLibrary: ").Append(SdkLibrary).Append("\n");
        sb.Append("  NetworkConnectivity: ").Append(NetworkConnectivity).Append("\n");
        sb.Append("  ReferrerUrl: ").Append(ReferrerUrl).Append("\n");
        sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Traits: ").Append(Traits).Append("\n");
        sb.Append("  CustomerCookieId: ").Append(CustomerCookieId).Append("\n");
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
        return Equals(obj as AppEventRequest);
    }

    /// <summary>
    /// Returns true if AppEventRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AppEventRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AppEventRequest other)
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
                ReferrerUrl == other.ReferrerUrl ||
                ReferrerUrl != null &&
                ReferrerUrl.Equals(other.ReferrerUrl)
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
            ) &&
            (
                CustomerCookieId == other.CustomerCookieId ||
                CustomerCookieId != null &&
                CustomerCookieId.Equals(other.CustomerCookieId)
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

            if (SdkLibrary != null)
            {
                hash = hash * 59 + SdkLibrary.GetHashCode();
            }

            if (NetworkConnectivity != null)
            {
                hash = hash * 59 + NetworkConnectivity.GetHashCode();
            }

            if (ReferrerUrl != null)
            {
                hash = hash * 59 + ReferrerUrl.GetHashCode();
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

            if (CustomerCookieId != null)
            {
                hash = hash * 59 + CustomerCookieId.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}
