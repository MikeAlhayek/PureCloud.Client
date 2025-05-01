using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgramsEntityListing
/// </summary>
[DataContract]
public partial class ProgramsEntityListing : IEquatable<ProgramsEntityListing>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramsEntityListing" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="PageSize">PageSize.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="NextUri">NextUri.</param>
    /// <param name="PageCount">PageCount.</param>
    public ProgramsEntityListing(List<ListedProgram> Entities = null, int? PageSize = null, string SelfUri = null, string NextUri = null, int? PageCount = null)
    {
        this.Entities = Entities;
        this.PageSize = PageSize;
        this.SelfUri = SelfUri;
        this.NextUri = NextUri;
        this.PageCount = PageCount;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<ListedProgram> Entities { get; set; }



    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    [DataMember(Name = "nextUri", EmitDefaultValue = false)]
    public string NextUri { get; set; }



    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    [DataMember(Name = "pageCount", EmitDefaultValue = false)]
    public int? PageCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProgramsEntityListing {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  NextUri: ").Append(NextUri).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
        return Equals(obj as ProgramsEntityListing);
    }

    /// <summary>
    /// Returns true if ProgramsEntityListing instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgramsEntityListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgramsEntityListing other)
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
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                NextUri == other.NextUri ||
                NextUri != null &&
                NextUri.Equals(other.NextUri)
            ) &&
            (
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
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

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (NextUri != null)
            {
                hash = hash * 59 + NextUri.GetHashCode();
            }

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            return hash;
        }
    }
}
