using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SttEngineEntity
/// </summary>

public partial class SttEngineEntity : IEquatable<SttEngineEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SttEngineEntity" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="GrammarBased">The STT engine is intended to be used for Grammars.</param>
    public SttEngineEntity(string Name = null, bool? GrammarBased = null)
    {
        this.Name = Name;
        this.GrammarBased = GrammarBased;

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
    /// The STT engine is intended to be used for Grammars
    /// </summary>
    /// <value>The STT engine is intended to be used for Grammars</value>
    [JsonPropertyName("grammarBased")]
    public bool? GrammarBased { get; set; }



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
        sb.Append("class SttEngineEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  GrammarBased: ").Append(GrammarBased).Append("\n");
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
        return Equals(obj as SttEngineEntity);
    }

    /// <summary>
    /// Returns true if SttEngineEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of SttEngineEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SttEngineEntity other)
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
                GrammarBased == other.GrammarBased ||
                GrammarBased != null &&
                GrammarBased.Equals(other.GrammarBased)
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

            if (GrammarBased != null)
            {
                hash = hash * 59 + GrammarBased.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
