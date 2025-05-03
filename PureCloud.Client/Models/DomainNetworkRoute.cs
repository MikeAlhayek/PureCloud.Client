using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainNetworkRoute
/// </summary>

public partial class DomainNetworkRoute : IEquatable<DomainNetworkRoute>
{
    /// <summary>
    /// The address family for this route.
    /// </summary>
    /// <value>The address family for this route.</value>
    
    public enum FamilyEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum NUMBER_2 for 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 2,

        /// <summary>
        /// Enum NUMBER_23 for 23
        /// </summary>
        [EnumMember(Value = "23")]
        NUMBER_23 = 23
    }
    /// <summary>
    /// The address family for this route.
    /// </summary>
    /// <value>The address family for this route.</value>
    [JsonPropertyName("family")]
    public FamilyEnum? Family { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainNetworkRoute" /> class.
    /// </summary>
    /// <param name="Prefix">The IPv4 or IPv6 route prefix in CIDR notation..</param>
    /// <param name="Nexthop">The IPv4 or IPv6 nexthop IP address..</param>
    /// <param name="Persistent">True if this route will persist on Edge restart.  Routes assigned by DHCP will be returned as false..</param>
    /// <param name="Metric">The metric being used for route. Lower values will have a higher priority..</param>
    /// <param name="Family">The address family for this route..</param>
    public DomainNetworkRoute(string Prefix = null, string Nexthop = null, bool? Persistent = null, int? Metric = null, FamilyEnum? Family = null)
    {
        this.Prefix = Prefix;
        this.Nexthop = Nexthop;
        this.Persistent = Persistent;
        this.Metric = Metric;
        this.Family = Family;

    }



    /// <summary>
    /// The IPv4 or IPv6 route prefix in CIDR notation.
    /// </summary>
    /// <value>The IPv4 or IPv6 route prefix in CIDR notation.</value>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; }



    /// <summary>
    /// The IPv4 or IPv6 nexthop IP address.
    /// </summary>
    /// <value>The IPv4 or IPv6 nexthop IP address.</value>
    [JsonPropertyName("nexthop")]
    public string Nexthop { get; set; }



    /// <summary>
    /// True if this route will persist on Edge restart.  Routes assigned by DHCP will be returned as false.
    /// </summary>
    /// <value>True if this route will persist on Edge restart.  Routes assigned by DHCP will be returned as false.</value>
    [JsonPropertyName("persistent")]
    public bool? Persistent { get; set; }



    /// <summary>
    /// The metric being used for route. Lower values will have a higher priority.
    /// </summary>
    /// <value>The metric being used for route. Lower values will have a higher priority.</value>
    [JsonPropertyName("metric")]
    public int? Metric { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainNetworkRoute {\n");

        sb.Append("  Prefix: ").Append(Prefix).Append("\n");
        sb.Append("  Nexthop: ").Append(Nexthop).Append("\n");
        sb.Append("  Persistent: ").Append(Persistent).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  Family: ").Append(Family).Append("\n");
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
        return Equals(obj as DomainNetworkRoute);
    }

    /// <summary>
    /// Returns true if DomainNetworkRoute instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainNetworkRoute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainNetworkRoute other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Prefix == other.Prefix ||
                Prefix != null &&
                Prefix.Equals(other.Prefix)
            ) &&
            (
                Nexthop == other.Nexthop ||
                Nexthop != null &&
                Nexthop.Equals(other.Nexthop)
            ) &&
            (
                Persistent == other.Persistent ||
                Persistent != null &&
                Persistent.Equals(other.Persistent)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                Family == other.Family ||
                Family != null &&
                Family.Equals(other.Family)
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
            if (Prefix != null)
            {
                hash = hash * 59 + Prefix.GetHashCode();
            }

            if (Nexthop != null)
            {
                hash = hash * 59 + Nexthop.GetHashCode();
            }

            if (Persistent != null)
            {
                hash = hash * 59 + Persistent.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (Family != null)
            {
                hash = hash * 59 + Family.GetHashCode();
            }

            return hash;
        }
    }
}
