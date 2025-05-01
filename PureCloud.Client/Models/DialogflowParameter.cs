using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialogflowParameter
/// </summary>
[DataContract]
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
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The parameter type
    /// </summary>
    /// <value>The parameter type</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
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
        return this.Equals(obj as DialogflowParameter);
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
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
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
            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            return hash;
        }
    }
}
