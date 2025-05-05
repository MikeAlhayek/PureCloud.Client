using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentOwnedMappingPreview
/// </summary>

public partial class AgentOwnedMappingPreview : IEquatable<AgentOwnedMappingPreview>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentOwnedMappingPreview" /> class.
    /// </summary>
    public AgentOwnedMappingPreview()
    {

    }



    /// <summary>
    /// The raw value of the agent-owned column
    /// </summary>
    /// <value>The raw value of the agent-owned column</value>
    [JsonPropertyName("agentOwnedColumn")]
    public string AgentOwnedColumn { get; private set; }



    /// <summary>
    /// The email address of the user, if it exists
    /// </summary>
    /// <value>The email address of the user, if it exists</value>
    [JsonPropertyName("email")]
    public string Email { get; private set; }



    /// <summary>
    /// The id of the user, if it exists
    /// </summary>
    /// <value>The id of the user, if it exists</value>
    [JsonPropertyName("userId")]
    public string UserId { get; private set; }



    /// <summary>
    /// Whether the user exists
    /// </summary>
    /// <value>Whether the user exists</value>
    [JsonPropertyName("exists")]
    public bool? Exists { get; private set; }



    /// <summary>
    /// Whether the user is a member of the campaign&#39;s queue
    /// </summary>
    /// <value>Whether the user is a member of the campaign&#39;s queue</value>
    [JsonPropertyName("isQueueMember")]
    public bool? IsQueueMember { get; private set; }



    /// <summary>
    /// The number of contact records whose agent-owned column matches the raw value
    /// </summary>
    /// <value>The number of contact records whose agent-owned column matches the raw value</value>
    [JsonPropertyName("recordCount")]
    public int? RecordCount { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentOwnedMappingPreview {\n");

        sb.Append("  AgentOwnedColumn: ").Append(AgentOwnedColumn).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Exists: ").Append(Exists).Append("\n");
        sb.Append("  IsQueueMember: ").Append(IsQueueMember).Append("\n");
        sb.Append("  RecordCount: ").Append(RecordCount).Append("\n");
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
        return Equals(obj as AgentOwnedMappingPreview);
    }

    /// <summary>
    /// Returns true if AgentOwnedMappingPreview instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentOwnedMappingPreview to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentOwnedMappingPreview other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AgentOwnedColumn == other.AgentOwnedColumn ||
                AgentOwnedColumn != null &&
                AgentOwnedColumn.Equals(other.AgentOwnedColumn)
            ) &&
            (
                Email == other.Email ||
                Email != null &&
                Email.Equals(other.Email)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                Exists == other.Exists ||
                Exists != null &&
                Exists.Equals(other.Exists)
            ) &&
            (
                IsQueueMember == other.IsQueueMember ||
                IsQueueMember != null &&
                IsQueueMember.Equals(other.IsQueueMember)
            ) &&
            (
                RecordCount == other.RecordCount ||
                RecordCount != null &&
                RecordCount.Equals(other.RecordCount)
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
            if (AgentOwnedColumn != null)
            {
                hash = hash * 59 + AgentOwnedColumn.GetHashCode();
            }

            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (Exists != null)
            {
                hash = hash * 59 + Exists.GetHashCode();
            }

            if (IsQueueMember != null)
            {
                hash = hash * 59 + IsQueueMember.GetHashCode();
            }

            if (RecordCount != null)
            {
                hash = hash * 59 + RecordCount.GetHashCode();
            }

            return hash;
        }
    }
}
