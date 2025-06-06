using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SelectedAnswer
/// </summary>

public partial class SelectedAnswer : IEquatable<SelectedAnswer>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SelectedAnswer" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SelectedAnswer() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SelectedAnswer" /> class.
    /// </summary>
    /// <param name="Document">The search result document chosen as the answer. (required).</param>
    public SelectedAnswer(AddressableEntityRef Document = null)
    {
        this.Document = Document;

    }



    /// <summary>
    /// The search result document chosen as the answer.
    /// </summary>
    /// <value>The search result document chosen as the answer.</value>
    [JsonPropertyName("document")]
    public AddressableEntityRef Document { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SelectedAnswer {\n");

        sb.Append("  Document: ").Append(Document).Append("\n");
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
        return Equals(obj as SelectedAnswer);
    }

    /// <summary>
    /// Returns true if SelectedAnswer instances are equal
    /// </summary>
    /// <param name="other">Instance of SelectedAnswer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SelectedAnswer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Document == other.Document ||
                Document != null &&
                Document.Equals(other.Document)
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
            if (Document != null)
            {
                hash = hash * 59 + Document.GetHashCode();
            }

            return hash;
        }
    }
}
