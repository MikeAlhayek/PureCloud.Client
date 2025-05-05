using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalAdherenceBulkQuery
/// </summary>

public partial class WfmHistoricalAdherenceBulkQuery : IEquatable<WfmHistoricalAdherenceBulkQuery>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmHistoricalAdherenceBulkQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkQuery" /> class.
    /// </summary>
    /// <param name="Items">The historical adherence items to query (required).</param>
    /// <param name="TimeZone">The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input. (required).</param>
    public WfmHistoricalAdherenceBulkQuery(List<WfmHistoricalAdherenceBulkItem> Items = null, string TimeZone = null)
    {
        this.Items = Items;
        this.TimeZone = TimeZone;

    }



    /// <summary>
    /// The historical adherence items to query
    /// </summary>
    /// <value>The historical adherence items to query</value>
    [JsonPropertyName("items")]
    public List<WfmHistoricalAdherenceBulkItem> Items { get; set; }



    /// <summary>
    /// The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.
    /// </summary>
    /// <value>The time zone, in olson format, to use in defining days when computing adherence. The results will be returned as UTC timestamps regardless of the time zone input.</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalAdherenceBulkQuery {\n");

        sb.Append("  Items: ").Append(Items).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
        return Equals(obj as WfmHistoricalAdherenceBulkQuery);
    }

    /// <summary>
    /// Returns true if WfmHistoricalAdherenceBulkQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalAdherenceBulkQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalAdherenceBulkQuery other)
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
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
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

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            return hash;
        }
    }
}
