using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Contains information about a response.
/// </summary>
[DataContract]
public partial class Response : IEquatable<Response>
{
    /// <summary>
    /// The interaction type for this response.
    /// </summary>
    /// <value>The interaction type for this response.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InteractionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Chat for "chat"
        /// </summary>
        [EnumMember(Value = "chat")]
        Chat,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Twitter for "twitter"
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter
    }
    /// <summary>
    /// The response type represented by the response.
    /// </summary>
    /// <value>The response type represented by the response.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ResponseTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Messagingtemplate for "MessagingTemplate"
        /// </summary>
        [EnumMember(Value = "MessagingTemplate")]
        Messagingtemplate,

        /// <summary>
        /// Enum Campaignsmstemplate for "CampaignSmsTemplate"
        /// </summary>
        [EnumMember(Value = "CampaignSmsTemplate")]
        Campaignsmstemplate,

        /// <summary>
        /// Enum Campaignemailtemplate for "CampaignEmailTemplate"
        /// </summary>
        [EnumMember(Value = "CampaignEmailTemplate")]
        Campaignemailtemplate,

        /// <summary>
        /// Enum Footer for "Footer"
        /// </summary>
        [EnumMember(Value = "Footer")]
        Footer
    }
    /// <summary>
    /// The interaction type for this response.
    /// </summary>
    /// <value>The interaction type for this response.</value>
    [DataMember(Name = "interactionType", EmitDefaultValue = false)]
    public InteractionTypeEnum? InteractionType { get; set; }
    /// <summary>
    /// The response type represented by the response.
    /// </summary>
    /// <value>The response type represented by the response.</value>
    [DataMember(Name = "responseType", EmitDefaultValue = false)]
    public ResponseTypeEnum? ResponseType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Response" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Response() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Response" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Version number required for updates..</param>
    /// <param name="Libraries">One or more libraries response is associated with. (required).</param>
    /// <param name="Texts">One or more texts associated with the response. (required).</param>
    /// <param name="InteractionType">The interaction type for this response..</param>
    /// <param name="Substitutions">Details about any text substitutions used in the texts for this response..</param>
    /// <param name="SubstitutionsSchema">Metadata about the text substitutions in json schema format..</param>
    /// <param name="ResponseType">The response type represented by the response..</param>
    /// <param name="MessagingTemplate">An optional messaging template definition for responseType.MessagingTemplate..</param>
    /// <param name="Assets">Assets used in the response.</param>
    /// <param name="Footer">Footer template definition for responseType.Footer..</param>
    public Response(string Name = null, int? Version = null, List<DomainEntityRef> Libraries = null, List<ResponseText> Texts = null, InteractionTypeEnum? InteractionType = null, List<ResponseSubstitution> Substitutions = null, JsonSchemaDocument SubstitutionsSchema = null, ResponseTypeEnum? ResponseType = null, MessagingTemplate MessagingTemplate = null, List<AddressableEntityRef> Assets = null, FooterTemplate Footer = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.Libraries = Libraries;
        this.Texts = Texts;
        this.InteractionType = InteractionType;
        this.Substitutions = Substitutions;
        this.SubstitutionsSchema = SubstitutionsSchema;
        this.ResponseType = ResponseType;
        this.MessagingTemplate = MessagingTemplate;
        this.Assets = Assets;
        this.Footer = Footer;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Version number required for updates.
    /// </summary>
    /// <value>Version number required for updates.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// One or more libraries response is associated with.
    /// </summary>
    /// <value>One or more libraries response is associated with.</value>
    [DataMember(Name = "libraries", EmitDefaultValue = false)]
    public List<DomainEntityRef> Libraries { get; set; }



    /// <summary>
    /// One or more texts associated with the response.
    /// </summary>
    /// <value>One or more texts associated with the response.</value>
    [DataMember(Name = "texts", EmitDefaultValue = false)]
    public List<ResponseText> Texts { get; set; }



    /// <summary>
    /// User that created the response
    /// </summary>
    /// <value>User that created the response</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public User CreatedBy { get; private set; }



    /// <summary>
    /// The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }





    /// <summary>
    /// Details about any text substitutions used in the texts for this response.
    /// </summary>
    /// <value>Details about any text substitutions used in the texts for this response.</value>
    [DataMember(Name = "substitutions", EmitDefaultValue = false)]
    public List<ResponseSubstitution> Substitutions { get; set; }



    /// <summary>
    /// Metadata about the text substitutions in json schema format.
    /// </summary>
    /// <value>Metadata about the text substitutions in json schema format.</value>
    [DataMember(Name = "substitutionsSchema", EmitDefaultValue = false)]
    public JsonSchemaDocument SubstitutionsSchema { get; set; }





    /// <summary>
    /// An optional messaging template definition for responseType.MessagingTemplate.
    /// </summary>
    /// <value>An optional messaging template definition for responseType.MessagingTemplate.</value>
    [DataMember(Name = "messagingTemplate", EmitDefaultValue = false)]
    public MessagingTemplate MessagingTemplate { get; set; }



    /// <summary>
    /// Assets used in the response
    /// </summary>
    /// <value>Assets used in the response</value>
    [DataMember(Name = "assets", EmitDefaultValue = false)]
    public List<AddressableEntityRef> Assets { get; set; }



    /// <summary>
    /// Footer template definition for responseType.Footer.
    /// </summary>
    /// <value>Footer template definition for responseType.Footer.</value>
    [DataMember(Name = "footer", EmitDefaultValue = false)]
    public FooterTemplate Footer { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Response {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Libraries: ").Append(Libraries).Append("\n");
        sb.Append("  Texts: ").Append(Texts).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
        sb.Append("  Substitutions: ").Append(Substitutions).Append("\n");
        sb.Append("  SubstitutionsSchema: ").Append(SubstitutionsSchema).Append("\n");
        sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
        sb.Append("  MessagingTemplate: ").Append(MessagingTemplate).Append("\n");
        sb.Append("  Assets: ").Append(Assets).Append("\n");
        sb.Append("  Footer: ").Append(Footer).Append("\n");
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
        return Equals(obj as Response);
    }

    /// <summary>
    /// Returns true if Response instances are equal
    /// </summary>
    /// <param name="other">Instance of Response to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Response other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Libraries == other.Libraries ||
                Libraries != null &&
                Libraries.SequenceEqual(other.Libraries)
            ) &&
            (
                Texts == other.Texts ||
                Texts != null &&
                Texts.SequenceEqual(other.Texts)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                InteractionType == other.InteractionType ||
                InteractionType != null &&
                InteractionType.Equals(other.InteractionType)
            ) &&
            (
                Substitutions == other.Substitutions ||
                Substitutions != null &&
                Substitutions.SequenceEqual(other.Substitutions)
            ) &&
            (
                SubstitutionsSchema == other.SubstitutionsSchema ||
                SubstitutionsSchema != null &&
                SubstitutionsSchema.Equals(other.SubstitutionsSchema)
            ) &&
            (
                ResponseType == other.ResponseType ||
                ResponseType != null &&
                ResponseType.Equals(other.ResponseType)
            ) &&
            (
                MessagingTemplate == other.MessagingTemplate ||
                MessagingTemplate != null &&
                MessagingTemplate.Equals(other.MessagingTemplate)
            ) &&
            (
                Assets == other.Assets ||
                Assets != null &&
                Assets.SequenceEqual(other.Assets)
            ) &&
            (
                Footer == other.Footer ||
                Footer != null &&
                Footer.Equals(other.Footer)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Libraries != null)
            {
                hash = hash * 59 + Libraries.GetHashCode();
            }

            if (Texts != null)
            {
                hash = hash * 59 + Texts.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (InteractionType != null)
            {
                hash = hash * 59 + InteractionType.GetHashCode();
            }

            if (Substitutions != null)
            {
                hash = hash * 59 + Substitutions.GetHashCode();
            }

            if (SubstitutionsSchema != null)
            {
                hash = hash * 59 + SubstitutionsSchema.GetHashCode();
            }

            if (ResponseType != null)
            {
                hash = hash * 59 + ResponseType.GetHashCode();
            }

            if (MessagingTemplate != null)
            {
                hash = hash * 59 + MessagingTemplate.GetHashCode();
            }

            if (Assets != null)
            {
                hash = hash * 59 + Assets.GetHashCode();
            }

            if (Footer != null)
            {
                hash = hash * 59 + Footer.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
