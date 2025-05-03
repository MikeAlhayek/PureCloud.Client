using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PostTextResponse
/// </summary>

public partial class PostTextResponse : IEquatable<PostTextResponse>
{
    /// <summary>
    /// The state of the bot after completion of the request
    /// </summary>
    /// <value>The state of the bot after completion of the request</value>
    
    public enum BotStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Moredata for "MoreData"
        /// </summary>
        [EnumMember(Value = "MoreData")]
        Moredata
    }
    /// <summary>
    /// The state of the bot after completion of the request
    /// </summary>
    /// <value>The state of the bot after completion of the request</value>
    [JsonPropertyName("botState")]
    public BotStateEnum? BotState { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PostTextResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PostTextResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PostTextResponse" /> class.
    /// </summary>
    /// <param name="BotState">The state of the bot after completion of the request (required).</param>
    /// <param name="ReplyMessages">The list of messages to respond with, if any.</param>
    /// <param name="IntentName">The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected..</param>
    /// <param name="Slots">Data parameters detected and filled by the bot..</param>
    /// <param name="BotCorrelationId">The optional ID specified in the request.</param>
    /// <param name="AmazonLex">Raw data response from AWS (if called).</param>
    /// <param name="GoogleDialogFlow">Raw data response from Google Dialogflow (if called).</param>
    /// <param name="GenesysDialogEngine">Raw data response from Genesys&#39; Dialogengine (if called).</param>
    /// <param name="GenesysBotConnector">Raw data response from Genesys&#39; BotConnector (if called).</param>
    /// <param name="NuanceMixDlg">Raw data response from Nuance Mix Dlg (if called).</param>
    public PostTextResponse(BotStateEnum? BotState = null, List<PostTextMessage> ReplyMessages = null, string IntentName = null, Dictionary<string, string> Slots = null, string BotCorrelationId = null, Dictionary<string, object> AmazonLex = null, Dictionary<string, object> GoogleDialogFlow = null, Dictionary<string, object> GenesysDialogEngine = null, Dictionary<string, object> GenesysBotConnector = null, Dictionary<string, object> NuanceMixDlg = null)
    {
        this.BotState = BotState;
        this.ReplyMessages = ReplyMessages;
        this.IntentName = IntentName;
        this.Slots = Slots;
        this.BotCorrelationId = BotCorrelationId;
        this.AmazonLex = AmazonLex;
        this.GoogleDialogFlow = GoogleDialogFlow;
        this.GenesysDialogEngine = GenesysDialogEngine;
        this.GenesysBotConnector = GenesysBotConnector;
        this.NuanceMixDlg = NuanceMixDlg;

    }





    /// <summary>
    /// The list of messages to respond with, if any
    /// </summary>
    /// <value>The list of messages to respond with, if any</value>
    [JsonPropertyName("replyMessages")]
    public List<PostTextMessage> ReplyMessages { get; set; }



    /// <summary>
    /// The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected.
    /// </summary>
    /// <value>The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected.</value>
    [JsonPropertyName("intentName")]
    public string IntentName { get; set; }



    /// <summary>
    /// Data parameters detected and filled by the bot.
    /// </summary>
    /// <value>Data parameters detected and filled by the bot.</value>
    [JsonPropertyName("slots")]
    public Dictionary<string, string> Slots { get; set; }



    /// <summary>
    /// The optional ID specified in the request
    /// </summary>
    /// <value>The optional ID specified in the request</value>
    [JsonPropertyName("botCorrelationId")]
    public string BotCorrelationId { get; set; }



    /// <summary>
    /// Raw data response from AWS (if called)
    /// </summary>
    /// <value>Raw data response from AWS (if called)</value>
    [JsonPropertyName("amazonLex")]
    public Dictionary<string, object> AmazonLex { get; set; }



    /// <summary>
    /// Raw data response from Google Dialogflow (if called)
    /// </summary>
    /// <value>Raw data response from Google Dialogflow (if called)</value>
    [JsonPropertyName("googleDialogFlow")]
    public Dictionary<string, object> GoogleDialogFlow { get; set; }



    /// <summary>
    /// Raw data response from Genesys&#39; Dialogengine (if called)
    /// </summary>
    /// <value>Raw data response from Genesys&#39; Dialogengine (if called)</value>
    [JsonPropertyName("genesysDialogEngine")]
    public Dictionary<string, object> GenesysDialogEngine { get; set; }



    /// <summary>
    /// Raw data response from Genesys&#39; BotConnector (if called)
    /// </summary>
    /// <value>Raw data response from Genesys&#39; BotConnector (if called)</value>
    [JsonPropertyName("genesysBotConnector")]
    public Dictionary<string, object> GenesysBotConnector { get; set; }



    /// <summary>
    /// Raw data response from Nuance Mix Dlg (if called)
    /// </summary>
    /// <value>Raw data response from Nuance Mix Dlg (if called)</value>
    [JsonPropertyName("nuanceMixDlg")]
    public Dictionary<string, object> NuanceMixDlg { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PostTextResponse {\n");

        sb.Append("  BotState: ").Append(BotState).Append("\n");
        sb.Append("  ReplyMessages: ").Append(ReplyMessages).Append("\n");
        sb.Append("  IntentName: ").Append(IntentName).Append("\n");
        sb.Append("  Slots: ").Append(Slots).Append("\n");
        sb.Append("  BotCorrelationId: ").Append(BotCorrelationId).Append("\n");
        sb.Append("  AmazonLex: ").Append(AmazonLex).Append("\n");
        sb.Append("  GoogleDialogFlow: ").Append(GoogleDialogFlow).Append("\n");
        sb.Append("  GenesysDialogEngine: ").Append(GenesysDialogEngine).Append("\n");
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
        return Equals(obj as PostTextResponse);
    }

    /// <summary>
    /// Returns true if PostTextResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of PostTextResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PostTextResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BotState == other.BotState ||
                BotState != null &&
                BotState.Equals(other.BotState)
            ) &&
            (
                ReplyMessages == other.ReplyMessages ||
                ReplyMessages != null &&
                ReplyMessages.SequenceEqual(other.ReplyMessages)
            ) &&
            (
                IntentName == other.IntentName ||
                IntentName != null &&
                IntentName.Equals(other.IntentName)
            ) &&
            (
                Slots == other.Slots ||
                Slots != null &&
                Slots.SequenceEqual(other.Slots)
            ) &&
            (
                BotCorrelationId == other.BotCorrelationId ||
                BotCorrelationId != null &&
                BotCorrelationId.Equals(other.BotCorrelationId)
            ) &&
            (
                AmazonLex == other.AmazonLex ||
                AmazonLex != null &&
                AmazonLex.SequenceEqual(other.AmazonLex)
            ) &&
            (
                GoogleDialogFlow == other.GoogleDialogFlow ||
                GoogleDialogFlow != null &&
                GoogleDialogFlow.SequenceEqual(other.GoogleDialogFlow)
            ) &&
            (
                GenesysDialogEngine == other.GenesysDialogEngine ||
                GenesysDialogEngine != null &&
                GenesysDialogEngine.SequenceEqual(other.GenesysDialogEngine)
            ) &&
            (
                GenesysBotConnector == other.GenesysBotConnector ||
                GenesysBotConnector != null &&
                GenesysBotConnector.SequenceEqual(other.GenesysBotConnector)
            ) &&
            (
                NuanceMixDlg == other.NuanceMixDlg ||
                NuanceMixDlg != null &&
                NuanceMixDlg.SequenceEqual(other.NuanceMixDlg)
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
            if (BotState != null)
            {
                hash = hash * 59 + BotState.GetHashCode();
            }

            if (ReplyMessages != null)
            {
                hash = hash * 59 + ReplyMessages.GetHashCode();
            }

            if (IntentName != null)
            {
                hash = hash * 59 + IntentName.GetHashCode();
            }

            if (Slots != null)
            {
                hash = hash * 59 + Slots.GetHashCode();
            }

            if (BotCorrelationId != null)
            {
                hash = hash * 59 + BotCorrelationId.GetHashCode();
            }

            if (AmazonLex != null)
            {
                hash = hash * 59 + AmazonLex.GetHashCode();
            }

            if (GoogleDialogFlow != null)
            {
                hash = hash * 59 + GoogleDialogFlow.GetHashCode();
            }

            if (GenesysDialogEngine != null)
            {
                hash = hash * 59 + GenesysDialogEngine.GetHashCode();
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
