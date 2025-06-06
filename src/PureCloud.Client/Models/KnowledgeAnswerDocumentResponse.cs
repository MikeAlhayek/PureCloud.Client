using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeAnswerDocumentResponse
/// </summary>

public partial class KnowledgeAnswerDocumentResponse : IEquatable<KnowledgeAnswerDocumentResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeAnswerDocumentResponse" /> class.
    /// </summary>
    /// <param name="Id">The document id..</param>
    /// <param name="Title">The document title..</param>
    /// <param name="Answer">The answer found inside a variationContent..</param>
    /// <param name="Variation">The variation with the answer&#39;s highlight data..</param>
    public KnowledgeAnswerDocumentResponse(string Id = null, string Title = null, string Answer = null, DocumentVariationAnswer Variation = null)
    {
        this.Id = Id;
        this.Title = Title;
        this.Answer = Answer;
        this.Variation = Variation;

    }



    /// <summary>
    /// The document id.
    /// </summary>
    /// <value>The document id.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The document title.
    /// </summary>
    /// <value>The document title.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// The answer found inside a variationContent.
    /// </summary>
    /// <value>The answer found inside a variationContent.</value>
    [JsonPropertyName("answer")]
    public string Answer { get; set; }



    /// <summary>
    /// The variation with the answer&#39;s highlight data.
    /// </summary>
    /// <value>The variation with the answer&#39;s highlight data.</value>
    [JsonPropertyName("variation")]
    public DocumentVariationAnswer Variation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeAnswerDocumentResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Answer: ").Append(Answer).Append("\n");
        sb.Append("  Variation: ").Append(Variation).Append("\n");
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
        return Equals(obj as KnowledgeAnswerDocumentResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeAnswerDocumentResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeAnswerDocumentResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeAnswerDocumentResponse other)
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
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Answer == other.Answer ||
                Answer != null &&
                Answer.Equals(other.Answer)
            ) &&
            (
                Variation == other.Variation ||
                Variation != null &&
                Variation.Equals(other.Variation)
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

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Answer != null)
            {
                hash = hash * 59 + Answer.GetHashCode();
            }

            if (Variation != null)
            {
                hash = hash * 59 + Variation.GetHashCode();
            }

            return hash;
        }
    }
}
