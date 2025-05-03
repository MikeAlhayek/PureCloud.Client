using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CobrowseWebMessagingSession
/// </summary>

public partial class CobrowseWebMessagingSession : IEquatable<CobrowseWebMessagingSession>
{
    /// <summary>
    /// CommunicationType for Cobrowse Session
    /// </summary>
    /// <value>CommunicationType for Cobrowse Session</value>
    
    public enum CommunicationTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Call for "Call"
        /// </summary>
        [EnumMember(Value = "Call")]
        Call,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// CommunicationType for Cobrowse Session
    /// </summary>
    /// <value>CommunicationType for Cobrowse Session</value>
    [JsonPropertyName("communicationType")]
    public CommunicationTypeEnum? CommunicationType { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CobrowseWebMessagingSession" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    public CobrowseWebMessagingSession(string Name = null)
    {
        this.Name = Name;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Cobrowse session join code
    /// </summary>
    /// <value>Cobrowse session join code</value>
    [JsonPropertyName("joinCode")]
    public string JoinCode { get; private set; }



    /// <summary>
    /// WebSocket URL for the JS client
    /// </summary>
    /// <value>WebSocket URL for the JS client</value>
    [JsonPropertyName("websocketUrl")]
    public string WebsocketUrl { get; private set; }



    /// <summary>
    /// Date when Cobrowse Offer Expires. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when Cobrowse Offer Expires. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateOfferEnds")]
    public DateTime? DateOfferEnds { get; private set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CobrowseWebMessagingSession {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  JoinCode: ").Append(JoinCode).Append("\n");
        sb.Append("  WebsocketUrl: ").Append(WebsocketUrl).Append("\n");
        sb.Append("  DateOfferEnds: ").Append(DateOfferEnds).Append("\n");
        sb.Append("  CommunicationType: ").Append(CommunicationType).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as CobrowseWebMessagingSession);
    }

    /// <summary>
    /// Returns true if CobrowseWebMessagingSession instances are equal
    /// </summary>
    /// <param name="other">Instance of CobrowseWebMessagingSession to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CobrowseWebMessagingSession other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                JoinCode == other.JoinCode ||
                JoinCode != null &&
                JoinCode.Equals(other.JoinCode)
            ) &&
            (
                WebsocketUrl == other.WebsocketUrl ||
                WebsocketUrl != null &&
                WebsocketUrl.Equals(other.WebsocketUrl)
            ) &&
            (
                DateOfferEnds == other.DateOfferEnds ||
                DateOfferEnds != null &&
                DateOfferEnds.Equals(other.DateOfferEnds)
            ) &&
            (
                CommunicationType == other.CommunicationType ||
                CommunicationType != null &&
                CommunicationType.Equals(other.CommunicationType)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (JoinCode != null)
            {
                hash = hash * 59 + JoinCode.GetHashCode();
            }

            if (WebsocketUrl != null)
            {
                hash = hash * 59 + WebsocketUrl.GetHashCode();
            }

            if (DateOfferEnds != null)
            {
                hash = hash * 59 + DateOfferEnds.GetHashCode();
            }

            if (CommunicationType != null)
            {
                hash = hash * 59 + CommunicationType.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
