using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets SurveyResponseStatuses
/// </summary>

public enum ViewFilterSurveyResponseStatusesEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Fullresponse for "FullResponse"
    /// </summary>
    [EnumMember(Value = "FullResponse")]
    Fullresponse,

    /// <summary>
    /// Enum Partialresponse for "PartialResponse"
    /// </summary>
    [EnumMember(Value = "PartialResponse")]
    Partialresponse
}
