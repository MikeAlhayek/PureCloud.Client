using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SnapshotMetaDataResult
/// </summary>
[DataContract]
public partial class SnapshotMetaDataResult : IEquatable<SnapshotMetaDataResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SnapshotMetaDataResult" /> class.
    /// </summary>
    /// <param name="SnapshotInfo">Information about the snapshot.</param>
    /// <param name="DateForecastStart">Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public SnapshotMetaDataResult(SnapshotInfo SnapshotInfo = null, DateTime? DateForecastStart = null)
    {
        this.SnapshotInfo = SnapshotInfo;
        this.DateForecastStart = DateForecastStart;

    }



    /// <summary>
    /// Information about the snapshot
    /// </summary>
    /// <value>Information about the snapshot</value>
    [DataMember(Name = "snapshotInfo", EmitDefaultValue = false)]
    public SnapshotInfo SnapshotInfo { get; set; }



    /// <summary>
    /// Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of the forecast. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateForecastStart", EmitDefaultValue = false)]
    public DateTime? DateForecastStart { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SnapshotMetaDataResult {\n");

        sb.Append("  SnapshotInfo: ").Append(SnapshotInfo).Append("\n");
        sb.Append("  DateForecastStart: ").Append(DateForecastStart).Append("\n");
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
        return Equals(obj as SnapshotMetaDataResult);
    }

    /// <summary>
    /// Returns true if SnapshotMetaDataResult instances are equal
    /// </summary>
    /// <param name="other">Instance of SnapshotMetaDataResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SnapshotMetaDataResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SnapshotInfo == other.SnapshotInfo ||
                SnapshotInfo != null &&
                SnapshotInfo.Equals(other.SnapshotInfo)
            ) &&
            (
                DateForecastStart == other.DateForecastStart ||
                DateForecastStart != null &&
                DateForecastStart.Equals(other.DateForecastStart)
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
            if (SnapshotInfo != null)
            {
                hash = hash * 59 + SnapshotInfo.GetHashCode();
            }

            if (DateForecastStart != null)
            {
                hash = hash * 59 + DateForecastStart.GetHashCode();
            }

            return hash;
        }
    }
}
