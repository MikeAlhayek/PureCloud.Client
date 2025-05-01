using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowVersion
/// </summary>
[DataContract]
public partial class FlowVersion : IEquatable<FlowVersion>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Publish for "PUBLISH"
        /// </summary>
        [EnumMember(Value = "PUBLISH")]
        Publish,

        /// <summary>
        /// Enum Checkin for "CHECKIN"
        /// </summary>
        [EnumMember(Value = "CHECKIN")]
        Checkin,

        /// <summary>
        /// Enum Save for "SAVE"
        /// </summary>
        [EnumMember(Value = "SAVE")]
        Save
    }
    /// <summary>
    /// Gets or Sets CompatibleFlowTypes
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CompatibleFlowTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bot for "BOT"
        /// </summary>
        [EnumMember(Value = "BOT")]
        Bot,

        /// <summary>
        /// Enum Commonmodule for "COMMONMODULE"
        /// </summary>
        [EnumMember(Value = "COMMONMODULE")]
        Commonmodule,

        /// <summary>
        /// Enum Digitalbot for "DIGITALBOT"
        /// </summary>
        [EnumMember(Value = "DIGITALBOT")]
        Digitalbot,

        /// <summary>
        /// Enum Inboundcall for "INBOUNDCALL"
        /// </summary>
        [EnumMember(Value = "INBOUNDCALL")]
        Inboundcall,

        /// <summary>
        /// Enum Inboundchat for "INBOUNDCHAT"
        /// </summary>
        [EnumMember(Value = "INBOUNDCHAT")]
        Inboundchat,

        /// <summary>
        /// Enum Inboundemail for "INBOUNDEMAIL"
        /// </summary>
        [EnumMember(Value = "INBOUNDEMAIL")]
        Inboundemail,

        /// <summary>
        /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
        /// </summary>
        [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
        Inboundshortmessage,

        /// <summary>
        /// Enum Inqueuecall for "INQUEUECALL"
        /// </summary>
        [EnumMember(Value = "INQUEUECALL")]
        Inqueuecall,

        /// <summary>
        /// Enum Inqueueemail for "INQUEUEEMAIL"
        /// </summary>
        [EnumMember(Value = "INQUEUEEMAIL")]
        Inqueueemail,

        /// <summary>
        /// Enum Inqueueshortmessage for "INQUEUESHORTMESSAGE"
        /// </summary>
        [EnumMember(Value = "INQUEUESHORTMESSAGE")]
        Inqueueshortmessage,

        /// <summary>
        /// Enum Outboundcall for "OUTBOUNDCALL"
        /// </summary>
        [EnumMember(Value = "OUTBOUNDCALL")]
        Outboundcall,

        /// <summary>
        /// Enum Securecall for "SECURECALL"
        /// </summary>
        [EnumMember(Value = "SECURECALL")]
        Securecall,

        /// <summary>
        /// Enum Speech for "SPEECH"
        /// </summary>
        [EnumMember(Value = "SPEECH")]
        Speech,

        /// <summary>
        /// Enum Surveyinvite for "SURVEYINVITE"
        /// </summary>
        [EnumMember(Value = "SURVEYINVITE")]
        Surveyinvite,

        /// <summary>
        /// Enum Voice for "VOICE"
        /// </summary>
        [EnumMember(Value = "VOICE")]
        Voice,

        /// <summary>
        /// Enum Voicemail for "VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "VOICEMAIL")]
        Voicemail,

        /// <summary>
        /// Enum Voicesurvey for "VOICESURVEY"
        /// </summary>
        [EnumMember(Value = "VOICESURVEY")]
        Voicesurvey,

        /// <summary>
        /// Enum Workflow for "WORKFLOW"
        /// </summary>
        [EnumMember(Value = "WORKFLOW")]
        Workflow,

        /// <summary>
        /// Enum Workitem for "WORKITEM"
        /// </summary>
        [EnumMember(Value = "WORKITEM")]
        Workitem
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowVersion" /> class.
    /// </summary>
    /// <param name="Id">The flow version identifier.</param>
    /// <param name="Name">Name.</param>
    /// <param name="CommitVersion">CommitVersion.</param>
    /// <param name="ConfigurationVersion">ConfigurationVersion.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Secure">Secure.</param>
    /// <param name="Debug">Debug.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="CreatedByClient">CreatedByClient.</param>
    /// <param name="ConfigurationUri">ConfigurationUri.</param>
    /// <param name="DateCreated">DateCreated.</param>
    /// <param name="DateCheckedIn">DateCheckedIn.</param>
    /// <param name="DateSaved">DateSaved.</param>
    /// <param name="GenerationId">GenerationId.</param>
    /// <param name="PublishResultUri">PublishResultUri.</param>
    /// <param name="InputSchema">InputSchema.</param>
    /// <param name="OutputSchema">OutputSchema.</param>
    /// <param name="VirtualAgentEnabled">VirtualAgentEnabled.</param>
    public FlowVersion(string Id = null, string Name = null, string CommitVersion = null, string ConfigurationVersion = null, TypeEnum? Type = null, bool? Secure = null, bool? Debug = null, User CreatedBy = null, DomainEntityRef CreatedByClient = null, string ConfigurationUri = null, long? DateCreated = null, long? DateCheckedIn = null, long? DateSaved = null, string GenerationId = null, string PublishResultUri = null, JsonSchemaDocument InputSchema = null, JsonSchemaDocument OutputSchema = null, bool? VirtualAgentEnabled = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.CommitVersion = CommitVersion;
        this.ConfigurationVersion = ConfigurationVersion;
        this.Type = Type;
        this.Secure = Secure;
        this.Debug = Debug;
        this.CreatedBy = CreatedBy;
        this.CreatedByClient = CreatedByClient;
        this.ConfigurationUri = ConfigurationUri;
        this.DateCreated = DateCreated;
        this.DateCheckedIn = DateCheckedIn;
        this.DateSaved = DateSaved;
        this.GenerationId = GenerationId;
        this.PublishResultUri = PublishResultUri;
        this.InputSchema = InputSchema;
        this.OutputSchema = OutputSchema;
        this.VirtualAgentEnabled = VirtualAgentEnabled;

    }



    /// <summary>
    /// The flow version identifier
    /// </summary>
    /// <value>The flow version identifier</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets CommitVersion
    /// </summary>
    [DataMember(Name = "commitVersion", EmitDefaultValue = false)]
    public string CommitVersion { get; set; }



    /// <summary>
    /// Gets or Sets ConfigurationVersion
    /// </summary>
    [DataMember(Name = "configurationVersion", EmitDefaultValue = false)]
    public string ConfigurationVersion { get; set; }





    /// <summary>
    /// Gets or Sets Secure
    /// </summary>
    [DataMember(Name = "secure", EmitDefaultValue = false)]
    public bool? Secure { get; set; }



    /// <summary>
    /// Gets or Sets Debug
    /// </summary>
    [DataMember(Name = "debug", EmitDefaultValue = false)]
    public bool? Debug { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public User CreatedBy { get; set; }



    /// <summary>
    /// Gets or Sets CreatedByClient
    /// </summary>
    [DataMember(Name = "createdByClient", EmitDefaultValue = false)]
    public DomainEntityRef CreatedByClient { get; set; }



    /// <summary>
    /// Gets or Sets ConfigurationUri
    /// </summary>
    [DataMember(Name = "configurationUri", EmitDefaultValue = false)]
    public string ConfigurationUri { get; set; }



    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public long? DateCreated { get; set; }



    /// <summary>
    /// Gets or Sets DateCheckedIn
    /// </summary>
    [DataMember(Name = "dateCheckedIn", EmitDefaultValue = false)]
    public long? DateCheckedIn { get; set; }



    /// <summary>
    /// Gets or Sets DateSaved
    /// </summary>
    [DataMember(Name = "dateSaved", EmitDefaultValue = false)]
    public long? DateSaved { get; set; }



    /// <summary>
    /// Gets or Sets GenerationId
    /// </summary>
    [DataMember(Name = "generationId", EmitDefaultValue = false)]
    public string GenerationId { get; set; }



    /// <summary>
    /// Gets or Sets PublishResultUri
    /// </summary>
    [DataMember(Name = "publishResultUri", EmitDefaultValue = false)]
    public string PublishResultUri { get; set; }



    /// <summary>
    /// Gets or Sets InputSchema
    /// </summary>
    [DataMember(Name = "inputSchema", EmitDefaultValue = false)]
    public JsonSchemaDocument InputSchema { get; set; }



    /// <summary>
    /// Gets or Sets OutputSchema
    /// </summary>
    [DataMember(Name = "outputSchema", EmitDefaultValue = false)]
    public JsonSchemaDocument OutputSchema { get; set; }



    /// <summary>
    /// Gets or Sets VirtualAgentEnabled
    /// </summary>
    [DataMember(Name = "virtualAgentEnabled", EmitDefaultValue = false)]
    public bool? VirtualAgentEnabled { get; set; }



    /// <summary>
    /// The date this version became the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date this version became the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "datePublished", EmitDefaultValue = false)]
    public DateTime? DatePublished { get; private set; }



    /// <summary>
    /// The date this version was no longer the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date this version was no longer the published version of the flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "datePublishedEnd", EmitDefaultValue = false)]
    public DateTime? DatePublishedEnd { get; private set; }



    /// <summary>
    /// Information about the natural language understanding configuration for the flow version
    /// </summary>
    /// <value>Information about the natural language understanding configuration for the flow version</value>
    [DataMember(Name = "nluInfo", EmitDefaultValue = false)]
    public NluInfo NluInfo { get; private set; }



    /// <summary>
    /// List of supported languages for this version of the flow
    /// </summary>
    /// <value>List of supported languages for this version of the flow</value>
    [DataMember(Name = "supportedLanguages", EmitDefaultValue = false)]
    public List<SupportedLanguage> SupportedLanguages { get; private set; }



    /// <summary>
    /// Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.
    /// </summary>
    /// <value>Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.</value>
    [DataMember(Name = "compatibleFlowTypes", EmitDefaultValue = false)]
    public List<CompatibleFlowTypesEnum> CompatibleFlowTypes { get; private set; }



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
        sb.Append("class FlowVersion {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  CommitVersion: ").Append(CommitVersion).Append("\n");
        sb.Append("  ConfigurationVersion: ").Append(ConfigurationVersion).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Secure: ").Append(Secure).Append("\n");
        sb.Append("  Debug: ").Append(Debug).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  CreatedByClient: ").Append(CreatedByClient).Append("\n");
        sb.Append("  ConfigurationUri: ").Append(ConfigurationUri).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateCheckedIn: ").Append(DateCheckedIn).Append("\n");
        sb.Append("  DateSaved: ").Append(DateSaved).Append("\n");
        sb.Append("  GenerationId: ").Append(GenerationId).Append("\n");
        sb.Append("  PublishResultUri: ").Append(PublishResultUri).Append("\n");
        sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
        sb.Append("  OutputSchema: ").Append(OutputSchema).Append("\n");
        sb.Append("  VirtualAgentEnabled: ").Append(VirtualAgentEnabled).Append("\n");
        sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
        sb.Append("  DatePublishedEnd: ").Append(DatePublishedEnd).Append("\n");
        sb.Append("  NluInfo: ").Append(NluInfo).Append("\n");
        sb.Append("  SupportedLanguages: ").Append(SupportedLanguages).Append("\n");
        sb.Append("  CompatibleFlowTypes: ").Append(CompatibleFlowTypes).Append("\n");
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
        return Equals(obj as FlowVersion);
    }

    /// <summary>
    /// Returns true if FlowVersion instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowVersion to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowVersion other)
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
                CommitVersion == other.CommitVersion ||
                CommitVersion != null &&
                CommitVersion.Equals(other.CommitVersion)
            ) &&
            (
                ConfigurationVersion == other.ConfigurationVersion ||
                ConfigurationVersion != null &&
                ConfigurationVersion.Equals(other.ConfigurationVersion)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Secure == other.Secure ||
                Secure != null &&
                Secure.Equals(other.Secure)
            ) &&
            (
                Debug == other.Debug ||
                Debug != null &&
                Debug.Equals(other.Debug)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                CreatedByClient == other.CreatedByClient ||
                CreatedByClient != null &&
                CreatedByClient.Equals(other.CreatedByClient)
            ) &&
            (
                ConfigurationUri == other.ConfigurationUri ||
                ConfigurationUri != null &&
                ConfigurationUri.Equals(other.ConfigurationUri)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateCheckedIn == other.DateCheckedIn ||
                DateCheckedIn != null &&
                DateCheckedIn.Equals(other.DateCheckedIn)
            ) &&
            (
                DateSaved == other.DateSaved ||
                DateSaved != null &&
                DateSaved.Equals(other.DateSaved)
            ) &&
            (
                GenerationId == other.GenerationId ||
                GenerationId != null &&
                GenerationId.Equals(other.GenerationId)
            ) &&
            (
                PublishResultUri == other.PublishResultUri ||
                PublishResultUri != null &&
                PublishResultUri.Equals(other.PublishResultUri)
            ) &&
            (
                InputSchema == other.InputSchema ||
                InputSchema != null &&
                InputSchema.Equals(other.InputSchema)
            ) &&
            (
                OutputSchema == other.OutputSchema ||
                OutputSchema != null &&
                OutputSchema.Equals(other.OutputSchema)
            ) &&
            (
                VirtualAgentEnabled == other.VirtualAgentEnabled ||
                VirtualAgentEnabled != null &&
                VirtualAgentEnabled.Equals(other.VirtualAgentEnabled)
            ) &&
            (
                DatePublished == other.DatePublished ||
                DatePublished != null &&
                DatePublished.Equals(other.DatePublished)
            ) &&
            (
                DatePublishedEnd == other.DatePublishedEnd ||
                DatePublishedEnd != null &&
                DatePublishedEnd.Equals(other.DatePublishedEnd)
            ) &&
            (
                NluInfo == other.NluInfo ||
                NluInfo != null &&
                NluInfo.Equals(other.NluInfo)
            ) &&
            (
                SupportedLanguages == other.SupportedLanguages ||
                SupportedLanguages != null &&
                SupportedLanguages.SequenceEqual(other.SupportedLanguages)
            ) &&
            (
                CompatibleFlowTypes == other.CompatibleFlowTypes ||
                CompatibleFlowTypes != null &&
                CompatibleFlowTypes.SequenceEqual(other.CompatibleFlowTypes)
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

            if (CommitVersion != null)
            {
                hash = hash * 59 + CommitVersion.GetHashCode();
            }

            if (ConfigurationVersion != null)
            {
                hash = hash * 59 + ConfigurationVersion.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Secure != null)
            {
                hash = hash * 59 + Secure.GetHashCode();
            }

            if (Debug != null)
            {
                hash = hash * 59 + Debug.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (CreatedByClient != null)
            {
                hash = hash * 59 + CreatedByClient.GetHashCode();
            }

            if (ConfigurationUri != null)
            {
                hash = hash * 59 + ConfigurationUri.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateCheckedIn != null)
            {
                hash = hash * 59 + DateCheckedIn.GetHashCode();
            }

            if (DateSaved != null)
            {
                hash = hash * 59 + DateSaved.GetHashCode();
            }

            if (GenerationId != null)
            {
                hash = hash * 59 + GenerationId.GetHashCode();
            }

            if (PublishResultUri != null)
            {
                hash = hash * 59 + PublishResultUri.GetHashCode();
            }

            if (InputSchema != null)
            {
                hash = hash * 59 + InputSchema.GetHashCode();
            }

            if (OutputSchema != null)
            {
                hash = hash * 59 + OutputSchema.GetHashCode();
            }

            if (VirtualAgentEnabled != null)
            {
                hash = hash * 59 + VirtualAgentEnabled.GetHashCode();
            }

            if (DatePublished != null)
            {
                hash = hash * 59 + DatePublished.GetHashCode();
            }

            if (DatePublishedEnd != null)
            {
                hash = hash * 59 + DatePublishedEnd.GetHashCode();
            }

            if (NluInfo != null)
            {
                hash = hash * 59 + NluInfo.GetHashCode();
            }

            if (SupportedLanguages != null)
            {
                hash = hash * 59 + SupportedLanguages.GetHashCode();
            }

            if (CompatibleFlowTypes != null)
            {
                hash = hash * 59 + CompatibleFlowTypes.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
