using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RequestScoredAgent
/// </summary>
[DataContract]
public partial class RequestScoredAgent : IEquatable<RequestScoredAgent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RequestScoredAgent" /> class.
    /// </summary>
    /// <param name="Id">Agent&#39;s user ID.</param>
    /// <param name="Score">Agent&#39;s score for the current conversation, from 0 - 100, higher being better.</param>
    public RequestScoredAgent(string Id = null, int? Score = null)
    {
        this.Id = Id;
        this.Score = Score;

    }



    /// <summary>
    /// Agent&#39;s user ID
    /// </summary>
    /// <value>Agent&#39;s user ID</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Agent&#39;s score for the current conversation, from 0 - 100, higher being better
    /// </summary>
    /// <value>Agent&#39;s score for the current conversation, from 0 - 100, higher being better</value>
    [DataMember(Name = "score", EmitDefaultValue = false)]
    public int? Score { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RequestScoredAgent {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as RequestScoredAgent);
    }

    /// <summary>
    /// Returns true if RequestScoredAgent instances are equal
    /// </summary>
    /// <param name="other">Instance of RequestScoredAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RequestScoredAgent other)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Score != null)
            {
                hash = hash * 59 + Score.GetHashCode();
            }

            return hash;
        }
    }
}
