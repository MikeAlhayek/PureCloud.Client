using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrusteeBillingOverview
{
    /// <summary>
    /// The subscription type.
    /// </summary>
    /// <value>The subscription type.</value>
    public TrusteeBillingOverviewSubscriptionTypeEnum? SubscriptionType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Organization
    /// </summary>
    /// <value>Organization</value>
    public NamedEntity Organization { get; set; }

    /// <summary>
    /// The currency type.
    /// </summary>
    /// <value>The currency type.</value>
    public string Currency { get; set; }

    /// <summary>
    /// The charge short names for products enabled during the specified period.
    /// </summary>
    /// <value>The charge short names for products enabled during the specified period.</value>
    public IEnumerable<string> EnabledProducts { get; set; }

    /// <summary>
    /// Date-time the ramp period starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the ramp period starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? RampPeriodStartDate { get; set; }

    /// <summary>
    /// Date-time the ramp period ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the ramp period ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? RampPeriodEndDate { get; set; }

    /// <summary>
    /// Date-time the billing period started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the billing period started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? BillingPeriodStartDate { get; set; }

    /// <summary>
    /// Date-time the billing period ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the billing period ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? BillingPeriodEndDate { get; set; }

    /// <summary>
    /// Usages for the specified period.
    /// </summary>
    /// <value>Usages for the specified period.</value>
    public IEnumerable<SubscriptionOverviewUsage> Usages { get; set; }

    /// <summary>
    /// Date-time the contract was last amended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the contract was last amended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ContractAmendmentDate { get; set; }

    /// <summary>
    /// Date-time the contract became effective. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the contract became effective. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? ContractEffectiveDate { get; set; }

    /// <summary>
    /// Date-time the contract ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? ContractEndDate { get; set; }

    /// <summary>
    /// Minimum amount that will be charged for the month
    /// </summary>
    /// <value>Minimum amount that will be charged for the month</value>
    public string MinimumMonthlyAmount { get; set; }

    /// <summary>
    /// Gets or Sets InRampPeriod
    /// </summary>
    public bool? InRampPeriod { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
