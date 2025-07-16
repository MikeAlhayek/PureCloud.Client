using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DataSchemaAppliesToEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Contact for "CONTACT"
    /// </summary>
    [EnumMember(Value = "CONTACT")]
    Contact,

    /// <summary>
    /// Enum Conversation for "CONVERSATION"
    /// </summary>
    [EnumMember(Value = "CONVERSATION")]
    Conversation,

    /// <summary>
    /// Enum ExternalOrganization for "EXTERNAL_ORGANIZATION"
    /// </summary>
    [EnumMember(Value = "EXTERNAL_ORGANIZATION")]
    ExternalOrganization,

    /// <summary>
    /// Enum OpenAction for "OPEN_ACTION"
    /// </summary>
    [EnumMember(Value = "OPEN_ACTION")]
    OpenAction,

    /// <summary>
    /// Enum Workitem for "WORKITEM"
    /// </summary>
    [EnumMember(Value = "WORKITEM")]
    Workitem,

    /// <summary>
    /// Enum DecisionTable for "DECISION_TABLE"
    /// </summary>
    [EnumMember(Value = "DECISION_TABLE")]
    DecisionTable
}
