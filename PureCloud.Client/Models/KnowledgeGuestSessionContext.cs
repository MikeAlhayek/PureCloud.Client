using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeGuestSessionContext
/// </summary>

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
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The list of knowledge context values associated with the session.
    /// </summary>
    /// <value>The list of knowledge context values associated with the session.</value>
    [JsonPropertyName("values")]
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
        return Equals(obj as KnowledgeGuestSessionContext);
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
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
