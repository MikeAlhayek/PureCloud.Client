using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Record
/// </summary>

public partial class Record : IEquatable<Record>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Record" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Record() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Record" /> class.
    /// </summary>
    /// <param name="Name">The name of the record. (required).</param>
    /// <param name="Type">The type of the record. (Example values:  MX, TXT, CNAME) (required).</param>
    /// <param name="Value">The value of the record. (required).</param>
    public Record(string Name = null, string Type = null, string Value = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Value = Value;

    }



    /// <summary>
    /// The name of the record.
    /// </summary>
    /// <value>The name of the record.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The type of the record. (Example values:  MX, TXT, CNAME)
    /// </summary>
    /// <value>The type of the record. (Example values:  MX, TXT, CNAME)</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// The value of the record.
    /// </summary>
    /// <value>The value of the record.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Record {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as Record);
    }

    /// <summary>
    /// Returns true if Record instances are equal
    /// </summary>
    /// <param name="other">Instance of Record to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Record other)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
