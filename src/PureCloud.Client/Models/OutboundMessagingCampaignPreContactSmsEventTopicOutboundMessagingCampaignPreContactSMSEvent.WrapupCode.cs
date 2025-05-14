using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets WrapupCode
/// </summary>

public enum OutboundMessagingCampaignPreContactSmsEventTopicOutboundMessagingCampaignPreContactSMSEventWrapupCodeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum IninOutboundNumbersInvalid for "ININ_OUTBOUND_NUMBERS_INVALID"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_NUMBERS_INVALID")]
    IninOutboundNumbersInvalid,

    /// <summary>
    /// Enum IninOutboundContactAttemptLimitSkipped for "ININ_OUTBOUND_CONTACT_ATTEMPT_LIMIT_SKIPPED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_CONTACT_ATTEMPT_LIMIT_SKIPPED")]
    IninOutboundContactAttemptLimitSkipped,

    /// <summary>
    /// Enum IninOutboundInternalErrorSkipped for "ININ_OUTBOUND_INTERNAL_ERROR_SKIPPED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_INTERNAL_ERROR_SKIPPED")]
    IninOutboundInternalErrorSkipped,

    /// <summary>
    /// Enum IninOutboundDncSkipped for "ININ_OUTBOUND_DNC_SKIPPED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_DNC_SKIPPED")]
    IninOutboundDncSkipped,

    /// <summary>
    /// Enum IninOutboundZoneBlockedSkipped for "ININ_OUTBOUND_ZONE_BLOCKED_SKIPPED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_ZONE_BLOCKED_SKIPPED")]
    IninOutboundZoneBlockedSkipped,

    /// <summary>
    /// Enum OutboundMessageBlank for "OUTBOUND_MESSAGE_BLANK"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_MESSAGE_BLANK")]
    OutboundMessageBlank,

    /// <summary>
    /// Enum OutboundRuleErrorSkipped for "OUTBOUND_RULE_ERROR_SKIPPED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_RULE_ERROR_SKIPPED")]
    OutboundRuleErrorSkipped,

    /// <summary>
    /// Enum OutboundRuleSkipped for "OUTBOUND_RULE_SKIPPED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_RULE_SKIPPED")]
    OutboundRuleSkipped,

    /// <summary>
    /// Enum OutboundContactUncontactableSkipped for "OUTBOUND_CONTACT_UNCONTACTABLE_SKIPPED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_CONTACT_UNCONTACTABLE_SKIPPED")]
    OutboundContactUncontactableSkipped,

    /// <summary>
    /// Enum OutboundNumberUncontactableSkipped for "OUTBOUND_NUMBER_UNCONTACTABLE_SKIPPED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_NUMBER_UNCONTACTABLE_SKIPPED")]
    OutboundNumberUncontactableSkipped,

    /// <summary>
    /// Enum OutboundContactAddressUncontactableSkipped for "OUTBOUND_CONTACT_ADDRESS_UNCONTACTABLE_SKIPPED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_CONTACT_ADDRESS_UNCONTACTABLE_SKIPPED")]
    OutboundContactAddressUncontactableSkipped,

    /// <summary>
    /// Enum OutboundInvalidPhoneNumber for "OUTBOUND_INVALID_PHONE_NUMBER"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_INVALID_PHONE_NUMBER")]
    OutboundInvalidPhoneNumber,

    /// <summary>
    /// Enum IninOutboundDncAuthenticationFailed for "ININ_OUTBOUND_DNC_AUTHENTICATION_FAILED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_DNC_AUTHENTICATION_FAILED")]
    IninOutboundDncAuthenticationFailed,

    /// <summary>
    /// Enum IninOutboundDncInvalidPhoneNumber for "ININ_OUTBOUND_DNC_INVALID_PHONE_NUMBER"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_DNC_INVALID_PHONE_NUMBER")]
    IninOutboundDncInvalidPhoneNumber,

    /// <summary>
    /// Enum IninOutboundAutomaticTimezoneBlocked for "ININ_OUTBOUND_AUTOMATIC_TIMEZONE_BLOCKED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_AUTOMATIC_TIMEZONE_BLOCKED")]
    IninOutboundAutomaticTimezoneBlocked,

    /// <summary>
    /// Enum IninOutboundNumberAttemptLimitSkipped for "ININ_OUTBOUND_NUMBER_ATTEMPT_LIMIT_SKIPPED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_NUMBER_ATTEMPT_LIMIT_SKIPPED")]
    IninOutboundNumberAttemptLimitSkipped,

    /// <summary>
    /// Enum IninOutboundOnDoNotCallList for "ININ_OUTBOUND_ON_DO_NOT_CALL_LIST"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_ON_DO_NOT_CALL_LIST")]
    IninOutboundOnDoNotCallList,

    /// <summary>
    /// Enum IninOutboundNotCallableTime for "ININ_OUTBOUND_NOT_CALLABLE_TIME"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_NOT_CALLABLE_TIME")]
    IninOutboundNotCallableTime,

    /// <summary>
    /// Enum OutboundMaxMessageLengthExceeded for "OUTBOUND_MAX_MESSAGE_LENGTH_EXCEEDED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_MAX_MESSAGE_LENGTH_EXCEEDED")]
    OutboundMaxMessageLengthExceeded
}
