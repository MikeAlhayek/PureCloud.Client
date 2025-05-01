using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HrisTimeOffType
/// </summary>
[DataContract]
public partial class HrisTimeOffType : IEquatable<HrisTimeOffType>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="HrisTimeOffType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected HrisTimeOffType() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="HrisTimeOffType" /> class.
    /// </summary>
    /// <param name="Id">The ID of the time off type configured in integration. (required).</param>
    /// <param name="Name">The name of the time off type configured in integration. (required).</param>
    /// <param name="HrisIntegrationId">The ID of the integration. (required).</param>
    /// <param name="SecondaryId">Secondary ID of the time off type, if configured in integration..</param>
    public HrisTimeOffType(string Id = null, string Name = null, string HrisIntegrationId = null, string SecondaryId = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.HrisIntegrationId = HrisIntegrationId;
        this.SecondaryId = SecondaryId;

    }



    /// <summary>
    /// The ID of the time off type configured in integration.
    /// </summary>
    /// <value>The ID of the time off type configured in integration.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The name of the time off type configured in integration.
    /// </summary>
    /// <value>The name of the time off type configured in integration.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The ID of the integration.
    /// </summary>
    /// <value>The ID of the integration.</value>
    [DataMember(Name = "hrisIntegrationId", EmitDefaultValue = false)]
    public string HrisIntegrationId { get; set; }



    /// <summary>
    /// Secondary ID of the time off type, if configured in integration.
    /// </summary>
    /// <value>Secondary ID of the time off type, if configured in integration.</value>
    [DataMember(Name = "secondaryId", EmitDefaultValue = false)]
    public string SecondaryId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HrisTimeOffType {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  HrisIntegrationId: ").Append(HrisIntegrationId).Append("\n");
        sb.Append("  SecondaryId: ").Append(SecondaryId).Append("\n");
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
        return Equals(obj as HrisTimeOffType);
    }

    /// <summary>
    /// Returns true if HrisTimeOffType instances are equal
    /// </summary>
    /// <param name="other">Instance of HrisTimeOffType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HrisTimeOffType other)
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
                HrisIntegrationId == other.HrisIntegrationId ||
                HrisIntegrationId != null &&
                HrisIntegrationId.Equals(other.HrisIntegrationId)
            ) &&
            (
                SecondaryId == other.SecondaryId ||
                SecondaryId != null &&
                SecondaryId.Equals(other.SecondaryId)
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

            if (HrisIntegrationId != null)
            {
                hash = hash * 59 + HrisIntegrationId.GetHashCode();
            }

            if (SecondaryId != null)
            {
                hash = hash * 59 + SecondaryId.GetHashCode();
            }

            return hash;
        }
    }
}
