using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmHistoricalDataImportPurgeCompleteTopicHistoricalDataDisallowedDeleteEntityReasonEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Deleteinprogress for "DeleteInProgress"
    /// </summary>
    [EnumMember(Value = "DeleteInProgress")]
    Deleteinprogress,

    /// <summary>
    /// Enum Validationinprogress for "ValidationInProgress"
    /// </summary>
    [EnumMember(Value = "ValidationInProgress")]
    Validationinprogress,

    /// <summary>
    /// Enum Requestidnotfound for "RequestIdNotFound"
    /// </summary>
    [EnumMember(Value = "RequestIdNotFound")]
    Requestidnotfound,

    /// <summary>
    /// Enum Invalidrequest for "InvalidRequest"
    /// </summary>
    [EnumMember(Value = "InvalidRequest")]
    Invalidrequest
}
