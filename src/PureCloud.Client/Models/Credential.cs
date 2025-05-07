using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Credential
/// </summary>

public partial class Credential : IEquatable<Credential>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Credential" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Credential() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Credential" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Type">The type of credential. (required).</param>
    /// <param name="CredentialFields">CredentialFields.</param>
    public Credential(string Name = null, CredentialType Type = null, Dictionary<string, string> CredentialFields = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.CredentialFields = CredentialFields;

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
    /// The type of credential.
    /// </summary>
    /// <value>The type of credential.</value>
    [JsonPropertyName("type")]
    public CredentialType Type { get; set; }



    /// <summary>
    /// Gets or Sets CredentialFields
    /// </summary>
    [JsonPropertyName("credentialFields")]
    public Dictionary<string, string> CredentialFields { get; set; }



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
        sb.Append("class Credential {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  CredentialFields: ").Append(CredentialFields).Append("\n");
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
        return Equals(obj as Credential);
    }

    /// <summary>
    /// Returns true if Credential instances are equal
    /// </summary>
    /// <param name="other">Instance of Credential to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Credential other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                CredentialFields == other.CredentialFields ||
                CredentialFields != null &&
                CredentialFields.SequenceEqual(other.CredentialFields)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (CredentialFields != null)
            {
                hash = hash * 59 + CredentialFields.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
