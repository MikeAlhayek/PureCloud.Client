using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningModuleRule
/// </summary>

public partial class LearningModuleRule : IEquatable<LearningModuleRule>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleRule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningModuleRule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleRule" /> class.
    /// </summary>
    /// <param name="IsActive">If true, rule is active (required).</param>
    /// <param name="Parts">The parts of a learning module rule (required).</param>
    public LearningModuleRule(bool? IsActive = null, List<LearningModuleRuleParts> Parts = null)
    {
        this.IsActive = IsActive;
        this.Parts = Parts;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// If true, rule is active
    /// </summary>
    /// <value>If true, rule is active</value>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }



    /// <summary>
    /// The parts of a learning module rule
    /// </summary>
    /// <value>The parts of a learning module rule</value>
    [JsonPropertyName("parts")]
    public List<LearningModuleRuleParts> Parts { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModuleRule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IsActive: ").Append(IsActive).Append("\n");
        sb.Append("  Parts: ").Append(Parts).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as LearningModuleRule);
    }

    /// <summary>
    /// Returns true if LearningModuleRule instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModuleRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModuleRule other)
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
                IsActive == other.IsActive ||
                IsActive != null &&
                IsActive.Equals(other.IsActive)
            ) &&
            (
                Parts == other.Parts ||
                Parts != null &&
                Parts.SequenceEqual(other.Parts)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (IsActive != null)
            {
                hash = hash * 59 + IsActive.GetHashCode();
            }

            if (Parts != null)
            {
                hash = hash * 59 + Parts.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
