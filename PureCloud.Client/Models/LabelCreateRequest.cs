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
        return this.Equals(obj as LabelCreateRequest);
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
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Color == other.Color ||
                this.Color != null &&
                this.Color.Equals(other.Color)
            ) &&
            (
                this.ExternalId == other.ExternalId ||
                this.ExternalId != null &&
                this.ExternalId.Equals(other.ExternalId)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Color != null)
            {
                hash = hash * 59 + this.Color.GetHashCode();
            }

            if (this.ExternalId != null)
            {
                hash = hash * 59 + this.ExternalId.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
