using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LocalEncryptionConfiguration
/// </summary>

public partial class LocalEncryptionConfiguration : IEquatable<LocalEncryptionConfiguration>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LocalEncryptionConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LocalEncryptionConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LocalEncryptionConfiguration" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Url">The url for decryption. This must specify the path to where PureCloudEnvironment can requests decryption (required).</param>
    /// <param name="ApiId">The api id for Hawk Authentication. (required).</param>
    /// <param name="ApiKey">The api shared symmetric key used for hawk authentication (required).</param>
    public LocalEncryptionConfiguration(string Name = null, string Url = null, string ApiId = null, string ApiKey = null)
    {
        this.Name = Name;
        this.Url = Url;
        this.ApiId = ApiId;
        this.ApiKey = ApiKey;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The url for decryption. This must specify the path to where PureCloudEnvironment can requests decryption
    /// </summary>
    /// <value>The url for decryption. This must specify the path to where PureCloudEnvironment can requests decryption</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// The api id for Hawk Authentication.
    /// </summary>
    /// <value>The api id for Hawk Authentication.</value>
    [JsonPropertyName("apiId")]
    public string ApiId { get; set; }



    /// <summary>
    /// The api shared symmetric key used for hawk authentication
    /// </summary>
    /// <value>The api shared symmetric key used for hawk authentication</value>
    [JsonPropertyName("apiKey")]
    public string ApiKey { get; set; }



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
        sb.Append("class LocalEncryptionConfiguration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  ApiId: ").Append(ApiId).Append("\n");
        sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
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
        return Equals(obj as LocalEncryptionConfiguration);
    }

    /// <summary>
    /// Returns true if LocalEncryptionConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of LocalEncryptionConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LocalEncryptionConfiguration other)
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
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                ApiId == other.ApiId ||
                ApiId != null &&
                ApiId.Equals(other.ApiId)
            ) &&
            (
                ApiKey == other.ApiKey ||
                ApiKey != null &&
                ApiKey.Equals(other.ApiKey)
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

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (ApiId != null)
            {
                hash = hash * 59 + ApiId.GetHashCode();
            }

            if (ApiKey != null)
            {
                hash = hash * 59 + ApiKey.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
