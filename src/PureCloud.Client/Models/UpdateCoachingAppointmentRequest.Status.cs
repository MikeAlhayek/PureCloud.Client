using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum UpdateCoachingAppointmentRequestStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Scheduled for "Scheduled"
    /// </summary>
    [EnumMember(Value = "Scheduled")]
    Scheduled,

    /// <summary>
    /// Enum Inprogress for "InProgress"
    /// </summary>
    [EnumMember(Value = "InProgress")]
    Inprogress,

    /// <summary>
    /// Enum Completed for "Completed"
    /// </summary>
    [EnumMember(Value = "Completed")]
    Completed
}
