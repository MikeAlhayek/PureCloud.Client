using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Link to a help or support resource
/// </summary>

public partial class HelpLink : IEquatable<HelpLink>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HelpLink" /> class.
    /// </summary>
    public HelpLink()
    {

    }



    /// <summary>
    /// URI of the help resource
    /// </summary>
    /// <value>URI of the help resource</value>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }



    /// <summary>
    /// Link text of the resource
    /// </summary>
    /// <value>Link text of the resource</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// Description of the document or resource
    /// </summary>
    /// <value>Description of the document or resource</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HelpLink {\n");

        sb.Append("  Uri: ").Append(Uri).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as HelpLink);
    }

    /// <summary>
    /// Returns true if HelpLink instances are equal
    /// </summary>
    /// <param name="other">Instance of HelpLink to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HelpLink other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Uri == other.Uri ||
                Uri != null &&
                Uri.Equals(other.Uri)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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
            if (Uri != null)
            {
                hash = hash * 59 + Uri.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            return hash;
        }
    }
}
