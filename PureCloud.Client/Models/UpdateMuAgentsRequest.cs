using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateMuAgentsRequest
/// </summary>
[DataContract]
public partial class UpdateMuAgentsRequest : IEquatable<UpdateMuAgentsRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateMuAgentsRequest" /> class.
    /// </summary>
    /// <param name="Entities">List of agents to update.</param>
    public UpdateMuAgentsRequest(List<UpdateMuAgentRequest> Entities = null)
    {
        this.Entities = Entities;

    }



    /// <summary>
    /// List of agents to update
    /// </summary>
    /// <value>List of agents to update</value>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<UpdateMuAgentRequest> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateMuAgentsRequest {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as UpdateMuAgentsRequest);
    }

    /// <summary>
    /// Returns true if UpdateMuAgentsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateMuAgentsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateMuAgentsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}
