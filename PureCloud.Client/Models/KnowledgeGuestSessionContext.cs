using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// KnowledgeGuestSessionContext
/// </summary>
[DataContract]
public partial class KnowledgeGuestSessionContext : IEquatable<KnowledgeGuestSessionContext>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestSessionContext" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeGuestSessionContext() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestSessionContext" /> class.
    /// </summary>
    /// <param name="Id">The context id associated with the session. (required).</param>
    /// <param name="Values">The list of knowledge context values associated with the session. (required).</param>
    public KnowledgeGuestSessionContext(string Id = null, List<Entity> Values = null)
    {
        this.Id = Id;
        this.Values = Values;

    }



    /// <summary>
    /// The context id associated with the session.
    /// </summary>
    /// <value>The context id associated with the session.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The list of knowledge context values associated with the session.
    /// </summary>
    /// <value>The list of knowledge context values associated with the session.</value>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<Entity> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeGuestSessionContext {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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
        return this.Equals(obj as KnowledgeGuestSessionContext);
    }

    /// <summary>
    /// Returns true if KnowledgeGuestSessionContext instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeGuestSessionContext to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeGuestSessionContext other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Values == other.Values ||
                this.Values != null &&
                this.Values.SequenceEqual(other.Values)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Values != null)
            {
                hash = hash * 59 + this.Values.GetHashCode();
            }

            return hash;
        }
    }
}
