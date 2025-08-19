using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Message receipt status, only used with type Receipt.
/// </summary>
public enum WebMessagingMessageStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Sent for "Sent"
    /// </summary>
    [EnumMember(Value = "Sent")]
    Sent,

    /// <summary>
    /// Enum Delivered for "Delivered"
    /// </summary>
    [EnumMember(Value = "Delivered")]
    Delivered,

    /// <summary>
    /// Enum Read for "Read"
    /// </summary>
    [EnumMember(Value = "Read")]
    Read,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed,

    /// <summary>
    /// Enum Published for "Published"
    /// </summary>
    [EnumMember(Value = "Published")]
    Published,

    /// <summary>
    /// Enum Removed for "Removed"
    /// </summary>
    [EnumMember(Value = "Removed")]
    Removed
}