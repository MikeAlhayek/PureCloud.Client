using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentIntegrationAssociationResponse
/// </summary>
[DataContract]
public partial class AgentIntegrationAssociationResponse : IEquatable<AgentIntegrationAssociationResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentIntegrationAssociationResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentIntegrationAssociationResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentIntegrationAssociationResponse" /> class.
    /// </summary>
    /// <param name="AgentExternalId">ID of the agent in external system (required).</param>
    /// <param name="Integration">The integration associated with the agent (required).</param>
    /// <param name="Locked">Whether agentExternalId should be protected from update by automatic processes (required).</param>
    public AgentIntegrationAssociationResponse(string AgentExternalId = null, WfmIntegrationReference Integration = null, bool? Locked = null)
    {
        this.AgentExternalId = AgentExternalId;
        this.Integration = Integration;
        this.Locked = Locked;

    }



    /// <summary>
    /// ID of the agent in external system
    /// </summary>
    /// <value>ID of the agent in external system</value>
    [DataMember(Name = "agentExternalId", EmitDefaultValue = false)]
    public string AgentExternalId { get; set; }



    /// <summary>
    /// The integration associated with the agent
    /// </summary>
    /// <value>The integration associated with the agent</value>
    [DataMember(Name = "integration", EmitDefaultValue = false)]
    public WfmIntegrationReference Integration { get; set; }



    /// <summary>
    /// Whether agentExternalId should be protected from update by automatic processes
    /// </summary>
    /// <value>Whether agentExternalId should be protected from update by automatic processes</value>
    [DataMember(Name = "locked", EmitDefaultValue = false)]
    public bool? Locked { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentIntegrationAssociationResponse {\n");

        sb.Append("  AgentExternalId: ").Append(AgentExternalId).Append("\n");
        sb.Append("  Integration: ").Append(Integration).Append("\n");
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
        return Equals(obj as AgentIntegrationAssociationResponse);
    }

    /// <summary>
    /// Returns true if AgentIntegrationAssociationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentIntegrationAssociationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentIntegrationAssociationResponse other)
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
                Integration == other.Integration ||
                Integration != null &&
                Integration.Equals(other.Integration)
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

            if (Integration != null)
            {
                hash = hash * 59 + Integration.GetHashCode();
            }

            if (Locked != null)
            {
                hash = hash * 59 + Locked.GetHashCode();
            }

            return hash;
        }
    }
}
