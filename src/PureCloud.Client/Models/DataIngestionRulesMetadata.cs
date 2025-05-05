using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DataIngestionRulesMetadata
/// </summary>

public partial class DataIngestionRulesMetadata : IEquatable<DataIngestionRulesMetadata>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataIngestionRulesMetadata" /> class.
    /// </summary>
    /// <param name="CountByStatus">Count of data ingestion rules by status.</param>
    /// <param name="Platform">The platform for which the data ingestion rules are available.</param>
    /// <param name="TotalCount">The total count of data ingestion rule.</param>
    public DataIngestionRulesMetadata(Dictionary<string, int?> CountByStatus = null, string Platform = null, int? TotalCount = null)
    {
        this.CountByStatus = CountByStatus;
        this.Platform = Platform;
        this.TotalCount = TotalCount;

    }



    /// <summary>
    /// Count of data ingestion rules by status
    /// </summary>
    /// <value>Count of data ingestion rules by status</value>
    [JsonPropertyName("countByStatus")]
    public Dictionary<string, int?> CountByStatus { get; set; }



    /// <summary>
    /// The platform for which the data ingestion rules are available
    /// </summary>
    /// <value>The platform for which the data ingestion rules are available</value>
    [JsonPropertyName("platform")]
    public string Platform { get; set; }



    /// <summary>
    /// The total count of data ingestion rule
    /// </summary>
    /// <value>The total count of data ingestion rule</value>
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DataIngestionRulesMetadata {\n");

        sb.Append("  CountByStatus: ").Append(CountByStatus).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
        return Equals(obj as DataIngestionRulesMetadata);
    }

    /// <summary>
    /// Returns true if DataIngestionRulesMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of DataIngestionRulesMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataIngestionRulesMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CountByStatus == other.CountByStatus ||
                CountByStatus != null &&
                CountByStatus.SequenceEqual(other.CountByStatus)
            ) &&
            (
                Platform == other.Platform ||
                Platform != null &&
                Platform.Equals(other.Platform)
            ) &&
            (
                TotalCount == other.TotalCount ||
                TotalCount != null &&
                TotalCount.Equals(other.TotalCount)
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
            if (CountByStatus != null)
            {
                hash = hash * 59 + CountByStatus.GetHashCode();
            }

            if (Platform != null)
            {
                hash = hash * 59 + Platform.GetHashCode();
            }

            if (TotalCount != null)
            {
                hash = hash * 59 + TotalCount.GetHashCode();
            }

            return hash;
        }
    }
}
