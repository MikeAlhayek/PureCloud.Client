using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GoogleDialogflowConfig
/// </summary>

public partial class GoogleDialogflowConfig : IEquatable<GoogleDialogflowConfig>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="GoogleDialogflowConfig" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GoogleDialogflowConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GoogleDialogflowConfig" /> class.
    /// </summary>
    /// <param name="IntegrationId">The integration identifier with which the assistant will fetch transcriptions and knowledge suggestions..</param>
    /// <param name="ConversationProfiles">The conversation profiles for which the assistant will fetch transcription and knowledge suggestions. (required).</param>
    public GoogleDialogflowConfig(string IntegrationId = null, List<ConversationProfile> ConversationProfiles = null)
    {
        this.IntegrationId = IntegrationId;
        this.ConversationProfiles = ConversationProfiles;

    }



    /// <summary>
    /// The integration identifier with which the assistant will fetch transcriptions and knowledge suggestions.
    /// </summary>
    /// <value>The integration identifier with which the assistant will fetch transcriptions and knowledge suggestions.</value>
    [JsonPropertyName("integrationId")]
    public string IntegrationId { get; set; }



    /// <summary>
    /// The conversation profiles for which the assistant will fetch transcription and knowledge suggestions.
    /// </summary>
    /// <value>The conversation profiles for which the assistant will fetch transcription and knowledge suggestions.</value>
    [JsonPropertyName("conversationProfiles")]
    public List<ConversationProfile> ConversationProfiles { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GoogleDialogflowConfig {\n");

        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  ConversationProfiles: ").Append(ConversationProfiles).Append("\n");
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
        return Equals(obj as GoogleDialogflowConfig);
    }

    /// <summary>
    /// Returns true if GoogleDialogflowConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of GoogleDialogflowConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GoogleDialogflowConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
            ) &&
            (
                ConversationProfiles == other.ConversationProfiles ||
                ConversationProfiles != null &&
                ConversationProfiles.SequenceEqual(other.ConversationProfiles)
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
            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            if (ConversationProfiles != null)
            {
                hash = hash * 59 + ConversationProfiles.GetHashCode();
            }

            return hash;
        }
    }
}
