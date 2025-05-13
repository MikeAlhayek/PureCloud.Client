using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerContactlistfilterConfigChangeContactListFilterFilterTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum And for "AND"
    /// </summary>
    [EnumMember(Value = "AND")]
    And,

    /// <summary>
    /// Enum Or for "OR"
    /// </summary>
    [EnumMember(Value = "OR")]
    Or
}
