using PureCloud.Client.Models;
using PureCloud.Client.Models.Queues;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Contracts;

public interface IRoutingApi
{
    /// <inheritdoc />
    Task<AnalyticsQueryResponse> CreateAnalyticsQueuesObservationsQueryAsync(QueueObservationQuery body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingActivityResponse> CreateAnalyticsRoutingActivityQueryAsync(RoutingActivityQuery body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<BenefitAssessment> CreateRoutingAssessmentAsync(CreateBenefitAssessmentRequest body = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<BenefitAssessmentJob> CreateRoutingAssessmentsJobsAsync(CreateBenefitAssessmentJobRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> CreateRoutingEmailDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> CreateRoutingEmailDomainRouteAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> CreateRoutingEmailDomainRoutesAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TestMessage> CreateRoutingEmailDomainTestconnectionAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> CreateRoutingEmailOutboundDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EmailOutboundDomainResult> CreateRoutingEmailOutboundDomainsSimulatedAsync(OutboundDomain body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Language> CreateRoutingLanguageAsync(Language body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Predictor> CreateRoutingPredictorsAsync(CreatePredictorRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Queue> CreateRoutingQueueAsync(QueueRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Queue> CreateRoutingQueueAsync(CreateQueueRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMember> CreateRoutingQueueMembersAsync(string queueId, IEnumerable<WritableEntity> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMember> CreateRoutingQueueUsersAsync(string queueId, IEnumerable<WritableEntity> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode[]> CreateRoutingQueueWrapupcodesAsync(string queueId, IEnumerable<WrapupCodeReference> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSkill> CreateRoutingSkillAsync(RoutingSkill body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroup> CreateRoutingSkillgroupAsync(SkillGroup body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupMemberDivisionListing> CreateRoutingSkillgroupMembersDivisionsAsync(string skillGroupId, SkillGroupMemberDivisions body = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAddress> CreateRoutingSmsAddressAsync(SmsAddressProvision body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAddress> CreateRoutingSmsAddressAsync(SmsAddress body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumber> CreateRoutingSmsPhoneNumberAsync(SmsPhoneNumberProvision body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAlphanumericConfig> CreateRoutingSmsPhonenumbersAlphanumericAsync(SmsAlphanumericConfig body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumberImportJobResponse> CreateRoutingSmsPhonenumbersImportAsync(SmsPhoneNumberImportJobRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabel> CreateRoutingUtilizationLabelsAsync(CreateUtilizationLabelRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationTag> CreateRoutingUtilizationTagsAsync(CreateUtilizationTagRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> CreateRoutingWrapupcodeAsync(WrapupCodeRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserLanguageEntityListing> CreateUserRoutinglanguagesAsync(string userId, UserRoutingLanguagePost body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkillEntityListing> CreateUserRoutingskillsAsync(string userId, UserRoutingSkillPost body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingQueueAsync(string queueId, bool? forceDelete = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingQueueMemberAsync(string queueId, string memberId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingQueueUserAsync(string queueId, string memberId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingQueueWrapupcodeAsync(string queueId, string codeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingSettingsAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingSkillgroupAsync(string skillGroupId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingSmsPhonenumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingUtilizationAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteUserRoutinglanguageAsync(string userId, string languageId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteUserRoutingskillAsync(string userId, string skillId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<BenefitAssessment> GetRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AssessmentListing> GetRoutingAssessmentsAsync(string before = null, string after = null, string limit = null, string pageSize = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<BenefitAssessmentJob> GetRoutingAssessmentsJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(string divisionId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AvailableMediaTypeEntityListing> GetRoutingAvailablemediatypesAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentDirectRoutingBackupSettings> GetRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> GetRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> GetRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> GetRoutingEmailDomainRouteIdentityresolutionAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRouteEntityListing> GetRoutingEmailDomainRoutesAsync(string domainName, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomainEntityListing> GetRoutingEmailDomainsAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EmailOutboundDomainResult> GetRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> GetRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomain> GetRoutingEmailOutboundDomainSearchAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(int? pageSize = null, int? pageNumber = null, string filter = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(string filter = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EmailSetup> GetRoutingEmailSetupAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Language> GetRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Recipient> GetRoutingMessageRecipientAsync(string recipientId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RecipientListing> GetRoutingMessageRecipientsAsync(string messengerType = null, string name = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RecipientListing> GetRoutingMessageRecipientsAsync(string messengerType = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Predictor> GetRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorModelFeatureListing> GetRoutingPredictorModelFeaturesAsync(string predictorId, string modelId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorModelListing> GetRoutingPredictorModelsAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, int? limit = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, string limit = null, string pageSize = null, IEnumerable<string> queueIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<KeyPerformanceIndicatorListing> GetRoutingPredictorsKeyperformanceindicatorsAsync(IEnumerable<string> kpiIds = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AssistantQueue> GetRoutingQueueAssistantAsync(string queueId, string expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AssistantQueue> GetRoutingQueueAssistantAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Queue> GetRoutingQueueAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ComparisonPeriod> GetRoutingQueueComparisonperiodAsync(string queueId, string comparisonPeriodId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ComparisonPeriodListing> GetRoutingQueueComparisonperiodsAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EstimatedWaitTimePredictions> GetRoutingQueueEstimatedwaittimeAsync(string queueId, string conversationId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionQueueConfig> GetRoutingQueueIdentityresolutionAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EstimatedWaitTimePredictions> GetRoutingQueueMediatypeEstimatedwaittimeAsync(string queueId, string mediaType, string labelId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EstimatedWaitTimePredictions> GetRoutingQueueMediatypeEstimatedwaittimeAsync(string queueId, string mediaType, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListingV1> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, bool? joined = null, string name = null, IEnumerable<string> profileSkills = null, IEnumerable<string> skills = null, IEnumerable<string> languages = null, IEnumerable<string> routingStatus = null, IEnumerable<string> presence = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeEntityListing> GetRoutingQueueWrapupcodesAsync(string queueId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, bool? active = null, string divisionId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, string hasMember = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAllAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(int? pageSize = null, int? pageNumber = null, bool? joined = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, bool? joined = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSettings> GetRoutingSettingsAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ContactCenterSettings> GetRoutingSettingsContactcenterAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TranscriptionSettings> GetRoutingSettingsTranscriptionAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSkill> GetRoutingSkillAsync(string skillId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroup> GetRoutingSkillgroupAsync(string skillGroupId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, string after = null, string before = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupMemberDivisionListing> GetRoutingSkillgroupMembersDivisionsAsync(string skillGroupId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, string name = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillEntityListing> GetRoutingSkillsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAddress> GetRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAddressEntityListing> GetRoutingSmsAddressesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, string addressRequirement = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SMSAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, bool? addressRequirement = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionConfig> GetRoutingSmsIdentityresolutionPhonenumberAsync(string addressId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumber> GetRoutingSmsPhoneNumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhoneNumbersAsync(string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumber> GetRoutingSmsPhonenumberAsync(string phoneNumberId, string expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhonenumbersAsync(string phoneNumber = null, IEnumerable<string> phoneNumberType = null, IEnumerable<string> phoneNumberStatus = null, IEnumerable<string> countryCode = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, string integrationId = null, string supportedContentId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentDirectRoutingBackupSettings> GetRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentMaxUtilizationResponse> GetRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationResponse> GetRoutingUtilizationAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentManagementUnitReference[]> GetRoutingUtilizationLabelAgentsAsync(string labelId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabel> GetRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabelEntityListing> GetRoutingUtilizationLabelsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentManagementUnitReference[]> GetRoutingUtilizationTagAgentsAsync(string tagId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationTag> GetRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationTagEntityListing> GetRoutingUtilizationTagsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> GetRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeEntityListing> GetRoutingWrapupcodesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> GetRoutingWrapupcodesDivisionviewAsync(string codeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeDivisionViewEntityListing> GetRoutingWrapupcodesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string name = null, IEnumerable<string> ids = null, IEnumerable<string> divisionIds = null, bool? includeState = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueueEntityListing> GetUserQueuesAsync(string userId, int? pageSize = null, int? pageNumber = null, bool? joined = null, IEnumerable<string> divisionIds = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserLanguageEntityListing> GetUserRoutinglanguagesAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkillEntityListing> GetUserRoutingskillsAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkillGroupEntityListing> GetUserSkillgroupsAsync(string userId, int? pageSize = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TestMessage> TestRoutingEmailDomainConnectionAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Conversation> UpdateRoutingConversationAsync(string conversationId, Conversation body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> UpdateRoutingEmailDomainAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionConfig> UpdateRoutingEmailDomainRouteIdentityresolutionAsync(string domainName, string routeId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> UpdateRoutingEmailDomainValidateAsync(string domainId, InboundDomainPatchRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EmailOutboundDomainResult> UpdateRoutingEmailOutboundDomainActivationAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Recipient> UpdateRoutingMessageRecipientAsync(string recipientId, Recipient body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Predictor> UpdateRoutingPredictorAsync(string predictorId, CreatePredictorRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Queue> UpdateRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionQueueConfig> UpdateRoutingQueueIdentityresolutionAsync(string queueId, IdentityResolutionQueueConfig body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> UpdateRoutingQueueMemberAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> UpdateRoutingQueueMembersAsync(string queueId, IEnumerable<QueueMember> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMember> UpdateRoutingQueueUserAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> UpdateRoutingQueueUsersAsync(string queueId, IEnumerable<QueueMember> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSettings> UpdateRoutingSettingsAsync(RoutingSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ContactCenterSettings> UpdateRoutingSettingsContactcenterAsync(ContactCenterSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TranscriptionSettings> UpdateRoutingSettingsTranscriptionAsync(TranscriptionSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroup> UpdateRoutingSkillgroupAsync(string skillGroupId, SkillGroup body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroup> UpdateRoutingSkillgroupAsync(string skillGroupId, SkillGroup body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IdentityResolutionConfig> UpdateRoutingSmsIdentityresolutionPhonenumberAsync(string phoneNumberId, IdentityResolutionConfig body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentDirectRoutingBackupSettings> UpdateRoutingUserDirectroutingbackupSettingsAsync(string userId, AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserUtilization> UpdateRoutingUserUtilizationAsync(string userId, UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationResponse> UpdateRoutingUtilizationAsync(UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabel> UpdateRoutingUtilizationLabelAsync(string labelId, UpdateUtilizationLabelRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> UpdateRoutingWrapupcodeAsync(string codeId, WrapupCode body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueue> UpdateUserQueueAsync(string queueId, string userId, UserQueue body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueueEntityListing> UpdateUserQueuesAsync(string userId, IEnumerable<UserQueue> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserRoutingLanguage> UpdateUserRoutinglanguageAsync(string userId, string languageId, UserRoutingLanguage body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserRoutingLanguageEntityListing> UpdateUserRoutinglanguagesBulkAsync(string userId, IEnumerable<UserRoutingLanguage> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserRoutingSkill> UpdateUserRoutingskillAsync(string userId, string skillId, UserRoutingSkill body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkillEntityListing> UpdateUserRoutingskillsBulkAsync(string userId, IEnumerable<UserRoutingSkillPost> body, CancellationToken cancellationToken = default);

}
