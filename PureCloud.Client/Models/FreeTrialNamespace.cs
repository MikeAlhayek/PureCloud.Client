using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FreeTrialNamespace
/// </summary>

public partial class FreeTrialNamespace : IEquatable<FreeTrialNamespace>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FreeTrialNamespace" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="FriendlyName">FriendlyName.</param>
    /// <param name="Limits">Limits.</param>
    public FreeTrialNamespace(string Name = null, string FriendlyName = null, List<FreeTrialLimit> Limits = null)
    {
        this.Name = Name;
        this.FriendlyName = FriendlyName;
        this.Limits = Limits;

    }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets FriendlyName
    /// </summary>
    [JsonPropertyName("friendlyName")]
    public string FriendlyName { get; set; }



    /// <summary>
    /// Gets or Sets Limits
    /// </summary>
    [JsonPropertyName("limits")]
    public List<FreeTrialLimit> Limits { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FreeTrialNamespace {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
        sb.Append("  Limits: ").Append(Limits).Append("\n");
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
        return Equals(obj as FreeTrialNamespace);
    }

    /// <summary>
    /// Returns true if FreeTrialNamespace instances are equal
    /// </summary>
    /// <param name="other">Instance of FreeTrialNamespace to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FreeTrialNamespace other)
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
                FriendlyName == other.FriendlyName ||
                FriendlyName != null &&
                FriendlyName.Equals(other.FriendlyName)
            ) &&
            (
                Limits == other.Limits ||
                Limits != null &&
                Limits.SequenceEqual(other.Limits)
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

            if (FriendlyName != null)
            {
                hash = hash * 59 + FriendlyName.GetHashCode();
            }

            if (Limits != null)
            {
                hash = hash * 59 + Limits.GetHashCode();
            }

            return hash;
        }
    }
}
