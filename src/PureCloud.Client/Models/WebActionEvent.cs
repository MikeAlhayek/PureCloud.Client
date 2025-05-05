using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebActionEvent
/// </summary>

public partial class WebActionEvent : IEquatable<WebActionEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebActionEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebActionEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebActionEvent" /> class.
    /// </summary>
    /// <param name="Action">The action that triggered the event. (required).</param>
    /// <param name="ActionMap">The action map that triggered the action. (required).</param>
    /// <param name="ActionTarget">The target for engagement actions. (required).</param>
    /// <param name="TimeToDisposition">Milliseconds elapsed until the action is disposed..</param>
    /// <param name="ErrorCode">Code of the error returned when the action fails..</param>
    /// <param name="ErrorMessage">Message of the error returned when the action fails..</param>
    /// <param name="UserAgentString">HTTP User-Agent string (see https://tools.ietf.org/html/rfc1945#section-10.15). (required).</param>
    /// <param name="Browser">Customer&#39;s browser. (required).</param>
    /// <param name="Device">Customer&#39;s device. (required).</param>
    /// <param name="Geolocation">Customer&#39;s geolocation..</param>
    /// <param name="IpAddress">Visitor&#39;s IP address..</param>
    /// <param name="IpOrganization">Visitor&#39;s IP-based organization or ISP name..</param>
    /// <param name="MktCampaign">Marketing / traffic source information..</param>
    /// <param name="VisitReferrer">Visit&#39;s referrer..</param>
    public WebActionEvent(EventAction Action = null, ActionEventActionMap ActionMap = null, AddressableEntityRef ActionTarget = null, long? TimeToDisposition = null, string ErrorCode = null, string ErrorMessage = null, string UserAgentString = null, Browser Browser = null, Device Device = null, JourneyGeolocation Geolocation = null, string IpAddress = null, string IpOrganization = null, JourneyCampaign MktCampaign = null, Referrer VisitReferrer = null)
    {
        this.Action = Action;
        this.ActionMap = ActionMap;
        this.ActionTarget = ActionTarget;
        this.TimeToDisposition = TimeToDisposition;
        this.ErrorCode = ErrorCode;
        this.ErrorMessage = ErrorMessage;
        this.UserAgentString = UserAgentString;
        this.Browser = Browser;
        this.Device = Device;
        this.Geolocation = Geolocation;
        this.IpAddress = IpAddress;
        this.IpOrganization = IpOrganization;
        this.MktCampaign = MktCampaign;
        this.VisitReferrer = VisitReferrer;

    }



    /// <summary>
    /// The action that triggered the event.
    /// </summary>
    /// <value>The action that triggered the event.</value>
    [JsonPropertyName("action")]
    public EventAction Action { get; set; }



    /// <summary>
    /// The action map that triggered the action.
    /// </summary>
    /// <value>The action map that triggered the action.</value>
    [JsonPropertyName("actionMap")]
    public ActionEventActionMap ActionMap { get; set; }



    /// <summary>
    /// The target for engagement actions.
    /// </summary>
    /// <value>The target for engagement actions.</value>
    [JsonPropertyName("actionTarget")]
    public AddressableEntityRef ActionTarget { get; set; }



    /// <summary>
    /// Milliseconds elapsed until the action is disposed.
    /// </summary>
    /// <value>Milliseconds elapsed until the action is disposed.</value>
    [JsonPropertyName("timeToDisposition")]
    public long? TimeToDisposition { get; set; }



    /// <summary>
    /// Code of the error returned when the action fails.
    /// </summary>
    /// <value>Code of the error returned when the action fails.</value>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Message of the error returned when the action fails.
    /// </summary>
    /// <value>Message of the error returned when the action fails.</value>
    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; set; }



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
    /// Visitor&#39;s IP address.
    /// </summary>
    /// <value>Visitor&#39;s IP address.</value>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }



    /// <summary>
    /// Visitor&#39;s IP-based organization or ISP name.
    /// </summary>
    /// <value>Visitor&#39;s IP-based organization or ISP name.</value>
    [JsonPropertyName("ipOrganization")]
    public string IpOrganization { get; set; }



    /// <summary>
    /// Marketing / traffic source information.
    /// </summary>
    /// <value>Marketing / traffic source information.</value>
    [JsonPropertyName("mktCampaign")]
    public JourneyCampaign MktCampaign { get; set; }



    /// <summary>
    /// Visit&#39;s referrer.
    /// </summary>
    /// <value>Visit&#39;s referrer.</value>
    [JsonPropertyName("visitReferrer")]
    public Referrer VisitReferrer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebActionEvent {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
        sb.Append("  ActionTarget: ").Append(ActionTarget).Append("\n");
        sb.Append("  TimeToDisposition: ").Append(TimeToDisposition).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
        sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
        sb.Append("  Browser: ").Append(Browser).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
        sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
        sb.Append("  VisitReferrer: ").Append(VisitReferrer).Append("\n");
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
        return Equals(obj as WebActionEvent);
    }

    /// <summary>
    /// Returns true if WebActionEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of WebActionEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebActionEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                ActionMap == other.ActionMap ||
                ActionMap != null &&
                ActionMap.Equals(other.ActionMap)
            ) &&
            (
                ActionTarget == other.ActionTarget ||
                ActionTarget != null &&
                ActionTarget.Equals(other.ActionTarget)
            ) &&
            (
                TimeToDisposition == other.TimeToDisposition ||
                TimeToDisposition != null &&
                TimeToDisposition.Equals(other.TimeToDisposition)
            ) &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                ErrorMessage == other.ErrorMessage ||
                ErrorMessage != null &&
                ErrorMessage.Equals(other.ErrorMessage)
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
                VisitReferrer == other.VisitReferrer ||
                VisitReferrer != null &&
                VisitReferrer.Equals(other.VisitReferrer)
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
            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (ActionMap != null)
            {
                hash = hash * 59 + ActionMap.GetHashCode();
            }

            if (ActionTarget != null)
            {
                hash = hash * 59 + ActionTarget.GetHashCode();
            }

            if (TimeToDisposition != null)
            {
                hash = hash * 59 + TimeToDisposition.GetHashCode();
            }

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (ErrorMessage != null)
            {
                hash = hash * 59 + ErrorMessage.GetHashCode();
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

            if (VisitReferrer != null)
            {
                hash = hash * 59 + VisitReferrer.GetHashCode();
            }

            return hash;
        }
    }
}
