using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DraftTopicRequest
/// </summary>
[DataContract]
public partial class DraftTopicRequest : IEquatable<DraftTopicRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DraftTopicRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DraftTopicRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DraftTopicRequest" /> class.
    /// </summary>
    /// <param name="Id">Id for a topic. (required).</param>
    /// <param name="Name">Name/Label for a topic. (required).</param>
    /// <param name="Phrases">The phrases that are extracted for a topic. (required).</param>
    public DraftTopicRequest(string Id = null, string Name = null, List<string> Phrases = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Phrases = Phrases;

    }



    /// <summary>
    /// Id for a topic.
    /// </summary>
    /// <value>Id for a topic.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Name/Label for a topic.
    /// </summary>
    /// <value>Name/Label for a topic.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The phrases that are extracted for a topic.
    /// </summary>
    /// <value>The phrases that are extracted for a topic.</value>
    [DataMember(Name = "phrases", EmitDefaultValue = false)]
    public List<string> Phrases { get; set; }



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
        sb.Append("class DraftTopicRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Phrases: ").Append(Phrases).Append("\n");
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
        return Equals(obj as DraftTopicRequest);
    }

    /// <summary>
    /// Returns true if DraftTopicRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of DraftTopicRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DraftTopicRequest other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Phrases == other.Phrases ||
                Phrases != null &&
                Phrases.SequenceEqual(other.Phrases)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Phrases != null)
            {
                hash = hash * 59 + Phrases.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
