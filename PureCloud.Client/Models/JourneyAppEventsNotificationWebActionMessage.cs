using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAppEventsNotificationWebActionMessage
/// </summary>
[DataContract]
public partial class JourneyAppEventsNotificationWebActionMessage : IEquatable<JourneyAppEventsNotificationWebActionMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAppEventsNotificationWebActionMessage" /> class.
    /// </summary>
    /// <param name="Action">Action.</param>
    /// <param name="ActionTarget">ActionTarget.</param>
    /// <param name="ActionMap">ActionMap.</param>
    /// <param name="ErrorCode">ErrorCode.</param>
    /// <param name="ErrorMessage">ErrorMessage.</param>
    /// <param name="UserAgentString">UserAgentString.</param>
    /// <param name="IpAddress">IpAddress.</param>
    /// <param name="IpOrganization">IpOrganization.</param>
    /// <param name="Browser">Browser.</param>
    /// <param name="Device">Device.</param>
    /// <param name="Geolocation">Geolocation.</param>
    /// <param name="MktCampaign">MktCampaign.</param>
    /// <param name="VisitReferrer">VisitReferrer.</param>
    /// <param name="TimeToDisposition">TimeToDisposition.</param>
    public JourneyAppEventsNotificationWebActionMessage(JourneyAppEventsNotificationEventAction Action = null, JourneyAppEventsNotificationActionTarget ActionTarget = null, JourneyAppEventsNotificationActionMap ActionMap = null, string ErrorCode = null, string ErrorMessage = null, string UserAgentString = null, string IpAddress = null, string IpOrganization = null, JourneyAppEventsNotificationBrowser Browser = null, JourneyAppEventsNotificationDevice Device = null, JourneyAppEventsNotificationGeoLocation Geolocation = null, JourneyAppEventsNotificationMktCampaign MktCampaign = null, JourneyAppEventsNotificationReferrer VisitReferrer = null, long? TimeToDisposition = null)
    {
        this.Action = Action;
        this.ActionTarget = ActionTarget;
        this.ActionMap = ActionMap;
        this.ErrorCode = ErrorCode;
        this.ErrorMessage = ErrorMessage;
        this.UserAgentString = UserAgentString;
        this.IpAddress = IpAddress;
        this.IpOrganization = IpOrganization;
        this.Browser = Browser;
        this.Device = Device;
        this.Geolocation = Geolocation;
        this.MktCampaign = MktCampaign;
        this.VisitReferrer = VisitReferrer;
        this.TimeToDisposition = TimeToDisposition;

    }



    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public JourneyAppEventsNotificationEventAction Action { get; set; }



    /// <summary>
    /// Gets or Sets ActionTarget
    /// </summary>
    [DataMember(Name = "actionTarget", EmitDefaultValue = false)]
    public JourneyAppEventsNotificationActionTarget ActionTarget { get; set; }



    /// <summary>
    /// Gets or Sets ActionMap
    /// </summary>
    [DataMember(Name = "actionMap", EmitDefaultValue = false)]
    public JourneyAppEventsNotificationActionMap ActionMap { get; set; }



    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }



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
    /// Gets or Sets Browser
    /// </summary>
    [DataMember(Name = "browser", EmitDefaultValue = false)]
    public JourneyAppEventsNotificationBrowser Browser { get; set; }



    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    [DataMember(Name = "device", EmitDefaultValue = false)]
    public JourneyAppEventsNotificationDevice Device { get; set; }



    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    [DataMember(Name = "geolocation", EmitDefaultValue = false)]
    public JourneyAppEventsNotificationGeoLocation Geolocation { get; set; }



    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    [DataMember(Name = "mktCampaign", EmitDefaultValue = false)]
    public JourneyAppEventsNotificationMktCampaign MktCampaign { get; set; }



    /// <summary>
    /// Gets or Sets VisitReferrer
    /// </summary>
    [DataMember(Name = "visitReferrer", EmitDefaultValue = false)]
    public JourneyAppEventsNotificationReferrer VisitReferrer { get; set; }



    /// <summary>
    /// Gets or Sets TimeToDisposition
    /// </summary>
    [DataMember(Name = "timeToDisposition", EmitDefaultValue = false)]
    public long? TimeToDisposition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAppEventsNotificationWebActionMessage {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  ActionTarget: ").Append(ActionTarget).Append("\n");
        sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
        sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
        sb.Append("  Browser: ").Append(Browser).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
        sb.Append("  VisitReferrer: ").Append(VisitReferrer).Append("\n");
        sb.Append("  TimeToDisposition: ").Append(TimeToDisposition).Append("\n");
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
        return Equals(obj as JourneyAppEventsNotificationWebActionMessage);
    }

    /// <summary>
    /// Returns true if JourneyAppEventsNotificationWebActionMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAppEventsNotificationWebActionMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAppEventsNotificationWebActionMessage other)
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
                ActionTarget == other.ActionTarget ||
                ActionTarget != null &&
                ActionTarget.Equals(other.ActionTarget)
            ) &&
            (
                ActionMap == other.ActionMap ||
                ActionMap != null &&
                ActionMap.Equals(other.ActionMap)
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
                VisitReferrer == other.VisitReferrer ||
                VisitReferrer != null &&
                VisitReferrer.Equals(other.VisitReferrer)
            ) &&
            (
                TimeToDisposition == other.TimeToDisposition ||
                TimeToDisposition != null &&
                TimeToDisposition.Equals(other.TimeToDisposition)
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

            if (ActionTarget != null)
            {
                hash = hash * 59 + ActionTarget.GetHashCode();
            }

            if (ActionMap != null)
            {
                hash = hash * 59 + ActionMap.GetHashCode();
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

            if (IpAddress != null)
            {
                hash = hash * 59 + IpAddress.GetHashCode();
            }

            if (IpOrganization != null)
            {
                hash = hash * 59 + IpOrganization.GetHashCode();
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

            if (VisitReferrer != null)
            {
                hash = hash * 59 + VisitReferrer.GetHashCode();
            }

            if (TimeToDisposition != null)
            {
                hash = hash * 59 + TimeToDisposition.GetHashCode();
            }

            return hash;
        }
    }
}
