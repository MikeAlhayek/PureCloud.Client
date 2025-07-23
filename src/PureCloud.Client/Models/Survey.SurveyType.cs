namespace PureCloud.Client.Models;

/// <summary>
/// Type of the survey
/// </summary>
public enum SurveyType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Web for "Web"
    /// </summary>
    Web,

    /// <summary>
    /// Enum Voice for "Voice"
    /// </summary>
    Voice
}