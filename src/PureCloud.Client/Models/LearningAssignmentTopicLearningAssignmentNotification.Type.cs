using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Type
/// </summary>

public enum LearningAssignmentTopicLearningAssignmentNotificationTypeEnum
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
    /// Enum Native for "Native"
    /// </summary>
    [EnumMember(Value = "Native")]
    Native,

    /// <summary>
    /// Enum External for "External"
    /// </summary>
    [EnumMember(Value = "External")]
    External
}
