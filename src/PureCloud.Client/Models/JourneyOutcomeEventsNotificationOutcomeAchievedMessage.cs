using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyOutcomeEventsNotificationOutcomeAchievedMessage
/// </summary>

public partial class JourneyOutcomeEventsNotificationOutcomeAchievedMessage : IEquatable<JourneyOutcomeEventsNotificationOutcomeAchievedMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationOutcomeAchievedMessage" /> class.
    /// </summary>
    /// <param name="Outcome">Outcome.</param>
    /// <param name="Browser">Browser.</param>
    /// <param name="VisitCreatedDate">VisitCreatedDate.</param>
    /// <param name="IpAddress">IpAddress.</param>
    /// <param name="IpOrganization">IpOrganization.</param>
    /// <param name="UserAgentString">UserAgentString.</param>
    /// <param name="Device">Device.</param>
    /// <param name="Geolocation">Geolocation.</param>
    /// <param name="MktCampaign">MktCampaign.</param>
    /// <param name="VisitReferrer">VisitReferrer.</param>
    /// <param name="AssociatedValue">AssociatedValue.</param>
    public JourneyOutcomeEventsNotificationOutcomeAchievedMessage(JourneyOutcomeEventsNotificationOutcome Outcome = null, JourneyOutcomeEventsNotificationBrowser Browser = null, DateTime? VisitCreatedDate = null, string IpAddress = null, string IpOrganization = null, string UserAgentString = null, JourneyOutcomeEventsNotificationDevice Device = null, JourneyOutcomeEventsNotificationGeoLocation Geolocation = null, JourneyOutcomeEventsNotificationMktCampaign MktCampaign = null, JourneyOutcomeEventsNotificationReferrer VisitReferrer = null, JourneyOutcomeEventsNotificationAssociatedValue AssociatedValue = null)
    {
        this.Outcome = Outcome;
        this.Browser = Browser;
        this.VisitCreatedDate = VisitCreatedDate;
        this.IpAddress = IpAddress;
        this.IpOrganization = IpOrganization;
        this.UserAgentString = UserAgentString;
        this.Device = Device;
        this.Geolocation = Geolocation;
        this.MktCampaign = MktCampaign;
        this.VisitReferrer = VisitReferrer;
        this.AssociatedValue = AssociatedValue;

    }



    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    [JsonPropertyName("outcome")]
    public JourneyOutcomeEventsNotificationOutcome Outcome { get; set; }



    /// <summary>
    /// Gets or Sets Browser
    /// </summary>
    [JsonPropertyName("browser")]
    public JourneyOutcomeEventsNotificationBrowser Browser { get; set; }



    /// <summary>
    /// Gets or Sets VisitCreatedDate
    /// </summary>
    [JsonPropertyName("visitCreatedDate")]
    public DateTime? VisitCreatedDate { get; set; }



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
    /// Gets or Sets UserAgentString
    /// </summary>
    [JsonPropertyName("userAgentString")]
    public string UserAgentString { get; set; }



    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    [JsonPropertyName("device")]
    public JourneyOutcomeEventsNotificationDevice Device { get; set; }



    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    [JsonPropertyName("geolocation")]
    public JourneyOutcomeEventsNotificationGeoLocation Geolocation { get; set; }



    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    [JsonPropertyName("mktCampaign")]
    public JourneyOutcomeEventsNotificationMktCampaign MktCampaign { get; set; }



    /// <summary>
    /// Gets or Sets VisitReferrer
    /// </summary>
    [JsonPropertyName("visitReferrer")]
    public JourneyOutcomeEventsNotificationReferrer VisitReferrer { get; set; }



    /// <summary>
    /// Gets or Sets AssociatedValue
    /// </summary>
    [JsonPropertyName("associatedValue")]
    public JourneyOutcomeEventsNotificationAssociatedValue AssociatedValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyOutcomeEventsNotificationOutcomeAchievedMessage {\n");

        sb.Append("  Outcome: ").Append(Outcome).Append("\n");
        sb.Append("  Browser: ").Append(Browser).Append("\n");
        sb.Append("  VisitCreatedDate: ").Append(VisitCreatedDate).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
        sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
        sb.Append("  VisitReferrer: ").Append(VisitReferrer).Append("\n");
        sb.Append("  AssociatedValue: ").Append(AssociatedValue).Append("\n");
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
        return Equals(obj as JourneyOutcomeEventsNotificationOutcomeAchievedMessage);
    }

    /// <summary>
    /// Returns true if JourneyOutcomeEventsNotificationOutcomeAchievedMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyOutcomeEventsNotificationOutcomeAchievedMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyOutcomeEventsNotificationOutcomeAchievedMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Outcome == other.Outcome ||
                Outcome != null &&
                Outcome.Equals(other.Outcome)
            ) &&
            (
                Browser == other.Browser ||
                Browser != null &&
                Browser.Equals(other.Browser)
            ) &&
            (
                VisitCreatedDate == other.VisitCreatedDate ||
                VisitCreatedDate != null &&
                VisitCreatedDate.Equals(other.VisitCreatedDate)
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
                UserAgentString == other.UserAgentString ||
                UserAgentString != null &&
                UserAgentString.Equals(other.UserAgentString)
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
                VisitReferrer == other.VisitReferrer ||
                VisitReferrer != null &&
                VisitReferrer.Equals(other.VisitReferrer)
            ) &&
            (
                AssociatedValue == other.AssociatedValue ||
                AssociatedValue != null &&
                AssociatedValue.Equals(other.AssociatedValue)
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
            if (Outcome != null)
            {
                hash = hash * 59 + Outcome.GetHashCode();
            }

            if (Browser != null)
            {
                hash = hash * 59 + Browser.GetHashCode();
            }

            if (VisitCreatedDate != null)
            {
                hash = hash * 59 + VisitCreatedDate.GetHashCode();
            }

            if (IpAddress != null)
            {
                hash = hash * 59 + IpAddress.GetHashCode();
            }

            if (IpOrganization != null)
            {
                hash = hash * 59 + IpOrganization.GetHashCode();
            }

            if (UserAgentString != null)
            {
                hash = hash * 59 + UserAgentString.GetHashCode();
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

            if (VisitReferrer != null)
            {
                hash = hash * 59 + VisitReferrer.GetHashCode();
            }

            if (AssociatedValue != null)
            {
                hash = hash * 59 + AssociatedValue.GetHashCode();
            }

            return hash;
        }
    }
}
