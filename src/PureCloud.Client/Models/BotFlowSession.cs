using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BotFlowSession
/// </summary>

public partial class BotFlowSession : IEquatable<BotFlowSession>
{
    /// <summary>
    /// The reason for session termination.
    /// </summary>
    /// <value>The reason for session termination.</value>
    
    public enum BotResultEnum
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
        /// Enum Exitrequestedbyuser for "ExitRequestedByUser"
        /// </summary>
        [EnumMember(Value = "ExitRequestedByUser")]
        Exitrequestedbyuser,

        /// <summary>
        /// Enum Exitrequestedbybot for "ExitRequestedByBot"
        /// </summary>
        [EnumMember(Value = "ExitRequestedByBot")]
        Exitrequestedbybot,

        /// <summary>
        /// Enum Exiterror for "ExitError"
        /// </summary>
        [EnumMember(Value = "ExitError")]
        Exiterror,

        /// <summary>
        /// Enum Exitrecognitionfailure for "ExitRecognitionFailure"
        /// </summary>
        [EnumMember(Value = "ExitRecognitionFailure")]
        Exitrecognitionfailure,

        /// <summary>
        /// Enum Disconnectrequestedbyuser for "DisconnectRequestedByUser"
        /// </summary>
        [EnumMember(Value = "DisconnectRequestedByUser")]
        Disconnectrequestedbyuser,

        /// <summary>
        /// Enum Disconnectrequestedbybot for "DisconnectRequestedByBot"
        /// </summary>
        [EnumMember(Value = "DisconnectRequestedByBot")]
        Disconnectrequestedbybot,

        /// <summary>
        /// Enum Disconnectsessionexpired for "DisconnectSessionExpired"
        /// </summary>
        [EnumMember(Value = "DisconnectSessionExpired")]
        Disconnectsessionexpired,

        /// <summary>
        /// Enum Disconnecterror for "DisconnectError"
        /// </summary>
        [EnumMember(Value = "DisconnectError")]
        Disconnecterror,

        /// <summary>
        /// Enum Disconnectrecognitionfailure for "DisconnectRecognitionFailure"
        /// </summary>
        [EnumMember(Value = "DisconnectRecognitionFailure")]
        Disconnectrecognitionfailure,

        /// <summary>
        /// Enum Transfertoacd for "TransferToACD"
        /// </summary>
        [EnumMember(Value = "TransferToACD")]
        Transfertoacd
    }
    /// <summary>
    /// The category of result for the session.
    /// </summary>
    /// <value>The category of result for the session.</value>
    
    public enum BotResultCategoryEnum
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
        /// Enum Userexit for "UserExit"
        /// </summary>
        [EnumMember(Value = "UserExit")]
        Userexit,

        /// <summary>
        /// Enum Botexit for "BotExit"
        /// </summary>
        [EnumMember(Value = "BotExit")]
        Botexit,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Recognitionfailure for "RecognitionFailure"
        /// </summary>
        [EnumMember(Value = "RecognitionFailure")]
        Recognitionfailure,

        /// <summary>
        /// Enum Userdisconnect for "UserDisconnect"
        /// </summary>
        [EnumMember(Value = "UserDisconnect")]
        Userdisconnect,

        /// <summary>
        /// Enum Botdisconnect for "BotDisconnect"
        /// </summary>
        [EnumMember(Value = "BotDisconnect")]
        Botdisconnect,

        /// <summary>
        /// Enum Sessionexpired for "SessionExpired"
        /// </summary>
        [EnumMember(Value = "SessionExpired")]
        Sessionexpired,

        /// <summary>
        /// Enum Transfer for "Transfer"
        /// </summary>
        [EnumMember(Value = "Transfer")]
        Transfer
    }
    /// <summary>
    /// The reason for session termination.
    /// </summary>
    /// <value>The reason for session termination.</value>
    [JsonPropertyName("botResult")]
    public BotResultEnum? BotResult { get; set; }
    /// <summary>
    /// The category of result for the session.
    /// </summary>
    /// <value>The category of result for the session.</value>
    [JsonPropertyName("botResultCategory")]
    public BotResultCategoryEnum? BotResultCategory { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BotFlowSession" /> class.
    /// </summary>
    /// <param name="Id">The ID of the bot session..</param>
    /// <param name="Flow">The flow associated to this bot session..</param>
    /// <param name="Channel">Channel-specific information that describes the message channel/provider..</param>
    /// <param name="Language">The initial language of operation for the session..</param>
    /// <param name="EndLanguage">The language of the session at the time the session ended.</param>
    /// <param name="BotResult">The reason for session termination..</param>
    /// <param name="BotResultCategory">The category of result for the session..</param>
    /// <param name="DateCreated">Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateCompleted">Timestamp indicating when the session was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public BotFlowSession(string Id = null, Entity Flow = null, BotChannel Channel = null, string Language = null, string EndLanguage = null, BotResultEnum? BotResult = null, BotResultCategoryEnum? BotResultCategory = null, DateTime? DateCreated = null, DateTime? DateCompleted = null)
    {
        this.Id = Id;
        this.Flow = Flow;
        this.Channel = Channel;
        this.Language = Language;
        this.EndLanguage = EndLanguage;
        this.BotResult = BotResult;
        this.BotResultCategory = BotResultCategory;
        this.DateCreated = DateCreated;
        this.DateCompleted = DateCompleted;

    }



    /// <summary>
    /// The ID of the bot session.
    /// </summary>
    /// <value>The ID of the bot session.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The flow associated to this bot session.
    /// </summary>
    /// <value>The flow associated to this bot session.</value>
    [JsonPropertyName("flow")]
    public Entity Flow { get; set; }



    /// <summary>
    /// Channel-specific information that describes the message channel/provider.
    /// </summary>
    /// <value>Channel-specific information that describes the message channel/provider.</value>
    [JsonPropertyName("channel")]
    public BotChannel Channel { get; set; }



    /// <summary>
    /// The initial language of operation for the session.
    /// </summary>
    /// <value>The initial language of operation for the session.</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// The language of the session at the time the session ended
    /// </summary>
    /// <value>The language of the session at the time the session ended</value>
    [JsonPropertyName("endLanguage")]
    public string EndLanguage { get; set; }







    /// <summary>
    /// Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Timestamp indicating when the session was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the session was completed. Note: The &#39;interval&#39; query param uses this timestamp to filter the output. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCompleted")]
    public DateTime? DateCompleted { get; set; }



    /// <summary>
    /// The conversation details, across potentially multiple Bot Flow sessions.
    /// </summary>
    /// <value>The conversation details, across potentially multiple Bot Flow sessions.</value>
    [JsonPropertyName("conversation")]
    public AddressableEntityRef Conversation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BotFlowSession {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  Channel: ").Append(Channel).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  EndLanguage: ").Append(EndLanguage).Append("\n");
        sb.Append("  BotResult: ").Append(BotResult).Append("\n");
        sb.Append("  BotResultCategory: ").Append(BotResultCategory).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
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
        return Equals(obj as BotFlowSession);
    }

    /// <summary>
    /// Returns true if BotFlowSession instances are equal
    /// </summary>
    /// <param name="other">Instance of BotFlowSession to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BotFlowSession other)
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
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                Channel == other.Channel ||
                Channel != null &&
                Channel.Equals(other.Channel)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                EndLanguage == other.EndLanguage ||
                EndLanguage != null &&
                EndLanguage.Equals(other.EndLanguage)
            ) &&
            (
                BotResult == other.BotResult ||
                BotResult != null &&
                BotResult.Equals(other.BotResult)
            ) &&
            (
                BotResultCategory == other.BotResultCategory ||
                BotResultCategory != null &&
                BotResultCategory.Equals(other.BotResultCategory)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateCompleted == other.DateCompleted ||
                DateCompleted != null &&
                DateCompleted.Equals(other.DateCompleted)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
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

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (Channel != null)
            {
                hash = hash * 59 + Channel.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (EndLanguage != null)
            {
                hash = hash * 59 + EndLanguage.GetHashCode();
            }

            if (BotResult != null)
            {
                hash = hash * 59 + BotResult.GetHashCode();
            }

            if (BotResultCategory != null)
            {
                hash = hash * 59 + BotResultCategory.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateCompleted != null)
            {
                hash = hash * 59 + DateCompleted.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            return hash;
        }
    }
}
