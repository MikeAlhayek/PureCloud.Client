using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentIntegrationsRequest
/// </summary>

public partial class AgentIntegrationsRequest : IEquatable<AgentIntegrationsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentIntegrationsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentIntegrationsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentIntegrationsRequest" /> class.
    /// </summary>
    /// <param name="SelectedIntegrationId">The ID of the integration selected for the agent. If not set, no integration will be used for the agent.</param>
    /// <param name="AssociatedIntegrations">The list of integrations associated with the agent (required).</param>
    public AgentIntegrationsRequest(string SelectedIntegrationId = null, List<AgentIntegrationAssociationRequest> AssociatedIntegrations = null)
    {
        this.SelectedIntegrationId = SelectedIntegrationId;
        this.AssociatedIntegrations = AssociatedIntegrations;

    }



    /// <summary>
    /// The ID of the integration selected for the agent. If not set, no integration will be used for the agent
    /// </summary>
    /// <value>The ID of the integration selected for the agent. If not set, no integration will be used for the agent</value>
    [JsonPropertyName("selectedIntegrationId")]
    public string SelectedIntegrationId { get; set; }



    /// <summary>
    /// The list of integrations associated with the agent
    /// </summary>
    /// <value>The list of integrations associated with the agent</value>
    [JsonPropertyName("associatedIntegrations")]
    public List<AgentIntegrationAssociationRequest> AssociatedIntegrations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentIntegrationsRequest {\n");

        sb.Append("  SelectedIntegrationId: ").Append(SelectedIntegrationId).Append("\n");
        sb.Append("  AssociatedIntegrations: ").Append(AssociatedIntegrations).Append("\n");
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
        return Equals(obj as AgentIntegrationsRequest);
    }

    /// <summary>
    /// Returns true if AgentIntegrationsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentIntegrationsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentIntegrationsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SelectedIntegrationId == other.SelectedIntegrationId ||
                SelectedIntegrationId != null &&
                SelectedIntegrationId.Equals(other.SelectedIntegrationId)
            ) &&
            (
                AssociatedIntegrations == other.AssociatedIntegrations ||
                AssociatedIntegrations != null &&
                AssociatedIntegrations.SequenceEqual(other.AssociatedIntegrations)
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
            if (SelectedIntegrationId != null)
            {
                hash = hash * 59 + SelectedIntegrationId.GetHashCode();
            }

            if (AssociatedIntegrations != null)
            {
                hash = hash * 59 + AssociatedIntegrations.GetHashCode();
            }

            return hash;
        }
    }
}
