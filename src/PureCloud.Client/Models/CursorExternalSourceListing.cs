using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CursorExternalSourceListing
/// </summary>

public partial class CursorExternalSourceListing : IEquatable<CursorExternalSourceListing>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CursorExternalSourceListing" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="NextUri">NextUri.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="PreviousUri">PreviousUri.</param>
    /// <param name="Cursors">The cursor that points to the next set of entities being returned..</param>
    public CursorExternalSourceListing(List<ExternalSource> Entities = null, string NextUri = null, string SelfUri = null, string PreviousUri = null, Cursors Cursors = null)
    {
        this.Entities = Entities;
        this.NextUri = NextUri;
        this.SelfUri = SelfUri;
        this.PreviousUri = PreviousUri;
        this.Cursors = Cursors;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<ExternalSource> Entities { get; set; }



    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    [JsonPropertyName("nextUri")]
    public string NextUri { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    [JsonPropertyName("previousUri")]
    public string PreviousUri { get; set; }



    /// <summary>
    /// The cursor that points to the next set of entities being returned.
    /// </summary>
    /// <value>The cursor that points to the next set of entities being returned.</value>
    [JsonPropertyName("cursors")]
    public Cursors Cursors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CursorExternalSourceListing {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  NextUri: ").Append(NextUri).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
        sb.Append("  Cursors: ").Append(Cursors).Append("\n");
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
        return Equals(obj as CursorExternalSourceListing);
    }

    /// <summary>
    /// Returns true if CursorExternalSourceListing instances are equal
    /// </summary>
    /// <param name="other">Instance of CursorExternalSourceListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CursorExternalSourceListing other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                NextUri == other.NextUri ||
                NextUri != null &&
                NextUri.Equals(other.NextUri)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                PreviousUri == other.PreviousUri ||
                PreviousUri != null &&
                PreviousUri.Equals(other.PreviousUri)
            ) &&
            (
                Cursors == other.Cursors ||
                Cursors != null &&
                Cursors.Equals(other.Cursors)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (NextUri != null)
            {
                hash = hash * 59 + NextUri.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (PreviousUri != null)
            {
                hash = hash * 59 + PreviousUri.GetHashCode();
            }

            if (Cursors != null)
            {
                hash = hash * 59 + Cursors.GetHashCode();
            }

            return hash;
        }
    }
}
