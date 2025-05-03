using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Session
/// </summary>

public partial class Session : IEquatable<Session>
{
    /// <summary>
    /// The original direction of the conversation.
    /// </summary>
    /// <value>The original direction of the conversation.</value>
    
    public enum OriginatingDirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Inbound for "Inbound"
        /// </summary>
        [EnumMember(Value = "Inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "Outbound"
        /// </summary>
        [EnumMember(Value = "Outbound")]
        Outbound
    }
    /// <summary>
    /// Disconnect reason for the last user connected to the conversation.
    /// </summary>
    /// <value>Disconnect reason for the last user connected to the conversation.</value>
    
    public enum LastUserDisconnectTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Endpoint for "Endpoint"
        /// </summary>
        [EnumMember(Value = "Endpoint")]
        Endpoint,

        /// <summary>
        /// Enum Client for "Client"
        /// </summary>
        [EnumMember(Value = "Client")]
        Client,

        /// <summary>
        /// Enum System for "System"
        /// </summary>
        [EnumMember(Value = "System")]
        System,

        /// <summary>
        /// Enum Transfer for "Transfer"
        /// </summary>
        [EnumMember(Value = "Transfer")]
        Transfer,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Peer for "Peer"
        /// </summary>
        [EnumMember(Value = "Peer")]
        Peer,

        /// <summary>
        /// Enum Other for "Other"
        /// </summary>
        [EnumMember(Value = "Other")]
        Other,

        /// <summary>
        /// Enum Spam for "Spam"
        /// </summary>
        [EnumMember(Value = "Spam")]
        Spam,

        /// <summary>
        /// Enum Timeout for "Timeout"
        /// </summary>
        [EnumMember(Value = "Timeout")]
        Timeout,

        /// <summary>
        /// Enum Transportfailure for "TransportFailure"
        /// </summary>
        [EnumMember(Value = "TransportFailure")]
        Transportfailure,

        /// <summary>
        /// Enum Conferencetransfer for "ConferenceTransfer"
        /// </summary>
        [EnumMember(Value = "ConferenceTransfer")]
        Conferencetransfer,

        /// <summary>
        /// Enum Consulttransfer for "ConsultTransfer"
        /// </summary>
        [EnumMember(Value = "ConsultTransfer")]
        Consulttransfer,

        /// <summary>
        /// Enum Forwardtransfer for "ForwardTransfer"
        /// </summary>
        [EnumMember(Value = "ForwardTransfer")]
        Forwardtransfer,

        /// <summary>
        /// Enum Noanswertransfer for "NoAnswerTransfer"
        /// </summary>
        [EnumMember(Value = "NoAnswerTransfer")]
        Noanswertransfer,

        /// <summary>
        /// Enum Notavailabletransfer for "NotAvailableTransfer"
        /// </summary>
        [EnumMember(Value = "NotAvailableTransfer")]
        Notavailabletransfer,

        /// <summary>
        /// Enum Uncallable for "Uncallable"
        /// </summary>
        [EnumMember(Value = "Uncallable")]
        Uncallable,

        /// <summary>
        /// Enum Donotdisturbendpoint for "DoNotDisturbEndpoint"
        /// </summary>
        [EnumMember(Value = "DoNotDisturbEndpoint")]
        Donotdisturbendpoint,

        /// <summary>
        /// Enum Donotdisturbtransfer for "DoNotDisturbTransfer"
        /// </summary>
        [EnumMember(Value = "DoNotDisturbTransfer")]
        Donotdisturbtransfer
    }
    /// <summary>
    /// Last ACD outcome for the conversation.
    /// </summary>
    /// <value>Last ACD outcome for the conversation.</value>
    
    public enum LastAcdOutcomeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Abandon for "Abandon"
        /// </summary>
        [EnumMember(Value = "Abandon")]
        Abandon,

        /// <summary>
        /// Enum Answered for "Answered"
        /// </summary>
        [EnumMember(Value = "Answered")]
        Answered,

        /// <summary>
        /// Enum Flowout for "FlowOut"
        /// </summary>
        [EnumMember(Value = "FlowOut")]
        Flowout
    }
    /// <summary>
    /// The original direction of the conversation.
    /// </summary>
    /// <value>The original direction of the conversation.</value>
    [JsonPropertyName("originatingDirection")]
    public OriginatingDirectionEnum? OriginatingDirection { get; set; }
    /// <summary>
    /// Disconnect reason for the last user connected to the conversation.
    /// </summary>
    /// <value>Disconnect reason for the last user connected to the conversation.</value>
    [JsonPropertyName("lastUserDisconnectType")]
    public LastUserDisconnectTypeEnum? LastUserDisconnectType { get; set; }
    /// <summary>
    /// Last ACD outcome for the conversation.
    /// </summary>
    /// <value>Last ACD outcome for the conversation.</value>
    [JsonPropertyName("lastAcdOutcome")]
    public LastAcdOutcomeEnum? LastAcdOutcome { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Session" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Session() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Session" /> class.
    /// </summary>
    /// <param name="Id">The ID of the session. (required).</param>
    /// <param name="CustomerId">Primary identifier of the customer in the source where the events for the session originate from..</param>
    /// <param name="CustomerIdType">Type of source customer identifier (e.g. cookie, email, phone)..</param>
    /// <param name="Type">Session types indicate the type or category of sessions (e.g. web, app). (required).</param>
    /// <param name="ExternalId">Unique identifier in the external system where the events for the session originate from..</param>
    /// <param name="ExternalUrl">A URL that identifies an external system-of-record resource that may have more detailed information on the session..</param>
    /// <param name="ShortId">Shortened numeric identifier of 4-6 digits..</param>
    /// <param name="OutcomeAchievements">List of the outcome achievements by the customer in this session..</param>
    /// <param name="SegmentAssignments">List of the segment assignments to the customer in this session..</param>
    /// <param name="Attributes">Attributes projected from the session&#39;s event stream..</param>
    /// <param name="AttributeLists">List-type attributes projected from the session&#39;s event stream..</param>
    /// <param name="Browser">Customer&#39;s browser..</param>
    /// <param name="Device">Customer&#39;s device..</param>
    /// <param name="Geolocation">Customer&#39;s geolocation..</param>
    /// <param name="IpAddress">Customer&#39;s IP address..</param>
    /// <param name="IpOrganization">Customer&#39;s IP-based organization or ISP name..</param>
    /// <param name="LastPage">The webpage where the customer&#39;s last web interaction occurred..</param>
    /// <param name="MktCampaign">Marketing / traffic source information..</param>
    /// <param name="Referrer">Identifies the page URL that originally generated the request for the current page being viewed..</param>
    /// <param name="App">Application that the customer is interacting with (for app sessions)..</param>
    /// <param name="SdkLibrary">SDK library used to generate the events for the session (for app and web sessions)..</param>
    /// <param name="NetworkConnectivity">Information relating to the device&#39;s network connectivity (for app sessions)..</param>
    /// <param name="SearchTerms">Search terms associated with the session..</param>
    /// <param name="UserAgentString">String identifying the user agent..</param>
    /// <param name="DurationInSeconds">Indicates how long the session has been active (valid for an individual device)..</param>
    /// <param name="EventCount">The count of all events performed during the session. (required).</param>
    /// <param name="PageviewCount">The count of all pageviews performed during the session..</param>
    /// <param name="ScreenviewCount">The count of all screenviews performed during the session..</param>
    /// <param name="LastEvent">Information about the most recent event in this session. (required).</param>
    /// <param name="LastConnectedQueue">The last queue connected to this session..</param>
    /// <param name="LastConnectedUser">The last user connected to this session..</param>
    /// <param name="LastUserDisposition">The last user disposition connected to this session..</param>
    /// <param name="ConversationChannels">Represents the channels used for this conversation..</param>
    /// <param name="OriginatingDirection">The original direction of the conversation..</param>
    /// <param name="ConversationSubject">The subject for the conversation, for example an email subject..</param>
    /// <param name="LastUserDisconnectType">Disconnect reason for the last user connected to the conversation..</param>
    /// <param name="LastAcdOutcome">Last ACD outcome for the conversation..</param>
    /// <param name="Authenticated">Indicates whether or not the session is authenticated. (required).</param>
    /// <param name="DivisionIds">List of division IDs associated with the session..</param>
    /// <param name="LastScreen">The app screen name where the customer&#39;s last app interaction occurred..</param>
    /// <param name="CreatedDate">Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="EndedDate">Timestamp indicating when the session was ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AwayDate">Timestamp indicating when the visitor should be considered as away. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="IdleDate">Timestamp indicating when the visitor should be considered as idle. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public Session(string Id = null, string CustomerId = null, string CustomerIdType = null, string Type = null, string ExternalId = null, string ExternalUrl = null, string ShortId = null, List<OutcomeAchievement> OutcomeAchievements = null, List<SessionSegmentAssignment> SegmentAssignments = null, Dictionary<string, CustomEventAttribute> Attributes = null, Dictionary<string, CustomEventAttributeList> AttributeLists = null, Browser Browser = null, Device Device = null, JourneyGeolocation Geolocation = null, string IpAddress = null, string IpOrganization = null, JourneyPage LastPage = null, JourneyCampaign MktCampaign = null, Referrer Referrer = null, JourneyApp App = null, SdkLibrary SdkLibrary = null, NetworkConnectivity NetworkConnectivity = null, List<string> SearchTerms = null, string UserAgentString = null, int? DurationInSeconds = null, int? EventCount = null, int? PageviewCount = null, int? ScreenviewCount = null, SessionLastEvent LastEvent = null, ConnectedQueue LastConnectedQueue = null, ConnectedUser LastConnectedUser = null, ConversationUserDisposition LastUserDisposition = null, List<ConversationChannel> ConversationChannels = null, OriginatingDirectionEnum? OriginatingDirection = null, string ConversationSubject = null, LastUserDisconnectTypeEnum? LastUserDisconnectType = null, LastAcdOutcomeEnum? LastAcdOutcome = null, bool? Authenticated = null, List<string> DivisionIds = null, string LastScreen = null, DateTime? CreatedDate = null, DateTime? EndedDate = null, DateTime? AwayDate = null, DateTime? IdleDate = null)
    {
        this.Id = Id;
        this.CustomerId = CustomerId;
        this.CustomerIdType = CustomerIdType;
        this.Type = Type;
        this.ExternalId = ExternalId;
        this.ExternalUrl = ExternalUrl;
        this.ShortId = ShortId;
        this.OutcomeAchievements = OutcomeAchievements;
        this.SegmentAssignments = SegmentAssignments;
        this.Attributes = Attributes;
        this.AttributeLists = AttributeLists;
        this.Browser = Browser;
        this.Device = Device;
        this.Geolocation = Geolocation;
        this.IpAddress = IpAddress;
        this.IpOrganization = IpOrganization;
        this.LastPage = LastPage;
        this.MktCampaign = MktCampaign;
        this.Referrer = Referrer;
        this.App = App;
        this.SdkLibrary = SdkLibrary;
        this.NetworkConnectivity = NetworkConnectivity;
        this.SearchTerms = SearchTerms;
        this.UserAgentString = UserAgentString;
        this.DurationInSeconds = DurationInSeconds;
        this.EventCount = EventCount;
        this.PageviewCount = PageviewCount;
        this.ScreenviewCount = ScreenviewCount;
        this.LastEvent = LastEvent;
        this.LastConnectedQueue = LastConnectedQueue;
        this.LastConnectedUser = LastConnectedUser;
        this.LastUserDisposition = LastUserDisposition;
        this.ConversationChannels = ConversationChannels;
        this.OriginatingDirection = OriginatingDirection;
        this.ConversationSubject = ConversationSubject;
        this.LastUserDisconnectType = LastUserDisconnectType;
        this.LastAcdOutcome = LastAcdOutcome;
        this.Authenticated = Authenticated;
        this.DivisionIds = DivisionIds;
        this.LastScreen = LastScreen;
        this.CreatedDate = CreatedDate;
        this.EndedDate = EndedDate;
        this.AwayDate = AwayDate;
        this.IdleDate = IdleDate;

    }



    /// <summary>
    /// The ID of the session.
    /// </summary>
    /// <value>The ID of the session.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Primary identifier of the customer in the source where the events for the session originate from.
    /// </summary>
    /// <value>Primary identifier of the customer in the source where the events for the session originate from.</value>
    [JsonPropertyName("customerId")]
    public string CustomerId { get; set; }



    /// <summary>
    /// Type of source customer identifier (e.g. cookie, email, phone).
    /// </summary>
    /// <value>Type of source customer identifier (e.g. cookie, email, phone).</value>
    [JsonPropertyName("customerIdType")]
    public string CustomerIdType { get; set; }



    /// <summary>
    /// Session types indicate the type or category of sessions (e.g. web, app).
    /// </summary>
    /// <value>Session types indicate the type or category of sessions (e.g. web, app).</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Unique identifier in the external system where the events for the session originate from.
    /// </summary>
    /// <value>Unique identifier in the external system where the events for the session originate from.</value>
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; }



    /// <summary>
    /// A URL that identifies an external system-of-record resource that may have more detailed information on the session.
    /// </summary>
    /// <value>A URL that identifies an external system-of-record resource that may have more detailed information on the session.</value>
    [JsonPropertyName("externalUrl")]
    public string ExternalUrl { get; set; }



    /// <summary>
    /// Shortened numeric identifier of 4-6 digits.
    /// </summary>
    /// <value>Shortened numeric identifier of 4-6 digits.</value>
    [JsonPropertyName("shortId")]
    public string ShortId { get; set; }



    /// <summary>
    /// List of the outcome achievements by the customer in this session.
    /// </summary>
    /// <value>List of the outcome achievements by the customer in this session.</value>
    [JsonPropertyName("outcomeAchievements")]
    public List<OutcomeAchievement> OutcomeAchievements { get; set; }



    /// <summary>
    /// List of the segment assignments to the customer in this session.
    /// </summary>
    /// <value>List of the segment assignments to the customer in this session.</value>
    [JsonPropertyName("segmentAssignments")]
    public List<SessionSegmentAssignment> SegmentAssignments { get; set; }



    /// <summary>
    /// Attributes projected from the session&#39;s event stream.
    /// </summary>
    /// <value>Attributes projected from the session&#39;s event stream.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, CustomEventAttribute> Attributes { get; set; }



    /// <summary>
    /// List-type attributes projected from the session&#39;s event stream.
    /// </summary>
    /// <value>List-type attributes projected from the session&#39;s event stream.</value>
    [JsonPropertyName("attributeLists")]
    public Dictionary<string, CustomEventAttributeList> AttributeLists { get; set; }



    /// <summary>
    /// Customer&#39;s browser.
    /// </summary>
    /// <value>Customer&#39;s browser.</value>
    [JsonPropertyName("browser")]
    public Browser Browser { get; set; }



    /// <summary>
    /// Customer&#39;s device.
    /// </summary>
    /// <value>Customer&#39;s device.</value>
    [JsonPropertyName("device")]
    public Device Device { get; set; }



    /// <summary>
    /// Customer&#39;s geolocation.
    /// </summary>
    /// <value>Customer&#39;s geolocation.</value>
    [JsonPropertyName("geolocation")]
    public JourneyGeolocation Geolocation { get; set; }



    /// <summary>
    /// Customer&#39;s IP address.
    /// </summary>
    /// <value>Customer&#39;s IP address.</value>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }



    /// <summary>
    /// Customer&#39;s IP-based organization or ISP name.
    /// </summary>
    /// <value>Customer&#39;s IP-based organization or ISP name.</value>
    [JsonPropertyName("ipOrganization")]
    public string IpOrganization { get; set; }



    /// <summary>
    /// The webpage where the customer&#39;s last web interaction occurred.
    /// </summary>
    /// <value>The webpage where the customer&#39;s last web interaction occurred.</value>
    [JsonPropertyName("lastPage")]
    public JourneyPage LastPage { get; set; }



    /// <summary>
    /// Marketing / traffic source information.
    /// </summary>
    /// <value>Marketing / traffic source information.</value>
    [JsonPropertyName("mktCampaign")]
    public JourneyCampaign MktCampaign { get; set; }



    /// <summary>
    /// Identifies the page URL that originally generated the request for the current page being viewed.
    /// </summary>
    /// <value>Identifies the page URL that originally generated the request for the current page being viewed.</value>
    [JsonPropertyName("referrer")]
    public Referrer Referrer { get; set; }



    /// <summary>
    /// Application that the customer is interacting with (for app sessions).
    /// </summary>
    /// <value>Application that the customer is interacting with (for app sessions).</value>
    [JsonPropertyName("app")]
    public JourneyApp App { get; set; }



    /// <summary>
    /// SDK library used to generate the events for the session (for app and web sessions).
    /// </summary>
    /// <value>SDK library used to generate the events for the session (for app and web sessions).</value>
    [JsonPropertyName("sdkLibrary")]
    public SdkLibrary SdkLibrary { get; set; }



    /// <summary>
    /// Information relating to the device&#39;s network connectivity (for app sessions).
    /// </summary>
    /// <value>Information relating to the device&#39;s network connectivity (for app sessions).</value>
    [JsonPropertyName("networkConnectivity")]
    public NetworkConnectivity NetworkConnectivity { get; set; }



    /// <summary>
    /// Search terms associated with the session.
    /// </summary>
    /// <value>Search terms associated with the session.</value>
    [JsonPropertyName("searchTerms")]
    public List<string> SearchTerms { get; set; }



    /// <summary>
    /// String identifying the user agent.
    /// </summary>
    /// <value>String identifying the user agent.</value>
    [JsonPropertyName("userAgentString")]
    public string UserAgentString { get; set; }



    /// <summary>
    /// Indicates how long the session has been active (valid for an individual device).
    /// </summary>
    /// <value>Indicates how long the session has been active (valid for an individual device).</value>
    [JsonPropertyName("durationInSeconds")]
    public int? DurationInSeconds { get; set; }



    /// <summary>
    /// The count of all events performed during the session.
    /// </summary>
    /// <value>The count of all events performed during the session.</value>
    [JsonPropertyName("eventCount")]
    public int? EventCount { get; set; }



    /// <summary>
    /// The count of all pageviews performed during the session.
    /// </summary>
    /// <value>The count of all pageviews performed during the session.</value>
    [JsonPropertyName("pageviewCount")]
    public int? PageviewCount { get; set; }



    /// <summary>
    /// The count of all screenviews performed during the session.
    /// </summary>
    /// <value>The count of all screenviews performed during the session.</value>
    [JsonPropertyName("screenviewCount")]
    public int? ScreenviewCount { get; set; }



    /// <summary>
    /// Information about the most recent event in this session.
    /// </summary>
    /// <value>Information about the most recent event in this session.</value>
    [JsonPropertyName("lastEvent")]
    public SessionLastEvent LastEvent { get; set; }



    /// <summary>
    /// The last queue connected to this session.
    /// </summary>
    /// <value>The last queue connected to this session.</value>
    [JsonPropertyName("lastConnectedQueue")]
    public ConnectedQueue LastConnectedQueue { get; set; }



    /// <summary>
    /// The last user connected to this session.
    /// </summary>
    /// <value>The last user connected to this session.</value>
    [JsonPropertyName("lastConnectedUser")]
    public ConnectedUser LastConnectedUser { get; set; }



    /// <summary>
    /// The last user disposition connected to this session.
    /// </summary>
    /// <value>The last user disposition connected to this session.</value>
    [JsonPropertyName("lastUserDisposition")]
    public ConversationUserDisposition LastUserDisposition { get; set; }



    /// <summary>
    /// Represents the channels used for this conversation.
    /// </summary>
    /// <value>Represents the channels used for this conversation.</value>
    [JsonPropertyName("conversationChannels")]
    public List<ConversationChannel> ConversationChannels { get; set; }





    /// <summary>
    /// The subject for the conversation, for example an email subject.
    /// </summary>
    /// <value>The subject for the conversation, for example an email subject.</value>
    [JsonPropertyName("conversationSubject")]
    public string ConversationSubject { get; set; }







    /// <summary>
    /// Indicates whether or not the session is authenticated.
    /// </summary>
    /// <value>Indicates whether or not the session is authenticated.</value>
    [JsonPropertyName("authenticated")]
    public bool? Authenticated { get; set; }



    /// <summary>
    /// List of division IDs associated with the session.
    /// </summary>
    /// <value>List of division IDs associated with the session.</value>
    [JsonPropertyName("divisionIds")]
    public List<string> DivisionIds { get; set; }



    /// <summary>
    /// The app screen name where the customer&#39;s last app interaction occurred.
    /// </summary>
    /// <value>The app screen name where the customer&#39;s last app interaction occurred.</value>
    [JsonPropertyName("lastScreen")]
    public string LastScreen { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }



    /// <summary>
    /// Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Timestamp indicating when the session was ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the session was ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endedDate")]
    public DateTime? EndedDate { get; set; }



    /// <summary>
    /// The external contact associated with this session.
    /// </summary>
    /// <value>The external contact associated with this session.</value>
    [JsonPropertyName("externalContact")]
    public AddressableEntityRef ExternalContact { get; private set; }



    /// <summary>
    /// Timestamp indicating when the visitor should be considered as away. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the visitor should be considered as away. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("awayDate")]
    public DateTime? AwayDate { get; set; }



    /// <summary>
    /// Timestamp indicating when the visitor should be considered as idle. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the visitor should be considered as idle. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("idleDate")]
    public DateTime? IdleDate { get; set; }



    /// <summary>
    /// The conversation for this session.
    /// </summary>
    /// <value>The conversation for this session.</value>
    [JsonPropertyName("conversation")]
    public AddressableEntityRef Conversation { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Session {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
        sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
        sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
        sb.Append("  ShortId: ").Append(ShortId).Append("\n");
        sb.Append("  OutcomeAchievements: ").Append(OutcomeAchievements).Append("\n");
        sb.Append("  SegmentAssignments: ").Append(SegmentAssignments).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  AttributeLists: ").Append(AttributeLists).Append("\n");
        sb.Append("  Browser: ").Append(Browser).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
        sb.Append("  LastPage: ").Append(LastPage).Append("\n");
        sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
        sb.Append("  Referrer: ").Append(Referrer).Append("\n");
        sb.Append("  App: ").Append(App).Append("\n");
        sb.Append("  SdkLibrary: ").Append(SdkLibrary).Append("\n");
        sb.Append("  NetworkConnectivity: ").Append(NetworkConnectivity).Append("\n");
        sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
        sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
        sb.Append("  DurationInSeconds: ").Append(DurationInSeconds).Append("\n");
        sb.Append("  EventCount: ").Append(EventCount).Append("\n");
        sb.Append("  PageviewCount: ").Append(PageviewCount).Append("\n");
        sb.Append("  ScreenviewCount: ").Append(ScreenviewCount).Append("\n");
        sb.Append("  LastEvent: ").Append(LastEvent).Append("\n");
        sb.Append("  LastConnectedQueue: ").Append(LastConnectedQueue).Append("\n");
        sb.Append("  LastConnectedUser: ").Append(LastConnectedUser).Append("\n");
        sb.Append("  LastUserDisposition: ").Append(LastUserDisposition).Append("\n");
        sb.Append("  ConversationChannels: ").Append(ConversationChannels).Append("\n");
        sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
        sb.Append("  ConversationSubject: ").Append(ConversationSubject).Append("\n");
        sb.Append("  LastUserDisconnectType: ").Append(LastUserDisconnectType).Append("\n");
        sb.Append("  LastAcdOutcome: ").Append(LastAcdOutcome).Append("\n");
        sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
        sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
        sb.Append("  LastScreen: ").Append(LastScreen).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  EndedDate: ").Append(EndedDate).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  AwayDate: ").Append(AwayDate).Append("\n");
        sb.Append("  IdleDate: ").Append(IdleDate).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
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
        return Equals(obj as Session);
    }

    /// <summary>
    /// Returns true if Session instances are equal
    /// </summary>
    /// <param name="other">Instance of Session to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Session other)
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
                CustomerId == other.CustomerId ||
                CustomerId != null &&
                CustomerId.Equals(other.CustomerId)
            ) &&
            (
                CustomerIdType == other.CustomerIdType ||
                CustomerIdType != null &&
                CustomerIdType.Equals(other.CustomerIdType)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                ExternalId == other.ExternalId ||
                ExternalId != null &&
                ExternalId.Equals(other.ExternalId)
            ) &&
            (
                ExternalUrl == other.ExternalUrl ||
                ExternalUrl != null &&
                ExternalUrl.Equals(other.ExternalUrl)
            ) &&
            (
                ShortId == other.ShortId ||
                ShortId != null &&
                ShortId.Equals(other.ShortId)
            ) &&
            (
                OutcomeAchievements == other.OutcomeAchievements ||
                OutcomeAchievements != null &&
                OutcomeAchievements.SequenceEqual(other.OutcomeAchievements)
            ) &&
            (
                SegmentAssignments == other.SegmentAssignments ||
                SegmentAssignments != null &&
                SegmentAssignments.SequenceEqual(other.SegmentAssignments)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                AttributeLists == other.AttributeLists ||
                AttributeLists != null &&
                AttributeLists.SequenceEqual(other.AttributeLists)
            ) &&
            (
                Browser == other.Browser ||
                Browser != null &&
                Browser.Equals(other.Browser)
            ) &&
            (
                Device == other.Device ||
                Device != null &&
                Device.Equals(other.Device)
            ) &&
            (
                Geolocation == other.Geolocation ||
                Geolocation != null &&
                Geolocation.Equals(other.Geolocation)
            ) &&
            (
                IpAddress == other.IpAddress ||
                IpAddress != null &&
                IpAddress.Equals(other.IpAddress)
            ) &&
            (
                IpOrganization == other.IpOrganization ||
                IpOrganization != null &&
                IpOrganization.Equals(other.IpOrganization)
            ) &&
            (
                LastPage == other.LastPage ||
                LastPage != null &&
                LastPage.Equals(other.LastPage)
            ) &&
            (
                MktCampaign == other.MktCampaign ||
                MktCampaign != null &&
                MktCampaign.Equals(other.MktCampaign)
            ) &&
            (
                Referrer == other.Referrer ||
                Referrer != null &&
                Referrer.Equals(other.Referrer)
            ) &&
            (
                App == other.App ||
                App != null &&
                App.Equals(other.App)
            ) &&
            (
                SdkLibrary == other.SdkLibrary ||
                SdkLibrary != null &&
                SdkLibrary.Equals(other.SdkLibrary)
            ) &&
            (
                NetworkConnectivity == other.NetworkConnectivity ||
                NetworkConnectivity != null &&
                NetworkConnectivity.Equals(other.NetworkConnectivity)
            ) &&
            (
                SearchTerms == other.SearchTerms ||
                SearchTerms != null &&
                SearchTerms.SequenceEqual(other.SearchTerms)
            ) &&
            (
                UserAgentString == other.UserAgentString ||
                UserAgentString != null &&
                UserAgentString.Equals(other.UserAgentString)
            ) &&
            (
                DurationInSeconds == other.DurationInSeconds ||
                DurationInSeconds != null &&
                DurationInSeconds.Equals(other.DurationInSeconds)
            ) &&
            (
                EventCount == other.EventCount ||
                EventCount != null &&
                EventCount.Equals(other.EventCount)
            ) &&
            (
                PageviewCount == other.PageviewCount ||
                PageviewCount != null &&
                PageviewCount.Equals(other.PageviewCount)
            ) &&
            (
                ScreenviewCount == other.ScreenviewCount ||
                ScreenviewCount != null &&
                ScreenviewCount.Equals(other.ScreenviewCount)
            ) &&
            (
                LastEvent == other.LastEvent ||
                LastEvent != null &&
                LastEvent.Equals(other.LastEvent)
            ) &&
            (
                LastConnectedQueue == other.LastConnectedQueue ||
                LastConnectedQueue != null &&
                LastConnectedQueue.Equals(other.LastConnectedQueue)
            ) &&
            (
                LastConnectedUser == other.LastConnectedUser ||
                LastConnectedUser != null &&
                LastConnectedUser.Equals(other.LastConnectedUser)
            ) &&
            (
                LastUserDisposition == other.LastUserDisposition ||
                LastUserDisposition != null &&
                LastUserDisposition.Equals(other.LastUserDisposition)
            ) &&
            (
                ConversationChannels == other.ConversationChannels ||
                ConversationChannels != null &&
                ConversationChannels.SequenceEqual(other.ConversationChannels)
            ) &&
            (
                OriginatingDirection == other.OriginatingDirection ||
                OriginatingDirection != null &&
                OriginatingDirection.Equals(other.OriginatingDirection)
            ) &&
            (
                ConversationSubject == other.ConversationSubject ||
                ConversationSubject != null &&
                ConversationSubject.Equals(other.ConversationSubject)
            ) &&
            (
                LastUserDisconnectType == other.LastUserDisconnectType ||
                LastUserDisconnectType != null &&
                LastUserDisconnectType.Equals(other.LastUserDisconnectType)
            ) &&
            (
                LastAcdOutcome == other.LastAcdOutcome ||
                LastAcdOutcome != null &&
                LastAcdOutcome.Equals(other.LastAcdOutcome)
            ) &&
            (
                Authenticated == other.Authenticated ||
                Authenticated != null &&
                Authenticated.Equals(other.Authenticated)
            ) &&
            (
                DivisionIds == other.DivisionIds ||
                DivisionIds != null &&
                DivisionIds.SequenceEqual(other.DivisionIds)
            ) &&
            (
                LastScreen == other.LastScreen ||
                LastScreen != null &&
                LastScreen.Equals(other.LastScreen)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                EndedDate == other.EndedDate ||
                EndedDate != null &&
                EndedDate.Equals(other.EndedDate)
            ) &&
            (
                ExternalContact == other.ExternalContact ||
                ExternalContact != null &&
                ExternalContact.Equals(other.ExternalContact)
            ) &&
            (
                AwayDate == other.AwayDate ||
                AwayDate != null &&
                AwayDate.Equals(other.AwayDate)
            ) &&
            (
                IdleDate == other.IdleDate ||
                IdleDate != null &&
                IdleDate.Equals(other.IdleDate)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
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

            if (CustomerId != null)
            {
                hash = hash * 59 + CustomerId.GetHashCode();
            }

            if (CustomerIdType != null)
            {
                hash = hash * 59 + CustomerIdType.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            if (ExternalUrl != null)
            {
                hash = hash * 59 + ExternalUrl.GetHashCode();
            }

            if (ShortId != null)
            {
                hash = hash * 59 + ShortId.GetHashCode();
            }

            if (OutcomeAchievements != null)
            {
                hash = hash * 59 + OutcomeAchievements.GetHashCode();
            }

            if (SegmentAssignments != null)
            {
                hash = hash * 59 + SegmentAssignments.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (AttributeLists != null)
            {
                hash = hash * 59 + AttributeLists.GetHashCode();
            }

            if (Browser != null)
            {
                hash = hash * 59 + Browser.GetHashCode();
            }

            if (Device != null)
            {
                hash = hash * 59 + Device.GetHashCode();
            }

            if (Geolocation != null)
            {
                hash = hash * 59 + Geolocation.GetHashCode();
            }

            if (IpAddress != null)
            {
                hash = hash * 59 + IpAddress.GetHashCode();
            }

            if (IpOrganization != null)
            {
                hash = hash * 59 + IpOrganization.GetHashCode();
            }

            if (LastPage != null)
            {
                hash = hash * 59 + LastPage.GetHashCode();
            }

            if (MktCampaign != null)
            {
                hash = hash * 59 + MktCampaign.GetHashCode();
            }

            if (Referrer != null)
            {
                hash = hash * 59 + Referrer.GetHashCode();
            }

            if (App != null)
            {
                hash = hash * 59 + App.GetHashCode();
            }

            if (SdkLibrary != null)
            {
                hash = hash * 59 + SdkLibrary.GetHashCode();
            }

            if (NetworkConnectivity != null)
            {
                hash = hash * 59 + NetworkConnectivity.GetHashCode();
            }

            if (SearchTerms != null)
            {
                hash = hash * 59 + SearchTerms.GetHashCode();
            }

            if (UserAgentString != null)
            {
                hash = hash * 59 + UserAgentString.GetHashCode();
            }

            if (DurationInSeconds != null)
            {
                hash = hash * 59 + DurationInSeconds.GetHashCode();
            }

            if (EventCount != null)
            {
                hash = hash * 59 + EventCount.GetHashCode();
            }

            if (PageviewCount != null)
            {
                hash = hash * 59 + PageviewCount.GetHashCode();
            }

            if (ScreenviewCount != null)
            {
                hash = hash * 59 + ScreenviewCount.GetHashCode();
            }

            if (LastEvent != null)
            {
                hash = hash * 59 + LastEvent.GetHashCode();
            }

            if (LastConnectedQueue != null)
            {
                hash = hash * 59 + LastConnectedQueue.GetHashCode();
            }

            if (LastConnectedUser != null)
            {
                hash = hash * 59 + LastConnectedUser.GetHashCode();
            }

            if (LastUserDisposition != null)
            {
                hash = hash * 59 + LastUserDisposition.GetHashCode();
            }

            if (ConversationChannels != null)
            {
                hash = hash * 59 + ConversationChannels.GetHashCode();
            }

            if (OriginatingDirection != null)
            {
                hash = hash * 59 + OriginatingDirection.GetHashCode();
            }

            if (ConversationSubject != null)
            {
                hash = hash * 59 + ConversationSubject.GetHashCode();
            }

            if (LastUserDisconnectType != null)
            {
                hash = hash * 59 + LastUserDisconnectType.GetHashCode();
            }

            if (LastAcdOutcome != null)
            {
                hash = hash * 59 + LastAcdOutcome.GetHashCode();
            }

            if (Authenticated != null)
            {
                hash = hash * 59 + Authenticated.GetHashCode();
            }

            if (DivisionIds != null)
            {
                hash = hash * 59 + DivisionIds.GetHashCode();
            }

            if (LastScreen != null)
            {
                hash = hash * 59 + LastScreen.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (EndedDate != null)
            {
                hash = hash * 59 + EndedDate.GetHashCode();
            }

            if (ExternalContact != null)
            {
                hash = hash * 59 + ExternalContact.GetHashCode();
            }

            if (AwayDate != null)
            {
                hash = hash * 59 + AwayDate.GetHashCode();
            }

            if (IdleDate != null)
            {
                hash = hash * 59 + IdleDate.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            return hash;
        }
    }
}
