using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateVerifierRequest
/// </summary>

public partial class UpdateVerifierRequest : IEquatable<UpdateVerifierRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateVerifierRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the verifier..</param>
    /// <param name="Enabled">Indicates whether this verifier will be enabled..</param>
    /// <param name="Default">Indicates whether this will be the default verifier..</param>
    public UpdateVerifierRequest(string Name = null, bool? Enabled = null, bool? Default = null)
    {
        this.Name = Name;
        this.Enabled = Enabled;
        this.Default = Default;

    }



    /// <summary>
    /// The name of the verifier.
    /// </summary>
    /// <value>The name of the verifier.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Indicates whether this verifier will be enabled.
    /// </summary>
    /// <value>Indicates whether this verifier will be enabled.</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Indicates whether this will be the default verifier.
    /// </summary>
    /// <value>Indicates whether this will be the default verifier.</value>
    [JsonPropertyName("default")]
    public bool? Default { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateVerifierRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Default: ").Append(Default).Append("\n");
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
        return Equals(obj as UpdateVerifierRequest);
    }

    /// <summary>
    /// Returns true if UpdateVerifierRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateVerifierRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateVerifierRequest other)
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
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Default == other.Default ||
                Default != null &&
                Default.Equals(other.Default)
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

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Default != null)
            {
                hash = hash * 59 + Default.GetHashCode();
            }

            return hash;
        }
    }
}
