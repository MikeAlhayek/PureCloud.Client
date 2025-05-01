using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ReportingTurnsResponse
/// </summary>
[DataContract]
public partial class ReportingTurnsResponse : IEquatable<ReportingTurnsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingTurnsResponse" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="NextUri">NextUri.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="PreviousUri">PreviousUri.</param>
    public ReportingTurnsResponse(List<ReportingTurn> Entities = null, string NextUri = null, string SelfUri = null, string PreviousUri = null)
    {
        this.Entities = Entities;
        this.NextUri = NextUri;
        this.SelfUri = SelfUri;
        this.PreviousUri = PreviousUri;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<ReportingTurn> Entities { get; set; }



    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    [DataMember(Name = "nextUri", EmitDefaultValue = false)]
    public string NextUri { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    [DataMember(Name = "previousUri", EmitDefaultValue = false)]
    public string PreviousUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReportingTurnsResponse {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  NextUri: ").Append(NextUri).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
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
        return Equals(obj as ReportingTurnsResponse);
    }

    /// <summary>
    /// Returns true if ReportingTurnsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ReportingTurnsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReportingTurnsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                NextUri == other.NextUri ||
                NextUri != null &&
                NextUri.Equals(other.NextUri)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                PreviousUri == other.PreviousUri ||
                PreviousUri != null &&
                PreviousUri.Equals(other.PreviousUri)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (NextUri != null)
            {
                hash = hash * 59 + NextUri.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (PreviousUri != null)
            {
                hash = hash * 59 + PreviousUri.GetHashCode();
            }

            return hash;
        }
    }
}
