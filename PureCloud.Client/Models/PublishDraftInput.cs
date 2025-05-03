using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Draft to be published
/// </summary>

public partial class PublishDraftInput : IEquatable<PublishDraftInput>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PublishDraftInput" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PublishDraftInput() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PublishDraftInput" /> class.
    /// </summary>
    /// <param name="Version">The current draft version. (required).</param>
    public PublishDraftInput(int? Version = null)
    {
        this.Version = Version;

    }



    /// <summary>
    /// The current draft version.
    /// </summary>
    /// <value>The current draft version.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PublishDraftInput {\n");

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
        return Equals(obj as PublishDraftInput);
    }

    /// <summary>
    /// Returns true if PublishDraftInput instances are equal
    /// </summary>
    /// <param name="other">Instance of PublishDraftInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PublishDraftInput other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
