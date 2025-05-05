using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerCampaignConfigChangeCampaign
/// </summary>

public partial class DialerCampaignConfigChangeCampaign : IEquatable<DialerCampaignConfigChangeCampaign>
{
    /// <summary>
    /// dialing mode of the campaign
    /// </summary>
    /// <value>dialing mode of the campaign</value>
    
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
        /// Enum External for "external"
        /// </summary>
        [EnumMember(Value = "external")]
        External,

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
        Progressive
    }
    /// <summary>
    /// Gets or Sets CampaignStatus
    /// </summary>
    
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
        /// Enum Stopping for "stopping"
        /// </summary>
        [EnumMember(Value = "stopping")]
        Stopping,

        /// <summary>
        /// Enum Invalid for "invalid"
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid
    }
    /// <summary>
    /// dialing mode of the campaign
    /// </summary>
    /// <value>dialing mode of the campaign</value>
    [JsonPropertyName("dialingMode")]
    public DialingModeEnum? DialingMode { get; set; }
    /// <summary>
    /// Gets or Sets CampaignStatus
    /// </summary>
    [JsonPropertyName("campaignStatus")]
    public CampaignStatusEnum? CampaignStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerCampaignConfigChangeCampaign" /> class.
    /// </summary>
    /// <param name="ContactList">ContactList.</param>
    /// <param name="Queue">A UriReference for a resource.</param>
    /// <param name="DialingMode">dialing mode of the campaign.</param>
    /// <param name="Script">A UriReference for a resource.</param>
    /// <param name="EdgeGroup">A UriReference for a resource.</param>
    /// <param name="Site">A UriReference for a resource.</param>
    /// <param name="CampaignStatus">CampaignStatus.</param>
    /// <param name="PhoneColumns">the contact list phone columns to be called for the campaign.</param>
    /// <param name="AbandonRate">the targeted abandon rate percentage.</param>
    /// <param name="DncLists">identifiers of the do not call lists.</param>
    /// <param name="CallableTimeSet">A UriReference for a resource.</param>
    /// <param name="CallAnalysisResponseSet">A UriReference for a resource.</param>
    /// <param name="CallerName">caller id name to be displayed on the outbound call.</param>
    /// <param name="CallerAddress">caller id phone number to be displayed on the outbound call.</param>
    /// <param name="OutboundLineCount">for agentless campaigns, the number of outbound lines to be concurrently dialed.</param>
    /// <param name="Errors">a list of current error conditions associated with the campaign.</param>
    /// <param name="RuleSets">identifiers of the rule sets.</param>
    /// <param name="SkipPreviewDisabled">for preview campaigns, indicator of whether the agent can skip a preview without placing a call.</param>
    /// <param name="PreviewTimeOutSeconds">for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls.</param>
    /// <param name="SingleNumberPreview">for preview campaigns with multiple phone columns, indicator if one (true) or multiple (false) phone numbers will be available to call for each preview.</param>
    /// <param name="ContactSort">ContactSort.</param>
    /// <param name="ContactSorts">List of contact sort objects..</param>
    /// <param name="NoAnswerTimeout">for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds.</param>
    /// <param name="CallAnalysisLanguage">The language the edge will use to analyze the call.</param>
    /// <param name="Priority">The priority of this campaign relative to other campaigns.</param>
    /// <param name="ContactListFilters">List of contact filters.</param>
    /// <param name="Division">A UriReference for a resource.</param>
    /// <param name="AgentOwnedColumn">For Preview Campaigns. Name of the contact column in the contact list containing the userIds of agents to assign specific contact records to..</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    public DialerCampaignConfigChangeCampaign(DialerCampaignConfigChangeUriReference ContactList = null, DialerCampaignConfigChangeUriReference Queue = null, DialingModeEnum? DialingMode = null, DialerCampaignConfigChangeUriReference Script = null, DialerCampaignConfigChangeUriReference EdgeGroup = null, DialerCampaignConfigChangeUriReference Site = null, CampaignStatusEnum? CampaignStatus = null, List<DialerCampaignConfigChangePhoneColumn> PhoneColumns = null, double? AbandonRate = null, List<DialerCampaignConfigChangeUriReference> DncLists = null, DialerCampaignConfigChangeUriReference CallableTimeSet = null, DialerCampaignConfigChangeUriReference CallAnalysisResponseSet = null, string CallerName = null, string CallerAddress = null, long? OutboundLineCount = null, List<DialerCampaignConfigChangeRestErrorDetail> Errors = null, List<DialerCampaignConfigChangeUriReference> RuleSets = null, bool? SkipPreviewDisabled = null, long? PreviewTimeOutSeconds = null, bool? SingleNumberPreview = null, DialerCampaignConfigChangeContactSort ContactSort = null, List<DialerCampaignConfigChangeContactSort> ContactSorts = null, long? NoAnswerTimeout = null, string CallAnalysisLanguage = null, long? Priority = null, List<DialerCampaignConfigChangeUriReference> ContactListFilters = null, DialerCampaignConfigChangeUriReference Division = null, string AgentOwnedColumn = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
    {
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
        this.Errors = Errors;
        this.RuleSets = RuleSets;
        this.SkipPreviewDisabled = SkipPreviewDisabled;
        this.PreviewTimeOutSeconds = PreviewTimeOutSeconds;
        this.SingleNumberPreview = SingleNumberPreview;
        this.ContactSort = ContactSort;
        this.ContactSorts = ContactSorts;
        this.NoAnswerTimeout = NoAnswerTimeout;
        this.CallAnalysisLanguage = CallAnalysisLanguage;
        this.Priority = Priority;
        this.ContactListFilters = ContactListFilters;
        this.Division = Division;
        this.AgentOwnedColumn = AgentOwnedColumn;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;

    }



    /// <summary>
    /// Gets or Sets ContactList
    /// </summary>
    [JsonPropertyName("contactList")]
    public DialerCampaignConfigChangeUriReference ContactList { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("queue")]
    public DialerCampaignConfigChangeUriReference Queue { get; set; }





    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("script")]
    public DialerCampaignConfigChangeUriReference Script { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("edgeGroup")]
    public DialerCampaignConfigChangeUriReference EdgeGroup { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("site")]
    public DialerCampaignConfigChangeUriReference Site { get; set; }





    /// <summary>
    /// the contact list phone columns to be called for the campaign
    /// </summary>
    /// <value>the contact list phone columns to be called for the campaign</value>
    [JsonPropertyName("phoneColumns")]
    public List<DialerCampaignConfigChangePhoneColumn> PhoneColumns { get; set; }



    /// <summary>
    /// the targeted abandon rate percentage
    /// </summary>
    /// <value>the targeted abandon rate percentage</value>
    [JsonPropertyName("abandonRate")]
    public double? AbandonRate { get; set; }



    /// <summary>
    /// identifiers of the do not call lists
    /// </summary>
    /// <value>identifiers of the do not call lists</value>
    [JsonPropertyName("dncLists")]
    public List<DialerCampaignConfigChangeUriReference> DncLists { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("callableTimeSet")]
    public DialerCampaignConfigChangeUriReference CallableTimeSet { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("callAnalysisResponseSet")]
    public DialerCampaignConfigChangeUriReference CallAnalysisResponseSet { get; set; }



    /// <summary>
    /// caller id name to be displayed on the outbound call
    /// </summary>
    /// <value>caller id name to be displayed on the outbound call</value>
    [JsonPropertyName("callerName")]
    public string CallerName { get; set; }



    /// <summary>
    /// caller id phone number to be displayed on the outbound call
    /// </summary>
    /// <value>caller id phone number to be displayed on the outbound call</value>
    [JsonPropertyName("callerAddress")]
    public string CallerAddress { get; set; }



    /// <summary>
    /// for agentless campaigns, the number of outbound lines to be concurrently dialed
    /// </summary>
    /// <value>for agentless campaigns, the number of outbound lines to be concurrently dialed</value>
    [JsonPropertyName("outboundLineCount")]
    public long? OutboundLineCount { get; set; }



    /// <summary>
    /// a list of current error conditions associated with the campaign
    /// </summary>
    /// <value>a list of current error conditions associated with the campaign</value>
    [JsonPropertyName("errors")]
    public List<DialerCampaignConfigChangeRestErrorDetail> Errors { get; set; }



    /// <summary>
    /// identifiers of the rule sets
    /// </summary>
    /// <value>identifiers of the rule sets</value>
    [JsonPropertyName("ruleSets")]
    public List<DialerCampaignConfigChangeUriReference> RuleSets { get; set; }



    /// <summary>
    /// for preview campaigns, indicator of whether the agent can skip a preview without placing a call
    /// </summary>
    /// <value>for preview campaigns, indicator of whether the agent can skip a preview without placing a call</value>
    [JsonPropertyName("skipPreviewDisabled")]
    public bool? SkipPreviewDisabled { get; set; }



    /// <summary>
    /// for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls
    /// </summary>
    /// <value>for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls</value>
    [JsonPropertyName("previewTimeOutSeconds")]
    public long? PreviewTimeOutSeconds { get; set; }



    /// <summary>
    /// for preview campaigns with multiple phone columns, indicator if one (true) or multiple (false) phone numbers will be available to call for each preview
    /// </summary>
    /// <value>for preview campaigns with multiple phone columns, indicator if one (true) or multiple (false) phone numbers will be available to call for each preview</value>
    [JsonPropertyName("singleNumberPreview")]
    public bool? SingleNumberPreview { get; set; }



    /// <summary>
    /// Gets or Sets ContactSort
    /// </summary>
    [JsonPropertyName("contactSort")]
    public DialerCampaignConfigChangeContactSort ContactSort { get; set; }



    /// <summary>
    /// List of contact sort objects.
    /// </summary>
    /// <value>List of contact sort objects.</value>
    [JsonPropertyName("contactSorts")]
    public List<DialerCampaignConfigChangeContactSort> ContactSorts { get; set; }



    /// <summary>
    /// for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds
    /// </summary>
    /// <value>for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds</value>
    [JsonPropertyName("noAnswerTimeout")]
    public long? NoAnswerTimeout { get; set; }



    /// <summary>
    /// The language the edge will use to analyze the call
    /// </summary>
    /// <value>The language the edge will use to analyze the call</value>
    [JsonPropertyName("callAnalysisLanguage")]
    public string CallAnalysisLanguage { get; set; }



    /// <summary>
    /// The priority of this campaign relative to other campaigns
    /// </summary>
    /// <value>The priority of this campaign relative to other campaigns</value>
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }



    /// <summary>
    /// List of contact filters
    /// </summary>
    /// <value>List of contact filters</value>
    [JsonPropertyName("contactListFilters")]
    public List<DialerCampaignConfigChangeUriReference> ContactListFilters { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [JsonPropertyName("division")]
    public DialerCampaignConfigChangeUriReference Division { get; set; }



    /// <summary>
    /// For Preview Campaigns. Name of the contact column in the contact list containing the userIds of agents to assign specific contact records to.
    /// </summary>
    /// <value>For Preview Campaigns. Name of the contact column in the contact list containing the userIds of agents to assign specific contact records to.</value>
    [JsonPropertyName("agentOwnedColumn")]
    public string AgentOwnedColumn { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerCampaignConfigChangeCampaign {\n");

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
        sb.Append("  CallerName: ").Append(CallerName).Append("\n");
        sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
        sb.Append("  OutboundLineCount: ").Append(OutboundLineCount).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
        sb.Append("  SkipPreviewDisabled: ").Append(SkipPreviewDisabled).Append("\n");
        sb.Append("  PreviewTimeOutSeconds: ").Append(PreviewTimeOutSeconds).Append("\n");
        sb.Append("  SingleNumberPreview: ").Append(SingleNumberPreview).Append("\n");
        sb.Append("  ContactSort: ").Append(ContactSort).Append("\n");
        sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
        sb.Append("  NoAnswerTimeout: ").Append(NoAnswerTimeout).Append("\n");
        sb.Append("  CallAnalysisLanguage: ").Append(CallAnalysisLanguage).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  ContactListFilters: ").Append(ContactListFilters).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  AgentOwnedColumn: ").Append(AgentOwnedColumn).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as DialerCampaignConfigChangeCampaign);
    }

    /// <summary>
    /// Returns true if DialerCampaignConfigChangeCampaign instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerCampaignConfigChangeCampaign to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerCampaignConfigChangeCampaign other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
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
                SingleNumberPreview == other.SingleNumberPreview ||
                SingleNumberPreview != null &&
                SingleNumberPreview.Equals(other.SingleNumberPreview)
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
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
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

            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
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

            if (SingleNumberPreview != null)
            {
                hash = hash * 59 + SingleNumberPreview.GetHashCode();
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

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

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

            return hash;
        }
    }
}
