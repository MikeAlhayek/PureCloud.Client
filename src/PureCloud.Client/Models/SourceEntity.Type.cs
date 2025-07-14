using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum SourceEntityTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Thankyou for "ThankYou"
    /// </summary>
    [EnumMember(Value = "ThankYou")]
    Thankyou,

    /// <summary>
    /// Enum Congratulations for "Congratulations"
    /// </summary>
    [EnumMember(Value = "Congratulations")]
    Congratulations,

    /// <summary>
    /// Enum Highperformance for "HighPerformance"
    /// </summary>
    [EnumMember(Value = "HighPerformance")]
    Highperformance,

    /// <summary>
    /// Enum Companyvalues for "CompanyValues"
    /// </summary>
    [EnumMember(Value = "CompanyValues")]
    Companyvalues,

    /// <summary>
    /// Enum Competition for "Competition"
    /// </summary>
    [EnumMember(Value = "Competition")]
    Competition,

    /// <summary>
    /// Enum Race for "Race"
    /// </summary>
    [EnumMember(Value = "Race")]
    Race,

    /// <summary>
    /// Enum Raffle for "Raffle"
    /// </summary>
    [EnumMember(Value = "Raffle")]
    Raffle,

    /// <summary>
    /// Enum Teamgoal for "TeamGoal"
    /// </summary>
    [EnumMember(Value = "TeamGoal")]
    Teamgoal
}
