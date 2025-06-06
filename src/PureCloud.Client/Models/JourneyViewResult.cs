using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A journey view result
/// </summary>

public partial class JourneyViewResult : IEquatable<JourneyViewResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewResult" /> class.
    /// </summary>
    public JourneyViewResult()
    {

    }



    /// <summary>
    /// The elements within the journey view result
    /// </summary>
    /// <value>The elements within the journey view result</value>
    [JsonPropertyName("elements")]
    public List<JourneyViewResultElement> Elements { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewResult {\n");

        sb.Append("  Elements: ").Append(Elements).Append("\n");
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
        return Equals(obj as JourneyViewResult);
    }

    /// <summary>
    /// Returns true if JourneyViewResult instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Elements == other.Elements ||
                Elements != null &&
                Elements.SequenceEqual(other.Elements)
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
            if (Elements != null)
            {
                hash = hash * 59 + Elements.GetHashCode();
            }

            return hash;
        }
    }
}
