using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RuleEngineConfig
/// </summary>
[DataContract]
public partial class RuleEngineConfig : IEquatable<RuleEngineConfig>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RuleEngineConfig" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RuleEngineConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RuleEngineConfig" /> class.
    /// </summary>
    /// <param name="Rules">List of rules to evaluate by the engine. (required).</param>
    /// <param name="Fallback">Fallback configuration..</param>
    public RuleEngineConfig(List<RuleConfig> Rules = null, Fallback Fallback = null)
    {
        this.Rules = Rules;
        this.Fallback = Fallback;

    }



    /// <summary>
    /// List of rules to evaluate by the engine.
    /// </summary>
    /// <value>List of rules to evaluate by the engine.</value>
    [DataMember(Name = "rules", EmitDefaultValue = false)]
    public List<RuleConfig> Rules { get; set; }



    /// <summary>
    /// Fallback configuration.
    /// </summary>
    /// <value>Fallback configuration.</value>
    [DataMember(Name = "fallback", EmitDefaultValue = false)]
    public Fallback Fallback { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RuleEngineConfig {\n");

        sb.Append("  Rules: ").Append(Rules).Append("\n");
        sb.Append("  Fallback: ").Append(Fallback).Append("\n");
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
        return Equals(obj as RuleEngineConfig);
    }

    /// <summary>
    /// Returns true if RuleEngineConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of RuleEngineConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RuleEngineConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Rules == other.Rules ||
                Rules != null &&
                Rules.SequenceEqual(other.Rules)
            ) &&
            (
                Fallback == other.Fallback ||
                Fallback != null &&
                Fallback.Equals(other.Fallback)
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
            if (Rules != null)
            {
                hash = hash * 59 + Rules.GetHashCode();
            }

            if (Fallback != null)
            {
                hash = hash * 59 + Fallback.GetHashCode();
            }

            return hash;
        }
    }
}
