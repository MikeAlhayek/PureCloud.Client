using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowOutcomeDivisionView
/// </summary>

public partial class FlowOutcomeDivisionView : IEquatable<FlowOutcomeDivisionView>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowOutcomeDivisionView" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowOutcomeDivisionView() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowOutcomeDivisionView" /> class.
    /// </summary>
    /// <param name="Id">The flow outcome identifier.</param>
    /// <param name="Name">The flow outcome name (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    public FlowOutcomeDivisionView(string Id = null, string Name = null, WritableDivision Division = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Division = Division;

    }



    /// <summary>
    /// The flow outcome identifier
    /// </summary>
    /// <value>The flow outcome identifier</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The flow outcome name
    /// </summary>
    /// <value>The flow outcome name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableDivision Division { get; set; }



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
        sb.Append("class FlowOutcomeDivisionView {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
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
        return Equals(obj as FlowOutcomeDivisionView);
    }

    /// <summary>
    /// Returns true if FlowOutcomeDivisionView instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowOutcomeDivisionView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowOutcomeDivisionView other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
