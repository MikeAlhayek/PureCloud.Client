using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TextBotFlowMilestone
/// </summary>

public partial class TextBotFlowMilestone : IEquatable<TextBotFlowMilestone>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowMilestone" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotFlowMilestone() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowMilestone" /> class.
    /// </summary>
    /// <param name="Id">The Milestone&#39;s ID. (required).</param>
    /// <param name="DateReached">The timestamp of when the milestone was reached. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Sequence">The sequence number of the milestone. (required).</param>
    public TextBotFlowMilestone(string Id = null, DateTime? DateReached = null, long? Sequence = null)
    {
        this.Id = Id;
        this.DateReached = DateReached;
        this.Sequence = Sequence;

    }



    /// <summary>
    /// The Milestone&#39;s ID.
    /// </summary>
    /// <value>The Milestone&#39;s ID.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The timestamp of when the milestone was reached. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the milestone was reached. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateReached")]
    public DateTime? DateReached { get; set; }



    /// <summary>
    /// The sequence number of the milestone.
    /// </summary>
    /// <value>The sequence number of the milestone.</value>
    [JsonPropertyName("sequence")]
    public long? Sequence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotFlowMilestone {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DateReached: ").Append(DateReached).Append("\n");
        sb.Append("  Sequence: ").Append(Sequence).Append("\n");
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
        return Equals(obj as TextBotFlowMilestone);
    }

    /// <summary>
    /// Returns true if TextBotFlowMilestone instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotFlowMilestone to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotFlowMilestone other)
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
                DateReached == other.DateReached ||
                DateReached != null &&
                DateReached.Equals(other.DateReached)
            ) &&
            (
                Sequence == other.Sequence ||
                Sequence != null &&
                Sequence.Equals(other.Sequence)
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

            if (DateReached != null)
            {
                hash = hash * 59 + DateReached.GetHashCode();
            }

            if (Sequence != null)
            {
                hash = hash * 59 + Sequence.GetHashCode();
            }

            return hash;
        }
    }
}
