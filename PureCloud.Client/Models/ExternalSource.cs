using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalSource
/// </summary>

public partial class ExternalSource : IEquatable<ExternalSource>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalSource" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExternalSource() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalSource" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The name of the external source. (required).</param>
    /// <param name="Active">Active.</param>
    /// <param name="LinkConfiguration">LinkConfiguration.</param>
    public ExternalSource(string Id = null, string Name = null, bool? Active = null, LinkConfiguration LinkConfiguration = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Active = Active;
        this.LinkConfiguration = LinkConfiguration;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the external source.
    /// </summary>
    /// <value>The name of the external source.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }



    /// <summary>
    /// Gets or Sets LinkConfiguration
    /// </summary>
    [JsonPropertyName("linkConfiguration")]
    public LinkConfiguration LinkConfiguration { get; set; }



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
        sb.Append("class ExternalSource {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  LinkConfiguration: ").Append(LinkConfiguration).Append("\n");
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
        return Equals(obj as ExternalSource);
    }

    /// <summary>
    /// Returns true if ExternalSource instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalSource to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalSource other)
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
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
            ) &&
            (
                LinkConfiguration == other.LinkConfiguration ||
                LinkConfiguration != null &&
                LinkConfiguration.Equals(other.LinkConfiguration)
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

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (LinkConfiguration != null)
            {
                hash = hash * 59 + LinkConfiguration.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
