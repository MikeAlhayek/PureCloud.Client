using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PublishScriptRequestData
/// </summary>

public partial class PublishScriptRequestData : IEquatable<PublishScriptRequestData>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PublishScriptRequestData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PublishScriptRequestData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PublishScriptRequestData" /> class.
    /// </summary>
    /// <param name="ScriptId">The id of the script to publish (required).</param>
    /// <param name="VersionId">VersionId.</param>
    public PublishScriptRequestData(string ScriptId = null, string VersionId = null)
    {
        this.ScriptId = ScriptId;
        this.VersionId = VersionId;

    }



    /// <summary>
    /// The id of the script to publish
    /// </summary>
    /// <value>The id of the script to publish</value>
    [JsonPropertyName("scriptId")]
    public string ScriptId { get; set; }



    /// <summary>
    /// Gets or Sets VersionId
    /// </summary>
    [JsonPropertyName("versionId")]
    public string VersionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PublishScriptRequestData {\n");

        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  VersionId: ").Append(VersionId).Append("\n");
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
        return Equals(obj as PublishScriptRequestData);
    }

    /// <summary>
    /// Returns true if PublishScriptRequestData instances are equal
    /// </summary>
    /// <param name="other">Instance of PublishScriptRequestData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PublishScriptRequestData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ScriptId == other.ScriptId ||
                ScriptId != null &&
                ScriptId.Equals(other.ScriptId)
            ) &&
            (
                VersionId == other.VersionId ||
                VersionId != null &&
                VersionId.Equals(other.VersionId)
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
            if (ScriptId != null)
            {
                hash = hash * 59 + ScriptId.GetHashCode();
            }

            if (VersionId != null)
            {
                hash = hash * 59 + VersionId.GetHashCode();
            }

            return hash;
        }
    }
}
