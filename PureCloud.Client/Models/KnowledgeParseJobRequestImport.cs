using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeParseJobRequestImport
/// </summary>
[DataContract]
public partial class KnowledgeParseJobRequestImport : IEquatable<KnowledgeParseJobRequestImport>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeParseJobRequestImport" /> class.
    /// </summary>
    /// <param name="Edits">Override of the result of the parse..</param>
    /// <param name="Excludes">Excluded results..</param>
    public KnowledgeParseJobRequestImport(List<KnowledgeParseRecord> Edits = null, List<string> Excludes = null)
    {
        this.Edits = Edits;
        this.Excludes = Excludes;

    }



    /// <summary>
    /// Override of the result of the parse.
    /// </summary>
    /// <value>Override of the result of the parse.</value>
    [DataMember(Name = "edits", EmitDefaultValue = false)]
    public List<KnowledgeParseRecord> Edits { get; set; }



    /// <summary>
    /// Excluded results.
    /// </summary>
    /// <value>Excluded results.</value>
    [DataMember(Name = "excludes", EmitDefaultValue = false)]
    public List<string> Excludes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeParseJobRequestImport {\n");

        sb.Append("  Edits: ").Append(Edits).Append("\n");
        sb.Append("  Excludes: ").Append(Excludes).Append("\n");
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
        return Equals(obj as KnowledgeParseJobRequestImport);
    }

    /// <summary>
    /// Returns true if KnowledgeParseJobRequestImport instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeParseJobRequestImport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeParseJobRequestImport other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Edits == other.Edits ||
                Edits != null &&
                Edits.SequenceEqual(other.Edits)
            ) &&
            (
                Excludes == other.Excludes ||
                Excludes != null &&
                Excludes.SequenceEqual(other.Excludes)
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
            if (Edits != null)
            {
                hash = hash * 59 + Edits.GetHashCode();
            }

            if (Excludes != null)
            {
                hash = hash * 59 + Excludes.GetHashCode();
            }

            return hash;
        }
    }
}
