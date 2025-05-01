using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Represents a link between 2 elements in a journey view result
/// </summary>
[DataContract]
public partial class JourneyViewResultLink : IEquatable<JourneyViewResultLink>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewResultLink" /> class.
    /// </summary>
    public JourneyViewResultLink()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// the number of connections for the journey view link
    /// </summary>
    /// <value>the number of connections for the journey view link</value>
    [DataMember(Name = "connectionCount", EmitDefaultValue = false)]
    public int? ConnectionCount { get; private set; }



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
        sb.Append("class JourneyViewResultLink {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ConnectionCount: ").Append(ConnectionCount).Append("\n");
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
        return Equals(obj as JourneyViewResultLink);
    }

    /// <summary>
    /// Returns true if JourneyViewResultLink instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewResultLink to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewResultLink other)
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
                ConnectionCount == other.ConnectionCount ||
                ConnectionCount != null &&
                ConnectionCount.Equals(other.ConnectionCount)
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

            if (ConnectionCount != null)
            {
                hash = hash * 59 + ConnectionCount.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
