using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IRoutingApi
{
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
    Task<bool> DeleteRoutingUtilizationLabelAsync(string labelId, bool? forceDelete = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingUtilizationTagAsync(string tagId, bool? forceDelete = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteUserRoutinglanguageAsync(string userId, string languageId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<bool> DeleteUserRoutingskillAsync(string userId, string skillId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<BenefitAssessment> GetRoutingAssessmentAsync(string assessmentId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AssessmentJobListing> GetRoutingAssessmentsJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AssessmentJobListing> GetRoutingAssessmentsJobsAsync(List<string> divisionId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DirectroutingbackupSettings> GetRoutingDirectroutingbackupSettingsMeAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> GetRoutingEmailDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> GetRoutingEmailDomainRouteAsync(string domainName, string routeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRouteEntityListing> GetRoutingEmailDomainRoutesAsync(string domainName, int? pageSize = null, int? pageNumber = null, string pattern = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomainEntityListing> GetRoutingEmailDomainsAsync(bool? excludeStatus = null, string filter = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomain> GetRoutingEmailOutboundDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomainEntityListing> GetRoutingEmailOutboundDomainsAsync(string filter = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EmailSetup> GetRoutingEmailSetupAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Language> GetRoutingLanguageAsync(string languageId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<LanguageEntityListing> GetRoutingLanguagesAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<MessageTypeListing> GetRoutingMessageRecipientsAsync(string messengerType = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Predictor> GetRoutingPredictorAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorModels> GetRoutingPredictorModelFeaturesAsync(string predictorId, string modelId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorModels> GetRoutingPredictorModelsAsync(string predictorId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorListing> GetRoutingPredictorsAsync(string before = null, string after = null, string limit = null, int? pageSize = null, List<string> queueId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PredictorListing> GetRoutingPredictorsKeyperformanceindicatorsAsync(string kpiGroup = null, string expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Queue> GetRoutingQueueAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMember> GetRoutingQueueComparisonperiodAsync(string queueId, string comparisonPeriodId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueComparisonperiodsAsync(string queueId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EstimatedWaitTimePredictions> GetRoutingQueueEstimatedwaittimeAsync(string queueId, string conversationId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueMediatypeEstimatedwaittimeAsync(string queueId, string mediaType, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueMembersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, List<string> expand = null, string name = null, List<string> profileSkills = null, List<string> skills = null, List<string> languages = null, List<string> routingStatus = null, List<string> presence = null, List<string> memberBy = null, bool? joined = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> GetRoutingQueueUsersAsync(string queueId, int? pageNumber = null, int? pageSize = null, string sortOrder = null, List<string> expand = null, bool? joined = null, string name = null, List<string> profileSkills = null, List<string> skills = null, List<string> languages = null, List<string> routingStatus = null, List<string> presence = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeEntityListing> GetRoutingQueueWrapupcodesAsync(string queueId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, List<string> id = null, List<string> divisionId = null, List<string> skillEvaluationMethod = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAsync(int? pageNumber = null, int? pageSize = null, string sortOrder = null, string name = null, List<string> id = null, List<string> divisionId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueEntityListing> GetRoutingQueuesDivisionviewsAllAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserQueueEntityListing> GetRoutingQueuesMeAsync(bool? joined = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

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
    Task<SkillGroupMemberEntityListing> GetRoutingSkillgroupMembersAsync(string skillGroupId, int? pageSize = null, int? pageNumber = null, string after = null, string before = null, List<string> expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupMemberDivisionListing> GetRoutingSkillgroupMembersDivisionviewsAsync(string skillGroupId, int? pageSize = null, int? pageNumber = null, string after = null, string before = null, List<string> expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroupEntityListing> GetRoutingSkillgroupsAsync(int? pageSize = null, int? pageNumber = null, string name = null, string after = null, string before = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillEntityListing> GetRoutingSkillsAsync(int? pageSize = null, int? pageNumber = null, string name = null, List<string> id = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAddress> GetRoutingSmsAddressAsync(string addressId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAddressEntityListing> GetRoutingSmsAddressesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAvailablePhoneNumberEntityListing> GetRoutingSmsAvailablephonenumbersAsync(string countryCode, string phoneNumberType, string region = null, string city = null, string areaCode = null, string pattern = null, string addressRequirement = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumber> GetRoutingSmsPhonenumberAsync(string phoneNumberId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumberEntityListing> GetRoutingSmsPhonenumbersAsync(string phoneNumber = null, string phoneNumberType = null, string phoneNumberStatus = null, string countryCode = null, int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string language = null, string integration = null, string supportedContent = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DirectroutingbackupSettings> GetRoutingUserDirectroutingbackupSettingsAsync(string userId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentMaxUtilizationResponse> GetRoutingUserUtilizationAsync(string userId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationResponse> GetRoutingUtilizationAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabel> GetRoutingUtilizationLabelAsync(string labelId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabelEntityListing> GetRoutingUtilizationLabelsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationTag> GetRoutingUtilizationTagAsync(string tagId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationTagEntityListing> GetRoutingUtilizationTagsAsync(int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> GetRoutingWrapupcodeAsync(string codeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeEntityListing> GetRoutingWrapupcodesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, List<string> id = null, List<string> divisionId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeEntityListing> GetRoutingWrapupcodesDivisionviewsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, List<string> divisionId = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserLanguageEntityListing> GetUserRoutinglanguagesAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkillEntityListing> GetUserRoutingskillsAsync(string userId, int? pageSize = null, int? pageNumber = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentActivityEntityListing> PatchRoutingQueueMemberAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> PatchRoutingQueueMembersAsync(string queueId, List<QueueMember> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMember> PatchRoutingQueueUserAsync(string queueId, string memberId, QueueMember body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<QueueMemberEntityListing> PatchRoutingQueueUsersAsync(string queueId, List<QueueMember> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ContactCenterSettings> PatchRoutingSettingsContactcenterAsync(ContactCenterSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TranscriptionSettings> PatchRoutingSettingsTranscriptionAsync(TranscriptionSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentMaxUtilizationResponse> PatchUserRoutinglanguageAsync(string userId, string languageId, UserRoutingLanguage body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkill> PatchUserRoutingskillsAsync(string userId, List<UserRoutingSkillPost> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<BenefitAssessment> CreateRoutingAssessmentAsync(CreateBenefitAssessmentRequest body = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<BenefitAssessmentJob> CreateRoutingAssessmentsJobAsync(CreateBenefitAssessmentJobRequest body = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundDomain> CreateRoutingEmailDomainAsync(InboundDomain body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> CreateRoutingEmailDomainRouteAsync(string domainName, InboundRoute body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TestMessage> CreateRoutingEmailDomainTestconnectionAsync(string domainId, TestMessage body = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomain> CreateRoutingEmailOutboundDomainAsync(OutboundDomain body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Language> CreateRoutingLanguageAsync(Language body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Predictor> CreateRoutingPredictorAsync(CreatePredictorRequest body = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Queue> CreateRoutingQueueAsync(CreateQueueRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCodeReference> CreateRoutingQueueWrapupcodeAsync(string queueId, List<WrapupCodeReference> body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSkill> CreateRoutingSkillAsync(RoutingSkill body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroup> CreateRoutingSkillgroupAsync(SkillGroup body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsAddress> CreateRoutingSmsAddressAsync(SmsAddressProvision body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SmsPhoneNumber> CreateRoutingSmsPhonenumberAsync(SmsPhoneNumberProvision body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabel> CreateRoutingUtilizationLabelAsync(CreateUtilizationLabelRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationTag> CreateRoutingUtilizationTagAsync(CreateUtilizationTagRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> CreateRoutingWrapupcodeAsync(WrapupCode body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserLanguage> CreateUserRoutinglanguageAsync(string userId, UserRoutingLanguagePost body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkill> CreateUserRoutingskillAsync(string userId, UserRoutingSkillPost body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DirectroutingbackupSettings> UpdateRoutingDirectroutingbackupSettingsMeAsync(AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<InboundRoute> UpdateRoutingEmailDomainRouteAsync(string domainName, string routeId, InboundRoute body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundDomain> UpdateRoutingEmailOutboundDomainAsync(string domainId, OutboundDomain body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Language> UpdateRoutingLanguageAsync(string languageId, Language body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Queue> UpdateRoutingQueueAsync(string queueId, QueueRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSettings> UpdateRoutingSettingsAsync(RoutingSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<RoutingSkill> UpdateRoutingSkillAsync(string skillId, RoutingSkill body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SkillGroup> UpdateRoutingSkillgroupAsync(string skillGroupId, SkillGroup body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DirectroutingbackupSettings> UpdateRoutingUserDirectroutingbackupSettingsAsync(string userId, AgentDirectRoutingBackupSettings body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AgentMaxUtilizationResponse> UpdateRoutingUserUtilizationAsync(string userId, UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationResponse> UpdateRoutingUtilizationAsync(UtilizationRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationLabel> UpdateRoutingUtilizationLabelAsync(string labelId, UpdateUtilizationLabelRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UtilizationTag> UpdateRoutingUtilizationTagAsync(string tagId, UpdateUtilizationTagRequest body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<WrapupCode> UpdateRoutingWrapupcodeAsync(string codeId, WrapupCode body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserLanguage> UpdateUserRoutinglanguageAsync(string userId, string languageId, UserRoutingLanguage body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<UserSkill> UpdateUserRoutingskillAsync(string userId, string skillId, UserRoutingSkill body, CancellationToken cancellationToken = default);
}