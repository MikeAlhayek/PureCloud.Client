using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LexSlot
/// </summary>
[DataContract]
public partial class LexSlot : IEquatable<LexSlot>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LexSlot" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LexSlot() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LexSlot" /> class.
    /// </summary>
    /// <param name="Name">The slot name (required).</param>
    /// <param name="Description">The slot description.</param>
    /// <param name="Type">The slot type (required).</param>
    /// <param name="Priority">The priority of the slot.</param>
    public LexSlot(string Name = null, string Description = null, string Type = null, int? Priority = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Type = Type;
        this.Priority = Priority;

    }



    /// <summary>
    /// The slot name
    /// </summary>
    /// <value>The slot name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The slot description
    /// </summary>
    /// <value>The slot description</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The slot type
    /// </summary>
    /// <value>The slot type</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// The priority of the slot
    /// </summary>
    /// <value>The priority of the slot</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public int? Priority { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LexSlot {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
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
        return Equals(obj as LexSlot);
    }

    /// <summary>
    /// Returns true if LexSlot instances are equal
    /// </summary>
    /// <param name="other">Instance of LexSlot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LexSlot other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            return hash;
        }
    }
}
