using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module preview update SCO structure
/// </summary>

public partial class LearningModulePreviewUpdateScoStructure : IEquatable<LearningModulePreviewUpdateScoStructure>
{
    /// <summary>
    /// The success status of this SCO
    /// </summary>
    /// <value>The success status of this SCO</value>
    
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
    /// The completion status of this SCO
    /// </summary>
    /// <value>The completion status of this SCO</value>
    
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
    /// The success status of this SCO
    /// </summary>
    /// <value>The success status of this SCO</value>
    [JsonPropertyName("successStatus")]
    public SuccessStatusEnum? SuccessStatus { get; set; }
    /// <summary>
    /// The completion status of this SCO
    /// </summary>
    /// <value>The completion status of this SCO</value>
    [JsonPropertyName("completionStatus")]
    public CompletionStatusEnum? CompletionStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModulePreviewUpdateScoStructure" /> class.
    /// </summary>
    /// <param name="Id">The id of this SCO in the course manifest.</param>
    /// <param name="Name">The name of this SCO in the course manifest.</param>
    /// <param name="SuccessStatus">The success status of this SCO.</param>
    /// <param name="CompletionStatus">The completion status of this SCO.</param>
    /// <param name="PercentageScore">Percentage Score.</param>
    /// <param name="Children">Child items belonging to this SCO in the course manifest.</param>
    public LearningModulePreviewUpdateScoStructure(string Id = null, string Name = null, SuccessStatusEnum? SuccessStatus = null, CompletionStatusEnum? CompletionStatus = null, float? PercentageScore = null, List<LearningModulePreviewUpdateScoStructure> Children = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SuccessStatus = SuccessStatus;
        this.CompletionStatus = CompletionStatus;
        this.PercentageScore = PercentageScore;
        this.Children = Children;

    }



    /// <summary>
    /// The id of this SCO in the course manifest
    /// </summary>
    /// <value>The id of this SCO in the course manifest</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of this SCO in the course manifest
    /// </summary>
    /// <value>The name of this SCO in the course manifest</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }







    /// <summary>
    /// Percentage Score
    /// </summary>
    /// <value>Percentage Score</value>
    [JsonPropertyName("percentageScore")]
    public float? PercentageScore { get; set; }



    /// <summary>
    /// Child items belonging to this SCO in the course manifest
    /// </summary>
    /// <value>Child items belonging to this SCO in the course manifest</value>
    [JsonPropertyName("children")]
    public List<LearningModulePreviewUpdateScoStructure> Children { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModulePreviewUpdateScoStructure {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SuccessStatus: ").Append(SuccessStatus).Append("\n");
        sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
        sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
        sb.Append("  Children: ").Append(Children).Append("\n");
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
        return Equals(obj as LearningModulePreviewUpdateScoStructure);
    }

    /// <summary>
    /// Returns true if LearningModulePreviewUpdateScoStructure instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModulePreviewUpdateScoStructure to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModulePreviewUpdateScoStructure other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
                PercentageScore == other.PercentageScore ||
                PercentageScore != null &&
                PercentageScore.Equals(other.PercentageScore)
            ) &&
            (
                Children == other.Children ||
                Children != null &&
                Children.SequenceEqual(other.Children)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (SuccessStatus != null)
            {
                hash = hash * 59 + SuccessStatus.GetHashCode();
            }

            if (CompletionStatus != null)
            {
                hash = hash * 59 + CompletionStatus.GetHashCode();
            }

            if (PercentageScore != null)
            {
                hash = hash * 59 + PercentageScore.GetHashCode();
            }

            if (Children != null)
            {
                hash = hash * 59 + Children.GetHashCode();
            }

            return hash;
        }
    }
}
