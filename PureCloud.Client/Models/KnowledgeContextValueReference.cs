using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeContextValueReference
/// </summary>
[DataContract]
public partial class KnowledgeContextValueReference : IEquatable<KnowledgeContextValueReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeContextValueReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeContextValueReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeContextValueReference" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the knowledge context value. (required).</param>
    public KnowledgeContextValueReference(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// The globally unique identifier for the knowledge context value.
    /// </summary>
    /// <value>The globally unique identifier for the knowledge context value.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeContextValueReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as KnowledgeContextValueReference);
    }

    /// <summary>
    /// Returns true if KnowledgeContextValueReference instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeContextValueReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeContextValueReference other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
