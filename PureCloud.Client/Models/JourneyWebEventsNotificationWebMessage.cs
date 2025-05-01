using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyWebEventsNotificationWebMessage
/// </summary>
[DataContract]
public partial class JourneyWebEventsNotificationWebMessage : IEquatable<JourneyWebEventsNotificationWebMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationWebMessage" /> class.
    /// </summary>
    /// <param name="EventName">EventName.</param>
    /// <param name="TotalEventCount">TotalEventCount.</param>
    /// <param name="TotalPageviewCount">TotalPageviewCount.</param>
    /// <param name="UserAgentString">UserAgentString.</param>
    /// <param name="IpAddress">IpAddress.</param>
    /// <param name="IpOrganization">IpOrganization.</param>
    /// <param name="SearchQuery">SearchQuery.</param>
    /// <param name="Authenticated">Authenticated.</param>
    /// <param name="Browser">Browser.</param>
    /// <param name="Device">Device.</param>
    /// <param name="Geolocation">Geolocation.</param>
    /// <param name="MktCampaign">MktCampaign.</param>
    /// <param name="Page">Page.</param>
    /// <param name="Referrer">Referrer.</param>
    /// <param name="Attributes">Attributes.</param>
    /// <param name="Traits">Traits.</param>
    public JourneyWebEventsNotificationWebMessage(string EventName = null, long? TotalEventCount = null, long? TotalPageviewCount = null, string UserAgentString = null, string IpAddress = null, string IpOrganization = null, string SearchQuery = null, bool? Authenticated = null, JourneyWebEventsNotificationBrowser Browser = null, JourneyWebEventsNotificationDevice Device = null, JourneyWebEventsNotificationGeoLocation Geolocation = null, JourneyWebEventsNotificationMktCampaign MktCampaign = null, JourneyWebEventsNotificationPage Page = null, JourneyWebEventsNotificationReferrer Referrer = null, Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Attributes = null, Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Traits = null)
    {
        this.EventName = EventName;
        this.TotalEventCount = TotalEventCount;
        this.TotalPageviewCount = TotalPageviewCount;
        this.UserAgentString = UserAgentString;
        this.IpAddress = IpAddress;
        this.IpOrganization = IpOrganization;
        this.SearchQuery = SearchQuery;
        this.Authenticated = Authenticated;
        this.Browser = Browser;
        this.Device = Device;
        this.Geolocation = Geolocation;
        this.MktCampaign = MktCampaign;
        this.Page = Page;
        this.Referrer = Referrer;
        this.Attributes = Attributes;
        this.Traits = Traits;

    }



    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    [DataMember(Name = "eventName", EmitDefaultValue = false)]
    public string EventName { get; set; }



    /// <summary>
    /// Gets or Sets TotalEventCount
    /// </summary>
    [DataMember(Name = "totalEventCount", EmitDefaultValue = false)]
    public long? TotalEventCount { get; set; }



    /// <summary>
    /// Gets or Sets TotalPageviewCount
    /// </summary>
    [DataMember(Name = "totalPageviewCount", EmitDefaultValue = false)]
    public long? TotalPageviewCount { get; set; }



    /// <summary>
    /// Gets or Sets UserAgentString
    /// </summary>
    [DataMember(Name = "userAgentString", EmitDefaultValue = false)]
    public string UserAgentString { get; set; }



    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [DataMember(Name = "ipAddress", EmitDefaultValue = false)]
    public string IpAddress { get; set; }



    /// <summary>
    /// Gets or Sets IpOrganization
    /// </summary>
    [DataMember(Name = "ipOrganization", EmitDefaultValue = false)]
    public string IpOrganization { get; set; }



    /// <summary>
    /// Gets or Sets SearchQuery
    /// </summary>
    [DataMember(Name = "searchQuery", EmitDefaultValue = false)]
    public string SearchQuery { get; set; }



    /// <summary>
    /// Gets or Sets Authenticated
    /// </summary>
    [DataMember(Name = "authenticated", EmitDefaultValue = false)]
    public bool? Authenticated { get; set; }



    /// <summary>
    /// Gets or Sets Browser
    /// </summary>
    [DataMember(Name = "browser", EmitDefaultValue = false)]
    public JourneyWebEventsNotificationBrowser Browser { get; set; }



    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    [DataMember(Name = "device", EmitDefaultValue = false)]
    public JourneyWebEventsNotificationDevice Device { get; set; }



    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    [DataMember(Name = "geolocation", EmitDefaultValue = false)]
    public JourneyWebEventsNotificationGeoLocation Geolocation { get; set; }



    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    [DataMember(Name = "mktCampaign", EmitDefaultValue = false)]
    public JourneyWebEventsNotificationMktCampaign MktCampaign { get; set; }



    /// <summary>
    /// Gets or Sets Page
    /// </summary>
    [DataMember(Name = "page", EmitDefaultValue = false)]
    public JourneyWebEventsNotificationPage Page { get; set; }



    /// <summary>
    /// Gets or Sets Referrer
    /// </summary>
    [DataMember(Name = "referrer", EmitDefaultValue = false)]
    public JourneyWebEventsNotificationReferrer Referrer { get; set; }



    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Attributes { get; set; }



    /// <summary>
    /// Gets or Sets Traits
    /// </summary>
    [DataMember(Name = "traits", EmitDefaultValue = false)]
    public Dictionary<string, JourneyWebEventsNotificationCustomEventAttribute> Traits { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyWebEventsNotificationWebMessage {\n");

        sb.Append("  EventName: ").Append(EventName).Append("\n");
        sb.Append("  TotalEventCount: ").Append(TotalEventCount).Append("\n");
        sb.Append("  TotalPageviewCount: ").Append(TotalPageviewCount).Append("\n");
        sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
        sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
        sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
        sb.Append("  Browser: ").Append(Browser).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  Referrer: ").Append(Referrer).Append("\n");
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
        return Equals(obj as JourneyWebEventsNotificationWebMessage);
    }

    /// <summary>
    /// Returns true if JourneyWebEventsNotificationWebMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyWebEventsNotificationWebMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyWebEventsNotificationWebMessage other)
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
                UserAgentString == other.UserAgentString ||
                UserAgentString != null &&
                UserAgentString.Equals(other.UserAgentString)
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
                SearchQuery == other.SearchQuery ||
                SearchQuery != null &&
                SearchQuery.Equals(other.SearchQuery)
            ) &&
            (
                Authenticated == other.Authenticated ||
                Authenticated != null &&
                Authenticated.Equals(other.Authenticated)
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
                MktCampaign == other.MktCampaign ||
                MktCampaign != null &&
                MktCampaign.Equals(other.MktCampaign)
            ) &&
            (
                Page == other.Page ||
                Page != null &&
                Page.Equals(other.Page)
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

            if (UserAgentString != null)
            {
                hash = hash * 59 + UserAgentString.GetHashCode();
            }

            if (IpAddress != null)
            {
                hash = hash * 59 + IpAddress.GetHashCode();
            }

            if (IpOrganization != null)
            {
                hash = hash * 59 + IpOrganization.GetHashCode();
            }

            if (SearchQuery != null)
            {
                hash = hash * 59 + SearchQuery.GetHashCode();
            }

            if (Authenticated != null)
            {
                hash = hash * 59 + Authenticated.GetHashCode();
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

            if (MktCampaign != null)
            {
                hash = hash * 59 + MktCampaign.GetHashCode();
            }

            if (Page != null)
            {
                hash = hash * 59 + Page.GetHashCode();
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

            return hash;
        }
    }
}
