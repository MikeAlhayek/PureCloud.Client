using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// GDPRJourneyCustomer
/// </summary>
[DataContract]
public partial class GDPRJourneyCustomer : IEquatable<GDPRJourneyCustomer>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GDPRJourneyCustomer" /> class.
    /// </summary>
    /// <param name="Type">The type of the customerId within the Journey System (e.g. cookie). Required if &#x60;id&#x60; is defined..</param>
    /// <param name="Id">An ID of a customer within the Journey System at a point-in-time. Required if &#x60;type&#x60; is defined..</param>
    public GDPRJourneyCustomer(string Type = null, string Id = null)
    {
        this.Type = Type;
        this.Id = Id;

    }



    /// <summary>
    /// The type of the customerId within the Journey System (e.g. cookie). Required if &#x60;id&#x60; is defined.
    /// </summary>
    /// <value>The type of the customerId within the Journey System (e.g. cookie). Required if &#x60;id&#x60; is defined.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// An ID of a customer within the Journey System at a point-in-time. Required if &#x60;type&#x60; is defined.
    /// </summary>
    /// <value>An ID of a customer within the Journey System at a point-in-time. Required if &#x60;type&#x60; is defined.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GDPRJourneyCustomer {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as GDPRJourneyCustomer);
    }

    /// <summary>
    /// Returns true if GDPRJourneyCustomer instances are equal
    /// </summary>
    /// <param name="other">Instance of GDPRJourneyCustomer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GDPRJourneyCustomer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}
