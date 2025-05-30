using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Card
/// </summary>

public partial class Card : IEquatable<Card>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Card" /> class.
    /// </summary>
    /// <param name="Title">Text to show in the title..</param>
    /// <param name="Description">Text to show in the description..</param>
    /// <param name="Url">URL of an image..</param>
    /// <param name="DefaultAction">The default action to be taken..</param>
    /// <param name="Actions">List of possible action objects..</param>
    public Card(string Title = null, string Description = null, string Url = null, CardAction DefaultAction = null, List<CardAction> Actions = null)
    {
        this.Title = Title;
        this.Description = Description;
        this.Url = Url;
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
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// The default action to be taken.
    /// </summary>
    /// <value>The default action to be taken.</value>
    [JsonPropertyName("defaultAction")]
    public CardAction DefaultAction { get; set; }



    /// <summary>
    /// List of possible action objects.
    /// </summary>
    /// <value>List of possible action objects.</value>
    [JsonPropertyName("actions")]
    public List<CardAction> Actions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Card {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
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
        return Equals(obj as Card);
    }

    /// <summary>
    /// Returns true if Card instances are equal
    /// </summary>
    /// <param name="other">Instance of Card to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Card other)
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
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
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

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
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
