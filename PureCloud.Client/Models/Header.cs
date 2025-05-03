using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Header
/// </summary>

public partial class Header : IEquatable<Header>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Header" /> class.
    /// </summary>
    /// <param name="Name">Name of the header.</param>
    /// <param name="Value">Value of the header.</param>
    public Header(string Name = null, string Value = null)
    {
        this.Name = Name;
        this.Value = Value;

    }



    /// <summary>
    /// Name of the header
    /// </summary>
    /// <value>Name of the header</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Value of the header
    /// </summary>
    /// <value>Value of the header</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Header {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as Header);
    }

    /// <summary>
    /// Returns true if Header instances are equal
    /// </summary>
    /// <param name="other">Instance of Header to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Header other)
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
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
