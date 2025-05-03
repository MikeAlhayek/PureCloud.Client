using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LexV2Bot
/// </summary>

public partial class LexV2Bot : IEquatable<LexV2Bot>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LexV2Bot" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LexV2Bot() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LexV2Bot" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="BotId">Lex V2 bot Id (required).</param>
    /// <param name="Region">A region of the Lex V2 bot (required).</param>
    /// <param name="Description">A description of the Lex V2 bot.</param>
    public LexV2Bot(string Name = null, string BotId = null, string Region = null, string Description = null)
    {
        this.Name = Name;
        this.BotId = BotId;
        this.Region = Region;
        this.Description = Description;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Lex V2 bot Id
    /// </summary>
    /// <value>Lex V2 bot Id</value>
    [JsonPropertyName("botId")]
    public string BotId { get; set; }



    /// <summary>
    /// A region of the Lex V2 bot
    /// </summary>
    /// <value>A region of the Lex V2 bot</value>
    [JsonPropertyName("region")]
    public string Region { get; set; }



    /// <summary>
    /// A description of the Lex V2 bot
    /// </summary>
    /// <value>A description of the Lex V2 bot</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LexV2Bot {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  BotId: ").Append(BotId).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as LexV2Bot);
    }

    /// <summary>
    /// Returns true if LexV2Bot instances are equal
    /// </summary>
    /// <param name="other">Instance of LexV2Bot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LexV2Bot other)
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
                BotId == other.BotId ||
                BotId != null &&
                BotId.Equals(other.BotId)
            ) &&
            (
                Region == other.Region ||
                Region != null &&
                Region.Equals(other.Region)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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

            if (BotId != null)
            {
                hash = hash * 59 + BotId.GetHashCode();
            }

            if (Region != null)
            {
                hash = hash * 59 + Region.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
