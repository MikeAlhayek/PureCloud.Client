using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DeploymentWebAction
/// </summary>
[DataContract]
public partial class DeploymentWebAction : IEquatable<DeploymentWebAction>
{
    /// <summary>
    /// Action media type used to deliver the action.
    /// </summary>
    /// <value>Action media type used to deliver the action.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Webchat for "webchat"
        /// </summary>
        [EnumMember(Value = "webchat")]
        Webchat,

        /// <summary>
        /// Enum Webmessagingoffer for "webMessagingOffer"
        /// </summary>
        [EnumMember(Value = "webMessagingOffer")]
        Webmessagingoffer,

        /// <summary>
        /// Enum Contentoffer for "contentOffer"
        /// </summary>
        [EnumMember(Value = "contentOffer")]
        Contentoffer,

        /// <summary>
        /// Enum Integrationaction for "integrationAction"
        /// </summary>
        [EnumMember(Value = "integrationAction")]
        Integrationaction,

        /// <summary>
        /// Enum Architectflow for "architectFlow"
        /// </summary>
        [EnumMember(Value = "architectFlow")]
        Architectflow,

        /// <summary>
        /// Enum Openaction for "openAction"
        /// </summary>
        [EnumMember(Value = "openAction")]
        Openaction
    }
    /// <summary>
    /// Action media type used to deliver the action.
    /// </summary>
    /// <value>Action media type used to deliver the action.</value>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DeploymentWebAction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DeploymentWebAction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DeploymentWebAction" /> class.
    /// </summary>
    /// <param name="Id">System-generated UUID for the action. (required).</param>
    /// <param name="MediaType">Action media type used to deliver the action. (required).</param>
    /// <param name="CustomerId">ID string of the customer that the action was triggered for..</param>
    /// <param name="CustomerIdType">Type of the customer ID that the action was triggered for..</param>
    /// <param name="ActionMapId">ID of the action map that triggered the action. (required).</param>
    /// <param name="ActionMapVersion">Version of the action map that triggered the action. (required).</param>
    /// <param name="SessionId">ID of the session that the action was triggered for. (required).</param>
    /// <param name="WebMessagingOfferProperties">Web messaging offer specific properties..</param>
    /// <param name="ContentOfferProperties">Content offer specific properties..</param>
    /// <param name="OpenActionProperties">Open action specific properties..</param>
    public DeploymentWebAction(string Id = null, MediaTypeEnum? MediaType = null, string CustomerId = null, string CustomerIdType = null, string ActionMapId = null, int? ActionMapVersion = null, string SessionId = null, WebMessagingOfferProperties WebMessagingOfferProperties = null, ContentOffer ContentOfferProperties = null, OpenActionProperties OpenActionProperties = null)
    {
        this.Id = Id;
        this.MediaType = MediaType;
        this.CustomerId = CustomerId;
        this.CustomerIdType = CustomerIdType;
        this.ActionMapId = ActionMapId;
        this.ActionMapVersion = ActionMapVersion;
        this.SessionId = SessionId;
        this.WebMessagingOfferProperties = WebMessagingOfferProperties;
        this.ContentOfferProperties = ContentOfferProperties;
        this.OpenActionProperties = OpenActionProperties;

    }



    /// <summary>
    /// System-generated UUID for the action.
    /// </summary>
    /// <value>System-generated UUID for the action.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }





    /// <summary>
    /// ID string of the customer that the action was triggered for.
    /// </summary>
    /// <value>ID string of the customer that the action was triggered for.</value>
    [DataMember(Name = "customerId", EmitDefaultValue = false)]
    public string CustomerId { get; set; }



    /// <summary>
    /// Type of the customer ID that the action was triggered for.
    /// </summary>
    /// <value>Type of the customer ID that the action was triggered for.</value>
    [DataMember(Name = "customerIdType", EmitDefaultValue = false)]
    public string CustomerIdType { get; set; }



    /// <summary>
    /// ID of the action map that triggered the action.
    /// </summary>
    /// <value>ID of the action map that triggered the action.</value>
    [DataMember(Name = "actionMapId", EmitDefaultValue = false)]
    public string ActionMapId { get; set; }



    /// <summary>
    /// Version of the action map that triggered the action.
    /// </summary>
    /// <value>Version of the action map that triggered the action.</value>
    [DataMember(Name = "actionMapVersion", EmitDefaultValue = false)]
    public int? ActionMapVersion { get; set; }



    /// <summary>
    /// ID of the session that the action was triggered for.
    /// </summary>
    /// <value>ID of the session that the action was triggered for.</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }



    /// <summary>
    /// Web messaging offer specific properties.
    /// </summary>
    /// <value>Web messaging offer specific properties.</value>
    [DataMember(Name = "webMessagingOfferProperties", EmitDefaultValue = false)]
    public WebMessagingOfferProperties WebMessagingOfferProperties { get; set; }



    /// <summary>
    /// Content offer specific properties.
    /// </summary>
    /// <value>Content offer specific properties.</value>
    [DataMember(Name = "contentOfferProperties", EmitDefaultValue = false)]
    public ContentOffer ContentOfferProperties { get; set; }



    /// <summary>
    /// Open action specific properties.
    /// </summary>
    /// <value>Open action specific properties.</value>
    [DataMember(Name = "openActionProperties", EmitDefaultValue = false)]
    public OpenActionProperties OpenActionProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DeploymentWebAction {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
        sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
        sb.Append("  ActionMapId: ").Append(ActionMapId).Append("\n");
        sb.Append("  ActionMapVersion: ").Append(ActionMapVersion).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  WebMessagingOfferProperties: ").Append(WebMessagingOfferProperties).Append("\n");
        sb.Append("  ContentOfferProperties: ").Append(ContentOfferProperties).Append("\n");
        sb.Append("  OpenActionProperties: ").Append(OpenActionProperties).Append("\n");
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
        return Equals(obj as DeploymentWebAction);
    }

    /// <summary>
    /// Returns true if DeploymentWebAction instances are equal
    /// </summary>
    /// <param name="other">Instance of DeploymentWebAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DeploymentWebAction other)
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
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
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
                ActionMapId == other.ActionMapId ||
                ActionMapId != null &&
                ActionMapId.Equals(other.ActionMapId)
            ) &&
            (
                ActionMapVersion == other.ActionMapVersion ||
                ActionMapVersion != null &&
                ActionMapVersion.Equals(other.ActionMapVersion)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                WebMessagingOfferProperties == other.WebMessagingOfferProperties ||
                WebMessagingOfferProperties != null &&
                WebMessagingOfferProperties.Equals(other.WebMessagingOfferProperties)
            ) &&
            (
                ContentOfferProperties == other.ContentOfferProperties ||
                ContentOfferProperties != null &&
                ContentOfferProperties.Equals(other.ContentOfferProperties)
            ) &&
            (
                OpenActionProperties == other.OpenActionProperties ||
                OpenActionProperties != null &&
                OpenActionProperties.Equals(other.OpenActionProperties)
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

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (CustomerId != null)
            {
                hash = hash * 59 + CustomerId.GetHashCode();
            }

            if (CustomerIdType != null)
            {
                hash = hash * 59 + CustomerIdType.GetHashCode();
            }

            if (ActionMapId != null)
            {
                hash = hash * 59 + ActionMapId.GetHashCode();
            }

            if (ActionMapVersion != null)
            {
                hash = hash * 59 + ActionMapVersion.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (WebMessagingOfferProperties != null)
            {
                hash = hash * 59 + WebMessagingOfferProperties.GetHashCode();
            }

            if (ContentOfferProperties != null)
            {
                hash = hash * 59 + ContentOfferProperties.GetHashCode();
            }

            if (OpenActionProperties != null)
            {
                hash = hash * 59 + OpenActionProperties.GetHashCode();
            }

            return hash;
        }
    }
}
