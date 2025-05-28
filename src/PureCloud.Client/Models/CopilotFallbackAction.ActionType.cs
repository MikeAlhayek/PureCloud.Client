using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CopilotFallbackActionActionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Knowledgearticle for "KnowledgeArticle"
    /// </summary>
    [EnumMember(Value = "KnowledgeArticle")]
    Knowledgearticle,

    /// <summary>
    /// Enum Cannedresponse for "CannedResponse"
    /// </summary>
    [EnumMember(Value = "CannedResponse")]
    Cannedresponse,

    /// <summary>
    /// Enum Script for "Script"
    /// </summary>
    [EnumMember(Value = "Script")]
    Script,

    /// <summary>
    /// Enum Knowledgesearch for "KnowledgeSearch"
    /// </summary>
    [EnumMember(Value = "KnowledgeSearch")]
    Knowledgesearch
}
