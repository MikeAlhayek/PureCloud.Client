using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnswerOption
/// </summary>
[DataContract]
public partial class AnswerOption : IEquatable<AnswerOption>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnswerOption" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Text">Text.</param>
    /// <param name="Value">Value.</param>
    /// <param name="AssistanceConditions">List of assistance conditions which are combined together with a logical AND operator. Eg ( assistanceCondtion1 &amp;&amp; assistanceCondition2 ) wherein assistanceCondition could be ( EXISTS topic1 || topic2 || ... ) or (NOTEXISTS topic3 || topic4 || ...)..</param>
    public AnswerOption(string Id = null, string Text = null, int? Value = null, List<AssistanceCondition> AssistanceConditions = null)
    {
        this.Id = Id;
        this.Text = Text;
        this.Value = Value;
        this.AssistanceConditions = AssistanceConditions;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public int? Value { get; set; }



    /// <summary>
    /// List of assistance conditions which are combined together with a logical AND operator. Eg ( assistanceCondtion1 &amp;&amp; assistanceCondition2 ) wherein assistanceCondition could be ( EXISTS topic1 || topic2 || ... ) or (NOTEXISTS topic3 || topic4 || ...).
    /// </summary>
    /// <value>List of assistance conditions which are combined together with a logical AND operator. Eg ( assistanceCondtion1 &amp;&amp; assistanceCondition2 ) wherein assistanceCondition could be ( EXISTS topic1 || topic2 || ... ) or (NOTEXISTS topic3 || topic4 || ...).</value>
    [DataMember(Name = "assistanceConditions", EmitDefaultValue = false)]
    public List<AssistanceCondition> AssistanceConditions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnswerOption {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  AssistanceConditions: ").Append(AssistanceConditions).Append("\n");
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
        return Equals(obj as AnswerOption);
    }

    /// <summary>
    /// Returns true if AnswerOption instances are equal
    /// </summary>
    /// <param name="other">Instance of AnswerOption to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnswerOption other)
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
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                AssistanceConditions == other.AssistanceConditions ||
                AssistanceConditions != null &&
                AssistanceConditions.SequenceEqual(other.AssistanceConditions)
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

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (AssistanceConditions != null)
            {
                hash = hash * 59 + AssistanceConditions.GetHashCode();
            }

            return hash;
        }
    }
}
