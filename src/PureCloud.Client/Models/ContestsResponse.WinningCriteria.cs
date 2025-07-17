using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContestsResponseWinningCriteriaEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Highestoverallscore for "HighestOverallScore"
    /// </summary>
    [EnumMember(Value = "HighestOverallScore")]
    Highestoverallscore,

    /// <summary>
    /// Enum Highestoverallpercentofgoal for "HighestOverallPercentOfGoal"
    /// </summary>
    [EnumMember(Value = "HighestOverallPercentOfGoal")]
    Highestoverallpercentofgoal
}
