using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Miner
/// </summary>

public partial class Miner : IEquatable<Miner>
{
    /// <summary>
    /// Language Localization code.
    /// </summary>
    /// <value>Language Localization code.</value>
    
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
        /// Enum Enus for "en-us"
        /// </summary>
        [EnumMember(Value = "en-us")]
        Enus,

        /// <summary>
        /// Enum Engb for "en-gb"
        /// </summary>
        [EnumMember(Value = "en-gb")]
        Engb,

        /// <summary>
        /// Enum Enau for "en-au"
        /// </summary>
        [EnumMember(Value = "en-au")]
        Enau,

        /// <summary>
        /// Enum Enin for "en-in"
        /// </summary>
        [EnumMember(Value = "en-in")]
        Enin,

        /// <summary>
        /// Enum Enza for "en-za"
        /// </summary>
        [EnumMember(Value = "en-za")]
        Enza,

        /// <summary>
        /// Enum Esus for "es-us"
        /// </summary>
        [EnumMember(Value = "es-us")]
        Esus,

        /// <summary>
        /// Enum Eses for "es-es"
        /// </summary>
        [EnumMember(Value = "es-es")]
        Eses,

        /// <summary>
        /// Enum Frfr for "fr-fr"
        /// </summary>
        [EnumMember(Value = "fr-fr")]
        Frfr,

        /// <summary>
        /// Enum Frca for "fr-ca"
        /// </summary>
        [EnumMember(Value = "fr-ca")]
        Frca,

        /// <summary>
        /// Enum Dede for "de-de"
        /// </summary>
        [EnumMember(Value = "de-de")]
        Dede,

        /// <summary>
        /// Enum Ptpt for "pt-pt"
        /// </summary>
        [EnumMember(Value = "pt-pt")]
        Ptpt,

        /// <summary>
        /// Enum Ptbr for "pt-br"
        /// </summary>
        [EnumMember(Value = "pt-br")]
        Ptbr,

        /// <summary>
        /// Enum Itit for "it-it"
        /// </summary>
        [EnumMember(Value = "it-it")]
        Itit,

        /// <summary>
        /// Enum Nlnl for "nl-nl"
        /// </summary>
        [EnumMember(Value = "nl-nl")]
        Nlnl,

        /// <summary>
        /// Enum Dech for "de-ch"
        /// </summary>
        [EnumMember(Value = "de-ch")]
        Dech
    }
    /// <summary>
    /// Type of the miner, intent or topic.
    /// </summary>
    /// <value>Type of the miner, intent or topic.</value>
    
    public enum MinerTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Intent for "Intent"
        /// </summary>
        [EnumMember(Value = "Intent")]
        Intent,

        /// <summary>
        /// Enum Topic for "Topic"
        /// </summary>
        [EnumMember(Value = "Topic")]
        Topic
    }
    /// <summary>
    /// Status of the miner.
    /// </summary>
    /// <value>Status of the miner.</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Notstarted for "NotStarted"
        /// </summary>
        [EnumMember(Value = "NotStarted")]
        Notstarted,

        /// <summary>
        /// Enum Fetchingconversationids for "FetchingConversationIds"
        /// </summary>
        [EnumMember(Value = "FetchingConversationIds")]
        Fetchingconversationids,

        /// <summary>
        /// Enum Conversationidsfetched for "ConversationIdsFetched"
        /// </summary>
        [EnumMember(Value = "ConversationIdsFetched")]
        Conversationidsfetched,

        /// <summary>
        /// Enum Conversationidsfetcherror for "ConversationIdsFetchError"
        /// </summary>
        [EnumMember(Value = "ConversationIdsFetchError")]
        Conversationidsfetcherror,

        /// <summary>
        /// Enum Fetchingconversations for "FetchingConversations"
        /// </summary>
        [EnumMember(Value = "FetchingConversations")]
        Fetchingconversations,

        /// <summary>
        /// Enum Conversationsfetched for "ConversationsFetched"
        /// </summary>
        [EnumMember(Value = "ConversationsFetched")]
        Conversationsfetched,

        /// <summary>
        /// Enum Conversationsfetcherror for "ConversationsFetchError"
        /// </summary>
        [EnumMember(Value = "ConversationsFetchError")]
        Conversationsfetcherror,

        /// <summary>
        /// Enum Queued for "Queued"
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued,

        /// <summary>
        /// Enum Queuingerror for "QueuingError"
        /// </summary>
        [EnumMember(Value = "QueuingError")]
        Queuingerror,

        /// <summary>
        /// Enum Miningstarted for "MiningStarted"
        /// </summary>
        [EnumMember(Value = "MiningStarted")]
        Miningstarted,

        /// <summary>
        /// Enum Maskingutterances for "MaskingUtterances"
        /// </summary>
        [EnumMember(Value = "MaskingUtterances")]
        Maskingutterances,

        /// <summary>
        /// Enum Maskingerror for "MaskingError"
        /// </summary>
        [EnumMember(Value = "MaskingError")]
        Maskingerror,

        /// <summary>
        /// Enum Computinganalytics for "ComputingAnalytics"
        /// </summary>
        [EnumMember(Value = "ComputingAnalytics")]
        Computinganalytics,

        /// <summary>
        /// Enum Computinganalyticserror for "ComputingAnalyticsError"
        /// </summary>
        [EnumMember(Value = "ComputingAnalyticsError")]
        Computinganalyticserror,

        /// <summary>
        /// Enum Miningcompleted for "MiningCompleted"
        /// </summary>
        [EnumMember(Value = "MiningCompleted")]
        Miningcompleted,

        /// <summary>
        /// Enum Miningerror for "MiningError"
        /// </summary>
        [EnumMember(Value = "MiningError")]
        Miningerror,

        /// <summary>
        /// Enum Modelvalidationerror for "ModelValidationError"
        /// </summary>
        [EnumMember(Value = "ModelValidationError")]
        Modelvalidationerror,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    /// <summary>
    /// Media type for filtering conversations.
    /// </summary>
    /// <value>Media type for filtering conversations.</value>
    
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
        /// Enum Chat for "Chat"
        /// </summary>
        [EnumMember(Value = "Chat")]
        Chat,

        /// <summary>
        /// Enum Call for "Call"
        /// </summary>
        [EnumMember(Value = "Call")]
        Call,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email
    }
    /// <summary>
    /// Type of the participant, either agent, customer or both.
    /// </summary>
    /// <value>Type of the participant, either agent, customer or both.</value>
    
    public enum ParticipantTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Customer for "Customer"
        /// </summary>
        [EnumMember(Value = "Customer")]
        Customer,

        /// <summary>
        /// Enum Agent for "Agent"
        /// </summary>
        [EnumMember(Value = "Agent")]
        Agent,

        /// <summary>
        /// Enum Both for "Both"
        /// </summary>
        [EnumMember(Value = "Both")]
        Both
    }
    /// <summary>
    /// Language Localization code.
    /// </summary>
    /// <value>Language Localization code.</value>
    [JsonPropertyName("language")]
    public LanguageEnum? Language { get; set; }
    /// <summary>
    /// Type of the miner, intent or topic.
    /// </summary>
    /// <value>Type of the miner, intent or topic.</value>
    [JsonPropertyName("minerType")]
    public MinerTypeEnum? MinerType { get; set; }
    /// <summary>
    /// Status of the miner.
    /// </summary>
    /// <value>Status of the miner.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Media type for filtering conversations.
    /// </summary>
    /// <value>Media type for filtering conversations.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Type of the participant, either agent, customer or both.
    /// </summary>
    /// <value>Type of the participant, either agent, customer or both.</value>
    [JsonPropertyName("participantType")]
    public ParticipantTypeEnum? ParticipantType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Miner" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Miner() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Miner" /> class.
    /// </summary>
    /// <param name="Name">Chat Corpus Name. (required).</param>
    /// <param name="Language">Language Localization code..</param>
    /// <param name="MinerType">Type of the miner, intent or topic..</param>
    public Miner(string Name = null, LanguageEnum? Language = null, MinerTypeEnum? MinerType = null)
    {
        this.Name = Name;
        this.Language = Language;
        this.MinerType = MinerType;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Chat Corpus Name.
    /// </summary>
    /// <value>Chat Corpus Name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }







    /// <summary>
    /// Date when the miner was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the miner was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }





    /// <summary>
    /// Date from which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Date from which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("conversationsDateRangeStart")]
    public string ConversationsDateRangeStart { get; set; }



    /// <summary>
    /// Date till which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Date till which the conversations need to be taken for mining. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("conversationsDateRangeEnd")]
    public string ConversationsDateRangeEnd { get; set; }



    /// <summary>
    /// Date when the mining process was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the mining process was completed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCompleted")]
    public DateTime? DateCompleted { get; set; }



    /// <summary>
    /// Mining message if present.
    /// </summary>
    /// <value>Mining message if present.</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// Error Information
    /// </summary>
    /// <value>Error Information</value>
    [JsonPropertyName("errorInfo")]
    public MinerErrorInfo ErrorInfo { get; set; }



    /// <summary>
    /// Warning Information
    /// </summary>
    /// <value>Warning Information</value>
    [JsonPropertyName("warningInfo")]
    public MinerErrorInfo WarningInfo { get; set; }



    /// <summary>
    /// Flag to indicate whether data file to be mined was uploaded.
    /// </summary>
    /// <value>Flag to indicate whether data file to be mined was uploaded.</value>
    [JsonPropertyName("conversationDataUploaded")]
    public bool? ConversationDataUploaded { get; set; }







    /// <summary>
    /// List of queue IDs for filtering conversations.
    /// </summary>
    /// <value>List of queue IDs for filtering conversations.</value>
    [JsonPropertyName("queueIds")]
    public List<string> QueueIds { get; set; }



    /// <summary>
    /// Date when the miner started execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the miner started execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateTriggered")]
    public DateTime? DateTriggered { get; set; }



    /// <summary>
    /// Date when the miner was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the miner was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Latest draft details of the miner.
    /// </summary>
    /// <value>Latest draft details of the miner.</value>
    [JsonPropertyName("latestDraftVersion")]
    public Draft LatestDraftVersion { get; set; }



    /// <summary>
    /// Number of conversations/transcripts fetched.
    /// </summary>
    /// <value>Number of conversations/transcripts fetched.</value>
    [JsonPropertyName("conversationsFetchedCount")]
    public int? ConversationsFetchedCount { get; set; }



    /// <summary>
    /// Number of conversations/recordings/transcripts that were found valid for mining purposes.
    /// </summary>
    /// <value>Number of conversations/recordings/transcripts that were found valid for mining purposes.</value>
    [JsonPropertyName("conversationsValidCount")]
    public int? ConversationsValidCount { get; set; }



    /// <summary>
    /// Number of intents or topics based on the miner type.
    /// </summary>
    /// <value>Number of intents or topics based on the miner type.</value>
    [JsonPropertyName("getminedItemCount")]
    public int? GetminedItemCount { get; set; }



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
        sb.Append("class Miner {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  MinerType: ").Append(MinerType).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ConversationsDateRangeStart: ").Append(ConversationsDateRangeStart).Append("\n");
        sb.Append("  ConversationsDateRangeEnd: ").Append(ConversationsDateRangeEnd).Append("\n");
        sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  WarningInfo: ").Append(WarningInfo).Append("\n");
        sb.Append("  ConversationDataUploaded: ").Append(ConversationDataUploaded).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ParticipantType: ").Append(ParticipantType).Append("\n");
        sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
        sb.Append("  DateTriggered: ").Append(DateTriggered).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  LatestDraftVersion: ").Append(LatestDraftVersion).Append("\n");
        sb.Append("  ConversationsFetchedCount: ").Append(ConversationsFetchedCount).Append("\n");
        sb.Append("  ConversationsValidCount: ").Append(ConversationsValidCount).Append("\n");
        sb.Append("  GetminedItemCount: ").Append(GetminedItemCount).Append("\n");
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
        return Equals(obj as Miner);
    }

    /// <summary>
    /// Returns true if Miner instances are equal
    /// </summary>
    /// <param name="other">Instance of Miner to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Miner other)
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
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                MinerType == other.MinerType ||
                MinerType != null &&
                MinerType.Equals(other.MinerType)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                ConversationsDateRangeStart == other.ConversationsDateRangeStart ||
                ConversationsDateRangeStart != null &&
                ConversationsDateRangeStart.Equals(other.ConversationsDateRangeStart)
            ) &&
            (
                ConversationsDateRangeEnd == other.ConversationsDateRangeEnd ||
                ConversationsDateRangeEnd != null &&
                ConversationsDateRangeEnd.Equals(other.ConversationsDateRangeEnd)
            ) &&
            (
                DateCompleted == other.DateCompleted ||
                DateCompleted != null &&
                DateCompleted.Equals(other.DateCompleted)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
            ) &&
            (
                WarningInfo == other.WarningInfo ||
                WarningInfo != null &&
                WarningInfo.Equals(other.WarningInfo)
            ) &&
            (
                ConversationDataUploaded == other.ConversationDataUploaded ||
                ConversationDataUploaded != null &&
                ConversationDataUploaded.Equals(other.ConversationDataUploaded)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                ParticipantType == other.ParticipantType ||
                ParticipantType != null &&
                ParticipantType.Equals(other.ParticipantType)
            ) &&
            (
                QueueIds == other.QueueIds ||
                QueueIds != null &&
                QueueIds.SequenceEqual(other.QueueIds)
            ) &&
            (
                DateTriggered == other.DateTriggered ||
                DateTriggered != null &&
                DateTriggered.Equals(other.DateTriggered)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                LatestDraftVersion == other.LatestDraftVersion ||
                LatestDraftVersion != null &&
                LatestDraftVersion.Equals(other.LatestDraftVersion)
            ) &&
            (
                ConversationsFetchedCount == other.ConversationsFetchedCount ||
                ConversationsFetchedCount != null &&
                ConversationsFetchedCount.Equals(other.ConversationsFetchedCount)
            ) &&
            (
                ConversationsValidCount == other.ConversationsValidCount ||
                ConversationsValidCount != null &&
                ConversationsValidCount.Equals(other.ConversationsValidCount)
            ) &&
            (
                GetminedItemCount == other.GetminedItemCount ||
                GetminedItemCount != null &&
                GetminedItemCount.Equals(other.GetminedItemCount)
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

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (MinerType != null)
            {
                hash = hash * 59 + MinerType.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ConversationsDateRangeStart != null)
            {
                hash = hash * 59 + ConversationsDateRangeStart.GetHashCode();
            }

            if (ConversationsDateRangeEnd != null)
            {
                hash = hash * 59 + ConversationsDateRangeEnd.GetHashCode();
            }

            if (DateCompleted != null)
            {
                hash = hash * 59 + DateCompleted.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            if (WarningInfo != null)
            {
                hash = hash * 59 + WarningInfo.GetHashCode();
            }

            if (ConversationDataUploaded != null)
            {
                hash = hash * 59 + ConversationDataUploaded.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (ParticipantType != null)
            {
                hash = hash * 59 + ParticipantType.GetHashCode();
            }

            if (QueueIds != null)
            {
                hash = hash * 59 + QueueIds.GetHashCode();
            }

            if (DateTriggered != null)
            {
                hash = hash * 59 + DateTriggered.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (LatestDraftVersion != null)
            {
                hash = hash * 59 + LatestDraftVersion.GetHashCode();
            }

            if (ConversationsFetchedCount != null)
            {
                hash = hash * 59 + ConversationsFetchedCount.GetHashCode();
            }

            if (ConversationsValidCount != null)
            {
                hash = hash * 59 + ConversationsValidCount.GetHashCode();
            }

            if (GetminedItemCount != null)
            {
                hash = hash * 59 + GetminedItemCount.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
