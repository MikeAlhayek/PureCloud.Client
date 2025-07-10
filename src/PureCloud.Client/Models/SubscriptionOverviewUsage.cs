using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SubscriptionOverviewUsage
{
    /// <summary>
    /// Product charge name
    /// </summary>
    /// <value>Product charge name</value>
    public string Name { get; set; }

    /// <summary>
    /// Product part number
    /// </summary>
    /// <value>Product part number</value>
    public string PartNumber { get; set; }

    /// <summary>
    /// UI grouping key
    /// </summary>
    /// <value>UI grouping key</value>
    public string Grouping { get; set; }

    /// <summary>
    /// UI unit of measure
    /// </summary>
    /// <value>UI unit of measure</value>
    public string UnitOfMeasureType { get; set; }

    /// <summary>
    /// Usage count for specified period
    /// </summary>
    /// <value>Usage count for specified period</value>
    public string UsageQuantity { get; set; }

    /// <summary>
    /// Price for usage / overage charge
    /// </summary>
    /// <value>Price for usage / overage charge</value>
    public string OveragePrice { get; set; }

    /// <summary>
    /// Items prepaid for specified period
    /// </summary>
    /// <value>Items prepaid for specified period</value>
    public string PrepayQuantity { get; set; }

    /// <summary>
    /// Price for prepay charge
    /// </summary>
    /// <value>Price for prepay charge</value>
    public string PrepayPrice { get; set; }

    /// <summary>
    /// Notes about the usage/charge item
    /// </summary>
    /// <value>Notes about the usage/charge item</value>
    public string UsageNotes { get; set; }

    /// <summary>
    /// Indicates whether the item is cancellable
    /// </summary>
    /// <value>Indicates whether the item is cancellable</value>
    public bool? IsCancellable { get; set; }

    /// <summary>
    /// Quantity multiplier for this charge
    /// </summary>
    /// <value>Quantity multiplier for this charge</value>
    public string BundleQuantity { get; set; }

    /// <summary>
    /// A charge from a third party entity
    /// </summary>
    /// <value>A charge from a third party entity</value>
    public bool? IsThirdParty { get; set; }
}
