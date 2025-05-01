using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkMetricsTopicTrunkMetrics
/// </summary>
[DataContract]
public partial class TrunkMetricsTopicTrunkMetrics : IEquatable<TrunkMetricsTopicTrunkMetrics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkMetricsTopicTrunkMetrics" /> class.
    /// </summary>
    /// <param name="Calls">Calls.</param>
    /// <param name="EventTime">EventTime.</param>
    /// <param name="Qos">Qos.</param>
    /// <param name="Trunk">Trunk.</param>
    public TrunkMetricsTopicTrunkMetrics(TrunkMetricsTopicTrunkMetricsCalls Calls = null, DateTime? EventTime = null, TrunkMetricsTopicTrunkMetricsQoS Qos = null, TrunkMetricsTopicUriReference Trunk = null)
    {
        this.Calls = Calls;
        this.EventTime = EventTime;
        this.Qos = Qos;
        this.Trunk = Trunk;

    }



    /// <summary>
    /// Gets or Sets Calls
    /// </summary>
    [DataMember(Name = "calls", EmitDefaultValue = false)]
    public TrunkMetricsTopicTrunkMetricsCalls Calls { get; set; }



    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    [DataMember(Name = "eventTime", EmitDefaultValue = false)]
    public DateTime? EventTime { get; set; }



    /// <summary>
    /// Gets or Sets Qos
    /// </summary>
    [DataMember(Name = "qos", EmitDefaultValue = false)]
    public TrunkMetricsTopicTrunkMetricsQoS Qos { get; set; }



    /// <summary>
    /// Gets or Sets Trunk
    /// </summary>
    [DataMember(Name = "trunk", EmitDefaultValue = false)]
    public TrunkMetricsTopicUriReference Trunk { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkMetricsTopicTrunkMetrics {\n");

        sb.Append("  Calls: ").Append(Calls).Append("\n");
        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  Qos: ").Append(Qos).Append("\n");
        sb.Append("  Trunk: ").Append(Trunk).Append("\n");
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
        return Equals(obj as TrunkMetricsTopicTrunkMetrics);
    }

    /// <summary>
    /// Returns true if TrunkMetricsTopicTrunkMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkMetricsTopicTrunkMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkMetricsTopicTrunkMetrics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Calls == other.Calls ||
                Calls != null &&
                Calls.Equals(other.Calls)
            ) &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                Qos == other.Qos ||
                Qos != null &&
                Qos.Equals(other.Qos)
            ) &&
            (
                Trunk == other.Trunk ||
                Trunk != null &&
                Trunk.Equals(other.Trunk)
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
            if (Calls != null)
            {
                hash = hash * 59 + Calls.GetHashCode();
            }

            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (Qos != null)
            {
                hash = hash * 59 + Qos.GetHashCode();
            }

            if (Trunk != null)
            {
                hash = hash * 59 + Trunk.GetHashCode();
            }

            return hash;
        }
    }
}
