using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchAction
/// </summary>

public partial class PatchAction : IEquatable<PatchAction>
{
    /// <summary>
    /// Media type of action.
    /// </summary>
    /// <value>Media type of action.</value>
    
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
    /// Media type of action.
    /// </summary>
    /// <value>Media type of action.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PatchAction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PatchAction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchAction" /> class.
    /// </summary>
    /// <param name="MediaType">Media type of action. (required).</param>
    /// <param name="ActionTemplate">Action template associated with the action map..</param>
    /// <param name="ActionTargetId">Action target ID..</param>
    /// <param name="IsPacingEnabled">Whether this action should be throttled..</param>
    /// <param name="Props">Additional properties..</param>
    /// <param name="ArchitectFlowFields">Architect Flow Id and input contract..</param>
    /// <param name="WebMessagingOfferFields">Admin-configurable fields of a web messaging offer action..</param>
    /// <param name="OpenActionFields">Admin-configurable fields of an open action..</param>
    public PatchAction(MediaTypeEnum? MediaType = null, ActionMapActionTemplate ActionTemplate = null, string ActionTargetId = null, bool? IsPacingEnabled = null, PatchActionProperties Props = null, ArchitectFlowFields ArchitectFlowFields = null, PatchWebMessagingOfferFields WebMessagingOfferFields = null, OpenActionFields OpenActionFields = null)
    {
        this.MediaType = MediaType;
        this.ActionTemplate = ActionTemplate;
        this.ActionTargetId = ActionTargetId;
        this.IsPacingEnabled = IsPacingEnabled;
        this.Props = Props;
        this.ArchitectFlowFields = ArchitectFlowFields;
        this.WebMessagingOfferFields = WebMessagingOfferFields;
        this.OpenActionFields = OpenActionFields;

    }





    /// <summary>
    /// Action template associated with the action map.
    /// </summary>
    /// <value>Action template associated with the action map.</value>
    [JsonPropertyName("actionTemplate")]
    public ActionMapActionTemplate ActionTemplate { get; set; }



    /// <summary>
    /// Action target ID.
    /// </summary>
    /// <value>Action target ID.</value>
    [JsonPropertyName("actionTargetId")]
    public string ActionTargetId { get; set; }



    /// <summary>
    /// Whether this action should be throttled.
    /// </summary>
    /// <value>Whether this action should be throttled.</value>
    [JsonPropertyName("isPacingEnabled")]
    public bool? IsPacingEnabled { get; set; }



    /// <summary>
    /// Additional properties.
    /// </summary>
    /// <value>Additional properties.</value>
    [JsonPropertyName("props")]
    public PatchActionProperties Props { get; set; }



    /// <summary>
    /// Architect Flow Id and input contract.
    /// </summary>
    /// <value>Architect Flow Id and input contract.</value>
    [JsonPropertyName("architectFlowFields")]
    public ArchitectFlowFields ArchitectFlowFields { get; set; }



    /// <summary>
    /// Admin-configurable fields of a web messaging offer action.
    /// </summary>
    /// <value>Admin-configurable fields of a web messaging offer action.</value>
    [JsonPropertyName("webMessagingOfferFields")]
    public PatchWebMessagingOfferFields WebMessagingOfferFields { get; set; }



    /// <summary>
    /// Admin-configurable fields of an open action.
    /// </summary>
    /// <value>Admin-configurable fields of an open action.</value>
    [JsonPropertyName("openActionFields")]
    public OpenActionFields OpenActionFields { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchAction {\n");

        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ActionTemplate: ").Append(ActionTemplate).Append("\n");
        sb.Append("  ActionTargetId: ").Append(ActionTargetId).Append("\n");
        sb.Append("  IsPacingEnabled: ").Append(IsPacingEnabled).Append("\n");
        sb.Append("  Props: ").Append(Props).Append("\n");
        sb.Append("  ArchitectFlowFields: ").Append(ArchitectFlowFields).Append("\n");
        sb.Append("  WebMessagingOfferFields: ").Append(WebMessagingOfferFields).Append("\n");
        sb.Append("  OpenActionFields: ").Append(OpenActionFields).Append("\n");
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
        return Equals(obj as PatchAction);
    }

    /// <summary>
    /// Returns true if PatchAction instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                ActionTemplate == other.ActionTemplate ||
                ActionTemplate != null &&
                ActionTemplate.Equals(other.ActionTemplate)
            ) &&
            (
                ActionTargetId == other.ActionTargetId ||
                ActionTargetId != null &&
                ActionTargetId.Equals(other.ActionTargetId)
            ) &&
            (
                IsPacingEnabled == other.IsPacingEnabled ||
                IsPacingEnabled != null &&
                IsPacingEnabled.Equals(other.IsPacingEnabled)
            ) &&
            (
                Props == other.Props ||
                Props != null &&
                Props.Equals(other.Props)
            ) &&
            (
                ArchitectFlowFields == other.ArchitectFlowFields ||
                ArchitectFlowFields != null &&
                ArchitectFlowFields.Equals(other.ArchitectFlowFields)
            ) &&
            (
                WebMessagingOfferFields == other.WebMessagingOfferFields ||
                WebMessagingOfferFields != null &&
                WebMessagingOfferFields.Equals(other.WebMessagingOfferFields)
            ) &&
            (
                OpenActionFields == other.OpenActionFields ||
                OpenActionFields != null &&
                OpenActionFields.Equals(other.OpenActionFields)
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
            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (ActionTemplate != null)
            {
                hash = hash * 59 + ActionTemplate.GetHashCode();
            }

            if (ActionTargetId != null)
            {
                hash = hash * 59 + ActionTargetId.GetHashCode();
            }

            if (IsPacingEnabled != null)
            {
                hash = hash * 59 + IsPacingEnabled.GetHashCode();
            }

            if (Props != null)
            {
                hash = hash * 59 + Props.GetHashCode();
            }

            if (ArchitectFlowFields != null)
            {
                hash = hash * 59 + ArchitectFlowFields.GetHashCode();
            }

            if (WebMessagingOfferFields != null)
            {
                hash = hash * 59 + WebMessagingOfferFields.GetHashCode();
            }

            if (OpenActionFields != null)
            {
                hash = hash * 59 + OpenActionFields.GetHashCode();
            }

            return hash;
        }
    }
}
