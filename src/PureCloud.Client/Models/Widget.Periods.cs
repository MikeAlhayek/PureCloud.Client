using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Periods
/// </summary>

public enum WidgetPeriodsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum None for "NONE"
    /// </summary>
    [EnumMember(Value = "NONE")]
    None,

    /// <summary>
    /// Enum CurrentHalfHour for "CURRENT_HALF_HOUR"
    /// </summary>
    [EnumMember(Value = "CURRENT_HALF_HOUR")]
    CurrentHalfHour,

    /// <summary>
    /// Enum Today for "TODAY"
    /// </summary>
    [EnumMember(Value = "TODAY")]
    Today,

    /// <summary>
    /// Enum Yesterday for "YESTERDAY"
    /// </summary>
    [EnumMember(Value = "YESTERDAY")]
    Yesterday,

    /// <summary>
    /// Enum ThisWeek for "THIS_WEEK"
    /// </summary>
    [EnumMember(Value = "THIS_WEEK")]
    ThisWeek,

    /// <summary>
    /// Enum LastWeek for "LAST_WEEK"
    /// </summary>
    [EnumMember(Value = "LAST_WEEK")]
    LastWeek,

    /// <summary>
    /// Enum ThisMonth for "THIS_MONTH"
    /// </summary>
    [EnumMember(Value = "THIS_MONTH")]
    ThisMonth,

    /// <summary>
    /// Enum LastMonth for "LAST_MONTH"
    /// </summary>
    [EnumMember(Value = "LAST_MONTH")]
    LastMonth,

    /// <summary>
    /// Enum Prior7Days for "PRIOR_7_DAYS"
    /// </summary>
    [EnumMember(Value = "PRIOR_7_DAYS")]
    Prior7Days,

    /// <summary>
    /// Enum Past7DaysToDate for "PAST_7_DAYS_TO_DATE"
    /// </summary>
    [EnumMember(Value = "PAST_7_DAYS_TO_DATE")]
    Past7DaysToDate,

    /// <summary>
    /// Enum Prior30Days for "PRIOR_30_DAYS"
    /// </summary>
    [EnumMember(Value = "PRIOR_30_DAYS")]
    Prior30Days,

    /// <summary>
    /// Enum Past30DaysToDate for "PAST_30_DAYS_TO_DATE"
    /// </summary>
    [EnumMember(Value = "PAST_30_DAYS_TO_DATE")]
    Past30DaysToDate,

    /// <summary>
    /// Enum Prior3Months for "PRIOR_3_MONTHS"
    /// </summary>
    [EnumMember(Value = "PRIOR_3_MONTHS")]
    Prior3Months
}
