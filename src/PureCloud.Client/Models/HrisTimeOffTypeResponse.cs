using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HrisTimeOffTypeResponse
/// </summary>

public partial class HrisTimeOffTypeResponse : IEquatable<HrisTimeOffTypeResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="HrisTimeOffTypeResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected HrisTimeOffTypeResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="HrisTimeOffTypeResponse" /> class.
    /// </summary>
    /// <param name="Id">ID of the time off type configured in integration (required).</param>
    /// <param name="Name">Name of the time off type configured in integration (required).</param>
    /// <param name="SecondaryId">Secondary ID of the time off type, if configured in integration.</param>
    public HrisTimeOffTypeResponse(string Id = null, string Name = null, string SecondaryId = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SecondaryId = SecondaryId;

    }



    /// <summary>
    /// ID of the time off type configured in integration
    /// </summary>
    /// <value>ID of the time off type configured in integration</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Name of the time off type configured in integration
    /// </summary>
    /// <value>Name of the time off type configured in integration</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Secondary ID of the time off type, if configured in integration
    /// </summary>
    /// <value>Secondary ID of the time off type, if configured in integration</value>
    [JsonPropertyName("secondaryId")]
    public string SecondaryId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HrisTimeOffTypeResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as HrisTimeOffTypeResponse);
    }

    /// <summary>
    /// Returns true if HrisTimeOffTypeResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of HrisTimeOffTypeResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HrisTimeOffTypeResponse other)
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

            if (SecondaryId != null)
            {
                hash = hash * 59 + SecondaryId.GetHashCode();
            }

            return hash;
        }
    }
}
