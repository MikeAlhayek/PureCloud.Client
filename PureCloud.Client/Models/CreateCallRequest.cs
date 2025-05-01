using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateCallRequest
/// </summary>
[DataContract]
public partial class CreateCallRequest : IEquatable<CreateCallRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateCallRequest" /> class.
    /// </summary>
    /// <param name="PhoneNumber">The phone number to dial..</param>
    /// <param name="CallerId">The caller id phone number for this outbound call..</param>
    /// <param name="CallerIdName">The caller id name for this outbound call..</param>
    /// <param name="CallFromQueueId">The queue ID to call on behalf of..</param>
    /// <param name="CallQueueId">The queue ID to call..</param>
    /// <param name="CallUserId">The user ID to call..</param>
    /// <param name="Priority">The priority to assign to this call (if calling a queue)..</param>
    /// <param name="Attributes">The list of attributes to associate with the customer participant..</param>
    /// <param name="LanguageId">The language skill ID to use for routing this call (if calling a queue)..</param>
    /// <param name="RoutingSkillsIds">The skill ID&#39;s to use for routing this call (if calling a queue)..</param>
    /// <param name="ConversationIds">The list of existing call conversations to merge into a new ad-hoc conference..</param>
    /// <param name="Participants">The list of participants to call to create a new ad-hoc conference..</param>
    /// <param name="UuiData">User to User Information (UUI) data managed by SIP session application..</param>
    /// <param name="ExternalContactId">The external contact with which to associate the call..</param>
    /// <param name="Label">An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level.</param>
    public CreateCallRequest(string PhoneNumber = null, string CallerId = null, string CallerIdName = null, string CallFromQueueId = null, string CallQueueId = null, string CallUserId = null, int? Priority = null, Dictionary<string, string> Attributes = null, string LanguageId = null, List<string> RoutingSkillsIds = null, List<string> ConversationIds = null, List<Destination> Participants = null, string UuiData = null, string ExternalContactId = null, string Label = null)
    {
        this.PhoneNumber = PhoneNumber;
        this.CallerId = CallerId;
        this.CallerIdName = CallerIdName;
        this.CallFromQueueId = CallFromQueueId;
        this.CallQueueId = CallQueueId;
        this.CallUserId = CallUserId;
        this.Priority = Priority;
        this.Attributes = Attributes;
        this.LanguageId = LanguageId;
        this.RoutingSkillsIds = RoutingSkillsIds;
        this.ConversationIds = ConversationIds;
        this.Participants = Participants;
        this.UuiData = UuiData;
        this.ExternalContactId = ExternalContactId;
        this.Label = Label;

    }



    /// <summary>
    /// The phone number to dial.
    /// </summary>
    /// <value>The phone number to dial.</value>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// The caller id phone number for this outbound call.
    /// </summary>
    /// <value>The caller id phone number for this outbound call.</value>
    [DataMember(Name = "callerId", EmitDefaultValue = false)]
    public string CallerId { get; set; }



    /// <summary>
    /// The caller id name for this outbound call.
    /// </summary>
    /// <value>The caller id name for this outbound call.</value>
    [DataMember(Name = "callerIdName", EmitDefaultValue = false)]
    public string CallerIdName { get; set; }



    /// <summary>
    /// The queue ID to call on behalf of.
    /// </summary>
    /// <value>The queue ID to call on behalf of.</value>
    [DataMember(Name = "callFromQueueId", EmitDefaultValue = false)]
    public string CallFromQueueId { get; set; }



    /// <summary>
    /// The queue ID to call.
    /// </summary>
    /// <value>The queue ID to call.</value>
    [DataMember(Name = "callQueueId", EmitDefaultValue = false)]
    public string CallQueueId { get; set; }



    /// <summary>
    /// The user ID to call.
    /// </summary>
    /// <value>The user ID to call.</value>
    [DataMember(Name = "callUserId", EmitDefaultValue = false)]
    public string CallUserId { get; set; }



    /// <summary>
    /// The priority to assign to this call (if calling a queue).
    /// </summary>
    /// <value>The priority to assign to this call (if calling a queue).</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public int? Priority { get; set; }



    /// <summary>
    /// The list of attributes to associate with the customer participant.
    /// </summary>
    /// <value>The list of attributes to associate with the customer participant.</value>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// The language skill ID to use for routing this call (if calling a queue).
    /// </summary>
    /// <value>The language skill ID to use for routing this call (if calling a queue).</value>
    [DataMember(Name = "languageId", EmitDefaultValue = false)]
    public string LanguageId { get; set; }



    /// <summary>
    /// The skill ID&#39;s to use for routing this call (if calling a queue).
    /// </summary>
    /// <value>The skill ID&#39;s to use for routing this call (if calling a queue).</value>
    [DataMember(Name = "routingSkillsIds", EmitDefaultValue = false)]
    public List<string> RoutingSkillsIds { get; set; }



    /// <summary>
    /// The list of existing call conversations to merge into a new ad-hoc conference.
    /// </summary>
    /// <value>The list of existing call conversations to merge into a new ad-hoc conference.</value>
    [DataMember(Name = "conversationIds", EmitDefaultValue = false)]
    public List<string> ConversationIds { get; set; }



    /// <summary>
    /// The list of participants to call to create a new ad-hoc conference.
    /// </summary>
    /// <value>The list of participants to call to create a new ad-hoc conference.</value>
    [DataMember(Name = "participants", EmitDefaultValue = false)]
    public List<Destination> Participants { get; set; }



    /// <summary>
    /// User to User Information (UUI) data managed by SIP session application.
    /// </summary>
    /// <value>User to User Information (UUI) data managed by SIP session application.</value>
    [DataMember(Name = "uuiData", EmitDefaultValue = false)]
    public string UuiData { get; set; }



    /// <summary>
    /// The external contact with which to associate the call.
    /// </summary>
    /// <value>The external contact with which to associate the call.</value>
    [DataMember(Name = "externalContactId", EmitDefaultValue = false)]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
    /// </summary>
    /// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
    [DataMember(Name = "label", EmitDefaultValue = false)]
    public string Label { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateCallRequest {\n");

        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  CallerId: ").Append(CallerId).Append("\n");
        sb.Append("  CallerIdName: ").Append(CallerIdName).Append("\n");
        sb.Append("  CallFromQueueId: ").Append(CallFromQueueId).Append("\n");
        sb.Append("  CallQueueId: ").Append(CallQueueId).Append("\n");
        sb.Append("  CallUserId: ").Append(CallUserId).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
        sb.Append("  RoutingSkillsIds: ").Append(RoutingSkillsIds).Append("\n");
        sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  UuiData: ").Append(UuiData).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
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
        return Equals(obj as CreateCallRequest);
    }

    /// <summary>
    /// Returns true if CreateCallRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateCallRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateCallRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                CallerId == other.CallerId ||
                CallerId != null &&
                CallerId.Equals(other.CallerId)
            ) &&
            (
                CallerIdName == other.CallerIdName ||
                CallerIdName != null &&
                CallerIdName.Equals(other.CallerIdName)
            ) &&
            (
                CallFromQueueId == other.CallFromQueueId ||
                CallFromQueueId != null &&
                CallFromQueueId.Equals(other.CallFromQueueId)
            ) &&
            (
                CallQueueId == other.CallQueueId ||
                CallQueueId != null &&
                CallQueueId.Equals(other.CallQueueId)
            ) &&
            (
                CallUserId == other.CallUserId ||
                CallUserId != null &&
                CallUserId.Equals(other.CallUserId)
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
                LanguageId == other.LanguageId ||
                LanguageId != null &&
                LanguageId.Equals(other.LanguageId)
            ) &&
            (
                RoutingSkillsIds == other.RoutingSkillsIds ||
                RoutingSkillsIds != null &&
                RoutingSkillsIds.SequenceEqual(other.RoutingSkillsIds)
            ) &&
            (
                ConversationIds == other.ConversationIds ||
                ConversationIds != null &&
                ConversationIds.SequenceEqual(other.ConversationIds)
            ) &&
            (
                Participants == other.Participants ||
                Participants != null &&
                Participants.SequenceEqual(other.Participants)
            ) &&
            (
                UuiData == other.UuiData ||
                UuiData != null &&
                UuiData.Equals(other.UuiData)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                Label == other.Label ||
                Label != null &&
                Label.Equals(other.Label)
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
            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (CallerId != null)
            {
                hash = hash * 59 + CallerId.GetHashCode();
            }

            if (CallerIdName != null)
            {
                hash = hash * 59 + CallerIdName.GetHashCode();
            }

            if (CallFromQueueId != null)
            {
                hash = hash * 59 + CallFromQueueId.GetHashCode();
            }

            if (CallQueueId != null)
            {
                hash = hash * 59 + CallQueueId.GetHashCode();
            }

            if (CallUserId != null)
            {
                hash = hash * 59 + CallUserId.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (LanguageId != null)
            {
                hash = hash * 59 + LanguageId.GetHashCode();
            }

            if (RoutingSkillsIds != null)
            {
                hash = hash * 59 + RoutingSkillsIds.GetHashCode();
            }

            if (ConversationIds != null)
            {
                hash = hash * 59 + ConversationIds.GetHashCode();
            }

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            if (UuiData != null)
            {
                hash = hash * 59 + UuiData.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (Label != null)
            {
                hash = hash * 59 + Label.GetHashCode();
            }

            return hash;
        }
    }
}
