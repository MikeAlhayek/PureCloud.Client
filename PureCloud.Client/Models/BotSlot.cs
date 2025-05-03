using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Description of a data value returned from an intent
/// </summary>

public partial class BotSlot : IEquatable<BotSlot>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BotSlot" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BotSlot() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BotSlot" /> class.
    /// </summary>
    /// <param name="Name">The name of the slot. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace (required).</param>
    /// <param name="Type">The data type of the slot string, integer, decimal, duration, boolean, currency, datetime or the xxxCollection versions of those types (required).</param>
    public BotSlot(string Name = null, string Type = null)
    {
        this.Name = Name;
        this.Type = Type;

    }



    /// <summary>
    /// The name of the slot. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace
    /// </summary>
    /// <value>The name of the slot. This can be up to 100 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The data type of the slot string, integer, decimal, duration, boolean, currency, datetime or the xxxCollection versions of those types
    /// </summary>
    /// <value>The data type of the slot string, integer, decimal, duration, boolean, currency, datetime or the xxxCollection versions of those types</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BotSlot {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as BotSlot);
    }

    /// <summary>
    /// Returns true if BotSlot instances are equal
    /// </summary>
    /// <param name="other">Instance of BotSlot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BotSlot other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
