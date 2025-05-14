using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerCampaignScheduleConfigChangeRecurrenceRangeTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Noend for "NoEnd"
    /// </summary>
    [EnumMember(Value = "NoEnd")]
    Noend,

    /// <summary>
    /// Enum Numbered for "Numbered"
    /// </summary>
    [EnumMember(Value = "Numbered")]
    Numbered,

    /// <summary>
    /// Enum Enddate for "EndDate"
    /// </summary>
    [EnumMember(Value = "EndDate")]
    Enddate
}
