using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Search Type
/// </summary>
/// <value>Search Type</value>

public enum DocumentationSearchCriteriaTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Exact for "EXACT"
    /// </summary>
    [EnumMember(Value = "EXACT")]
    Exact,

    /// <summary>
    /// Enum StartsWith for "STARTS_WITH"
    /// </summary>
    [EnumMember(Value = "STARTS_WITH")]
    StartsWith,

    /// <summary>
    /// Enum Contains for "CONTAINS"
    /// </summary>
    [EnumMember(Value = "CONTAINS")]
    Contains,

    /// <summary>
    /// Enum Term for "TERM"
    /// </summary>
    [EnumMember(Value = "TERM")]
    Term,

    /// <summary>
    /// Enum Terms for "TERMS"
    /// </summary>
    [EnumMember(Value = "TERMS")]
    Terms,

    /// <summary>
    /// Enum MatchAll for "MATCH_ALL"
    /// </summary>
    [EnumMember(Value = "MATCH_ALL")]
    MatchAll,

    /// <summary>
    /// Enum Simple for "SIMPLE"
    /// </summary>
    [EnumMember(Value = "SIMPLE")]
    Simple,

    /// <summary>
    /// Enum QueryString for "QUERY_STRING"
    /// </summary>
    [EnumMember(Value = "QUERY_STRING")]
    QueryString,

    /// <summary>
    /// Enum MultiMatch for "MULTI_MATCH"
    /// </summary>
    [EnumMember(Value = "MULTI_MATCH")]
    MultiMatch
}
