using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrusteeBillingOverview
/// </summary>
[DataContract]
public partial class TrusteeBillingOverview : IEquatable<TrusteeBillingOverview>
{
    /// <summary>
    /// The subscription type.
    /// </summary>
    /// <value>The subscription type.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubscriptionTypeEnum
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
    /// <summary>
    /// The subscription type.
    /// </summary>
    /// <value>The subscription type.</value>
    [DataMember(Name = "subscriptionType", EmitDefaultValue = false)]
    public SubscriptionTypeEnum? SubscriptionType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TrusteeBillingOverview" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TrusteeBillingOverview() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TrusteeBillingOverview" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Organization">Organization (required).</param>
    /// <param name="Currency">The currency type. (required).</param>
    /// <param name="EnabledProducts">The charge short names for products enabled during the specified period. (required).</param>
    /// <param name="SubscriptionType">The subscription type. (required).</param>
    /// <param name="RampPeriodStartDate">Date-time the ramp period starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="RampPeriodEndDate">Date-time the ramp period ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="BillingPeriodStartDate">Date-time the billing period started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="BillingPeriodEndDate">Date-time the billing period ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Usages">Usages for the specified period. (required).</param>
    /// <param name="ContractAmendmentDate">Date-time the contract was last amended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ContractEffectiveDate">Date-time the contract became effective. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ContractEndDate">Date-time the contract ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="MinimumMonthlyAmount">Minimum amount that will be charged for the month.</param>
    /// <param name="InRampPeriod">InRampPeriod.</param>
    public TrusteeBillingOverview(string Name = null, NamedEntity Organization = null, string Currency = null, List<string> EnabledProducts = null, SubscriptionTypeEnum? SubscriptionType = null, DateTime? RampPeriodStartDate = null, DateTime? RampPeriodEndDate = null, DateTime? BillingPeriodStartDate = null, DateTime? BillingPeriodEndDate = null, List<SubscriptionOverviewUsage> Usages = null, DateTime? ContractAmendmentDate = null, DateTime? ContractEffectiveDate = null, DateTime? ContractEndDate = null, string MinimumMonthlyAmount = null, bool? InRampPeriod = null)
    {
        this.Name = Name;
        this.Organization = Organization;
        this.Currency = Currency;
        this.EnabledProducts = EnabledProducts;
        this.SubscriptionType = SubscriptionType;
        this.RampPeriodStartDate = RampPeriodStartDate;
        this.RampPeriodEndDate = RampPeriodEndDate;
        this.BillingPeriodStartDate = BillingPeriodStartDate;
        this.BillingPeriodEndDate = BillingPeriodEndDate;
        this.Usages = Usages;
        this.ContractAmendmentDate = ContractAmendmentDate;
        this.ContractEffectiveDate = ContractEffectiveDate;
        this.ContractEndDate = ContractEndDate;
        this.MinimumMonthlyAmount = MinimumMonthlyAmount;
        this.InRampPeriod = InRampPeriod;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Organization
    /// </summary>
    /// <value>Organization</value>
    [DataMember(Name = "organization", EmitDefaultValue = false)]
    public NamedEntity Organization { get; set; }



    /// <summary>
    /// The currency type.
    /// </summary>
    /// <value>The currency type.</value>
    [DataMember(Name = "currency", EmitDefaultValue = false)]
    public string Currency { get; set; }



    /// <summary>
    /// The charge short names for products enabled during the specified period.
    /// </summary>
    /// <value>The charge short names for products enabled during the specified period.</value>
    [DataMember(Name = "enabledProducts", EmitDefaultValue = false)]
    public List<string> EnabledProducts { get; set; }





    /// <summary>
    /// Date-time the ramp period starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the ramp period starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "rampPeriodStartDate", EmitDefaultValue = false)]
    public DateTime? RampPeriodStartDate { get; set; }



    /// <summary>
    /// Date-time the ramp period ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the ramp period ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "rampPeriodEndDate", EmitDefaultValue = false)]
    public DateTime? RampPeriodEndDate { get; set; }



    /// <summary>
    /// Date-time the billing period started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the billing period started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "billingPeriodStartDate", EmitDefaultValue = false)]
    public DateTime? BillingPeriodStartDate { get; set; }



    /// <summary>
    /// Date-time the billing period ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the billing period ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "billingPeriodEndDate", EmitDefaultValue = false)]
    public DateTime? BillingPeriodEndDate { get; set; }



    /// <summary>
    /// Usages for the specified period.
    /// </summary>
    /// <value>Usages for the specified period.</value>
    [DataMember(Name = "usages", EmitDefaultValue = false)]
    public List<SubscriptionOverviewUsage> Usages { get; set; }



    /// <summary>
    /// Date-time the contract was last amended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the contract was last amended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "contractAmendmentDate", EmitDefaultValue = false)]
    public DateTime? ContractAmendmentDate { get; set; }



    /// <summary>
    /// Date-time the contract became effective. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the contract became effective. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "contractEffectiveDate", EmitDefaultValue = false)]
    public DateTime? ContractEffectiveDate { get; set; }



    /// <summary>
    /// Date-time the contract ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date-time the contract ends. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "contractEndDate", EmitDefaultValue = false)]
    public DateTime? ContractEndDate { get; set; }



    /// <summary>
    /// Minimum amount that will be charged for the month
    /// </summary>
    /// <value>Minimum amount that will be charged for the month</value>
    [DataMember(Name = "minimumMonthlyAmount", EmitDefaultValue = false)]
    public string MinimumMonthlyAmount { get; set; }



    /// <summary>
    /// Gets or Sets InRampPeriod
    /// </summary>
    [DataMember(Name = "inRampPeriod", EmitDefaultValue = false)]
    public bool? InRampPeriod { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrusteeBillingOverview {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Organization: ").Append(Organization).Append("\n");
        sb.Append("  Currency: ").Append(Currency).Append("\n");
        sb.Append("  EnabledProducts: ").Append(EnabledProducts).Append("\n");
        sb.Append("  SubscriptionType: ").Append(SubscriptionType).Append("\n");
        sb.Append("  RampPeriodStartDate: ").Append(RampPeriodStartDate).Append("\n");
        sb.Append("  RampPeriodEndDate: ").Append(RampPeriodEndDate).Append("\n");
        sb.Append("  BillingPeriodStartDate: ").Append(BillingPeriodStartDate).Append("\n");
        sb.Append("  BillingPeriodEndDate: ").Append(BillingPeriodEndDate).Append("\n");
        sb.Append("  Usages: ").Append(Usages).Append("\n");
        sb.Append("  ContractAmendmentDate: ").Append(ContractAmendmentDate).Append("\n");
        sb.Append("  ContractEffectiveDate: ").Append(ContractEffectiveDate).Append("\n");
        sb.Append("  ContractEndDate: ").Append(ContractEndDate).Append("\n");
        sb.Append("  MinimumMonthlyAmount: ").Append(MinimumMonthlyAmount).Append("\n");
        sb.Append("  InRampPeriod: ").Append(InRampPeriod).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as TrusteeBillingOverview);
    }

    /// <summary>
    /// Returns true if TrusteeBillingOverview instances are equal
    /// </summary>
    /// <param name="other">Instance of TrusteeBillingOverview to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrusteeBillingOverview other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Organization == other.Organization ||
                Organization != null &&
                Organization.Equals(other.Organization)
            ) &&
            (
                Currency == other.Currency ||
                Currency != null &&
                Currency.Equals(other.Currency)
            ) &&
            (
                EnabledProducts == other.EnabledProducts ||
                EnabledProducts != null &&
                EnabledProducts.SequenceEqual(other.EnabledProducts)
            ) &&
            (
                SubscriptionType == other.SubscriptionType ||
                SubscriptionType != null &&
                SubscriptionType.Equals(other.SubscriptionType)
            ) &&
            (
                RampPeriodStartDate == other.RampPeriodStartDate ||
                RampPeriodStartDate != null &&
                RampPeriodStartDate.Equals(other.RampPeriodStartDate)
            ) &&
            (
                RampPeriodEndDate == other.RampPeriodEndDate ||
                RampPeriodEndDate != null &&
                RampPeriodEndDate.Equals(other.RampPeriodEndDate)
            ) &&
            (
                BillingPeriodStartDate == other.BillingPeriodStartDate ||
                BillingPeriodStartDate != null &&
                BillingPeriodStartDate.Equals(other.BillingPeriodStartDate)
            ) &&
            (
                BillingPeriodEndDate == other.BillingPeriodEndDate ||
                BillingPeriodEndDate != null &&
                BillingPeriodEndDate.Equals(other.BillingPeriodEndDate)
            ) &&
            (
                Usages == other.Usages ||
                Usages != null &&
                Usages.SequenceEqual(other.Usages)
            ) &&
            (
                ContractAmendmentDate == other.ContractAmendmentDate ||
                ContractAmendmentDate != null &&
                ContractAmendmentDate.Equals(other.ContractAmendmentDate)
            ) &&
            (
                ContractEffectiveDate == other.ContractEffectiveDate ||
                ContractEffectiveDate != null &&
                ContractEffectiveDate.Equals(other.ContractEffectiveDate)
            ) &&
            (
                ContractEndDate == other.ContractEndDate ||
                ContractEndDate != null &&
                ContractEndDate.Equals(other.ContractEndDate)
            ) &&
            (
                MinimumMonthlyAmount == other.MinimumMonthlyAmount ||
                MinimumMonthlyAmount != null &&
                MinimumMonthlyAmount.Equals(other.MinimumMonthlyAmount)
            ) &&
            (
                InRampPeriod == other.InRampPeriod ||
                InRampPeriod != null &&
                InRampPeriod.Equals(other.InRampPeriod)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Organization != null)
            {
                hash = hash * 59 + Organization.GetHashCode();
            }

            if (Currency != null)
            {
                hash = hash * 59 + Currency.GetHashCode();
            }

            if (EnabledProducts != null)
            {
                hash = hash * 59 + EnabledProducts.GetHashCode();
            }

            if (SubscriptionType != null)
            {
                hash = hash * 59 + SubscriptionType.GetHashCode();
            }

            if (RampPeriodStartDate != null)
            {
                hash = hash * 59 + RampPeriodStartDate.GetHashCode();
            }

            if (RampPeriodEndDate != null)
            {
                hash = hash * 59 + RampPeriodEndDate.GetHashCode();
            }

            if (BillingPeriodStartDate != null)
            {
                hash = hash * 59 + BillingPeriodStartDate.GetHashCode();
            }

            if (BillingPeriodEndDate != null)
            {
                hash = hash * 59 + BillingPeriodEndDate.GetHashCode();
            }

            if (Usages != null)
            {
                hash = hash * 59 + Usages.GetHashCode();
            }

            if (ContractAmendmentDate != null)
            {
                hash = hash * 59 + ContractAmendmentDate.GetHashCode();
            }

            if (ContractEffectiveDate != null)
            {
                hash = hash * 59 + ContractEffectiveDate.GetHashCode();
            }

            if (ContractEndDate != null)
            {
                hash = hash * 59 + ContractEndDate.GetHashCode();
            }

            if (MinimumMonthlyAmount != null)
            {
                hash = hash * 59 + MinimumMonthlyAmount.GetHashCode();
            }

            if (InRampPeriod != null)
            {
                hash = hash * 59 + InRampPeriod.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
