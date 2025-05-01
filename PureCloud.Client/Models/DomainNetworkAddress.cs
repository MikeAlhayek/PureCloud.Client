using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DomainNetworkAddress
/// </summary>
[DataContract]
public partial class DomainNetworkAddress : IEquatable<DomainNetworkAddress>
{
    /// <summary>
    /// The type of address.
    /// </summary>
    /// <value>The type of address.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ip for "ip"
        /// </summary>
        [EnumMember(Value = "ip")]
        Ip,

        /// <summary>
        /// Enum Dns for "dns"
        /// </summary>
        [EnumMember(Value = "dns")]
        Dns,

        /// <summary>
        /// Enum Gateway for "gateway"
        /// </summary>
        [EnumMember(Value = "gateway")]
        Gateway,

        /// <summary>
        /// Enum Tdm for "tdm"
        /// </summary>
        [EnumMember(Value = "tdm")]
        Tdm
    }
    /// <summary>
    /// The address family for this address.
    /// </summary>
    /// <value>The address family for this address.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// The type of address.
    /// </summary>
    /// <value>The type of address.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The address family for this address.
    /// </summary>
    /// <value>The address family for this address.</value>
    [DataMember(Name = "family", EmitDefaultValue = false)]
    public FamilyEnum? Family { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainNetworkAddress" /> class.
    /// </summary>
    /// <param name="Type">The type of address..</param>
    /// <param name="Address">An IPv4 or IPv6 IP address. When specifying an address of type \&quot;ip\&quot;, use CIDR format for the subnet mask..</param>
    /// <param name="Persistent">True if this address will persist on Edge restart.  Addresses assigned by DHCP will be returned as false..</param>
    /// <param name="Family">The address family for this address..</param>
    public DomainNetworkAddress(TypeEnum? Type = null, string Address = null, bool? Persistent = null, FamilyEnum? Family = null)
    {
        this.Type = Type;
        this.Address = Address;
        this.Persistent = Persistent;
        this.Family = Family;

    }





    /// <summary>
    /// An IPv4 or IPv6 IP address. When specifying an address of type \&quot;ip\&quot;, use CIDR format for the subnet mask.
    /// </summary>
    /// <value>An IPv4 or IPv6 IP address. When specifying an address of type \&quot;ip\&quot;, use CIDR format for the subnet mask.</value>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public string Address { get; set; }



    /// <summary>
    /// True if this address will persist on Edge restart.  Addresses assigned by DHCP will be returned as false.
    /// </summary>
    /// <value>True if this address will persist on Edge restart.  Addresses assigned by DHCP will be returned as false.</value>
    [DataMember(Name = "persistent", EmitDefaultValue = false)]
    public bool? Persistent { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DomainNetworkAddress {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  Persistent: ").Append(Persistent).Append("\n");
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
        return Equals(obj as DomainNetworkAddress);
    }

    /// <summary>
    /// Returns true if DomainNetworkAddress instances are equal
    /// </summary>
    /// <param name="other">Instance of DomainNetworkAddress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DomainNetworkAddress other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                Persistent == other.Persistent ||
                Persistent != null &&
                Persistent.Equals(other.Persistent)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (Persistent != null)
            {
                hash = hash * 59 + Persistent.GetHashCode();
            }

            if (Family != null)
            {
                hash = hash * 59 + Family.GetHashCode();
            }

            return hash;
        }
    }
}
