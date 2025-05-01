using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Creating an exported script via Download Service
/// </summary>
[DataContract]
public partial class ExportScriptRequest : IEquatable<ExportScriptRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExportScriptRequest" /> class.
    /// </summary>
    /// <param name="FileName">The final file name (no extension) of the script download: &lt;fileName&gt;.script.</param>
    /// <param name="VersionId">The UUID version of the script to be exported.  Defaults to the current editable version..</param>
    public ExportScriptRequest(string FileName = null, string VersionId = null)
    {
        this.FileName = FileName;
        this.VersionId = VersionId;

    }



    /// <summary>
    /// The final file name (no extension) of the script download: &lt;fileName&gt;.script
    /// </summary>
    /// <value>The final file name (no extension) of the script download: &lt;fileName&gt;.script</value>
    [DataMember(Name = "fileName", EmitDefaultValue = false)]
    public string FileName { get; set; }



    /// <summary>
    /// The UUID version of the script to be exported.  Defaults to the current editable version.
    /// </summary>
    /// <value>The UUID version of the script to be exported.  Defaults to the current editable version.</value>
    [DataMember(Name = "versionId", EmitDefaultValue = false)]
    public string VersionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExportScriptRequest {\n");

        sb.Append("  FileName: ").Append(FileName).Append("\n");
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
        return Equals(obj as ExportScriptRequest);
    }

    /// <summary>
    /// Returns true if ExportScriptRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ExportScriptRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExportScriptRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
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
            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (VersionId != null)
            {
                hash = hash * 59 + VersionId.GetHashCode();
            }

            return hash;
        }
    }
}
