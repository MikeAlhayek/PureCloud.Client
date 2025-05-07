using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details for a UserApp
/// </summary>

public partial class UserApp : IEquatable<UserApp>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserApp" /> class.
    /// </summary>
    /// <param name="Config">Config.</param>
    public UserApp(UserAppConfigurationInfo Config = null)
    {
        this.Config = Config;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the userApp, used to distinguish this userApp from others of the same type.
    /// </summary>
    /// <value>The name of the userApp, used to distinguish this userApp from others of the same type.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Integration Type for the userApp
    /// </summary>
    /// <value>Integration Type for the userApp</value>
    [JsonPropertyName("integrationType")]
    public IntegrationType IntegrationType { get; set; }



    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [JsonPropertyName("config")]
    public UserAppConfigurationInfo Config { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserApp {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IntegrationType: ").Append(IntegrationType).Append("\n");
        sb.Append("  Config: ").Append(Config).Append("\n");
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
        return Equals(obj as UserApp);
    }

    /// <summary>
    /// Returns true if UserApp instances are equal
    /// </summary>
    /// <param name="other">Instance of UserApp to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserApp other)
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
                IntegrationType == other.IntegrationType ||
                IntegrationType != null &&
                IntegrationType.Equals(other.IntegrationType)
            ) &&
            (
                Config == other.Config ||
                Config != null &&
                Config.Equals(other.Config)
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

            if (IntegrationType != null)
            {
                hash = hash * 59 + IntegrationType.GetHashCode();
            }

            if (Config != null)
            {
                hash = hash * 59 + Config.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
