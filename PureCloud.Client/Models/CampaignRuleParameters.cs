using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignRuleParameters
/// </summary>

public partial class CampaignRuleParameters : IEquatable<CampaignRuleParameters>
{
    /// <summary>
    /// The operator for comparison. Required for a CampaignRuleCondition.
    /// </summary>
    /// <value>The operator for comparison. Required for a CampaignRuleCondition.</value>
    
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Equals for "equals"
        /// </summary>
        [EnumMember(Value = "equals")]
        Equals,

        /// <summary>
        /// Enum Greaterthan for "greaterThan"
        /// </summary>
        [EnumMember(Value = "greaterThan")]
        Greaterthan,

        /// <summary>
        /// Enum Greaterthanequalto for "greaterThanEqualTo"
        /// </summary>
        [EnumMember(Value = "greaterThanEqualTo")]
        Greaterthanequalto,

        /// <summary>
        /// Enum Lessthan for "lessThan"
        /// </summary>
        [EnumMember(Value = "lessThan")]
        Lessthan,

        /// <summary>
        /// Enum Lessthanequalto for "lessThanEqualTo"
        /// </summary>
        [EnumMember(Value = "lessThanEqualTo")]
        Lessthanequalto
    }
    /// <summary>
    /// The priority to set a campaign to. Required for the 'setCampaignPriority' action.
    /// </summary>
    /// <value>The priority to set a campaign to. Required for the 'setCampaignPriority' action.</value>
    
    public enum PriorityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum _1 for "1"
        /// </summary>
        [EnumMember(Value = "1")]
        _1,

        /// <summary>
        /// Enum _2 for "2"
        /// </summary>
        [EnumMember(Value = "2")]
        _2,

        /// <summary>
        /// Enum _3 for "3"
        /// </summary>
        [EnumMember(Value = "3")]
        _3,

        /// <summary>
        /// Enum _4 for "4"
        /// </summary>
        [EnumMember(Value = "4")]
        _4,

        /// <summary>
        /// Enum _5 for "5"
        /// </summary>
        [EnumMember(Value = "5")]
        _5
    }
    /// <summary>
    /// The dialing mode to set a campaign to. Required for the 'setCampaignDialingMode' action.
    /// </summary>
    /// <value>The dialing mode to set a campaign to. Required for the 'setCampaignDialingMode' action.</value>
    
    public enum DialingModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Agentless for "agentless"
        /// </summary>
        [EnumMember(Value = "agentless")]
        Agentless,

        /// <summary>
        /// Enum Preview for "preview"
        /// </summary>
        [EnumMember(Value = "preview")]
        Preview,

        /// <summary>
        /// Enum Power for "power"
        /// </summary>
        [EnumMember(Value = "power")]
        Power,

        /// <summary>
        /// Enum Predictive for "predictive"
        /// </summary>
        [EnumMember(Value = "predictive")]
        Predictive,

        /// <summary>
        /// Enum Progressive for "progressive"
        /// </summary>
        [EnumMember(Value = "progressive")]
        Progressive,

        /// <summary>
        /// Enum External for "external"
        /// </summary>
        [EnumMember(Value = "external")]
        External
    }
    /// <summary>
    /// The operator for comparison. Required for a CampaignRuleCondition.
    /// </summary>
    /// <value>The operator for comparison. Required for a CampaignRuleCondition.</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// The priority to set a campaign to. Required for the 'setCampaignPriority' action.
    /// </summary>
    /// <value>The priority to set a campaign to. Required for the 'setCampaignPriority' action.</value>
    [JsonPropertyName("priority")]
    public PriorityEnum? Priority { get; set; }
    /// <summary>
    /// The dialing mode to set a campaign to. Required for the 'setCampaignDialingMode' action.
    /// </summary>
    /// <value>The dialing mode to set a campaign to. Required for the 'setCampaignDialingMode' action.</value>
    [JsonPropertyName("dialingMode")]
    public DialingModeEnum? DialingMode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignRuleParameters" /> class.
    /// </summary>
    /// <param name="Operator">The operator for comparison. Required for a CampaignRuleCondition..</param>
    /// <param name="Value">The value for comparison. Required for a CampaignRuleCondition..</param>
    /// <param name="Priority">The priority to set a campaign to. Required for the &#39;setCampaignPriority&#39; action..</param>
    /// <param name="DialingMode">The dialing mode to set a campaign to. Required for the &#39;setCampaignDialingMode&#39; action..</param>
    /// <param name="AbandonRate">The abandon rate to set a campaign to. Required for the &#39;setCampaignAbandonRate&#39; action..</param>
    /// <param name="OutboundLineCount">The  number of outbound lines to set a campaign to. Required for the &#39;setCampaignNumberOfLines&#39; action..</param>
    /// <param name="RelativeWeight">The relative weight to set a campaign to. Required for the &#39;setCampaignWeight&#39; action..</param>
    /// <param name="MaxCallsPerAgent">The maximum number of calls per agent to set a campaign to. Required for the &#39;setCampaignMaxCallsPerAgent&#39; action..</param>
    /// <param name="Queue">The queue a campaign to. Required for the &#39;changeCampaignQueue&#39; action..</param>
    /// <param name="MessagesPerMinute">The number of messages per minute to set a messaging campaign to..</param>
    /// <param name="SmsMessagesPerMinute">The number of messages per minute to set a SMS messaging campaign to..</param>
    /// <param name="EmailMessagesPerMinute">The number of messages per minute to set a Email messaging campaign to..</param>
    /// <param name="SmsContentTemplate">The content template to set a SMS campaign to..</param>
    /// <param name="EmailContentTemplate">The content template to set a Email campaign to..</param>
    public CampaignRuleParameters(OperatorEnum? Operator = null, string Value = null, PriorityEnum? Priority = null, DialingModeEnum? DialingMode = null, double? AbandonRate = null, int? OutboundLineCount = null, int? RelativeWeight = null, double? MaxCallsPerAgent = null, DomainEntityRef Queue = null, int? MessagesPerMinute = null, int? SmsMessagesPerMinute = null, int? EmailMessagesPerMinute = null, DomainEntityRef SmsContentTemplate = null, DomainEntityRef EmailContentTemplate = null)
    {
        this.Operator = Operator;
        this.Value = Value;
        this.Priority = Priority;
        this.DialingMode = DialingMode;
        this.AbandonRate = AbandonRate;
        this.OutboundLineCount = OutboundLineCount;
        this.RelativeWeight = RelativeWeight;
        this.MaxCallsPerAgent = MaxCallsPerAgent;
        this.Queue = Queue;
        this.MessagesPerMinute = MessagesPerMinute;
        this.SmsMessagesPerMinute = SmsMessagesPerMinute;
        this.EmailMessagesPerMinute = EmailMessagesPerMinute;
        this.SmsContentTemplate = SmsContentTemplate;
        this.EmailContentTemplate = EmailContentTemplate;

    }





    /// <summary>
    /// The value for comparison. Required for a CampaignRuleCondition.
    /// </summary>
    /// <value>The value for comparison. Required for a CampaignRuleCondition.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }







    /// <summary>
    /// The abandon rate to set a campaign to. Required for the &#39;setCampaignAbandonRate&#39; action.
    /// </summary>
    /// <value>The abandon rate to set a campaign to. Required for the &#39;setCampaignAbandonRate&#39; action.</value>
    [JsonPropertyName("abandonRate")]
    public double? AbandonRate { get; set; }



    /// <summary>
    /// The  number of outbound lines to set a campaign to. Required for the &#39;setCampaignNumberOfLines&#39; action.
    /// </summary>
    /// <value>The  number of outbound lines to set a campaign to. Required for the &#39;setCampaignNumberOfLines&#39; action.</value>
    [JsonPropertyName("outboundLineCount")]
    public int? OutboundLineCount { get; set; }



    /// <summary>
    /// The relative weight to set a campaign to. Required for the &#39;setCampaignWeight&#39; action.
    /// </summary>
    /// <value>The relative weight to set a campaign to. Required for the &#39;setCampaignWeight&#39; action.</value>
    [JsonPropertyName("relativeWeight")]
    public int? RelativeWeight { get; set; }



    /// <summary>
    /// The maximum number of calls per agent to set a campaign to. Required for the &#39;setCampaignMaxCallsPerAgent&#39; action.
    /// </summary>
    /// <value>The maximum number of calls per agent to set a campaign to. Required for the &#39;setCampaignMaxCallsPerAgent&#39; action.</value>
    [JsonPropertyName("maxCallsPerAgent")]
    public double? MaxCallsPerAgent { get; set; }



    /// <summary>
    /// The queue a campaign to. Required for the &#39;changeCampaignQueue&#39; action.
    /// </summary>
    /// <value>The queue a campaign to. Required for the &#39;changeCampaignQueue&#39; action.</value>
    [JsonPropertyName("queue")]
    public DomainEntityRef Queue { get; set; }



    /// <summary>
    /// The number of messages per minute to set a messaging campaign to.
    /// </summary>
    /// <value>The number of messages per minute to set a messaging campaign to.</value>
    [JsonPropertyName("messagesPerMinute")]
    public int? MessagesPerMinute { get; set; }



    /// <summary>
    /// The number of messages per minute to set a SMS messaging campaign to.
    /// </summary>
    /// <value>The number of messages per minute to set a SMS messaging campaign to.</value>
    [JsonPropertyName("smsMessagesPerMinute")]
    public int? SmsMessagesPerMinute { get; set; }



    /// <summary>
    /// The number of messages per minute to set a Email messaging campaign to.
    /// </summary>
    /// <value>The number of messages per minute to set a Email messaging campaign to.</value>
    [JsonPropertyName("emailMessagesPerMinute")]
    public int? EmailMessagesPerMinute { get; set; }



    /// <summary>
    /// The content template to set a SMS campaign to.
    /// </summary>
    /// <value>The content template to set a SMS campaign to.</value>
    [JsonPropertyName("smsContentTemplate")]
    public DomainEntityRef SmsContentTemplate { get; set; }



    /// <summary>
    /// The content template to set a Email campaign to.
    /// </summary>
    /// <value>The content template to set a Email campaign to.</value>
    [JsonPropertyName("emailContentTemplate")]
    public DomainEntityRef EmailContentTemplate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignRuleParameters {\n");

        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  DialingMode: ").Append(DialingMode).Append("\n");
        sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
        sb.Append("  OutboundLineCount: ").Append(OutboundLineCount).Append("\n");
        sb.Append("  RelativeWeight: ").Append(RelativeWeight).Append("\n");
        sb.Append("  MaxCallsPerAgent: ").Append(MaxCallsPerAgent).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  MessagesPerMinute: ").Append(MessagesPerMinute).Append("\n");
        sb.Append("  SmsMessagesPerMinute: ").Append(SmsMessagesPerMinute).Append("\n");
        sb.Append("  EmailMessagesPerMinute: ").Append(EmailMessagesPerMinute).Append("\n");
        sb.Append("  SmsContentTemplate: ").Append(SmsContentTemplate).Append("\n");
        sb.Append("  EmailContentTemplate: ").Append(EmailContentTemplate).Append("\n");
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
        return Equals(obj as CampaignRuleParameters);
    }

    /// <summary>
    /// Returns true if CampaignRuleParameters instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignRuleParameters to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignRuleParameters other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                DialingMode == other.DialingMode ||
                DialingMode != null &&
                DialingMode.Equals(other.DialingMode)
            ) &&
            (
                AbandonRate == other.AbandonRate ||
                AbandonRate != null &&
                AbandonRate.Equals(other.AbandonRate)
            ) &&
            (
                OutboundLineCount == other.OutboundLineCount ||
                OutboundLineCount != null &&
                OutboundLineCount.Equals(other.OutboundLineCount)
            ) &&
            (
                RelativeWeight == other.RelativeWeight ||
                RelativeWeight != null &&
                RelativeWeight.Equals(other.RelativeWeight)
            ) &&
            (
                MaxCallsPerAgent == other.MaxCallsPerAgent ||
                MaxCallsPerAgent != null &&
                MaxCallsPerAgent.Equals(other.MaxCallsPerAgent)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                MessagesPerMinute == other.MessagesPerMinute ||
                MessagesPerMinute != null &&
                MessagesPerMinute.Equals(other.MessagesPerMinute)
            ) &&
            (
                SmsMessagesPerMinute == other.SmsMessagesPerMinute ||
                SmsMessagesPerMinute != null &&
                SmsMessagesPerMinute.Equals(other.SmsMessagesPerMinute)
            ) &&
            (
                EmailMessagesPerMinute == other.EmailMessagesPerMinute ||
                EmailMessagesPerMinute != null &&
                EmailMessagesPerMinute.Equals(other.EmailMessagesPerMinute)
            ) &&
            (
                SmsContentTemplate == other.SmsContentTemplate ||
                SmsContentTemplate != null &&
                SmsContentTemplate.Equals(other.SmsContentTemplate)
            ) &&
            (
                EmailContentTemplate == other.EmailContentTemplate ||
                EmailContentTemplate != null &&
                EmailContentTemplate.Equals(other.EmailContentTemplate)
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
            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (DialingMode != null)
            {
                hash = hash * 59 + DialingMode.GetHashCode();
            }

            if (AbandonRate != null)
            {
                hash = hash * 59 + AbandonRate.GetHashCode();
            }

            if (OutboundLineCount != null)
            {
                hash = hash * 59 + OutboundLineCount.GetHashCode();
            }

            if (RelativeWeight != null)
            {
                hash = hash * 59 + RelativeWeight.GetHashCode();
            }

            if (MaxCallsPerAgent != null)
            {
                hash = hash * 59 + MaxCallsPerAgent.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (MessagesPerMinute != null)
            {
                hash = hash * 59 + MessagesPerMinute.GetHashCode();
            }

            if (SmsMessagesPerMinute != null)
            {
                hash = hash * 59 + SmsMessagesPerMinute.GetHashCode();
            }

            if (EmailMessagesPerMinute != null)
            {
                hash = hash * 59 + EmailMessagesPerMinute.GetHashCode();
            }

            if (SmsContentTemplate != null)
            {
                hash = hash * 59 + SmsContentTemplate.GetHashCode();
            }

            if (EmailContentTemplate != null)
            {
                hash = hash * 59 + EmailContentTemplate.GetHashCode();
            }

            return hash;
        }
    }
}
