using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeMetricsTopicEdgeMetricProcessor
/// </summary>
[DataContract]
public partial class EdgeMetricsTopicEdgeMetricProcessor : IEquatable<EdgeMetricsTopicEdgeMetricProcessor>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeMetricsTopicEdgeMetricProcessor" /> class.
    /// </summary>
    /// <param name="CpuId">CpuId.</param>
    /// <param name="IdleTimePct">IdleTimePct.</param>
    /// <param name="ActiveTimePct">ActiveTimePct.</param>
    /// <param name="PrivilegedTimePct">PrivilegedTimePct.</param>
    /// <param name="UserTimePct">UserTimePct.</param>
    public EdgeMetricsTopicEdgeMetricProcessor(string CpuId = null, long? IdleTimePct = null, long? ActiveTimePct = null, long? PrivilegedTimePct = null, long? UserTimePct = null)
    {
        this.CpuId = CpuId;
        this.IdleTimePct = IdleTimePct;
        this.ActiveTimePct = ActiveTimePct;
        this.PrivilegedTimePct = PrivilegedTimePct;
        this.UserTimePct = UserTimePct;

    }



    /// <summary>
    /// Gets or Sets CpuId
    /// </summary>
    [DataMember(Name = "cpuId", EmitDefaultValue = false)]
    public string CpuId { get; set; }



    /// <summary>
    /// Gets or Sets IdleTimePct
    /// </summary>
    [DataMember(Name = "idleTimePct", EmitDefaultValue = false)]
    public long? IdleTimePct { get; set; }



    /// <summary>
    /// Gets or Sets ActiveTimePct
    /// </summary>
    [DataMember(Name = "activeTimePct", EmitDefaultValue = false)]
    public long? ActiveTimePct { get; set; }



    /// <summary>
    /// Gets or Sets PrivilegedTimePct
    /// </summary>
    [DataMember(Name = "privilegedTimePct", EmitDefaultValue = false)]
    public long? PrivilegedTimePct { get; set; }



    /// <summary>
    /// Gets or Sets UserTimePct
    /// </summary>
    [DataMember(Name = "userTimePct", EmitDefaultValue = false)]
    public long? UserTimePct { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeMetricsTopicEdgeMetricProcessor {\n");

        sb.Append("  CpuId: ").Append(CpuId).Append("\n");
        sb.Append("  IdleTimePct: ").Append(IdleTimePct).Append("\n");
        sb.Append("  ActiveTimePct: ").Append(ActiveTimePct).Append("\n");
        sb.Append("  PrivilegedTimePct: ").Append(PrivilegedTimePct).Append("\n");
        sb.Append("  UserTimePct: ").Append(UserTimePct).Append("\n");
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
        return Equals(obj as EdgeMetricsTopicEdgeMetricProcessor);
    }

    /// <summary>
    /// Returns true if EdgeMetricsTopicEdgeMetricProcessor instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeMetricsTopicEdgeMetricProcessor to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeMetricsTopicEdgeMetricProcessor other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CpuId == other.CpuId ||
                CpuId != null &&
                CpuId.Equals(other.CpuId)
            ) &&
            (
                IdleTimePct == other.IdleTimePct ||
                IdleTimePct != null &&
                IdleTimePct.Equals(other.IdleTimePct)
            ) &&
            (
                ActiveTimePct == other.ActiveTimePct ||
                ActiveTimePct != null &&
                ActiveTimePct.Equals(other.ActiveTimePct)
            ) &&
            (
                PrivilegedTimePct == other.PrivilegedTimePct ||
                PrivilegedTimePct != null &&
                PrivilegedTimePct.Equals(other.PrivilegedTimePct)
            ) &&
            (
                UserTimePct == other.UserTimePct ||
                UserTimePct != null &&
                UserTimePct.Equals(other.UserTimePct)
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
            if (CpuId != null)
            {
                hash = hash * 59 + CpuId.GetHashCode();
            }

            if (IdleTimePct != null)
            {
                hash = hash * 59 + IdleTimePct.GetHashCode();
            }

            if (ActiveTimePct != null)
            {
                hash = hash * 59 + ActiveTimePct.GetHashCode();
            }

            if (PrivilegedTimePct != null)
            {
                hash = hash * 59 + PrivilegedTimePct.GetHashCode();
            }

            if (UserTimePct != null)
            {
                hash = hash * 59 + UserTimePct.GetHashCode();
            }

            return hash;
        }
    }
}
