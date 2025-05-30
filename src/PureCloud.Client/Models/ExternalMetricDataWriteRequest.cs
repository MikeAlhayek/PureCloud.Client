using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalMetricDataWriteRequest
/// </summary>

public partial class ExternalMetricDataWriteRequest : IEquatable<ExternalMetricDataWriteRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalMetricDataWriteRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExternalMetricDataWriteRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalMetricDataWriteRequest" /> class.
    /// </summary>
    /// <param name="Items">A list of external metric data items. A maximum of 100 items are allowed. (required).</param>
    public ExternalMetricDataWriteRequest(List<ExternalMetricDataItem> Items = null)
    {
        this.Items = Items;

    }



    /// <summary>
    /// A list of external metric data items. A maximum of 100 items are allowed.
    /// </summary>
    /// <value>A list of external metric data items. A maximum of 100 items are allowed.</value>
    [JsonPropertyName("items")]
    public List<ExternalMetricDataItem> Items { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalMetricDataWriteRequest {\n");

        sb.Append("  Items: ").Append(Items).Append("\n");
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
        return Equals(obj as ExternalMetricDataWriteRequest);
    }

    /// <summary>
    /// Returns true if ExternalMetricDataWriteRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalMetricDataWriteRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalMetricDataWriteRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Items == other.Items ||
                Items != null &&
                Items.SequenceEqual(other.Items)
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
            if (Items != null)
            {
                hash = hash * 59 + Items.GetHashCode();
            }

            return hash;
        }
    }
}
