using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A summary description for a botConnector bot
/// </summary>

public partial class BotSummary : IEquatable<BotSummary>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BotSummary" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BotSummary() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BotSummary" /> class.
    /// </summary>
    /// <param name="Name">The name of the bot. (required).</param>
    /// <param name="Id">The id of the bot. (required).</param>
    /// <param name="Description">An optional description of the bot..</param>
    public BotSummary(string Name = null, string Id = null, string Description = null)
    {
        this.Name = Name;
        this.Id = Id;
        this.Description = Description;

    }



    /// <summary>
    /// The name of the bot.
    /// </summary>
    /// <value>The name of the bot.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The id of the bot.
    /// </summary>
    /// <value>The id of the bot.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// An optional description of the bot.
    /// </summary>
    /// <value>An optional description of the bot.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// A system-generated string that contains metadata about this bot.
    /// </summary>
    /// <value>A system-generated string that contains metadata about this bot.</value>
    [JsonPropertyName("botCompositeTag")]
    public string BotCompositeTag { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BotSummary {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  BotCompositeTag: ").Append(BotCompositeTag).Append("\n");
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
        return Equals(obj as BotSummary);
    }

    /// <summary>
    /// Returns true if BotSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of BotSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BotSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                BotCompositeTag == other.BotCompositeTag ||
                BotCompositeTag != null &&
                BotCompositeTag.Equals(other.BotCompositeTag)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (BotCompositeTag != null)
            {
                hash = hash * 59 + BotCompositeTag.GetHashCode();
            }

            return hash;
        }
    }
}
