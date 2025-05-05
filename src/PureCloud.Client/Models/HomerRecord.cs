using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HomerRecord
/// </summary>

public partial class HomerRecord : IEquatable<HomerRecord>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HomerRecord" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Date">metadata associated to the SIP calls. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="MilliTs">metadata associated to the SIP calls.</param>
    /// <param name="MicroTs">metadata associated to the SIP calls.</param>
    /// <param name="Method">metadata associated to the SIP calls.</param>
    /// <param name="ReplyReason">metadata associated to the SIP calls.</param>
    /// <param name="Ruri">metadata associated to the SIP calls.</param>
    /// <param name="RuriUser">metadata associated to the SIP calls.</param>
    /// <param name="RuriDomain">metadata associated to the SIP calls.</param>
    /// <param name="FromUser">metadata associated to the SIP calls.</param>
    /// <param name="FromDomain">metadata associated to the SIP calls.</param>
    /// <param name="FromTag">metadata associated to the SIP calls.</param>
    /// <param name="ToUser">metadata associated to the SIP calls.</param>
    /// <param name="ToDomain">metadata associated to the SIP calls.</param>
    /// <param name="ToTag">metadata associated to the SIP calls.</param>
    /// <param name="PidUser">metadata associated to the SIP calls.</param>
    /// <param name="ContactUser">metadata associated to the SIP calls.</param>
    /// <param name="AuthUser">metadata associated to the SIP calls.</param>
    /// <param name="Callid">metadata associated to the SIP calls.</param>
    /// <param name="CallidAleg">metadata associated to the SIP calls.</param>
    /// <param name="Via1">metadata associated to the SIP calls.</param>
    /// <param name="Via1Branch">metadata associated to the SIP calls.</param>
    /// <param name="Cseq">metadata associated to the SIP calls.</param>
    /// <param name="Diversion">metadata associated to the SIP calls.</param>
    /// <param name="Reason">metadata associated to the SIP calls.</param>
    /// <param name="ContentType">metadata associated to the SIP calls.</param>
    /// <param name="Auth">metadata associated to the SIP calls.</param>
    /// <param name="UserAgent">metadata associated to the SIP calls.</param>
    /// <param name="SourceIp">metadata associated to the SIP calls.</param>
    /// <param name="SourcePort">metadata associated to the SIP calls.</param>
    /// <param name="DestinationIp">metadata associated to the SIP calls.</param>
    /// <param name="DestinationPort">metadata associated to the SIP calls.</param>
    /// <param name="ContactIp">metadata associated to the SIP calls.</param>
    /// <param name="ContactPort">metadata associated to the SIP calls.</param>
    /// <param name="OriginatorIp">metadata associated to the SIP calls.</param>
    /// <param name="OriginatorPort">metadata associated to the SIP calls.</param>
    /// <param name="CorrelationId">metadata associated to the SIP calls.</param>
    /// <param name="Proto">metadata associated to the SIP calls.</param>
    /// <param name="Family">metadata associated to the SIP calls.</param>
    /// <param name="RtpStat">metadata associated to the SIP calls.</param>
    /// <param name="Type">metadata associated to the SIP calls.</param>
    /// <param name="Node">metadata associated to the SIP calls.</param>
    /// <param name="Trans">metadata associated to the SIP calls.</param>
    /// <param name="Dbnode">metadata associated to the SIP calls.</param>
    /// <param name="Msg">metadata associated to the SIP calls.</param>
    /// <param name="SourceAlias">metadata associated to the SIP calls.</param>
    /// <param name="DestinationAlias">metadata associated to the SIP calls.</param>
    /// <param name="ConversationId">metadata associated to the SIP calls.</param>
    /// <param name="ParticipantId">metadata associated to the SIP calls.</param>
    public HomerRecord(string Name = null, DateTime? Date = null, string MilliTs = null, string MicroTs = null, string Method = null, string ReplyReason = null, string Ruri = null, string RuriUser = null, string RuriDomain = null, string FromUser = null, string FromDomain = null, string FromTag = null, string ToUser = null, string ToDomain = null, string ToTag = null, string PidUser = null, string ContactUser = null, string AuthUser = null, string Callid = null, string CallidAleg = null, string Via1 = null, string Via1Branch = null, string Cseq = null, string Diversion = null, string Reason = null, string ContentType = null, string Auth = null, string UserAgent = null, string SourceIp = null, string SourcePort = null, string DestinationIp = null, string DestinationPort = null, string ContactIp = null, string ContactPort = null, string OriginatorIp = null, string OriginatorPort = null, string CorrelationId = null, string Proto = null, string Family = null, string RtpStat = null, string Type = null, string Node = null, string Trans = null, string Dbnode = null, string Msg = null, string SourceAlias = null, string DestinationAlias = null, string ConversationId = null, string ParticipantId = null)
    {
        this.Name = Name;
        this.Date = Date;
        this.MilliTs = MilliTs;
        this.MicroTs = MicroTs;
        this.Method = Method;
        this.ReplyReason = ReplyReason;
        this.Ruri = Ruri;
        this.RuriUser = RuriUser;
        this.RuriDomain = RuriDomain;
        this.FromUser = FromUser;
        this.FromDomain = FromDomain;
        this.FromTag = FromTag;
        this.ToUser = ToUser;
        this.ToDomain = ToDomain;
        this.ToTag = ToTag;
        this.PidUser = PidUser;
        this.ContactUser = ContactUser;
        this.AuthUser = AuthUser;
        this.Callid = Callid;
        this.CallidAleg = CallidAleg;
        this.Via1 = Via1;
        this.Via1Branch = Via1Branch;
        this.Cseq = Cseq;
        this.Diversion = Diversion;
        this.Reason = Reason;
        this.ContentType = ContentType;
        this.Auth = Auth;
        this.UserAgent = UserAgent;
        this.SourceIp = SourceIp;
        this.SourcePort = SourcePort;
        this.DestinationIp = DestinationIp;
        this.DestinationPort = DestinationPort;
        this.ContactIp = ContactIp;
        this.ContactPort = ContactPort;
        this.OriginatorIp = OriginatorIp;
        this.OriginatorPort = OriginatorPort;
        this.CorrelationId = CorrelationId;
        this.Proto = Proto;
        this.Family = Family;
        this.RtpStat = RtpStat;
        this.Type = Type;
        this.Node = Node;
        this.Trans = Trans;
        this.Dbnode = Dbnode;
        this.Msg = Msg;
        this.SourceAlias = SourceAlias;
        this.DestinationAlias = DestinationAlias;
        this.ConversationId = ConversationId;
        this.ParticipantId = ParticipantId;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>metadata associated to the SIP calls. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("milliTs")]
    public string MilliTs { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("microTs")]
    public string MicroTs { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("method")]
    public string Method { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("replyReason")]
    public string ReplyReason { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("ruri")]
    public string Ruri { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("ruriUser")]
    public string RuriUser { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("ruriDomain")]
    public string RuriDomain { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("fromUser")]
    public string FromUser { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("fromDomain")]
    public string FromDomain { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("fromTag")]
    public string FromTag { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("toUser")]
    public string ToUser { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("toDomain")]
    public string ToDomain { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("toTag")]
    public string ToTag { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("pidUser")]
    public string PidUser { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("contactUser")]
    public string ContactUser { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("authUser")]
    public string AuthUser { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("callid")]
    public string Callid { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("callidAleg")]
    public string CallidAleg { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("via1")]
    public string Via1 { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("via1Branch")]
    public string Via1Branch { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("cseq")]
    public string Cseq { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("diversion")]
    public string Diversion { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("contentType")]
    public string ContentType { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("auth")]
    public string Auth { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("userAgent")]
    public string UserAgent { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("sourceIp")]
    public string SourceIp { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("sourcePort")]
    public string SourcePort { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("destinationIp")]
    public string DestinationIp { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("destinationPort")]
    public string DestinationPort { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("contactIp")]
    public string ContactIp { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("contactPort")]
    public string ContactPort { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("originatorIp")]
    public string OriginatorIp { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("originatorPort")]
    public string OriginatorPort { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("correlationId")]
    public string CorrelationId { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("proto")]
    public string Proto { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("family")]
    public string Family { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("rtpStat")]
    public string RtpStat { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("node")]
    public string Node { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("trans")]
    public string Trans { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("dbnode")]
    public string Dbnode { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("msg")]
    public string Msg { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("sourceAlias")]
    public string SourceAlias { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("destinationAlias")]
    public string DestinationAlias { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// metadata associated to the SIP calls
    /// </summary>
    /// <value>metadata associated to the SIP calls</value>
    [JsonPropertyName("participantId")]
    public string ParticipantId { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HomerRecord {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Date: ").Append(Date).Append("\n");
        sb.Append("  MilliTs: ").Append(MilliTs).Append("\n");
        sb.Append("  MicroTs: ").Append(MicroTs).Append("\n");
        sb.Append("  Method: ").Append(Method).Append("\n");
        sb.Append("  ReplyReason: ").Append(ReplyReason).Append("\n");
        sb.Append("  Ruri: ").Append(Ruri).Append("\n");
        sb.Append("  RuriUser: ").Append(RuriUser).Append("\n");
        sb.Append("  RuriDomain: ").Append(RuriDomain).Append("\n");
        sb.Append("  FromUser: ").Append(FromUser).Append("\n");
        sb.Append("  FromDomain: ").Append(FromDomain).Append("\n");
        sb.Append("  FromTag: ").Append(FromTag).Append("\n");
        sb.Append("  ToUser: ").Append(ToUser).Append("\n");
        sb.Append("  ToDomain: ").Append(ToDomain).Append("\n");
        sb.Append("  ToTag: ").Append(ToTag).Append("\n");
        sb.Append("  PidUser: ").Append(PidUser).Append("\n");
        sb.Append("  ContactUser: ").Append(ContactUser).Append("\n");
        sb.Append("  AuthUser: ").Append(AuthUser).Append("\n");
        sb.Append("  Callid: ").Append(Callid).Append("\n");
        sb.Append("  CallidAleg: ").Append(CallidAleg).Append("\n");
        sb.Append("  Via1: ").Append(Via1).Append("\n");
        sb.Append("  Via1Branch: ").Append(Via1Branch).Append("\n");
        sb.Append("  Cseq: ").Append(Cseq).Append("\n");
        sb.Append("  Diversion: ").Append(Diversion).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  Auth: ").Append(Auth).Append("\n");
        sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
        sb.Append("  SourceIp: ").Append(SourceIp).Append("\n");
        sb.Append("  SourcePort: ").Append(SourcePort).Append("\n");
        sb.Append("  DestinationIp: ").Append(DestinationIp).Append("\n");
        sb.Append("  DestinationPort: ").Append(DestinationPort).Append("\n");
        sb.Append("  ContactIp: ").Append(ContactIp).Append("\n");
        sb.Append("  ContactPort: ").Append(ContactPort).Append("\n");
        sb.Append("  OriginatorIp: ").Append(OriginatorIp).Append("\n");
        sb.Append("  OriginatorPort: ").Append(OriginatorPort).Append("\n");
        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  Proto: ").Append(Proto).Append("\n");
        sb.Append("  Family: ").Append(Family).Append("\n");
        sb.Append("  RtpStat: ").Append(RtpStat).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Node: ").Append(Node).Append("\n");
        sb.Append("  Trans: ").Append(Trans).Append("\n");
        sb.Append("  Dbnode: ").Append(Dbnode).Append("\n");
        sb.Append("  Msg: ").Append(Msg).Append("\n");
        sb.Append("  SourceAlias: ").Append(SourceAlias).Append("\n");
        sb.Append("  DestinationAlias: ").Append(DestinationAlias).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
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
        return Equals(obj as HomerRecord);
    }

    /// <summary>
    /// Returns true if HomerRecord instances are equal
    /// </summary>
    /// <param name="other">Instance of HomerRecord to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HomerRecord other)
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
                Date == other.Date ||
                Date != null &&
                Date.Equals(other.Date)
            ) &&
            (
                MilliTs == other.MilliTs ||
                MilliTs != null &&
                MilliTs.Equals(other.MilliTs)
            ) &&
            (
                MicroTs == other.MicroTs ||
                MicroTs != null &&
                MicroTs.Equals(other.MicroTs)
            ) &&
            (
                Method == other.Method ||
                Method != null &&
                Method.Equals(other.Method)
            ) &&
            (
                ReplyReason == other.ReplyReason ||
                ReplyReason != null &&
                ReplyReason.Equals(other.ReplyReason)
            ) &&
            (
                Ruri == other.Ruri ||
                Ruri != null &&
                Ruri.Equals(other.Ruri)
            ) &&
            (
                RuriUser == other.RuriUser ||
                RuriUser != null &&
                RuriUser.Equals(other.RuriUser)
            ) &&
            (
                RuriDomain == other.RuriDomain ||
                RuriDomain != null &&
                RuriDomain.Equals(other.RuriDomain)
            ) &&
            (
                FromUser == other.FromUser ||
                FromUser != null &&
                FromUser.Equals(other.FromUser)
            ) &&
            (
                FromDomain == other.FromDomain ||
                FromDomain != null &&
                FromDomain.Equals(other.FromDomain)
            ) &&
            (
                FromTag == other.FromTag ||
                FromTag != null &&
                FromTag.Equals(other.FromTag)
            ) &&
            (
                ToUser == other.ToUser ||
                ToUser != null &&
                ToUser.Equals(other.ToUser)
            ) &&
            (
                ToDomain == other.ToDomain ||
                ToDomain != null &&
                ToDomain.Equals(other.ToDomain)
            ) &&
            (
                ToTag == other.ToTag ||
                ToTag != null &&
                ToTag.Equals(other.ToTag)
            ) &&
            (
                PidUser == other.PidUser ||
                PidUser != null &&
                PidUser.Equals(other.PidUser)
            ) &&
            (
                ContactUser == other.ContactUser ||
                ContactUser != null &&
                ContactUser.Equals(other.ContactUser)
            ) &&
            (
                AuthUser == other.AuthUser ||
                AuthUser != null &&
                AuthUser.Equals(other.AuthUser)
            ) &&
            (
                Callid == other.Callid ||
                Callid != null &&
                Callid.Equals(other.Callid)
            ) &&
            (
                CallidAleg == other.CallidAleg ||
                CallidAleg != null &&
                CallidAleg.Equals(other.CallidAleg)
            ) &&
            (
                Via1 == other.Via1 ||
                Via1 != null &&
                Via1.Equals(other.Via1)
            ) &&
            (
                Via1Branch == other.Via1Branch ||
                Via1Branch != null &&
                Via1Branch.Equals(other.Via1Branch)
            ) &&
            (
                Cseq == other.Cseq ||
                Cseq != null &&
                Cseq.Equals(other.Cseq)
            ) &&
            (
                Diversion == other.Diversion ||
                Diversion != null &&
                Diversion.Equals(other.Diversion)
            ) &&
            (
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                Auth == other.Auth ||
                Auth != null &&
                Auth.Equals(other.Auth)
            ) &&
            (
                UserAgent == other.UserAgent ||
                UserAgent != null &&
                UserAgent.Equals(other.UserAgent)
            ) &&
            (
                SourceIp == other.SourceIp ||
                SourceIp != null &&
                SourceIp.Equals(other.SourceIp)
            ) &&
            (
                SourcePort == other.SourcePort ||
                SourcePort != null &&
                SourcePort.Equals(other.SourcePort)
            ) &&
            (
                DestinationIp == other.DestinationIp ||
                DestinationIp != null &&
                DestinationIp.Equals(other.DestinationIp)
            ) &&
            (
                DestinationPort == other.DestinationPort ||
                DestinationPort != null &&
                DestinationPort.Equals(other.DestinationPort)
            ) &&
            (
                ContactIp == other.ContactIp ||
                ContactIp != null &&
                ContactIp.Equals(other.ContactIp)
            ) &&
            (
                ContactPort == other.ContactPort ||
                ContactPort != null &&
                ContactPort.Equals(other.ContactPort)
            ) &&
            (
                OriginatorIp == other.OriginatorIp ||
                OriginatorIp != null &&
                OriginatorIp.Equals(other.OriginatorIp)
            ) &&
            (
                OriginatorPort == other.OriginatorPort ||
                OriginatorPort != null &&
                OriginatorPort.Equals(other.OriginatorPort)
            ) &&
            (
                CorrelationId == other.CorrelationId ||
                CorrelationId != null &&
                CorrelationId.Equals(other.CorrelationId)
            ) &&
            (
                Proto == other.Proto ||
                Proto != null &&
                Proto.Equals(other.Proto)
            ) &&
            (
                Family == other.Family ||
                Family != null &&
                Family.Equals(other.Family)
            ) &&
            (
                RtpStat == other.RtpStat ||
                RtpStat != null &&
                RtpStat.Equals(other.RtpStat)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Node == other.Node ||
                Node != null &&
                Node.Equals(other.Node)
            ) &&
            (
                Trans == other.Trans ||
                Trans != null &&
                Trans.Equals(other.Trans)
            ) &&
            (
                Dbnode == other.Dbnode ||
                Dbnode != null &&
                Dbnode.Equals(other.Dbnode)
            ) &&
            (
                Msg == other.Msg ||
                Msg != null &&
                Msg.Equals(other.Msg)
            ) &&
            (
                SourceAlias == other.SourceAlias ||
                SourceAlias != null &&
                SourceAlias.Equals(other.SourceAlias)
            ) &&
            (
                DestinationAlias == other.DestinationAlias ||
                DestinationAlias != null &&
                DestinationAlias.Equals(other.DestinationAlias)
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

            if (Date != null)
            {
                hash = hash * 59 + Date.GetHashCode();
            }

            if (MilliTs != null)
            {
                hash = hash * 59 + MilliTs.GetHashCode();
            }

            if (MicroTs != null)
            {
                hash = hash * 59 + MicroTs.GetHashCode();
            }

            if (Method != null)
            {
                hash = hash * 59 + Method.GetHashCode();
            }

            if (ReplyReason != null)
            {
                hash = hash * 59 + ReplyReason.GetHashCode();
            }

            if (Ruri != null)
            {
                hash = hash * 59 + Ruri.GetHashCode();
            }

            if (RuriUser != null)
            {
                hash = hash * 59 + RuriUser.GetHashCode();
            }

            if (RuriDomain != null)
            {
                hash = hash * 59 + RuriDomain.GetHashCode();
            }

            if (FromUser != null)
            {
                hash = hash * 59 + FromUser.GetHashCode();
            }

            if (FromDomain != null)
            {
                hash = hash * 59 + FromDomain.GetHashCode();
            }

            if (FromTag != null)
            {
                hash = hash * 59 + FromTag.GetHashCode();
            }

            if (ToUser != null)
            {
                hash = hash * 59 + ToUser.GetHashCode();
            }

            if (ToDomain != null)
            {
                hash = hash * 59 + ToDomain.GetHashCode();
            }

            if (ToTag != null)
            {
                hash = hash * 59 + ToTag.GetHashCode();
            }

            if (PidUser != null)
            {
                hash = hash * 59 + PidUser.GetHashCode();
            }

            if (ContactUser != null)
            {
                hash = hash * 59 + ContactUser.GetHashCode();
            }

            if (AuthUser != null)
            {
                hash = hash * 59 + AuthUser.GetHashCode();
            }

            if (Callid != null)
            {
                hash = hash * 59 + Callid.GetHashCode();
            }

            if (CallidAleg != null)
            {
                hash = hash * 59 + CallidAleg.GetHashCode();
            }

            if (Via1 != null)
            {
                hash = hash * 59 + Via1.GetHashCode();
            }

            if (Via1Branch != null)
            {
                hash = hash * 59 + Via1Branch.GetHashCode();
            }

            if (Cseq != null)
            {
                hash = hash * 59 + Cseq.GetHashCode();
            }

            if (Diversion != null)
            {
                hash = hash * 59 + Diversion.GetHashCode();
            }

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (Auth != null)
            {
                hash = hash * 59 + Auth.GetHashCode();
            }

            if (UserAgent != null)
            {
                hash = hash * 59 + UserAgent.GetHashCode();
            }

            if (SourceIp != null)
            {
                hash = hash * 59 + SourceIp.GetHashCode();
            }

            if (SourcePort != null)
            {
                hash = hash * 59 + SourcePort.GetHashCode();
            }

            if (DestinationIp != null)
            {
                hash = hash * 59 + DestinationIp.GetHashCode();
            }

            if (DestinationPort != null)
            {
                hash = hash * 59 + DestinationPort.GetHashCode();
            }

            if (ContactIp != null)
            {
                hash = hash * 59 + ContactIp.GetHashCode();
            }

            if (ContactPort != null)
            {
                hash = hash * 59 + ContactPort.GetHashCode();
            }

            if (OriginatorIp != null)
            {
                hash = hash * 59 + OriginatorIp.GetHashCode();
            }

            if (OriginatorPort != null)
            {
                hash = hash * 59 + OriginatorPort.GetHashCode();
            }

            if (CorrelationId != null)
            {
                hash = hash * 59 + CorrelationId.GetHashCode();
            }

            if (Proto != null)
            {
                hash = hash * 59 + Proto.GetHashCode();
            }

            if (Family != null)
            {
                hash = hash * 59 + Family.GetHashCode();
            }

            if (RtpStat != null)
            {
                hash = hash * 59 + RtpStat.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Node != null)
            {
                hash = hash * 59 + Node.GetHashCode();
            }

            if (Trans != null)
            {
                hash = hash * 59 + Trans.GetHashCode();
            }

            if (Dbnode != null)
            {
                hash = hash * 59 + Dbnode.GetHashCode();
            }

            if (Msg != null)
            {
                hash = hash * 59 + Msg.GetHashCode();
            }

            if (SourceAlias != null)
            {
                hash = hash * 59 + SourceAlias.GetHashCode();
            }

            if (DestinationAlias != null)
            {
                hash = hash * 59 + DestinationAlias.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ParticipantId != null)
            {
                hash = hash * 59 + ParticipantId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
