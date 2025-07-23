using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentCreate
/// </summary>
public sealed class LearningAssignmentCreate
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentCreate" /> class.
    /// </summary>
    private LearningAssignmentCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentCreate" /> class.
    /// </summary>
    /// <param name="ModuleId">The Learning module Id associated with this assignment (required).</param>
    /// <param name="UserId">The User for whom the assignment is assigned (required).</param>
    /// <param name="RecommendedCompletionDate">The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="LengthInMinutes">The length in minutes of assignment.</param>
    public LearningAssignmentCreate(string ModuleId = null, string UserId = null, DateTime? RecommendedCompletionDate = null, int? LengthInMinutes = null)
    {
        this.ModuleId = ModuleId;
        this.UserId = UserId;
        this.RecommendedCompletionDate = RecommendedCompletionDate;
        this.LengthInMinutes = LengthInMinutes;

    }



    /// <summary>
    /// The Learning module Id associated with this assignment
    /// </summary>
    /// <value>The Learning module Id associated with this assignment</value>
    [JsonPropertyName("moduleId")]
    public string ModuleId { get; set; }



    /// <summary>
    /// The User for whom the assignment is assigned
    /// </summary>
    /// <value>The User for whom the assignment is assigned</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The recommended completion date of assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("recommendedCompletionDate")]
    public DateTime? RecommendedCompletionDate { get; set; }



    /// <summary>
    /// The length in minutes of assignment
    /// </summary>
    /// <value>The length in minutes of assignment</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentCreate {\n");

        sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  RecommendedCompletionDate: ").Append(RecommendedCompletionDate).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}
