using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentIntegrationAssociationRequest
/// </summary>

public partial class AgentIntegrationAssociationRequest : IEquatable<AgentIntegrationAssociationRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentIntegrationAssociationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentIntegrationAssociationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentIntegrationAssociationRequest" /> class.
    /// </summary>
    /// <param name="AgentExternalId">The ID of the agent in external system (required).</param>
    /// <param name="IntegrationId">The ID of the integration associated with the agent (required).</param>
    /// <param name="Locked">Whether agentExternalId should be protected from update by automatic processes (required).</param>
    public AgentIntegrationAssociationRequest(string AgentExternalId = null, string IntegrationId = null, bool? Locked = null)
    {
        this.AgentExternalId = AgentExternalId;
        this.IntegrationId = IntegrationId;
        this.Locked = Locked;

    }



    /// <summary>
    /// The ID of the agent in external system
    /// </summary>
    /// <value>The ID of the agent in external system</value>
    [JsonPropertyName("agentExternalId")]
    public string AgentExternalId { get; set; }



    /// <summary>
    /// The ID of the integration associated with the agent
    /// </summary>
    /// <value>The ID of the integration associated with the agent</value>
    [JsonPropertyName("integrationId")]
    public string IntegrationId { get; set; }



    /// <summary>
    /// Whether agentExternalId should be protected from update by automatic processes
    /// </summary>
    /// <value>Whether agentExternalId should be protected from update by automatic processes</value>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentIntegrationAssociationRequest {\n");

        sb.Append("  AgentExternalId: ").Append(AgentExternalId).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  Locked: ").Append(Locked).Append("\n");
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
        return Equals(obj as AgentIntegrationAssociationRequest);
    }

    /// <summary>
    /// Returns true if AgentIntegrationAssociationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentIntegrationAssociationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentIntegrationAssociationRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AgentExternalId == other.AgentExternalId ||
                AgentExternalId != null &&
                AgentExternalId.Equals(other.AgentExternalId)
            ) &&
            (
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
            ) &&
            (
                Locked == other.Locked ||
                Locked != null &&
                Locked.Equals(other.Locked)
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
            if (AgentExternalId != null)
            {
                hash = hash * 59 + AgentExternalId.GetHashCode();
            }

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            if (Locked != null)
            {
                hash = hash * 59 + Locked.GetHashCode();
            }

            return hash;
        }
    }
}
