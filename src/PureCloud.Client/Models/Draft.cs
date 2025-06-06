using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Draft
/// </summary>

public partial class Draft : IEquatable<Draft>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Draft" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Draft() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Draft" /> class.
    /// </summary>
    /// <param name="Name">Draft name (required).</param>
    public Draft(string Name = null)
    {
        this.Name = Name;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Draft name
    /// </summary>
    /// <value>Draft name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Miner to which the draft belongs.
    /// </summary>
    /// <value>Miner to which the draft belongs.</value>
    [JsonPropertyName("miner")]
    public Miner Miner { get; set; }



    /// <summary>
    /// Draft intent object.
    /// </summary>
    /// <value>Draft intent object.</value>
    [JsonPropertyName("intents")]
    public List<DraftIntents> Intents { get; set; }



    /// <summary>
    /// Draft topic object.
    /// </summary>
    /// <value>Draft topic object.</value>
    [JsonPropertyName("topics")]
    public List<DraftTopics> Topics { get; set; }



    /// <summary>
    /// Date when the draft was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the draft was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date when the draft was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the draft was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Draft {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Miner: ").Append(Miner).Append("\n");
        sb.Append("  Intents: ").Append(Intents).Append("\n");
        sb.Append("  Topics: ").Append(Topics).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as Draft);
    }

    /// <summary>
    /// Returns true if Draft instances are equal
    /// </summary>
    /// <param name="other">Instance of Draft to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Draft other)
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
                Miner == other.Miner ||
                Miner != null &&
                Miner.Equals(other.Miner)
            ) &&
            (
                Intents == other.Intents ||
                Intents != null &&
                Intents.SequenceEqual(other.Intents)
            ) &&
            (
                Topics == other.Topics ||
                Topics != null &&
                Topics.SequenceEqual(other.Topics)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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

            if (Miner != null)
            {
                hash = hash * 59 + Miner.GetHashCode();
            }

            if (Intents != null)
            {
                hash = hash * 59 + Intents.GetHashCode();
            }

            if (Topics != null)
            {
                hash = hash * 59 + Topics.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
