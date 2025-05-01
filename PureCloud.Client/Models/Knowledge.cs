using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Knowledge
/// </summary>
[DataContract]
public partial class Knowledge : IEquatable<Knowledge>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Knowledge" /> class.
    /// </summary>
    /// <param name="Enabled">whether or not knowledge base is enabled.</param>
    /// <param name="KnowledgeBase">The knowledge base for messenger.</param>
    public Knowledge(bool? Enabled = null, AddressableEntityRef KnowledgeBase = null)
    {
        this.Enabled = Enabled;
        this.KnowledgeBase = KnowledgeBase;

    }



    /// <summary>
    /// whether or not knowledge base is enabled
    /// </summary>
    /// <value>whether or not knowledge base is enabled</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The knowledge base for messenger
    /// </summary>
    /// <value>The knowledge base for messenger</value>
    [DataMember(Name = "knowledgeBase", EmitDefaultValue = false)]
    public AddressableEntityRef KnowledgeBase { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Knowledge {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
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
        return Equals(obj as Knowledge);
    }

    /// <summary>
    /// Returns true if Knowledge instances are equal
    /// </summary>
    /// <param name="other">Instance of Knowledge to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Knowledge other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                KnowledgeBase == other.KnowledgeBase ||
                KnowledgeBase != null &&
                KnowledgeBase.Equals(other.KnowledgeBase)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (KnowledgeBase != null)
            {
                hash = hash * 59 + KnowledgeBase.GetHashCode();
            }

            return hash;
        }
    }
}
