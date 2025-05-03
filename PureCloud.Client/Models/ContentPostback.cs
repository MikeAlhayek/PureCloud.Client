using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Postback response object representing the click of a rich media button (Deprecated).
/// </summary>

public partial class ContentPostback : IEquatable<ContentPostback>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContentPostback" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContentPostback() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentPostback" /> class.
    /// </summary>
    /// <param name="Id">An ID assigned to the button response..</param>
    /// <param name="Text">The response text from the button click..</param>
    /// <param name="Payload">The response payload associated with the clicked button. (required).</param>
    public ContentPostback(string Id = null, string Text = null, string Payload = null)
    {
        this.Id = Id;
        this.Text = Text;
        this.Payload = Payload;

    }



    /// <summary>
    /// An ID assigned to the button response.
    /// </summary>
    /// <value>An ID assigned to the button response.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The response text from the button click.
    /// </summary>
    /// <value>The response text from the button click.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// The response payload associated with the clicked button.
    /// </summary>
    /// <value>The response payload associated with the clicked button.</value>
    [JsonPropertyName("payload")]
    public string Payload { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentPostback {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Payload: ").Append(Payload).Append("\n");
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
        return Equals(obj as ContentPostback);
    }

    /// <summary>
    /// Returns true if ContentPostback instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentPostback to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentPostback other)
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
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Payload == other.Payload ||
                Payload != null &&
                Payload.Equals(other.Payload)
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

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Payload != null)
            {
                hash = hash * 59 + Payload.GetHashCode();
            }

            return hash;
        }
    }
}
