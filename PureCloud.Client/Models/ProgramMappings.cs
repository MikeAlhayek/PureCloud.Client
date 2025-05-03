using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgramMappings
/// </summary>

public partial class ProgramMappings : IEquatable<ProgramMappings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramMappings" /> class.
    /// </summary>
    /// <param name="Program">Program.</param>
    /// <param name="Queues">Queues.</param>
    /// <param name="Flows">Flows.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ProgramMappings(BaseProgramEntity Program = null, List<AddressableEntityRef> Queues = null, List<AddressableEntityRef> Flows = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null)
    {
        this.Program = Program;
        this.Queues = Queues;
        this.Flows = Flows;
        this.ModifiedBy = ModifiedBy;
        this.DateModified = DateModified;

    }



    /// <summary>
    /// Gets or Sets Program
    /// </summary>
    [JsonPropertyName("program")]
    public BaseProgramEntity Program { get; set; }



    /// <summary>
    /// Gets or Sets Queues
    /// </summary>
    [JsonPropertyName("queues")]
    public List<AddressableEntityRef> Queues { get; set; }



    /// <summary>
    /// Gets or Sets Flows
    /// </summary>
    [JsonPropertyName("flows")]
    public List<AddressableEntityRef> Flows { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [JsonPropertyName("modifiedBy")]
    public AddressableEntityRef ModifiedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProgramMappings {\n");

        sb.Append("  Program: ").Append(Program).Append("\n");
        sb.Append("  Queues: ").Append(Queues).Append("\n");
        sb.Append("  Flows: ").Append(Flows).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as ProgramMappings);
    }

    /// <summary>
    /// Returns true if ProgramMappings instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgramMappings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgramMappings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Program == other.Program ||
                Program != null &&
                Program.Equals(other.Program)
            ) &&
            (
                Queues == other.Queues ||
                Queues != null &&
                Queues.SequenceEqual(other.Queues)
            ) &&
            (
                Flows == other.Flows ||
                Flows != null &&
                Flows.SequenceEqual(other.Flows)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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
            if (Program != null)
            {
                hash = hash * 59 + Program.GetHashCode();
            }

            if (Queues != null)
            {
                hash = hash * 59 + Queues.GetHashCode();
            }

            if (Flows != null)
            {
                hash = hash * 59 + Flows.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            return hash;
        }
    }
}
