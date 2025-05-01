using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RetentionDuration
/// </summary>
[DataContract]
public partial class RetentionDuration : IEquatable<RetentionDuration>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RetentionDuration" /> class.
    /// </summary>
    /// <param name="ArchiveRetention">ArchiveRetention.</param>
    /// <param name="DeleteRetention">DeleteRetention.</param>
    public RetentionDuration(ArchiveRetention ArchiveRetention = null, DeleteRetention DeleteRetention = null)
    {
        this.ArchiveRetention = ArchiveRetention;
        this.DeleteRetention = DeleteRetention;

    }



    /// <summary>
    /// Gets or Sets ArchiveRetention
    /// </summary>
    [DataMember(Name = "archiveRetention", EmitDefaultValue = false)]
    public ArchiveRetention ArchiveRetention { get; set; }



    /// <summary>
    /// Gets or Sets DeleteRetention
    /// </summary>
    [DataMember(Name = "deleteRetention", EmitDefaultValue = false)]
    public DeleteRetention DeleteRetention { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RetentionDuration {\n");

        sb.Append("  ArchiveRetention: ").Append(ArchiveRetention).Append("\n");
        sb.Append("  DeleteRetention: ").Append(DeleteRetention).Append("\n");
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
        return Equals(obj as RetentionDuration);
    }

    /// <summary>
    /// Returns true if RetentionDuration instances are equal
    /// </summary>
    /// <param name="other">Instance of RetentionDuration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RetentionDuration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ArchiveRetention == other.ArchiveRetention ||
                ArchiveRetention != null &&
                ArchiveRetention.Equals(other.ArchiveRetention)
            ) &&
            (
                DeleteRetention == other.DeleteRetention ||
                DeleteRetention != null &&
                DeleteRetention.Equals(other.DeleteRetention)
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
            if (ArchiveRetention != null)
            {
                hash = hash * 59 + ArchiveRetention.GetHashCode();
            }

            if (DeleteRetention != null)
            {
                hash = hash * 59 + DeleteRetention.GetHashCode();
            }

            return hash;
        }
    }
}
