using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Variable type information about a complex type from the bot&#39;s definition
/// </summary>

public partial class ComplexVariableInfo : IEquatable<ComplexVariableInfo>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ComplexVariableInfo" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ComplexVariableInfo() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ComplexVariableInfo" /> class.
    /// </summary>
    /// <param name="Id">The variable type ID (required).</param>
    /// <param name="Name">The variable type display name (required).</param>
    public ComplexVariableInfo(string Id = null, string Name = null)
    {
        this.Id = Id;
        this.Name = Name;

    }



    /// <summary>
    /// The variable type ID
    /// </summary>
    /// <value>The variable type ID</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The variable type display name
    /// </summary>
    /// <value>The variable type display name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ComplexVariableInfo {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as ComplexVariableInfo);
    }

    /// <summary>
    /// Returns true if ComplexVariableInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of ComplexVariableInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ComplexVariableInfo other)
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

            return hash;
        }
    }
}
