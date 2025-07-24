using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Metrics
/// </summary>
public enum SocialMediaAsyncAggregationQueryMetrics
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nsocialposts for "nSocialPosts"
    /// </summary>
    [EnumMember(Value = "nSocialPosts")]
    Nsocialposts,

    /// <summary>
    /// Enum Osocialauthors for "oSocialAuthors"
    /// </summary>
    [EnumMember(Value = "oSocialAuthors")]
    Osocialauthors,

    /// <summary>
    /// Enum Osocialsentiment for "oSocialSentiment"
    /// </summary>
    [EnumMember(Value = "oSocialSentiment")]
    Osocialsentiment,

    /// <summary>
    /// Enum Osocialengagement for "oSocialEngagement"
    /// </summary>
    [EnumMember(Value = "oSocialEngagement")]
    Osocialengagement
}