using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class JourneySessionEventsNotificationSessionEvent
{
    /// <summary>
    /// Gets or Sets OriginatingDirection
    /// </summary>
    public JourneySessionEventsNotificationSessionEventOriginatingDirectionEnum? OriginatingDirection { get; set; }

    /// <summary>
    /// Gets or Sets LastUserDisconnectType
    /// </summary>
    public JourneySessionEventsNotificationSessionEventLastUserDisconnectTypeEnum? LastUserDisconnectType { get; set; }

    /// <summary>
    /// Gets or Sets LastAcdOutcome
    /// </summary>
    public JourneySessionEventsNotificationSessionEventLastAcdOutcomeEnum? LastAcdOutcome { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Gets or Sets EndedDate
    /// </summary>
    public DateTime? EndedDate { get; set; }

    /// <summary>
    /// Gets or Sets ExternalContact
    /// </summary>
    public JourneySessionEventsNotificationExternalContact ExternalContact { get; set; }

    /// <summary>
    /// Gets or Sets CustomerId
    /// </summary>
    public string CustomerId { get; set; }

    /// <summary>
    /// Gets or Sets CustomerIdType
    /// </summary>
    public string CustomerIdType { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets OutcomeAchievements
    /// </summary>
    public IEnumerable<JourneySessionEventsNotificationOutcomeAchievement> OutcomeAchievements { get; set; }

    /// <summary>
    /// Gets or Sets SegmentAssignments
    /// </summary>
    public IEnumerable<JourneySessionEventsNotificationSegmentAssignment> SegmentAssignments { get; set; }

    /// <summary>
    /// Gets or Sets AwayDate
    /// </summary>
    public DateTime? AwayDate { get; set; }

    /// <summary>
    /// Gets or Sets Browser
    /// </summary>
    public JourneySessionEventsNotificationBrowser Browser { get; set; }

    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    public JourneySessionEventsNotificationDevice Device { get; set; }

    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    public JourneySessionEventsNotificationGeoLocation Geolocation { get; set; }

    /// <summary>
    /// Gets or Sets IdleDate
    /// </summary>
    public DateTime? IdleDate { get; set; }

    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    public string IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets IpOrganization
    /// </summary>
    public string IpOrganization { get; set; }

    /// <summary>
    /// Gets or Sets LastPage
    /// </summary>
    public JourneySessionEventsNotificationPage LastPage { get; set; }

    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    public JourneySessionEventsNotificationMktCampaign MktCampaign { get; set; }

    /// <summary>
    /// Gets or Sets Referrer
    /// </summary>
    public JourneySessionEventsNotificationReferrer Referrer { get; set; }

    /// <summary>
    /// Gets or Sets SearchTerms
    /// </summary>
    public IEnumerable<string> SearchTerms { get; set; }

    /// <summary>
    /// Gets or Sets UserAgentString
    /// </summary>
    public string UserAgentString { get; set; }

    /// <summary>
    /// Gets or Sets DurationInSeconds
    /// </summary>
    public long? DurationInSeconds { get; set; }

    /// <summary>
    /// Gets or Sets EventCount
    /// </summary>
    public long? EventCount { get; set; }

    /// <summary>
    /// Gets or Sets PageviewCount
    /// </summary>
    public long? PageviewCount { get; set; }

    /// <summary>
    /// Gets or Sets ScreenviewCount
    /// </summary>
    public long? ScreenviewCount { get; set; }

    /// <summary>
    /// Gets or Sets LastEvent
    /// </summary>
    public JourneySessionEventsNotificationSessionLastEvent LastEvent { get; set; }

    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    public JourneySessionEventsNotificationConversation Conversation { get; set; }

    /// <summary>
    /// Gets or Sets ConversationSubject
    /// </summary>
    public string ConversationSubject { get; set; }

    /// <summary>
    /// Gets or Sets LastUserDisposition
    /// </summary>
    public JourneySessionEventsNotificationConversationUserDisposition LastUserDisposition { get; set; }

    /// <summary>
    /// Gets or Sets LastConnectedUser
    /// </summary>
    public JourneySessionEventsNotificationUser LastConnectedUser { get; set; }

    /// <summary>
    /// Gets or Sets LastConnectedQueue
    /// </summary>
    public JourneySessionEventsNotificationConnectedQueue LastConnectedQueue { get; set; }

    /// <summary>
    /// Gets or Sets ConversationChannels
    /// </summary>
    public IEnumerable<JourneySessionEventsNotificationConversationChannel> ConversationChannels { get; set; }

    /// <summary>
    /// Gets or Sets Authenticated
    /// </summary>
    public bool? Authenticated { get; set; }

    /// <summary>
    /// Gets or Sets App
    /// </summary>
    public JourneySessionEventsNotificationApp App { get; set; }

    /// <summary>
    /// Gets or Sets SdkLibrary
    /// </summary>
    public JourneySessionEventsNotificationSdkLibrary SdkLibrary { get; set; }

    /// <summary>
    /// Gets or Sets NetworkConnectivity
    /// </summary>
    public JourneySessionEventsNotificationNetworkConnectivity NetworkConnectivity { get; set; }

    /// <summary>
    /// Gets or Sets DivisionIds
    /// </summary>
    public IEnumerable<string> DivisionIds { get; set; }

    /// <summary>
    /// Gets or Sets LastScreen
    /// </summary>
    public string LastScreen { get; set; }
}
