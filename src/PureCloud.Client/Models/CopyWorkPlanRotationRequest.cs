using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CopyWorkPlanRotationRequest
/// </summary>

public partial class CopyWorkPlanRotationRequest : IEquatable<CopyWorkPlanRotationRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CopyWorkPlanRotationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CopyWorkPlanRotationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CopyWorkPlanRotationRequest" /> class.
    /// </summary>
    /// <param name="Name">Name to apply to the new copy of the work plan rotation (required).</param>
    public CopyWorkPlanRotationRequest(string Name = null)
    {
        this.Name = Name;

    }



    /// <summary>
    /// Name to apply to the new copy of the work plan rotation
    /// </summary>
    /// <value>Name to apply to the new copy of the work plan rotation</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CopyWorkPlanRotationRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as CopyWorkPlanRotationRequest);
    }

    /// <summary>
    /// Returns true if CopyWorkPlanRotationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CopyWorkPlanRotationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CopyWorkPlanRotationRequest other)
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

            return hash;
        }
    }
}
