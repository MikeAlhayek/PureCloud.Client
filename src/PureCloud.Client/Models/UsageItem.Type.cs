using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum UsageItemTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Recording for "RECORDING"
    /// </summary>
    [EnumMember(Value = "RECORDING")]
    Recording,

    /// <summary>
    /// Enum Fax for "FAX"
    /// </summary>
    [EnumMember(Value = "FAX")]
    Fax,

    /// <summary>
    /// Enum Document for "DOCUMENT"
    /// </summary>
    [EnumMember(Value = "DOCUMENT")]
    Document,

    /// <summary>
    /// Enum All for "ALL"
    /// </summary>
    [EnumMember(Value = "ALL")]
    All
}
