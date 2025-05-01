using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A version summary for a botConnector bot.
/// </summary>
[DataContract]
public partial class BotVersionSummary : IEquatable<BotVersionSummary>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BotVersionSummary" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BotVersionSummary() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BotVersionSummary" /> class.
    /// </summary>
    /// <param name="Name">The name of the bot. (required).</param>
    /// <param name="Id">The id of the bot. (required).</param>
    /// <param name="Description">An optional description of the bot..</param>
    /// <param name="Version">The name of the version. (required).</param>
    public BotVersionSummary(string Name = null, string Id = null, string Description = null, string Version = null)
    {
        this.Name = Name;
        this.Id = Id;
        this.Description = Description;
        this.Version = Version;

    }



    /// <summary>
    /// The name of the bot.
    /// </summary>
    /// <value>The name of the bot.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The id of the bot.
    /// </summary>
    /// <value>The id of the bot.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// An optional description of the bot.
    /// </summary>
    /// <value>An optional description of the bot.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// A system-generated string that contains metadata about this bot.
    /// </summary>
    /// <value>A system-generated string that contains metadata about this bot.</value>
    [DataMember(Name = "botCompositeTag", EmitDefaultValue = false)]
    public string BotCompositeTag { get; private set; }



    /// <summary>
    /// The name of the version.
    /// </summary>
    /// <value>The name of the version.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BotVersionSummary {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  BotCompositeTag: ").Append(BotCompositeTag).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as BotVersionSummary);
    }

    /// <summary>
    /// Returns true if BotVersionSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of BotVersionSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BotVersionSummary other)
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
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
