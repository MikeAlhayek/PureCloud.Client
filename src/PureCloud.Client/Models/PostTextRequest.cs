using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PostTextRequest
/// </summary>

public partial class PostTextRequest : IEquatable<PostTextRequest>
{
    /// <summary>
    /// Gets or Sets BotChannels
    /// </summary>
    
    public enum BotChannelsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Call for "Call"
        /// </summary>
        [EnumMember(Value = "Call")]
        Call,

        /// <summary>
        /// Enum Callback for "Callback"
        /// </summary>
        [EnumMember(Value = "Callback")]
        Callback,

        /// <summary>
        /// Enum Messaging for "Messaging"
        /// </summary>
        [EnumMember(Value = "Messaging")]
        Messaging,

        /// <summary>
        /// Enum Webchat for "Webchat"
        /// </summary>
        [EnumMember(Value = "Webchat")]
        Webchat
    }
    /// <summary>
    /// If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics
    /// </summary>
    /// <value>If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics</value>
    
    public enum MessagingPlatformTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Phone for "Phone"
        /// </summary>
        [EnumMember(Value = "Phone")]
        Phone,

        /// <summary>
        /// Enum Sms for "SMS"
        /// </summary>
        [EnumMember(Value = "SMS")]
        Sms,

        /// <summary>
        /// Enum Genesyswebwidget for "GenesysWebWidget"
        /// </summary>
        [EnumMember(Value = "GenesysWebWidget")]
        Genesyswebwidget,

        /// <summary>
        /// Enum Facebookmessenger for "FacebookMessenger"
        /// </summary>
        [EnumMember(Value = "FacebookMessenger")]
        Facebookmessenger,

        /// <summary>
        /// Enum Wechat for "WeChat"
        /// </summary>
        [EnumMember(Value = "WeChat")]
        Wechat,

        /// <summary>
        /// Enum Whatsapp for "Whatsapp"
        /// </summary>
        [EnumMember(Value = "Whatsapp")]
        Whatsapp,

        /// <summary>
        /// Enum Applebusinesschat for "AppleBusinessChat"
        /// </summary>
        [EnumMember(Value = "AppleBusinessChat")]
        Applebusinesschat,

        /// <summary>
        /// Enum Apple for "Apple"
        /// </summary>
        [EnumMember(Value = "Apple")]
        Apple,

        /// <summary>
        /// Enum Telegram for "Telegram"
        /// </summary>
        [EnumMember(Value = "Telegram")]
        Telegram,

        /// <summary>
        /// Enum Slack for "Slack"
        /// </summary>
        [EnumMember(Value = "Slack")]
        Slack,

        /// <summary>
        /// Enum Signal for "Signal"
        /// </summary>
        [EnumMember(Value = "Signal")]
        Signal,

        /// <summary>
        /// Enum Line for "Line"
        /// </summary>
        [EnumMember(Value = "Line")]
        Line,

        /// <summary>
        /// Enum Discord for "Discord"
        /// </summary>
        [EnumMember(Value = "Discord")]
        Discord,

        /// <summary>
        /// Enum Twitterdirectmessage for "TwitterDirectMessage"
        /// </summary>
        [EnumMember(Value = "TwitterDirectMessage")]
        Twitterdirectmessage,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Instagram for "Instagram"
        /// </summary>
        [EnumMember(Value = "Instagram")]
        Instagram,

        /// <summary>
        /// Enum Other for "Other"
        /// </summary>
        [EnumMember(Value = "Other")]
        Other,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics
    /// </summary>
    /// <value>If the channels list contains a 'Messaging' item and the messaging platform is known, include it here to get accurate analytics</value>
    [JsonPropertyName("messagingPlatformType")]
    public MessagingPlatformTypeEnum? MessagingPlatformType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PostTextRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PostTextRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PostTextRequest" /> class.
    /// </summary>
    /// <param name="BotId">ID of the bot to send the text to. (required).</param>
    /// <param name="BotAlias">Alias/Version of the bot.</param>
    /// <param name="IntegrationId">the integration service id for the bot&#39;s credentials (required).</param>
    /// <param name="BotSessionId">GUID for this bot&#39;s session (required).</param>
    /// <param name="PostTextMessage">Message to send to the bot (required).</param>
    /// <param name="LanguageCode">The launguage code the bot will run under.</param>
    /// <param name="BotSessionTimeoutMinutes">Override timeout for the bot session. This should be greater than 10 minutes..</param>
    /// <param name="BotChannels">The channels this bot is utilizing.</param>
    /// <param name="BotCorrelationId">Id for tracking the activity - this will be returned in the response.</param>
    /// <param name="MessagingPlatformType">If the channels list contains a &#39;Messaging&#39; item and the messaging platform is known, include it here to get accurate analytics.</param>
    /// <param name="AmazonLexRequest">Provider specific settings, if any.</param>
    /// <param name="GoogleDialogflow">Provider specific settings, if any.</param>
    /// <param name="GenesysBotConnector">Provider specific settings, if any.</param>
    /// <param name="NuanceMixDlg">Provider specific settings, if any.</param>
    public PostTextRequest(string BotId = null, string BotAlias = null, string IntegrationId = null, string BotSessionId = null, PostTextMessage PostTextMessage = null, string LanguageCode = null, int? BotSessionTimeoutMinutes = null, List<BotChannelsEnum> BotChannels = null, string BotCorrelationId = null, MessagingPlatformTypeEnum? MessagingPlatformType = null, AmazonLexRequest AmazonLexRequest = null, GoogleDialogflowCustomSettings GoogleDialogflow = null, GenesysBotConnector GenesysBotConnector = null, NuanceMixDlgSettings NuanceMixDlg = null)
    {
        this.BotId = BotId;
        this.BotAlias = BotAlias;
        this.IntegrationId = IntegrationId;
        this.BotSessionId = BotSessionId;
        this.PostTextMessage = PostTextMessage;
        this.LanguageCode = LanguageCode;
        this.BotSessionTimeoutMinutes = BotSessionTimeoutMinutes;
        this.BotChannels = BotChannels;
        this.BotCorrelationId = BotCorrelationId;
        this.MessagingPlatformType = MessagingPlatformType;
        this.AmazonLexRequest = AmazonLexRequest;
        this.GoogleDialogflow = GoogleDialogflow;
        this.GenesysBotConnector = GenesysBotConnector;
        this.NuanceMixDlg = NuanceMixDlg;

    }



    /// <summary>
    /// ID of the bot to send the text to.
    /// </summary>
    /// <value>ID of the bot to send the text to.</value>
    [JsonPropertyName("botId")]
    public string BotId { get; set; }



    /// <summary>
    /// Alias/Version of the bot
    /// </summary>
    /// <value>Alias/Version of the bot</value>
    [JsonPropertyName("botAlias")]
    public string BotAlias { get; set; }



    /// <summary>
    /// the integration service id for the bot&#39;s credentials
    /// </summary>
    /// <value>the integration service id for the bot&#39;s credentials</value>
    [JsonPropertyName("integrationId")]
    public string IntegrationId { get; set; }



    /// <summary>
    /// GUID for this bot&#39;s session
    /// </summary>
    /// <value>GUID for this bot&#39;s session</value>
    [JsonPropertyName("botSessionId")]
    public string BotSessionId { get; set; }



    /// <summary>
    /// Message to send to the bot
    /// </summary>
    /// <value>Message to send to the bot</value>
    [JsonPropertyName("postTextMessage")]
    public PostTextMessage PostTextMessage { get; set; }



    /// <summary>
    /// The launguage code the bot will run under
    /// </summary>
    /// <value>The launguage code the bot will run under</value>
    [JsonPropertyName("languageCode")]
    public string LanguageCode { get; set; }



    /// <summary>
    /// Override timeout for the bot session. This should be greater than 10 minutes.
    /// </summary>
    /// <value>Override timeout for the bot session. This should be greater than 10 minutes.</value>
    [JsonPropertyName("botSessionTimeoutMinutes")]
    public int? BotSessionTimeoutMinutes { get; set; }



    /// <summary>
    /// The channels this bot is utilizing
    /// </summary>
    /// <value>The channels this bot is utilizing</value>
    [JsonPropertyName("botChannels")]
    public List<BotChannelsEnum> BotChannels { get; set; }



    /// <summary>
    /// Id for tracking the activity - this will be returned in the response
    /// </summary>
    /// <value>Id for tracking the activity - this will be returned in the response</value>
    [JsonPropertyName("botCorrelationId")]
    public string BotCorrelationId { get; set; }





    /// <summary>
    /// Provider specific settings, if any
    /// </summary>
    /// <value>Provider specific settings, if any</value>
    [JsonPropertyName("amazonLexRequest")]
    public AmazonLexRequest AmazonLexRequest { get; set; }



    /// <summary>
    /// Provider specific settings, if any
    /// </summary>
    /// <value>Provider specific settings, if any</value>
    [JsonPropertyName("googleDialogflow")]
    public GoogleDialogflowCustomSettings GoogleDialogflow { get; set; }



    /// <summary>
    /// Provider specific settings, if any
    /// </summary>
    /// <value>Provider specific settings, if any</value>
    [JsonPropertyName("genesysBotConnector")]
    public GenesysBotConnector GenesysBotConnector { get; set; }



    /// <summary>
    /// Provider specific settings, if any
    /// </summary>
    /// <value>Provider specific settings, if any</value>
    [JsonPropertyName("nuanceMixDlg")]
    public NuanceMixDlgSettings NuanceMixDlg { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PostTextRequest {\n");

        sb.Append("  BotId: ").Append(BotId).Append("\n");
        sb.Append("  BotAlias: ").Append(BotAlias).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  BotSessionId: ").Append(BotSessionId).Append("\n");
        sb.Append("  PostTextMessage: ").Append(PostTextMessage).Append("\n");
        sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
        sb.Append("  BotSessionTimeoutMinutes: ").Append(BotSessionTimeoutMinutes).Append("\n");
        sb.Append("  BotChannels: ").Append(BotChannels).Append("\n");
        sb.Append("  BotCorrelationId: ").Append(BotCorrelationId).Append("\n");
        sb.Append("  MessagingPlatformType: ").Append(MessagingPlatformType).Append("\n");
        sb.Append("  AmazonLexRequest: ").Append(AmazonLexRequest).Append("\n");
        sb.Append("  GoogleDialogflow: ").Append(GoogleDialogflow).Append("\n");
        sb.Append("  GenesysBotConnector: ").Append(GenesysBotConnector).Append("\n");
        sb.Append("  NuanceMixDlg: ").Append(NuanceMixDlg).Append("\n");
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
        return Equals(obj as PostTextRequest);
    }

    /// <summary>
    /// Returns true if PostTextRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of PostTextRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PostTextRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BotId == other.BotId ||
                BotId != null &&
                BotId.Equals(other.BotId)
            ) &&
            (
                BotAlias == other.BotAlias ||
                BotAlias != null &&
                BotAlias.Equals(other.BotAlias)
            ) &&
            (
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
            ) &&
            (
                BotSessionId == other.BotSessionId ||
                BotSessionId != null &&
                BotSessionId.Equals(other.BotSessionId)
            ) &&
            (
                PostTextMessage == other.PostTextMessage ||
                PostTextMessage != null &&
                PostTextMessage.Equals(other.PostTextMessage)
            ) &&
            (
                LanguageCode == other.LanguageCode ||
                LanguageCode != null &&
                LanguageCode.Equals(other.LanguageCode)
            ) &&
            (
                BotSessionTimeoutMinutes == other.BotSessionTimeoutMinutes ||
                BotSessionTimeoutMinutes != null &&
                BotSessionTimeoutMinutes.Equals(other.BotSessionTimeoutMinutes)
            ) &&
            (
                BotChannels == other.BotChannels ||
                BotChannels != null &&
                BotChannels.SequenceEqual(other.BotChannels)
            ) &&
            (
                BotCorrelationId == other.BotCorrelationId ||
                BotCorrelationId != null &&
                BotCorrelationId.Equals(other.BotCorrelationId)
            ) &&
            (
                MessagingPlatformType == other.MessagingPlatformType ||
                MessagingPlatformType != null &&
                MessagingPlatformType.Equals(other.MessagingPlatformType)
            ) &&
            (
                AmazonLexRequest == other.AmazonLexRequest ||
                AmazonLexRequest != null &&
                AmazonLexRequest.Equals(other.AmazonLexRequest)
            ) &&
            (
                GoogleDialogflow == other.GoogleDialogflow ||
                GoogleDialogflow != null &&
                GoogleDialogflow.Equals(other.GoogleDialogflow)
            ) &&
            (
                GenesysBotConnector == other.GenesysBotConnector ||
                GenesysBotConnector != null &&
                GenesysBotConnector.Equals(other.GenesysBotConnector)
            ) &&
            (
                NuanceMixDlg == other.NuanceMixDlg ||
                NuanceMixDlg != null &&
                NuanceMixDlg.Equals(other.NuanceMixDlg)
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
            if (BotId != null)
            {
                hash = hash * 59 + BotId.GetHashCode();
            }

            if (BotAlias != null)
            {
                hash = hash * 59 + BotAlias.GetHashCode();
            }

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            if (BotSessionId != null)
            {
                hash = hash * 59 + BotSessionId.GetHashCode();
            }

            if (PostTextMessage != null)
            {
                hash = hash * 59 + PostTextMessage.GetHashCode();
            }

            if (LanguageCode != null)
            {
                hash = hash * 59 + LanguageCode.GetHashCode();
            }

            if (BotSessionTimeoutMinutes != null)
            {
                hash = hash * 59 + BotSessionTimeoutMinutes.GetHashCode();
            }

            if (BotChannels != null)
            {
                hash = hash * 59 + BotChannels.GetHashCode();
            }

            if (BotCorrelationId != null)
            {
                hash = hash * 59 + BotCorrelationId.GetHashCode();
            }

            if (MessagingPlatformType != null)
            {
                hash = hash * 59 + MessagingPlatformType.GetHashCode();
            }

            if (AmazonLexRequest != null)
            {
                hash = hash * 59 + AmazonLexRequest.GetHashCode();
            }

            if (GoogleDialogflow != null)
            {
                hash = hash * 59 + GoogleDialogflow.GetHashCode();
            }

            if (GenesysBotConnector != null)
            {
                hash = hash * 59 + GenesysBotConnector.GetHashCode();
            }

            if (NuanceMixDlg != null)
            {
                hash = hash * 59 + NuanceMixDlg.GetHashCode();
            }

            return hash;
        }
    }
}
