using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkJobAddRequest
/// </summary>

public partial class BulkJobAddRequest : IEquatable<BulkJobAddRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BulkJobAddRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BulkJobAddRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkJobAddRequest" /> class.
    /// </summary>
    /// <param name="Entities">The list of workitem entities to create. (required).</param>
    public BulkJobAddRequest(List<WorkitemCommonCreate> Entities = null)
    {
        this.Entities = Entities;

    }



    /// <summary>
    /// The list of workitem entities to create.
    /// </summary>
    /// <value>The list of workitem entities to create.</value>
    [JsonPropertyName("entities")]
    public List<WorkitemCommonCreate> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkJobAddRequest {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as BulkJobAddRequest);
    }

    /// <summary>
    /// Returns true if BulkJobAddRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkJobAddRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkJobAddRequest other)
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

            return hash;
        }
    }
}
