using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluConfusionMatrixColumn
/// </summary>

public partial class NluConfusionMatrixColumn : IEquatable<NluConfusionMatrixColumn>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluConfusionMatrixColumn" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluConfusionMatrixColumn() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluConfusionMatrixColumn" /> class.
    /// </summary>
    /// <param name="Name">The name of the intent for the column. (required).</param>
    /// <param name="Value">The confusion value between the intents (required).</param>
    public NluConfusionMatrixColumn(string Name = null, float? Value = null)
    {
        this.Name = Name;
        this.Value = Value;

    }



    /// <summary>
    /// The name of the intent for the column.
    /// </summary>
    /// <value>The name of the intent for the column.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The confusion value between the intents
    /// </summary>
    /// <value>The confusion value between the intents</value>
    [JsonPropertyName("value")]
    public float? Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluConfusionMatrixColumn {\n");

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
        return Equals(obj as NluConfusionMatrixColumn);
    }

    /// <summary>
    /// Returns true if NluConfusionMatrixColumn instances are equal
    /// </summary>
    /// <param name="other">Instance of NluConfusionMatrixColumn to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluConfusionMatrixColumn other)
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
