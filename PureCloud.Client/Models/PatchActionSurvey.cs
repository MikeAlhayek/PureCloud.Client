using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchActionSurvey
/// </summary>
[DataContract]
public partial class PatchActionSurvey : IEquatable<PatchActionSurvey>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PatchActionSurvey" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PatchActionSurvey() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchActionSurvey" /> class.
    /// </summary>
    /// <param name="Questions">Questions shown to the user. (required).</param>
    public PatchActionSurvey(List<PatchSurveyQuestion> Questions = null)
    {
        this.Questions = Questions;

    }



    /// <summary>
    /// Questions shown to the user.
    /// </summary>
    /// <value>Questions shown to the user.</value>
    [DataMember(Name = "questions", EmitDefaultValue = false)]
    public List<PatchSurveyQuestion> Questions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchActionSurvey {\n");

        sb.Append("  Questions: ").Append(Questions).Append("\n");
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
        return this.Equals(obj as PatchActionSurvey);
    }

    /// <summary>
    /// Returns true if PatchActionSurvey instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchActionSurvey to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchActionSurvey other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Questions == other.Questions ||
                this.Questions != null &&
                this.Questions.SequenceEqual(other.Questions)
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
            if (this.Questions != null)
            {
                hash = hash * 59 + this.Questions.GetHashCode();
            }

            return hash;
        }
    }
}
