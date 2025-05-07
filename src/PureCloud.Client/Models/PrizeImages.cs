using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PrizeImages
/// </summary>

public partial class PrizeImages : IEquatable<PrizeImages>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PrizeImages" /> class.
    /// </summary>
    public PrizeImages()
    {

    }



    /// <summary>
    /// The Contest Prize image url
    /// </summary>
    /// <value>The Contest Prize image url</value>
    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PrizeImages {\n");

        sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
        return Equals(obj as PrizeImages);
    }

    /// <summary>
    /// Returns true if PrizeImages instances are equal
    /// </summary>
    /// <param name="other">Instance of PrizeImages to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PrizeImages other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ImageUrl == other.ImageUrl ||
                ImageUrl != null &&
                ImageUrl.Equals(other.ImageUrl)
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
            if (ImageUrl != null)
            {
                hash = hash * 59 + ImageUrl.GetHashCode();
            }

            return hash;
        }
    }
}
