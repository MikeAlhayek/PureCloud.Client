using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentCopilotAsyncAggregateQueryResponse
/// </summary>
[DataContract]
public partial class AgentCopilotAsyncAggregateQueryResponse : IEquatable<AgentCopilotAsyncAggregateQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentCopilotAsyncAggregateQueryResponse" /> class.
    /// </summary>
    /// <param name="Results">Results.</param>
    /// <param name="Cursor">Cursor token to retrieve next page.</param>
    public AgentCopilotAsyncAggregateQueryResponse(List<AgentCopilotAggregateDataContainer> Results = null, string Cursor = null)
    {
        this.Results = Results;
        this.Cursor = Cursor;

    }



    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public List<AgentCopilotAggregateDataContainer> Results { get; set; }



    /// <summary>
    /// Cursor token to retrieve next page
    /// </summary>
    /// <value>Cursor token to retrieve next page</value>
    [DataMember(Name = "cursor", EmitDefaultValue = false)]
    public string Cursor { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentCopilotAsyncAggregateQueryResponse {\n");

        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
        return Equals(obj as AgentCopilotAsyncAggregateQueryResponse);
    }

    /// <summary>
    /// Returns true if AgentCopilotAsyncAggregateQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentCopilotAsyncAggregateQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentCopilotAsyncAggregateQueryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
            ) &&
            (
                Cursor == other.Cursor ||
                Cursor != null &&
                Cursor.Equals(other.Cursor)
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
            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (Cursor != null)
            {
                hash = hash * 59 + Cursor.GetHashCode();
            }

            return hash;
        }
    }
}
