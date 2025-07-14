using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BatchConversationEventRequest
{
    /// <summary>
    /// Voice - EndTransfer events for this batch
    /// </summary>
    /// <value>Voice - EndTransfer events for this batch</value>
    public IEnumerable<EndTransferEvent> EndTransferEvents { get; set; }

    /// <summary>
    /// Voice - PhoneTransfer events for this batch
    /// </summary>
    /// <value>Voice - PhoneTransfer events for this batch</value>
    public IEnumerable<PhoneTransferEvent> PhoneTransferEvents { get; set; }

    /// <summary>
    /// Voice - ProgressTransfer events for this batch
    /// </summary>
    /// <value>Voice - ProgressTransfer events for this batch</value>
    public IEnumerable<ProgressTransferEvent> ProgressTransferEvents { get; set; }

    /// <summary>
    /// Voice - RoutingTransfer events for this batch
    /// </summary>
    /// <value>Voice - RoutingTransfer events for this batch</value>
    public IEnumerable<RoutingTransferEvent> RoutingTransferEvents { get; set; }

    /// <summary>
    /// Voice - UserTransfer events for this batch
    /// </summary>
    /// <value>Voice - UserTransfer events for this batch</value>
    public IEnumerable<UserTransferEvent> UserTransferEvents { get; set; }

    /// <summary>
    /// Voice - CommunicationAnswered events for this batch
    /// </summary>
    /// <value>Voice - CommunicationAnswered events for this batch</value>
    public IEnumerable<CommunicationAnsweredEvent> CommunicationAnsweredEvents { get; set; }

    /// <summary>
    /// Voice - CommunicationDispositionApplied events for this batch
    /// </summary>
    /// <value>Voice - CommunicationDispositionApplied events for this batch</value>
    public IEnumerable<CommunicationDispositionAppliedEvent> CommunicationDispositionAppliedEvents { get; set; }

    /// <summary>
    /// Voice - HoldUpdated events for this batch
    /// </summary>
    /// <value>Voice - HoldUpdated events for this batch</value>
    public IEnumerable<HoldUpdatedEvent> HoldUpdatedEvents { get; set; }

    /// <summary>
    /// Voice - ExternalEstablished events for this batch
    /// </summary>
    /// <value>Voice - ExternalEstablished events for this batch</value>
    public IEnumerable<ExternalEstablishedEvent> ExternalEstablishedEvents { get; set; }

    /// <summary>
    /// Voice - IvrEstablished events for this batch
    /// </summary>
    /// <value>Voice - IvrEstablished events for this batch</value>
    public IEnumerable<IvrEstablishedEvent> IvrEstablishedEvents { get; set; }

    /// <summary>
    /// Voice - PhoneEstablished events for this batch
    /// </summary>
    /// <value>Voice - PhoneEstablished events for this batch</value>
    public IEnumerable<PhoneEstablishedEvent> PhoneEstablishedEvents { get; set; }

    /// <summary>
    /// Voice - RoutingEstablished events for this batch
    /// </summary>
    /// <value>Voice - RoutingEstablished events for this batch</value>
    public IEnumerable<RoutingEstablishedEvent> RoutingEstablishedEvents { get; set; }

    /// <summary>
    /// Voice - UserEstablished events for this batch
    /// </summary>
    /// <value>Voice - UserEstablished events for this batch</value>
    public IEnumerable<UserEstablishedEvent> UserEstablishedEvents { get; set; }

    /// <summary>
    /// Voice - AudioUpdated events for this batch
    /// </summary>
    /// <value>Voice - AudioUpdated events for this batch</value>
    public IEnumerable<AudioUpdatedEvent> AudioUpdatedEvents { get; set; }

    /// <summary>
    /// Voice - CommunicationEnded events for this batch
    /// </summary>
    /// <value>Voice - CommunicationEnded events for this batch</value>
    public IEnumerable<CommunicationEndedEvent> CommunicationEndedEvents { get; set; }

    /// <summary>
    /// Voice - ConsultTransfer events for this batch
    /// </summary>
    /// <value>Voice - ConsultTransfer events for this batch</value>
    public IEnumerable<ConsultTransferEvent> ConsultTransferEvents { get; set; }

    /// <summary>
    /// Voice - ProgressConsultTransfer events for this batch
    /// </summary>
    /// <value>Voice - ProgressConsultTransfer events for this batch</value>
    public IEnumerable<ProgressConsultTransferEvent> ProgressConsultTransferEvents { get; set; }

    /// <summary>
    /// Voice - EndConsultTransfer events for this batch
    /// </summary>
    /// <value>Voice - EndConsultTransfer events for this batch</value>
    public IEnumerable<EndConsultTransferEvent> EndConsultTransferEvents { get; set; }

    /// <summary>
    /// Email - EmailBeginTransmittingEvent events for this batch
    /// </summary>
    /// <value>Email - EmailBeginTransmittingEvent events for this batch</value>
    public IEnumerable<EmailBeginTransmittingEvent> EmailBeginTransmittingEvents { get; set; }

    /// <summary>
    /// Email - EmailCommunicationEndedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailCommunicationEndedEvent events for this batch</value>
    public IEnumerable<EmailCommunicationEndedEvent> EmailCommunicationEndedEvents { get; set; }

    /// <summary>
    /// Email - EmailExternalEstablishedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailExternalEstablishedEvent events for this batch</value>
    public IEnumerable<EmailExternalEstablishedEvent> EmailExternalEstablishedEvents { get; set; }

    /// <summary>
    /// Email - EmailFlowEstablishedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailFlowEstablishedEvent events for this batch</value>
    public IEnumerable<EmailFlowEstablishedEvent> EmailFlowEstablishedEvents { get; set; }

    /// <summary>
    /// Email - EmailRoutingEstablishedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailRoutingEstablishedEvent events for this batch</value>
    public IEnumerable<EmailRoutingEstablishedEvent> EmailRoutingEstablishedEvents { get; set; }

    /// <summary>
    /// Email - EmailUserEstablishedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailUserEstablishedEvent events for this batch</value>
    public IEnumerable<EmailUserEstablishedEvent> EmailUserEstablishedEvents { get; set; }

    /// <summary>
    /// Email - EmailCommunicationAnsweredEvent events for this batch
    /// </summary>
    /// <value>Email - EmailCommunicationAnsweredEvent events for this batch</value>
    public IEnumerable<EmailCommunicationAnsweredEvent> EmailCommunicationAnsweredEvents { get; set; }

    /// <summary>
    /// Email - EmailCommunicationDispositionAppliedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailCommunicationDispositionAppliedEvent events for this batch</value>
    public IEnumerable<EmailCommunicationDispositionAppliedEvent> EmailCommunicationDispositionAppliedEvents { get; set; }

    /// <summary>
    /// Email - EmailCommunicationSentMessageEvent events for this batch
    /// </summary>
    /// <value>Email - EmailCommunicationSentMessageEvent events for this batch</value>
    public IEnumerable<EmailCommunicationSentMessageEvent> EmailCommunicationSentMessageEvents { get; set; }

    /// <summary>
    /// Email - EmailHoldUpdatedEvent events for this batch
    /// </summary>
    /// <value>Email - EmailHoldUpdatedEvent events for this batch</value>
    public IEnumerable<EmailHoldUpdatedEvent> EmailHoldUpdatedEvents { get; set; }

    /// <summary>
    /// Email - EmailEndTransferEvent events for this batch
    /// </summary>
    /// <value>Email - EmailEndTransferEvent events for this batch</value>
    public IEnumerable<EmailEndTransferEvent> EmailEndTransferEvents { get; set; }

    /// <summary>
    /// Email - EmailProgressTransferEvent events for this batch
    /// </summary>
    /// <value>Email - EmailProgressTransferEvent events for this batch</value>
    public IEnumerable<EmailProgressTransferEvent> EmailProgressTransferEvents { get; set; }

    /// <summary>
    /// Email - EmailRoutingTransferEvent events for this batch
    /// </summary>
    /// <value>Email - EmailRoutingTransferEvent events for this batch</value>
    public IEnumerable<EmailRoutingTransferEvent> EmailRoutingTransferEvents { get; set; }

    /// <summary>
    /// Email - EmailUserTransferEvent events for this batch
    /// </summary>
    /// <value>Email - EmailUserTransferEvent events for this batch</value>
    public IEnumerable<EmailUserTransferEvent> EmailUserTransferEvents { get; set; }
}
