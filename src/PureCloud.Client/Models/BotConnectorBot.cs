using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A botConnector Bot Instance
/// </summary>

public partial class BotConnectorBot : IEquatable<BotConnectorBot>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BotConnectorBot" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BotConnectorBot() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BotConnectorBot" /> class.
    /// </summary>
    /// <param name="Id">The Botconnector Bot Id - this is configurable by the user when put (required).</param>
    /// <param name="Name">Name.</param>
    /// <param name="Description">An optional description of the bot.  This can be up to 256 characters long and must be comprised of displayable characters without leading or trailing whitespace.</param>
    /// <param name="Versions">This bots versions, limit of 50 per bot (required).</param>
    public BotConnectorBot(string Id = null, string Name = null, string Description = null, List<BotConnectorBotVersion> Versions = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Versions = Versions;

    }



    /// <summary>
    /// The Botconnector Bot Id - this is configurable by the user when put
    /// </summary>
    /// <value>The Botconnector Bot Id - this is configurable by the user when put</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// An optional description of the bot.  This can be up to 256 characters long and must be comprised of displayable characters without leading or trailing whitespace
    /// </summary>
    /// <value>An optional description of the bot.  This can be up to 256 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// This bots versions, limit of 50 per bot
    /// </summary>
    /// <value>This bots versions, limit of 50 per bot</value>
    [JsonPropertyName("versions")]
    public List<BotConnectorBotVersion> Versions { get; set; }



    /// <summary>
    /// A system-generated string that contains metadata about this bot.
    /// </summary>
    /// <value>A system-generated string that contains metadata about this bot.</value>
    [JsonPropertyName("botCompositeTag")]
    public string BotCompositeTag { get; set; }



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
        sb.Append("class BotConnectorBot {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Versions: ").Append(Versions).Append("\n");
        sb.Append("  BotCompositeTag: ").Append(BotCompositeTag).Append("\n");
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
        return Equals(obj as BotConnectorBot);
    }

    /// <summary>
    /// Returns true if BotConnectorBot instances are equal
    /// </summary>
    /// <param name="other">Instance of BotConnectorBot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BotConnectorBot other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Versions == other.Versions ||
                Versions != null &&
                Versions.SequenceEqual(other.Versions)
            ) &&
            (
                BotCompositeTag == other.BotCompositeTag ||
                BotCompositeTag != null &&
                BotCompositeTag.Equals(other.BotCompositeTag)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Versions != null)
            {
                hash = hash * 59 + Versions.GetHashCode();
            }

            if (BotCompositeTag != null)
            {
                hash = hash * 59 + BotCompositeTag.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
