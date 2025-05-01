using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainCapabilities
/// </summary>
[DataContract]
public partial class DomainCapabilities : IEquatable<DomainCapabilities>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainCapabilities" /> class.
    /// </summary>
    /// <param name="Enabled">True if this address family on the interface is enabled..</param>
    /// <param name="Dhcp">True if this address family on the interface is using DHCP..</param>
    /// <param name="Metric">The metric being used for the address family on this interface. Lower values will have a higher priority. If autoMetric is true, this value will be the automatically calculated metric. To set this value be sure autoMetric is false. If no value is returned, metric configuration is not supported on this Edge..</param>
    /// <param name="AutoMetric">True if the metric is being calculated automatically for the address family on this interface..</param>
    /// <param name="PingEnabled">Set to true to enable this address family on this interface to respond to ping requests..</param>
    public DomainCapabilities(bool? Enabled = null, bool? Dhcp = null, int? Metric = null, bool? AutoMetric = null, bool? PingEnabled = null)
    {
        this.Enabled = Enabled;
        this.Dhcp = Dhcp;
        this.Metric = Metric;
        this.AutoMetric = AutoMetric;
        this.PingEnabled = PingEnabled;

    }



    /// <summary>
    /// True if this address family on the interface is enabled.
    /// </summary>
    /// <value>True if this address family on the interface is enabled.</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// True if this address family on the interface is using DHCP.
    /// </summary>
    /// <value>True if this address family on the interface is using DHCP.</value>
    [DataMember(Name = "dhcp", EmitDefaultValue = false)]
    public bool? Dhcp { get; set; }



    /// <summary>
    /// The metric being used for the address family on this interface. Lower values will have a higher priority. If autoMetric is true, this value will be the automatically calculated metric. To set this value be sure autoMetric is false. If no value is returned, metric configuration is not supported on this Edge.
    /// </summary>
    /// <value>The metric being used for the address family on this interface. Lower values will have a higher priority. If autoMetric is true, this value will be the automatically calculated metric. To set this value be sure autoMetric is false. If no value is returned, metric configuration is not supported on this Edge.</value>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public int? Metric { get; set; }



    /// <summary>
    /// True if the metric is being calculated automatically for the address family on this interface.
    /// </summary>
    /// <value>True if the metric is being calculated automatically for the address family on this interface.</value>
    [DataMember(Name = "autoMetric", EmitDefaultValue = false)]
    public bool? AutoMetric { get; set; }



    /// <summary>
    /// True if metric configuration is supported.
    /// </summary>
    /// <value>True if metric configuration is supported.</value>
    [DataMember(Name = "supportsMetric", EmitDefaultValue = false)]
    public bool? SupportsMetric { get; private set; }



    /// <summary>
    /// Set to true to enable this address family on this interface to respond to ping requests.
    /// </summary>
    /// <value>Set to true to enable this address family on this interface to respond to ping requests.</value>
    [DataMember(Name = "pingEnabled", EmitDefaultValue = false)]
    public bool? PingEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainCapabilities {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Dhcp: ").Append(Dhcp).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  AutoMetric: ").Append(AutoMetric).Append("\n");
        sb.Append("  SupportsMetric: ").Append(SupportsMetric).Append("\n");
        sb.Append("  PingEnabled: ").Append(PingEnabled).Append("\n");
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
        return Equals(obj as DomainCapabilities);
    }

    /// <summary>
    /// Returns true if DomainCapabilities instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainCapabilities to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainCapabilities other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Dhcp == other.Dhcp ||
                Dhcp != null &&
                Dhcp.Equals(other.Dhcp)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                AutoMetric == other.AutoMetric ||
                AutoMetric != null &&
                AutoMetric.Equals(other.AutoMetric)
            ) &&
            (
                SupportsMetric == other.SupportsMetric ||
                SupportsMetric != null &&
                SupportsMetric.Equals(other.SupportsMetric)
            ) &&
            (
                PingEnabled == other.PingEnabled ||
                PingEnabled != null &&
                PingEnabled.Equals(other.PingEnabled)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Dhcp != null)
            {
                hash = hash * 59 + Dhcp.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (AutoMetric != null)
            {
                hash = hash * 59 + AutoMetric.GetHashCode();
            }

            if (SupportsMetric != null)
            {
                hash = hash * 59 + SupportsMetric.GetHashCode();
            }

            if (PingEnabled != null)
            {
                hash = hash * 59 + PingEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
