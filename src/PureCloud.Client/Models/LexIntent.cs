using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LexIntent
/// </summary>

public partial class LexIntent : IEquatable<LexIntent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LexIntent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LexIntent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LexIntent" /> class.
    /// </summary>
    /// <param name="Name">The intent name (required).</param>
    /// <param name="Description">A description of the intent.</param>
    /// <param name="Slots">An object mapping slot names to Slot objects (required).</param>
    /// <param name="Version">The intent version (required).</param>
    public LexIntent(string Name = null, string Description = null, Dictionary<string, LexSlot> Slots = null, string Version = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Slots = Slots;
        this.Version = Version;

    }



    /// <summary>
    /// The intent name
    /// </summary>
    /// <value>The intent name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A description of the intent
    /// </summary>
    /// <value>A description of the intent</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// An object mapping slot names to Slot objects
    /// </summary>
    /// <value>An object mapping slot names to Slot objects</value>
    [JsonPropertyName("slots")]
    public Dictionary<string, LexSlot> Slots { get; set; }



    /// <summary>
    /// The intent version
    /// </summary>
    /// <value>The intent version</value>
    [JsonPropertyName("version")]
    public string Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LexIntent {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Slots: ").Append(Slots).Append("\n");
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
        return Equals(obj as LexIntent);
    }

    /// <summary>
    /// Returns true if LexIntent instances are equal
    /// </summary>
    /// <param name="other">Instance of LexIntent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LexIntent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Slots == other.Slots ||
                Slots != null &&
                Slots.SequenceEqual(other.Slots)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Slots != null)
            {
                hash = hash * 59 + Slots.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
