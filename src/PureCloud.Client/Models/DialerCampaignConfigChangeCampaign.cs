using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCampaignConfigChangeCampaign
{
    /// <summary>
    /// dialing mode of the campaign
    /// </summary>
    /// <value>dialing mode of the campaign</value>
    public DialerCampaignConfigChangeCampaignDialingModeEnum? DialingMode { get; set; }

    /// <summary>
    /// Gets or Sets CampaignStatus
    /// </summary>
    public DialerCampaignConfigChangeCampaignCampaignStatusEnum? CampaignStatus { get; set; }

    /// <summary>
    /// Gets or Sets ContactList
    /// </summary>
    public DialerCampaignConfigChangeUriReference ContactList { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public DialerCampaignConfigChangeUriReference Queue { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public DialerCampaignConfigChangeUriReference Script { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public DialerCampaignConfigChangeUriReference EdgeGroup { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public DialerCampaignConfigChangeUriReference Site { get; set; }

    /// <summary>
    /// the contact list phone columns to be called for the campaign
    /// </summary>
    /// <value>the contact list phone columns to be called for the campaign</value>
    public IEnumerable<DialerCampaignConfigChangePhoneColumn> PhoneColumns { get; set; }

    /// <summary>
    /// the targeted abandon rate percentage
    /// </summary>
    /// <value>the targeted abandon rate percentage</value>
    public double? AbandonRate { get; set; }

    /// <summary>
    /// identifiers of the do not call lists
    /// </summary>
    /// <value>identifiers of the do not call lists</value>
    public IEnumerable<DialerCampaignConfigChangeUriReference> DncLists { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public DialerCampaignConfigChangeUriReference CallableTimeSet { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public DialerCampaignConfigChangeUriReference CallAnalysisResponseSet { get; set; }

    /// <summary>
    /// caller id name to be displayed on the outbound call
    /// </summary>
    /// <value>caller id name to be displayed on the outbound call</value>
    public string CallerName { get; set; }

    /// <summary>
    /// caller id phone number to be displayed on the outbound call
    /// </summary>
    /// <value>caller id phone number to be displayed on the outbound call</value>
    public string CallerAddress { get; set; }

    /// <summary>
    /// for agentless campaigns, the number of outbound lines to be concurrently dialed
    /// </summary>
    /// <value>for agentless campaigns, the number of outbound lines to be concurrently dialed</value>
    public long? OutboundLineCount { get; set; }

    /// <summary>
    /// a list of current error conditions associated with the campaign
    /// </summary>
    /// <value>a list of current error conditions associated with the campaign</value>
    public IEnumerable<DialerCampaignConfigChangeRestErrorDetail> Errors { get; set; }

    /// <summary>
    /// identifiers of the rule sets
    /// </summary>
    /// <value>identifiers of the rule sets</value>
    public IEnumerable<DialerCampaignConfigChangeUriReference> RuleSets { get; set; }

    /// <summary>
    /// for preview campaigns, indicator of whether the agent can skip a preview without placing a call
    /// </summary>
    /// <value>for preview campaigns, indicator of whether the agent can skip a preview without placing a call</value>
    public bool? SkipPreviewDisabled { get; set; }

    /// <summary>
    /// for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls
    /// </summary>
    /// <value>for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls</value>
    public long? PreviewTimeOutSeconds { get; set; }

    /// <summary>
    /// for preview campaigns with multiple phone columns, indicator if one (true) or multiple (false) phone numbers will be available to call for each preview
    /// </summary>
    /// <value>for preview campaigns with multiple phone columns, indicator if one (true) or multiple (false) phone numbers will be available to call for each preview</value>
    public bool? SingleNumberPreview { get; set; }

    /// <summary>
    /// Gets or Sets ContactSort
    /// </summary>
    public DialerCampaignConfigChangeContactSort ContactSort { get; set; }

    /// <summary>
    /// List of contact sort objects.
    /// </summary>
    /// <value>List of contact sort objects.</value>
    public IEnumerable<DialerCampaignConfigChangeContactSort> ContactSorts { get; set; }

    /// <summary>
    /// for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds
    /// </summary>
    /// <value>for non-preview campaigns, how long to wait before dispositioning as &#39;no-answer&#39;, default 30 seconds</value>
    public long? NoAnswerTimeout { get; set; }

    /// <summary>
    /// The language the edge will use to analyze the call
    /// </summary>
    /// <value>The language the edge will use to analyze the call</value>
    public string CallAnalysisLanguage { get; set; }

    /// <summary>
    /// The priority of this campaign relative to other campaigns
    /// </summary>
    /// <value>The priority of this campaign relative to other campaigns</value>
    public long? Priority { get; set; }

    /// <summary>
    /// List of contact filters
    /// </summary>
    /// <value>List of contact filters</value>
    public IEnumerable<DialerCampaignConfigChangeUriReference> ContactListFilters { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public DialerCampaignConfigChangeUriReference Division { get; set; }

    /// <summary>
    /// For Preview Campaigns. Name of the contact column in the contact list containing the userIds of agents to assign specific contact records to.
    /// </summary>
    /// <value>For Preview Campaigns. Name of the contact column in the contact list containing the userIds of agents to assign specific contact records to.</value>
    public string AgentOwnedColumn { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    public string Name { get; set; }

    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    public long? Version { get; set; }
}
