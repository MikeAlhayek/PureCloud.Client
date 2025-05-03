using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Model for a Nuance bot application
/// </summary>

public partial class NuanceApplication : IEquatable<NuanceApplication>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceApplication" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NuanceApplication() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceApplication" /> class.
    /// </summary>
    /// <param name="Id">The application ID (required).</param>
    /// <param name="Tag">The application Tag (required).</param>
    /// <param name="Name">The application name (required).</param>
    public NuanceApplication(string Id = null, string Tag = null, string Name = null)
    {
        this.Id = Id;
        this.Tag = Tag;
        this.Name = Name;

    }



    /// <summary>
    /// The application ID
    /// </summary>
    /// <value>The application ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The application Tag
    /// </summary>
    /// <value>The application Tag</value>
    [JsonPropertyName("tag")]
    public string Tag { get; set; }



    /// <summary>
    /// The application name
    /// </summary>
    /// <value>The application name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NuanceApplication {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Tag: ").Append(Tag).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as NuanceApplication);
    }

    /// <summary>
    /// Returns true if NuanceApplication instances are equal
    /// </summary>
    /// <param name="other">Instance of NuanceApplication to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NuanceApplication other)
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
                Tag == other.Tag ||
                Tag != null &&
                Tag.Equals(other.Tag)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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

            if (Tag != null)
            {
                hash = hash * 59 + Tag.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            return hash;
        }
    }
}
