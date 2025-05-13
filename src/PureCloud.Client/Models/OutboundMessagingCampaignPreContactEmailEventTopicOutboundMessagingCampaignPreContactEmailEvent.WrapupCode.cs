using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets WrapupCode
/// </summary>

public enum OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEventWrapupCodeEnum
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
    /// Enum OutboundEmailsInvalidSkipped for "OUTBOUND_EMAILS_INVALID_SKIPPED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_EMAILS_INVALID_SKIPPED")]
    OutboundEmailsInvalidSkipped,

    /// <summary>
    /// Enum OutboundInvalidEmailAddress for "OUTBOUND_INVALID_EMAIL_ADDRESS"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_INVALID_EMAIL_ADDRESS")]
    OutboundInvalidEmailAddress,

    /// <summary>
    /// Enum OutboundMaxEmailSubjectLengthExceeded for "OUTBOUND_MAX_EMAIL_SUBJECT_LENGTH_EXCEEDED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_MAX_EMAIL_SUBJECT_LENGTH_EXCEEDED")]
    OutboundMaxEmailSubjectLengthExceeded,

    /// <summary>
    /// Enum OutboundMaxEmailBodyLengthExceeded for "OUTBOUND_MAX_EMAIL_BODY_LENGTH_EXCEEDED"
    /// </summary>
    [EnumMember(Value = "OUTBOUND_MAX_EMAIL_BODY_LENGTH_EXCEEDED")]
    OutboundMaxEmailBodyLengthExceeded,

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
    /// Enum IninOutboundZoneBlockedSkipped for "ININ_OUTBOUND_ZONE_BLOCKED_SKIPPED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_ZONE_BLOCKED_SKIPPED")]
    IninOutboundZoneBlockedSkipped,

    /// <summary>
    /// Enum IninOutboundDncSkipped for "ININ_OUTBOUND_DNC_SKIPPED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_DNC_SKIPPED")]
    IninOutboundDncSkipped,

    /// <summary>
    /// Enum IninOutboundInternalErrorSkipped for "ININ_OUTBOUND_INTERNAL_ERROR_SKIPPED"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_INTERNAL_ERROR_SKIPPED")]
    IninOutboundInternalErrorSkipped,

    /// <summary>
    /// Enum IninOutboundOnDoNotCallList for "ININ_OUTBOUND_ON_DO_NOT_CALL_LIST"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_ON_DO_NOT_CALL_LIST")]
    IninOutboundOnDoNotCallList,

    /// <summary>
    /// Enum IninOutboundNotCallableTime for "ININ_OUTBOUND_NOT_CALLABLE_TIME"
    /// </summary>
    [EnumMember(Value = "ININ_OUTBOUND_NOT_CALLABLE_TIME")]
    IninOutboundNotCallableTime
}
