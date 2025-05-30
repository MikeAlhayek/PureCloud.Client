using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentIntegrationsResponse
/// </summary>

public partial class AgentIntegrationsResponse : IEquatable<AgentIntegrationsResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentIntegrationsResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentIntegrationsResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentIntegrationsResponse" /> class.
    /// </summary>
    /// <param name="Agent">The user associated with the integrations (required).</param>
    /// <param name="SelectedIntegration">The integration selected for the agent. If not set, no integration will be used for the agent.</param>
    /// <param name="UserSelected">Whether the integration association has been manually selected.</param>
    /// <param name="AssociatedIntegrations">The list of integrations associated with the agent (required).</param>
    public AgentIntegrationsResponse(UserReference Agent = null, WfmIntegrationReference SelectedIntegration = null, bool? UserSelected = null, List<AgentIntegrationAssociationResponse> AssociatedIntegrations = null)
    {
        this.Agent = Agent;
        this.SelectedIntegration = SelectedIntegration;
        this.UserSelected = UserSelected;
        this.AssociatedIntegrations = AssociatedIntegrations;

    }



    /// <summary>
    /// The user associated with the integrations
    /// </summary>
    /// <value>The user associated with the integrations</value>
    [JsonPropertyName("agent")]
    public UserReference Agent { get; set; }



    /// <summary>
    /// The integration selected for the agent. If not set, no integration will be used for the agent
    /// </summary>
    /// <value>The integration selected for the agent. If not set, no integration will be used for the agent</value>
    [JsonPropertyName("selectedIntegration")]
    public WfmIntegrationReference SelectedIntegration { get; set; }



    /// <summary>
    /// Whether the integration association has been manually selected
    /// </summary>
    /// <value>Whether the integration association has been manually selected</value>
    [JsonPropertyName("userSelected")]
    public bool? UserSelected { get; set; }



    /// <summary>
    /// The list of integrations associated with the agent
    /// </summary>
    /// <value>The list of integrations associated with the agent</value>
    [JsonPropertyName("associatedIntegrations")]
    public List<AgentIntegrationAssociationResponse> AssociatedIntegrations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentIntegrationsResponse {\n");

        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  SelectedIntegration: ").Append(SelectedIntegration).Append("\n");
        sb.Append("  UserSelected: ").Append(UserSelected).Append("\n");
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
        return Equals(obj as AgentIntegrationsResponse);
    }

    /// <summary>
    /// Returns true if AgentIntegrationsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentIntegrationsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentIntegrationsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                SelectedIntegration == other.SelectedIntegration ||
                SelectedIntegration != null &&
                SelectedIntegration.Equals(other.SelectedIntegration)
            ) &&
            (
                UserSelected == other.UserSelected ||
                UserSelected != null &&
                UserSelected.Equals(other.UserSelected)
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
            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (SelectedIntegration != null)
            {
                hash = hash * 59 + SelectedIntegration.GetHashCode();
            }

            if (UserSelected != null)
            {
                hash = hash * 59 + UserSelected.GetHashCode();
            }

            if (AssociatedIntegrations != null)
            {
                hash = hash * 59 + AssociatedIntegrations.GetHashCode();
            }

            return hash;
        }
    }
}
