using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SuggestionKnowledgeAnswer
/// </summary>

public partial class SuggestionKnowledgeAnswer : IEquatable<SuggestionKnowledgeAnswer>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionKnowledgeAnswer" /> class.
    /// </summary>
    public SuggestionKnowledgeAnswer()
    {

    }



    /// <summary>
    /// The most relevant answer
    /// </summary>
    /// <value>The most relevant answer</value>
    [JsonPropertyName("answer")]
    public string Answer { get; private set; }



    /// <summary>
    /// The start index of the answer
    /// </summary>
    /// <value>The start index of the answer</value>
    [JsonPropertyName("startIndex")]
    public int? StartIndex { get; private set; }



    /// <summary>
    /// The end index of the answer
    /// </summary>
    /// <value>The end index of the answer</value>
    [JsonPropertyName("endIndex")]
    public int? EndIndex { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SuggestionKnowledgeAnswer {\n");

        sb.Append("  Answer: ").Append(Answer).Append("\n");
        sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
        sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
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
        return Equals(obj as SuggestionKnowledgeAnswer);
    }

    /// <summary>
    /// Returns true if SuggestionKnowledgeAnswer instances are equal
    /// </summary>
    /// <param name="other">Instance of SuggestionKnowledgeAnswer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SuggestionKnowledgeAnswer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Answer == other.Answer ||
                Answer != null &&
                Answer.Equals(other.Answer)
            ) &&
            (
                StartIndex == other.StartIndex ||
                StartIndex != null &&
                StartIndex.Equals(other.StartIndex)
            ) &&
            (
                EndIndex == other.EndIndex ||
                EndIndex != null &&
                EndIndex.Equals(other.EndIndex)
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
            if (Answer != null)
            {
                hash = hash * 59 + Answer.GetHashCode();
            }

            if (StartIndex != null)
            {
                hash = hash * 59 + StartIndex.GetHashCode();
            }

            if (EndIndex != null)
            {
                hash = hash * 59 + EndIndex.GetHashCode();
            }

            return hash;
        }
    }
}
