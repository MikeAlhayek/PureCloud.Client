using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentAggregateQueryResponseGroupedData
/// </summary>

public partial class LearningAssignmentAggregateQueryResponseGroupedData : IEquatable<LearningAssignmentAggregateQueryResponseGroupedData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentAggregateQueryResponseGroupedData" /> class.
    /// </summary>
    /// <param name="Group">The group values for this data.</param>
    /// <param name="Data">The metrics in this group.</param>
    public LearningAssignmentAggregateQueryResponseGroupedData(Dictionary<string, string> Group = null, List<LearningAssignmentAggregateQueryResponseData> Data = null)
    {
        this.Group = Group;
        this.Data = Data;

    }



    /// <summary>
    /// The group values for this data
    /// </summary>
    /// <value>The group values for this data</value>
    [JsonPropertyName("group")]
    public Dictionary<string, string> Group { get; set; }



    /// <summary>
    /// The metrics in this group
    /// </summary>
    /// <value>The metrics in this group</value>
    [JsonPropertyName("data")]
    public List<LearningAssignmentAggregateQueryResponseData> Data { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentAggregateQueryResponseGroupedData {\n");

        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
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
        return Equals(obj as LearningAssignmentAggregateQueryResponseGroupedData);
    }

    /// <summary>
    /// Returns true if LearningAssignmentAggregateQueryResponseGroupedData instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentAggregateQueryResponseGroupedData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentAggregateQueryResponseGroupedData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Group == other.Group ||
                Group != null &&
                Group.SequenceEqual(other.Group)
            ) &&
            (
                Data == other.Data ||
                Data != null &&
                Data.SequenceEqual(other.Data)
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
            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            return hash;
        }
    }
}
