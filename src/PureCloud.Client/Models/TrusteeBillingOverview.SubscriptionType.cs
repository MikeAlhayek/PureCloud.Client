using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TrusteeBillingOverviewSubscriptionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Inin for "ININ"
    /// </summary>
    [EnumMember(Value = "ININ")]
    Inin,

    /// <summary>
    /// Enum MonthToMonth for "MONTH_TO_MONTH"
    /// </summary>
    [EnumMember(Value = "MONTH_TO_MONTH")]
    MonthToMonth,

    /// <summary>
    /// Enum FreeTrialMonthToMonth for "FREE_TRIAL_MONTH_TO_MONTH"
    /// </summary>
    [EnumMember(Value = "FREE_TRIAL_MONTH_TO_MONTH")]
    FreeTrialMonthToMonth,

    /// <summary>
    /// Enum PrepayMonthlyCommitment for "PREPAY_MONTHLY_COMMITMENT"
    /// </summary>
    [EnumMember(Value = "PREPAY_MONTHLY_COMMITMENT")]
    PrepayMonthlyCommitment,

    /// <summary>
    /// Enum Prepay for "PREPAY"
    /// </summary>
    [EnumMember(Value = "PREPAY")]
    Prepay,

    /// <summary>
    /// Enum DevOrgMonthToMonth for "DEV_ORG_MONTH_TO_MONTH"
    /// </summary>
    [EnumMember(Value = "DEV_ORG_MONTH_TO_MONTH")]
    DevOrgMonthToMonth,

    /// <summary>
    /// Enum DevOrgPrepayMonthlyCommitment for "DEV_ORG_PREPAY_MONTHLY_COMMITMENT"
    /// </summary>
    [EnumMember(Value = "DEV_ORG_PREPAY_MONTHLY_COMMITMENT")]
    DevOrgPrepayMonthlyCommitment,

    /// <summary>
    /// Enum DevOrgPrepay for "DEV_ORG_PREPAY"
    /// </summary>
    [EnumMember(Value = "DEV_ORG_PREPAY")]
    DevOrgPrepay
}
