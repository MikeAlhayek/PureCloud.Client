using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module cover art response
/// </summary>

public partial class LearningModuleCoverArtResponse : IEquatable<LearningModuleCoverArtResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleCoverArtResponse" /> class.
    /// </summary>
    /// <param name="Url">The URL for the cover art.</param>
    /// <param name="Thumbnails">Thumbnails for the cover art.</param>
    public LearningModuleCoverArtResponse(string Url = null, List<LearningCoverArtThumbnail> Thumbnails = null)
    {
        this.Url = Url;
        this.Thumbnails = Thumbnails;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }



    /// <summary>
    /// The URL for the cover art
    /// </summary>
    /// <value>The URL for the cover art</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// Thumbnails for the cover art
    /// </summary>
    /// <value>Thumbnails for the cover art</value>
    [JsonPropertyName("thumbnails")]
    public List<LearningCoverArtThumbnail> Thumbnails { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModuleCoverArtResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
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
        return Equals(obj as LearningModuleCoverArtResponse);
    }

    /// <summary>
    /// Returns true if LearningModuleCoverArtResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModuleCoverArtResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModuleCoverArtResponse other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                Thumbnails == other.Thumbnails ||
                Thumbnails != null &&
                Thumbnails.SequenceEqual(other.Thumbnails)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Thumbnails != null)
            {
                hash = hash * 59 + Thumbnails.GetHashCode();
            }

            return hash;
        }
    }
}
