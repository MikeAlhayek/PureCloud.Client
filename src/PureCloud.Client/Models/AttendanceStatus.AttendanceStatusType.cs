using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AttendanceStatusAttendanceStatusTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Hasdata for "HasData"
    /// </summary>
    [EnumMember(Value = "HasData")]
    Hasdata,

    /// <summary>
    /// Enum Scheduled for "Scheduled"
    /// </summary>
    [EnumMember(Value = "Scheduled")]
    Scheduled,

    /// <summary>
    /// Enum Absent for "Absent"
    /// </summary>
    [EnumMember(Value = "Absent")]
    Absent,

    /// <summary>
    /// Enum Present for "Present"
    /// </summary>
    [EnumMember(Value = "Present")]
    Present,

    /// <summary>
    /// Enum Noschedule for "NoSchedule"
    /// </summary>
    [EnumMember(Value = "NoSchedule")]
    Noschedule
}
