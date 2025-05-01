using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SIPSearchPublicRequest
/// </summary>
[DataContract]
public partial class SIPSearchPublicRequest : IEquatable<SIPSearchPublicRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SIPSearchPublicRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SIPSearchPublicRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SIPSearchPublicRequest" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="CallId">unique identification of the placed call.</param>
    /// <param name="ToUser">SIP user to who the call was placed.</param>
    /// <param name="FromUser">SIP user who placed the call.</param>
    /// <param name="ConversationId">Unique identification of the conversation.</param>
    /// <param name="ParticipantId">Unique identification of the participant.</param>
    /// <param name="DateStart">Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="DateEnd">End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public SIPSearchPublicRequest(string Name = null, string CallId = null, string ToUser = null, string FromUser = null, string ConversationId = null, string ParticipantId = null, DateTime? DateStart = null, DateTime? DateEnd = null)
    {
        this.Name = Name;
        this.CallId = CallId;
        this.ToUser = ToUser;
        this.FromUser = FromUser;
        this.ConversationId = ConversationId;
        this.ParticipantId = ParticipantId;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;

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
    /// unique identification of the placed call
    /// </summary>
    /// <value>unique identification of the placed call</value>
    [DataMember(Name = "callId", EmitDefaultValue = false)]
    public string CallId { get; set; }



    /// <summary>
    /// SIP user to who the call was placed
    /// </summary>
    /// <value>SIP user to who the call was placed</value>
    [DataMember(Name = "toUser", EmitDefaultValue = false)]
    public string ToUser { get; set; }



    /// <summary>
    /// SIP user who placed the call
    /// </summary>
    /// <value>SIP user who placed the call</value>
    [DataMember(Name = "fromUser", EmitDefaultValue = false)]
    public string FromUser { get; set; }



    /// <summary>
    /// Unique identification of the conversation
    /// </summary>
    /// <value>Unique identification of the conversation</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Unique identification of the participant
    /// </summary>
    /// <value>Unique identification of the participant</value>
    [DataMember(Name = "participantId", EmitDefaultValue = false)]
    public string ParticipantId { get; set; }



    /// <summary>
    /// Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateStart", EmitDefaultValue = false)]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>End date of the search. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateEnd", EmitDefaultValue = false)]
    public DateTime? DateEnd { get; set; }



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
        sb.Append("class SIPSearchPublicRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  CallId: ").Append(CallId).Append("\n");
        sb.Append("  ToUser: ").Append(ToUser).Append("\n");
        sb.Append("  FromUser: ").Append(FromUser).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
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
        return Equals(obj as SIPSearchPublicRequest);
    }

    /// <summary>
    /// Returns true if SIPSearchPublicRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SIPSearchPublicRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SIPSearchPublicRequest other)
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
                CallId == other.CallId ||
                CallId != null &&
                CallId.Equals(other.CallId)
            ) &&
            (
                ToUser == other.ToUser ||
                ToUser != null &&
                ToUser.Equals(other.ToUser)
            ) &&
            (
                FromUser == other.FromUser ||
                FromUser != null &&
                FromUser.Equals(other.FromUser)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                ParticipantId == other.ParticipantId ||
                ParticipantId != null &&
                ParticipantId.Equals(other.ParticipantId)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
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

            if (CallId != null)
            {
                hash = hash * 59 + CallId.GetHashCode();
            }

            if (ToUser != null)
            {
                hash = hash * 59 + ToUser.GetHashCode();
            }

            if (FromUser != null)
            {
                hash = hash * 59 + FromUser.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ParticipantId != null)
            {
                hash = hash * 59 + ParticipantId.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
