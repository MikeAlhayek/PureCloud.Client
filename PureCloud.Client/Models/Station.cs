using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Station
/// </summary>

public partial class Station : IEquatable<Station>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Available for "AVAILABLE"
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        Available,

        /// <summary>
        /// Enum Associated for "ASSOCIATED"
        /// </summary>
        [EnumMember(Value = "ASSOCIATED")]
        Associated
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Station" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Status">Status.</param>
    /// <param name="UserId">The Id of the user currently logged in and associated with the station..</param>
    /// <param name="WebRtcUserId">The Id of the user configured for the station if it is of type inin_webrtc_softphone. Empty if station type is not inin_webrtc_softphone..</param>
    /// <param name="PrimaryEdge">PrimaryEdge.</param>
    /// <param name="SecondaryEdge">SecondaryEdge.</param>
    /// <param name="Type">Type.</param>
    /// <param name="LineAppearanceId">LineAppearanceId.</param>
    public Station(string Name = null, string Description = null, StatusEnum? Status = null, string UserId = null, string WebRtcUserId = null, DomainEntityRef PrimaryEdge = null, DomainEntityRef SecondaryEdge = null, string Type = null, string LineAppearanceId = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Status = Status;
        this.UserId = UserId;
        this.WebRtcUserId = WebRtcUserId;
        this.PrimaryEdge = PrimaryEdge;
        this.SecondaryEdge = SecondaryEdge;
        this.Type = Type;
        this.LineAppearanceId = LineAppearanceId;

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
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }





    /// <summary>
    /// The Id of the user currently logged in and associated with the station.
    /// </summary>
    /// <value>The Id of the user currently logged in and associated with the station.</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// The Id of the user configured for the station if it is of type inin_webrtc_softphone. Empty if station type is not inin_webrtc_softphone.
    /// </summary>
    /// <value>The Id of the user configured for the station if it is of type inin_webrtc_softphone. Empty if station type is not inin_webrtc_softphone.</value>
    [JsonPropertyName("webRtcUserId")]
    public string WebRtcUserId { get; set; }



    /// <summary>
    /// Gets or Sets PrimaryEdge
    /// </summary>
    [JsonPropertyName("primaryEdge")]
    public DomainEntityRef PrimaryEdge { get; set; }



    /// <summary>
    /// Gets or Sets SecondaryEdge
    /// </summary>
    [JsonPropertyName("secondaryEdge")]
    public DomainEntityRef SecondaryEdge { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets LineAppearanceId
    /// </summary>
    [JsonPropertyName("lineAppearanceId")]
    public string LineAppearanceId { get; set; }



    /// <summary>
    /// The default or configured value of media dscp for the station. Empty if station type is not inin_webrtc_softphone.
    /// </summary>
    /// <value>The default or configured value of media dscp for the station. Empty if station type is not inin_webrtc_softphone.</value>
    [JsonPropertyName("webRtcMediaDscp")]
    public int? WebRtcMediaDscp { get; private set; }



    /// <summary>
    /// The default or configured value of persistent connection setting for the station. Empty if station type is not inin_webrtc_softphone.
    /// </summary>
    /// <value>The default or configured value of persistent connection setting for the station. Empty if station type is not inin_webrtc_softphone.</value>
    [JsonPropertyName("webRtcPersistentEnabled")]
    public bool? WebRtcPersistentEnabled { get; private set; }



    /// <summary>
    /// Whether the station is configured to require TURN for routing WebRTC calls. Empty if station type is not inin_webrtc_softphone.
    /// </summary>
    /// <value>Whether the station is configured to require TURN for routing WebRTC calls. Empty if station type is not inin_webrtc_softphone.</value>
    [JsonPropertyName("webRtcForceTurn")]
    public bool? WebRtcForceTurn { get; private set; }



    /// <summary>
    /// The number of call appearances on the station.
    /// </summary>
    /// <value>The number of call appearances on the station.</value>
    [JsonPropertyName("webRtcCallAppearances")]
    public int? WebRtcCallAppearances { get; private set; }



    /// <summary>
    /// True when the media helper required.
    /// </summary>
    /// <value>True when the media helper required.</value>
    [JsonPropertyName("webRtcRequireMediaHelper")]
    public bool? WebRtcRequireMediaHelper { get; private set; }



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
        sb.Append("class Station {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  WebRtcUserId: ").Append(WebRtcUserId).Append("\n");
        sb.Append("  PrimaryEdge: ").Append(PrimaryEdge).Append("\n");
        sb.Append("  SecondaryEdge: ").Append(SecondaryEdge).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  LineAppearanceId: ").Append(LineAppearanceId).Append("\n");
        sb.Append("  WebRtcMediaDscp: ").Append(WebRtcMediaDscp).Append("\n");
        sb.Append("  WebRtcPersistentEnabled: ").Append(WebRtcPersistentEnabled).Append("\n");
        sb.Append("  WebRtcForceTurn: ").Append(WebRtcForceTurn).Append("\n");
        sb.Append("  WebRtcCallAppearances: ").Append(WebRtcCallAppearances).Append("\n");
        sb.Append("  WebRtcRequireMediaHelper: ").Append(WebRtcRequireMediaHelper).Append("\n");
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
        return Equals(obj as Station);
    }

    /// <summary>
    /// Returns true if Station instances are equal
    /// </summary>
    /// <param name="other">Instance of Station to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Station other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                WebRtcUserId == other.WebRtcUserId ||
                WebRtcUserId != null &&
                WebRtcUserId.Equals(other.WebRtcUserId)
            ) &&
            (
                PrimaryEdge == other.PrimaryEdge ||
                PrimaryEdge != null &&
                PrimaryEdge.Equals(other.PrimaryEdge)
            ) &&
            (
                SecondaryEdge == other.SecondaryEdge ||
                SecondaryEdge != null &&
                SecondaryEdge.Equals(other.SecondaryEdge)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                LineAppearanceId == other.LineAppearanceId ||
                LineAppearanceId != null &&
                LineAppearanceId.Equals(other.LineAppearanceId)
            ) &&
            (
                WebRtcMediaDscp == other.WebRtcMediaDscp ||
                WebRtcMediaDscp != null &&
                WebRtcMediaDscp.Equals(other.WebRtcMediaDscp)
            ) &&
            (
                WebRtcPersistentEnabled == other.WebRtcPersistentEnabled ||
                WebRtcPersistentEnabled != null &&
                WebRtcPersistentEnabled.Equals(other.WebRtcPersistentEnabled)
            ) &&
            (
                WebRtcForceTurn == other.WebRtcForceTurn ||
                WebRtcForceTurn != null &&
                WebRtcForceTurn.Equals(other.WebRtcForceTurn)
            ) &&
            (
                WebRtcCallAppearances == other.WebRtcCallAppearances ||
                WebRtcCallAppearances != null &&
                WebRtcCallAppearances.Equals(other.WebRtcCallAppearances)
            ) &&
            (
                WebRtcRequireMediaHelper == other.WebRtcRequireMediaHelper ||
                WebRtcRequireMediaHelper != null &&
                WebRtcRequireMediaHelper.Equals(other.WebRtcRequireMediaHelper)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (WebRtcUserId != null)
            {
                hash = hash * 59 + WebRtcUserId.GetHashCode();
            }

            if (PrimaryEdge != null)
            {
                hash = hash * 59 + PrimaryEdge.GetHashCode();
            }

            if (SecondaryEdge != null)
            {
                hash = hash * 59 + SecondaryEdge.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (LineAppearanceId != null)
            {
                hash = hash * 59 + LineAppearanceId.GetHashCode();
            }

            if (WebRtcMediaDscp != null)
            {
                hash = hash * 59 + WebRtcMediaDscp.GetHashCode();
            }

            if (WebRtcPersistentEnabled != null)
            {
                hash = hash * 59 + WebRtcPersistentEnabled.GetHashCode();
            }

            if (WebRtcForceTurn != null)
            {
                hash = hash * 59 + WebRtcForceTurn.GetHashCode();
            }

            if (WebRtcCallAppearances != null)
            {
                hash = hash * 59 + WebRtcCallAppearances.GetHashCode();
            }

            if (WebRtcRequireMediaHelper != null)
            {
                hash = hash * 59 + WebRtcRequireMediaHelper.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
