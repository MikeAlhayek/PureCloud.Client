using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module reassign summary data
/// </summary>

public partial class LearningModuleReassignSummary : IEquatable<LearningModuleReassignSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleReassignSummary" /> class.
    /// </summary>
    /// <param name="TotalReassigned">The total number of users for whom assignment is reassigned.</param>
    /// <param name="CompletedCount">The total number of users who have the assignment in Completed state.</param>
    /// <param name="InProgressCount">The total number of users who have the assignment in InProgress state.</param>
    /// <param name="AssignedCount">The total number of users who have the assignment in Assigned state.</param>
    /// <param name="NotCompletedCount">The total number of users who have their assignment overdue.</param>
    public LearningModuleReassignSummary(int? TotalReassigned = null, int? CompletedCount = null, int? InProgressCount = null, int? AssignedCount = null, int? NotCompletedCount = null)
    {
        this.TotalReassigned = TotalReassigned;
        this.CompletedCount = CompletedCount;
        this.InProgressCount = InProgressCount;
        this.AssignedCount = AssignedCount;
        this.NotCompletedCount = NotCompletedCount;

    }



    /// <summary>
    /// The total number of users for whom assignment is reassigned
    /// </summary>
    /// <value>The total number of users for whom assignment is reassigned</value>
    [JsonPropertyName("totalReassigned")]
    public int? TotalReassigned { get; set; }



    /// <summary>
    /// The total number of users who have the assignment in Completed state
    /// </summary>
    /// <value>The total number of users who have the assignment in Completed state</value>
    [JsonPropertyName("completedCount")]
    public int? CompletedCount { get; set; }



    /// <summary>
    /// The total number of users who have the assignment in InProgress state
    /// </summary>
    /// <value>The total number of users who have the assignment in InProgress state</value>
    [JsonPropertyName("inProgressCount")]
    public int? InProgressCount { get; set; }



    /// <summary>
    /// The total number of users who have the assignment in Assigned state
    /// </summary>
    /// <value>The total number of users who have the assignment in Assigned state</value>
    [JsonPropertyName("assignedCount")]
    public int? AssignedCount { get; set; }



    /// <summary>
    /// The total number of users who have their assignment overdue
    /// </summary>
    /// <value>The total number of users who have their assignment overdue</value>
    [JsonPropertyName("notCompletedCount")]
    public int? NotCompletedCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModuleReassignSummary {\n");

        sb.Append("  TotalReassigned: ").Append(TotalReassigned).Append("\n");
        sb.Append("  CompletedCount: ").Append(CompletedCount).Append("\n");
        sb.Append("  InProgressCount: ").Append(InProgressCount).Append("\n");
        sb.Append("  AssignedCount: ").Append(AssignedCount).Append("\n");
        sb.Append("  NotCompletedCount: ").Append(NotCompletedCount).Append("\n");
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
        return Equals(obj as LearningModuleReassignSummary);
    }

    /// <summary>
    /// Returns true if LearningModuleReassignSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModuleReassignSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModuleReassignSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TotalReassigned == other.TotalReassigned ||
                TotalReassigned != null &&
                TotalReassigned.Equals(other.TotalReassigned)
            ) &&
            (
                CompletedCount == other.CompletedCount ||
                CompletedCount != null &&
                CompletedCount.Equals(other.CompletedCount)
            ) &&
            (
                InProgressCount == other.InProgressCount ||
                InProgressCount != null &&
                InProgressCount.Equals(other.InProgressCount)
            ) &&
            (
                AssignedCount == other.AssignedCount ||
                AssignedCount != null &&
                AssignedCount.Equals(other.AssignedCount)
            ) &&
            (
                NotCompletedCount == other.NotCompletedCount ||
                NotCompletedCount != null &&
                NotCompletedCount.Equals(other.NotCompletedCount)
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
            if (TotalReassigned != null)
            {
                hash = hash * 59 + TotalReassigned.GetHashCode();
            }

            if (CompletedCount != null)
            {
                hash = hash * 59 + CompletedCount.GetHashCode();
            }

            if (InProgressCount != null)
            {
                hash = hash * 59 + InProgressCount.GetHashCode();
            }

            if (AssignedCount != null)
            {
                hash = hash * 59 + AssignedCount.GetHashCode();
            }

            if (NotCompletedCount != null)
            {
                hash = hash * 59 + NotCompletedCount.GetHashCode();
            }

            return hash;
        }
    }
}
