using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets RecommendationSources
/// </summary>

public enum ViewFilterRecommendationSourcesEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Knowledgesearch for "KnowledgeSearch"
    /// </summary>
    [EnumMember(Value = "KnowledgeSearch")]
    Knowledgesearch,

    /// <summary>
    /// Enum Rulesengine for "RulesEngine"
    /// </summary>
    [EnumMember(Value = "RulesEngine")]
    Rulesengine,

    /// <summary>
    /// Enum Manualsearch for "ManualSearch"
    /// </summary>
    [EnumMember(Value = "ManualSearch")]
    Manualsearch
}
