using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module preview update request current step
/// </summary>

public partial class LearningModulePreviewUpdateRequestCurrentStep : IEquatable<LearningModulePreviewUpdateRequestCurrentStep>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModulePreviewUpdateRequestCurrentStep" /> class.
    /// </summary>
    /// <param name="Id">The id of this step.</param>
    /// <param name="CompletionPercentage">The completion percentage for this step.</param>
    /// <param name="ShareableContentObject">The SCO (Shareable Content Object) data.</param>
    public LearningModulePreviewUpdateRequestCurrentStep(string Id = null, float? CompletionPercentage = null, LearningShareableContentObject ShareableContentObject = null)
    {
        this.Id = Id;
        this.CompletionPercentage = CompletionPercentage;
        this.ShareableContentObject = ShareableContentObject;

    }



    /// <summary>
    /// The id of this step
    /// </summary>
    /// <value>The id of this step</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The completion percentage for this step
    /// </summary>
    /// <value>The completion percentage for this step</value>
    [JsonPropertyName("completionPercentage")]
    public float? CompletionPercentage { get; set; }



    /// <summary>
    /// The SCO (Shareable Content Object) data
    /// </summary>
    /// <value>The SCO (Shareable Content Object) data</value>
    [JsonPropertyName("shareableContentObject")]
    public LearningShareableContentObject ShareableContentObject { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModulePreviewUpdateRequestCurrentStep {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CompletionPercentage: ").Append(CompletionPercentage).Append("\n");
        sb.Append("  ShareableContentObject: ").Append(ShareableContentObject).Append("\n");
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
        return Equals(obj as LearningModulePreviewUpdateRequestCurrentStep);
    }

    /// <summary>
    /// Returns true if LearningModulePreviewUpdateRequestCurrentStep instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModulePreviewUpdateRequestCurrentStep to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModulePreviewUpdateRequestCurrentStep other)
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
                CompletionPercentage == other.CompletionPercentage ||
                CompletionPercentage != null &&
                CompletionPercentage.Equals(other.CompletionPercentage)
            ) &&
            (
                ShareableContentObject == other.ShareableContentObject ||
                ShareableContentObject != null &&
                ShareableContentObject.Equals(other.ShareableContentObject)
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

            if (CompletionPercentage != null)
            {
                hash = hash * 59 + CompletionPercentage.GetHashCode();
            }

            if (ShareableContentObject != null)
            {
                hash = hash * 59 + ShareableContentObject.GetHashCode();
            }

            return hash;
        }
    }
}
