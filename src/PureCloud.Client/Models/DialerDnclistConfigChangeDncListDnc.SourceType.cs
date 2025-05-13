using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerDnclistConfigChangeDncListDncSourceTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Rds for "rds"
    /// </summary>
    [EnumMember(Value = "rds")]
    Rds,

    /// <summary>
    /// Enum Dnccom for "dnc.com"
    /// </summary>
    [EnumMember(Value = "dnc.com")]
    Dnccom,

    /// <summary>
    /// Enum Gryphon for "gryphon"
    /// </summary>
    [EnumMember(Value = "gryphon")]
    Gryphon
}
