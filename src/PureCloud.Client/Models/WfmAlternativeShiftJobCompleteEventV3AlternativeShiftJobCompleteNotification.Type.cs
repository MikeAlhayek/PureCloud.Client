using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotificationTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Listoffers for "ListOffers"
    /// </summary>
    [EnumMember(Value = "ListOffers")]
    Listoffers,

    /// <summary>
    /// Enum Searchoffers for "SearchOffers"
    /// </summary>
    [EnumMember(Value = "SearchOffers")]
    Searchoffers,

    /// <summary>
    /// Enum Listusertrades for "ListUserTrades"
    /// </summary>
    [EnumMember(Value = "ListUserTrades")]
    Listusertrades,

    /// <summary>
    /// Enum Searchtrades for "SearchTrades"
    /// </summary>
    [EnumMember(Value = "SearchTrades")]
    Searchtrades,

    /// <summary>
    /// Enum Bulkupdatetrades for "BulkUpdateTrades"
    /// </summary>
    [EnumMember(Value = "BulkUpdateTrades")]
    Bulkupdatetrades
}
