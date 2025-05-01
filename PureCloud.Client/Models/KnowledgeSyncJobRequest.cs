using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeSyncJobRequest
/// </summary>
[DataContract]
public partial class KnowledgeSyncJobRequest : IEquatable<KnowledgeSyncJobRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSyncJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeSyncJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSyncJobRequest" /> class.
    /// </summary>
    /// <param name="UploadKey">Upload key (required).</param>
    /// <param name="SourceId">Knowledge integration source id..</param>
    public KnowledgeSyncJobRequest(string UploadKey = null, string SourceId = null)
    {
        this.UploadKey = UploadKey;
        this.SourceId = SourceId;

    }



    /// <summary>
    /// Upload key
    /// </summary>
    /// <value>Upload key</value>
    [DataMember(Name = "uploadKey", EmitDefaultValue = false)]
    public string UploadKey { get; set; }



    /// <summary>
    /// Knowledge integration source id.
    /// </summary>
    /// <value>Knowledge integration source id.</value>
    [DataMember(Name = "sourceId", EmitDefaultValue = false)]
    public string SourceId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeSyncJobRequest {\n");

        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  SourceId: ").Append(SourceId).Append("\n");
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
        return Equals(obj as KnowledgeSyncJobRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeSyncJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeSyncJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeSyncJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
            ) &&
            (
                SourceId == other.SourceId ||
                SourceId != null &&
                SourceId.Equals(other.SourceId)
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
            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (SourceId != null)
            {
                hash = hash * 59 + SourceId.GetHashCode();
            }

            return hash;
        }
    }
}
