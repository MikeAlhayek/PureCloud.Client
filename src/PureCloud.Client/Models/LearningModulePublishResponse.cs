using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module publish response
/// </summary>

public partial class LearningModulePublishResponse : IEquatable<LearningModulePublishResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModulePublishResponse" /> class.
    /// </summary>
    /// <param name="Version">The version of published learning module.</param>
    public LearningModulePublishResponse(int? Version = null)
    {
        this.Version = Version;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The version of published learning module
    /// </summary>
    /// <value>The version of published learning module</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



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
        sb.Append("class LearningModulePublishResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as LearningModulePublishResponse);
    }

    /// <summary>
    /// Returns true if LearningModulePublishResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModulePublishResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModulePublishResponse other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
