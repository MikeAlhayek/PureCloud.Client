using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeConnectionInfo
/// </summary>

public partial class EdgeConnectionInfo : IEquatable<EdgeConnectionInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeConnectionInfo" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Site">Site.</param>
    public EdgeConnectionInfo(string Name = null, AddressableEntityRef Site = null)
    {
        this.Name = Name;
        this.Site = Site;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Interface used for the connection on the edge
    /// </summary>
    /// <value>Interface used for the connection on the edge</value>
    [JsonPropertyName("interfaceName")]
    public string InterfaceName { get; private set; }



    /// <summary>
    /// IP address of the interface
    /// </summary>
    /// <value>IP address of the interface</value>
    [JsonPropertyName("interfaceIpAddress")]
    public string InterfaceIpAddress { get; private set; }



    /// <summary>
    /// Connection errors
    /// </summary>
    /// <value>Connection errors</value>
    [JsonPropertyName("connectionErrors")]
    public List<string> ConnectionErrors { get; private set; }



    /// <summary>
    /// Gets or Sets Site
    /// </summary>
    [JsonPropertyName("site")]
    public AddressableEntityRef Site { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeConnectionInfo {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
        sb.Append("  InterfaceIpAddress: ").Append(InterfaceIpAddress).Append("\n");
        sb.Append("  ConnectionErrors: ").Append(ConnectionErrors).Append("\n");
        sb.Append("  Site: ").Append(Site).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as EdgeConnectionInfo);
    }

    /// <summary>
    /// Returns true if EdgeConnectionInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeConnectionInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeConnectionInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                InterfaceName == other.InterfaceName ||
                InterfaceName != null &&
                InterfaceName.Equals(other.InterfaceName)
            ) &&
            (
                InterfaceIpAddress == other.InterfaceIpAddress ||
                InterfaceIpAddress != null &&
                InterfaceIpAddress.Equals(other.InterfaceIpAddress)
            ) &&
            (
                ConnectionErrors == other.ConnectionErrors ||
                ConnectionErrors != null &&
                ConnectionErrors.SequenceEqual(other.ConnectionErrors)
            ) &&
            (
                Site == other.Site ||
                Site != null &&
                Site.Equals(other.Site)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (InterfaceName != null)
            {
                hash = hash * 59 + InterfaceName.GetHashCode();
            }

            if (InterfaceIpAddress != null)
            {
                hash = hash * 59 + InterfaceIpAddress.GetHashCode();
            }

            if (ConnectionErrors != null)
            {
                hash = hash * 59 + ConnectionErrors.GetHashCode();
            }

            if (Site != null)
            {
                hash = hash * 59 + Site.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
