using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentsAnswerFilter
/// </summary>

public partial class KnowledgeDocumentsAnswerFilter : IEquatable<KnowledgeDocumentsAnswerFilter>
{
    /// <summary>
    /// The language of the documents.
    /// </summary>
    /// <value>The language of the documents.</value>
    
    public enum LanguageEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Enus for "en-US"
        /// </summary>
        [EnumMember(Value = "en-US")]
        Enus,

        /// <summary>
        /// Enum Enuk for "en-UK"
        /// </summary>
        [EnumMember(Value = "en-UK")]
        Enuk,

        /// <summary>
        /// Enum Enau for "en-AU"
        /// </summary>
        [EnumMember(Value = "en-AU")]
        Enau,

        /// <summary>
        /// Enum Enca for "en-CA"
        /// </summary>
        [EnumMember(Value = "en-CA")]
        Enca,

        /// <summary>
        /// Enum Enhk for "en-HK"
        /// </summary>
        [EnumMember(Value = "en-HK")]
        Enhk,

        /// <summary>
        /// Enum Enin for "en-IN"
        /// </summary>
        [EnumMember(Value = "en-IN")]
        Enin,

        /// <summary>
        /// Enum Enie for "en-IE"
        /// </summary>
        [EnumMember(Value = "en-IE")]
        Enie,

        /// <summary>
        /// Enum Ennz for "en-NZ"
        /// </summary>
        [EnumMember(Value = "en-NZ")]
        Ennz,

        /// <summary>
        /// Enum Enph for "en-PH"
        /// </summary>
        [EnumMember(Value = "en-PH")]
        Enph,

        /// <summary>
        /// Enum Ensg for "en-SG"
        /// </summary>
        [EnumMember(Value = "en-SG")]
        Ensg,

        /// <summary>
        /// Enum Enza for "en-ZA"
        /// </summary>
        [EnumMember(Value = "en-ZA")]
        Enza,

        /// <summary>
        /// Enum Dede for "de-DE"
        /// </summary>
        [EnumMember(Value = "de-DE")]
        Dede,

        /// <summary>
        /// Enum Deat for "de-AT"
        /// </summary>
        [EnumMember(Value = "de-AT")]
        Deat,

        /// <summary>
        /// Enum Dech for "de-CH"
        /// </summary>
        [EnumMember(Value = "de-CH")]
        Dech,

        /// <summary>
        /// Enum Esar for "es-AR"
        /// </summary>
        [EnumMember(Value = "es-AR")]
        Esar,

        /// <summary>
        /// Enum Esco for "es-CO"
        /// </summary>
        [EnumMember(Value = "es-CO")]
        Esco,

        /// <summary>
        /// Enum Esmx for "es-MX"
        /// </summary>
        [EnumMember(Value = "es-MX")]
        Esmx,

        /// <summary>
        /// Enum Esus for "es-US"
        /// </summary>
        [EnumMember(Value = "es-US")]
        Esus,

        /// <summary>
        /// Enum Eses for "es-ES"
        /// </summary>
        [EnumMember(Value = "es-ES")]
        Eses,

        /// <summary>
        /// Enum Frfr for "fr-FR"
        /// </summary>
        [EnumMember(Value = "fr-FR")]
        Frfr,

        /// <summary>
        /// Enum Frbe for "fr-BE"
        /// </summary>
        [EnumMember(Value = "fr-BE")]
        Frbe,

        /// <summary>
        /// Enum Frca for "fr-CA"
        /// </summary>
        [EnumMember(Value = "fr-CA")]
        Frca,

        /// <summary>
        /// Enum Frch for "fr-CH"
        /// </summary>
        [EnumMember(Value = "fr-CH")]
        Frch,

        /// <summary>
        /// Enum Ptbr for "pt-BR"
        /// </summary>
        [EnumMember(Value = "pt-BR")]
        Ptbr,

        /// <summary>
        /// Enum Ptpt for "pt-PT"
        /// </summary>
        [EnumMember(Value = "pt-PT")]
        Ptpt,

        /// <summary>
        /// Enum Nlnl for "nl-NL"
        /// </summary>
        [EnumMember(Value = "nl-NL")]
        Nlnl,

        /// <summary>
        /// Enum Nlbe for "nl-BE"
        /// </summary>
        [EnumMember(Value = "nl-BE")]
        Nlbe,

        /// <summary>
        /// Enum Itit for "it-IT"
        /// </summary>
        [EnumMember(Value = "it-IT")]
        Itit,

        /// <summary>
        /// Enum Caes for "ca-ES"
        /// </summary>
        [EnumMember(Value = "ca-ES")]
        Caes,

        /// <summary>
        /// Enum Trtr for "tr-TR"
        /// </summary>
        [EnumMember(Value = "tr-TR")]
        Trtr,

        /// <summary>
        /// Enum Svse for "sv-SE"
        /// </summary>
        [EnumMember(Value = "sv-SE")]
        Svse,

        /// <summary>
        /// Enum Fifi for "fi-FI"
        /// </summary>
        [EnumMember(Value = "fi-FI")]
        Fifi,

        /// <summary>
        /// Enum Nbno for "nb-NO"
        /// </summary>
        [EnumMember(Value = "nb-NO")]
        Nbno,

        /// <summary>
        /// Enum Dadk for "da-DK"
        /// </summary>
        [EnumMember(Value = "da-DK")]
        Dadk,

        /// <summary>
        /// Enum Jajp for "ja-JP"
        /// </summary>
        [EnumMember(Value = "ja-JP")]
        Jajp,

        /// <summary>
        /// Enum Arae for "ar-AE"
        /// </summary>
        [EnumMember(Value = "ar-AE")]
        Arae,

        /// <summary>
        /// Enum Zhcn for "zh-CN"
        /// </summary>
        [EnumMember(Value = "zh-CN")]
        Zhcn,

        /// <summary>
        /// Enum Zhtw for "zh-TW"
        /// </summary>
        [EnumMember(Value = "zh-TW")]
        Zhtw,

        /// <summary>
        /// Enum Zhhk for "zh-HK"
        /// </summary>
        [EnumMember(Value = "zh-HK")]
        Zhhk,

        /// <summary>
        /// Enum Kokr for "ko-KR"
        /// </summary>
        [EnumMember(Value = "ko-KR")]
        Kokr,

        /// <summary>
        /// Enum Plpl for "pl-PL"
        /// </summary>
        [EnumMember(Value = "pl-PL")]
        Plpl,

        /// <summary>
        /// Enum Hiin for "hi-IN"
        /// </summary>
        [EnumMember(Value = "hi-IN")]
        Hiin,

        /// <summary>
        /// Enum Thth for "th-TH"
        /// </summary>
        [EnumMember(Value = "th-TH")]
        Thth,

        /// <summary>
        /// Enum Huhu for "hu-HU"
        /// </summary>
        [EnumMember(Value = "hu-HU")]
        Huhu,

        /// <summary>
        /// Enum Vivn for "vi-VN"
        /// </summary>
        [EnumMember(Value = "vi-VN")]
        Vivn,

        /// <summary>
        /// Enum Ukua for "uk-UA"
        /// </summary>
        [EnumMember(Value = "uk-UA")]
        Ukua
    }
    /// <summary>
    /// The appType
    /// </summary>
    /// <value>The appType</value>
    
    public enum AppTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Assistant for "Assistant"
        /// </summary>
        [EnumMember(Value = "Assistant")]
        Assistant,

        /// <summary>
        /// Enum Botflow for "BotFlow"
        /// </summary>
        [EnumMember(Value = "BotFlow")]
        Botflow,

        /// <summary>
        /// Enum Messengerknowledgeapp for "MessengerKnowledgeApp"
        /// </summary>
        [EnumMember(Value = "MessengerKnowledgeApp")]
        Messengerknowledgeapp,

        /// <summary>
        /// Enum Smartadvisor for "SmartAdvisor"
        /// </summary>
        [EnumMember(Value = "SmartAdvisor")]
        Smartadvisor,

        /// <summary>
        /// Enum Supportcenter for "SupportCenter"
        /// </summary>
        [EnumMember(Value = "SupportCenter")]
        Supportcenter
    }
    /// <summary>
    /// The query type
    /// </summary>
    /// <value>The query type</value>
    
    public enum QueryTypeEnum
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
        /// Enum Article for "Article"
        /// </summary>
        [EnumMember(Value = "Article")]
        Article,

        /// <summary>
        /// Enum Autosearch for "AutoSearch"
        /// </summary>
        [EnumMember(Value = "AutoSearch")]
        Autosearch,

        /// <summary>
        /// Enum Category for "Category"
        /// </summary>
        [EnumMember(Value = "Category")]
        Category,

        /// <summary>
        /// Enum Manualsearch for "ManualSearch"
        /// </summary>
        [EnumMember(Value = "ManualSearch")]
        Manualsearch,

        /// <summary>
        /// Enum Recommendation for "Recommendation"
        /// </summary>
        [EnumMember(Value = "Recommendation")]
        Recommendation,

        /// <summary>
        /// Enum Suggestion for "Suggestion"
        /// </summary>
        [EnumMember(Value = "Suggestion")]
        Suggestion
    }
    /// <summary>
    /// Gets or Sets AnswerMode
    /// </summary>
    
    public enum AnswerModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Answerhighlight for "AnswerHighlight"
        /// </summary>
        [EnumMember(Value = "AnswerHighlight")]
        Answerhighlight,

        /// <summary>
        /// Enum Answergeneration for "AnswerGeneration"
        /// </summary>
        [EnumMember(Value = "AnswerGeneration")]
        Answergeneration
    }
    /// <summary>
    /// The language of the documents.
    /// </summary>
    /// <value>The language of the documents.</value>
    [JsonPropertyName("language")]
    public LanguageEnum? Language { get; set; }
    /// <summary>
    /// The appType
    /// </summary>
    /// <value>The appType</value>
    [JsonPropertyName("appType")]
    public AppTypeEnum? AppType { get; set; }
    /// <summary>
    /// The query type
    /// </summary>
    /// <value>The query type</value>
    [JsonPropertyName("queryType")]
    public QueryTypeEnum? QueryType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentsAnswerFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentsAnswerFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentsAnswerFilter" /> class.
    /// </summary>
    /// <param name="Query">The search query..</param>
    /// <param name="Language">The language of the documents..</param>
    /// <param name="AppType">The appType.</param>
    /// <param name="QueryType">The query type.</param>
    /// <param name="SearchId">The search id..</param>
    /// <param name="InsertHighlightIntoVariationContent">If specified - insert highlight data into the variation content..</param>
    /// <param name="AnswerMode">Allows extracted answers from an article (AnswerHighlight) and/or AI-generated answers (AnswerGeneration). Default mode: AnswerHighlight.</param>
    /// <param name="VariationIds">The variation Ids to answer. (required).</param>
    public KnowledgeDocumentsAnswerFilter(string Query = null, LanguageEnum? Language = null, AppTypeEnum? AppType = null, QueryTypeEnum? QueryType = null, string SearchId = null, bool? InsertHighlightIntoVariationContent = null, List<AnswerModeEnum> AnswerMode = null, List<string> VariationIds = null)
    {
        this.Query = Query;
        this.Language = Language;
        this.AppType = AppType;
        this.QueryType = QueryType;
        this.SearchId = SearchId;
        this.InsertHighlightIntoVariationContent = InsertHighlightIntoVariationContent;
        this.AnswerMode = AnswerMode;
        this.VariationIds = VariationIds;

    }



    /// <summary>
    /// The search query.
    /// </summary>
    /// <value>The search query.</value>
    [JsonPropertyName("query")]
    public string Query { get; set; }









    /// <summary>
    /// The search id.
    /// </summary>
    /// <value>The search id.</value>
    [JsonPropertyName("searchId")]
    public string SearchId { get; set; }



    /// <summary>
    /// If specified - insert highlight data into the variation content.
    /// </summary>
    /// <value>If specified - insert highlight data into the variation content.</value>
    [JsonPropertyName("insertHighlightIntoVariationContent")]
    public bool? InsertHighlightIntoVariationContent { get; set; }



    /// <summary>
    /// Allows extracted answers from an article (AnswerHighlight) and/or AI-generated answers (AnswerGeneration). Default mode: AnswerHighlight
    /// </summary>
    /// <value>Allows extracted answers from an article (AnswerHighlight) and/or AI-generated answers (AnswerGeneration). Default mode: AnswerHighlight</value>
    [JsonPropertyName("answerMode")]
    public List<AnswerModeEnum> AnswerMode { get; set; }



    /// <summary>
    /// The variation Ids to answer.
    /// </summary>
    /// <value>The variation Ids to answer.</value>
    [JsonPropertyName("variationIds")]
    public List<string> VariationIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentsAnswerFilter {\n");

        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  AppType: ").Append(AppType).Append("\n");
        sb.Append("  QueryType: ").Append(QueryType).Append("\n");
        sb.Append("  SearchId: ").Append(SearchId).Append("\n");
        sb.Append("  InsertHighlightIntoVariationContent: ").Append(InsertHighlightIntoVariationContent).Append("\n");
        sb.Append("  AnswerMode: ").Append(AnswerMode).Append("\n");
        sb.Append("  VariationIds: ").Append(VariationIds).Append("\n");
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
        return Equals(obj as KnowledgeDocumentsAnswerFilter);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentsAnswerFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentsAnswerFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentsAnswerFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Query == other.Query ||
                Query != null &&
                Query.Equals(other.Query)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                AppType == other.AppType ||
                AppType != null &&
                AppType.Equals(other.AppType)
            ) &&
            (
                QueryType == other.QueryType ||
                QueryType != null &&
                QueryType.Equals(other.QueryType)
            ) &&
            (
                SearchId == other.SearchId ||
                SearchId != null &&
                SearchId.Equals(other.SearchId)
            ) &&
            (
                InsertHighlightIntoVariationContent == other.InsertHighlightIntoVariationContent ||
                InsertHighlightIntoVariationContent != null &&
                InsertHighlightIntoVariationContent.Equals(other.InsertHighlightIntoVariationContent)
            ) &&
            (
                AnswerMode == other.AnswerMode ||
                AnswerMode != null &&
                AnswerMode.SequenceEqual(other.AnswerMode)
            ) &&
            (
                VariationIds == other.VariationIds ||
                VariationIds != null &&
                VariationIds.SequenceEqual(other.VariationIds)
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
            if (Query != null)
            {
                hash = hash * 59 + Query.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (AppType != null)
            {
                hash = hash * 59 + AppType.GetHashCode();
            }

            if (QueryType != null)
            {
                hash = hash * 59 + QueryType.GetHashCode();
            }

            if (SearchId != null)
            {
                hash = hash * 59 + SearchId.GetHashCode();
            }

            if (InsertHighlightIntoVariationContent != null)
            {
                hash = hash * 59 + InsertHighlightIntoVariationContent.GetHashCode();
            }

            if (AnswerMode != null)
            {
                hash = hash * 59 + AnswerMode.GetHashCode();
            }

            if (VariationIds != null)
            {
                hash = hash * 59 + VariationIds.GetHashCode();
            }

            return hash;
        }
    }
}
