using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Learning module preview get SCO structure
/// </summary>
[DataContract]
public partial class LearningModulePreviewGetScoStructure : IEquatable<LearningModulePreviewGetScoStructure>
{
    /// <summary>
    /// The success status of this SCO
    /// </summary>
    /// <value>The success status of this SCO</value>
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
    /// The completion status of this SCO
    /// </summary>
    /// <value>The completion status of this SCO</value>
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
    /// The success status of this SCO
    /// </summary>
    /// <value>The success status of this SCO</value>
    [DataMember(Name = "successStatus", EmitDefaultValue = false)]
    public SuccessStatusEnum? SuccessStatus { get; private set; }
    /// <summary>
    /// The completion status of this SCO
    /// </summary>
    /// <value>The completion status of this SCO</value>
    [DataMember(Name = "completionStatus", EmitDefaultValue = false)]
    public CompletionStatusEnum? CompletionStatus { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModulePreviewGetScoStructure" /> class.
    /// </summary>
    /// <param name="ShareableContentObject">The SCO (Shareable Content Object) data.</param>
    public LearningModulePreviewGetScoStructure(LearningShareableContentObject ShareableContentObject = null)
    {
        this.ShareableContentObject = ShareableContentObject;

    }



    /// <summary>
    /// The id of this SCO in the course manifest
    /// </summary>
    /// <value>The id of this SCO in the course manifest</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of this SCO in the course manifest
    /// </summary>
    /// <value>The name of this SCO in the course manifest</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; private set; }







    /// <summary>
    /// Percentage Score
    /// </summary>
    /// <value>Percentage Score</value>
    [DataMember(Name = "percentageScore", EmitDefaultValue = false)]
    public float? PercentageScore { get; private set; }



    /// <summary>
    /// The SCO (Shareable Content Object) data
    /// </summary>
    /// <value>The SCO (Shareable Content Object) data</value>
    [DataMember(Name = "shareableContentObject", EmitDefaultValue = false)]
    public LearningShareableContentObject ShareableContentObject { get; set; }



    /// <summary>
    /// Child items belonging to this SCO in the course manifest
    /// </summary>
    /// <value>Child items belonging to this SCO in the course manifest</value>
    [DataMember(Name = "children", EmitDefaultValue = false)]
    public List<LearningModulePreviewGetScoStructure> Children { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModulePreviewGetScoStructure {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SuccessStatus: ").Append(SuccessStatus).Append("\n");
        sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
        sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
        sb.Append("  ShareableContentObject: ").Append(ShareableContentObject).Append("\n");
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
        return this.Equals(obj as LearningModulePreviewGetScoStructure);
    }

    /// <summary>
    /// Returns true if LearningModulePreviewGetScoStructure instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModulePreviewGetScoStructure to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModulePreviewGetScoStructure other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.SuccessStatus == other.SuccessStatus ||
                this.SuccessStatus != null &&
                this.SuccessStatus.Equals(other.SuccessStatus)
            ) &&
            (
                this.CompletionStatus == other.CompletionStatus ||
                this.CompletionStatus != null &&
                this.CompletionStatus.Equals(other.CompletionStatus)
            ) &&
            (
                this.PercentageScore == other.PercentageScore ||
                this.PercentageScore != null &&
                this.PercentageScore.Equals(other.PercentageScore)
            ) &&
            (
                this.ShareableContentObject == other.ShareableContentObject ||
                this.ShareableContentObject != null &&
                this.ShareableContentObject.Equals(other.ShareableContentObject)
            ) &&
            (
                this.Children == other.Children ||
                this.Children != null &&
                this.Children.SequenceEqual(other.Children)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.SuccessStatus != null)
            {
                hash = hash * 59 + this.SuccessStatus.GetHashCode();
            }

            if (this.CompletionStatus != null)
            {
                hash = hash * 59 + this.CompletionStatus.GetHashCode();
            }

            if (this.PercentageScore != null)
            {
                hash = hash * 59 + this.PercentageScore.GetHashCode();
            }

            if (this.ShareableContentObject != null)
            {
                hash = hash * 59 + this.ShareableContentObject.GetHashCode();
            }

            if (this.Children != null)
            {
                hash = hash * 59 + this.Children.GetHashCode();
            }

            return hash;
        }
    }
}
