using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WebChatMemberInfoRoleEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Agent for "AGENT"
    /// </summary>
    [EnumMember(Value = "AGENT")]
    Agent,

    /// <summary>
    /// Enum Customer for "CUSTOMER"
    /// </summary>
    [EnumMember(Value = "CUSTOMER")]
    Customer,

    /// <summary>
    /// Enum Workflow for "WORKFLOW"
    /// </summary>
    [EnumMember(Value = "WORKFLOW")]
    Workflow,

    /// <summary>
    /// Enum Acd for "ACD"
    /// </summary>
    [EnumMember(Value = "ACD")]
    Acd
}
