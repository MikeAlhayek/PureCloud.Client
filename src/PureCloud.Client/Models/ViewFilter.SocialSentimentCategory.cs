using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets SocialSentimentCategory
/// </summary>

public enum ViewFilterSocialSentimentCategoryEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Positive for "Positive"
    /// </summary>
    [EnumMember(Value = "Positive")]
    Positive,

    /// <summary>
    /// Enum Negative for "Negative"
    /// </summary>
    [EnumMember(Value = "Negative")]
    Negative,

    /// <summary>
    /// Enum Neutral for "Neutral"
    /// </summary>
    [EnumMember(Value = "Neutral")]
    Neutral,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
