using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BillingUsage
/// </summary>

public partial class BillingUsage : IEquatable<BillingUsage>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BillingUsage" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BillingUsage() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BillingUsage" /> class.
    /// </summary>
    /// <param name="Name">Identifies the billable usage. (required).</param>
    /// <param name="TotalUsage">The total amount of usage, expressed as a decimal number in string format. (required).</param>
    /// <param name="Resources">The resources for which usage was observed (e.g. license users, devices). (required).</param>
    public BillingUsage(string Name = null, string TotalUsage = null, List<BillingUsageResource> Resources = null)
    {
        this.Name = Name;
        this.TotalUsage = TotalUsage;
        this.Resources = Resources;

    }



    /// <summary>
    /// Identifies the billable usage.
    /// </summary>
    /// <value>Identifies the billable usage.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The total amount of usage, expressed as a decimal number in string format.
    /// </summary>
    /// <value>The total amount of usage, expressed as a decimal number in string format.</value>
    [JsonPropertyName("totalUsage")]
    public string TotalUsage { get; set; }



    /// <summary>
    /// The resources for which usage was observed (e.g. license users, devices).
    /// </summary>
    /// <value>The resources for which usage was observed (e.g. license users, devices).</value>
    [JsonPropertyName("resources")]
    public List<BillingUsageResource> Resources { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BillingUsage {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  TotalUsage: ").Append(TotalUsage).Append("\n");
        sb.Append("  Resources: ").Append(Resources).Append("\n");
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
        return Equals(obj as BillingUsage);
    }

    /// <summary>
    /// Returns true if BillingUsage instances are equal
    /// </summary>
    /// <param name="other">Instance of BillingUsage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BillingUsage other)
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
                TotalUsage == other.TotalUsage ||
                TotalUsage != null &&
                TotalUsage.Equals(other.TotalUsage)
            ) &&
            (
                Resources == other.Resources ||
                Resources != null &&
                Resources.SequenceEqual(other.Resources)
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

            if (TotalUsage != null)
            {
                hash = hash * 59 + TotalUsage.GetHashCode();
            }

            if (Resources != null)
            {
                hash = hash * 59 + Resources.GetHashCode();
            }

            return hash;
        }
    }
}
