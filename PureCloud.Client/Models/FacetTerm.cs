using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// FacetTerm
/// </summary>
[DataContract]
public partial class FacetTerm : IEquatable<FacetTerm>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FacetTerm" /> class.
    /// </summary>
    /// <param name="Term">Term.</param>
    /// <param name="Key">Key.</param>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Count">Count.</param>
    /// <param name="Time">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public FacetTerm(string Term = null, long? Key = null, string Id = null, string Name = null, long? Count = null, DateTime? Time = null)
    {
        this.Term = Term;
        this.Key = Key;
        this.Id = Id;
        this.Name = Name;
        this.Count = Count;
        this.Time = Time;

    }



    /// <summary>
    /// Gets or Sets Term
    /// </summary>
    [DataMember(Name = "term", EmitDefaultValue = false)]
    public string Term { get; set; }



    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name = "key", EmitDefaultValue = false)]
    public long? Key { get; set; }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name = "count", EmitDefaultValue = false)]
    public long? Count { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "time", EmitDefaultValue = false)]
    public DateTime? Time { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FacetTerm {\n");

        sb.Append("  Term: ").Append(Term).Append("\n");
        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
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
        return Equals(obj as FacetTerm);
    }

    /// <summary>
    /// Returns true if FacetTerm instances are equal
    /// </summary>
    /// <param name="other">Instance of FacetTerm to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FacetTerm other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Term == other.Term ||
                Term != null &&
                Term.Equals(other.Term)
            ) &&
            (
                Key == other.Key ||
                Key != null &&
                Key.Equals(other.Key)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
            ) &&
            (
                Time == other.Time ||
                Time != null &&
                Time.Equals(other.Time)
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
            if (Term != null)
            {
                hash = hash * 59 + Term.GetHashCode();
            }

            if (Key != null)
            {
                hash = hash * 59 + Key.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            if (Time != null)
            {
                hash = hash * 59 + Time.GetHashCode();
            }

            return hash;
        }
    }
}
