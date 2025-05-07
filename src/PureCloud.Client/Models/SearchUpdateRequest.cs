using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SearchUpdateRequest
/// </summary>

public partial class SearchUpdateRequest : IEquatable<SearchUpdateRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SearchUpdateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SearchUpdateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchUpdateRequest" /> class.
    /// </summary>
    /// <param name="Answered">Mark the search as answered/unanswered (required).</param>
    /// <param name="SelectedAnswer">The selected search result chosen as the answer..</param>
    public SearchUpdateRequest(bool? Answered = null, SelectedAnswer SelectedAnswer = null)
    {
        this.Answered = Answered;
        this.SelectedAnswer = SelectedAnswer;

    }



    /// <summary>
    /// The unique identifier of this session
    /// </summary>
    /// <value>The unique identifier of this session</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }



    /// <summary>
    /// Mark the search as answered/unanswered
    /// </summary>
    /// <value>Mark the search as answered/unanswered</value>
    [JsonPropertyName("answered")]
    public bool? Answered { get; set; }



    /// <summary>
    /// The selected search result chosen as the answer.
    /// </summary>
    /// <value>The selected search result chosen as the answer.</value>
    [JsonPropertyName("selectedAnswer")]
    public SelectedAnswer SelectedAnswer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SearchUpdateRequest {\n");

        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  Answered: ").Append(Answered).Append("\n");
        sb.Append("  SelectedAnswer: ").Append(SelectedAnswer).Append("\n");
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
        return Equals(obj as SearchUpdateRequest);
    }

    /// <summary>
    /// Returns true if SearchUpdateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SearchUpdateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SearchUpdateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                Answered == other.Answered ||
                Answered != null &&
                Answered.Equals(other.Answered)
            ) &&
            (
                SelectedAnswer == other.SelectedAnswer ||
                SelectedAnswer != null &&
                SelectedAnswer.Equals(other.SelectedAnswer)
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
            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (Answered != null)
            {
                hash = hash * 59 + Answered.GetHashCode();
            }

            if (SelectedAnswer != null)
            {
                hash = hash * 59 + SelectedAnswer.GetHashCode();
            }

            return hash;
        }
    }
}
