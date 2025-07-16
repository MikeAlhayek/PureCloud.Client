using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Session
{
    /// <summary>
    /// The original direction of the conversation.
    /// </summary>
    /// <value>The original direction of the conversation.</value>
    public SessionOriginatingDirectionEnum? OriginatingDirection { get; set; }

    /// <summary>
    /// Disconnect reason for the last user connected to the conversation.
    /// </summary>
    /// <value>Disconnect reason for the last user connected to the conversation.</value>
    public SessionLastUserDisconnectTypeEnum? LastUserDisconnectType { get; set; }

    /// <summary>
    /// Last ACD outcome for the conversation.
    /// </summary>
    /// <value>Last ACD outcome for the conversation.</value>
    public SessionLastAcdOutcomeEnum? LastAcdOutcome { get; set; }

    /// <summary>
    /// The ID of the session.
    /// </summary>
    /// <value>The ID of the session.</value>
    public string Id { get; set; }

    /// <summary>
    /// Primary identifier of the customer in the source where the events for the session originate from.
    /// </summary>
    /// <value>Primary identifier of the customer in the source where the events for the session originate from.</value>
    public string CustomerId { get; set; }

    /// <summary>
    /// Type of source customer identifier (e.g. cookie, email, phone).
    /// </summary>
    /// <value>Type of source customer identifier (e.g. cookie, email, phone).</value>
    public string CustomerIdType { get; set; }

    /// <summary>
    /// Session types indicate the type or category of sessions (e.g. web, app).
    /// </summary>
    /// <value>Session types indicate the type or category of sessions (e.g. web, app).</value>
    public string Type { get; set; }

    /// <summary>
    /// Unique identifier in the external system where the events for the session originate from.
    /// </summary>
    /// <value>Unique identifier in the external system where the events for the session originate from.</value>
    public string ExternalId { get; set; }

    /// <summary>
    /// A URL that identifies an external system-of-record resource that may have more detailed information on the session.
    /// </summary>
    /// <value>A URL that identifies an external system-of-record resource that may have more detailed information on the session.</value>
    public string ExternalUrl { get; set; }

    /// <summary>
    /// Shortened numeric identifier of 4-6 digits.
    /// </summary>
    /// <value>Shortened numeric identifier of 4-6 digits.</value>
    public string ShortId { get; set; }

    /// <summary>
    /// List of the outcome achievements by the customer in this session.
    /// </summary>
    /// <value>List of the outcome achievements by the customer in this session.</value>
    public IEnumerable<OutcomeAchievement> OutcomeAchievements { get; set; }

    /// <summary>
    /// List of the segment assignments to the customer in this session.
    /// </summary>
    /// <value>List of the segment assignments to the customer in this session.</value>
    public IEnumerable<SessionSegmentAssignment> SegmentAssignments { get; set; }

    /// <summary>
    /// Attributes projected from the session&#39;s event stream.
    /// </summary>
    /// <value>Attributes projected from the session&#39;s event stream.</value>
    public Dictionary<string, CustomEventAttribute> Attributes { get; set; }

    /// <summary>
    /// List-type attributes projected from the session&#39;s event stream.
    /// </summary>
    /// <value>List-type attributes projected from the session&#39;s event stream.</value>
    public Dictionary<string, CustomEventAttributeList> AttributeLists { get; set; }

    /// <summary>
    /// Customer&#39;s browser.
    /// </summary>
    /// <value>Customer&#39;s browser.</value>
    public Browser Browser { get; set; }

    /// <summary>
    /// Customer&#39;s device.
    /// </summary>
    public Device Device { get; set; }

    /// <summary>
    /// Customer&#39;s geolocation.
    /// </summary>
    /// <value>Customer&#39;s geolocation.</value>
    public JourneyGeolocation Geolocation { get; set; }

    /// <summary>
    /// Customer&#39;s IP address.
    /// </summary>
    /// <value>Customer&#39;s IP address.</value>
    public string IpAddress { get; set; }

    /// <summary>
    /// Customer&#39;s IP-based organization or ISP name.
    /// </summary>
    /// <value>Customer&#39;s IP-based organization or ISP name.</value>
    public string IpOrganization { get; set; }

    /// <summary>
    /// The webpage where the customer&#39;s last web interaction occurred.
    /// </summary>
    public JourneyPage LastPage { get; set; }

    /// <summary>
    /// Marketing / traffic source information.
    /// </summary>
    /// <value>Marketing / traffic source information.</value>
    public JourneyCampaign MktCampaign { get; set; }

    /// <summary>
    /// Identifies the page URL that originally generated the request for the current page being viewed.
    /// </summary>
    /// <value>Identifies the page URL that originally generated the request for the current page being viewed.</value>
    public Referrer Referrer { get; set; }

    /// <summary>
    /// Application that the customer is interacting with (for app sessions).
    /// </summary>
    /// <value>Application that the customer is interacting with (for app sessions).</value>
    public JourneyApp App { get; set; }

    /// <summary>
    /// SDK library used to generate the events for the session (for app and web sessions).
    /// </summary>
    /// <value>SDK library used to generate the events for the session (for app and web sessions).</value>
    public SdkLibrary SdkLibrary { get; set; }

    /// <summary>
    /// Information relating to the device&#39;s network connectivity (for app sessions).
    /// </summary>
    /// <value>Information relating to the device&#39;s network connectivity (for app sessions).</value>
    public NetworkConnectivity NetworkConnectivity { get; set; }

    /// <summary>
    /// Search terms associated with the session.
    /// </summary>
    /// <value>Search terms associated with the session.</value>
    public IEnumerable<string> SearchTerms { get; set; }

    /// <summary>
    /// String identifying the user agent.
    /// </summary>
    /// <value>String identifying the user agent.</value>
    public string UserAgentString { get; set; }

    /// <summary>
    /// Indicates how long the session has been active (valid for an individual device).
    /// </summary>
    /// <value>Indicates how long the session has been active (valid for an individual device).</value>
    public int? DurationInSeconds { get; set; }

    /// <summary>
    /// The count of all events performed during the session.
    /// </summary>
    /// <value>The count of all events performed during the session.</value>
    public int? EventCount { get; set; }

    /// <summary>
    /// The count of all pageviews performed during the session.
    /// </summary>
    /// <value>The count of all pageviews performed during the session.</value>
    public int? PageviewCount { get; set; }

    /// <summary>
    /// The count of all screenviews performed during the session.
    /// </summary>
    /// <value>The count of all screenviews performed during the session.</value>
    public int? ScreenviewCount { get; set; }

    /// <summary>
    /// Information about the most recent event in this session.
    /// </summary>
    /// <value>Information about the most recent event in this session.</value>
    public SessionLastEvent LastEvent { get; set; }

    /// <summary>
    /// The last queue connected to this session.
    /// </summary>
    /// <value>The last queue connected to this session.</value>
    public ConnectedQueue LastConnectedQueue { get; set; }

    /// <summary>
    /// The last user connected to this session.
    /// </summary>
    /// <value>The last user connected to this session.</value>
    public ConnectedUser LastConnectedUser { get; set; }

    /// <summary>
    /// The last user disposition connected to this session.
    /// </summary>
    /// <value>The last user disposition connected to this session.</value>
    public ConversationUserDisposition LastUserDisposition { get; set; }

    /// <summary>
    /// Represents the channels used for this conversation.
    /// </summary>
    /// <value>Represents the channels used for this conversation.</value>
    public IEnumerable<ConversationChannel> ConversationChannels { get; set; }

    /// <summary>
    /// The subject for the conversation, for example an email subject.
    /// </summary>
    /// <value>The subject for the conversation, for example an email subject.</value>
    public string ConversationSubject { get; set; }

    /// <summary>
    /// Indicates whether or not the session is authenticated.
    /// </summary>
    /// <value>Indicates whether or not the session is authenticated.</value>
    public bool? Authenticated { get; set; }

    /// <summary>
    /// List of division IDs associated with the session.
    /// </summary>
    /// <value>List of division IDs associated with the session.</value>
    public IEnumerable<string> DivisionIds { get; set; }

    /// <summary>
    /// The app screen name where the customer&#39;s last app interaction occurred.
    /// </summary>
    /// <value>The app screen name where the customer&#39;s last app interaction occurred.</value>
    public string LastScreen { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the session was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Timestamp indicating when the session was ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the session was ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EndedDate { get; set; }

    /// <summary>
    /// The external contact associated with this session.
    /// </summary>
    /// <value>The external contact associated with this session.</value>
    public AddressableEntityRef ExternalContact { get; set; }

    /// <summary>
    /// Timestamp indicating when the visitor should be considered as away. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the visitor should be considered as away. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? AwayDate { get; set; }

    /// <summary>
    /// Timestamp indicating when the visitor should be considered as idle. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the visitor should be considered as idle. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? IdleDate { get; set; }

    /// <summary>
    /// The conversation for this session.
    /// </summary>
    /// <value>The conversation for this session.</value>
    public AddressableEntityRef Conversation { get; set; }
}
