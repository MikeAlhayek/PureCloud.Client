using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Search Type
/// </summary>
/// <value>Search Type</value>

public enum GroupSearchCriteriaTypeEnum
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
    /// Enum Regex for "REGEX"
    /// </summary>
    [EnumMember(Value = "REGEX")]
    Regex,

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
    /// Enum RequiredFields for "REQUIRED_FIELDS"
    /// </summary>
    [EnumMember(Value = "REQUIRED_FIELDS")]
    RequiredFields,

    /// <summary>
    /// Enum MatchAll for "MATCH_ALL"
    /// </summary>
    [EnumMember(Value = "MATCH_ALL")]
    MatchAll
}
