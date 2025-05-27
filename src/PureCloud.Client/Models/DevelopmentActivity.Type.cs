using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of activity
/// </summary>
/// <value>The type of activity</value>

public enum DevelopmentActivityTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Informational for "Informational"
    /// </summary>
    [EnumMember(Value = "Informational")]
    Informational,

    /// <summary>
    /// Enum Coaching for "Coaching"
    /// </summary>
    [EnumMember(Value = "Coaching")]
    Coaching,

    /// <summary>
    /// Enum Assessedcontent for "AssessedContent"
    /// </summary>
    [EnumMember(Value = "AssessedContent")]
    Assessedcontent,

    /// <summary>
    /// Enum Assessment for "Assessment"
    /// </summary>
    [EnumMember(Value = "Assessment")]
    Assessment,

    /// <summary>
    /// Enum External for "External"
    /// </summary>
    [EnumMember(Value = "External")]
    External,

    /// <summary>
    /// Enum Native for "Native"
    /// </summary>
    [EnumMember(Value = "Native")]
    Native
}
