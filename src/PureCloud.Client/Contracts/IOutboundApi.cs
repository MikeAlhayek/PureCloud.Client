using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IOutboundApi
{
    /// <summary>
    /// Get attemptlimit
    /// </summary>
    /// <param name="attemptLimitsId">The attemptLimitsId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<AttemptLimits> GetOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get attemptlimits
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<AttemptLimitsEntityListing> GetOutboundAttemptlimitsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create attemptlimit
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<AttemptLimits> CreateOutboundAttemptlimitAsync(AttemptLimits body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update attemptlimit
    /// </summary>
    /// <param name="attemptLimitsId">The attemptLimitsId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<AttemptLimits> UpdateOutboundAttemptlimitAsync(string attemptLimitsId, AttemptLimits body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete attemptlimit
    /// </summary>
    /// <param name="attemptLimitsId">The attemptLimitsId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get callabletimeset
    /// </summary>
    /// <param name="callableTimeSetId">The callableTimeSetId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CallableTimeSet> GetOutboundCallabletimesetAsync(string callableTimeSetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get callabletimesets
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CallableTimeSetEntityListing> GetOutboundCallabletimesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create callabletimeset
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CallableTimeSet> CreateOutboundCallabletimesetAsync(CallableTimeSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update callabletimeset
    /// </summary>
    /// <param name="callableTimeSetId">The callableTimeSetId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CallableTimeSet> UpdateOutboundCallabletimesetAsync(string callableTimeSetId, CallableTimeSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete callabletimeset
    /// </summary>
    /// <param name="callableTimeSetId">The callableTimeSetId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundCallabletimesetAsync(string callableTimeSetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaign
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<Campaign> GetOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaigns
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="ids">The ids</param>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="dncListIds">The dncListIds</param>
    /// <param name="distributionQueueId">The distributionQueueId</param>
    /// <param name="edgeGroupId">The edgeGroupId</param>
    /// <param name="callAnalysisResponseSetId">The callAnalysisResponseSetId</param>
    /// <param name="divisionId">The divisionId</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignEntityListing> GetOutboundCampaignsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string contactListId = null, string dncListIds = null, string distributionQueueId = null, string edgeGroupId = null, string callAnalysisResponseSetId = null, IEnumerable<string> divisionIds = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create campaign
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<Campaign> CreateOutboundCampaignAsync(Campaign body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update campaign
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<Campaign> UpdateOutboundCampaignAsync(string campaignId, Campaign body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete campaign
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get callanalysisresponseset
    /// </summary>
    /// <param name="callAnalysisSetId">The callAnalysisSetId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ResponseSet> GetOutboundCallanalysisresponsesetAsync(string callAnalysisSetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get callanalysisresponsesets
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ResponseSetEntityListing> GetOutboundCallanalysisresponsesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create callanalysisresponseset
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ResponseSet> CreateOutboundCallanalysisresponsesetAsync(ResponseSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update callanalysisresponseset
    /// </summary>
    /// <param name="callAnalysisSetId">The callAnalysisSetId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ResponseSet> UpdateOutboundCallanalysisresponsesetAsync(string callAnalysisSetId, ResponseSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete callanalysisresponseset
    /// </summary>
    /// <param name="callAnalysisSetId">The callAnalysisSetId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundCallanalysisresponsesetAsync(string callAnalysisSetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete campaignprogress
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundCampaignProgressAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete campaignrule
    /// </summary>
    /// <param name="campaignRuleId">The campaignRuleId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundCampaignruleAsync(string campaignRuleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete contactlist
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundContactlistAsync(string contactListId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete contactlistcontact
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="contactId">The contactId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundContactlistContactAsync(string contactListId, string contactId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete contactlistcontacts
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="contactIds">The contactIds</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundContactlistContactsAsync(string contactListId, IEnumerable<string> contactIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete contactlistfilter
    /// </summary>
    /// <param name="contactListFilterId">The contactListFilterId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundContactlistfilterAsync(string contactListFilterId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete contactlists
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundContactlistsAsync(IEnumerable<string> id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete contactlisttemplate
    /// </summary>
    /// <param name="contactListTemplateId">The contactListTemplateId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundContactlisttemplateAsync(string contactListTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete contactlisttemplates
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundContactlisttemplatesAsync(IEnumerable<string> id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete digitalruleset
    /// </summary>
    /// <param name="digitalRuleSetId">The digitalRuleSetId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundDigitalrulesetAsync(string digitalRuleSetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete dnclist
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundDnclistAsync(string dncListId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete dnclistcustomexclusioncolumns
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="expiredOnly">The expiredOnly</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundDnclistCustomexclusioncolumnsAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete dnclistemailaddresses
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="expiredOnly">The expiredOnly</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundDnclistEmailaddressesAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete dnclistphonenumbers
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="expiredOnly">The expiredOnly</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundDnclistPhonenumbersAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete dnclistwhatsappnumbers
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="expiredOnly">The expiredOnly</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundDnclistWhatsappnumbersAsync(string dncListId, bool? expiredOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete filespecificationtemplate
    /// </summary>
    /// <param name="fileSpecificationTemplateId">The fileSpecificationTemplateId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundFilespecificationtemplateAsync(string fileSpecificationTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete filespecificationtemplatesbulk
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundFilespecificationtemplatesBulkAsync(IEnumerable<string> id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete importtemplate
    /// </summary>
    /// <param name="importTemplateId">The importTemplateId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundImporttemplateAsync(string importTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete importtemplates
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundImporttemplatesAsync(IEnumerable<string> id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete messagingcampaign
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete messagingcampaignprogress
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundMessagingcampaignProgressAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete ruleset
    /// </summary>
    /// <param name="ruleSetId">The ruleSetId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundRulesetAsync(string ruleSetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete schedulescampaign
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundSchedulesCampaignAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete schedulesemailcampaign
    /// </summary>
    /// <param name="emailCampaignId">The emailCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundSchedulesEmailcampaignAsync(string emailCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete schedulesmessagingcampaign
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundSchedulesMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete schedulessequence
    /// </summary>
    /// <param name="sequenceId">The sequenceId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundSchedulesSequenceAsync(string sequenceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete sequence
    /// </summary>
    /// <param name="sequenceId">The sequenceId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteOutboundSequenceAsync(string sequenceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignagentownedmappingpreviewresults
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<AgentOwnedMappingPreviewListing> GetOutboundCampaignAgentownedmappingpreviewResultsAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaigndiagnostics
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignDiagnostics> GetOutboundCampaignDiagnosticsAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaigninteractions
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignInteractions> GetOutboundCampaignInteractionsAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignlinedistribution
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="includeOnlyActiveCampaigns">The includeOnlyActiveCampaigns</param>
    /// <param name="edgeGroupId">The edgeGroupId</param>
    /// <param name="siteId">The siteId</param>
    /// <param name="useWeight">The useWeight</param>
    /// <param name="relativeWeight">The relativeWeight</param>
    /// <param name="outboundLineCount">The outboundLineCount</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignOutboundLinesDistribution> GetOutboundCampaignLinedistributionAsync(string campaignId, bool? includeOnlyActiveCampaigns = null, string edgeGroupId = null, string siteId = null, bool? useWeight = null, int? relativeWeight = null, int? outboundLineCount = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignprogress
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignProgress> GetOutboundCampaignProgressAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignskillcombinations
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<PagedSkillCombinationListing> GetOutboundCampaignSkillcombinationsAsync(string campaignId, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignstats
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignStats> GetOutboundCampaignStatsAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignrule
    /// </summary>
    /// <param name="campaignRuleId">The campaignRuleId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignRule> GetOutboundCampaignruleAsync(string campaignRuleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignrules
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignRuleEntityListing> GetOutboundCampaignrulesAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignsall
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="id">The id</param>
    /// <param name="name">The name</param>
    /// <param name="divisionId">The divisionId</param>
    /// <param name="mediaType">The mediaType</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CommonCampaignEntityListing> GetOutboundCampaignsAllAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> ids = null, string name = null, IEnumerable<string> divisionIds = null, IEnumerable<string> mediaTypes = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignsalldivisionviews
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="id">The id</param>
    /// <param name="name">The name</param>
    /// <param name="divisionId">The divisionId</param>
    /// <param name="mediaType">The mediaType</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CommonCampaignDivisionViewEntityListing> GetOutboundCampaignsAllDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, IEnumerable<string> ids = null, string name = null, IEnumerable<string> divisionIds = null, IEnumerable<string> mediaTypes = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create attemptlimits
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <summary>
    /// Create callabletimesets
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <summary>
    /// Create callanalysisresponsesets
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <summary>
    /// Update attemptlimit
    /// </summary>
    /// <param name="attemptLimitsId">The attemptLimitsId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <summary>
    /// Update callabletimeset
    /// </summary>
    /// <param name="callableTimeSetId">The callableTimeSetId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <summary>
    /// Update callanalysisresponseset
    /// </summary>
    /// <param name="callAnalysisSetId">The callAnalysisSetId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <summary>
    /// Get contactlists
    /// </summary>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="includeSize">The includeSize</param>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="id">The id</param>
    /// <param name="divisionId">The divisionId</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListEntityListing> GetOutboundContactlistsAsync(bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlistfilter
    /// </summary>
    /// <param name="contactListFilterId">The contactListFilterId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListFilter> GetOutboundContactlistfilterAsync(string contactListFilterId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlistfilters
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListFilterEntityListing> GetOutboundContactlistfiltersAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, string contactListId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlisttemplate
    /// </summary>
    /// <param name="contactListTemplateId">The contactListTemplateId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListTemplate> GetOutboundContactlisttemplateAsync(string contactListTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlisttemplates
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListTemplateEntityListing> GetOutboundContactlisttemplatesAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get digitalruleset
    /// </summary>
    /// <param name="digitalRuleSetId">The digitalRuleSetId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DigitalRuleSet> GetOutboundDigitalrulesetAsync(string digitalRuleSetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get digitalrulesets
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DigitalRuleSetEntityListing> GetOutboundDigitalrulesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get dnclist
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="includeSize">The includeSize</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DncList> GetOutboundDnclistAsync(string dncListId, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get dnclists
    /// </summary>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="includeSize">The includeSize</param>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="dncSourceType">The dncSourceType</param>
    /// <param name="divisionId">The divisionId</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DncListEntityListing> GetOutboundDnclistsAsync(bool? includeImportStatus = null, bool? includeSize = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string dncSourceType = null, IEnumerable<string> divisionIds = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get event
    /// </summary>
    /// <param name="eventId">The eventId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<EventLog> GetOutboundEventAsync(string eventId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get events
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="category">The category</param>
    /// <param name="level">The level</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DialerEventEntityListing> GetOutboundEventsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string category = null, string level = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get filespecificationtemplate
    /// </summary>
    /// <param name="fileSpecificationTemplateId">The fileSpecificationTemplateId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<FileSpecificationTemplate> GetOutboundFilespecificationtemplateAsync(string fileSpecificationTemplateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get filespecificationtemplates
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<FileSpecificationTemplateEntityListing> GetOutboundFilespecificationtemplatesAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get importtemplate
    /// </summary>
    /// <param name="importTemplateId">The importTemplateId</param>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ImportTemplate> GetOutboundImporttemplateAsync(string importTemplateId, bool? includeImportStatus = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get importtemplates
    /// </summary>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="contactListTemplateId">The contactListTemplateId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ImportTemplateEntityListing> GetOutboundImporttemplatesAsync(bool? includeImportStatus = null, int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, string contactListTemplateId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get ruleset
    /// </summary>
    /// <param name="ruleSetId">The ruleSetId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<RuleSet> GetOutboundRulesetAsync(string ruleSetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get rulesets
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<RuleSetEntityListing> GetOutboundRulesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sequence
    /// </summary>
    /// <param name="sequenceId">The sequenceId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSequence> GetOutboundSequenceAsync(string sequenceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get sequences
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="allowEmptyResult">The allowEmptyResult</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSequenceEntityListing> GetOutboundSequencesAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<OutboundSettings> GetOutboundSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get wrapupcodemappings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<WrapUpCodeMapping> GetOutboundWrapupcodemappingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create digitalruleset
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DigitalRuleSet> PostOutboundDigitalrulesetAsync(DigitalRuleSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create dnclist
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DncList> CreateOutboundDnclistAsync(DncListCreate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create filespecificationtemplates
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<FileSpecificationTemplate> PostOutboundFilespecificationtemplatesAsync(FileSpecificationTemplate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create importtemplates
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ImportTemplate> PostOutboundImporttemplatesAsync(ImportTemplate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create ruleset
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<RuleSet> PostOutboundRulesetAsync(RuleSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create sequence
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSequence> CreateOutboundSequenceAsync(CampaignSequence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update digitalruleset
    /// </summary>
    /// <param name="digitalRuleSetId">The digitalRuleSetId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DigitalRuleSet> UpdateOutboundDigitalrulesetAsync(string digitalRuleSetId, DigitalRuleSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update dnclist
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DncList> PutOutboundDnclistAsync(string dncListId, DncList body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update filespecificationtemplate
    /// </summary>
    /// <param name="fileSpecificationTemplateId">The fileSpecificationTemplateId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<FileSpecificationTemplate> PutOutboundFilespecificationtemplateAsync(string fileSpecificationTemplateId, FileSpecificationTemplate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update importtemplate
    /// </summary>
    /// <param name="importTemplateId">The importTemplateId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ImportTemplate> PutOutboundImporttemplateAsync(string importTemplateId, ImportTemplate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update ruleset
    /// </summary>
    /// <param name="ruleSetId">The ruleSetId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<RuleSet> PutOutboundRulesetAsync(string ruleSetId, RuleSet body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update sequence
    /// </summary>
    /// <param name="sequenceId">The sequenceId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSequence> PutOutboundSequenceAsync(string sequenceId, CampaignSequence body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update settings
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<OutboundSettings> PutOutboundSettingsAsync(OutboundSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update wrapupcodemappings
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<WrapUpCodeMapping> PutOutboundWrapupcodemappingsAsync(WrapUpCodeMapping body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlistexport
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="download">The download</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>String result</returns>
    Task<string> GetOutboundContactlistExportAsync(string contactListId, string download = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlistimportstatus
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ImportStatus> GetOutboundContactlistImportstatusAsync(string contactListId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get dnclistexport
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="download">The download</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>String result</returns>
    Task<string> GetOutboundDnclistExportAsync(string dncListId, string download = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get dnclistimportstatus
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ImportStatus> GetOutboundDnclistImportstatusAsync(string dncListId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get importtemplateimportstatus
    /// </summary>
    /// <param name="importTemplateId">The importTemplateId</param>
    /// <param name="listNamePrefix">The listNamePrefix</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ImportStatus> GetOutboundImporttemplateImportstatusAsync(string importTemplateId, IEnumerable<string> listNamePrefixes = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlistclear
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>String result</returns>
    Task<string> PostOutboundContactlistClearAsync(string contactListId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlistexport
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>String result</returns>
    Task<string> PostOutboundContactlistExportAsync(string contactListId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create dnclistexport
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DncList> PostOutboundDnclistExportAsync(string dncListId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create dnclistemailaddresses
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>String result</returns>
    Task<string> PostOutboundDnclistEmailaddressesAsync(string dncListId, IEnumerable<string> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create dnclistphonenumbers
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>String result</returns>
    Task<string> PostOutboundDnclistPhonenumbersAsync(string dncListId, IEnumerable<string> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create schedulescampaign
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSchedule> PostOutboundSchedulesCampaignAsync(CampaignSchedule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create schedulessequence
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSchedule> PostOutboundSchedulesSequenceAsync(CampaignSchedule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignsdivisionview
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignDivisionView> GetOutboundCampaignsDivisionviewAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get campaignsdivisionviews
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="id">The id</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignDivisionViewListing> GetOutboundCampaignsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlist
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="includeSize">The includeSize</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactList> GetOutboundContactlistAsync(string contactListId, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlistcontact
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="contactId">The contactId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DialerContact> GetOutboundContactlistContactAsync(string contactListId, string contactId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlistcontactsbulkjob
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="jobId">The jobId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactsBulkOperationJob> GetOutboundContactlistContactsBulkJobAsync(string contactListId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlistcontactsbulkjobs
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactsBulkOperationJobListing> GetOutboundContactlistContactsBulkJobsAsync(string contactListId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlisttimezonemappingpreview
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<TimeZoneMappingPreview> GetOutboundContactlistTimezonemappingpreviewAsync(string contactListId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlistsdivisionview
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="includeSize">The includeSize</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListDivisionView> GetOutboundContactlistsDivisionviewAsync(string contactListId, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get contactlistsdivisionviews
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="id">The id</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="includeSize">The includeSize</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListDivisionViewListing> GetOutboundContactlistsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string sortBy = null, string sortOrder = null, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get dnclistsdivisionview
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="includeSize">The includeSize</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DncListDivisionView> GetOutboundDnclistsDivisionviewAsync(string dncListId, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get dnclistsdivisionviews
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="id">The id</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="includeImportStatus">The includeImportStatus</param>
    /// <param name="includeSize">The includeSize</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DncListDivisionViewListing> GetOutboundDnclistsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string sortBy = null, string sortOrder = null, bool? includeImportStatus = null, bool? includeSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get messagingcampaign
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaign> GetOutboundMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get messagingcampaigndiagnostics
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaignDiagnostics> GetOutboundMessagingcampaignDiagnosticsAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get messagingcampaignprogress
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignProgress> GetOutboundMessagingcampaignProgressAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get messagingcampaigns
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="id">The id</param>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="distributionQueueId">The distributionQueueId</param>
    /// <param name="edgeGroupId">The edgeGroupId</param>
    /// <param name="divisionId">The divisionId</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaignEntityListing> GetOutboundMessagingcampaignsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string contactListId = null, string dncListId = null, string distributionQueueId = null, string edgeGroupId = null, IEnumerable<string> divisionIds = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get messagingcampaignsdivisionview
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaignDivisionView> GetOutboundMessagingcampaignsDivisionviewAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get messagingcampaignsdivisionviews
    /// </summary>
    /// <param name="pageSize">The pageSize</param>
    /// <param name="pageNumber">The pageNumber</param>
    /// <param name="filterType">The filterType</param>
    /// <param name="name">The name</param>
    /// <param name="id">The id</param>
    /// <param name="sortBy">The sortBy</param>
    /// <param name="sortOrder">The sortOrder</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaignDivisionViewEntityListing> GetOutboundMessagingcampaignsDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string filterType = null, string name = null, IEnumerable<string> ids = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedulescampaign
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSchedule> GetOutboundSchedulesCampaignAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedulesemailcampaign
    /// </summary>
    /// <param name="emailCampaignId">The emailCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<EmailCampaignSchedule> GetOutboundSchedulesEmailcampaignAsync(string emailCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedulesmessagingcampaign
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaignSchedule> GetOutboundSchedulesMessagingcampaignAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedulessequence
    /// </summary>
    /// <param name="sequenceId">The sequenceId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSchedule> GetOutboundSchedulesSequenceAsync(string sequenceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Patch campaign
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<Campaign> PatchOutboundCampaignAsync(string campaignId, Campaign body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Patch dnclistcustomexclusioncolumns
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="body">The body</param>
    /// <param name="expiredOnly">The expiredOnly</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task PatchOutboundDnclistCustomexclusioncolumnsAsync(string dncListId, DncPatchCustomExclusionColumnsRequest body, bool? expiredOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Patch dnclistemailaddresses
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="body">The body</param>
    /// <param name="expiredOnly">The expiredOnly</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task PatchOutboundDnclistEmailaddressesAsync(string dncListId, DncPatchEmailsRequest body, bool? expiredOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Patch dnclistphonenumbers
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="body">The body</param>
    /// <param name="expiredOnly">The expiredOnly</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task PatchOutboundDnclistPhonenumbersAsync(string dncListId, DncPatchPhoneNumbersRequest body, bool? expiredOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Patch dnclistwhatsappnumbers
    /// </summary>
    /// <param name="dncListId">The dncListId</param>
    /// <param name="body">The body</param>
    /// <param name="expiredOnly">The expiredOnly</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task PatchOutboundDnclistWhatsappnumbersAsync(string dncListId, DncPatchEmailsRequest body, bool? expiredOnly = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Patch settings
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<OutboundSettings> PatchOutboundSettingsAsync(OutboundSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create campaignagentownedmappingpreview
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<AgentOwnedMappingPreviewListing> PostOutboundCampaignAgentownedmappingpreviewAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create campaignstart
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<Campaign> PostOutboundCampaignStartAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create campaignstop
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<Campaign> PostOutboundCampaignStopAsync(string campaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create campaignrules
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignRule> PostOutboundCampaignrulesAsync(CampaignRule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create campaigns
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <summary>
    /// Create contactlistcontacts
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="body">The body</param>
    /// <param name="priority">The priority</param>
    /// <param name="clearSystemData">The clearSystemData</param>
    /// <param name="doNotQueue">The doNotQueue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DialerContact> PostOutboundContactlistContactsAsync(string contactListId, IEnumerable<DialerContact> body, int? priority = null, bool? clearSystemData = null, bool? doNotQueue = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlistcontactsbulk
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactsBulkOperationJob> PostOutboundContactlistContactsBulkAsync(string contactListId, IEnumerable<string> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlistcontactsbulkremove
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactsBulkOperationJob> PostOutboundContactlistContactsBulkRemoveAsync(string contactListId, ContactBulkDeleteRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlistcontactsbulkupdate
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactsBulkOperationJob> PostOutboundContactlistContactsBulkUpdateAsync(string contactListId, ContactBulkEditRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlistcontactssearch
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListingResponse> PostOutboundContactlistContactsSearchAsync(string contactListId, ContactListingRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlistfilters
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListFilter> PostOutboundContactlistfiltersAsync(ContactListFilter body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlistfiltersbulkretrieve
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListFilterEntityListing> PostOutboundContactlistfiltersBulkRetrieveAsync(ContactListFilterBulkRetrieveBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlistfilterspreview
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<FilterPreviewResponse> PostOutboundContactlistfiltersPreviewAsync(ContactListFilter body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlists
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactList> PostOutboundContactlistsAsync(ContactList body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlisttemplates
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListTemplate> PostOutboundContactlisttemplatesAsync(ContactListTemplate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlisttemplatesbulkadd
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListTemplateEntityListing> PostOutboundContactlisttemplatesBulkAddAsync(IEnumerable<ContactListTemplate> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create contactlisttemplatesbulkretrieve
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListTemplateEntityListing> PostOutboundContactlisttemplatesBulkRetrieveAsync(ContactListTemplateBulkRetrieveBody body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create digitalrulesets
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ImportTemplate> PostOutboundImporttemplatesBulkAddAsync(IEnumerable<ImportTemplate> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create messagingcampaignstart
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaign> PostOutboundMessagingcampaignStartAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create messagingcampaignstop
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaign> PostOutboundMessagingcampaignStopAsync(string messagingCampaignId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create messagingcampaigns
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaign> PostOutboundMessagingcampaignsAsync(MessagingCampaign body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update campaign
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    /// <summary>
    /// Update campaignrule
    /// </summary>
    /// <param name="campaignRuleId">The campaignRuleId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignRule> PutOutboundCampaignruleAsync(string campaignRuleId, CampaignRule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update contactlist
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactList> PutOutboundContactlistAsync(string contactListId, ContactList body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update contactlistcontact
    /// </summary>
    /// <param name="contactListId">The contactListId</param>
    /// <param name="contactId">The contactId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<DialerContact> PutOutboundContactlistContactAsync(string contactListId, string contactId, DialerContact body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update contactlistfilter
    /// </summary>
    /// <param name="contactListFilterId">The contactListFilterId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListFilter> PutOutboundContactlistfilterAsync(string contactListFilterId, ContactListFilter body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update contactlisttemplate
    /// </summary>
    /// <param name="contactListTemplateId">The contactListTemplateId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<ContactListTemplate> PutOutboundContactlisttemplateAsync(string contactListTemplateId, ContactListTemplate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update messagingcampaign
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaign> PutOutboundMessagingcampaignAsync(string messagingCampaignId, MessagingCampaign body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update schedulescampaign
    /// </summary>
    /// <param name="campaignId">The campaignId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSchedule> PutOutboundSchedulesCampaignAsync(string campaignId, CampaignSchedule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update schedulesemailcampaign
    /// </summary>
    /// <param name="emailCampaignId">The emailCampaignId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<EmailCampaignSchedule> PutOutboundSchedulesEmailcampaignAsync(string emailCampaignId, EmailCampaignSchedule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update schedulesmessagingcampaign
    /// </summary>
    /// <param name="messagingCampaignId">The messagingCampaignId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<MessagingCampaignSchedule> PutOutboundSchedulesMessagingcampaignAsync(string messagingCampaignId, MessagingCampaignSchedule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update schedulessequence
    /// </summary>
    /// <param name="sequenceId">The sequenceId</param>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<CampaignSchedule> PutOutboundSchedulesSequenceAsync(string sequenceId, CampaignSchedule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedulescampaigns
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<IEnumerable<CampaignSchedule>> GetOutboundSchedulesCampaignsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedulesemailcampaigns
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<IEnumerable<EmailCampaignSchedule>> GetOutboundSchedulesEmailcampaignsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedulesmessagingcampaigns
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<IEnumerable<MessagingCampaignSchedule>> GetOutboundSchedulesMessagingcampaignsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get schedulessequences
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<IEnumerable<CampaignSchedule>> GetOutboundSchedulesSequencesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create campaignsprogress
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<IEnumerable<CampaignProgress>> PostOutboundCampaignsProgressAsync(IEnumerable<string> body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create messagingcampaignsprogress
    /// </summary>
    /// <param name="body">The body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task result</returns>
    Task<IEnumerable<CampaignProgress>> PostOutboundMessagingcampaignsProgressAsync(IEnumerable<string> body, CancellationToken cancellationToken = default);
}

