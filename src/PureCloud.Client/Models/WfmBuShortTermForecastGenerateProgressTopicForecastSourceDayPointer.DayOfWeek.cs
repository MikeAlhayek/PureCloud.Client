using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmBuShortTermForecastGenerateProgressTopicForecastSourceDayPointerDayOfWeekEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Sunday for "Sunday"
    /// </summary>
    [EnumMember(Value = "Sunday")]
    Sunday,

    /// <summary>
    /// Enum Monday for "Monday"
    /// </summary>
    [EnumMember(Value = "Monday")]
    Monday,

    /// <summary>
    /// Enum Tuesday for "Tuesday"
    /// </summary>
    [EnumMember(Value = "Tuesday")]
    Tuesday,

    /// <summary>
    /// Enum Wednesday for "Wednesday"
    /// </summary>
    [EnumMember(Value = "Wednesday")]
    Wednesday,

    /// <summary>
    /// Enum Thursday for "Thursday"
    /// </summary>
    [EnumMember(Value = "Thursday")]
    Thursday,

    /// <summary>
    /// Enum Friday for "Friday"
    /// </summary>
    [EnumMember(Value = "Friday")]
    Friday,

    /// <summary>
    /// Enum Saturday for "Saturday"
    /// </summary>
    [EnumMember(Value = "Saturday")]
    Saturday,

    /// <summary>
    /// Enum Eighthday for "EighthDay"
    /// </summary>
    [EnumMember(Value = "EighthDay")]
    Eighthday
}
