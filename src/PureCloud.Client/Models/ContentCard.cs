using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Card content object.
/// </summary>

public partial class ContentCard : IEquatable<ContentCard>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContentCard" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContentCard() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentCard" /> class.
    /// </summary>
    /// <param name="Title">Text to show in the title. (required).</param>
    /// <param name="Description">Text to show in the description..</param>
    /// <param name="Image">URL of an image..</param>
    /// <param name="Video">URL of a video..</param>
    /// <param name="DefaultAction">The default button action..</param>
    /// <param name="Actions">An array of action objects. (required).</param>
    public ContentCard(string Title = null, string Description = null, string Image = null, string Video = null, ContentCardAction DefaultAction = null, List<ContentCardAction> Actions = null)
    {
        this.Title = Title;
        this.Description = Description;
        this.Image = Image;
        this.Video = Video;
        this.DefaultAction = DefaultAction;
        this.Actions = Actions;

    }



    /// <summary>
    /// Text to show in the title.
    /// </summary>
    /// <value>Text to show in the title.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// Text to show in the description.
    /// </summary>
    /// <value>Text to show in the description.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// URL of an image.
    /// </summary>
    /// <value>URL of an image.</value>
    [JsonPropertyName("image")]
    public string Image { get; set; }



    /// <summary>
    /// URL of a video.
    /// </summary>
    /// <value>URL of a video.</value>
    [JsonPropertyName("video")]
    public string Video { get; set; }



    /// <summary>
    /// The default button action.
    /// </summary>
    /// <value>The default button action.</value>
    [JsonPropertyName("defaultAction")]
    public ContentCardAction DefaultAction { get; set; }



    /// <summary>
    /// An array of action objects.
    /// </summary>
    /// <value>An array of action objects.</value>
    [JsonPropertyName("actions")]
    public List<ContentCardAction> Actions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentCard {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  Video: ").Append(Video).Append("\n");
        sb.Append("  DefaultAction: ").Append(DefaultAction).Append("\n");
        sb.Append("  Actions: ").Append(Actions).Append("\n");
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
        return Equals(obj as ContentCard);
    }

    /// <summary>
    /// Returns true if ContentCard instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentCard to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentCard other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Image == other.Image ||
                Image != null &&
                Image.Equals(other.Image)
            ) &&
            (
                Video == other.Video ||
                Video != null &&
                Video.Equals(other.Video)
            ) &&
            (
                DefaultAction == other.DefaultAction ||
                DefaultAction != null &&
                DefaultAction.Equals(other.DefaultAction)
            ) &&
            (
                Actions == other.Actions ||
                Actions != null &&
                Actions.SequenceEqual(other.Actions)
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
            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Image != null)
            {
                hash = hash * 59 + Image.GetHashCode();
            }

            if (Video != null)
            {
                hash = hash * 59 + Video.GetHashCode();
            }

            if (DefaultAction != null)
            {
                hash = hash * 59 + DefaultAction.GetHashCode();
            }

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            return hash;
        }
    }
}
