using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// PublishedSurveyFormReference
/// </summary>
[DataContract]
public partial class PublishedSurveyFormReference : IEquatable<PublishedSurveyFormReference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PublishedSurveyFormReference" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ContextId">The context id of this form..</param>
    public PublishedSurveyFormReference(string Name = null, string ContextId = null)
    {
        this.Name = Name;
        this.ContextId = ContextId;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The context id of this form.
    /// </summary>
    /// <value>The context id of this form.</value>
    [DataMember(Name = "contextId", EmitDefaultValue = false)]
    public string ContextId { get; set; }



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
        sb.Append("class PublishedSurveyFormReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
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
        return Equals(obj as PublishedSurveyFormReference);
    }

    /// <summary>
    /// Returns true if PublishedSurveyFormReference instances are equal
    /// </summary>
    /// <param name="other">Instance of PublishedSurveyFormReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PublishedSurveyFormReference other)
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
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
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

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
