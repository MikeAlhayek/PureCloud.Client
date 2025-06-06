using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateWebChatRequest
/// </summary>

public partial class CreateWebChatRequest : IEquatable<CreateWebChatRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateWebChatRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateWebChatRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateWebChatRequest" /> class.
    /// </summary>
    /// <param name="QueueId">The ID of the queue to use for routing the chat conversation. (required).</param>
    /// <param name="Provider">The name of the provider that is sourcing the web chat. (required).</param>
    /// <param name="SkillIds">The list of skill ID&#39;s to use for routing..</param>
    /// <param name="LanguageId">The ID of the langauge to use for routing..</param>
    /// <param name="Priority">The priority to assign to the conversation for routing..</param>
    /// <param name="Attributes">The list of attributes to associate with the customer participant..</param>
    /// <param name="CustomerName">The name of the customer participating in the web chat..</param>
    public CreateWebChatRequest(string QueueId = null, string Provider = null, List<string> SkillIds = null, string LanguageId = null, long? Priority = null, Dictionary<string, string> Attributes = null, string CustomerName = null)
    {
        this.QueueId = QueueId;
        this.Provider = Provider;
        this.SkillIds = SkillIds;
        this.LanguageId = LanguageId;
        this.Priority = Priority;
        this.Attributes = Attributes;
        this.CustomerName = CustomerName;

    }



    /// <summary>
    /// The ID of the queue to use for routing the chat conversation.
    /// </summary>
    /// <value>The ID of the queue to use for routing the chat conversation.</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// The name of the provider that is sourcing the web chat.
    /// </summary>
    /// <value>The name of the provider that is sourcing the web chat.</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }



    /// <summary>
    /// The list of skill ID&#39;s to use for routing.
    /// </summary>
    /// <value>The list of skill ID&#39;s to use for routing.</value>
    [JsonPropertyName("skillIds")]
    public List<string> SkillIds { get; set; }



    /// <summary>
    /// The ID of the langauge to use for routing.
    /// </summary>
    /// <value>The ID of the langauge to use for routing.</value>
    [JsonPropertyName("languageId")]
    public string LanguageId { get; set; }



    /// <summary>
    /// The priority to assign to the conversation for routing.
    /// </summary>
    /// <value>The priority to assign to the conversation for routing.</value>
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }



    /// <summary>
    /// The list of attributes to associate with the customer participant.
    /// </summary>
    /// <value>The list of attributes to associate with the customer participant.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// The name of the customer participating in the web chat.
    /// </summary>
    /// <value>The name of the customer participating in the web chat.</value>
    [JsonPropertyName("customerName")]
    public string CustomerName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateWebChatRequest {\n");

        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
        sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
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
        return Equals(obj as CreateWebChatRequest);
    }

    /// <summary>
    /// Returns true if CreateWebChatRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateWebChatRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateWebChatRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                SkillIds == other.SkillIds ||
                SkillIds != null &&
                SkillIds.SequenceEqual(other.SkillIds)
            ) &&
            (
                LanguageId == other.LanguageId ||
                LanguageId != null &&
                LanguageId.Equals(other.LanguageId)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                CustomerName == other.CustomerName ||
                CustomerName != null &&
                CustomerName.Equals(other.CustomerName)
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
            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (SkillIds != null)
            {
                hash = hash * 59 + SkillIds.GetHashCode();
            }

            if (LanguageId != null)
            {
                hash = hash * 59 + LanguageId.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (CustomerName != null)
            {
                hash = hash * 59 + CustomerName.GetHashCode();
            }

            return hash;
        }
    }
}
