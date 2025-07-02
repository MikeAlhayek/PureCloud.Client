using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Type
/// </summary>

public enum TranscriptConversationDetailSearchCriteriaTypeEnum
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
    /// Enum ExactPhrase for "EXACT_PHRASE"
    /// </summary>
    [EnumMember(Value = "EXACT_PHRASE")]
    ExactPhrase,

    /// <summary>
    /// Enum Phrase for "PHRASE"
    /// </summary>
    [EnumMember(Value = "PHRASE")]
    Phrase,

    /// <summary>
    /// Enum DateRange for "DATE_RANGE"
    /// </summary>
    [EnumMember(Value = "DATE_RANGE")]
    DateRange
}
