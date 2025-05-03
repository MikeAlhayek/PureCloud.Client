using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchActionTemplate
/// </summary>

public partial class PatchActionTemplate : IEquatable<PatchActionTemplate>
{
    /// <summary>
    /// Media type of action described by the action template.
    /// </summary>
    /// <value>Media type of action described by the action template.</value>
    
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
    /// Whether the action template is currently active, inactive or deleted.
    /// </summary>
    /// <value>Whether the action template is currently active, inactive or deleted.</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    /// <summary>
    /// Media type of action described by the action template.
    /// </summary>
    /// <value>Media type of action described by the action template.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Whether the action template is currently active, inactive or deleted.
    /// </summary>
    /// <value>Whether the action template is currently active, inactive or deleted.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PatchActionTemplate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PatchActionTemplate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchActionTemplate" /> class.
    /// </summary>
    /// <param name="Name">Name of the action template. (required).</param>
    /// <param name="Description">Description of the action template&#39;s functionality..</param>
    /// <param name="Version">The version of the action template..</param>
    /// <param name="MediaType">Media type of action described by the action template..</param>
    /// <param name="State">Whether the action template is currently active, inactive or deleted..</param>
    /// <param name="ContentOffer">Properties used to configure an action of type content offer.</param>
    public PatchActionTemplate(string Name = null, string Description = null, int? Version = null, MediaTypeEnum? MediaType = null, StateEnum? State = null, PatchContentOffer ContentOffer = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Version = Version;
        this.MediaType = MediaType;
        this.State = State;
        this.ContentOffer = ContentOffer;

    }



    /// <summary>
    /// Name of the action template.
    /// </summary>
    /// <value>Name of the action template.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Description of the action template&#39;s functionality.
    /// </summary>
    /// <value>Description of the action template&#39;s functionality.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The version of the action template.
    /// </summary>
    /// <value>The version of the action template.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }







    /// <summary>
    /// Properties used to configure an action of type content offer
    /// </summary>
    /// <value>Properties used to configure an action of type content offer</value>
    [JsonPropertyName("contentOffer")]
    public PatchContentOffer ContentOffer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchActionTemplate {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  ContentOffer: ").Append(ContentOffer).Append("\n");
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
        return Equals(obj as PatchActionTemplate);
    }

    /// <summary>
    /// Returns true if PatchActionTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchActionTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchActionTemplate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                ContentOffer == other.ContentOffer ||
                ContentOffer != null &&
                ContentOffer.Equals(other.ContentOffer)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (ContentOffer != null)
            {
                hash = hash * 59 + ContentOffer.GetHashCode();
            }

            return hash;
        }
    }
}
