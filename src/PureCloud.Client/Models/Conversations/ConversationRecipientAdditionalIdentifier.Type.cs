using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ConversationRecipientAdditionalIdentifierTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Deployment for "Deployment"
    /// </summary>
    [EnumMember(Value = "Deployment")]
    Deployment,

    /// <summary>
    /// Enum Subject for "Subject"
    /// </summary>
    [EnumMember(Value = "Subject")]
    Subject,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Topic for "Topic"
    /// </summary>
    [EnumMember(Value = "Topic")]
    Topic,

    /// <summary>
    /// Enum Ingestionrule for "IngestionRule"
    /// </summary>
    [EnumMember(Value = "IngestionRule")]
    Ingestionrule,

    /// <summary>
    /// Enum Ingestionruleversion for "IngestionRuleVersion"
    /// </summary>
    [EnumMember(Value = "IngestionRuleVersion")]
    Ingestionruleversion
}
