using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Assistant
/// </summary>

public partial class Assistant : IEquatable<Assistant>
{
    /// <summary>
    /// State of the assistant.
    /// </summary>
    /// <value>State of the assistant.</value>
    
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
        Inactive
    }
    /// <summary>
    /// State of the assistant.
    /// </summary>
    /// <value>State of the assistant.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Assistant" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Assistant() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Assistant" /> class.
    /// </summary>
    /// <param name="Name">The name of the assistant that will assist the agent. (required).</param>
    /// <param name="GoogleDialogflowConfig">(Deprecated: use the &#39;knowledgeSuggestionConfig&#39; for genesys knowledge suggestions) Configuration of Dialogflow used to assist the agent with transcriptions and knowledge suggestions..</param>
    /// <param name="TranscriptionConfig">Configuration for speech transcription used to assist the agent. (required).</param>
    /// <param name="KnowledgeSuggestionConfig">Configuration that defines how to produce knowledge suggestions. (required).</param>
    public Assistant(string Name = null, GoogleDialogflowConfig GoogleDialogflowConfig = null, TranscriptionConfig TranscriptionConfig = null, KnowledgeSuggestionConfig KnowledgeSuggestionConfig = null)
    {
        this.Name = Name;
        this.GoogleDialogflowConfig = GoogleDialogflowConfig;
        this.TranscriptionConfig = TranscriptionConfig;
        this.KnowledgeSuggestionConfig = KnowledgeSuggestionConfig;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the assistant that will assist the agent.
    /// </summary>
    /// <value>The name of the assistant that will assist the agent.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Date when the assistant was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assistant was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date when the assistant was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assistant was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The user who created the assistant.
    /// </summary>
    /// <value>The user who created the assistant.</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The user who last modified the assistant.
    /// </summary>
    /// <value>The user who last modified the assistant.</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// (Deprecated: use the &#39;knowledgeSuggestionConfig&#39; for genesys knowledge suggestions) Configuration of Dialogflow used to assist the agent with transcriptions and knowledge suggestions.
    /// </summary>
    /// <value>(Deprecated: use the &#39;knowledgeSuggestionConfig&#39; for genesys knowledge suggestions) Configuration of Dialogflow used to assist the agent with transcriptions and knowledge suggestions.</value>
    [JsonPropertyName("googleDialogflowConfig")]
    public GoogleDialogflowConfig GoogleDialogflowConfig { get; set; }



    /// <summary>
    /// Configuration for speech transcription used to assist the agent.
    /// </summary>
    /// <value>Configuration for speech transcription used to assist the agent.</value>
    [JsonPropertyName("transcriptionConfig")]
    public TranscriptionConfig TranscriptionConfig { get; set; }



    /// <summary>
    /// Configuration that defines how to produce knowledge suggestions.
    /// </summary>
    /// <value>Configuration that defines how to produce knowledge suggestions.</value>
    [JsonPropertyName("knowledgeSuggestionConfig")]
    public KnowledgeSuggestionConfig KnowledgeSuggestionConfig { get; set; }





    /// <summary>
    /// Agent copilot configuration.
    /// </summary>
    /// <value>Agent copilot configuration.</value>
    [JsonPropertyName("copilot")]
    public Copilot Copilot { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Assistant {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  GoogleDialogflowConfig: ").Append(GoogleDialogflowConfig).Append("\n");
        sb.Append("  TranscriptionConfig: ").Append(TranscriptionConfig).Append("\n");
        sb.Append("  KnowledgeSuggestionConfig: ").Append(KnowledgeSuggestionConfig).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Copilot: ").Append(Copilot).Append("\n");
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
        return Equals(obj as Assistant);
    }

    /// <summary>
    /// Returns true if Assistant instances are equal
    /// </summary>
    /// <param name="other">Instance of Assistant to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Assistant other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                GoogleDialogflowConfig == other.GoogleDialogflowConfig ||
                GoogleDialogflowConfig != null &&
                GoogleDialogflowConfig.Equals(other.GoogleDialogflowConfig)
            ) &&
            (
                TranscriptionConfig == other.TranscriptionConfig ||
                TranscriptionConfig != null &&
                TranscriptionConfig.Equals(other.TranscriptionConfig)
            ) &&
            (
                KnowledgeSuggestionConfig == other.KnowledgeSuggestionConfig ||
                KnowledgeSuggestionConfig != null &&
                KnowledgeSuggestionConfig.Equals(other.KnowledgeSuggestionConfig)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Copilot == other.Copilot ||
                Copilot != null &&
                Copilot.Equals(other.Copilot)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (GoogleDialogflowConfig != null)
            {
                hash = hash * 59 + GoogleDialogflowConfig.GetHashCode();
            }

            if (TranscriptionConfig != null)
            {
                hash = hash * 59 + TranscriptionConfig.GetHashCode();
            }

            if (KnowledgeSuggestionConfig != null)
            {
                hash = hash * 59 + KnowledgeSuggestionConfig.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Copilot != null)
            {
                hash = hash * 59 + Copilot.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
