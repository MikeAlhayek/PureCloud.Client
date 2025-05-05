using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DraftIntents
/// </summary>

public partial class DraftIntents : IEquatable<DraftIntents>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DraftIntents" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DraftIntents() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DraftIntents" /> class.
    /// </summary>
    /// <param name="Id">Id for an intent. (required).</param>
    /// <param name="Name">Name/Label for an intent. (required).</param>
    /// <param name="Utterances">The utterances that are extracted for an Intent. (required).</param>
    public DraftIntents(string Id = null, string Name = null, List<string> Utterances = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Utterances = Utterances;

    }



    /// <summary>
    /// Id for an intent.
    /// </summary>
    /// <value>Id for an intent.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Name/Label for an intent.
    /// </summary>
    /// <value>Name/Label for an intent.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The utterances that are extracted for an Intent.
    /// </summary>
    /// <value>The utterances that are extracted for an Intent.</value>
    [JsonPropertyName("utterances")]
    public List<string> Utterances { get; set; }



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
        sb.Append("class DraftIntents {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Utterances: ").Append(Utterances).Append("\n");
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
        return Equals(obj as DraftIntents);
    }

    /// <summary>
    /// Returns true if DraftIntents instances are equal
    /// </summary>
    /// <param name="other">Instance of DraftIntents to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DraftIntents other)
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
                Utterances == other.Utterances ||
                Utterances != null &&
                Utterances.SequenceEqual(other.Utterances)
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

            if (Utterances != null)
            {
                hash = hash * 59 + Utterances.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
