using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a user role.
/// </summary>

public partial class ScimUserRole : IEquatable<ScimUserRole>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimUserRole" /> class.
    /// </summary>
    /// <param name="Value">The role of the Genesys Cloud user..</param>
    public ScimUserRole(string Value = null)
    {
        this.Value = Value;

    }



    /// <summary>
    /// The role of the Genesys Cloud user.
    /// </summary>
    /// <value>The role of the Genesys Cloud user.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimUserRole {\n");

        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as ScimUserRole);
    }

    /// <summary>
    /// Returns true if ScimUserRole instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimUserRole to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimUserRole other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
