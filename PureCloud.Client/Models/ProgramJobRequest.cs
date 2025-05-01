using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgramJobRequest
/// </summary>
[DataContract]
public partial class ProgramJobRequest : IEquatable<ProgramJobRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ProgramJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramJobRequest" /> class.
    /// </summary>
    /// <param name="ProgramIds">The ids of the programs used for this job (required).</param>
    public ProgramJobRequest(List<string> ProgramIds = null)
    {
        this.ProgramIds = ProgramIds;

    }



    /// <summary>
    /// The ids of the programs used for this job
    /// </summary>
    /// <value>The ids of the programs used for this job</value>
    [DataMember(Name = "programIds", EmitDefaultValue = false)]
    public List<string> ProgramIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProgramJobRequest {\n");

        sb.Append("  ProgramIds: ").Append(ProgramIds).Append("\n");
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
        return Equals(obj as ProgramJobRequest);
    }

    /// <summary>
    /// Returns true if ProgramJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgramJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgramJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ProgramIds == other.ProgramIds ||
                ProgramIds != null &&
                ProgramIds.SequenceEqual(other.ProgramIds)
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
            if (ProgramIds != null)
            {
                hash = hash * 59 + ProgramIds.GetHashCode();
            }

            return hash;
        }
    }
}
