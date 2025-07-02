using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TranscriptConversationDetailSearchRequestSortOrderEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Asc for "ASC"
    /// </summary>
    [EnumMember(Value = "ASC")]
    Asc,

    /// <summary>
    /// Enum Desc for "DESC"
    /// </summary>
    [EnumMember(Value = "DESC")]
    Desc,

    /// <summary>
    /// Enum Score for "SCORE"
    /// </summary>
    [EnumMember(Value = "SCORE")]
    Score
}
