using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AppEventResponse
/// </summary>

public partial class AppEventResponse : IEquatable<AppEventResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AppEventResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AppEventResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AppEventResponse" /> class.
    /// </summary>
    /// <param name="Id">System-generated UUID for the event. (required).</param>
    /// <param name="CustomerId">Identifier of the customer in the source of the event. (required).</param>
    /// <param name="CustomerIdType">Type of identifier for the customer ID (cookie, email etc.). (required).</param>
    /// <param name="EventName">Represents the action the customer performed. A good event name is typically an object followed by the action performed in past tense (e.g. screen_viewed, order_completed, user_registered). (required).</param>
    /// <param name="ScreenName">The name of the screen in the app that the event took place. (required).</param>
    /// <param name="App">Application that the customer is interacting with. (required).</param>
    /// <param name="Device">Customer&#39;s device. (required).</param>
    /// <param name="IpOrganization">Customer&#39;s IP-based organization or ISP name..</param>
    /// <param name="Geolocation">Customer&#39;s geolocation..</param>
    /// <param name="SdkLibrary">SDK library used to generate the event..</param>
    /// <param name="NetworkConnectivity">Information relating to the device&#39;s network connectivity..</param>
    /// <param name="MktCampaign">Marketing / traffic source information..</param>
    /// <param name="Session">The app session the event belongs to. (required).</param>
    /// <param name="SearchQuery">Represents the keywords in a customer search query..</param>
    /// <param name="Attributes">User-defined attributes associated with a particular event. (required).</param>
    /// <param name="Traits">Traits are attributes intrinsic to the customer that may be sent in selected events (e.g. email, name, phone). (required).</param>
    /// <param name="CreatedDate">UTC timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public AppEventResponse(string Id = null, string CustomerId = null, string CustomerIdType = null, string EventName = null, string ScreenName = null, JourneyApp App = null, Device Device = null, string IpOrganization = null, JourneyGeolocation Geolocation = null, SdkLibrary SdkLibrary = null, NetworkConnectivity NetworkConnectivity = null, JourneyCampaign MktCampaign = null, AppEventResponseSession Session = null, string SearchQuery = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttribute> Traits = null, DateTime? CreatedDate = null)
    {
        this.Id = Id;
        this.CustomerId = CustomerId;
        this.CustomerIdType = CustomerIdType;
        this.EventName = EventName;
        this.ScreenName = ScreenName;
        this.App = App;
        this.Device = Device;
        this.IpOrganization = IpOrganization;
        this.Geolocation = Geolocation;
        this.SdkLibrary = SdkLibrary;
        this.NetworkConnectivity = NetworkConnectivity;
        this.MktCampaign = MktCampaign;
        this.Session = Session;
        this.SearchQuery = SearchQuery;
        this.Attributes = Attributes;
        this.Traits = Traits;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// System-generated UUID for the event.
    /// </summary>
    /// <value>System-generated UUID for the event.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Identifier of the customer in the source of the event.
    /// </summary>
    /// <value>Identifier of the customer in the source of the event.</value>
    [JsonPropertyName("customerId")]
    public string CustomerId { get; set; }



    /// <summary>
    /// Type of identifier for the customer ID (cookie, email etc.).
    /// </summary>
    /// <value>Type of identifier for the customer ID (cookie, email etc.).</value>
    [JsonPropertyName("customerIdType")]
    public string CustomerIdType { get; set; }



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
    /// The app session the event belongs to.
    /// </summary>
    /// <value>The app session the event belongs to.</value>
    [JsonPropertyName("session")]
    public AppEventResponseSession Session { get; set; }



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
    /// Traits are attributes intrinsic to the customer that may be sent in selected events (e.g. email, name, phone).
    /// </summary>
    /// <value>Traits are attributes intrinsic to the customer that may be sent in selected events (e.g. email, name, phone).</value>
    [JsonPropertyName("traits")]
    public Dictionary<string, CustomEventAttribute> Traits { get; set; }



    /// <summary>
    /// UTC timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>UTC timestamp indicating when the event actually took place. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AppEventResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
        sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
        sb.Append("  EventName: ").Append(EventName).Append("\n");
        sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
        sb.Append("  App: ").Append(App).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  SdkLibrary: ").Append(SdkLibrary).Append("\n");
        sb.Append("  NetworkConnectivity: ").Append(NetworkConnectivity).Append("\n");
        sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
        sb.Append("  Session: ").Append(Session).Append("\n");
        sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
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
        return Equals(obj as AppEventResponse);
    }

    /// <summary>
    /// Returns true if AppEventResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AppEventResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AppEventResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                CustomerId == other.CustomerId ||
                CustomerId != null &&
                CustomerId.Equals(other.CustomerId)
            ) &&
            (
                CustomerIdType == other.CustomerIdType ||
                CustomerIdType != null &&
                CustomerIdType.Equals(other.CustomerIdType)
            ) &&
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
                Session == other.Session ||
                Session != null &&
                Session.Equals(other.Session)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (CustomerId != null)
            {
                hash = hash * 59 + CustomerId.GetHashCode();
            }

            if (CustomerIdType != null)
            {
                hash = hash * 59 + CustomerIdType.GetHashCode();
            }

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

            if (Session != null)
            {
                hash = hash * 59 + Session.GetHashCode();
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

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}
