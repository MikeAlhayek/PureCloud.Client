using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Flow
/// </summary>

public partial class Flow : IEquatable<Flow>
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
    /// Gets or Sets CompatibleFlowTypes
    /// </summary>
    
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
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Flow" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Flow() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Flow" /> class.
    /// </summary>
    /// <param name="Id">The flow identifier.</param>
    /// <param name="Name">The flow name (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">Description.</param>
    /// <param name="Type">Type.</param>
    /// <param name="LockedUser">User that has the flow locked..</param>
    /// <param name="LockedClient">OAuth client that has the flow locked..</param>
    /// <param name="Active">Active.</param>
    /// <param name="System">System.</param>
    /// <param name="Deleted">Deleted.</param>
    /// <param name="PublishedVersion">PublishedVersion.</param>
    /// <param name="SavedVersion">SavedVersion.</param>
    /// <param name="InputSchema">json schema describing the inputs for the flow.</param>
    /// <param name="OutputSchema">json schema describing the outputs for the flow.</param>
    /// <param name="CheckedInVersion">CheckedInVersion.</param>
    /// <param name="DebugVersion">DebugVersion.</param>
    /// <param name="PublishedBy">PublishedBy.</param>
    /// <param name="CurrentOperation">CurrentOperation.</param>
    /// <param name="WorktypeId">WorktypeId.</param>
    /// <param name="VirtualAgentEnabled">VirtualAgentEnabled.</param>
    public Flow(string Id = null, string Name = null, WritableDivision Division = null, string Description = null, TypeEnum? Type = null, User LockedUser = null, DomainEntityRef LockedClient = null, bool? Active = null, bool? System = null, bool? Deleted = null, FlowVersion PublishedVersion = null, FlowVersion SavedVersion = null, object InputSchema = null, object OutputSchema = null, FlowVersion CheckedInVersion = null, FlowVersion DebugVersion = null, User PublishedBy = null, Operation CurrentOperation = null, string WorktypeId = null, bool? VirtualAgentEnabled = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Type = Type;
        this.LockedUser = LockedUser;
        this.LockedClient = LockedClient;
        this.Active = Active;
        this.System = System;
        this.Deleted = Deleted;
        this.PublishedVersion = PublishedVersion;
        this.SavedVersion = SavedVersion;
        this.InputSchema = InputSchema;
        this.OutputSchema = OutputSchema;
        this.CheckedInVersion = CheckedInVersion;
        this.DebugVersion = DebugVersion;
        this.PublishedBy = PublishedBy;
        this.CurrentOperation = CurrentOperation;
        this.WorktypeId = WorktypeId;
        this.VirtualAgentEnabled = VirtualAgentEnabled;

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
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }





    /// <summary>
    /// User that has the flow locked.
    /// </summary>
    /// <value>User that has the flow locked.</value>
    [JsonPropertyName("lockedUser")]
    public User LockedUser { get; set; }



    /// <summary>
    /// OAuth client that has the flow locked.
    /// </summary>
    /// <value>OAuth client that has the flow locked.</value>
    [JsonPropertyName("lockedClient")]
    public DomainEntityRef LockedClient { get; set; }



    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }



    /// <summary>
    /// Gets or Sets System
    /// </summary>
    [JsonPropertyName("system")]
    public bool? System { get; set; }



    /// <summary>
    /// Gets or Sets Deleted
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }



    /// <summary>
    /// Gets or Sets PublishedVersion
    /// </summary>
    [JsonPropertyName("publishedVersion")]
    public FlowVersion PublishedVersion { get; set; }



    /// <summary>
    /// Gets or Sets SavedVersion
    /// </summary>
    [JsonPropertyName("savedVersion")]
    public FlowVersion SavedVersion { get; set; }



    /// <summary>
    /// json schema describing the inputs for the flow
    /// </summary>
    /// <value>json schema describing the inputs for the flow</value>
    [JsonPropertyName("inputSchema")]
    public object InputSchema { get; set; }



    /// <summary>
    /// json schema describing the outputs for the flow
    /// </summary>
    /// <value>json schema describing the outputs for the flow</value>
    [JsonPropertyName("outputSchema")]
    public object OutputSchema { get; set; }



    /// <summary>
    /// Gets or Sets CheckedInVersion
    /// </summary>
    [JsonPropertyName("checkedInVersion")]
    public FlowVersion CheckedInVersion { get; set; }



    /// <summary>
    /// Gets or Sets DebugVersion
    /// </summary>
    [JsonPropertyName("debugVersion")]
    public FlowVersion DebugVersion { get; set; }



    /// <summary>
    /// Gets or Sets PublishedBy
    /// </summary>
    [JsonPropertyName("publishedBy")]
    public User PublishedBy { get; set; }



    /// <summary>
    /// Gets or Sets CurrentOperation
    /// </summary>
    [JsonPropertyName("currentOperation")]
    public Operation CurrentOperation { get; set; }



    /// <summary>
    /// Information about the natural language understanding configuration for the published version of the flow
    /// </summary>
    /// <value>Information about the natural language understanding configuration for the published version of the flow</value>
    [JsonPropertyName("nluInfo")]
    public NluInfo NluInfo { get; private set; }



    /// <summary>
    /// List of supported languages for the published version of the flow.
    /// </summary>
    /// <value>List of supported languages for the published version of the flow.</value>
    [JsonPropertyName("supportedLanguages")]
    public List<SupportedLanguage> SupportedLanguages { get; private set; }



    /// <summary>
    /// Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.
    /// </summary>
    /// <value>Compatible flow types designate which flow types are allowed to embed a flow’s configuration within their own flow configuration.  Currently the only flows that can be embedded are Common Module flows and the embedding flow can invoke them using the Call Common Module action.</value>
    [JsonPropertyName("compatibleFlowTypes")]
    public List<CompatibleFlowTypesEnum> CompatibleFlowTypes { get; private set; }



    /// <summary>
    /// Gets or Sets WorktypeId
    /// </summary>
    [JsonPropertyName("worktypeId")]
    public string WorktypeId { get; set; }



    /// <summary>
    /// Gets or Sets VirtualAgentEnabled
    /// </summary>
    [JsonPropertyName("virtualAgentEnabled")]
    public bool? VirtualAgentEnabled { get; set; }



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
        sb.Append("class Flow {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  LockedUser: ").Append(LockedUser).Append("\n");
        sb.Append("  LockedClient: ").Append(LockedClient).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  System: ").Append(System).Append("\n");
        sb.Append("  Deleted: ").Append(Deleted).Append("\n");
        sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
        sb.Append("  SavedVersion: ").Append(SavedVersion).Append("\n");
        sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
        sb.Append("  OutputSchema: ").Append(OutputSchema).Append("\n");
        sb.Append("  CheckedInVersion: ").Append(CheckedInVersion).Append("\n");
        sb.Append("  DebugVersion: ").Append(DebugVersion).Append("\n");
        sb.Append("  PublishedBy: ").Append(PublishedBy).Append("\n");
        sb.Append("  CurrentOperation: ").Append(CurrentOperation).Append("\n");
        sb.Append("  NluInfo: ").Append(NluInfo).Append("\n");
        sb.Append("  SupportedLanguages: ").Append(SupportedLanguages).Append("\n");
        sb.Append("  CompatibleFlowTypes: ").Append(CompatibleFlowTypes).Append("\n");
        sb.Append("  WorktypeId: ").Append(WorktypeId).Append("\n");
        sb.Append("  VirtualAgentEnabled: ").Append(VirtualAgentEnabled).Append("\n");
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
        return Equals(obj as Flow);
    }

    /// <summary>
    /// Returns true if Flow instances are equal
    /// </summary>
    /// <param name="other">Instance of Flow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Flow other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                LockedUser == other.LockedUser ||
                LockedUser != null &&
                LockedUser.Equals(other.LockedUser)
            ) &&
            (
                LockedClient == other.LockedClient ||
                LockedClient != null &&
                LockedClient.Equals(other.LockedClient)
            ) &&
            (
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
            ) &&
            (
                System == other.System ||
                System != null &&
                System.Equals(other.System)
            ) &&
            (
                Deleted == other.Deleted ||
                Deleted != null &&
                Deleted.Equals(other.Deleted)
            ) &&
            (
                PublishedVersion == other.PublishedVersion ||
                PublishedVersion != null &&
                PublishedVersion.Equals(other.PublishedVersion)
            ) &&
            (
                SavedVersion == other.SavedVersion ||
                SavedVersion != null &&
                SavedVersion.Equals(other.SavedVersion)
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
                CheckedInVersion == other.CheckedInVersion ||
                CheckedInVersion != null &&
                CheckedInVersion.Equals(other.CheckedInVersion)
            ) &&
            (
                DebugVersion == other.DebugVersion ||
                DebugVersion != null &&
                DebugVersion.Equals(other.DebugVersion)
            ) &&
            (
                PublishedBy == other.PublishedBy ||
                PublishedBy != null &&
                PublishedBy.Equals(other.PublishedBy)
            ) &&
            (
                CurrentOperation == other.CurrentOperation ||
                CurrentOperation != null &&
                CurrentOperation.Equals(other.CurrentOperation)
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
                WorktypeId == other.WorktypeId ||
                WorktypeId != null &&
                WorktypeId.Equals(other.WorktypeId)
            ) &&
            (
                VirtualAgentEnabled == other.VirtualAgentEnabled ||
                VirtualAgentEnabled != null &&
                VirtualAgentEnabled.Equals(other.VirtualAgentEnabled)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (LockedUser != null)
            {
                hash = hash * 59 + LockedUser.GetHashCode();
            }

            if (LockedClient != null)
            {
                hash = hash * 59 + LockedClient.GetHashCode();
            }

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (System != null)
            {
                hash = hash * 59 + System.GetHashCode();
            }

            if (Deleted != null)
            {
                hash = hash * 59 + Deleted.GetHashCode();
            }

            if (PublishedVersion != null)
            {
                hash = hash * 59 + PublishedVersion.GetHashCode();
            }

            if (SavedVersion != null)
            {
                hash = hash * 59 + SavedVersion.GetHashCode();
            }

            if (InputSchema != null)
            {
                hash = hash * 59 + InputSchema.GetHashCode();
            }

            if (OutputSchema != null)
            {
                hash = hash * 59 + OutputSchema.GetHashCode();
            }

            if (CheckedInVersion != null)
            {
                hash = hash * 59 + CheckedInVersion.GetHashCode();
            }

            if (DebugVersion != null)
            {
                hash = hash * 59 + DebugVersion.GetHashCode();
            }

            if (PublishedBy != null)
            {
                hash = hash * 59 + PublishedBy.GetHashCode();
            }

            if (CurrentOperation != null)
            {
                hash = hash * 59 + CurrentOperation.GetHashCode();
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

            if (WorktypeId != null)
            {
                hash = hash * 59 + WorktypeId.GetHashCode();
            }

            if (VirtualAgentEnabled != null)
            {
                hash = hash * 59 + VirtualAgentEnabled.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
