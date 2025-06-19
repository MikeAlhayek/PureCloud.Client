using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CommonRuleTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Conversationmetrics for "ConversationMetrics"
    /// </summary>
    [EnumMember(Value = "ConversationMetrics")]
    Conversationmetrics,

    /// <summary>
    /// Enum Userpresence for "UserPresence"
    /// </summary>
    [EnumMember(Value = "UserPresence")]
    Userpresence,

    /// <summary>
    /// Enum Workforcemanagement for "WorkforceManagement"
    /// </summary>
    [EnumMember(Value = "WorkforceManagement")]
    Workforcemanagement,

    /// <summary>
    /// Enum Operationalconsole for "OperationalConsole"
    /// </summary>
    [EnumMember(Value = "OperationalConsole")]
    Operationalconsole,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
