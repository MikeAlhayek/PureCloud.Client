using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentStateCountsRequest
/// </summary>
[DataContract]
public partial class AgentStateCountsRequest : IEquatable<AgentStateCountsRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentStateCountsRequest" /> class.
    /// </summary>
    /// <param name="UserFilter">Filters that target user-level data.</param>
    /// <param name="SessionFilter">Filters that target session-level data.</param>
    public AgentStateCountsRequest(AgentStateUserFilter UserFilter = null, AgentStateSessionFilter SessionFilter = null)
    {
        this.UserFilter = UserFilter;
        this.SessionFilter = SessionFilter;

    }



    /// <summary>
    /// Filters that target user-level data
    /// </summary>
    /// <value>Filters that target user-level data</value>
    [DataMember(Name = "userFilter", EmitDefaultValue = false)]
    public AgentStateUserFilter UserFilter { get; set; }



    /// <summary>
    /// Filters that target session-level data
    /// </summary>
    /// <value>Filters that target session-level data</value>
    [DataMember(Name = "sessionFilter", EmitDefaultValue = false)]
    public AgentStateSessionFilter SessionFilter { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentStateCountsRequest {\n");

        sb.Append("  UserFilter: ").Append(UserFilter).Append("\n");
        sb.Append("  SessionFilter: ").Append(SessionFilter).Append("\n");
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
        return Equals(obj as AgentStateCountsRequest);
    }

    /// <summary>
    /// Returns true if AgentStateCountsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentStateCountsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentStateCountsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserFilter == other.UserFilter ||
                UserFilter != null &&
                UserFilter.Equals(other.UserFilter)
            ) &&
            (
                SessionFilter == other.SessionFilter ||
                SessionFilter != null &&
                SessionFilter.Equals(other.SessionFilter)
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
            if (UserFilter != null)
            {
                hash = hash * 59 + UserFilter.GetHashCode();
            }

            if (SessionFilter != null)
            {
                hash = hash * 59 + SessionFilter.GetHashCode();
            }

            return hash;
        }
    }
}
