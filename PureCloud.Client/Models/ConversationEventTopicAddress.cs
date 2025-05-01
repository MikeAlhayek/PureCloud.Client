using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Address and name data for a call endpoint.
/// </summary>
[DataContract]
public partial class ConversationEventTopicAddress : IEquatable<ConversationEventTopicAddress>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventTopicAddress" /> class.
    /// </summary>
    /// <param name="Name">This will be nameRaw if present, or a locality lookup of the address field otherwise..</param>
    /// <param name="NameRaw">The name as close to the bits on the wire as possible..</param>
    /// <param name="AddressNormalized">The normalized address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table..</param>
    /// <param name="AddressRaw">The address as close to the bits on the wire as possible..</param>
    /// <param name="AddressDisplayable">The displayable address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table..</param>
    public ConversationEventTopicAddress(string Name = null, string NameRaw = null, string AddressNormalized = null, string AddressRaw = null, string AddressDisplayable = null)
    {
        this.Name = Name;
        this.NameRaw = NameRaw;
        this.AddressNormalized = AddressNormalized;
        this.AddressRaw = AddressRaw;
        this.AddressDisplayable = AddressDisplayable;

    }



    /// <summary>
    /// This will be nameRaw if present, or a locality lookup of the address field otherwise.
    /// </summary>
    /// <value>This will be nameRaw if present, or a locality lookup of the address field otherwise.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The name as close to the bits on the wire as possible.
    /// </summary>
    /// <value>The name as close to the bits on the wire as possible.</value>
    [DataMember(Name = "nameRaw", EmitDefaultValue = false)]
    public string NameRaw { get; set; }



    /// <summary>
    /// The normalized address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table.
    /// </summary>
    /// <value>The normalized address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table.</value>
    [DataMember(Name = "addressNormalized", EmitDefaultValue = false)]
    public string AddressNormalized { get; set; }



    /// <summary>
    /// The address as close to the bits on the wire as possible.
    /// </summary>
    /// <value>The address as close to the bits on the wire as possible.</value>
    [DataMember(Name = "addressRaw", EmitDefaultValue = false)]
    public string AddressRaw { get; set; }



    /// <summary>
    /// The displayable address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table.
    /// </summary>
    /// <value>The displayable address. This field is acquired from the Address Normalization Table.  The addressRaw could have gone through some transformations, such as only using the numeric portion, before being run through the Address Normalization Table.</value>
    [DataMember(Name = "addressDisplayable", EmitDefaultValue = false)]
    public string AddressDisplayable { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEventTopicAddress {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  NameRaw: ").Append(NameRaw).Append("\n");
        sb.Append("  AddressNormalized: ").Append(AddressNormalized).Append("\n");
        sb.Append("  AddressRaw: ").Append(AddressRaw).Append("\n");
        sb.Append("  AddressDisplayable: ").Append(AddressDisplayable).Append("\n");
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
        return Equals(obj as ConversationEventTopicAddress);
    }

    /// <summary>
    /// Returns true if ConversationEventTopicAddress instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEventTopicAddress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEventTopicAddress other)
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
            ) &&
            (
                NameRaw == other.NameRaw ||
                NameRaw != null &&
                NameRaw.Equals(other.NameRaw)
            ) &&
            (
                AddressNormalized == other.AddressNormalized ||
                AddressNormalized != null &&
                AddressNormalized.Equals(other.AddressNormalized)
            ) &&
            (
                AddressRaw == other.AddressRaw ||
                AddressRaw != null &&
                AddressRaw.Equals(other.AddressRaw)
            ) &&
            (
                AddressDisplayable == other.AddressDisplayable ||
                AddressDisplayable != null &&
                AddressDisplayable.Equals(other.AddressDisplayable)
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

            if (NameRaw != null)
            {
                hash = hash * 59 + NameRaw.GetHashCode();
            }

            if (AddressNormalized != null)
            {
                hash = hash * 59 + AddressNormalized.GetHashCode();
            }

            if (AddressRaw != null)
            {
                hash = hash * 59 + AddressRaw.GetHashCode();
            }

            if (AddressDisplayable != null)
            {
                hash = hash * 59 + AddressDisplayable.GetHashCode();
            }

            return hash;
        }
    }
}
