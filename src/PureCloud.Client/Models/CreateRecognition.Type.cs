using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CreateRecognitionTypeEnum
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
    Companyvalues
}
