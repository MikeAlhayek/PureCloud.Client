using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM manager.
/// </summary>
[DataContract]
public partial class Manager : IEquatable<Manager>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Manager" /> class.
    /// </summary>
    /// <param name="Value">The ID of the manager..</param>
    public Manager(string Value = null)
    {
        this.Value = Value;

    }



    /// <summary>
    /// The ID of the manager.
    /// </summary>
    /// <value>The ID of the manager.</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }



    /// <summary>
    /// The reference URI of the manager&#39;s user record.
    /// </summary>
    /// <value>The reference URI of the manager&#39;s user record.</value>
    [DataMember(Name = "$ref", EmitDefaultValue = false)]
    public string Ref { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Manager {\n");

        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Ref: ").Append(Ref).Append("\n");
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
        return Equals(obj as Manager);
    }

    /// <summary>
    /// Returns true if Manager instances are equal
    /// </summary>
    /// <param name="other">Instance of Manager to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Manager other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Ref == other.Ref ||
                Ref != null &&
                Ref.Equals(other.Ref)
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
            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Ref != null)
            {
                hash = hash * 59 + Ref.GetHashCode();
            }

            return hash;
        }
    }
}
