using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ConnectedEdge
/// </summary>
[DataContract]
public partial class ConnectedEdge : IEquatable<ConnectedEdge>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConnectedEdge" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="EdgeConnectionList">EdgeConnectionList.</param>
    public ConnectedEdge(string Name = null, List<EdgeConnectionInfo> EdgeConnectionList = null)
    {
        this.Name = Name;
        this.EdgeConnectionList = EdgeConnectionList;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Edge interface name used for the connection
    /// </summary>
    /// <value>Edge interface name used for the connection</value>
    [DataMember(Name = "interfaceName", EmitDefaultValue = false)]
    public string InterfaceName { get; private set; }



    /// <summary>
    /// Edge interface IP address
    /// </summary>
    /// <value>Edge interface IP address</value>
    [DataMember(Name = "interfaceIpAddress", EmitDefaultValue = false)]
    public string InterfaceIpAddress { get; private set; }



    /// <summary>
    /// Gets or Sets EdgeConnectionList
    /// </summary>
    [DataMember(Name = "edgeConnectionList", EmitDefaultValue = false)]
    public List<EdgeConnectionInfo> EdgeConnectionList { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConnectedEdge {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
        sb.Append("  InterfaceIpAddress: ").Append(InterfaceIpAddress).Append("\n");
        sb.Append("  EdgeConnectionList: ").Append(EdgeConnectionList).Append("\n");
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
        return Equals(obj as ConnectedEdge);
    }

    /// <summary>
    /// Returns true if ConnectedEdge instances are equal
    /// </summary>
    /// <param name="other">Instance of ConnectedEdge to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConnectedEdge other)
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
                EdgeConnectionList == other.EdgeConnectionList ||
                EdgeConnectionList != null &&
                EdgeConnectionList.SequenceEqual(other.EdgeConnectionList)
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

            if (EdgeConnectionList != null)
            {
                hash = hash * 59 + EdgeConnectionList.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
