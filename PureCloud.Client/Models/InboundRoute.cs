using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InboundRoute
/// </summary>
[DataContract]
public partial class InboundRoute : IEquatable<InboundRoute>
{
    /// <summary>
    /// The configuration to indicate how the history of a conversation has to be included in a draft
    /// </summary>
    /// <value>The configuration to indicate how the history of a conversation has to be included in a draft</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HistoryInclusionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Include for "Include"
        /// </summary>
        [EnumMember(Value = "Include")]
        Include,

        /// <summary>
        /// Enum Exclude for "Exclude"
        /// </summary>
        [EnumMember(Value = "Exclude")]
        Exclude,

        /// <summary>
        /// Enum Optional for "Optional"
        /// </summary>
        [EnumMember(Value = "Optional")]
        Optional
    }
    /// <summary>
    /// The configuration to indicate how the history of a conversation has to be included in a draft
    /// </summary>
    /// <value>The configuration to indicate how the history of a conversation has to be included in a draft</value>
    [DataMember(Name = "historyInclusion", EmitDefaultValue = false)]
    public HistoryInclusionEnum? HistoryInclusion { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="InboundRoute" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected InboundRoute() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InboundRoute" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Pattern">The search pattern that the mailbox name should match. (required).</param>
    /// <param name="Queue">The queue to route the emails to..</param>
    /// <param name="Priority">The priority to use for routing..</param>
    /// <param name="Skills">The skills to use for routing..</param>
    /// <param name="Language">The language to use for routing..</param>
    /// <param name="FromName">The sender name to use for outgoing replies. (required).</param>
    /// <param name="FromEmail">The sender email to use for outgoing replies..</param>
    /// <param name="Flow">The flow to use for processing the email..</param>
    /// <param name="ReplyEmailAddress">The route to use for email replies..</param>
    /// <param name="AutoBcc">The recipients that should be automatically blind copied on outbound emails associated with this InboundRoute..</param>
    /// <param name="SpamFlow">The flow to use for processing inbound emails that have been marked as spam..</param>
    /// <param name="Signature">The configuration for the canned response signature that will be appended to outbound emails sent via this route.</param>
    /// <param name="HistoryInclusion">The configuration to indicate how the history of a conversation has to be included in a draft.</param>
    /// <param name="AllowMultipleActions">Control if multiple actions are allowed on this route. When true the disconnect has to be done manually. When false a conversation will be disconnected by the system after every action.</param>
    public InboundRoute(string Name = null, string Pattern = null, DomainEntityRef Queue = null, int? Priority = null, List<DomainEntityRef> Skills = null, DomainEntityRef Language = null, string FromName = null, string FromEmail = null, DomainEntityRef Flow = null, QueueEmailAddress ReplyEmailAddress = null, List<EmailAddress> AutoBcc = null, DomainEntityRef SpamFlow = null, Signature Signature = null, HistoryInclusionEnum? HistoryInclusion = null, bool? AllowMultipleActions = null)
    {
        this.Name = Name;
        this.Pattern = Pattern;
        this.Queue = Queue;
        this.Priority = Priority;
        this.Skills = Skills;
        this.Language = Language;
        this.FromName = FromName;
        this.FromEmail = FromEmail;
        this.Flow = Flow;
        this.ReplyEmailAddress = ReplyEmailAddress;
        this.AutoBcc = AutoBcc;
        this.SpamFlow = SpamFlow;
        this.Signature = Signature;
        this.HistoryInclusion = HistoryInclusion;
        this.AllowMultipleActions = AllowMultipleActions;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The search pattern that the mailbox name should match.
    /// </summary>
    /// <value>The search pattern that the mailbox name should match.</value>
    [DataMember(Name = "pattern", EmitDefaultValue = false)]
    public string Pattern { get; set; }



    /// <summary>
    /// The queue to route the emails to.
    /// </summary>
    /// <value>The queue to route the emails to.</value>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public DomainEntityRef Queue { get; set; }



    /// <summary>
    /// The priority to use for routing.
    /// </summary>
    /// <value>The priority to use for routing.</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public int? Priority { get; set; }



    /// <summary>
    /// The skills to use for routing.
    /// </summary>
    /// <value>The skills to use for routing.</value>
    [DataMember(Name = "skills", EmitDefaultValue = false)]
    public List<DomainEntityRef> Skills { get; set; }



    /// <summary>
    /// The language to use for routing.
    /// </summary>
    /// <value>The language to use for routing.</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public DomainEntityRef Language { get; set; }



    /// <summary>
    /// The sender name to use for outgoing replies.
    /// </summary>
    /// <value>The sender name to use for outgoing replies.</value>
    [DataMember(Name = "fromName", EmitDefaultValue = false)]
    public string FromName { get; set; }



    /// <summary>
    /// The sender email to use for outgoing replies.
    /// </summary>
    /// <value>The sender email to use for outgoing replies.</value>
    [DataMember(Name = "fromEmail", EmitDefaultValue = false)]
    public string FromEmail { get; set; }



    /// <summary>
    /// The flow to use for processing the email.
    /// </summary>
    /// <value>The flow to use for processing the email.</value>
    [DataMember(Name = "flow", EmitDefaultValue = false)]
    public DomainEntityRef Flow { get; set; }



    /// <summary>
    /// The route to use for email replies.
    /// </summary>
    /// <value>The route to use for email replies.</value>
    [DataMember(Name = "replyEmailAddress", EmitDefaultValue = false)]
    public QueueEmailAddress ReplyEmailAddress { get; set; }



    /// <summary>
    /// The recipients that should be automatically blind copied on outbound emails associated with this InboundRoute.
    /// </summary>
    /// <value>The recipients that should be automatically blind copied on outbound emails associated with this InboundRoute.</value>
    [DataMember(Name = "autoBcc", EmitDefaultValue = false)]
    public List<EmailAddress> AutoBcc { get; set; }



    /// <summary>
    /// The flow to use for processing inbound emails that have been marked as spam.
    /// </summary>
    /// <value>The flow to use for processing inbound emails that have been marked as spam.</value>
    [DataMember(Name = "spamFlow", EmitDefaultValue = false)]
    public DomainEntityRef SpamFlow { get; set; }



    /// <summary>
    /// The configuration for the canned response signature that will be appended to outbound emails sent via this route
    /// </summary>
    /// <value>The configuration for the canned response signature that will be appended to outbound emails sent via this route</value>
    [DataMember(Name = "signature", EmitDefaultValue = false)]
    public Signature Signature { get; set; }





    /// <summary>
    /// Control if multiple actions are allowed on this route. When true the disconnect has to be done manually. When false a conversation will be disconnected by the system after every action
    /// </summary>
    /// <value>Control if multiple actions are allowed on this route. When true the disconnect has to be done manually. When false a conversation will be disconnected by the system after every action</value>
    [DataMember(Name = "allowMultipleActions", EmitDefaultValue = false)]
    public bool? AllowMultipleActions { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InboundRoute {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Pattern: ").Append(Pattern).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  FromName: ").Append(FromName).Append("\n");
        sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  ReplyEmailAddress: ").Append(ReplyEmailAddress).Append("\n");
        sb.Append("  AutoBcc: ").Append(AutoBcc).Append("\n");
        sb.Append("  SpamFlow: ").Append(SpamFlow).Append("\n");
        sb.Append("  Signature: ").Append(Signature).Append("\n");
        sb.Append("  HistoryInclusion: ").Append(HistoryInclusion).Append("\n");
        sb.Append("  AllowMultipleActions: ").Append(AllowMultipleActions).Append("\n");
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
        return Equals(obj as InboundRoute);
    }

    /// <summary>
    /// Returns true if InboundRoute instances are equal
    /// </summary>
    /// <param name="other">Instance of InboundRoute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InboundRoute other)
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
                Pattern == other.Pattern ||
                Pattern != null &&
                Pattern.Equals(other.Pattern)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                Skills == other.Skills ||
                Skills != null &&
                Skills.SequenceEqual(other.Skills)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                FromName == other.FromName ||
                FromName != null &&
                FromName.Equals(other.FromName)
            ) &&
            (
                FromEmail == other.FromEmail ||
                FromEmail != null &&
                FromEmail.Equals(other.FromEmail)
            ) &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                ReplyEmailAddress == other.ReplyEmailAddress ||
                ReplyEmailAddress != null &&
                ReplyEmailAddress.Equals(other.ReplyEmailAddress)
            ) &&
            (
                AutoBcc == other.AutoBcc ||
                AutoBcc != null &&
                AutoBcc.SequenceEqual(other.AutoBcc)
            ) &&
            (
                SpamFlow == other.SpamFlow ||
                SpamFlow != null &&
                SpamFlow.Equals(other.SpamFlow)
            ) &&
            (
                Signature == other.Signature ||
                Signature != null &&
                Signature.Equals(other.Signature)
            ) &&
            (
                HistoryInclusion == other.HistoryInclusion ||
                HistoryInclusion != null &&
                HistoryInclusion.Equals(other.HistoryInclusion)
            ) &&
            (
                AllowMultipleActions == other.AllowMultipleActions ||
                AllowMultipleActions != null &&
                AllowMultipleActions.Equals(other.AllowMultipleActions)
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

            if (Pattern != null)
            {
                hash = hash * 59 + Pattern.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (Skills != null)
            {
                hash = hash * 59 + Skills.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (FromName != null)
            {
                hash = hash * 59 + FromName.GetHashCode();
            }

            if (FromEmail != null)
            {
                hash = hash * 59 + FromEmail.GetHashCode();
            }

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (ReplyEmailAddress != null)
            {
                hash = hash * 59 + ReplyEmailAddress.GetHashCode();
            }

            if (AutoBcc != null)
            {
                hash = hash * 59 + AutoBcc.GetHashCode();
            }

            if (SpamFlow != null)
            {
                hash = hash * 59 + SpamFlow.GetHashCode();
            }

            if (Signature != null)
            {
                hash = hash * 59 + Signature.GetHashCode();
            }

            if (HistoryInclusion != null)
            {
                hash = hash * 59 + HistoryInclusion.GetHashCode();
            }

            if (AllowMultipleActions != null)
            {
                hash = hash * 59 + AllowMultipleActions.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
