using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Model for a Nuance bot geography
/// </summary>

public partial class NuanceGeography : IEquatable<NuanceGeography>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceGeography" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NuanceGeography() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceGeography" /> class.
    /// </summary>
    /// <param name="Id">The geography ID (required).</param>
    /// <param name="Name">The geography name (required).</param>
    public NuanceGeography(string Id = null, string Name = null)
    {
        this.Id = Id;
        this.Name = Name;

    }



    /// <summary>
    /// The geography ID
    /// </summary>
    /// <value>The geography ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The geography name
    /// </summary>
    /// <value>The geography name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NuanceGeography {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as NuanceGeography);
    }

    /// <summary>
    /// Returns true if NuanceGeography instances are equal
    /// </summary>
    /// <param name="other">Instance of NuanceGeography to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NuanceGeography other)
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

            return hash;
        }
    }
}
