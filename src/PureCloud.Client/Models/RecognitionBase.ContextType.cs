using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The context type (optional)
/// </summary>
/// <value>The context type (optional)</value>

public enum RecognitionBaseContextTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Interaction for "Interaction"
    /// </summary>
    [EnumMember(Value = "Interaction")]
    Interaction,

    /// <summary>
    /// Enum Insights for "Insights"
    /// </summary>
    [EnumMember(Value = "Insights")]
    Insights,

    /// <summary>
    /// Enum Development for "Development"
    /// </summary>
    [EnumMember(Value = "Development")]
    Development,

    /// <summary>
    /// Enum Scorecard for "Scorecard"
    /// </summary>
    [EnumMember(Value = "Scorecard")]
    Scorecard
}
