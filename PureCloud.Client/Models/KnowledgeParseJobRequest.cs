using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeParseJobRequest
/// </summary>
[DataContract]
public partial class KnowledgeParseJobRequest : IEquatable<KnowledgeParseJobRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeParseJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeParseJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeParseJobRequest" /> class.
    /// </summary>
    /// <param name="UploadKey">Upload key (required).</param>
    /// <param name="Hints">Hinted titles for the parser..</param>
    public KnowledgeParseJobRequest(string UploadKey = null, List<string> Hints = null)
    {
        this.UploadKey = UploadKey;
        this.Hints = Hints;

    }



    /// <summary>
    /// Upload key
    /// </summary>
    /// <value>Upload key</value>
    [DataMember(Name = "uploadKey", EmitDefaultValue = false)]
    public string UploadKey { get; set; }



    /// <summary>
    /// Hinted titles for the parser.
    /// </summary>
    /// <value>Hinted titles for the parser.</value>
    [DataMember(Name = "hints", EmitDefaultValue = false)]
    public List<string> Hints { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeParseJobRequest {\n");

        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  Hints: ").Append(Hints).Append("\n");
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
        return Equals(obj as KnowledgeParseJobRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeParseJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeParseJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeParseJobRequest other)
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
                Hints == other.Hints ||
                Hints != null &&
                Hints.SequenceEqual(other.Hints)
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

            if (Hints != null)
            {
                hash = hash * 59 + Hints.GetHashCode();
            }

            return hash;
        }
    }
}
