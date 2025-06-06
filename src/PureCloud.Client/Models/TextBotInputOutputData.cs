using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Input/Output data related to a bot flow which is exiting gracefully.
/// </summary>

public partial class TextBotInputOutputData : IEquatable<TextBotInputOutputData>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotInputOutputData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotInputOutputData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotInputOutputData" /> class.
    /// </summary>
    /// <param name="Variables">The input/output variables using the format as appropriate for the variable data type in the flow definition. (required).</param>
    public TextBotInputOutputData(Dictionary<string, object> Variables = null)
    {
        this.Variables = Variables;

    }



    /// <summary>
    /// The input/output variables using the format as appropriate for the variable data type in the flow definition.
    /// </summary>
    /// <value>The input/output variables using the format as appropriate for the variable data type in the flow definition.</value>
    [JsonPropertyName("variables")]
    public Dictionary<string, object> Variables { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotInputOutputData {\n");

        sb.Append("  Variables: ").Append(Variables).Append("\n");
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
        return Equals(obj as TextBotInputOutputData);
    }

    /// <summary>
    /// Returns true if TextBotInputOutputData instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotInputOutputData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotInputOutputData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Variables == other.Variables ||
                Variables != null &&
                Variables.SequenceEqual(other.Variables)
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
            if (Variables != null)
            {
                hash = hash * 59 + Variables.GetHashCode();
            }

            return hash;
        }
    }
}
