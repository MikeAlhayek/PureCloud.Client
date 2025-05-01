using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestCompleteDataScore
/// </summary>
[DataContract]
public partial class ContestCompleteDataScore : IEquatable<ContestCompleteDataScore>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestCompleteDataScore" /> class.
    /// </summary>
    /// <param name="Score">The Contest score.</param>
    public ContestCompleteDataScore(double? Score = null)
    {
        this.Score = Score;

    }



    /// <summary>
    /// The Contest score
    /// </summary>
    /// <value>The Contest score</value>
    [DataMember(Name = "score", EmitDefaultValue = false)]
    public double? Score { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestCompleteDataScore {\n");

        sb.Append("  Score: ").Append(Score).Append("\n");
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
        return Equals(obj as ContestCompleteDataScore);
    }

    /// <summary>
    /// Returns true if ContestCompleteDataScore instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestCompleteDataScore to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestCompleteDataScore other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Score == other.Score ||
                Score != null &&
                Score.Equals(other.Score)
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
            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            return hash;
        }
    }
}
