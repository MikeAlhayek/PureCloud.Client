using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A maximum of 100 events are allowed per request
/// </summary>

public partial class BatchConversationEventRequest : IEquatable<BatchConversationEventRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchConversationEventRequest" /> class.
    /// </summary>
    /// <param name="EndTransferEvents">Voice - EndTransfer events for this batch.</param>
    /// <param name="PhoneTransferEvents">Voice - PhoneTransfer events for this batch.</param>
    /// <param name="ProgressTransferEvents">Voice - ProgressTransfer events for this batch.</param>
    /// <param name="RoutingTransferEvents">Voice - RoutingTransfer events for this batch.</param>
    /// <param name="UserTransferEvents">Voice - UserTransfer events for this batch.</param>
    /// <param name="CommunicationAnsweredEvents">Voice - CommunicationAnswered events for this batch.</param>
    /// <param name="CommunicationDispositionAppliedEvents">Voice - CommunicationDispositionApplied events for this batch.</param>
    /// <param name="HoldUpdatedEvents">Voice - HoldUpdated events for this batch.</param>
    /// <param name="ExternalEstablishedEvents">Voice - ExternalEstablished events for this batch.</param>
    /// <param name="IvrEstablishedEvents">Voice - IvrEstablished events for this batch.</param>
    /// <param name="PhoneEstablishedEvents">Voice - PhoneEstablished events for this batch.</param>
    /// <param name="RoutingEstablishedEvents">Voice - RoutingEstablished events for this batch.</param>
    /// <param name="UserEstablishedEvents">Voice - UserEstablished events for this batch.</param>
    /// <param name="AudioUpdatedEvents">Voice - AudioUpdated events for this batch.</param>
    /// <param name="CommunicationEndedEvents">Voice - CommunicationEnded events for this batch.</param>
    /// <param name="ConsultTransferEvents">Voice - ConsultTransfer events for this batch.</param>
    /// <param name="ProgressConsultTransferEvents">Voice - ProgressConsultTransfer events for this batch.</param>
    /// <param name="EndConsultTransferEvents">Voice - EndConsultTransfer events for this batch.</param>
    /// <param name="EmailBeginTransmittingEvents">Email - EmailBeginTransmittingEvent events for this batch.</param>
    /// <param name="EmailCommunicationEndedEvents">Email - EmailCommunicationEndedEvent events for this batch.</param>
    /// <param name="EmailExternalEstablishedEvents">Email - EmailExternalEstablishedEvent events for this batch.</param>
    /// <param name="EmailFlowEstablishedEvents">Email - EmailFlowEstablishedEvent events for this batch.</param>
    /// <param name="EmailRoutingEstablishedEvents">Email - EmailRoutingEstablishedEvent events for this batch.</param>
    /// <param name="EmailUserEstablishedEvents">Email - EmailUserEstablishedEvent events for this batch.</param>
    /// <param name="EmailCommunicationAnsweredEvents">Email - EmailCommunicationAnsweredEvent events for this batch.</param>
    /// <param name="EmailCommunicationDispositionAppliedEvents">Email - EmailCommunicationDispositionAppliedEvent events for this batch.</param>
    /// <param name="EmailCommunicationSentMessageEvents">Email - EmailCommunicationSentMessageEvent events for this batch.</param>
    /// <param name="EmailHoldUpdatedEvents">Email - EmailHoldUpdatedEvent events for this batch.</param>
    /// <param name="EmailEndTransferEvents">Email - EmailEndTransferEvent events for this batch.</param>
    /// <param name="EmailProgressTransferEvents">Email - EmailProgressTransferEvent events for this batch.</param>
    /// <param name="EmailRoutingTransferEvents">Email - EmailRoutingTransferEvent events for this batch.</param>
    /// <param name="EmailUserTransferEvents">Email - EmailUserTransferEvent events for this batch.</param>
    public BatchConversationEventRequest(List<EndTransferEvent> EndTransferEvents = null, List<PhoneTransferEvent> PhoneTransferEvents = null, List<ProgressTransferEvent> ProgressTransferEvents = null, List<RoutingTransferEvent> RoutingTransferEvents = null, List<UserTransferEvent> UserTransferEvents = null, List<CommunicationAnsweredEvent> CommunicationAnsweredEvents = null, List<CommunicationDispositionAppliedEvent> CommunicationDispositionAppliedEvents = null, List<HoldUpdatedEvent> HoldUpdatedEvents = null, List<ExternalEstablishedEvent> ExternalEstablishedEvents = null, List<IvrEstablishedEvent> IvrEstablishedEvents = null, List<PhoneEstablishedEvent> PhoneEstablishedEvents = null, List<RoutingEstablishedEvent> RoutingEstablishedEvents = null, List<UserEstablishedEvent> UserEstablishedEvents = null, List<AudioUpdatedEvent> AudioUpdatedEvents = null, List<CommunicationEndedEvent> CommunicationEndedEvents = null, List<ConsultTransferEvent> ConsultTransferEvents = null, List<ProgressConsultTransferEvent> ProgressConsultTransferEvents = null, List<EndConsultTransferEvent> EndConsultTransferEvents = null, List<EmailBeginTransmittingEvent> EmailBeginTransmittingEvents = null, List<EmailCommunicationEndedEvent> EmailCommunicationEndedEvents = null, List<EmailExternalEstablishedEvent> EmailExternalEstablishedEvents = null, List<EmailFlowEstablishedEvent> EmailFlowEstablishedEvents = null, List<EmailRoutingEstablishedEvent> EmailRoutingEstablishedEvents = null, List<EmailUserEstablishedEvent> EmailUserEstablishedEvents = null, List<EmailCommunicationAnsweredEvent> EmailCommunicationAnsweredEvents = null, List<EmailCommunicationDispositionAppliedEvent> EmailCommunicationDispositionAppliedEvents = null, List<EmailCommunicationSentMessageEvent> EmailCommunicationSentMessageEvents = null, List<EmailHoldUpdatedEvent> EmailHoldUpdatedEvents = null, List<EmailEndTransferEvent> EmailEndTransferEvents = null, List<EmailProgressTransferEvent> EmailProgressTransferEvents = null, List<EmailRoutingTransferEvent> EmailRoutingTransferEvents = null, List<EmailUserTransferEvent> EmailUserTransferEvents = null)
    {
        this.EndTransferEvents = EndTransferEvents;
        this.PhoneTransferEvents = PhoneTransferEvents;
        this.ProgressTransferEvents = ProgressTransferEvents;
        this.RoutingTransferEvents = RoutingTransferEvents;
        this.UserTransferEvents = UserTransferEvents;
        this.CommunicationAnsweredEvents = CommunicationAnsweredEvents;
        this.CommunicationDispositionAppliedEvents = CommunicationDispositionAppliedEvents;
        this.HoldUpdatedEvents = HoldUpdatedEvents;
        this.ExternalEstablishedEvents = ExternalEstablishedEvents;
        this.IvrEstablishedEvents = IvrEstablishedEvents;
        this.PhoneEstablishedEvents = PhoneEstablishedEvents;
        this.RoutingEstablishedEvents = RoutingEstablishedEvents;
        this.UserEstablishedEvents = UserEstablishedEvents;
        this.AudioUpdatedEvents = AudioUpdatedEvents;
        this.CommunicationEndedEvents = CommunicationEndedEvents;
        this.ConsultTransferEvents = ConsultTransferEvents;
        this.ProgressConsultTransferEvents = ProgressConsultTransferEvents;
        this.EndConsultTransferEvents = EndConsultTransferEvents;
        this.EmailBeginTransmittingEvents = EmailBeginTransmittingEvents;
        this.EmailCommunicationEndedEvents = EmailCommunicationEndedEvents;
        this.EmailExternalEstablishedEvents = EmailExternalEstablishedEvents;
        this.EmailFlowEstablishedEvents = EmailFlowEstablishedEvents;
        this.EmailRoutingEstablishedEvents = EmailRoutingEstablishedEvents;
        this.EmailUserEstablishedEvents = EmailUserEstablishedEvents;
        this.EmailCommunicationAnsweredEvents = EmailCommunicationAnsweredEvents;
        this.EmailCommunicationDispositionAppliedEvents = EmailCommunicationDispositionAppliedEvents;
        this.EmailCommunicationSentMessageEvents = EmailCommunicationSentMessageEvents;
        this.EmailHoldUpdatedEvents = EmailHoldUpdatedEvents;
        this.EmailEndTransferEvents = EmailEndTransferEvents;
        this.EmailProgressTransferEvents = EmailProgressTransferEvents;
        this.EmailRoutingTransferEvents = EmailRoutingTransferEvents;
        this.EmailUserTransferEvents = EmailUserTransferEvents;

    }



    /// <summary>
    /// Voice - EndTransfer events for this batch
    /// </summary>
    /// <value>Voice - EndTransfer events for this batch</value>
    [JsonPropertyName("endTransferEvents")]
    public List<EndTransferEvent> EndTransferEvents { get; set; }



    /// <summary>
    /// Voice - PhoneTransfer events for this batch
    /// </summary>
    /// <value>Voice - PhoneTransfer events for this batch</value>
    [JsonPropertyName("phoneTransferEvents")]
    public List<PhoneTransferEvent> PhoneTransferEvents { get; set; }



    /// <summary>
    /// Voice - ProgressTransfer events for this batch
    /// </summary>
    /// <value>Voice - ProgressTransfer events for this batch</value>
    [JsonPropertyName("progressTransferEvents")]
    public List<ProgressTransferEvent> ProgressTransferEvents { get; set; }



    /// <summary>
    /// Voice - RoutingTransfer events for this batch
    /// </summary>
    /// <value>Voice - RoutingTransfer events for this batch</value>
    [JsonPropertyName("routingTransferEvents")]
    public List<RoutingTransferEvent> RoutingTransferEvents { get; set; }



    /// <summary>
    /// Voice - UserTransfer events for this batch
    /// </summary>
    /// <value>Voice - UserTransfer events for this batch</value>
    [JsonPropertyName("userTransferEvents")]
    public List<UserTransferEvent> UserTransferEvents { get; set; }



    /// <summary>
    /// Voice - CommunicationAnswered events for this batch
    /// </summary>
    /// <value>Voice - CommunicationAnswered events for this batch</value>
    [JsonPropertyName("communicationAnsweredEvents")]
    public List<CommunicationAnsweredEvent> CommunicationAnsweredEvents { get; set; }



    /// <summary>
    /// Voice - CommunicationDispositionApplied events for this batch
    /// </summary>
    /// <value>Voice - CommunicationDispositionApplied events for this batch</value>
    [JsonPropertyName("communicationDispositionAppliedEvents")]
    public List<CommunicationDispositionAppliedEvent> CommunicationDispositionAppliedEvents { get; set; }



    /// <summary>
    /// Voice - HoldUpdated events for this batch
    /// </summary>
    /// <value>Voice - HoldUpdated events for this batch</value>
    [JsonPropertyName("holdUpdatedEvents")]
    public List<HoldUpdatedEvent> HoldUpdatedEvents { get; set; }



    /// <summary>
    /// Voice - ExternalEstablished events for this batch
    /// </summary>
    /// <value>Voice - ExternalEstablished events for this batch</value>
    [JsonPropertyName("externalEstablishedEvents")]
    public List<ExternalEstablishedEvent> ExternalEstablishedEvents { get; set; }



    /// <summary>
    /// Voice - IvrEstablished events for this batch
    /// </summary>
    /// <value>Voice - IvrEstablished events for this batch</value>
    [JsonPropertyName("ivrEstablishedEvents")]
    public List<IvrEstablishedEvent> IvrEstablishedEvents { get; set; }



    /// <summary>
    /// Voice - PhoneEstablished events for this batch
    /// </summary>
    /// <value>Voice - PhoneEstablished events for this batch</value>
    [JsonPropertyName("phoneEstablishedEvents")]
    public List<PhoneEstablishedEvent> PhoneEstablishedEvents { get; set; }



    /// <summary>
    /// Voice - RoutingEstablished events for this batch
    /// </summary>
    /// <value>Voice - RoutingEstablished events for this batch</value>
    [JsonPropertyName("routingEstablishedEvents")]
    public List<RoutingEstablishedEvent> RoutingEstablishedEvents { get; set; }



    /// <summary>
    /// Voice - UserEstablished events for this batch
    /// </summary>
    /// <value>Voice - UserEstablished events for this batch</value>
    [JsonPropertyName("userEstablishedEvents")]
    public List<UserEstablishedEvent> UserEstablishedEvents { get; set; }



    /// <summary>
    /// Voice - AudioUpdated events for this batch
    /// </summary>
    /// <value>Voice - AudioUpdated events for this batch</value>
    [JsonPropertyName("audioUpdatedEvents")]
    public List<AudioUpdatedEvent> AudioUpdatedEvents { get; set; }



    /// <summary>
    /// Voice - CommunicationEnded events for this batch
    /// </summary>
    /// <value>Voice - CommunicationEnded events for this batch</value>
    [JsonPropertyName("communicationEndedEvents")]
    public List<CommunicationEndedEvent> CommunicationEndedEvents { get; set; }



    /// <summary>
    /// Voice - ConsultTransfer events for this batch
    /// </summary>
    /// <value>Voice - ConsultTransfer events for this batch</value>
    [JsonPropertyName("consultTransferEvents")]
    public List<ConsultTransferEvent> ConsultTransferEvents { get; set; }



    /// <summary>
    /// Voice - ProgressConsultTransfer events for this batch
    /// </summary>
    /// <value>Voice - ProgressConsultTransfer events for this batch</value>
    [JsonPropertyName("progressConsultTransferEvents")]
    public List<ProgressConsultTransferEvent> ProgressConsultTransferEvents { get; set; }



    /// <summary>
    /// Voice - EndConsultTransfer events for this batch
    /// </summary>
    /// <value>Voice - EndConsultTransfer events for this batch</value>
    [JsonPropertyName("endConsultTransferEvents")]
    public List<EndConsultTransferEvent> EndConsultTransferEvents { get; set; }



    /// <summary>
    /// Email - EmailBeginTransmittingEvent events for this batch
    /// </summary>
    /// <value>Email - EmailBeginTransmittingEvent events for this batch</value>
    [JsonPropertyName("emailBeginTransmittingEvents")]
    public List<EmailBeginTransmittingEvent> EmailBeginTransmittingEvents { get; set; }



    /// <summary>
    /// Email - EmailCommunicationEndedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailCommunicationEndedEvent events for this batch</value>
    [JsonPropertyName("emailCommunicationEndedEvents")]
    public List<EmailCommunicationEndedEvent> EmailCommunicationEndedEvents { get; set; }



    /// <summary>
    /// Email - EmailExternalEstablishedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailExternalEstablishedEvent events for this batch</value>
    [JsonPropertyName("emailExternalEstablishedEvents")]
    public List<EmailExternalEstablishedEvent> EmailExternalEstablishedEvents { get; set; }



    /// <summary>
    /// Email - EmailFlowEstablishedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailFlowEstablishedEvent events for this batch</value>
    [JsonPropertyName("emailFlowEstablishedEvents")]
    public List<EmailFlowEstablishedEvent> EmailFlowEstablishedEvents { get; set; }



    /// <summary>
    /// Email - EmailRoutingEstablishedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailRoutingEstablishedEvent events for this batch</value>
    [JsonPropertyName("emailRoutingEstablishedEvents")]
    public List<EmailRoutingEstablishedEvent> EmailRoutingEstablishedEvents { get; set; }



    /// <summary>
    /// Email - EmailUserEstablishedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailUserEstablishedEvent events for this batch</value>
    [JsonPropertyName("emailUserEstablishedEvents")]
    public List<EmailUserEstablishedEvent> EmailUserEstablishedEvents { get; set; }



    /// <summary>
    /// Email - EmailCommunicationAnsweredEvent events for this batch
    /// </summary>
    /// <value>Email - EmailCommunicationAnsweredEvent events for this batch</value>
    [JsonPropertyName("emailCommunicationAnsweredEvents")]
    public List<EmailCommunicationAnsweredEvent> EmailCommunicationAnsweredEvents { get; set; }



    /// <summary>
    /// Email - EmailCommunicationDispositionAppliedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailCommunicationDispositionAppliedEvent events for this batch</value>
    [JsonPropertyName("emailCommunicationDispositionAppliedEvents")]
    public List<EmailCommunicationDispositionAppliedEvent> EmailCommunicationDispositionAppliedEvents { get; set; }



    /// <summary>
    /// Email - EmailCommunicationSentMessageEvent events for this batch
    /// </summary>
    /// <value>Email - EmailCommunicationSentMessageEvent events for this batch</value>
    [JsonPropertyName("emailCommunicationSentMessageEvents")]
    public List<EmailCommunicationSentMessageEvent> EmailCommunicationSentMessageEvents { get; set; }



    /// <summary>
    /// Email - EmailHoldUpdatedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailHoldUpdatedEvent events for this batch</value>
    [JsonPropertyName("emailHoldUpdatedEvents")]
    public List<EmailHoldUpdatedEvent> EmailHoldUpdatedEvents { get; set; }



    /// <summary>
    /// Email - EmailEndTransferEvent events for this batch
    /// </summary>
    /// <value>Email - EmailEndTransferEvent events for this batch</value>
    [JsonPropertyName("emailEndTransferEvents")]
    public List<EmailEndTransferEvent> EmailEndTransferEvents { get; set; }



    /// <summary>
    /// Email - EmailProgressTransferEvent events for this batch
    /// </summary>
    /// <value>Email - EmailProgressTransferEvent events for this batch</value>
    [JsonPropertyName("emailProgressTransferEvents")]
    public List<EmailProgressTransferEvent> EmailProgressTransferEvents { get; set; }



    /// <summary>
    /// Email - EmailRoutingTransferEvent events for this batch
    /// </summary>
    /// <value>Email - EmailRoutingTransferEvent events for this batch</value>
    [JsonPropertyName("emailRoutingTransferEvents")]
    public List<EmailRoutingTransferEvent> EmailRoutingTransferEvents { get; set; }



    /// <summary>
    /// Email - EmailUserTransferEvent events for this batch
    /// </summary>
    /// <value>Email - EmailUserTransferEvent events for this batch</value>
    [JsonPropertyName("emailUserTransferEvents")]
    public List<EmailUserTransferEvent> EmailUserTransferEvents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BatchConversationEventRequest {\n");

        sb.Append("  EndTransferEvents: ").Append(EndTransferEvents).Append("\n");
        sb.Append("  PhoneTransferEvents: ").Append(PhoneTransferEvents).Append("\n");
        sb.Append("  ProgressTransferEvents: ").Append(ProgressTransferEvents).Append("\n");
        sb.Append("  RoutingTransferEvents: ").Append(RoutingTransferEvents).Append("\n");
        sb.Append("  UserTransferEvents: ").Append(UserTransferEvents).Append("\n");
        sb.Append("  CommunicationAnsweredEvents: ").Append(CommunicationAnsweredEvents).Append("\n");
        sb.Append("  CommunicationDispositionAppliedEvents: ").Append(CommunicationDispositionAppliedEvents).Append("\n");
        sb.Append("  HoldUpdatedEvents: ").Append(HoldUpdatedEvents).Append("\n");
        sb.Append("  ExternalEstablishedEvents: ").Append(ExternalEstablishedEvents).Append("\n");
        sb.Append("  IvrEstablishedEvents: ").Append(IvrEstablishedEvents).Append("\n");
        sb.Append("  PhoneEstablishedEvents: ").Append(PhoneEstablishedEvents).Append("\n");
        sb.Append("  RoutingEstablishedEvents: ").Append(RoutingEstablishedEvents).Append("\n");
        sb.Append("  UserEstablishedEvents: ").Append(UserEstablishedEvents).Append("\n");
        sb.Append("  AudioUpdatedEvents: ").Append(AudioUpdatedEvents).Append("\n");
        sb.Append("  CommunicationEndedEvents: ").Append(CommunicationEndedEvents).Append("\n");
        sb.Append("  ConsultTransferEvents: ").Append(ConsultTransferEvents).Append("\n");
        sb.Append("  ProgressConsultTransferEvents: ").Append(ProgressConsultTransferEvents).Append("\n");
        sb.Append("  EndConsultTransferEvents: ").Append(EndConsultTransferEvents).Append("\n");
        sb.Append("  EmailBeginTransmittingEvents: ").Append(EmailBeginTransmittingEvents).Append("\n");
        sb.Append("  EmailCommunicationEndedEvents: ").Append(EmailCommunicationEndedEvents).Append("\n");
        sb.Append("  EmailExternalEstablishedEvents: ").Append(EmailExternalEstablishedEvents).Append("\n");
        sb.Append("  EmailFlowEstablishedEvents: ").Append(EmailFlowEstablishedEvents).Append("\n");
        sb.Append("  EmailRoutingEstablishedEvents: ").Append(EmailRoutingEstablishedEvents).Append("\n");
        sb.Append("  EmailUserEstablishedEvents: ").Append(EmailUserEstablishedEvents).Append("\n");
        sb.Append("  EmailCommunicationAnsweredEvents: ").Append(EmailCommunicationAnsweredEvents).Append("\n");
        sb.Append("  EmailCommunicationDispositionAppliedEvents: ").Append(EmailCommunicationDispositionAppliedEvents).Append("\n");
        sb.Append("  EmailCommunicationSentMessageEvents: ").Append(EmailCommunicationSentMessageEvents).Append("\n");
        sb.Append("  EmailHoldUpdatedEvents: ").Append(EmailHoldUpdatedEvents).Append("\n");
        sb.Append("  EmailEndTransferEvents: ").Append(EmailEndTransferEvents).Append("\n");
        sb.Append("  EmailProgressTransferEvents: ").Append(EmailProgressTransferEvents).Append("\n");
        sb.Append("  EmailRoutingTransferEvents: ").Append(EmailRoutingTransferEvents).Append("\n");
        sb.Append("  EmailUserTransferEvents: ").Append(EmailUserTransferEvents).Append("\n");
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
        return Equals(obj as BatchConversationEventRequest);
    }

    /// <summary>
    /// Returns true if BatchConversationEventRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BatchConversationEventRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BatchConversationEventRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EndTransferEvents == other.EndTransferEvents ||
                EndTransferEvents != null &&
                EndTransferEvents.SequenceEqual(other.EndTransferEvents)
            ) &&
            (
                PhoneTransferEvents == other.PhoneTransferEvents ||
                PhoneTransferEvents != null &&
                PhoneTransferEvents.SequenceEqual(other.PhoneTransferEvents)
            ) &&
            (
                ProgressTransferEvents == other.ProgressTransferEvents ||
                ProgressTransferEvents != null &&
                ProgressTransferEvents.SequenceEqual(other.ProgressTransferEvents)
            ) &&
            (
                RoutingTransferEvents == other.RoutingTransferEvents ||
                RoutingTransferEvents != null &&
                RoutingTransferEvents.SequenceEqual(other.RoutingTransferEvents)
            ) &&
            (
                UserTransferEvents == other.UserTransferEvents ||
                UserTransferEvents != null &&
                UserTransferEvents.SequenceEqual(other.UserTransferEvents)
            ) &&
            (
                CommunicationAnsweredEvents == other.CommunicationAnsweredEvents ||
                CommunicationAnsweredEvents != null &&
                CommunicationAnsweredEvents.SequenceEqual(other.CommunicationAnsweredEvents)
            ) &&
            (
                CommunicationDispositionAppliedEvents == other.CommunicationDispositionAppliedEvents ||
                CommunicationDispositionAppliedEvents != null &&
                CommunicationDispositionAppliedEvents.SequenceEqual(other.CommunicationDispositionAppliedEvents)
            ) &&
            (
                HoldUpdatedEvents == other.HoldUpdatedEvents ||
                HoldUpdatedEvents != null &&
                HoldUpdatedEvents.SequenceEqual(other.HoldUpdatedEvents)
            ) &&
            (
                ExternalEstablishedEvents == other.ExternalEstablishedEvents ||
                ExternalEstablishedEvents != null &&
                ExternalEstablishedEvents.SequenceEqual(other.ExternalEstablishedEvents)
            ) &&
            (
                IvrEstablishedEvents == other.IvrEstablishedEvents ||
                IvrEstablishedEvents != null &&
                IvrEstablishedEvents.SequenceEqual(other.IvrEstablishedEvents)
            ) &&
            (
                PhoneEstablishedEvents == other.PhoneEstablishedEvents ||
                PhoneEstablishedEvents != null &&
                PhoneEstablishedEvents.SequenceEqual(other.PhoneEstablishedEvents)
            ) &&
            (
                RoutingEstablishedEvents == other.RoutingEstablishedEvents ||
                RoutingEstablishedEvents != null &&
                RoutingEstablishedEvents.SequenceEqual(other.RoutingEstablishedEvents)
            ) &&
            (
                UserEstablishedEvents == other.UserEstablishedEvents ||
                UserEstablishedEvents != null &&
                UserEstablishedEvents.SequenceEqual(other.UserEstablishedEvents)
            ) &&
            (
                AudioUpdatedEvents == other.AudioUpdatedEvents ||
                AudioUpdatedEvents != null &&
                AudioUpdatedEvents.SequenceEqual(other.AudioUpdatedEvents)
            ) &&
            (
                CommunicationEndedEvents == other.CommunicationEndedEvents ||
                CommunicationEndedEvents != null &&
                CommunicationEndedEvents.SequenceEqual(other.CommunicationEndedEvents)
            ) &&
            (
                ConsultTransferEvents == other.ConsultTransferEvents ||
                ConsultTransferEvents != null &&
                ConsultTransferEvents.SequenceEqual(other.ConsultTransferEvents)
            ) &&
            (
                ProgressConsultTransferEvents == other.ProgressConsultTransferEvents ||
                ProgressConsultTransferEvents != null &&
                ProgressConsultTransferEvents.SequenceEqual(other.ProgressConsultTransferEvents)
            ) &&
            (
                EndConsultTransferEvents == other.EndConsultTransferEvents ||
                EndConsultTransferEvents != null &&
                EndConsultTransferEvents.SequenceEqual(other.EndConsultTransferEvents)
            ) &&
            (
                EmailBeginTransmittingEvents == other.EmailBeginTransmittingEvents ||
                EmailBeginTransmittingEvents != null &&
                EmailBeginTransmittingEvents.SequenceEqual(other.EmailBeginTransmittingEvents)
            ) &&
            (
                EmailCommunicationEndedEvents == other.EmailCommunicationEndedEvents ||
                EmailCommunicationEndedEvents != null &&
                EmailCommunicationEndedEvents.SequenceEqual(other.EmailCommunicationEndedEvents)
            ) &&
            (
                EmailExternalEstablishedEvents == other.EmailExternalEstablishedEvents ||
                EmailExternalEstablishedEvents != null &&
                EmailExternalEstablishedEvents.SequenceEqual(other.EmailExternalEstablishedEvents)
            ) &&
            (
                EmailFlowEstablishedEvents == other.EmailFlowEstablishedEvents ||
                EmailFlowEstablishedEvents != null &&
                EmailFlowEstablishedEvents.SequenceEqual(other.EmailFlowEstablishedEvents)
            ) &&
            (
                EmailRoutingEstablishedEvents == other.EmailRoutingEstablishedEvents ||
                EmailRoutingEstablishedEvents != null &&
                EmailRoutingEstablishedEvents.SequenceEqual(other.EmailRoutingEstablishedEvents)
            ) &&
            (
                EmailUserEstablishedEvents == other.EmailUserEstablishedEvents ||
                EmailUserEstablishedEvents != null &&
                EmailUserEstablishedEvents.SequenceEqual(other.EmailUserEstablishedEvents)
            ) &&
            (
                EmailCommunicationAnsweredEvents == other.EmailCommunicationAnsweredEvents ||
                EmailCommunicationAnsweredEvents != null &&
                EmailCommunicationAnsweredEvents.SequenceEqual(other.EmailCommunicationAnsweredEvents)
            ) &&
            (
                EmailCommunicationDispositionAppliedEvents == other.EmailCommunicationDispositionAppliedEvents ||
                EmailCommunicationDispositionAppliedEvents != null &&
                EmailCommunicationDispositionAppliedEvents.SequenceEqual(other.EmailCommunicationDispositionAppliedEvents)
            ) &&
            (
                EmailCommunicationSentMessageEvents == other.EmailCommunicationSentMessageEvents ||
                EmailCommunicationSentMessageEvents != null &&
                EmailCommunicationSentMessageEvents.SequenceEqual(other.EmailCommunicationSentMessageEvents)
            ) &&
            (
                EmailHoldUpdatedEvents == other.EmailHoldUpdatedEvents ||
                EmailHoldUpdatedEvents != null &&
                EmailHoldUpdatedEvents.SequenceEqual(other.EmailHoldUpdatedEvents)
            ) &&
            (
                EmailEndTransferEvents == other.EmailEndTransferEvents ||
                EmailEndTransferEvents != null &&
                EmailEndTransferEvents.SequenceEqual(other.EmailEndTransferEvents)
            ) &&
            (
                EmailProgressTransferEvents == other.EmailProgressTransferEvents ||
                EmailProgressTransferEvents != null &&
                EmailProgressTransferEvents.SequenceEqual(other.EmailProgressTransferEvents)
            ) &&
            (
                EmailRoutingTransferEvents == other.EmailRoutingTransferEvents ||
                EmailRoutingTransferEvents != null &&
                EmailRoutingTransferEvents.SequenceEqual(other.EmailRoutingTransferEvents)
            ) &&
            (
                EmailUserTransferEvents == other.EmailUserTransferEvents ||
                EmailUserTransferEvents != null &&
                EmailUserTransferEvents.SequenceEqual(other.EmailUserTransferEvents)
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
            if (EndTransferEvents != null)
            {
                hash = hash * 59 + EndTransferEvents.GetHashCode();
            }

            if (PhoneTransferEvents != null)
            {
                hash = hash * 59 + PhoneTransferEvents.GetHashCode();
            }

            if (ProgressTransferEvents != null)
            {
                hash = hash * 59 + ProgressTransferEvents.GetHashCode();
            }

            if (RoutingTransferEvents != null)
            {
                hash = hash * 59 + RoutingTransferEvents.GetHashCode();
            }

            if (UserTransferEvents != null)
            {
                hash = hash * 59 + UserTransferEvents.GetHashCode();
            }

            if (CommunicationAnsweredEvents != null)
            {
                hash = hash * 59 + CommunicationAnsweredEvents.GetHashCode();
            }

            if (CommunicationDispositionAppliedEvents != null)
            {
                hash = hash * 59 + CommunicationDispositionAppliedEvents.GetHashCode();
            }

            if (HoldUpdatedEvents != null)
            {
                hash = hash * 59 + HoldUpdatedEvents.GetHashCode();
            }

            if (ExternalEstablishedEvents != null)
            {
                hash = hash * 59 + ExternalEstablishedEvents.GetHashCode();
            }

            if (IvrEstablishedEvents != null)
            {
                hash = hash * 59 + IvrEstablishedEvents.GetHashCode();
            }

            if (PhoneEstablishedEvents != null)
            {
                hash = hash * 59 + PhoneEstablishedEvents.GetHashCode();
            }

            if (RoutingEstablishedEvents != null)
            {
                hash = hash * 59 + RoutingEstablishedEvents.GetHashCode();
            }

            if (UserEstablishedEvents != null)
            {
                hash = hash * 59 + UserEstablishedEvents.GetHashCode();
            }

            if (AudioUpdatedEvents != null)
            {
                hash = hash * 59 + AudioUpdatedEvents.GetHashCode();
            }

            if (CommunicationEndedEvents != null)
            {
                hash = hash * 59 + CommunicationEndedEvents.GetHashCode();
            }

            if (ConsultTransferEvents != null)
            {
                hash = hash * 59 + ConsultTransferEvents.GetHashCode();
            }

            if (ProgressConsultTransferEvents != null)
            {
                hash = hash * 59 + ProgressConsultTransferEvents.GetHashCode();
            }

            if (EndConsultTransferEvents != null)
            {
                hash = hash * 59 + EndConsultTransferEvents.GetHashCode();
            }

            if (EmailBeginTransmittingEvents != null)
            {
                hash = hash * 59 + EmailBeginTransmittingEvents.GetHashCode();
            }

            if (EmailCommunicationEndedEvents != null)
            {
                hash = hash * 59 + EmailCommunicationEndedEvents.GetHashCode();
            }

            if (EmailExternalEstablishedEvents != null)
            {
                hash = hash * 59 + EmailExternalEstablishedEvents.GetHashCode();
            }

            if (EmailFlowEstablishedEvents != null)
            {
                hash = hash * 59 + EmailFlowEstablishedEvents.GetHashCode();
            }

            if (EmailRoutingEstablishedEvents != null)
            {
                hash = hash * 59 + EmailRoutingEstablishedEvents.GetHashCode();
            }

            if (EmailUserEstablishedEvents != null)
            {
                hash = hash * 59 + EmailUserEstablishedEvents.GetHashCode();
            }

            if (EmailCommunicationAnsweredEvents != null)
            {
                hash = hash * 59 + EmailCommunicationAnsweredEvents.GetHashCode();
            }

            if (EmailCommunicationDispositionAppliedEvents != null)
            {
                hash = hash * 59 + EmailCommunicationDispositionAppliedEvents.GetHashCode();
            }

            if (EmailCommunicationSentMessageEvents != null)
            {
                hash = hash * 59 + EmailCommunicationSentMessageEvents.GetHashCode();
            }

            if (EmailHoldUpdatedEvents != null)
            {
                hash = hash * 59 + EmailHoldUpdatedEvents.GetHashCode();
            }

            if (EmailEndTransferEvents != null)
            {
                hash = hash * 59 + EmailEndTransferEvents.GetHashCode();
            }

            if (EmailProgressTransferEvents != null)
            {
                hash = hash * 59 + EmailProgressTransferEvents.GetHashCode();
            }

            if (EmailRoutingTransferEvents != null)
            {
                hash = hash * 59 + EmailRoutingTransferEvents.GetHashCode();
            }

            if (EmailUserTransferEvents != null)
            {
                hash = hash * 59 + EmailUserTransferEvents.GetHashCode();
            }

            return hash;
        }
    }
}
