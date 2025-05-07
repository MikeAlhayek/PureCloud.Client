using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Suggestion
/// </summary>

public partial class Suggestion : IEquatable<Suggestion>
{
    /// <summary>
    /// The type of the documents for which the suggestion is.
    /// </summary>
    /// <value>The type of the documents for which the suggestion is.</value>
    
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
        /// Enum Faq for "Faq"
        /// </summary>
        [EnumMember(Value = "Faq")]
        Faq,

        /// <summary>
        /// Enum Article for "Article"
        /// </summary>
        [EnumMember(Value = "Article")]
        Article,

        /// <summary>
        /// Enum Knowledgearticle for "KnowledgeArticle"
        /// </summary>
        [EnumMember(Value = "KnowledgeArticle")]
        Knowledgearticle,

        /// <summary>
        /// Enum Knowledgesearch for "KnowledgeSearch"
        /// </summary>
        [EnumMember(Value = "KnowledgeSearch")]
        Knowledgesearch,

        /// <summary>
        /// Enum Cannedresponse for "CannedResponse"
        /// </summary>
        [EnumMember(Value = "CannedResponse")]
        Cannedresponse,

        /// <summary>
        /// Enum Script for "Script"
        /// </summary>
        [EnumMember(Value = "Script")]
        Script
    }
    /// <summary>
    /// The trigger type of the suggestion.
    /// </summary>
    /// <value>The trigger type of the suggestion.</value>
    
    public enum TriggerTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Fallback for "Fallback"
        /// </summary>
        [EnumMember(Value = "Fallback")]
        Fallback,

        /// <summary>
        /// Enum Conversationstart for "ConversationStart"
        /// </summary>
        [EnumMember(Value = "ConversationStart")]
        Conversationstart,

        /// <summary>
        /// Enum Conversationtransfer for "ConversationTransfer"
        /// </summary>
        [EnumMember(Value = "ConversationTransfer")]
        Conversationtransfer,

        /// <summary>
        /// Enum Conversationend for "ConversationEnd"
        /// </summary>
        [EnumMember(Value = "ConversationEnd")]
        Conversationend,

        /// <summary>
        /// Enum Intent for "Intent"
        /// </summary>
        [EnumMember(Value = "Intent")]
        Intent
    }
    /// <summary>
    /// The state of the suggestion.
    /// </summary>
    /// <value>The state of the suggestion.</value>
    
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
        /// Enum Suggested for "Suggested"
        /// </summary>
        [EnumMember(Value = "Suggested")]
        Suggested,

        /// <summary>
        /// Enum Accepted for "Accepted"
        /// </summary>
        [EnumMember(Value = "Accepted")]
        Accepted,

        /// <summary>
        /// Enum Dismissed for "Dismissed"
        /// </summary>
        [EnumMember(Value = "Dismissed")]
        Dismissed,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Rated for "Rated"
        /// </summary>
        [EnumMember(Value = "Rated")]
        Rated
    }
    /// <summary>
    /// The type of the documents for which the suggestion is.
    /// </summary>
    /// <value>The type of the documents for which the suggestion is.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The trigger type of the suggestion.
    /// </summary>
    /// <value>The trigger type of the suggestion.</value>
    [JsonPropertyName("triggerType")]
    public TriggerTypeEnum? TriggerType { get; set; }
    /// <summary>
    /// The state of the suggestion.
    /// </summary>
    /// <value>The state of the suggestion.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Suggestion" /> class.
    /// </summary>
    public Suggestion()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The Faq from the knowledgebase that was provided as the suggestion.
    /// </summary>
    /// <value>The Faq from the knowledgebase that was provided as the suggestion.</value>
    [JsonPropertyName("faq")]
    public Faq Faq { get; set; }



    /// <summary>
    /// The article from the knowledgebase that was provided as the suggestion.
    /// </summary>
    /// <value>The article from the knowledgebase that was provided as the suggestion.</value>
    [JsonPropertyName("article")]
    public Article Article { get; set; }



    /// <summary>
    /// Date when the suggestion was created. For example: yyyy-MM-ddTHH:mm:ss.SSZ. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the suggestion was created. For example: yyyy-MM-ddTHH:mm:ss.SSZ. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The ID of the knowledge search that provided the suggestion.
    /// </summary>
    /// <value>The ID of the knowledge search that provided the suggestion.</value>
    [JsonPropertyName("answerRecordId")]
    public string AnswerRecordId { get; set; }





    /// <summary>
    /// The conversation context in which the suggestion was raised.
    /// </summary>
    /// <value>The conversation context in which the suggestion was raised.</value>
    [JsonPropertyName("context")]
    public SuggestionContext Context { get; set; }





    /// <summary>
    /// The suggested knowledge search result that was provided as the suggestion.
    /// </summary>
    /// <value>The suggested knowledge search result that was provided as the suggestion.</value>
    [JsonPropertyName("knowledgeSearch")]
    public SuggestionKnowledgeSearch KnowledgeSearch { get; set; }



    /// <summary>
    /// The suggested knowledge article that was provided as the suggestion.
    /// </summary>
    /// <value>The suggested knowledge article that was provided as the suggestion.</value>
    [JsonPropertyName("knowledgeArticle")]
    public SuggestionKnowledgeArticle KnowledgeArticle { get; set; }



    /// <summary>
    /// The suggested canned response that was provided as the suggestion.
    /// </summary>
    /// <value>The suggested canned response that was provided as the suggestion.</value>
    [JsonPropertyName("cannedResponse")]
    public SuggestionCannedResponse CannedResponse { get; set; }



    /// <summary>
    /// The suggested script that was provided as the suggestion.
    /// </summary>
    /// <value>The suggested script that was provided as the suggestion.</value>
    [JsonPropertyName("script")]
    public SuggestionScript Script { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// The conversation that the suggestions correspond to.
    /// </summary>
    /// <value>The conversation that the suggestions correspond to.</value>
    [JsonPropertyName("conversation")]
    public AddressableEntityRef Conversation { get; set; }



    /// <summary>
    /// The assistant that was used to provide the suggestions.
    /// </summary>
    /// <value>The assistant that was used to provide the suggestions.</value>
    [JsonPropertyName("assistant")]
    public AddressableEntityRef Assistant { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Suggestion {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Faq: ").Append(Faq).Append("\n");
        sb.Append("  Article: ").Append(Article).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  AnswerRecordId: ").Append(AnswerRecordId).Append("\n");
        sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
        sb.Append("  Context: ").Append(Context).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  KnowledgeSearch: ").Append(KnowledgeSearch).Append("\n");
        sb.Append("  KnowledgeArticle: ").Append(KnowledgeArticle).Append("\n");
        sb.Append("  CannedResponse: ").Append(CannedResponse).Append("\n");
        sb.Append("  Script: ").Append(Script).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  Assistant: ").Append(Assistant).Append("\n");
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
        return Equals(obj as Suggestion);
    }

    /// <summary>
    /// Returns true if Suggestion instances are equal
    /// </summary>
    /// <param name="other">Instance of Suggestion to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Suggestion other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Faq == other.Faq ||
                Faq != null &&
                Faq.Equals(other.Faq)
            ) &&
            (
                Article == other.Article ||
                Article != null &&
                Article.Equals(other.Article)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                AnswerRecordId == other.AnswerRecordId ||
                AnswerRecordId != null &&
                AnswerRecordId.Equals(other.AnswerRecordId)
            ) &&
            (
                TriggerType == other.TriggerType ||
                TriggerType != null &&
                TriggerType.Equals(other.TriggerType)
            ) &&
            (
                Context == other.Context ||
                Context != null &&
                Context.Equals(other.Context)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                KnowledgeSearch == other.KnowledgeSearch ||
                KnowledgeSearch != null &&
                KnowledgeSearch.Equals(other.KnowledgeSearch)
            ) &&
            (
                KnowledgeArticle == other.KnowledgeArticle ||
                KnowledgeArticle != null &&
                KnowledgeArticle.Equals(other.KnowledgeArticle)
            ) &&
            (
                CannedResponse == other.CannedResponse ||
                CannedResponse != null &&
                CannedResponse.Equals(other.CannedResponse)
            ) &&
            (
                Script == other.Script ||
                Script != null &&
                Script.Equals(other.Script)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                Assistant == other.Assistant ||
                Assistant != null &&
                Assistant.Equals(other.Assistant)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Faq != null)
            {
                hash = hash * 59 + Faq.GetHashCode();
            }

            if (Article != null)
            {
                hash = hash * 59 + Article.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (AnswerRecordId != null)
            {
                hash = hash * 59 + AnswerRecordId.GetHashCode();
            }

            if (TriggerType != null)
            {
                hash = hash * 59 + TriggerType.GetHashCode();
            }

            if (Context != null)
            {
                hash = hash * 59 + Context.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (KnowledgeSearch != null)
            {
                hash = hash * 59 + KnowledgeSearch.GetHashCode();
            }

            if (KnowledgeArticle != null)
            {
                hash = hash * 59 + KnowledgeArticle.GetHashCode();
            }

            if (CannedResponse != null)
            {
                hash = hash * 59 + CannedResponse.GetHashCode();
            }

            if (Script != null)
            {
                hash = hash * 59 + Script.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (Assistant != null)
            {
                hash = hash * 59 + Assistant.GetHashCode();
            }

            return hash;
        }
    }
}
