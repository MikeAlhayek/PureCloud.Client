using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeInterface
/// </summary>

public partial class EdgeInterface : IEquatable<EdgeInterface>
{
    /// <summary>
    /// Gets or Sets LineTypes
    /// </summary>
    
    public enum LineTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Tie for "TIE"
        /// </summary>
        [EnumMember(Value = "TIE")]
        Tie,

        /// <summary>
        /// Enum Network for "NETWORK"
        /// </summary>
        [EnumMember(Value = "NETWORK")]
        Network,

        /// <summary>
        /// Enum Trunk for "TRUNK"
        /// </summary>
        [EnumMember(Value = "TRUNK")]
        Trunk,

        /// <summary>
        /// Enum Station for "STATION"
        /// </summary>
        [EnumMember(Value = "STATION")]
        Station
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeInterface" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="IpAddress">IpAddress.</param>
    /// <param name="Name">Name.</param>
    /// <param name="MacAddress">MacAddress.</param>
    /// <param name="IfName">IfName.</param>
    /// <param name="Endpoints">Endpoints.</param>
    /// <param name="LineTypes">LineTypes.</param>
    /// <param name="AddressFamilyId">AddressFamilyId.</param>
    public EdgeInterface(string Type = null, string IpAddress = null, string Name = null, string MacAddress = null, string IfName = null, List<DomainEntityRef> Endpoints = null, List<LineTypesEnum> LineTypes = null, string AddressFamilyId = null)
    {
        this.Type = Type;
        this.IpAddress = IpAddress;
        this.Name = Name;
        this.MacAddress = MacAddress;
        this.IfName = IfName;
        this.Endpoints = Endpoints;
        this.LineTypes = LineTypes;
        this.AddressFamilyId = AddressFamilyId;

    }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string IpAddress { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets MacAddress
    /// </summary>
    [JsonPropertyName("macAddress")]
    public string MacAddress { get; set; }



    /// <summary>
    /// Gets or Sets IfName
    /// </summary>
    [JsonPropertyName("ifName")]
    public string IfName { get; set; }



    /// <summary>
    /// Gets or Sets Endpoints
    /// </summary>
    [JsonPropertyName("endpoints")]
    public List<DomainEntityRef> Endpoints { get; set; }



    /// <summary>
    /// Gets or Sets LineTypes
    /// </summary>
    [JsonPropertyName("lineTypes")]
    public List<LineTypesEnum> LineTypes { get; set; }



    /// <summary>
    /// Gets or Sets AddressFamilyId
    /// </summary>
    [JsonPropertyName("addressFamilyId")]
    public string AddressFamilyId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeInterface {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
        sb.Append("  IfName: ").Append(IfName).Append("\n");
        sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
        sb.Append("  LineTypes: ").Append(LineTypes).Append("\n");
        sb.Append("  AddressFamilyId: ").Append(AddressFamilyId).Append("\n");
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
        return Equals(obj as EdgeInterface);
    }

    /// <summary>
    /// Returns true if EdgeInterface instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeInterface to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeInterface other)
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
                IpAddress == other.IpAddress ||
                IpAddress != null &&
                IpAddress.Equals(other.IpAddress)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                MacAddress == other.MacAddress ||
                MacAddress != null &&
                MacAddress.Equals(other.MacAddress)
            ) &&
            (
                IfName == other.IfName ||
                IfName != null &&
                IfName.Equals(other.IfName)
            ) &&
            (
                Endpoints == other.Endpoints ||
                Endpoints != null &&
                Endpoints.SequenceEqual(other.Endpoints)
            ) &&
            (
                LineTypes == other.LineTypes ||
                LineTypes != null &&
                LineTypes.SequenceEqual(other.LineTypes)
            ) &&
            (
                AddressFamilyId == other.AddressFamilyId ||
                AddressFamilyId != null &&
                AddressFamilyId.Equals(other.AddressFamilyId)
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

            if (IpAddress != null)
            {
                hash = hash * 59 + IpAddress.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (MacAddress != null)
            {
                hash = hash * 59 + MacAddress.GetHashCode();
            }

            if (IfName != null)
            {
                hash = hash * 59 + IfName.GetHashCode();
            }

            if (Endpoints != null)
            {
                hash = hash * 59 + Endpoints.GetHashCode();
            }

            if (LineTypes != null)
            {
                hash = hash * 59 + LineTypes.GetHashCode();
            }

            if (AddressFamilyId != null)
            {
                hash = hash * 59 + AddressFamilyId.GetHashCode();
            }

            return hash;
        }
    }
}
