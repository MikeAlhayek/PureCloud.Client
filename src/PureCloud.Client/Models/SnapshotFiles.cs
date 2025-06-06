using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SnapshotFiles
/// </summary>

public partial class SnapshotFiles : IEquatable<SnapshotFiles>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SnapshotFiles" /> class.
    /// </summary>
    /// <param name="MetaData">Metadata for requested snapshot.</param>
    /// <param name="Offered">Offered data for the requested snapshot.</param>
    /// <param name="AverageHandleTime">Average handle time data for the requested snapshot.</param>
    public SnapshotFiles(SnapshotMetaData MetaData = null, SnapshotMetricData Offered = null, SnapshotMetricData AverageHandleTime = null)
    {
        this.MetaData = MetaData;
        this.Offered = Offered;
        this.AverageHandleTime = AverageHandleTime;

    }



    /// <summary>
    /// Metadata for requested snapshot
    /// </summary>
    /// <value>Metadata for requested snapshot</value>
    [JsonPropertyName("metaData")]
    public SnapshotMetaData MetaData { get; set; }



    /// <summary>
    /// Offered data for the requested snapshot
    /// </summary>
    /// <value>Offered data for the requested snapshot</value>
    [JsonPropertyName("offered")]
    public SnapshotMetricData Offered { get; set; }



    /// <summary>
    /// Average handle time data for the requested snapshot
    /// </summary>
    /// <value>Average handle time data for the requested snapshot</value>
    [JsonPropertyName("averageHandleTime")]
    public SnapshotMetricData AverageHandleTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SnapshotFiles {\n");

        sb.Append("  MetaData: ").Append(MetaData).Append("\n");
        sb.Append("  Offered: ").Append(Offered).Append("\n");
        sb.Append("  AverageHandleTime: ").Append(AverageHandleTime).Append("\n");
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
        return Equals(obj as SnapshotFiles);
    }

    /// <summary>
    /// Returns true if SnapshotFiles instances are equal
    /// </summary>
    /// <param name="other">Instance of SnapshotFiles to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SnapshotFiles other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MetaData == other.MetaData ||
                MetaData != null &&
                MetaData.Equals(other.MetaData)
            ) &&
            (
                Offered == other.Offered ||
                Offered != null &&
                Offered.Equals(other.Offered)
            ) &&
            (
                AverageHandleTime == other.AverageHandleTime ||
                AverageHandleTime != null &&
                AverageHandleTime.Equals(other.AverageHandleTime)
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
            if (MetaData != null)
            {
                hash = hash * 59 + MetaData.GetHashCode();
            }

            if (Offered != null)
            {
                hash = hash * 59 + Offered.GetHashCode();
            }

            if (AverageHandleTime != null)
            {
                hash = hash * 59 + AverageHandleTime.GetHashCode();
            }

            return hash;
        }
    }
}
