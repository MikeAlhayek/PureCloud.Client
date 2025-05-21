using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdateStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Initiated for "Initiated"
    /// </summary>
    [EnumMember(Value = "Initiated")]
    Initiated,

    /// <summary>
    /// Enum Inprogress for "InProgress"
    /// </summary>
    [EnumMember(Value = "InProgress")]
    Inprogress,

    /// <summary>
    /// Enum Pending for "Pending"
    /// </summary>
    [EnumMember(Value = "Pending")]
    Pending,

    /// <summary>
    /// Enum Success for "Success"
    /// </summary>
    [EnumMember(Value = "Success")]
    Success,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed,

    /// <summary>
    /// Enum Cancelled for "Cancelled"
    /// </summary>
    [EnumMember(Value = "Cancelled")]
    Cancelled,

    /// <summary>
    /// Enum Purged for "Purged"
    /// </summary>
    [EnumMember(Value = "Purged")]
    Purged,

    /// <summary>
    /// Enum Purgepending for "PurgePending"
    /// </summary>
    [EnumMember(Value = "PurgePending")]
    Purgepending
}
