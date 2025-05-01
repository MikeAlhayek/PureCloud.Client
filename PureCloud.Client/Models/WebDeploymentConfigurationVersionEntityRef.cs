using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebDeploymentConfigurationVersionEntityRef
/// </summary>
[DataContract]
public partial class WebDeploymentConfigurationVersionEntityRef : IEquatable<WebDeploymentConfigurationVersionEntityRef>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentConfigurationVersionEntityRef" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebDeploymentConfigurationVersionEntityRef() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebDeploymentConfigurationVersionEntityRef" /> class.
    /// </summary>
    /// <param name="Id">The configuration version ID (required).</param>
    /// <param name="Name">The configuration version name.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="Version">The version of the configuration (required).</param>
    public WebDeploymentConfigurationVersionEntityRef(string Id = null, string Name = null, string SelfUri = null, string Version = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SelfUri = SelfUri;
        this.Version = Version;

    }



    /// <summary>
    /// The configuration version ID
    /// </summary>
    /// <value>The configuration version ID</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The configuration version name
    /// </summary>
    /// <value>The configuration version name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// The version of the configuration
    /// </summary>
    /// <value>The version of the configuration</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebDeploymentConfigurationVersionEntityRef {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as WebDeploymentConfigurationVersionEntityRef);
    }

    /// <summary>
    /// Returns true if WebDeploymentConfigurationVersionEntityRef instances are equal
    /// </summary>
    /// <param name="other">Instance of WebDeploymentConfigurationVersionEntityRef to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebDeploymentConfigurationVersionEntityRef other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
