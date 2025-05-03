using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LexV2Slot
/// </summary>

public partial class LexV2Slot : IEquatable<LexV2Slot>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LexV2Slot" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LexV2Slot() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LexV2Slot" /> class.
    /// </summary>
    /// <param name="SlotName">The slot name (required).</param>
    /// <param name="Description">The slot description.</param>
    /// <param name="SlotId">The slot id (required).</param>
    /// <param name="Type">The slot type (required).</param>
    /// <param name="SlotTypeId">The slot type id (required).</param>
    public LexV2Slot(string SlotName = null, string Description = null, string SlotId = null, string Type = null, string SlotTypeId = null)
    {
        this.SlotName = SlotName;
        this.Description = Description;
        this.SlotId = SlotId;
        this.Type = Type;
        this.SlotTypeId = SlotTypeId;

    }



    /// <summary>
    /// The slot name
    /// </summary>
    /// <value>The slot name</value>
    [JsonPropertyName("slotName")]
    public string SlotName { get; set; }



    /// <summary>
    /// The slot description
    /// </summary>
    /// <value>The slot description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The slot id
    /// </summary>
    /// <value>The slot id</value>
    [JsonPropertyName("slotId")]
    public string SlotId { get; set; }



    /// <summary>
    /// The slot type
    /// </summary>
    /// <value>The slot type</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// The slot type id
    /// </summary>
    /// <value>The slot type id</value>
    [JsonPropertyName("slotTypeId")]
    public string SlotTypeId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LexV2Slot {\n");

        sb.Append("  SlotName: ").Append(SlotName).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  SlotId: ").Append(SlotId).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  SlotTypeId: ").Append(SlotTypeId).Append("\n");
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
        return Equals(obj as LexV2Slot);
    }

    /// <summary>
    /// Returns true if LexV2Slot instances are equal
    /// </summary>
    /// <param name="other">Instance of LexV2Slot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LexV2Slot other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SlotName == other.SlotName ||
                SlotName != null &&
                SlotName.Equals(other.SlotName)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                SlotId == other.SlotId ||
                SlotId != null &&
                SlotId.Equals(other.SlotId)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                SlotTypeId == other.SlotTypeId ||
                SlotTypeId != null &&
                SlotTypeId.Equals(other.SlotTypeId)
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
            if (SlotName != null)
            {
                hash = hash * 59 + SlotName.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (SlotId != null)
            {
                hash = hash * 59 + SlotId.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (SlotTypeId != null)
            {
                hash = hash * 59 + SlotTypeId.GetHashCode();
            }

            return hash;
        }
    }
}
