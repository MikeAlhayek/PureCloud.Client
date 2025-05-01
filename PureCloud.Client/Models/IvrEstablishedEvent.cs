using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// IvrEstablishedEvent
/// </summary>
[DataContract]
public partial class IvrEstablishedEvent : IEquatable<IvrEstablishedEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="IvrEstablishedEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected IvrEstablishedEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IvrEstablishedEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication (required).</param>
    /// <param name="IvrPhoneNumber">The phone number for this IVR, if any is known.</param>
    /// <param name="IvrName">A displayable name for this IVR, if any is known..</param>
    /// <param name="Ani">The automatic number identification if it is available for this conversation..</param>
    /// <param name="Dnis">The dialed number identification if it is available for this conversation..</param>
    /// <param name="InitialConfiguration">Metadata about this communication. (required).</param>
    /// <param name="SourceConfiguration">Metadata about the source of this communication&#39;s interaction. (required).</param>
    public IvrEstablishedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string IvrPhoneNumber = null, string IvrName = null, string Ani = null, string Dnis = null, InitialConfiguration InitialConfiguration = null, SourceConfiguration SourceConfiguration = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.CommunicationId = CommunicationId;
        this.IvrPhoneNumber = IvrPhoneNumber;
        this.IvrName = IvrName;
        this.Ani = Ani;
        this.Dnis = Dnis;
        this.InitialConfiguration = InitialConfiguration;
        this.SourceConfiguration = SourceConfiguration;

    }



    /// <summary>
    /// A unique (V4 UUID) eventId for this event
    /// </summary>
    /// <value>A unique (V4 UUID) eventId for this event</value>
    [DataMember(Name = "eventId", EmitDefaultValue = false)]
    public string EventId { get; set; }



    /// <summary>
    /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "eventDateTime", EmitDefaultValue = false)]
    public DateTime? EventDateTime { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this communication
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this communication</value>
    [DataMember(Name = "communicationId", EmitDefaultValue = false)]
    public string CommunicationId { get; set; }



    /// <summary>
    /// The phone number for this IVR, if any is known
    /// </summary>
    /// <value>The phone number for this IVR, if any is known</value>
    [DataMember(Name = "ivrPhoneNumber", EmitDefaultValue = false)]
    public string IvrPhoneNumber { get; set; }



    /// <summary>
    /// A displayable name for this IVR, if any is known.
    /// </summary>
    /// <value>A displayable name for this IVR, if any is known.</value>
    [DataMember(Name = "ivrName", EmitDefaultValue = false)]
    public string IvrName { get; set; }



    /// <summary>
    /// The automatic number identification if it is available for this conversation.
    /// </summary>
    /// <value>The automatic number identification if it is available for this conversation.</value>
    [DataMember(Name = "ani", EmitDefaultValue = false)]
    public string Ani { get; set; }



    /// <summary>
    /// The dialed number identification if it is available for this conversation.
    /// </summary>
    /// <value>The dialed number identification if it is available for this conversation.</value>
    [DataMember(Name = "dnis", EmitDefaultValue = false)]
    public string Dnis { get; set; }



    /// <summary>
    /// Metadata about this communication.
    /// </summary>
    /// <value>Metadata about this communication.</value>
    [DataMember(Name = "initialConfiguration", EmitDefaultValue = false)]
    public InitialConfiguration InitialConfiguration { get; set; }



    /// <summary>
    /// Metadata about the source of this communication&#39;s interaction.
    /// </summary>
    /// <value>Metadata about the source of this communication&#39;s interaction.</value>
    [DataMember(Name = "sourceConfiguration", EmitDefaultValue = false)]
    public SourceConfiguration SourceConfiguration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IvrEstablishedEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  IvrPhoneNumber: ").Append(IvrPhoneNumber).Append("\n");
        sb.Append("  IvrName: ").Append(IvrName).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  InitialConfiguration: ").Append(InitialConfiguration).Append("\n");
        sb.Append("  SourceConfiguration: ").Append(SourceConfiguration).Append("\n");
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
        return Equals(obj as IvrEstablishedEvent);
    }

    /// <summary>
    /// Returns true if IvrEstablishedEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of IvrEstablishedEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IvrEstablishedEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventId == other.EventId ||
                EventId != null &&
                EventId.Equals(other.EventId)
            ) &&
            (
                EventDateTime == other.EventDateTime ||
                EventDateTime != null &&
                EventDateTime.Equals(other.EventDateTime)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                CommunicationId == other.CommunicationId ||
                CommunicationId != null &&
                CommunicationId.Equals(other.CommunicationId)
            ) &&
            (
                IvrPhoneNumber == other.IvrPhoneNumber ||
                IvrPhoneNumber != null &&
                IvrPhoneNumber.Equals(other.IvrPhoneNumber)
            ) &&
            (
                IvrName == other.IvrName ||
                IvrName != null &&
                IvrName.Equals(other.IvrName)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                InitialConfiguration == other.InitialConfiguration ||
                InitialConfiguration != null &&
                InitialConfiguration.Equals(other.InitialConfiguration)
            ) &&
            (
                SourceConfiguration == other.SourceConfiguration ||
                SourceConfiguration != null &&
                SourceConfiguration.Equals(other.SourceConfiguration)
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
            if (EventId != null)
            {
                hash = hash * 59 + EventId.GetHashCode();
            }

            if (EventDateTime != null)
            {
                hash = hash * 59 + EventDateTime.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (IvrPhoneNumber != null)
            {
                hash = hash * 59 + IvrPhoneNumber.GetHashCode();
            }

            if (IvrName != null)
            {
                hash = hash * 59 + IvrName.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (InitialConfiguration != null)
            {
                hash = hash * 59 + InitialConfiguration.GetHashCode();
            }

            if (SourceConfiguration != null)
            {
                hash = hash * 59 + SourceConfiguration.GetHashCode();
            }

            return hash;
        }
    }
}
