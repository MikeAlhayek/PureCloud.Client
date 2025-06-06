using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialogflowParameter
/// </summary>

public partial class DialogflowParameter : IEquatable<DialogflowParameter>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DialogflowParameter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DialogflowParameter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialogflowParameter" /> class.
    /// </summary>
    /// <param name="Name">The parameter name (required).</param>
    /// <param name="Type">The parameter type (required).</param>
    public DialogflowParameter(string Name = null, string Type = null)
    {
        this.Name = Name;
        this.Type = Type;

    }



    /// <summary>
    /// The parameter name
    /// </summary>
    /// <value>The parameter name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The parameter type
    /// </summary>
    /// <value>The parameter type</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialogflowParameter {\n");

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
        return Equals(obj as DialogflowParameter);
    }

    /// <summary>
    /// Returns true if DialogflowParameter instances are equal
    /// </summary>
    /// <param name="other">Instance of DialogflowParameter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialogflowParameter other)
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
