using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningModuleCoverArtRequest
/// </summary>

public partial class LearningModuleCoverArtRequest : IEquatable<LearningModuleCoverArtRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleCoverArtRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningModuleCoverArtRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleCoverArtRequest" /> class.
    /// </summary>
    /// <param name="Id">The key identifier for the cover art (required).</param>
    public LearningModuleCoverArtRequest(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// The key identifier for the cover art
    /// </summary>
    /// <value>The key identifier for the cover art</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModuleCoverArtRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as LearningModuleCoverArtRequest);
    }

    /// <summary>
    /// Returns true if LearningModuleCoverArtRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModuleCoverArtRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModuleCoverArtRequest other)
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

            return hash;
        }
    }
}
