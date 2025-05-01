using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EventMessage
/// </summary>
[DataContract]
public partial class EventMessage : IEquatable<EventMessage>
{
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum ActiveCampaignsLimitExceeded for "ACTIVE_CAMPAIGNS_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "ACTIVE_CAMPAIGNS_LIMIT_EXCEEDED")]
        ActiveCampaignsLimitExceeded,

        /// <summary>
        /// Enum AllCampaignsBlacklisted for "ALL_CAMPAIGNS_BLACKLISTED"
        /// </summary>
        [EnumMember(Value = "ALL_CAMPAIGNS_BLACKLISTED")]
        AllCampaignsBlacklisted,

        /// <summary>
        /// Enum AnotherCampaignStarting for "ANOTHER_CAMPAIGN_STARTING"
        /// </summary>
        [EnumMember(Value = "ANOTHER_CAMPAIGN_STARTING")]
        AnotherCampaignStarting,

        /// <summary>
        /// Enum ApproachingContactLimit for "APPROACHING_CONTACT_LIMIT"
        /// </summary>
        [EnumMember(Value = "APPROACHING_CONTACT_LIMIT")]
        ApproachingContactLimit,

        /// <summary>
        /// Enum ApproachingDncListPhoneNumberLimit for "APPROACHING_DNC_LIST_PHONE_NUMBER_LIMIT"
        /// </summary>
        [EnumMember(Value = "APPROACHING_DNC_LIST_PHONE_NUMBER_LIMIT")]
        ApproachingDncListPhoneNumberLimit,

        /// <summary>
        /// Enum ApproachingDncOrganizationPhoneNumberLimit for "APPROACHING_DNC_ORGANIZATION_PHONE_NUMBER_LIMIT"
        /// </summary>
        [EnumMember(Value = "APPROACHING_DNC_ORGANIZATION_PHONE_NUMBER_LIMIT")]
        ApproachingDncOrganizationPhoneNumberLimit,

        /// <summary>
        /// Enum ApproachingEntityLimit for "APPROACHING_ENTITY_LIMIT"
        /// </summary>
        [EnumMember(Value = "APPROACHING_ENTITY_LIMIT")]
        ApproachingEntityLimit,

        /// <summary>
        /// Enum AutomaticTimeZoneZipCodeInvalid for "AUTOMATIC_TIME_ZONE_ZIP_CODE_INVALID"
        /// </summary>
        [EnumMember(Value = "AUTOMATIC_TIME_ZONE_ZIP_CODE_INVALID")]
        AutomaticTimeZoneZipCodeInvalid,

        /// <summary>
        /// Enum CampaignBlacklisted for "CAMPAIGN_BLACKLISTED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_BLACKLISTED")]
        CampaignBlacklisted,

        /// <summary>
        /// Enum CampaignBuildContactQueueError for "CAMPAIGN_BUILD_CONTACT_QUEUE_ERROR"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_BUILD_CONTACT_QUEUE_ERROR")]
        CampaignBuildContactQueueError,

        /// <summary>
        /// Enum CampaignContentTemplateSubstitutionMismatch for "CAMPAIGN_CONTENT_TEMPLATE_SUBSTITUTION_MISMATCH"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_CONTENT_TEMPLATE_SUBSTITUTION_MISMATCH")]
        CampaignContentTemplateSubstitutionMismatch,

        /// <summary>
        /// Enum CampaignCallsPerAgentLow for "CAMPAIGN_CALLS_PER_AGENT_LOW"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_CALLS_PER_AGENT_LOW")]
        CampaignCallsPerAgentLow,

        /// <summary>
        /// Enum CampaignEmailBodyCharacterLimitExceeded for "CAMPAIGN_EMAIL_BODY_CHARACTER_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_EMAIL_BODY_CHARACTER_LIMIT_EXCEEDED")]
        CampaignEmailBodyCharacterLimitExceeded,

        /// <summary>
        /// Enum CampaignEmailSubjectCharacterLimitExceeded for "CAMPAIGN_EMAIL_SUBJECT_CHARACTER_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_EMAIL_SUBJECT_CHARACTER_LIMIT_EXCEEDED")]
        CampaignEmailSubjectCharacterLimitExceeded,

        /// <summary>
        /// Enum CampaignWhatsappHeaderValueLimitExceeded for "CAMPAIGN_WHATSAPP_HEADER_VALUE_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_WHATSAPP_HEADER_VALUE_LIMIT_EXCEEDED")]
        CampaignWhatsappHeaderValueLimitExceeded,

        /// <summary>
        /// Enum CampaignWhatsappButtonUrlValueLimitExceeded for "CAMPAIGN_WHATSAPP_BUTTON_URL_VALUE_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_WHATSAPP_BUTTON_URL_VALUE_LIMIT_EXCEEDED")]
        CampaignWhatsappButtonUrlValueLimitExceeded,

        /// <summary>
        /// Enum CampaignInvalidated for "CAMPAIGN_INVALIDATED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_INVALIDATED")]
        CampaignInvalidated,

        /// <summary>
        /// Enum CampaignForceStopped for "CAMPAIGN_FORCE_STOPPED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_FORCE_STOPPED")]
        CampaignForceStopped,

        /// <summary>
        /// Enum CampaignMessageCharacterLimitExceeded for "CAMPAIGN_MESSAGE_CHARACTER_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_MESSAGE_CHARACTER_LIMIT_EXCEEDED")]
        CampaignMessageCharacterLimitExceeded,

        /// <summary>
        /// Enum CampaignStartError for "CAMPAIGN_START_ERROR"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_START_ERROR")]
        CampaignStartError,

        /// <summary>
        /// Enum CampaignRuleStartError for "CAMPAIGN_RULE_START_ERROR"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_RULE_START_ERROR")]
        CampaignRuleStartError,

        /// <summary>
        /// Enum CampaignScriptStageMissing for "CAMPAIGN_SCRIPT_STAGE_MISSING"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_SCRIPT_STAGE_MISSING")]
        CampaignScriptStageMissing,

        /// <summary>
        /// Enum CampaignSetDialingModeError for "CAMPAIGN_SET_DIALING_MODE_ERROR"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_SET_DIALING_MODE_ERROR")]
        CampaignSetDialingModeError,

        /// <summary>
        /// Enum CampaignStopped for "CAMPAIGN_STOPPED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_STOPPED")]
        CampaignStopped,

        /// <summary>
        /// Enum CampaignThrottled for "CAMPAIGN_THROTTLED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_THROTTLED")]
        CampaignThrottled,

        /// <summary>
        /// Enum CampaignQueueMembersLimitExceeded for "CAMPAIGN_QUEUE_MEMBERS_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_QUEUE_MEMBERS_LIMIT_EXCEEDED")]
        CampaignQueueMembersLimitExceeded,

        /// <summary>
        /// Enum CampaignWeightZero for "CAMPAIGN_WEIGHT_ZERO"
        /// </summary>
        [EnumMember(Value = "CAMPAIGN_WEIGHT_ZERO")]
        CampaignWeightZero,

        /// <summary>
        /// Enum InvalidCallableTimeZone for "INVALID_CALLABLE_TIME_ZONE"
        /// </summary>
        [EnumMember(Value = "INVALID_CALLABLE_TIME_ZONE")]
        InvalidCallableTimeZone,

        /// <summary>
        /// Enum CallbackCreationInvalidNumber for "CALLBACK_CREATION_INVALID_NUMBER"
        /// </summary>
        [EnumMember(Value = "CALLBACK_CREATION_INVALID_NUMBER")]
        CallbackCreationInvalidNumber,

        /// <summary>
        /// Enum CallRuleInvalidContactColumn for "CALL_RULE_INVALID_CONTACT_COLUMN"
        /// </summary>
        [EnumMember(Value = "CALL_RULE_INVALID_CONTACT_COLUMN")]
        CallRuleInvalidContactColumn,

        /// <summary>
        /// Enum CallRuleMissingDataActionInput for "CALL_RULE_MISSING_DATA_ACTION_INPUT"
        /// </summary>
        [EnumMember(Value = "CALL_RULE_MISSING_DATA_ACTION_INPUT")]
        CallRuleMissingDataActionInput,

        /// <summary>
        /// Enum CallRuleMismatchType for "CALL_RULE_MISMATCH_TYPE"
        /// </summary>
        [EnumMember(Value = "CALL_RULE_MISMATCH_TYPE")]
        CallRuleMismatchType,

        /// <summary>
        /// Enum CallRuleInvalidOperator for "CALL_RULE_INVALID_OPERATOR"
        /// </summary>
        [EnumMember(Value = "CALL_RULE_INVALID_OPERATOR")]
        CallRuleInvalidOperator,

        /// <summary>
        /// Enum CallRuleNoDncListsConfigured for "CALL_RULE_NO_DNC_LISTS_CONFIGURED"
        /// </summary>
        [EnumMember(Value = "CALL_RULE_NO_DNC_LISTS_CONFIGURED")]
        CallRuleNoDncListsConfigured,

        /// <summary>
        /// Enum CallRuleUpdatedPhoneColumn for "CALL_RULE_UPDATED_PHONE_COLUMN"
        /// </summary>
        [EnumMember(Value = "CALL_RULE_UPDATED_PHONE_COLUMN")]
        CallRuleUpdatedPhoneColumn,

        /// <summary>
        /// Enum ContactListFilterEvaluationFailed for "CONTACT_LIST_FILTER_EVALUATION_FAILED"
        /// </summary>
        [EnumMember(Value = "CONTACT_LIST_FILTER_EVALUATION_FAILED")]
        ContactListFilterEvaluationFailed,

        /// <summary>
        /// Enum ContactListFilterInternalError for "CONTACT_LIST_FILTER_INTERNAL_ERROR"
        /// </summary>
        [EnumMember(Value = "CONTACT_LIST_FILTER_INTERNAL_ERROR")]
        ContactListFilterInternalError,

        /// <summary>
        /// Enum ContactColumnsLimitExceeded for "CONTACT_COLUMNS_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CONTACT_COLUMNS_LIMIT_EXCEEDED")]
        ContactColumnsLimitExceeded,

        /// <summary>
        /// Enum ContactColumnLengthLimitExceeded for "CONTACT_COLUMN_LENGTH_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CONTACT_COLUMN_LENGTH_LIMIT_EXCEEDED")]
        ContactColumnLengthLimitExceeded,

        /// <summary>
        /// Enum ContactIdLengthLimitExceeded for "CONTACT_ID_LENGTH_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CONTACT_ID_LENGTH_LIMIT_EXCEEDED")]
        ContactIdLengthLimitExceeded,

        /// <summary>
        /// Enum ContactDatumLengthLimitExceeded for "CONTACT_DATUM_LENGTH_LIMIT_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "CONTACT_DATUM_LENGTH_LIMIT_EXCEEDED")]
        ContactDatumLengthLimitExceeded,

        /// <summary>
        /// Enum ContactZipCodeColumnValueInvalid for "CONTACT_ZIP_CODE_COLUMN_VALUE_INVALID"
        /// </summary>
        [EnumMember(Value = "CONTACT_ZIP_CODE_COLUMN_VALUE_INVALID")]
        ContactZipCodeColumnValueInvalid,

        /// <summary>
        /// Enum DataActionExecutionFailed for "DATA_ACTION_EXECUTION_FAILED"
        /// </summary>
        [EnumMember(Value = "DATA_ACTION_EXECUTION_FAILED")]
        DataActionExecutionFailed,

        /// <summary>
        /// Enum DataActionAuthenticationFailure for "DATA_ACTION_AUTHENTICATION_FAILURE"
        /// </summary>
        [EnumMember(Value = "DATA_ACTION_AUTHENTICATION_FAILURE")]
        DataActionAuthenticationFailure,

        /// <summary>
        /// Enum DataActionNotFound for "DATA_ACTION_NOT_FOUND"
        /// </summary>
        [EnumMember(Value = "DATA_ACTION_NOT_FOUND")]
        DataActionNotFound,

        /// <summary>
        /// Enum DataActionTooManyRequests for "DATA_ACTION_TOO_MANY_REQUESTS"
        /// </summary>
        [EnumMember(Value = "DATA_ACTION_TOO_MANY_REQUESTS")]
        DataActionTooManyRequests,

        /// <summary>
        /// Enum DataActionTooManyRequestsRemote for "DATA_ACTION_TOO_MANY_REQUESTS_REMOTE"
        /// </summary>
        [EnumMember(Value = "DATA_ACTION_TOO_MANY_REQUESTS_REMOTE")]
        DataActionTooManyRequestsRemote,

        /// <summary>
        /// Enum ActionExecutionFailed for "ACTION_EXECUTION_FAILED"
        /// </summary>
        [EnumMember(Value = "ACTION_EXECUTION_FAILED")]
        ActionExecutionFailed,

        /// <summary>
        /// Enum ActionExecutionFailedInvalidParameter for "ACTION_EXECUTION_FAILED_INVALID_PARAMETER"
        /// </summary>
        [EnumMember(Value = "ACTION_EXECUTION_FAILED_INVALID_PARAMETER")]
        ActionExecutionFailedInvalidParameter,

        /// <summary>
        /// Enum DigitalRuleEvaluationFailed for "DIGITAL_RULE_EVALUATION_FAILED"
        /// </summary>
        [EnumMember(Value = "DIGITAL_RULE_EVALUATION_FAILED")]
        DigitalRuleEvaluationFailed,

        /// <summary>
        /// Enum DigitalRuleInternalError for "DIGITAL_RULE_INTERNAL_ERROR"
        /// </summary>
        [EnumMember(Value = "DIGITAL_RULE_INTERNAL_ERROR")]
        DigitalRuleInternalError,

        /// <summary>
        /// Enum DigitalRuleNoDncListsConfigured for "DIGITAL_RULE_NO_DNC_LISTS_CONFIGURED"
        /// </summary>
        [EnumMember(Value = "DIGITAL_RULE_NO_DNC_LISTS_CONFIGURED")]
        DigitalRuleNoDncListsConfigured,

        /// <summary>
        /// Enum DigitalRuleUpdatedContactAddress for "DIGITAL_RULE_UPDATED_CONTACT_ADDRESS"
        /// </summary>
        [EnumMember(Value = "DIGITAL_RULE_UPDATED_CONTACT_ADDRESS")]
        DigitalRuleUpdatedContactAddress,

        /// <summary>
        /// Enum DigitalRuleSmsPhoneNumberTypeMismatch for "DIGITAL_RULE_SMS_PHONE_NUMBER_TYPE_MISMATCH"
        /// </summary>
        [EnumMember(Value = "DIGITAL_RULE_SMS_PHONE_NUMBER_TYPE_MISMATCH")]
        DigitalRuleSmsPhoneNumberTypeMismatch,

        /// <summary>
        /// Enum DigitalRuleErrorSkipped for "DIGITAL_RULE_ERROR_SKIPPED"
        /// </summary>
        [EnumMember(Value = "DIGITAL_RULE_ERROR_SKIPPED")]
        DigitalRuleErrorSkipped,

        /// <summary>
        /// Enum DncAuthenticationFailure for "DNC_AUTHENTICATION_FAILURE"
        /// </summary>
        [EnumMember(Value = "DNC_AUTHENTICATION_FAILURE")]
        DncAuthenticationFailure,

        /// <summary>
        /// Enum ExceededContactLimit for "EXCEEDED_CONTACT_LIMIT"
        /// </summary>
        [EnumMember(Value = "EXCEEDED_CONTACT_LIMIT")]
        ExceededContactLimit,

        /// <summary>
        /// Enum ExceededDncRecordLimit for "EXCEEDED_DNC_RECORD_LIMIT"
        /// </summary>
        [EnumMember(Value = "EXCEEDED_DNC_RECORD_LIMIT")]
        ExceededDncRecordLimit,

        /// <summary>
        /// Enum ExceededDncPhoneNumberLength for "EXCEEDED_DNC_PHONE_NUMBER_LENGTH"
        /// </summary>
        [EnumMember(Value = "EXCEEDED_DNC_PHONE_NUMBER_LENGTH")]
        ExceededDncPhoneNumberLength,

        /// <summary>
        /// Enum InactiveEdgesFailedPlaceCalls for "INACTIVE_EDGES_FAILED_PLACE_CALLS"
        /// </summary>
        [EnumMember(Value = "INACTIVE_EDGES_FAILED_PLACE_CALLS")]
        InactiveEdgesFailedPlaceCalls,

        /// <summary>
        /// Enum InactiveEdgesTurnedCampaignOff for "INACTIVE_EDGES_TURNED_CAMPAIGN_OFF"
        /// </summary>
        [EnumMember(Value = "INACTIVE_EDGES_TURNED_CAMPAIGN_OFF")]
        InactiveEdgesTurnedCampaignOff,

        /// <summary>
        /// Enum InvalidAgent for "INVALID_AGENT"
        /// </summary>
        [EnumMember(Value = "INVALID_AGENT")]
        InvalidAgent,

        /// <summary>
        /// Enum InvalidEmailAddress for "INVALID_EMAIL_ADDRESS"
        /// </summary>
        [EnumMember(Value = "INVALID_EMAIL_ADDRESS")]
        InvalidEmailAddress,

        /// <summary>
        /// Enum InvalidPhoneNumber for "INVALID_PHONE_NUMBER"
        /// </summary>
        [EnumMember(Value = "INVALID_PHONE_NUMBER")]
        InvalidPhoneNumber,

        /// <summary>
        /// Enum ImportFailedToReadHeaders for "IMPORT_FAILED_TO_READ_HEADERS"
        /// </summary>
        [EnumMember(Value = "IMPORT_FAILED_TO_READ_HEADERS")]
        ImportFailedToReadHeaders,

        /// <summary>
        /// Enum ImportCouldNotParseAnEntry for "IMPORT_COULD_NOT_PARSE_AN_ENTRY"
        /// </summary>
        [EnumMember(Value = "IMPORT_COULD_NOT_PARSE_AN_ENTRY")]
        ImportCouldNotParseAnEntry,

        /// <summary>
        /// Enum ImportContactDoesNotMatchListFormat for "IMPORT_CONTACT_DOES_NOT_MATCH_LIST_FORMAT"
        /// </summary>
        [EnumMember(Value = "IMPORT_CONTACT_DOES_NOT_MATCH_LIST_FORMAT")]
        ImportContactDoesNotMatchListFormat,

        /// <summary>
        /// Enum ImportEntryDoesNotAlignWithHeaders for "IMPORT_ENTRY_DOES_NOT_ALIGN_WITH_HEADERS"
        /// </summary>
        [EnumMember(Value = "IMPORT_ENTRY_DOES_NOT_ALIGN_WITH_HEADERS")]
        ImportEntryDoesNotAlignWithHeaders,

        /// <summary>
        /// Enum ImportInvalidCustomId for "IMPORT_INVALID_CUSTOM_ID"
        /// </summary>
        [EnumMember(Value = "IMPORT_INVALID_CUSTOM_ID")]
        ImportInvalidCustomId,

        /// <summary>
        /// Enum ImportInvalidData for "IMPORT_INVALID_DATA"
        /// </summary>
        [EnumMember(Value = "IMPORT_INVALID_DATA")]
        ImportInvalidData,

        /// <summary>
        /// Enum ImportInvalidEmailAddresses for "IMPORT_INVALID_EMAIL_ADDRESSES"
        /// </summary>
        [EnumMember(Value = "IMPORT_INVALID_EMAIL_ADDRESSES")]
        ImportInvalidEmailAddresses,

        /// <summary>
        /// Enum ImportInvalidPhoneNumbers for "IMPORT_INVALID_PHONE_NUMBERS"
        /// </summary>
        [EnumMember(Value = "IMPORT_INVALID_PHONE_NUMBERS")]
        ImportInvalidPhoneNumbers,

        /// <summary>
        /// Enum ImportInvalidExpirationDate for "IMPORT_INVALID_EXPIRATION_DATE"
        /// </summary>
        [EnumMember(Value = "IMPORT_INVALID_EXPIRATION_DATE")]
        ImportInvalidExpirationDate,

        /// <summary>
        /// Enum ImportExpirationDateExceedsMaxDays for "IMPORT_EXPIRATION_DATE_EXCEEDS_MAX_DAYS"
        /// </summary>
        [EnumMember(Value = "IMPORT_EXPIRATION_DATE_EXCEEDS_MAX_DAYS")]
        ImportExpirationDateExceedsMaxDays,

        /// <summary>
        /// Enum ImportColumnExceedsLengthLimit for "IMPORT_COLUMN_EXCEEDS_LENGTH_LIMIT"
        /// </summary>
        [EnumMember(Value = "IMPORT_COLUMN_EXCEEDS_LENGTH_LIMIT")]
        ImportColumnExceedsLengthLimit,

        /// <summary>
        /// Enum ImportDatumExceedsLengthLimit for "IMPORT_DATUM_EXCEEDS_LENGTH_LIMIT"
        /// </summary>
        [EnumMember(Value = "IMPORT_DATUM_EXCEEDS_LENGTH_LIMIT")]
        ImportDatumExceedsLengthLimit,

        /// <summary>
        /// Enum ImportMissingCustomId for "IMPORT_MISSING_CUSTOM_ID"
        /// </summary>
        [EnumMember(Value = "IMPORT_MISSING_CUSTOM_ID")]
        ImportMissingCustomId,

        /// <summary>
        /// Enum ImportNoColumnsDefined for "IMPORT_NO_COLUMNS_DEFINED"
        /// </summary>
        [EnumMember(Value = "IMPORT_NO_COLUMNS_DEFINED")]
        ImportNoColumnsDefined,

        /// <summary>
        /// Enum ImportColumnsDoNotExistOnList for "IMPORT_COLUMNS_DO_NOT_EXIST_ON_LIST"
        /// </summary>
        [EnumMember(Value = "IMPORT_COLUMNS_DO_NOT_EXIST_ON_LIST")]
        ImportColumnsDoNotExistOnList,

        /// <summary>
        /// Enum ImportListNoLongerExists for "IMPORT_LIST_NO_LONGER_EXISTS"
        /// </summary>
        [EnumMember(Value = "IMPORT_LIST_NO_LONGER_EXISTS")]
        ImportListNoLongerExists,

        /// <summary>
        /// Enum ImportNoListsCreatedNoContactsMatchFilter for "IMPORT_NO_LISTS_CREATED_NO_CONTACTS_MATCH_FILTER"
        /// </summary>
        [EnumMember(Value = "IMPORT_NO_LISTS_CREATED_NO_CONTACTS_MATCH_FILTER")]
        ImportNoListsCreatedNoContactsMatchFilter,

        /// <summary>
        /// Enum ImportTargetContactListNameExists for "IMPORT_TARGET_CONTACT_LIST_NAME_EXISTS"
        /// </summary>
        [EnumMember(Value = "IMPORT_TARGET_CONTACT_LIST_NAME_EXISTS")]
        ImportTargetContactListNameExists,

        /// <summary>
        /// Enum ImportFailedContactZipCodeColumnValueInvalid for "IMPORT_FAILED_CONTACT_ZIP_CODE_COLUMN_VALUE_INVALID"
        /// </summary>
        [EnumMember(Value = "IMPORT_FAILED_CONTACT_ZIP_CODE_COLUMN_VALUE_INVALID")]
        ImportFailedContactZipCodeColumnValueInvalid,

        /// <summary>
        /// Enum ImportFailedContactDataGreaterThanMaxLength for "IMPORT_FAILED_CONTACT_DATA_GREATER_THAN_MAX_LENGTH"
        /// </summary>
        [EnumMember(Value = "IMPORT_FAILED_CONTACT_DATA_GREATER_THAN_MAX_LENGTH")]
        ImportFailedContactDataGreaterThanMaxLength,

        /// <summary>
        /// Enum ImportFailedContactDataNotWithinMinMaxRange for "IMPORT_FAILED_CONTACT_DATA_NOT_WITHIN_MIN_MAX_RANGE"
        /// </summary>
        [EnumMember(Value = "IMPORT_FAILED_CONTACT_DATA_NOT_WITHIN_MIN_MAX_RANGE")]
        ImportFailedContactDataNotWithinMinMaxRange,

        /// <summary>
        /// Enum ImportFailedContactDataInvalidDatatype for "IMPORT_FAILED_CONTACT_DATA_INVALID_DATATYPE"
        /// </summary>
        [EnumMember(Value = "IMPORT_FAILED_CONTACT_DATA_INVALID_DATATYPE")]
        ImportFailedContactDataInvalidDatatype,

        /// <summary>
        /// Enum ImportTooManyColumns for "IMPORT_TOO_MANY_COLUMNS"
        /// </summary>
        [EnumMember(Value = "IMPORT_TOO_MANY_COLUMNS")]
        ImportTooManyColumns,

        /// <summary>
        /// Enum ImportTooManyExtraColumns for "IMPORT_TOO_MANY_EXTRA_COLUMNS"
        /// </summary>
        [EnumMember(Value = "IMPORT_TOO_MANY_EXTRA_COLUMNS")]
        ImportTooManyExtraColumns,

        /// <summary>
        /// Enum ImportContactListNameLengthExceeded for "IMPORT_CONTACT_LIST_NAME_LENGTH_EXCEEDED"
        /// </summary>
        [EnumMember(Value = "IMPORT_CONTACT_LIST_NAME_LENGTH_EXCEEDED")]
        ImportContactListNameLengthExceeded,

        /// <summary>
        /// Enum OrganizationHasNoDomainSet for "ORGANIZATION_HAS_NO_DOMAIN_SET"
        /// </summary>
        [EnumMember(Value = "ORGANIZATION_HAS_NO_DOMAIN_SET")]
        OrganizationHasNoDomainSet,

        /// <summary>
        /// Enum QueueNotFound for "QUEUE_NOT_FOUND"
        /// </summary>
        [EnumMember(Value = "QUEUE_NOT_FOUND")]
        QueueNotFound,

        /// <summary>
        /// Enum RecycleCampaign for "RECYCLE_CAMPAIGN"
        /// </summary>
        [EnumMember(Value = "RECYCLE_CAMPAIGN")]
        RecycleCampaign,

        /// <summary>
        /// Enum ScheduledCampaignInvalid for "SCHEDULED_CAMPAIGN_INVALID"
        /// </summary>
        [EnumMember(Value = "SCHEDULED_CAMPAIGN_INVALID")]
        ScheduledCampaignInvalid,

        /// <summary>
        /// Enum ScheduleUnknownError for "SCHEDULE_UNKNOWN_ERROR"
        /// </summary>
        [EnumMember(Value = "SCHEDULE_UNKNOWN_ERROR")]
        ScheduleUnknownError,

        /// <summary>
        /// Enum SmsContentTemplateNotFound for "SMS_CONTENT_TEMPLATE_NOT_FOUND"
        /// </summary>
        [EnumMember(Value = "SMS_CONTENT_TEMPLATE_NOT_FOUND")]
        SmsContentTemplateNotFound,

        /// <summary>
        /// Enum RecurringScheduleNextOccurrenceFailure for "RECURRING_SCHEDULE_NEXT_OCCURRENCE_FAILURE"
        /// </summary>
        [EnumMember(Value = "RECURRING_SCHEDULE_NEXT_OCCURRENCE_FAILURE")]
        RecurringScheduleNextOccurrenceFailure,

        /// <summary>
        /// Enum RecurringScheduleEnded for "RECURRING_SCHEDULE_ENDED"
        /// </summary>
        [EnumMember(Value = "RECURRING_SCHEDULE_ENDED")]
        RecurringScheduleEnded,

        /// <summary>
        /// Enum RecurringScheduleMissedOccurrences for "RECURRING_SCHEDULE_MISSED_OCCURRENCES"
        /// </summary>
        [EnumMember(Value = "RECURRING_SCHEDULE_MISSED_OCCURRENCES")]
        RecurringScheduleMissedOccurrences,

        /// <summary>
        /// Enum VersionConflict for "VERSION_CONFLICT"
        /// </summary>
        [EnumMember(Value = "VERSION_CONFLICT")]
        VersionConflict
    }
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public CodeEnum? Code { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EventMessage" /> class.
    /// </summary>
    /// <param name="Code">Code.</param>
    /// <param name="Message">Message.</param>
    /// <param name="MessageWithParams">MessageWithParams.</param>
    /// <param name="MessageParams">MessageParams.</param>
    /// <param name="DocumentationUri">DocumentationUri.</param>
    /// <param name="ResourceURIs">ResourceURIs.</param>
    public EventMessage(CodeEnum? Code = null, string Message = null, string MessageWithParams = null, Dictionary<string, object> MessageParams = null, string DocumentationUri = null, List<string> ResourceURIs = null)
    {
        this.Code = Code;
        this.Message = Message;
        this.MessageWithParams = MessageWithParams;
        this.MessageParams = MessageParams;
        this.DocumentationUri = DocumentationUri;
        this.ResourceURIs = ResourceURIs;

    }





    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets MessageWithParams
    /// </summary>
    [DataMember(Name = "messageWithParams", EmitDefaultValue = false)]
    public string MessageWithParams { get; set; }



    /// <summary>
    /// Gets or Sets MessageParams
    /// </summary>
    [DataMember(Name = "messageParams", EmitDefaultValue = false)]
    public Dictionary<string, object> MessageParams { get; set; }



    /// <summary>
    /// Gets or Sets DocumentationUri
    /// </summary>
    [DataMember(Name = "documentationUri", EmitDefaultValue = false)]
    public string DocumentationUri { get; set; }



    /// <summary>
    /// Gets or Sets ResourceURIs
    /// </summary>
    [DataMember(Name = "resourceURIs", EmitDefaultValue = false)]
    public List<string> ResourceURIs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventMessage {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
        sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
        sb.Append("  DocumentationUri: ").Append(DocumentationUri).Append("\n");
        sb.Append("  ResourceURIs: ").Append(ResourceURIs).Append("\n");
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
        return Equals(obj as EventMessage);
    }

    /// <summary>
    /// Returns true if EventMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of EventMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                MessageWithParams == other.MessageWithParams ||
                MessageWithParams != null &&
                MessageWithParams.Equals(other.MessageWithParams)
            ) &&
            (
                MessageParams == other.MessageParams ||
                MessageParams != null &&
                MessageParams.SequenceEqual(other.MessageParams)
            ) &&
            (
                DocumentationUri == other.DocumentationUri ||
                DocumentationUri != null &&
                DocumentationUri.Equals(other.DocumentationUri)
            ) &&
            (
                ResourceURIs == other.ResourceURIs ||
                ResourceURIs != null &&
                ResourceURIs.SequenceEqual(other.ResourceURIs)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (MessageWithParams != null)
            {
                hash = hash * 59 + MessageWithParams.GetHashCode();
            }

            if (MessageParams != null)
            {
                hash = hash * 59 + MessageParams.GetHashCode();
            }

            if (DocumentationUri != null)
            {
                hash = hash * 59 + DocumentationUri.GetHashCode();
            }

            if (ResourceURIs != null)
            {
                hash = hash * 59 + ResourceURIs.GetHashCode();
            }

            return hash;
        }
    }
}
