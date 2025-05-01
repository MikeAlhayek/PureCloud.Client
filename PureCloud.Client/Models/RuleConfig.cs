using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RuleConfig
/// </summary>
[DataContract]
public partial class RuleConfig : IEquatable<RuleConfig>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RuleConfig" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RuleConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RuleConfig" /> class.
    /// </summary>
    /// <param name="Id">Rule ID..</param>
    /// <param name="Enabled">Rule enabled. (required).</param>
    /// <param name="Rule">Rule configuration. (required).</param>
    public RuleConfig(string Id = null, bool? Enabled = null, CopilotRule Rule = null)
    {
        this.Id = Id;
        this.Enabled = Enabled;
        this.Rule = Rule;

    }



    /// <summary>
    /// Rule ID.
    /// </summary>
    /// <value>Rule ID.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Rule enabled.
    /// </summary>
    /// <value>Rule enabled.</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Rule configuration.
    /// </summary>
    /// <value>Rule configuration.</value>
    [DataMember(Name = "rule", EmitDefaultValue = false)]
    public CopilotRule Rule { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RuleConfig {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Rule: ").Append(Rule).Append("\n");
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
        return Equals(obj as RuleConfig);
    }

    /// <summary>
    /// Returns true if RuleConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of RuleConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RuleConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Rule == other.Rule ||
                Rule != null &&
                Rule.Equals(other.Rule)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Rule != null)
            {
                hash = hash * 59 + Rule.GetHashCode();
            }

            return hash;
        }
    }
}
