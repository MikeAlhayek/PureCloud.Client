using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FacebookDataIngestionRuleRequest
/// </summary>

public partial class FacebookDataIngestionRuleRequest : IEquatable<FacebookDataIngestionRuleRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="FacebookDataIngestionRuleRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FacebookDataIngestionRuleRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FacebookDataIngestionRuleRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the data ingestion rule. (required).</param>
    /// <param name="Description">A description of the data ingestion rule..</param>
    /// <param name="IntegrationId">The Integration Id from which to ingest public social posts. This entity is created using the /conversations/messaging/integrations/facebook resource (required).</param>
    public FacebookDataIngestionRuleRequest(string Name = null, string Description = null, string IntegrationId = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.IntegrationId = IntegrationId;

    }



    /// <summary>
    /// The name of the data ingestion rule.
    /// </summary>
    /// <value>The name of the data ingestion rule.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A description of the data ingestion rule.
    /// </summary>
    /// <value>A description of the data ingestion rule.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The Integration Id from which to ingest public social posts. This entity is created using the /conversations/messaging/integrations/facebook resource
    /// </summary>
    /// <value>The Integration Id from which to ingest public social posts. This entity is created using the /conversations/messaging/integrations/facebook resource</value>
    [JsonPropertyName("integrationId")]
    public string IntegrationId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FacebookDataIngestionRuleRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
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
        return Equals(obj as FacebookDataIngestionRuleRequest);
    }

    /// <summary>
    /// Returns true if FacebookDataIngestionRuleRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of FacebookDataIngestionRuleRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FacebookDataIngestionRuleRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            return hash;
        }
    }
}
