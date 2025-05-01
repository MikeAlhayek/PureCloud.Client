using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Reference to supported content profile associated with the integration
/// </summary>
[DataContract]
public partial class SupportedContentReference : IEquatable<SupportedContentReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SupportedContentReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SupportedContentReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportedContentReference" /> class.
    /// </summary>
    /// <param name="Id">The SupportedContent unique identifier associated with this integration (required).</param>
    public SupportedContentReference(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// The SupportedContent unique identifier associated with this integration
    /// </summary>
    /// <value>The SupportedContent unique identifier associated with this integration</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The SupportedContent profile name
    /// </summary>
    /// <value>The SupportedContent profile name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; private set; }



    /// <summary>
    /// The SupportedContent profile URI
    /// </summary>
    /// <value>The SupportedContent profile URI</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }



    /// <summary>
    /// Media types definition for the supported content
    /// </summary>
    /// <value>Media types definition for the supported content</value>
    [DataMember(Name = "mediaTypes", EmitDefaultValue = false)]
    public MediaTypes MediaTypes { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportedContentReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
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
        return Equals(obj as SupportedContentReference);
    }

    /// <summary>
    /// Returns true if SupportedContentReference instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportedContentReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportedContentReference other)
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
                MediaTypes == other.MediaTypes ||
                MediaTypes != null &&
                MediaTypes.Equals(other.MediaTypes)
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

            if (MediaTypes != null)
            {
                hash = hash * 59 + MediaTypes.GetHashCode();
            }

            return hash;
        }
    }
}
