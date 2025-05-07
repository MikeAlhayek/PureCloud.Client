using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArticleContent
/// </summary>

public partial class ArticleContent : IEquatable<ArticleContent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArticleContent" /> class.
    /// </summary>
    public ArticleContent()
    {

    }



    /// <summary>
    /// Body of the article content.
    /// </summary>
    /// <value>Body of the article content.</value>
    [JsonPropertyName("body")]
    public ArticleContentBody Body { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArticleContent {\n");

        sb.Append("  Body: ").Append(Body).Append("\n");
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
        return Equals(obj as ArticleContent);
    }

    /// <summary>
    /// Returns true if ArticleContent instances are equal
    /// </summary>
    /// <param name="other">Instance of ArticleContent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArticleContent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Body == other.Body ||
                Body != null &&
                Body.Equals(other.Body)
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
            if (Body != null)
            {
                hash = hash * 59 + Body.GetHashCode();
            }

            return hash;
        }
    }
}
