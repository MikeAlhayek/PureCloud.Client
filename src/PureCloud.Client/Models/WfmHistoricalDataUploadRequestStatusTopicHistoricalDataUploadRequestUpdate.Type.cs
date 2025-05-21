using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Type
/// </summary>

public enum WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdateTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Csv for "Csv"
    /// </summary>
    [EnumMember(Value = "Csv")]
    Csv,

    /// <summary>
    /// Enum Json for "Json"
    /// </summary>
    [EnumMember(Value = "Json")]
    Json
}
