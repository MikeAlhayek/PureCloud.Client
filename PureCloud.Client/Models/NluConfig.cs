using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluConfig
/// </summary>
[DataContract]
public partial class NluConfig : IEquatable<NluConfig>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluConfig" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluConfig" /> class.
    /// </summary>
    /// <param name="Domain">NLU domain. (required).</param>
    /// <param name="IntentConfidenceThreshold">Minimum confidence value of accepting NLU intents, must be greater than 0 and less than 1. (required).</param>
    public NluConfig(CopilotNluDomain Domain = null, float? IntentConfidenceThreshold = null)
    {
        this.Domain = Domain;
        this.IntentConfidenceThreshold = IntentConfidenceThreshold;

    }



    /// <summary>
    /// NLU domain.
    /// </summary>
    /// <value>NLU domain.</value>
    [DataMember(Name = "domain", EmitDefaultValue = false)]
    public CopilotNluDomain Domain { get; set; }



    /// <summary>
    /// Minimum confidence value of accepting NLU intents, must be greater than 0 and less than 1.
    /// </summary>
    /// <value>Minimum confidence value of accepting NLU intents, must be greater than 0 and less than 1.</value>
    [DataMember(Name = "intentConfidenceThreshold", EmitDefaultValue = false)]
    public float? IntentConfidenceThreshold { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluConfig {\n");

        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  IntentConfidenceThreshold: ").Append(IntentConfidenceThreshold).Append("\n");
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
        return Equals(obj as NluConfig);
    }

    /// <summary>
    /// Returns true if NluConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of NluConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
            ) &&
            (
                IntentConfidenceThreshold == other.IntentConfidenceThreshold ||
                IntentConfidenceThreshold != null &&
                IntentConfidenceThreshold.Equals(other.IntentConfidenceThreshold)
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
            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            if (IntentConfidenceThreshold != null)
            {
                hash = hash * 59 + IntentConfidenceThreshold.GetHashCode();
            }

            return hash;
        }
    }
}
