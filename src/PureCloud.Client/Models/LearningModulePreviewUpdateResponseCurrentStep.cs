using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module preview update response current step
/// </summary>

public partial class LearningModulePreviewUpdateResponseCurrentStep : IEquatable<LearningModulePreviewUpdateResponseCurrentStep>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModulePreviewUpdateResponseCurrentStep" /> class.
    /// </summary>
    /// <param name="ShareableContentObject">The SCO (Shareable Content Object) data.</param>
    public LearningModulePreviewUpdateResponseCurrentStep(LearningShareableContentObject ShareableContentObject = null)
    {
        this.ShareableContentObject = ShareableContentObject;

    }



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
        sb.Append("class LearningModulePreviewUpdateResponseCurrentStep {\n");

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
        return Equals(obj as LearningModulePreviewUpdateResponseCurrentStep);
    }

    /// <summary>
    /// Returns true if LearningModulePreviewUpdateResponseCurrentStep instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModulePreviewUpdateResponseCurrentStep to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModulePreviewUpdateResponseCurrentStep other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (ShareableContentObject != null)
            {
                hash = hash * 59 + ShareableContentObject.GetHashCode();
            }

            return hash;
        }
    }
}
