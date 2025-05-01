using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Markdown
/// </summary>
[DataContract]
public partial class Markdown : IEquatable<Markdown>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Markdown" /> class.
    /// </summary>
    /// <param name="Enabled">whether or not markdown is enabled.</param>
    public Markdown(bool? Enabled = null)
    {
        this.Enabled = Enabled;

    }



    /// <summary>
    /// whether or not markdown is enabled
    /// </summary>
    /// <value>whether or not markdown is enabled</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Markdown {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
        return this.Equals(obj as Markdown);
    }

    /// <summary>
    /// Returns true if Markdown instances are equal
    /// </summary>
    /// <param name="other">Instance of Markdown to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Markdown other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Enabled == other.Enabled ||
                this.Enabled != null &&
                this.Enabled.Equals(other.Enabled)
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
            if (this.Enabled != null)
            {
                hash = hash * 59 + this.Enabled.GetHashCode();
            }

            return hash;
        }
    }
}
