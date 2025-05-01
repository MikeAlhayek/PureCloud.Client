using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings for launching an instance of a bot flow.
/// </summary>
[DataContract]
public partial class TextBotFlowLaunchRequest : IEquatable<TextBotFlowLaunchRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowLaunchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotFlowLaunchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowLaunchRequest" /> class.
    /// </summary>
    /// <param name="Flow">Specifies which Bot Flow to launch. (required).</param>
    /// <param name="ExternalSessionId">The ID of the external session that is associated with the bot flow. (required).</param>
    /// <param name="ConversationId">A conversation ID to associate with the bot flow, if available..</param>
    /// <param name="InputData">Input values to the flow. Valid values are defined by the flow&#39;s input JSON schema..</param>
    /// <param name="Channel">Channel information relevant to the bot flow. (required).</param>
    /// <param name="Language">The language that the bot will use in the session. Validated against list of supported languages and if the value is omitted or is invalid, the default language will be used..</param>
    public TextBotFlowLaunchRequest(TextBotFlow Flow = null, string ExternalSessionId = null, string ConversationId = null, TextBotInputOutputData InputData = null, TextBotChannel Channel = null, string Language = null)
    {
        this.Flow = Flow;
        this.ExternalSessionId = ExternalSessionId;
        this.ConversationId = ConversationId;
        this.InputData = InputData;
        this.Channel = Channel;
        this.Language = Language;

    }



    /// <summary>
    /// Specifies which Bot Flow to launch.
    /// </summary>
    /// <value>Specifies which Bot Flow to launch.</value>
    [DataMember(Name = "flow", EmitDefaultValue = false)]
    public TextBotFlow Flow { get; set; }



    /// <summary>
    /// The ID of the external session that is associated with the bot flow.
    /// </summary>
    /// <value>The ID of the external session that is associated with the bot flow.</value>
    [DataMember(Name = "externalSessionId", EmitDefaultValue = false)]
    public string ExternalSessionId { get; set; }



    /// <summary>
    /// A conversation ID to associate with the bot flow, if available.
    /// </summary>
    /// <value>A conversation ID to associate with the bot flow, if available.</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Input values to the flow. Valid values are defined by the flow&#39;s input JSON schema.
    /// </summary>
    /// <value>Input values to the flow. Valid values are defined by the flow&#39;s input JSON schema.</value>
    [DataMember(Name = "inputData", EmitDefaultValue = false)]
    public TextBotInputOutputData InputData { get; set; }



    /// <summary>
    /// Channel information relevant to the bot flow.
    /// </summary>
    /// <value>Channel information relevant to the bot flow.</value>
    [DataMember(Name = "channel", EmitDefaultValue = false)]
    public TextBotChannel Channel { get; set; }



    /// <summary>
    /// The language that the bot will use in the session. Validated against list of supported languages and if the value is omitted or is invalid, the default language will be used.
    /// </summary>
    /// <value>The language that the bot will use in the session. Validated against list of supported languages and if the value is omitted or is invalid, the default language will be used.</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotFlowLaunchRequest {\n");

        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  ExternalSessionId: ").Append(ExternalSessionId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  InputData: ").Append(InputData).Append("\n");
        sb.Append("  Channel: ").Append(Channel).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
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
        return Equals(obj as TextBotFlowLaunchRequest);
    }

    /// <summary>
    /// Returns true if TextBotFlowLaunchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotFlowLaunchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotFlowLaunchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                ExternalSessionId == other.ExternalSessionId ||
                ExternalSessionId != null &&
                ExternalSessionId.Equals(other.ExternalSessionId)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                InputData == other.InputData ||
                InputData != null &&
                InputData.Equals(other.InputData)
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
            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (ExternalSessionId != null)
            {
                hash = hash * 59 + ExternalSessionId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (InputData != null)
            {
                hash = hash * 59 + InputData.GetHashCode();
            }

            if (Channel != null)
            {
                hash = hash * 59 + Channel.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            return hash;
        }
    }
}
