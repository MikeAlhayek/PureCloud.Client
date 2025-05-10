using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Analytics;

/// <summary>
/// The type of the survey
/// </summary>
/// <value>The type of the survey</value>

public enum AnalyticsSurveySurveyType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Web for "Web"
    /// </summary>
    [EnumMember(Value = "Web")]
    Web,

    /// <summary>
    /// Enum Voice for "Voice"
    /// </summary>
    [EnumMember(Value = "Voice")]
    Voice
}
