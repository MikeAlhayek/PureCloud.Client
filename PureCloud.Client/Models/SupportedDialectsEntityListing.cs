using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportedDialectsEntityListing
/// </summary>
[DataContract]
public partial class SupportedDialectsEntityListing : IEquatable<SupportedDialectsEntityListing>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportedDialectsEntityListing" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    public SupportedDialectsEntityListing(List<SupportedDialectsTranscriptionEngine> Entities = null)
    {
        this.Entities = Entities;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<SupportedDialectsTranscriptionEngine> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportedDialectsEntityListing {\n");

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
        return Equals(obj as SupportedDialectsEntityListing);
    }

    /// <summary>
    /// Returns true if SupportedDialectsEntityListing instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportedDialectsEntityListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportedDialectsEntityListing other)
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
