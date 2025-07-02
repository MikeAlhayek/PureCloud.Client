using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets EmailDeliveryStatusList
/// </summary>

public enum ViewFilterEmailDeliveryStatusListEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Deliveryfailed for "DeliveryFailed"
    /// </summary>
    [EnumMember(Value = "DeliveryFailed")]
    Deliveryfailed,

    /// <summary>
    /// Enum Deliverypushed for "DeliveryPushed"
    /// </summary>
    [EnumMember(Value = "DeliveryPushed")]
    Deliverypushed,

    /// <summary>
    /// Enum Deliverysuccess for "DeliverySuccess"
    /// </summary>
    [EnumMember(Value = "DeliverySuccess")]
    Deliverysuccess,

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
    /// Enum Queued for "Queued"
    /// </summary>
    [EnumMember(Value = "Queued")]
    Queued,

    /// <summary>
    /// Enum Read for "Read"
    /// </summary>
    [EnumMember(Value = "Read")]
    Read,

    /// <summary>
    /// Enum Received for "Received"
    /// </summary>
    [EnumMember(Value = "Received")]
    Received,

    /// <summary>
    /// Enum Sent for "Sent"
    /// </summary>
    [EnumMember(Value = "Sent")]
    Sent
}
