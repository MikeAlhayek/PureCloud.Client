using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkMetrics
/// </summary>
[DataContract]
public partial class TrunkMetrics : IEquatable<TrunkMetrics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkMetrics" /> class.
    /// </summary>
    /// <param name="EventTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="LogicalInterface">LogicalInterface.</param>
    /// <param name="Trunk">Trunk.</param>
    /// <param name="Calls">Calls.</param>
    /// <param name="Qos">Qos.</param>
    public TrunkMetrics(DateTime? EventTime = null, DomainEntityRef LogicalInterface = null, DomainEntityRef Trunk = null, TrunkMetricsCalls Calls = null, TrunkMetricsQoS Qos = null)
    {
        this.EventTime = EventTime;
        this.LogicalInterface = LogicalInterface;
        this.Trunk = Trunk;
        this.Calls = Calls;
        this.Qos = Qos;

    }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "eventTime", EmitDefaultValue = false)]
    public DateTime? EventTime { get; set; }



    /// <summary>
    /// Gets or Sets LogicalInterface
    /// </summary>
    [DataMember(Name = "logicalInterface", EmitDefaultValue = false)]
    public DomainEntityRef LogicalInterface { get; set; }



    /// <summary>
    /// Gets or Sets Trunk
    /// </summary>
    [DataMember(Name = "trunk", EmitDefaultValue = false)]
    public DomainEntityRef Trunk { get; set; }



    /// <summary>
    /// Gets or Sets Calls
    /// </summary>
    [DataMember(Name = "calls", EmitDefaultValue = false)]
    public TrunkMetricsCalls Calls { get; set; }



    /// <summary>
    /// Gets or Sets Qos
    /// </summary>
    [DataMember(Name = "qos", EmitDefaultValue = false)]
    public TrunkMetricsQoS Qos { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkMetrics {\n");

        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  LogicalInterface: ").Append(LogicalInterface).Append("\n");
        sb.Append("  Trunk: ").Append(Trunk).Append("\n");
        sb.Append("  Calls: ").Append(Calls).Append("\n");
        sb.Append("  Qos: ").Append(Qos).Append("\n");
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
        return Equals(obj as TrunkMetrics);
    }

    /// <summary>
    /// Returns true if TrunkMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkMetrics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                LogicalInterface == other.LogicalInterface ||
                LogicalInterface != null &&
                LogicalInterface.Equals(other.LogicalInterface)
            ) &&
            (
                Trunk == other.Trunk ||
                Trunk != null &&
                Trunk.Equals(other.Trunk)
            ) &&
            (
                Calls == other.Calls ||
                Calls != null &&
                Calls.Equals(other.Calls)
            ) &&
            (
                Qos == other.Qos ||
                Qos != null &&
                Qos.Equals(other.Qos)
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
            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (LogicalInterface != null)
            {
                hash = hash * 59 + LogicalInterface.GetHashCode();
            }

            if (Trunk != null)
            {
                hash = hash * 59 + Trunk.GetHashCode();
            }

            if (Calls != null)
            {
                hash = hash * 59 + Calls.GetHashCode();
            }

            if (Qos != null)
            {
                hash = hash * 59 + Qos.GetHashCode();
            }

            return hash;
        }
    }
}
