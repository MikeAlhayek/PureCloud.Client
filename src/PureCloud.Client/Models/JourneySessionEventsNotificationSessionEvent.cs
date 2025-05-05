using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySessionEventsNotificationSessionEvent
/// </summary>

public partial class JourneySessionEventsNotificationSessionEvent : IEquatable<JourneySessionEventsNotificationSessionEvent>
{
    /// <summary>
    /// Gets or Sets OriginatingDirection
    /// </summary>
    
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
    /// Gets or Sets LastUserDisconnectType
    /// </summary>
    
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
    /// Gets or Sets LastAcdOutcome
    /// </summary>
    
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
    /// Gets or Sets OriginatingDirection
    /// </summary>
    [JsonPropertyName("originatingDirection")]
    public OriginatingDirectionEnum? OriginatingDirection { get; set; }
    /// <summary>
    /// Gets or Sets LastUserDisconnectType
    /// </summary>
    [JsonPropertyName("lastUserDisconnectType")]
    public LastUserDisconnectTypeEnum? LastUserDisconnectType { get; set; }
    /// <summary>
    /// Gets or Sets LastAcdOutcome
    /// </summary>
    [JsonPropertyName("lastAcdOutcome")]
    public LastAcdOutcomeEnum? LastAcdOutcome { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationSessionEvent" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="CreatedDate">CreatedDate.</param>
    /// <param name="EndedDate">EndedDate.</param>
    /// <param name="ExternalContact">ExternalContact.</param>
    /// <param name="CustomerId">CustomerId.</param>
    /// <param name="CustomerIdType">CustomerIdType.</param>
    /// <param name="Type">Type.</param>
    /// <param name="OutcomeAchievements">OutcomeAchievements.</param>
    /// <param name="SegmentAssignments">SegmentAssignments.</param>
    /// <param name="AwayDate">AwayDate.</param>
    /// <param name="Browser">Browser.</param>
    /// <param name="Device">Device.</param>
    /// <param name="Geolocation">Geolocation.</param>
    /// <param name="IdleDate">IdleDate.</param>
    /// <param name="IpAddress">IpAddress.</param>
    /// <param name="IpOrganization">IpOrganization.</param>
    /// <param name="LastPage">LastPage.</param>
    /// <param name="MktCampaign">MktCampaign.</param>
    /// <param name="Referrer">Referrer.</param>
    /// <param name="SearchTerms">SearchTerms.</param>
    /// <param name="UserAgentString">UserAgentString.</param>
    /// <param name="DurationInSeconds">DurationInSeconds.</param>
    /// <param name="EventCount">EventCount.</param>
    /// <param name="PageviewCount">PageviewCount.</param>
    /// <param name="ScreenviewCount">ScreenviewCount.</param>
    /// <param name="LastEvent">LastEvent.</param>
    /// <param name="Conversation">Conversation.</param>
    /// <param name="OriginatingDirection">OriginatingDirection.</param>
    /// <param name="ConversationSubject">ConversationSubject.</param>
    /// <param name="LastUserDisposition">LastUserDisposition.</param>
    /// <param name="LastConnectedUser">LastConnectedUser.</param>
    /// <param name="LastConnectedQueue">LastConnectedQueue.</param>
    /// <param name="ConversationChannels">ConversationChannels.</param>
    /// <param name="LastUserDisconnectType">LastUserDisconnectType.</param>
    /// <param name="LastAcdOutcome">LastAcdOutcome.</param>
    /// <param name="Authenticated">Authenticated.</param>
    /// <param name="App">App.</param>
    /// <param name="SdkLibrary">SdkLibrary.</param>
    /// <param name="NetworkConnectivity">NetworkConnectivity.</param>
    /// <param name="DivisionIds">DivisionIds.</param>
    /// <param name="LastScreen">LastScreen.</param>
    public JourneySessionEventsNotificationSessionEvent(Guid? Id = null, string SelfUri = null, DateTime? CreatedDate = null, DateTime? EndedDate = null, JourneySessionEventsNotificationExternalContact ExternalContact = null, string CustomerId = null, string CustomerIdType = null, string Type = null, List<JourneySessionEventsNotificationOutcomeAchievement> OutcomeAchievements = null, List<JourneySessionEventsNotificationSegmentAssignment> SegmentAssignments = null, DateTime? AwayDate = null, JourneySessionEventsNotificationBrowser Browser = null, JourneySessionEventsNotificationDevice Device = null, JourneySessionEventsNotificationGeoLocation Geolocation = null, DateTime? IdleDate = null, string IpAddress = null, string IpOrganization = null, JourneySessionEventsNotificationPage LastPage = null, JourneySessionEventsNotificationMktCampaign MktCampaign = null, JourneySessionEventsNotificationReferrer Referrer = null, List<string> SearchTerms = null, string UserAgentString = null, long? DurationInSeconds = null, long? EventCount = null, long? PageviewCount = null, long? ScreenviewCount = null, JourneySessionEventsNotificationSessionLastEvent LastEvent = null, JourneySessionEventsNotificationConversation Conversation = null, OriginatingDirectionEnum? OriginatingDirection = null, string ConversationSubject = null, JourneySessionEventsNotificationConversationUserDisposition LastUserDisposition = null, JourneySessionEventsNotificationUser LastConnectedUser = null, JourneySessionEventsNotificationConnectedQueue LastConnectedQueue = null, List<JourneySessionEventsNotificationConversationChannel> ConversationChannels = null, LastUserDisconnectTypeEnum? LastUserDisconnectType = null, LastAcdOutcomeEnum? LastAcdOutcome = null, bool? Authenticated = null, JourneySessionEventsNotificationApp App = null, JourneySessionEventsNotificationSdkLibrary SdkLibrary = null, JourneySessionEventsNotificationNetworkConnectivity NetworkConnectivity = null, List<string> DivisionIds = null, string LastScreen = null)
    {
        this.Id = Id;
        this.SelfUri = SelfUri;
        this.CreatedDate = CreatedDate;
        this.EndedDate = EndedDate;
        this.ExternalContact = ExternalContact;
        this.CustomerId = CustomerId;
        this.CustomerIdType = CustomerIdType;
        this.Type = Type;
        this.OutcomeAchievements = OutcomeAchievements;
        this.SegmentAssignments = SegmentAssignments;
        this.AwayDate = AwayDate;
        this.Browser = Browser;
        this.Device = Device;
        this.Geolocation = Geolocation;
        this.IdleDate = IdleDate;
        this.IpAddress = IpAddress;
        this.IpOrganization = IpOrganization;
        this.LastPage = LastPage;
        this.MktCampaign = MktCampaign;
        this.Referrer = Referrer;
        this.SearchTerms = SearchTerms;
        this.UserAgentString = UserAgentString;
        this.DurationInSeconds = DurationInSeconds;
        this.EventCount = EventCount;
        this.PageviewCount = PageviewCount;
        this.ScreenviewCount = ScreenviewCount;
        this.LastEvent = LastEvent;
        this.Conversation = Conversation;
        this.OriginatingDirection = OriginatingDirection;
        this.ConversationSubject = ConversationSubject;
        this.LastUserDisposition = LastUserDisposition;
        this.LastConnectedUser = LastConnectedUser;
        this.LastConnectedQueue = LastConnectedQueue;
        this.ConversationChannels = ConversationChannels;
        this.LastUserDisconnectType = LastUserDisconnectType;
        this.LastAcdOutcome = LastAcdOutcome;
        this.Authenticated = Authenticated;
        this.App = App;
        this.SdkLibrary = SdkLibrary;
        this.NetworkConnectivity = NetworkConnectivity;
        this.DivisionIds = DivisionIds;
        this.LastScreen = LastScreen;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Gets or Sets EndedDate
    /// </summary>
    [JsonPropertyName("endedDate")]
    public DateTime? EndedDate { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContact
    /// </summary>
    [JsonPropertyName("externalContact")]
    public JourneySessionEventsNotificationExternalContact ExternalContact { get; set; }



    /// <summary>
    /// Gets or Sets CustomerId
    /// </summary>
    [JsonPropertyName("customerId")]
    public string CustomerId { get; set; }



    /// <summary>
    /// Gets or Sets CustomerIdType
    /// </summary>
    [JsonPropertyName("customerIdType")]
    public string CustomerIdType { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets OutcomeAchievements
    /// </summary>
    [JsonPropertyName("outcomeAchievements")]
    public List<JourneySessionEventsNotificationOutcomeAchievement> OutcomeAchievements { get; set; }



    /// <summary>
    /// Gets or Sets SegmentAssignments
    /// </summary>
    [JsonPropertyName("segmentAssignments")]
    public List<JourneySessionEventsNotificationSegmentAssignment> SegmentAssignments { get; set; }



    /// <summary>
    /// Gets or Sets AwayDate
    /// </summary>
    [JsonPropertyName("awayDate")]
    public DateTime? AwayDate { get; set; }



    /// <summary>
    /// Gets or Sets Browser
    /// </summary>
    [JsonPropertyName("browser")]
    public JourneySessionEventsNotificationBrowser Browser { get; set; }



    /// <summary>
    /// Gets or Sets Device
    /// </summary>
    [JsonPropertyName("device")]
    public JourneySessionEventsNotificationDevice Device { get; set; }



    /// <summary>
    /// Gets or Sets Geolocation
    /// </summary>
    [JsonPropertyName("geolocation")]
    public JourneySessionEventsNotificationGeoLocation Geolocation { get; set; }



    /// <summary>
    /// Gets or Sets IdleDate
    /// </summary>
    [JsonPropertyName("idleDate")]
    public DateTime? IdleDate { get; set; }



    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }



    /// <summary>
    /// Gets or Sets IpOrganization
    /// </summary>
    [JsonPropertyName("ipOrganization")]
    public string IpOrganization { get; set; }



    /// <summary>
    /// Gets or Sets LastPage
    /// </summary>
    [JsonPropertyName("lastPage")]
    public JourneySessionEventsNotificationPage LastPage { get; set; }



    /// <summary>
    /// Gets or Sets MktCampaign
    /// </summary>
    [JsonPropertyName("mktCampaign")]
    public JourneySessionEventsNotificationMktCampaign MktCampaign { get; set; }



    /// <summary>
    /// Gets or Sets Referrer
    /// </summary>
    [JsonPropertyName("referrer")]
    public JourneySessionEventsNotificationReferrer Referrer { get; set; }



    /// <summary>
    /// Gets or Sets SearchTerms
    /// </summary>
    [JsonPropertyName("searchTerms")]
    public List<string> SearchTerms { get; set; }



    /// <summary>
    /// Gets or Sets UserAgentString
    /// </summary>
    [JsonPropertyName("userAgentString")]
    public string UserAgentString { get; set; }



    /// <summary>
    /// Gets or Sets DurationInSeconds
    /// </summary>
    [JsonPropertyName("durationInSeconds")]
    public long? DurationInSeconds { get; set; }



    /// <summary>
    /// Gets or Sets EventCount
    /// </summary>
    [JsonPropertyName("eventCount")]
    public long? EventCount { get; set; }



    /// <summary>
    /// Gets or Sets PageviewCount
    /// </summary>
    [JsonPropertyName("pageviewCount")]
    public long? PageviewCount { get; set; }



    /// <summary>
    /// Gets or Sets ScreenviewCount
    /// </summary>
    [JsonPropertyName("screenviewCount")]
    public long? ScreenviewCount { get; set; }



    /// <summary>
    /// Gets or Sets LastEvent
    /// </summary>
    [JsonPropertyName("lastEvent")]
    public JourneySessionEventsNotificationSessionLastEvent LastEvent { get; set; }



    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    [JsonPropertyName("conversation")]
    public JourneySessionEventsNotificationConversation Conversation { get; set; }





    /// <summary>
    /// Gets or Sets ConversationSubject
    /// </summary>
    [JsonPropertyName("conversationSubject")]
    public string ConversationSubject { get; set; }



    /// <summary>
    /// Gets or Sets LastUserDisposition
    /// </summary>
    [JsonPropertyName("lastUserDisposition")]
    public JourneySessionEventsNotificationConversationUserDisposition LastUserDisposition { get; set; }



    /// <summary>
    /// Gets or Sets LastConnectedUser
    /// </summary>
    [JsonPropertyName("lastConnectedUser")]
    public JourneySessionEventsNotificationUser LastConnectedUser { get; set; }



    /// <summary>
    /// Gets or Sets LastConnectedQueue
    /// </summary>
    [JsonPropertyName("lastConnectedQueue")]
    public JourneySessionEventsNotificationConnectedQueue LastConnectedQueue { get; set; }



    /// <summary>
    /// Gets or Sets ConversationChannels
    /// </summary>
    [JsonPropertyName("conversationChannels")]
    public List<JourneySessionEventsNotificationConversationChannel> ConversationChannels { get; set; }







    /// <summary>
    /// Gets or Sets Authenticated
    /// </summary>
    [JsonPropertyName("authenticated")]
    public bool? Authenticated { get; set; }



    /// <summary>
    /// Gets or Sets App
    /// </summary>
    [JsonPropertyName("app")]
    public JourneySessionEventsNotificationApp App { get; set; }



    /// <summary>
    /// Gets or Sets SdkLibrary
    /// </summary>
    [JsonPropertyName("sdkLibrary")]
    public JourneySessionEventsNotificationSdkLibrary SdkLibrary { get; set; }



    /// <summary>
    /// Gets or Sets NetworkConnectivity
    /// </summary>
    [JsonPropertyName("networkConnectivity")]
    public JourneySessionEventsNotificationNetworkConnectivity NetworkConnectivity { get; set; }



    /// <summary>
    /// Gets or Sets DivisionIds
    /// </summary>
    [JsonPropertyName("divisionIds")]
    public List<string> DivisionIds { get; set; }



    /// <summary>
    /// Gets or Sets LastScreen
    /// </summary>
    [JsonPropertyName("lastScreen")]
    public string LastScreen { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySessionEventsNotificationSessionEvent {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  EndedDate: ").Append(EndedDate).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
        sb.Append("  CustomerIdType: ").Append(CustomerIdType).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  OutcomeAchievements: ").Append(OutcomeAchievements).Append("\n");
        sb.Append("  SegmentAssignments: ").Append(SegmentAssignments).Append("\n");
        sb.Append("  AwayDate: ").Append(AwayDate).Append("\n");
        sb.Append("  Browser: ").Append(Browser).Append("\n");
        sb.Append("  Device: ").Append(Device).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  IdleDate: ").Append(IdleDate).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  IpOrganization: ").Append(IpOrganization).Append("\n");
        sb.Append("  LastPage: ").Append(LastPage).Append("\n");
        sb.Append("  MktCampaign: ").Append(MktCampaign).Append("\n");
        sb.Append("  Referrer: ").Append(Referrer).Append("\n");
        sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
        sb.Append("  UserAgentString: ").Append(UserAgentString).Append("\n");
        sb.Append("  DurationInSeconds: ").Append(DurationInSeconds).Append("\n");
        sb.Append("  EventCount: ").Append(EventCount).Append("\n");
        sb.Append("  PageviewCount: ").Append(PageviewCount).Append("\n");
        sb.Append("  ScreenviewCount: ").Append(ScreenviewCount).Append("\n");
        sb.Append("  LastEvent: ").Append(LastEvent).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
        sb.Append("  ConversationSubject: ").Append(ConversationSubject).Append("\n");
        sb.Append("  LastUserDisposition: ").Append(LastUserDisposition).Append("\n");
        sb.Append("  LastConnectedUser: ").Append(LastConnectedUser).Append("\n");
        sb.Append("  LastConnectedQueue: ").Append(LastConnectedQueue).Append("\n");
        sb.Append("  ConversationChannels: ").Append(ConversationChannels).Append("\n");
        sb.Append("  LastUserDisconnectType: ").Append(LastUserDisconnectType).Append("\n");
        sb.Append("  LastAcdOutcome: ").Append(LastAcdOutcome).Append("\n");
        sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
        sb.Append("  App: ").Append(App).Append("\n");
        sb.Append("  SdkLibrary: ").Append(SdkLibrary).Append("\n");
        sb.Append("  NetworkConnectivity: ").Append(NetworkConnectivity).Append("\n");
        sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
        sb.Append("  LastScreen: ").Append(LastScreen).Append("\n");
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
        return Equals(obj as JourneySessionEventsNotificationSessionEvent);
    }

    /// <summary>
    /// Returns true if JourneySessionEventsNotificationSessionEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySessionEventsNotificationSessionEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySessionEventsNotificationSessionEvent other)
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
                AwayDate == other.AwayDate ||
                AwayDate != null &&
                AwayDate.Equals(other.AwayDate)
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
                IdleDate == other.IdleDate ||
                IdleDate != null &&
                IdleDate.Equals(other.IdleDate)
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
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
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
                LastUserDisposition == other.LastUserDisposition ||
                LastUserDisposition != null &&
                LastUserDisposition.Equals(other.LastUserDisposition)
            ) &&
            (
                LastConnectedUser == other.LastConnectedUser ||
                LastConnectedUser != null &&
                LastConnectedUser.Equals(other.LastConnectedUser)
            ) &&
            (
                LastConnectedQueue == other.LastConnectedQueue ||
                LastConnectedQueue != null &&
                LastConnectedQueue.Equals(other.LastConnectedQueue)
            ) &&
            (
                ConversationChannels == other.ConversationChannels ||
                ConversationChannels != null &&
                ConversationChannels.SequenceEqual(other.ConversationChannels)
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
                DivisionIds == other.DivisionIds ||
                DivisionIds != null &&
                DivisionIds.SequenceEqual(other.DivisionIds)
            ) &&
            (
                LastScreen == other.LastScreen ||
                LastScreen != null &&
                LastScreen.Equals(other.LastScreen)
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

            if (OutcomeAchievements != null)
            {
                hash = hash * 59 + OutcomeAchievements.GetHashCode();
            }

            if (SegmentAssignments != null)
            {
                hash = hash * 59 + SegmentAssignments.GetHashCode();
            }

            if (AwayDate != null)
            {
                hash = hash * 59 + AwayDate.GetHashCode();
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

            if (IdleDate != null)
            {
                hash = hash * 59 + IdleDate.GetHashCode();
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

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (OriginatingDirection != null)
            {
                hash = hash * 59 + OriginatingDirection.GetHashCode();
            }

            if (ConversationSubject != null)
            {
                hash = hash * 59 + ConversationSubject.GetHashCode();
            }

            if (LastUserDisposition != null)
            {
                hash = hash * 59 + LastUserDisposition.GetHashCode();
            }

            if (LastConnectedUser != null)
            {
                hash = hash * 59 + LastConnectedUser.GetHashCode();
            }

            if (LastConnectedQueue != null)
            {
                hash = hash * 59 + LastConnectedQueue.GetHashCode();
            }

            if (ConversationChannels != null)
            {
                hash = hash * 59 + ConversationChannels.GetHashCode();
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

            if (DivisionIds != null)
            {
                hash = hash * 59 + DivisionIds.GetHashCode();
            }

            if (LastScreen != null)
            {
                hash = hash * 59 + LastScreen.GetHashCode();
            }

            return hash;
        }
    }
}
