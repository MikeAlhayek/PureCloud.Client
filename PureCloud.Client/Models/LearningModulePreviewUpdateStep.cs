using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module preview update assignment step
/// </summary>
[DataContract]
public partial class LearningModulePreviewUpdateStep : IEquatable<LearningModulePreviewUpdateStep>
{
    /// <summary>
    /// The success status of the step
    /// </summary>
    /// <value>The success status of the step</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SuccessStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Passed for "Passed"
        /// </summary>
        [EnumMember(Value = "Passed")]
        Passed,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The completion status of the step
    /// </summary>
    /// <value>The completion status of the step</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CompletionStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Incomplete for "Incomplete"
        /// </summary>
        [EnumMember(Value = "Incomplete")]
        Incomplete,

        /// <summary>
        /// Enum Notattempted for "NotAttempted"
        /// </summary>
        [EnumMember(Value = "NotAttempted")]
        Notattempted,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The success status of the step
    /// </summary>
    /// <value>The success status of the step</value>
    [DataMember(Name = "successStatus", EmitDefaultValue = false)]
    public SuccessStatusEnum? SuccessStatus { get; set; }
    /// <summary>
    /// The completion status of the step
    /// </summary>
    /// <value>The completion status of the step</value>
    [DataMember(Name = "completionStatus", EmitDefaultValue = false)]
    public CompletionStatusEnum? CompletionStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModulePreviewUpdateStep" /> class.
    /// </summary>
    /// <param name="Id">The id of the step.</param>
    /// <param name="SuccessStatus">The success status of the step.</param>
    /// <param name="CompletionStatus">The completion status of the step.</param>
    /// <param name="CompletionPercentage">The completion percentage of the step.</param>
    /// <param name="PercentageScore">Percentage Score.</param>
    /// <param name="Structure">The structure for any SCO associated with this step.</param>
    public LearningModulePreviewUpdateStep(string Id = null, SuccessStatusEnum? SuccessStatus = null, CompletionStatusEnum? CompletionStatus = null, float? CompletionPercentage = null, float? PercentageScore = null, List<LearningModulePreviewUpdateScoStructure> Structure = null)
    {
        this.Id = Id;
        this.SuccessStatus = SuccessStatus;
        this.CompletionStatus = CompletionStatus;
        this.CompletionPercentage = CompletionPercentage;
        this.PercentageScore = PercentageScore;
        this.Structure = Structure;

    }



    /// <summary>
    /// The id of the step
    /// </summary>
    /// <value>The id of the step</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }







    /// <summary>
    /// The completion percentage of the step
    /// </summary>
    /// <value>The completion percentage of the step</value>
    [DataMember(Name = "completionPercentage", EmitDefaultValue = false)]
    public float? CompletionPercentage { get; set; }



    /// <summary>
    /// Percentage Score
    /// </summary>
    /// <value>Percentage Score</value>
    [DataMember(Name = "percentageScore", EmitDefaultValue = false)]
    public float? PercentageScore { get; set; }



    /// <summary>
    /// The structure for any SCO associated with this step
    /// </summary>
    /// <value>The structure for any SCO associated with this step</value>
    [DataMember(Name = "structure", EmitDefaultValue = false)]
    public List<LearningModulePreviewUpdateScoStructure> Structure { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModulePreviewUpdateStep {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SuccessStatus: ").Append(SuccessStatus).Append("\n");
        sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
        sb.Append("  CompletionPercentage: ").Append(CompletionPercentage).Append("\n");
        sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
        sb.Append("  Structure: ").Append(Structure).Append("\n");
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
        return Equals(obj as LearningModulePreviewUpdateStep);
    }

    /// <summary>
    /// Returns true if LearningModulePreviewUpdateStep instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModulePreviewUpdateStep to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModulePreviewUpdateStep other)
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
                SuccessStatus == other.SuccessStatus ||
                SuccessStatus != null &&
                SuccessStatus.Equals(other.SuccessStatus)
            ) &&
            (
                CompletionStatus == other.CompletionStatus ||
                CompletionStatus != null &&
                CompletionStatus.Equals(other.CompletionStatus)
            ) &&
            (
                CompletionPercentage == other.CompletionPercentage ||
                CompletionPercentage != null &&
                CompletionPercentage.Equals(other.CompletionPercentage)
            ) &&
            (
                PercentageScore == other.PercentageScore ||
                PercentageScore != null &&
                PercentageScore.Equals(other.PercentageScore)
            ) &&
            (
                Structure == other.Structure ||
                Structure != null &&
                Structure.SequenceEqual(other.Structure)
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

            if (SuccessStatus != null)
            {
                hash = hash * 59 + SuccessStatus.GetHashCode();
            }

            if (CompletionStatus != null)
            {
                hash = hash * 59 + CompletionStatus.GetHashCode();
            }

            if (CompletionPercentage != null)
            {
                hash = hash * 59 + CompletionPercentage.GetHashCode();
            }

            if (PercentageScore != null)
            {
                hash = hash * 59 + PercentageScore.GetHashCode();
            }

            if (Structure != null)
            {
                hash = hash * 59 + Structure.GetHashCode();
            }

            return hash;
        }
    }
}
