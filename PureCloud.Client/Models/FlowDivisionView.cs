using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowDivisionView
/// </summary>

public partial class FlowDivisionView : IEquatable<FlowDivisionView>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
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
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowDivisionView" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowDivisionView() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowDivisionView" /> class.
    /// </summary>
    /// <param name="Id">The flow identifier.</param>
    /// <param name="Name">The flow name (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Type">Type.</param>
    /// <param name="Description">the flow description.</param>
    /// <param name="InputSchema">json schema describing the inputs for the flow.</param>
    /// <param name="OutputSchema">json schema describing the outputs for the flow.</param>
    /// <param name="PublishedVersion">published version information if there is a published version.</param>
    /// <param name="DebugVersion">debug version information if there is a debug version.</param>
    public FlowDivisionView(string Id = null, string Name = null, WritableDivision Division = null, TypeEnum? Type = null, string Description = null, JsonSchemaDocument InputSchema = null, JsonSchemaDocument OutputSchema = null, FlowVersion PublishedVersion = null, FlowVersion DebugVersion = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Division = Division;
        this.Type = Type;
        this.Description = Description;
        this.InputSchema = InputSchema;
        this.OutputSchema = OutputSchema;
        this.PublishedVersion = PublishedVersion;
        this.DebugVersion = DebugVersion;

    }



    /// <summary>
    /// The flow identifier
    /// </summary>
    /// <value>The flow identifier</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The flow name
    /// </summary>
    /// <value>The flow name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableDivision Division { get; set; }





    /// <summary>
    /// the flow description
    /// </summary>
    /// <value>the flow description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// json schema describing the inputs for the flow
    /// </summary>
    /// <value>json schema describing the inputs for the flow</value>
    [JsonPropertyName("inputSchema")]
    public JsonSchemaDocument InputSchema { get; set; }



    /// <summary>
    /// json schema describing the outputs for the flow
    /// </summary>
    /// <value>json schema describing the outputs for the flow</value>
    [JsonPropertyName("outputSchema")]
    public JsonSchemaDocument OutputSchema { get; set; }



    /// <summary>
    /// List of supported languages for the published version of the flow.
    /// </summary>
    /// <value>List of supported languages for the published version of the flow.</value>
    [JsonPropertyName("supportedLanguages")]
    public List<SupportedLanguage> SupportedLanguages { get; private set; }



    /// <summary>
    /// published version information if there is a published version
    /// </summary>
    /// <value>published version information if there is a published version</value>
    [JsonPropertyName("publishedVersion")]
    public FlowVersion PublishedVersion { get; set; }



    /// <summary>
    /// debug version information if there is a debug version
    /// </summary>
    /// <value>debug version information if there is a debug version</value>
    [JsonPropertyName("debugVersion")]
    public FlowVersion DebugVersion { get; set; }



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
        sb.Append("class FlowDivisionView {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
        sb.Append("  OutputSchema: ").Append(OutputSchema).Append("\n");
        sb.Append("  SupportedLanguages: ").Append(SupportedLanguages).Append("\n");
        sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
        sb.Append("  DebugVersion: ").Append(DebugVersion).Append("\n");
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
        return Equals(obj as FlowDivisionView);
    }

    /// <summary>
    /// Returns true if FlowDivisionView instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowDivisionView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowDivisionView other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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
                SupportedLanguages == other.SupportedLanguages ||
                SupportedLanguages != null &&
                SupportedLanguages.SequenceEqual(other.SupportedLanguages)
            ) &&
            (
                PublishedVersion == other.PublishedVersion ||
                PublishedVersion != null &&
                PublishedVersion.Equals(other.PublishedVersion)
            ) &&
            (
                DebugVersion == other.DebugVersion ||
                DebugVersion != null &&
                DebugVersion.Equals(other.DebugVersion)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (InputSchema != null)
            {
                hash = hash * 59 + InputSchema.GetHashCode();
            }

            if (OutputSchema != null)
            {
                hash = hash * 59 + OutputSchema.GetHashCode();
            }

            if (SupportedLanguages != null)
            {
                hash = hash * 59 + SupportedLanguages.GetHashCode();
            }

            if (PublishedVersion != null)
            {
                hash = hash * 59 + PublishedVersion.GetHashCode();
            }

            if (DebugVersion != null)
            {
                hash = hash * 59 + DebugVersion.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
