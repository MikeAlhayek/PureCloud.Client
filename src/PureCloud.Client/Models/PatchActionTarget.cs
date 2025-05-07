using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchActionTarget
/// </summary>

public partial class PatchActionTarget : IEquatable<PatchActionTarget>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchActionTarget" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ServiceLevel">Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level..</param>
    /// <param name="ShortAbandonThreshold">Indicates the non-default short abandon threshold.</param>
    public PatchActionTarget(string Name = null, ServiceLevel ServiceLevel = null, int? ShortAbandonThreshold = null)
    {
        this.Name = Name;
        this.ServiceLevel = ServiceLevel;
        this.ShortAbandonThreshold = ShortAbandonThreshold;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level.
    /// </summary>
    /// <value>Service Level of the action target. Chat offers for the target will be throttled with the aim of achieving this service level.</value>
    [JsonPropertyName("serviceLevel")]
    public ServiceLevel ServiceLevel { get; set; }



    /// <summary>
    /// Indicates the non-default short abandon threshold
    /// </summary>
    /// <value>Indicates the non-default short abandon threshold</value>
    [JsonPropertyName("shortAbandonThreshold")]
    public int? ShortAbandonThreshold { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchActionTarget {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
        sb.Append("  ShortAbandonThreshold: ").Append(ShortAbandonThreshold).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as PatchActionTarget);
    }

    /// <summary>
    /// Returns true if PatchActionTarget instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchActionTarget to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchActionTarget other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ServiceLevel == other.ServiceLevel ||
                ServiceLevel != null &&
                ServiceLevel.Equals(other.ServiceLevel)
            ) &&
            (
                ShortAbandonThreshold == other.ShortAbandonThreshold ||
                ShortAbandonThreshold != null &&
                ShortAbandonThreshold.Equals(other.ShortAbandonThreshold)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ServiceLevel != null)
            {
                hash = hash * 59 + ServiceLevel.GetHashCode();
            }

            if (ShortAbandonThreshold != null)
            {
                hash = hash * 59 + ShortAbandonThreshold.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
