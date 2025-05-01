using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ConditionalGroupRouting
/// </summary>
[DataContract]
public partial class ConditionalGroupRouting : IEquatable<ConditionalGroupRouting>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConditionalGroupRouting" /> class.
    /// </summary>
    /// <param name="Rules">The set of rules to be executed for each conversation.</param>
    public ConditionalGroupRouting(List<ConditionalGroupRoutingRule> Rules = null)
    {
        this.Rules = Rules;

    }



    /// <summary>
    /// The set of rules to be executed for each conversation
    /// </summary>
    /// <value>The set of rules to be executed for each conversation</value>
    [DataMember(Name = "rules", EmitDefaultValue = false)]
    public List<ConditionalGroupRoutingRule> Rules { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConditionalGroupRouting {\n");

        sb.Append("  Rules: ").Append(Rules).Append("\n");
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
        return Equals(obj as ConditionalGroupRouting);
    }

    /// <summary>
    /// Returns true if ConditionalGroupRouting instances are equal
    /// </summary>
    /// <param name="other">Instance of ConditionalGroupRouting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConditionalGroupRouting other)
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

            return hash;
        }
    }
}
