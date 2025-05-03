using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchIntegrationActionFields
/// </summary>

public partial class PatchIntegrationActionFields : IEquatable<PatchIntegrationActionFields>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchIntegrationActionFields" /> class.
    /// </summary>
    /// <param name="IntegrationAction">Reference to the Integration Action to be used when integrationAction type is qualified.</param>
    /// <param name="RequestMappings">Collection of Request Mappings to use.</param>
    public PatchIntegrationActionFields(PatchIntegrationAction IntegrationAction = null, List<RequestMapping> RequestMappings = null)
    {
        this.IntegrationAction = IntegrationAction;
        this.RequestMappings = RequestMappings;

    }



    /// <summary>
    /// Reference to the Integration Action to be used when integrationAction type is qualified
    /// </summary>
    /// <value>Reference to the Integration Action to be used when integrationAction type is qualified</value>
    [JsonPropertyName("integrationAction")]
    public PatchIntegrationAction IntegrationAction { get; set; }



    /// <summary>
    /// Collection of Request Mappings to use
    /// </summary>
    /// <value>Collection of Request Mappings to use</value>
    [JsonPropertyName("requestMappings")]
    public List<RequestMapping> RequestMappings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchIntegrationActionFields {\n");

        sb.Append("  IntegrationAction: ").Append(IntegrationAction).Append("\n");
        sb.Append("  RequestMappings: ").Append(RequestMappings).Append("\n");
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
        return Equals(obj as PatchIntegrationActionFields);
    }

    /// <summary>
    /// Returns true if PatchIntegrationActionFields instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchIntegrationActionFields to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchIntegrationActionFields other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                IntegrationAction == other.IntegrationAction ||
                IntegrationAction != null &&
                IntegrationAction.Equals(other.IntegrationAction)
            ) &&
            (
                RequestMappings == other.RequestMappings ||
                RequestMappings != null &&
                RequestMappings.SequenceEqual(other.RequestMappings)
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
            if (IntegrationAction != null)
            {
                hash = hash * 59 + IntegrationAction.GetHashCode();
            }

            if (RequestMappings != null)
            {
                hash = hash * 59 + RequestMappings.GetHashCode();
            }

            return hash;
        }
    }
}
