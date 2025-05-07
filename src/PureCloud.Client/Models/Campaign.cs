using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Campaign
/// </summary>

public partial class Campaign : IEquatable<Campaign>
{
    /// <summary>
    /// The strategy this Campaign will use for dialing.
    /// </summary>
    /// <value>The strategy this Campaign will use for dialing.</value>
    
    public enum DialingModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Agentless for "agentless"
        /// </summary>
        [EnumMember(Value = "agentless")]
        Agentless,

        /// <summary>
        /// Enum Preview for "preview"
        /// </summary>
        [EnumMember(Value = "preview")]
        Preview,

        /// <summary>
        /// Enum Power for "power"
        /// </summary>
        [EnumMember(Value = "power")]
        Power,

        /// <summary>
        /// Enum Predictive for "predictive"
        /// </summary>
        [EnumMember(Value = "predictive")]
        Predictive,

        /// <summary>
        /// Enum Progressive for "progressive"
        /// </summary>
        [EnumMember(Value = "progressive")]
        Progressive,

        /// <summary>
        /// Enum External for "external"
        /// </summary>
        [EnumMember(Value = "external")]
        External
    }
    /// <summary>
    /// The current status of the Campaign. A Campaign may be turned 'on' or 'off'. Required for updates.
    /// </summary>
    /// <value>The current status of the Campaign. A Campaign may be turned 'on' or 'off'. Required for updates.</value>
    
    public enum CampaignStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum On for "on"
        /// </summary>
        [EnumMember(Value = "on")]
        On,

        /// <summary>
        /// Enum Stopping for "stopping"
        /// </summary>
        [EnumMember(Value = "stopping")]
        Stopping,

        /// <summary>
        /// Enum Off for "off"
        /// </summary>
        [EnumMember(Value = "off")]
        Off,

        /// <summary>
        /// Enum Complete for "complete"
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete,

        /// <summary>
        /// Enum Invalid for "invalid"
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid,

        /// <summary>
        /// Enum ForcedOff for "forced_off"
        /// </summary>
        [EnumMember(Value = "forced_off")]
        ForcedOff,

        /// <summary>
        /// Enum ForcedStopping for "forced_stopping"
        /// </summary>
        [EnumMember(Value = "forced_stopping")]
        ForcedStopping
    }
    /// <summary>
    /// The strategy this Campaign will use for dialing.
    /// </summary>
    /// <value>The strategy this Campaign will use for dialing.</value>
    [JsonPropertyName("dialingMode")]
    public DialingModeEnum? DialingMode { get; set; }
    /// <summary>
    /// The current status of the Campaign. A Campaign may be turned 'on' or 'off'. Required for updates.
    /// </summary>
    /// <value>The current status of the Campaign. A Campaign may be turned 'on' or 'off'. Required for updates.</value>
    [JsonPropertyName("campaignStatus")]
    public CampaignStatusEnum? CampaignStatus { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Campaign" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Campaign() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Campaign" /> class.
    /// </summary>
    /// <param name="Name">The name of the Campaign. (required).</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="ContactList">The ContactList for this Campaign to dial. (required).</param>
    /// <param name="Queue">The Queue for this Campaign to route calls to. Required for all dialing modes except agentless..</param>
    /// <param name="DialingMode">The strategy this Campaign will use for dialing. (required).</param>
    /// <param name="Script">The Script to be displayed to agents that are handling outbound calls. Required for all dialing modes except agentless..</param>
    /// <param name="EdgeGroup">The EdgeGroup that will place the calls. Required for all dialing modes except preview..</param>
    /// <param name="Site">The identifier of the site to be used for dialing; can be set in place of an edge group..</param>
    /// <param name="CampaignStatus">The current status of the Campaign. A Campaign may be turned &#39;on&#39; or &#39;off&#39;. Required for updates..</param>
    /// <param name="PhoneColumns">The ContactPhoneNumberColumns on the ContactList that this Campaign should dial. (required).</param>
    /// <param name="AbandonRate">The targeted compliance abandon rate percentage. Required for power and predictive campaigns..</param>
    /// <param name="DncLists">DncLists for this Campaign to check before placing a call..</param>
    /// <param name="CallableTimeSet">The callable time set for this campaign to check before placing a call..</param>
    /// <param name="CallAnalysisResponseSet">The call analysis response set to handle call analysis results from the edge. Required for all dialing modes except preview..</param>
    /// <param name="CallerName">The caller id name to be displayed on the outbound call. (required).</param>
    /// <param name="CallerAddress">The caller id phone number to be displayed on the outbound call. (required).</param>
    /// <param name="OutboundLineCount">The number of outbound lines to be concurrently dialed. Only applicable to non-preview campaigns; only required for agentless..</param>
    /// <param name="RuleSets">Rule sets to be applied while this campaign is dialing..</param>
    /// <param name="SkipPreviewDisabled">Whether or not agents can skip previews without placing a call. Only applicable for preview campaigns..</param>
    /// <param name="PreviewTimeOutSeconds">The number of seconds before a call will be automatically placed on a preview. A value of 0 indicates no automatic placement of calls. Only applicable to preview campaigns..</param>
    /// <param name="AlwaysRunning">Indicates (when true) that the campaign will remain on after contacts are depleted, allowing additional contacts to be appended/added to the contact list and processed by the still-running campaign. The campaign can still be turned off manually..</param>
    /// <param name="ContactSort">The order in which to sort contacts for dialing, based on a column..</param>
    /// <param name="ContactSorts">The order in which to sort contacts for dialing, based on up to four columns..</param>
    /// <param name="NoAnswerTimeout">How long to wait before dispositioning a call as &#39;no-answer&#39;. Default 30 seconds. Only applicable to non-preview campaigns..</param>
    /// <param name="CallAnalysisLanguage">The language the edge will use to analyze the call..</param>
    /// <param name="Priority">The priority of this campaign relative to other campaigns that are running on the same queue. 5 is the highest priority, 1 the lowest..</param>
    /// <param name="ContactListFilters">Filter to apply to the contact list before dialing. Currently a campaign can only have one filter applied..</param>
    /// <param name="Division">The division this campaign belongs to..</param>
    /// <param name="AgentOwnedColumn">Name of the contact list column containing the id of the agent who owns the record. Only applicable to preview campaigns..</param>
    /// <param name="DynamicContactQueueingSettings">Settings for dynamic queueing of contacts..</param>
    /// <param name="SkillColumns">The skill columns on the ContactList that this Campaign should take into account when dialing.</param>
    /// <param name="MaxCallsPerAgent">The maximum number of calls that can be placed per agent on this campaign.</param>
    /// <param name="MaxCallsPerAgentDecimal">The maximum number of calls that can be placed per agent on this campaign with decimal precision.</param>
    /// <param name="CallbackAutoAnswer">The option manages the auto-answer callback calls.</param>
    /// <param name="DynamicLineBalancingSettings">Dynamic line balancing settings.</param>
    public Campaign(string Name = null, int? Version = null, DomainEntityRef ContactList = null, DomainEntityRef Queue = null, DialingModeEnum? DialingMode = null, DomainEntityRef Script = null, DomainEntityRef EdgeGroup = null, DomainEntityRef Site = null, CampaignStatusEnum? CampaignStatus = null, List<PhoneColumn> PhoneColumns = null, double? AbandonRate = null, List<DomainEntityRef> DncLists = null, DomainEntityRef CallableTimeSet = null, DomainEntityRef CallAnalysisResponseSet = null, string CallerName = null, string CallerAddress = null, int? OutboundLineCount = null, List<DomainEntityRef> RuleSets = null, bool? SkipPreviewDisabled = null, long? PreviewTimeOutSeconds = null, bool? AlwaysRunning = null, ContactSort ContactSort = null, List<ContactSort> ContactSorts = null, int? NoAnswerTimeout = null, string CallAnalysisLanguage = null, int? Priority = null, List<DomainEntityRef> ContactListFilters = null, DomainEntityRef Division = null, string AgentOwnedColumn = null, DynamicContactQueueingSettings DynamicContactQueueingSettings = null, List<string> SkillColumns = null, int? MaxCallsPerAgent = null, double? MaxCallsPerAgentDecimal = null, bool? CallbackAutoAnswer = null, DynamicLineBalancingSettings DynamicLineBalancingSettings = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.ContactList = ContactList;
        this.Queue = Queue;
        this.DialingMode = DialingMode;
        this.Script = Script;
        this.EdgeGroup = EdgeGroup;
        this.Site = Site;
        this.CampaignStatus = CampaignStatus;
        this.PhoneColumns = PhoneColumns;
        this.AbandonRate = AbandonRate;
        this.DncLists = DncLists;
        this.CallableTimeSet = CallableTimeSet;
        this.CallAnalysisResponseSet = CallAnalysisResponseSet;
        this.CallerName = CallerName;
        this.CallerAddress = CallerAddress;
        this.OutboundLineCount = OutboundLineCount;
        this.RuleSets = RuleSets;
        this.SkipPreviewDisabled = SkipPreviewDisabled;
        this.PreviewTimeOutSeconds = PreviewTimeOutSeconds;
        this.AlwaysRunning = AlwaysRunning;
        this.ContactSort = ContactSort;
        this.ContactSorts = ContactSorts;
        this.NoAnswerTimeout = NoAnswerTimeout;
        this.CallAnalysisLanguage = CallAnalysisLanguage;
        this.Priority = Priority;
        this.ContactListFilters = ContactListFilters;
        this.Division = Division;
        this.AgentOwnedColumn = AgentOwnedColumn;
        this.DynamicContactQueueingSettings = DynamicContactQueueingSettings;
        this.SkillColumns = SkillColumns;
        this.MaxCallsPerAgent = MaxCallsPerAgent;
        this.MaxCallsPerAgentDecimal = MaxCallsPerAgentDecimal;
        this.CallbackAutoAnswer = CallbackAutoAnswer;
        this.DynamicLineBalancingSettings = DynamicLineBalancingSettings;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the Campaign.
    /// </summary>
    /// <value>The name of the Campaign.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The ContactList for this Campaign to dial.
    /// </summary>
    /// <value>The ContactList for this Campaign to dial.</value>
    [JsonPropertyName("contactList")]
    public DomainEntityRef ContactList { get; set; }



    /// <summary>
    /// The Queue for this Campaign to route calls to. Required for all dialing modes except agentless.
    /// </summary>
    /// <value>The Queue for this Campaign to route calls to. Required for all dialing modes except agentless.</value>
    [JsonPropertyName("queue")]
    public DomainEntityRef Queue { get; set; }





    /// <summary>
    /// The Script to be displayed to agents that are handling outbound calls. Required for all dialing modes except agentless.
    /// </summary>
    /// <value>The Script to be displayed to agents that are handling outbound calls. Required for all dialing modes except agentless.</value>
    [JsonPropertyName("script")]
    public DomainEntityRef Script { get; set; }



    /// <summary>
    /// The EdgeGroup that will place the calls. Required for all dialing modes except preview.
    /// </summary>
    /// <value>The EdgeGroup that will place the calls. Required for all dialing modes except preview.</value>
    [JsonPropertyName("edgeGroup")]
    public DomainEntityRef EdgeGroup { get; set; }



    /// <summary>
    /// The identifier of the site to be used for dialing; can be set in place of an edge group.
    /// </summary>
    /// <value>The identifier of the site to be used for dialing; can be set in place of an edge group.</value>
    [JsonPropertyName("site")]
    public DomainEntityRef Site { get; set; }





    /// <summary>
    /// The ContactPhoneNumberColumns on the ContactList that this Campaign should dial.
    /// </summary>
    /// <value>The ContactPhoneNumberColumns on the ContactList that this Campaign should dial.</value>
    [JsonPropertyName("phoneColumns")]
    public List<PhoneColumn> PhoneColumns { get; set; }



    /// <summary>
    /// The targeted compliance abandon rate percentage. Required for power and predictive campaigns.
    /// </summary>
    /// <value>The targeted compliance abandon rate percentage. Required for power and predictive campaigns.</value>
    [JsonPropertyName("abandonRate")]
    public double? AbandonRate { get; set; }



    /// <summary>
    /// DncLists for this Campaign to check before placing a call.
    /// </summary>
    /// <value>DncLists for this Campaign to check before placing a call.</value>
    [JsonPropertyName("dncLists")]
    public List<DomainEntityRef> DncLists { get; set; }



    /// <summary>
    /// The callable time set for this campaign to check before placing a call.
    /// </summary>
    /// <value>The callable time set for this campaign to check before placing a call.</value>
    [JsonPropertyName("callableTimeSet")]
    public DomainEntityRef CallableTimeSet { get; set; }



    /// <summary>
    /// The call analysis response set to handle call analysis results from the edge. Required for all dialing modes except preview.
    /// </summary>
    /// <value>The call analysis response set to handle call analysis results from the edge. Required for all dialing modes except preview.</value>
    [JsonPropertyName("callAnalysisResponseSet")]
    public DomainEntityRef CallAnalysisResponseSet { get; set; }



    /// <summary>
    /// A list of current error conditions associated with the campaign.
    /// </summary>
    /// <value>A list of current error conditions associated with the campaign.</value>
    [JsonPropertyName("errors")]
    public List<RestErrorDetail> Errors { get; set; }



    /// <summary>
    /// The caller id name to be displayed on the outbound call.
    /// </summary>
    /// <value>The caller id name to be displayed on the outbound call.</value>
    [JsonPropertyName("callerName")]
    public string CallerName { get; set; }



    /// <summary>
    /// The caller id phone number to be displayed on the outbound call.
    /// </summary>
    /// <value>The caller id phone number to be displayed on the outbound call.</value>
    [JsonPropertyName("callerAddress")]
    public string CallerAddress { get; set; }



    /// <summary>
    /// The number of outbound lines to be concurrently dialed. Only applicable to non-preview campaigns; only required for agentless.
    /// </summary>
    /// <value>The number of outbound lines to be concurrently dialed. Only applicable to non-preview campaigns; only required for agentless.</value>
    [JsonPropertyName("outboundLineCount")]
    public int? OutboundLineCount { get; set; }



    /// <summary>
    /// Rule sets to be applied while this campaign is dialing.
    /// </summary>
    /// <value>Rule sets to be applied while this campaign is dialing.</value>
    [JsonPropertyName("ruleSets")]
    public List<DomainEntityRef> RuleSets { get; set; }



    /// <summary>
    /// Whether or not agents can skip previews without placing a call. Only applicable for preview campaigns.
    /// </summary>
    /// <value>Whether or not agents can skip previews without placing a call. Only applicable for preview campaigns.</value>
    [JsonPropertyName("skipPreviewDisabled")]
    public bool? SkipPreviewDisabled { get; set; }



    /// <summary>
    /// The number of seconds before a call will be automatically placed on a preview. A value of 0 indicates no automatic placement of calls. Only applicable to preview campaigns.
    /// </summary>
    /// <value>The number of seconds before a call will be automatically placed on a preview. A value of 0 indicates no automatic placement of calls. Only applicable to preview campaigns.</value>
    [JsonPropertyName("previewTimeOutSeconds")]
    public long? PreviewTimeOutSeconds { get; set; }



    /// <summary>
    /// Indicates (when true) that the campaign will remain on after contacts are depleted, allowing additional contacts to be appended/added to the contact list and processed by the still-running campaign. The campaign can still be turned off manually.
    /// </summary>
    /// <value>Indicates (when true) that the campaign will remain on after contacts are depleted, allowing additional contacts to be appended/added to the contact list and processed by the still-running campaign. The campaign can still be turned off manually.</value>
    [JsonPropertyName("alwaysRunning")]
    public bool? AlwaysRunning { get; set; }



    /// <summary>
    /// The order in which to sort contacts for dialing, based on a column.
    /// </summary>
    /// <value>The order in which to sort contacts for dialing, based on a column.</value>
    [JsonPropertyName("contactSort")]
    public ContactSort ContactSort { get; set; }



    /// <summary>
    /// The order in which to sort contacts for dialing, based on up to four columns.
    /// </summary>
    /// <value>The order in which to sort contacts for dialing, based on up to four columns.</value>
    [JsonPropertyName("contactSorts")]
    public List<ContactSort> ContactSorts { get; set; }



    /// <summary>
    /// How long to wait before dispositioning a call as &#39;no-answer&#39;. Default 30 seconds. Only applicable to non-preview campaigns.
    /// </summary>
    /// <value>How long to wait before dispositioning a call as &#39;no-answer&#39;. Default 30 seconds. Only applicable to non-preview campaigns.</value>
    [JsonPropertyName("noAnswerTimeout")]
    public int? NoAnswerTimeout { get; set; }



    /// <summary>
    /// The language the edge will use to analyze the call.
    /// </summary>
    /// <value>The language the edge will use to analyze the call.</value>
    [JsonPropertyName("callAnalysisLanguage")]
    public string CallAnalysisLanguage { get; set; }



    /// <summary>
    /// The priority of this campaign relative to other campaigns that are running on the same queue. 5 is the highest priority, 1 the lowest.
    /// </summary>
    /// <value>The priority of this campaign relative to other campaigns that are running on the same queue. 5 is the highest priority, 1 the lowest.</value>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }



    /// <summary>
    /// Filter to apply to the contact list before dialing. Currently a campaign can only have one filter applied.
    /// </summary>
    /// <value>Filter to apply to the contact list before dialing. Currently a campaign can only have one filter applied.</value>
    [JsonPropertyName("contactListFilters")]
    public List<DomainEntityRef> ContactListFilters { get; set; }



    /// <summary>
    /// The division this campaign belongs to.
    /// </summary>
    /// <value>The division this campaign belongs to.</value>
    [JsonPropertyName("division")]
    public DomainEntityRef Division { get; set; }



    /// <summary>
    /// Name of the contact list column containing the id of the agent who owns the record. Only applicable to preview campaigns.
    /// </summary>
    /// <value>Name of the contact list column containing the id of the agent who owns the record. Only applicable to preview campaigns.</value>
    [JsonPropertyName("agentOwnedColumn")]
    public string AgentOwnedColumn { get; set; }



    /// <summary>
    /// Settings for dynamic queueing of contacts.
    /// </summary>
    /// <value>Settings for dynamic queueing of contacts.</value>
    [JsonPropertyName("dynamicContactQueueingSettings")]
    public DynamicContactQueueingSettings DynamicContactQueueingSettings { get; set; }



    /// <summary>
    /// The skill columns on the ContactList that this Campaign should take into account when dialing
    /// </summary>
    /// <value>The skill columns on the ContactList that this Campaign should take into account when dialing</value>
    [JsonPropertyName("skillColumns")]
    public List<string> SkillColumns { get; set; }



    /// <summary>
    /// The maximum number of calls that can be placed per agent on this campaign
    /// </summary>
    /// <value>The maximum number of calls that can be placed per agent on this campaign</value>
    [JsonPropertyName("maxCallsPerAgent")]
    public int? MaxCallsPerAgent { get; set; }



    /// <summary>
    /// The maximum number of calls that can be placed per agent on this campaign with decimal precision
    /// </summary>
    /// <value>The maximum number of calls that can be placed per agent on this campaign with decimal precision</value>
    [JsonPropertyName("maxCallsPerAgentDecimal")]
    public double? MaxCallsPerAgentDecimal { get; set; }



    /// <summary>
    /// The option manages the auto-answer callback calls
    /// </summary>
    /// <value>The option manages the auto-answer callback calls</value>
    [JsonPropertyName("callbackAutoAnswer")]
    public bool? CallbackAutoAnswer { get; set; }



    /// <summary>
    /// Dynamic line balancing settings
    /// </summary>
    /// <value>Dynamic line balancing settings</value>
    [JsonPropertyName("dynamicLineBalancingSettings")]
    public DynamicLineBalancingSettings DynamicLineBalancingSettings { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Campaign {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ContactList: ").Append(ContactList).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  DialingMode: ").Append(DialingMode).Append("\n");
        sb.Append("  Script: ").Append(Script).Append("\n");
        sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
        sb.Append("  Site: ").Append(Site).Append("\n");
        sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
        sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
        sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
        sb.Append("  DncLists: ").Append(DncLists).Append("\n");
        sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
        sb.Append("  CallAnalysisResponseSet: ").Append(CallAnalysisResponseSet).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  CallerName: ").Append(CallerName).Append("\n");
        sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
        sb.Append("  OutboundLineCount: ").Append(OutboundLineCount).Append("\n");
        sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
        sb.Append("  SkipPreviewDisabled: ").Append(SkipPreviewDisabled).Append("\n");
        sb.Append("  PreviewTimeOutSeconds: ").Append(PreviewTimeOutSeconds).Append("\n");
        sb.Append("  AlwaysRunning: ").Append(AlwaysRunning).Append("\n");
        sb.Append("  ContactSort: ").Append(ContactSort).Append("\n");
        sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
        sb.Append("  NoAnswerTimeout: ").Append(NoAnswerTimeout).Append("\n");
        sb.Append("  CallAnalysisLanguage: ").Append(CallAnalysisLanguage).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  ContactListFilters: ").Append(ContactListFilters).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  AgentOwnedColumn: ").Append(AgentOwnedColumn).Append("\n");
        sb.Append("  DynamicContactQueueingSettings: ").Append(DynamicContactQueueingSettings).Append("\n");
        sb.Append("  SkillColumns: ").Append(SkillColumns).Append("\n");
        sb.Append("  MaxCallsPerAgent: ").Append(MaxCallsPerAgent).Append("\n");
        sb.Append("  MaxCallsPerAgentDecimal: ").Append(MaxCallsPerAgentDecimal).Append("\n");
        sb.Append("  CallbackAutoAnswer: ").Append(CallbackAutoAnswer).Append("\n");
        sb.Append("  DynamicLineBalancingSettings: ").Append(DynamicLineBalancingSettings).Append("\n");
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
        return Equals(obj as Campaign);
    }

    /// <summary>
    /// Returns true if Campaign instances are equal
    /// </summary>
    /// <param name="other">Instance of Campaign to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Campaign other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                ContactList == other.ContactList ||
                ContactList != null &&
                ContactList.Equals(other.ContactList)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                DialingMode == other.DialingMode ||
                DialingMode != null &&
                DialingMode.Equals(other.DialingMode)
            ) &&
            (
                Script == other.Script ||
                Script != null &&
                Script.Equals(other.Script)
            ) &&
            (
                EdgeGroup == other.EdgeGroup ||
                EdgeGroup != null &&
                EdgeGroup.Equals(other.EdgeGroup)
            ) &&
            (
                Site == other.Site ||
                Site != null &&
                Site.Equals(other.Site)
            ) &&
            (
                CampaignStatus == other.CampaignStatus ||
                CampaignStatus != null &&
                CampaignStatus.Equals(other.CampaignStatus)
            ) &&
            (
                PhoneColumns == other.PhoneColumns ||
                PhoneColumns != null &&
                PhoneColumns.SequenceEqual(other.PhoneColumns)
            ) &&
            (
                AbandonRate == other.AbandonRate ||
                AbandonRate != null &&
                AbandonRate.Equals(other.AbandonRate)
            ) &&
            (
                DncLists == other.DncLists ||
                DncLists != null &&
                DncLists.SequenceEqual(other.DncLists)
            ) &&
            (
                CallableTimeSet == other.CallableTimeSet ||
                CallableTimeSet != null &&
                CallableTimeSet.Equals(other.CallableTimeSet)
            ) &&
            (
                CallAnalysisResponseSet == other.CallAnalysisResponseSet ||
                CallAnalysisResponseSet != null &&
                CallAnalysisResponseSet.Equals(other.CallAnalysisResponseSet)
            ) &&
            (
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
            ) &&
            (
                CallerName == other.CallerName ||
                CallerName != null &&
                CallerName.Equals(other.CallerName)
            ) &&
            (
                CallerAddress == other.CallerAddress ||
                CallerAddress != null &&
                CallerAddress.Equals(other.CallerAddress)
            ) &&
            (
                OutboundLineCount == other.OutboundLineCount ||
                OutboundLineCount != null &&
                OutboundLineCount.Equals(other.OutboundLineCount)
            ) &&
            (
                RuleSets == other.RuleSets ||
                RuleSets != null &&
                RuleSets.SequenceEqual(other.RuleSets)
            ) &&
            (
                SkipPreviewDisabled == other.SkipPreviewDisabled ||
                SkipPreviewDisabled != null &&
                SkipPreviewDisabled.Equals(other.SkipPreviewDisabled)
            ) &&
            (
                PreviewTimeOutSeconds == other.PreviewTimeOutSeconds ||
                PreviewTimeOutSeconds != null &&
                PreviewTimeOutSeconds.Equals(other.PreviewTimeOutSeconds)
            ) &&
            (
                AlwaysRunning == other.AlwaysRunning ||
                AlwaysRunning != null &&
                AlwaysRunning.Equals(other.AlwaysRunning)
            ) &&
            (
                ContactSort == other.ContactSort ||
                ContactSort != null &&
                ContactSort.Equals(other.ContactSort)
            ) &&
            (
                ContactSorts == other.ContactSorts ||
                ContactSorts != null &&
                ContactSorts.SequenceEqual(other.ContactSorts)
            ) &&
            (
                NoAnswerTimeout == other.NoAnswerTimeout ||
                NoAnswerTimeout != null &&
                NoAnswerTimeout.Equals(other.NoAnswerTimeout)
            ) &&
            (
                CallAnalysisLanguage == other.CallAnalysisLanguage ||
                CallAnalysisLanguage != null &&
                CallAnalysisLanguage.Equals(other.CallAnalysisLanguage)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                ContactListFilters == other.ContactListFilters ||
                ContactListFilters != null &&
                ContactListFilters.SequenceEqual(other.ContactListFilters)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                AgentOwnedColumn == other.AgentOwnedColumn ||
                AgentOwnedColumn != null &&
                AgentOwnedColumn.Equals(other.AgentOwnedColumn)
            ) &&
            (
                DynamicContactQueueingSettings == other.DynamicContactQueueingSettings ||
                DynamicContactQueueingSettings != null &&
                DynamicContactQueueingSettings.Equals(other.DynamicContactQueueingSettings)
            ) &&
            (
                SkillColumns == other.SkillColumns ||
                SkillColumns != null &&
                SkillColumns.SequenceEqual(other.SkillColumns)
            ) &&
            (
                MaxCallsPerAgent == other.MaxCallsPerAgent ||
                MaxCallsPerAgent != null &&
                MaxCallsPerAgent.Equals(other.MaxCallsPerAgent)
            ) &&
            (
                MaxCallsPerAgentDecimal == other.MaxCallsPerAgentDecimal ||
                MaxCallsPerAgentDecimal != null &&
                MaxCallsPerAgentDecimal.Equals(other.MaxCallsPerAgentDecimal)
            ) &&
            (
                CallbackAutoAnswer == other.CallbackAutoAnswer ||
                CallbackAutoAnswer != null &&
                CallbackAutoAnswer.Equals(other.CallbackAutoAnswer)
            ) &&
            (
                DynamicLineBalancingSettings == other.DynamicLineBalancingSettings ||
                DynamicLineBalancingSettings != null &&
                DynamicLineBalancingSettings.Equals(other.DynamicLineBalancingSettings)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (ContactList != null)
            {
                hash = hash * 59 + ContactList.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (DialingMode != null)
            {
                hash = hash * 59 + DialingMode.GetHashCode();
            }

            if (Script != null)
            {
                hash = hash * 59 + Script.GetHashCode();
            }

            if (EdgeGroup != null)
            {
                hash = hash * 59 + EdgeGroup.GetHashCode();
            }

            if (Site != null)
            {
                hash = hash * 59 + Site.GetHashCode();
            }

            if (CampaignStatus != null)
            {
                hash = hash * 59 + CampaignStatus.GetHashCode();
            }

            if (PhoneColumns != null)
            {
                hash = hash * 59 + PhoneColumns.GetHashCode();
            }

            if (AbandonRate != null)
            {
                hash = hash * 59 + AbandonRate.GetHashCode();
            }

            if (DncLists != null)
            {
                hash = hash * 59 + DncLists.GetHashCode();
            }

            if (CallableTimeSet != null)
            {
                hash = hash * 59 + CallableTimeSet.GetHashCode();
            }

            if (CallAnalysisResponseSet != null)
            {
                hash = hash * 59 + CallAnalysisResponseSet.GetHashCode();
            }

            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            if (CallerName != null)
            {
                hash = hash * 59 + CallerName.GetHashCode();
            }

            if (CallerAddress != null)
            {
                hash = hash * 59 + CallerAddress.GetHashCode();
            }

            if (OutboundLineCount != null)
            {
                hash = hash * 59 + OutboundLineCount.GetHashCode();
            }

            if (RuleSets != null)
            {
                hash = hash * 59 + RuleSets.GetHashCode();
            }

            if (SkipPreviewDisabled != null)
            {
                hash = hash * 59 + SkipPreviewDisabled.GetHashCode();
            }

            if (PreviewTimeOutSeconds != null)
            {
                hash = hash * 59 + PreviewTimeOutSeconds.GetHashCode();
            }

            if (AlwaysRunning != null)
            {
                hash = hash * 59 + AlwaysRunning.GetHashCode();
            }

            if (ContactSort != null)
            {
                hash = hash * 59 + ContactSort.GetHashCode();
            }

            if (ContactSorts != null)
            {
                hash = hash * 59 + ContactSorts.GetHashCode();
            }

            if (NoAnswerTimeout != null)
            {
                hash = hash * 59 + NoAnswerTimeout.GetHashCode();
            }

            if (CallAnalysisLanguage != null)
            {
                hash = hash * 59 + CallAnalysisLanguage.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (ContactListFilters != null)
            {
                hash = hash * 59 + ContactListFilters.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (AgentOwnedColumn != null)
            {
                hash = hash * 59 + AgentOwnedColumn.GetHashCode();
            }

            if (DynamicContactQueueingSettings != null)
            {
                hash = hash * 59 + DynamicContactQueueingSettings.GetHashCode();
            }

            if (SkillColumns != null)
            {
                hash = hash * 59 + SkillColumns.GetHashCode();
            }

            if (MaxCallsPerAgent != null)
            {
                hash = hash * 59 + MaxCallsPerAgent.GetHashCode();
            }

            if (MaxCallsPerAgentDecimal != null)
            {
                hash = hash * 59 + MaxCallsPerAgentDecimal.GetHashCode();
            }

            if (CallbackAutoAnswer != null)
            {
                hash = hash * 59 + CallbackAutoAnswer.GetHashCode();
            }

            if (DynamicLineBalancingSettings != null)
            {
                hash = hash * 59 + DynamicLineBalancingSettings.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
