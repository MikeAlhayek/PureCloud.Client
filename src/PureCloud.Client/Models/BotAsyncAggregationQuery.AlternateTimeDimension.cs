using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
/// </summary>
/// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>

public enum BotAsyncAggregationQueryAlternateTimeDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Eventtime for "eventTime"
    /// </summary>
    [EnumMember(Value = "eventTime")]
    Eventtime
}
