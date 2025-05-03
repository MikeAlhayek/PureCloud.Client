using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Display attributes for an element in a journey view
/// </summary>

public partial class JourneyViewElementDisplayAttributes : IEquatable<JourneyViewElementDisplayAttributes>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElementDisplayAttributes" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewElementDisplayAttributes() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElementDisplayAttributes" /> class.
    /// </summary>
    /// <param name="X">The horizontal position (x-coordinate) of the element on the journey view canvas (required).</param>
    /// <param name="Y">The vertical position (y-coordinate) of the element on the journey view canvas (required).</param>
    /// <param name="Col">The column position for the element in the journey view canvas (required).</param>
    public JourneyViewElementDisplayAttributes(int? X = null, int? Y = null, int? Col = null)
    {
        this.X = X;
        this.Y = Y;
        this.Col = Col;

    }



    /// <summary>
    /// The horizontal position (x-coordinate) of the element on the journey view canvas
    /// </summary>
    /// <value>The horizontal position (x-coordinate) of the element on the journey view canvas</value>
    [JsonPropertyName("x")]
    public int? X { get; set; }



    /// <summary>
    /// The vertical position (y-coordinate) of the element on the journey view canvas
    /// </summary>
    /// <value>The vertical position (y-coordinate) of the element on the journey view canvas</value>
    [JsonPropertyName("y")]
    public int? Y { get; set; }



    /// <summary>
    /// The column position for the element in the journey view canvas
    /// </summary>
    /// <value>The column position for the element in the journey view canvas</value>
    [JsonPropertyName("col")]
    public int? Col { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewElementDisplayAttributes {\n");

        sb.Append("  X: ").Append(X).Append("\n");
        sb.Append("  Y: ").Append(Y).Append("\n");
        sb.Append("  Col: ").Append(Col).Append("\n");
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
        return Equals(obj as JourneyViewElementDisplayAttributes);
    }

    /// <summary>
    /// Returns true if JourneyViewElementDisplayAttributes instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewElementDisplayAttributes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewElementDisplayAttributes other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                X == other.X ||
                X != null &&
                X.Equals(other.X)
            ) &&
            (
                Y == other.Y ||
                Y != null &&
                Y.Equals(other.Y)
            ) &&
            (
                Col == other.Col ||
                Col != null &&
                Col.Equals(other.Col)
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
            if (X != null)
            {
                hash = hash * 59 + X.GetHashCode();
            }

            if (Y != null)
            {
                hash = hash * 59 + Y.GetHashCode();
            }

            if (Col != null)
            {
                hash = hash * 59 + Col.GetHashCode();
            }

            return hash;
        }
    }
}
