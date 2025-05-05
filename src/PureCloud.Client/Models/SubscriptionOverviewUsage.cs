using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SubscriptionOverviewUsage
/// </summary>

public partial class SubscriptionOverviewUsage : IEquatable<SubscriptionOverviewUsage>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionOverviewUsage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SubscriptionOverviewUsage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SubscriptionOverviewUsage" /> class.
    /// </summary>
    /// <param name="Name">Product charge name (required).</param>
    /// <param name="PartNumber">Product part number (required).</param>
    /// <param name="Grouping">UI grouping key (required).</param>
    /// <param name="UnitOfMeasureType">UI unit of measure (required).</param>
    /// <param name="UsageQuantity">Usage count for specified period (required).</param>
    /// <param name="OveragePrice">Price for usage / overage charge.</param>
    /// <param name="PrepayQuantity">Items prepaid for specified period (required).</param>
    /// <param name="PrepayPrice">Price for prepay charge.</param>
    /// <param name="UsageNotes">Notes about the usage/charge item.</param>
    /// <param name="IsCancellable">Indicates whether the item is cancellable.</param>
    /// <param name="BundleQuantity">Quantity multiplier for this charge.</param>
    /// <param name="IsThirdParty">A charge from a third party entity.</param>
    public SubscriptionOverviewUsage(string Name = null, string PartNumber = null, string Grouping = null, string UnitOfMeasureType = null, string UsageQuantity = null, string OveragePrice = null, string PrepayQuantity = null, string PrepayPrice = null, string UsageNotes = null, bool? IsCancellable = null, string BundleQuantity = null, bool? IsThirdParty = null)
    {
        this.Name = Name;
        this.PartNumber = PartNumber;
        this.Grouping = Grouping;
        this.UnitOfMeasureType = UnitOfMeasureType;
        this.UsageQuantity = UsageQuantity;
        this.OveragePrice = OveragePrice;
        this.PrepayQuantity = PrepayQuantity;
        this.PrepayPrice = PrepayPrice;
        this.UsageNotes = UsageNotes;
        this.IsCancellable = IsCancellable;
        this.BundleQuantity = BundleQuantity;
        this.IsThirdParty = IsThirdParty;

    }



    /// <summary>
    /// Product charge name
    /// </summary>
    /// <value>Product charge name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Product part number
    /// </summary>
    /// <value>Product part number</value>
    [JsonPropertyName("partNumber")]
    public string PartNumber { get; set; }



    /// <summary>
    /// UI grouping key
    /// </summary>
    /// <value>UI grouping key</value>
    [JsonPropertyName("grouping")]
    public string Grouping { get; set; }



    /// <summary>
    /// UI unit of measure
    /// </summary>
    /// <value>UI unit of measure</value>
    [JsonPropertyName("unitOfMeasureType")]
    public string UnitOfMeasureType { get; set; }



    /// <summary>
    /// Usage count for specified period
    /// </summary>
    /// <value>Usage count for specified period</value>
    [JsonPropertyName("usageQuantity")]
    public string UsageQuantity { get; set; }



    /// <summary>
    /// Price for usage / overage charge
    /// </summary>
    /// <value>Price for usage / overage charge</value>
    [JsonPropertyName("overagePrice")]
    public string OveragePrice { get; set; }



    /// <summary>
    /// Items prepaid for specified period
    /// </summary>
    /// <value>Items prepaid for specified period</value>
    [JsonPropertyName("prepayQuantity")]
    public string PrepayQuantity { get; set; }



    /// <summary>
    /// Price for prepay charge
    /// </summary>
    /// <value>Price for prepay charge</value>
    [JsonPropertyName("prepayPrice")]
    public string PrepayPrice { get; set; }



    /// <summary>
    /// Notes about the usage/charge item
    /// </summary>
    /// <value>Notes about the usage/charge item</value>
    [JsonPropertyName("usageNotes")]
    public string UsageNotes { get; set; }



    /// <summary>
    /// Indicates whether the item is cancellable
    /// </summary>
    /// <value>Indicates whether the item is cancellable</value>
    [JsonPropertyName("isCancellable")]
    public bool? IsCancellable { get; set; }



    /// <summary>
    /// Quantity multiplier for this charge
    /// </summary>
    /// <value>Quantity multiplier for this charge</value>
    [JsonPropertyName("bundleQuantity")]
    public string BundleQuantity { get; set; }



    /// <summary>
    /// A charge from a third party entity
    /// </summary>
    /// <value>A charge from a third party entity</value>
    [JsonPropertyName("isThirdParty")]
    public bool? IsThirdParty { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SubscriptionOverviewUsage {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
        sb.Append("  Grouping: ").Append(Grouping).Append("\n");
        sb.Append("  UnitOfMeasureType: ").Append(UnitOfMeasureType).Append("\n");
        sb.Append("  UsageQuantity: ").Append(UsageQuantity).Append("\n");
        sb.Append("  OveragePrice: ").Append(OveragePrice).Append("\n");
        sb.Append("  PrepayQuantity: ").Append(PrepayQuantity).Append("\n");
        sb.Append("  PrepayPrice: ").Append(PrepayPrice).Append("\n");
        sb.Append("  UsageNotes: ").Append(UsageNotes).Append("\n");
        sb.Append("  IsCancellable: ").Append(IsCancellable).Append("\n");
        sb.Append("  BundleQuantity: ").Append(BundleQuantity).Append("\n");
        sb.Append("  IsThirdParty: ").Append(IsThirdParty).Append("\n");
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
        return Equals(obj as SubscriptionOverviewUsage);
    }

    /// <summary>
    /// Returns true if SubscriptionOverviewUsage instances are equal
    /// </summary>
    /// <param name="other">Instance of SubscriptionOverviewUsage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SubscriptionOverviewUsage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                PartNumber == other.PartNumber ||
                PartNumber != null &&
                PartNumber.Equals(other.PartNumber)
            ) &&
            (
                Grouping == other.Grouping ||
                Grouping != null &&
                Grouping.Equals(other.Grouping)
            ) &&
            (
                UnitOfMeasureType == other.UnitOfMeasureType ||
                UnitOfMeasureType != null &&
                UnitOfMeasureType.Equals(other.UnitOfMeasureType)
            ) &&
            (
                UsageQuantity == other.UsageQuantity ||
                UsageQuantity != null &&
                UsageQuantity.Equals(other.UsageQuantity)
            ) &&
            (
                OveragePrice == other.OveragePrice ||
                OveragePrice != null &&
                OveragePrice.Equals(other.OveragePrice)
            ) &&
            (
                PrepayQuantity == other.PrepayQuantity ||
                PrepayQuantity != null &&
                PrepayQuantity.Equals(other.PrepayQuantity)
            ) &&
            (
                PrepayPrice == other.PrepayPrice ||
                PrepayPrice != null &&
                PrepayPrice.Equals(other.PrepayPrice)
            ) &&
            (
                UsageNotes == other.UsageNotes ||
                UsageNotes != null &&
                UsageNotes.Equals(other.UsageNotes)
            ) &&
            (
                IsCancellable == other.IsCancellable ||
                IsCancellable != null &&
                IsCancellable.Equals(other.IsCancellable)
            ) &&
            (
                BundleQuantity == other.BundleQuantity ||
                BundleQuantity != null &&
                BundleQuantity.Equals(other.BundleQuantity)
            ) &&
            (
                IsThirdParty == other.IsThirdParty ||
                IsThirdParty != null &&
                IsThirdParty.Equals(other.IsThirdParty)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (PartNumber != null)
            {
                hash = hash * 59 + PartNumber.GetHashCode();
            }

            if (Grouping != null)
            {
                hash = hash * 59 + Grouping.GetHashCode();
            }

            if (UnitOfMeasureType != null)
            {
                hash = hash * 59 + UnitOfMeasureType.GetHashCode();
            }

            if (UsageQuantity != null)
            {
                hash = hash * 59 + UsageQuantity.GetHashCode();
            }

            if (OveragePrice != null)
            {
                hash = hash * 59 + OveragePrice.GetHashCode();
            }

            if (PrepayQuantity != null)
            {
                hash = hash * 59 + PrepayQuantity.GetHashCode();
            }

            if (PrepayPrice != null)
            {
                hash = hash * 59 + PrepayPrice.GetHashCode();
            }

            if (UsageNotes != null)
            {
                hash = hash * 59 + UsageNotes.GetHashCode();
            }

            if (IsCancellable != null)
            {
                hash = hash * 59 + IsCancellable.GetHashCode();
            }

            if (BundleQuantity != null)
            {
                hash = hash * 59 + BundleQuantity.GetHashCode();
            }

            if (IsThirdParty != null)
            {
                hash = hash * 59 + IsThirdParty.GetHashCode();
            }

            return hash;
        }
    }
}
