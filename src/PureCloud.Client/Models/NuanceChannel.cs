using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Model for a Nuance channel
/// </summary>

public partial class NuanceChannel : IEquatable<NuanceChannel>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceChannel" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NuanceChannel() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceChannel" /> class.
    /// </summary>
    /// <param name="Id">The channel ID (required).</param>
    /// <param name="Name">The channel name (required).</param>
    /// <param name="Modes">Supported Channel Modes.</param>
    /// <param name="Color">The Channel Color.</param>
    public NuanceChannel(string Id = null, string Name = null, List<string> Modes = null, string Color = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Modes = Modes;
        this.Color = Color;

    }



    /// <summary>
    /// The channel ID
    /// </summary>
    /// <value>The channel ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The channel name
    /// </summary>
    /// <value>The channel name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Supported Channel Modes
    /// </summary>
    /// <value>Supported Channel Modes</value>
    [JsonPropertyName("modes")]
    public List<string> Modes { get; set; }



    /// <summary>
    /// The Channel Color
    /// </summary>
    /// <value>The Channel Color</value>
    [JsonPropertyName("color")]
    public string Color { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NuanceChannel {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Modes: ").Append(Modes).Append("\n");
        sb.Append("  Color: ").Append(Color).Append("\n");
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
        return Equals(obj as NuanceChannel);
    }

    /// <summary>
    /// Returns true if NuanceChannel instances are equal
    /// </summary>
    /// <param name="other">Instance of NuanceChannel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NuanceChannel other)
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
                Modes == other.Modes ||
                Modes != null &&
                Modes.SequenceEqual(other.Modes)
            ) &&
            (
                Color == other.Color ||
                Color != null &&
                Color.Equals(other.Color)
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

            if (Modes != null)
            {
                hash = hash * 59 + Modes.GetHashCode();
            }

            if (Color != null)
            {
                hash = hash * 59 + Color.GetHashCode();
            }

            return hash;
        }
    }
}
