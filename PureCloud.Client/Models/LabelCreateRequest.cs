using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LabelCreateRequest
/// </summary>
[DataContract]
public partial class LabelCreateRequest : IEquatable<LabelCreateRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LabelCreateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LabelCreateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LabelCreateRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the label. (required).</param>
    /// <param name="Color">The color for the label. (required).</param>
    /// <param name="ExternalId">The external id associated with the label..</param>
    public LabelCreateRequest(string Name = null, string Color = null, string ExternalId = null)
    {
        this.Name = Name;
        this.Color = Color;
        this.ExternalId = ExternalId;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the label.
    /// </summary>
    /// <value>The name of the label.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The color for the label.
    /// </summary>
    /// <value>The color for the label.</value>
    [DataMember(Name = "color", EmitDefaultValue = false)]
    public string Color { get; set; }



    /// <summary>
    /// The external id associated with the label.
    /// </summary>
    /// <value>The external id associated with the label.</value>
    [DataMember(Name = "externalId", EmitDefaultValue = false)]
    public string ExternalId { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LabelCreateRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Color: ").Append(Color).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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
        return Equals(obj as LabelCreateRequest);
    }

    /// <summary>
    /// Returns true if LabelCreateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LabelCreateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LabelCreateRequest other)
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
                Color == other.Color ||
                Color != null &&
                Color.Equals(other.Color)
            ) &&
            (
                ExternalId == other.ExternalId ||
                ExternalId != null &&
                ExternalId.Equals(other.ExternalId)
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

            if (Color != null)
            {
                hash = hash * 59 + Color.GetHashCode();
            }

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
