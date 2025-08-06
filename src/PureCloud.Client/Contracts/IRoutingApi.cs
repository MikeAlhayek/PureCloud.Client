using PureCloud.Client.Models;
using PureCloud.Client.Models.Queues;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IRoutingApi
{
/// <summary>
    /// Create a wrap-up code
    /// </summary>
    /// <param name="body">Wrap-up Code</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code</returns>
    Task<WrapupCode> CreateRoutingWrapupcodesAsync(WrapupCode body, CancellationToken cancellationToken = default);

/// <summary>
    /// Update routing settings
    /// </summary>
    /// <param name="body">Routing Settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing settings</returns>
    Task<RoutingSettings> UpdateRoutingSettingsAsync(RoutingSettings body, CancellationToken cancellationToken = default);

/// <summary>
    /// Provision an SMS phone number
    /// </summary>
    /// <param name="body">SMS phone number provision</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number</returns>
    Task<SmsPhoneNumber> CreateRoutingSmsPhonenumbersAsync(SmsPhoneNumberProvision body, CancellationToken cancellationToken = default);

/// <summary>
    /// Create a language
    /// </summary>
    /// <param name="body">Language</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language</returns>
    Task<Language> CreateRoutingLanguagesAsync(Language body, CancellationToken cancellationToken = default);

/// <summary>
    /// Create an outbound email domain
    /// </summary>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Email outbound domain result</returns>
    Task<EmailOutboundDomainResult> CreateRoutingEmailOutboundDomainsAsync(OutboundDomain body, CancellationToken cancellationToken = default);

/// <summary>
    /// Create a benefit assessment
    /// </summary>
    /// <param name="body">Assessment</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment</returns>
    Task<BenefitAssessment> CreateRoutingAssessmentsAsync(CreateBenefitAssessmentRequest body, CancellationToken cancellationToken = default);

/// <summary>
    /// Test the connection settings for a domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Test message</returns>
    Task<TestMessage> CreateRoutingEmailDomainTestconnectionAsync(string domainId, CancellationToken cancellationToken = default);

/// <summary>
    /// Provision an alphanumeric SMS sender ID
    /// </summary>
    /// <param name="body">SMS alphanumeric configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS alphanumeric config</returns>
    Task<SmsAlphanumericConfig> CreateRoutingSmsPhonenumbersAlphanumericAsync(SmsAlphanumericConfig body, CancellationToken cancellationToken = default);

/// <summary>
    /// Update a route
    /// </summary>
    /// <param name="domainName">Email domain</param>
    /// <param name="routeId">Route ID</param>
    /// <param name="body">Route</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound route</returns>
    Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default);

/// <summary>
    /// Update a recipient
    /// </summary>
    /// <param name="recipientId">Recipient ID</param>
    /// <param name="body">Recipient</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recipient</returns>
    Task<Recipient> UpdateRoutingMessageRecipientAsync(string recipientId, Recipient body, CancellationToken cancellationToken = default);

/// <summary>
    /// Update the user's max utilization settings
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Utilization request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User utilization</returns>
    Task<UserUtilization> UpdateRoutingUserUtilizationAsync(string userId, UtilizationRequest body, CancellationToken cancellationToken = default);

/// <summary>
    /// Update a utilization label
    /// </summary>
    /// <param name="labelId">Label ID</param>
    /// <param name="body">Update utilization label request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization label</returns>
    Task<UtilizationLabel> UpdateRoutingUtilizationLabelAsync(string labelId, UpdateUtilizationLabelRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update routing skill for user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="skillId">Skill ID</param>
    /// <param name="body">Routing skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User routing skill</returns>
    Task<UserRoutingSkill> UpdateUserRoutingskillAsync(string userId, string skillId, UserRoutingSkill body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace all routing skills assigned to a user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="body">Routing skills</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill entity listing</returns>
    Task<UserSkillEntityListing> UpdateUserRoutingskillsBulkAsync(string userId, IEnumerable<UserRoutingSkillPost> body, CancellationToken cancellationToken = default);



    /// <summary>
    /// Retrieve the latest assessment jobs for all queues in the organization
    /// </summary>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assessment job listing</returns>
    Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get outbound email domains
    /// </summary>
    /// <param name="filter">Filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Outbound domain entity listing</returns>
    Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(string filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of supported languages
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Language name</param>
    /// <param name="ids">Language IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Language entity listing</returns>
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a recipient
    /// </summary>
    /// <param name="messengerType">Messenger type</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recipient listing</returns>
    Task<RecipientListing> GetRoutingMessageRecipientsAsync(string messengerType = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all Predictors
    /// </summary>
    /// <param name="before">Before cursor</param>
    /// <param name="after">After cursor</param>
    /// <param name="limit">Limit</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="queueIds">Queue IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Predictor listing</returns>
    Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, string limit = null, string pageSize = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get queue agent assistant data
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Assistant queue</returns>
    Task<AssistantQueue> GetRoutingQueueAssistantAsync(string queueId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get estimated wait time for queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Estimated wait time predictions</returns>
    Task<EstimatedWaitTimePredictions> GetRoutingQueueMediatypeEstimatedwaittimeAsync(string queueId, string mediaType, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the members of this queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member entity listing</returns>
    Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the users in this queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue member entity listing</returns>
    Task<QueueMemberEntityListing> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of routing queues
    /// </summary>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Queue name</param>
    /// <param name="ids">Queue IDs</param>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="hasMember">Has member</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue entity listing</returns>
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, string hasMember = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all queue division views
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue entity listing</returns>
    Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, bool? joined = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get skill group members
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="after">After</param>
    /// <param name="expand">Expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group member entity listing</returns>
    Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, int? after = null, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get skill group member divisions
    /// </summary>
    /// <param name="skillGroupId">Skill group ID</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group member division listing</returns>
    Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, string name = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get available SMS phone numbers
    /// </summary>
    /// <param name="countryCode">Country code</param>
    /// <param name="phoneNumberType">Phone number type</param>
    /// <param name="region">Region</param>
    /// <param name="city">City</param>
    /// <param name="areaCode">Area code</param>
    /// <param name="pattern">Pattern</param>
    /// <param name="addressRequirement">Address requirement</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS available phone number entity listing</returns>
    Task<SmsAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, bool? addressRequirement = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SMS phone numbers
    /// </summary>
    /// <param name="phoneNumber">Phone number</param>
    /// <param name="phoneNumberType">Phone number type</param>
    /// <param name="phoneNumberStatus">Phone number status</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <summary>
    /// Get utilization labels
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="name">Name</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Label utilization entity listing</returns>
    /// Get wrapup codes division views
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="name">Name</param>
    /// <param name="ids">IDs</param>
    /// <param name="divisionIds">Division IDs</param>
    /// <param name="includeState">Include state</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrapup code entity listing</returns>
    Task<WrapupCodeEntityListing> GetRoutingWrapupcodesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, bool? includeState = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get user skill groups
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="after">After</param>
    /// <param name="before">Before</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>User skill group entity listing</returns>
    Task<UserSkillGroupEntityListing> GetUserSkillgroupsAsync(string userId, int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SMS phone number
    /// </summary>
    /// <param name="phoneNumberId">Phone number ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number</returns>
    Task<SmsPhoneNumber> GetRoutingSmsPhoneNumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SMS phone numbers
    /// </summary>
    /// <param name="phoneNumber">Phone number</param>
    /// <param name="phoneNumberType">Phone number type</param>
    /// <param name="phoneNumberStatus">Phone number status</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="language">Language</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number entity listing</returns>
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhoneNumbersAsync(string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a benefit assessment
    /// </summary>
    /// <param name="body">Assessment</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment</returns>
    Task<BenefitAssessment> CreateRoutingAssessmentAsync(CreateBenefitAssessmentRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Test domain connectivity
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Test message</returns>
    Task<TestMessage> TestRoutingEmailDomainConnectionAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create email domain
    /// </summary>
    /// <param name="body">Domain</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain</returns>
    Task<InboundDomain> CreateRoutingEmailDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create queue
    /// </summary>
    /// <param name="body">Queue</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> CreateRoutingQueueAsync(CreateQueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create skill group
    /// </summary>
    /// <param name="body">Skill group</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Skill group</returns>
    Task<SkillGroup> CreateRoutingSkillgroupAsync(SkillGroup body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create skill
    /// </summary>
    /// <param name="body">Skill</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Routing skill</returns>
    Task<RoutingSkill> CreateRoutingSkillAsync(RoutingSkill body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create SMS address
    /// </summary>
    /// <param name="body">SMS address</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS address</returns>
    Task<SmsAddress> CreateRoutingSmsAddressAsync(SmsAddress body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Provision SMS phone number
    /// </summary>
    /// <param name="body">SMS phone number provision</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number</returns>
    Task<SmsPhoneNumber> CreateRoutingSmsPhoneNumberAsync(SmsPhoneNumberProvision body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a benefit assessment
    /// </summary>
    /// <param name="assessmentId">Assessment ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success</returns>
    Task<bool> DeleteRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a benefit assessment
    /// </summary>
    /// <param name="assessmentId">Assessment ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Benefit assessment</returns>
    Task<BenefitAssessment> GetRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an inbound domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Inbound domain</returns>
    Task<InboundDomain> GetRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a benefit assessment
    /// </summary>
    /// <param name="body">Assessment request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success</returns>
    Task<bool> DeleteRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an email domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success</returns>
    Task<bool> DeleteRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a route
    /// </summary>
    /// <param name="domainName">Domain name</param>
    /// <param name="routeId">Route ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success</returns>
    Task<bool> DeleteRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an outbound email domain
    /// </summary>
    /// <param name="domainId">Domain ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success</returns>
    Task<bool> DeleteRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success</returns>
    Task<bool> DeleteRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="forceDelete">Force delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success</returns>
    Task<bool> DeleteRoutingQueueAsync(string queueId, bool? forceDelete = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a skill
    /// </summary>
    /// <param name="skillId">Skill ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success</returns>
    Task<bool> DeleteRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a phone number provisioned for SMS
    /// </summary>
    /// <param name="phoneNumberId">Phone number ID</param>
    /// <param name="expand">Expand response with additional information</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number</returns>
    Task<SmsPhoneNumber> GetRoutingSmsPhonenumberAsync(string phoneNumberId, string expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of provisioned phone numbers
    /// </summary>
    /// <param name="phoneNumber">Filter on phone number address</param>
    /// <param name="phoneNumberType">Filter on phone number type</param>
    /// <param name="phoneNumberStatus">Filter on phone number status</param>
    /// <param name="countryCode">Filter on country code</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Optional field to sort results</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="language">Language tag for localization</param>
    /// <param name="integrationId">Filter on the Genesys Cloud integration id</param>
    /// <param name="supportedContentId">Filter based on the supported content ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>SMS phone number entity listing</returns>
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhonenumbersAsync(string phoneNumber = null, IEnumerable<string> phoneNumberType = null, IEnumerable<string> phoneNumberStatus = null, IEnumerable<string> countryCode = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, string integrationId = null, string supportedContentId = null, CancellationToken cancellationToken = default);


    /// <summary>
    /// Update direct routing backup settings
    /// </summary>
    /// <param name="body">Direct routing backup settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Direct routing backup settings</returns>
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a queue
    /// </summary>
    /// <param name="queueId">Queue ID</param>
    /// <param name="body">Queue request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Queue</returns>
    Task<Queue> UpdateRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update organization-wide max utilization settings
    /// </summary>
    /// <param name="body">Utilization request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Utilization response</returns>
    Task<UtilizationResponse> UpdateRoutingUtilizationAsync(UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a wrap-up code
    /// </summary>
    /// <param name="codeId">Wrap-up code ID</param>
    /// <param name="body">Wrap-up code request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Wrap-up code</returns>
    Task<WrapupCode> UpdateRoutingWrapupcodeAsync(string codeId, WrapupCodeRequest body, CancellationToken cancellationToken = default);
}
