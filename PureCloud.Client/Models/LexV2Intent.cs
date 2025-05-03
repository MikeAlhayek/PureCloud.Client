using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LexV2Intent
/// </summary>

public partial class LexV2Intent : IEquatable<LexV2Intent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LexV2Intent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LexV2Intent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LexV2Intent" /> class.
    /// </summary>
    /// <param name="IntentName">The intent name (required).</param>
    /// <param name="Description">A description of the intent.</param>
    /// <param name="Slots">An object mapping slot names to Slot objects (required).</param>
    /// <param name="IntentId">The intent id (required).</param>
    public LexV2Intent(string IntentName = null, string Description = null, Dictionary<string, LexV2Slot> Slots = null, string IntentId = null)
    {
        this.IntentName = IntentName;
        this.Description = Description;
        this.Slots = Slots;
        this.IntentId = IntentId;

    }



    /// <summary>
    /// The intent name
    /// </summary>
    /// <value>The intent name</value>
    [JsonPropertyName("intentName")]
    public string IntentName { get; set; }



    /// <summary>
    /// A description of the intent
    /// </summary>
    /// <value>A description of the intent</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// An object mapping slot names to Slot objects
    /// </summary>
    /// <value>An object mapping slot names to Slot objects</value>
    [JsonPropertyName("slots")]
    public Dictionary<string, LexV2Slot> Slots { get; set; }



    /// <summary>
    /// The intent id
    /// </summary>
    /// <value>The intent id</value>
    [JsonPropertyName("intentId")]
    public string IntentId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LexV2Intent {\n");

        sb.Append("  IntentName: ").Append(IntentName).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Slots: ").Append(Slots).Append("\n");
        sb.Append("  IntentId: ").Append(IntentId).Append("\n");
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
        return Equals(obj as LexV2Intent);
    }

    /// <summary>
    /// Returns true if LexV2Intent instances are equal
    /// </summary>
    /// <param name="other">Instance of LexV2Intent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LexV2Intent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                IntentName == other.IntentName ||
                IntentName != null &&
                IntentName.Equals(other.IntentName)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Slots == other.Slots ||
                Slots != null &&
                Slots.SequenceEqual(other.Slots)
            ) &&
            (
                IntentId == other.IntentId ||
                IntentId != null &&
                IntentId.Equals(other.IntentId)
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
            if (IntentName != null)
            {
                hash = hash * 59 + IntentName.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Slots != null)
            {
                hash = hash * 59 + Slots.GetHashCode();
            }

            if (IntentId != null)
            {
                hash = hash * 59 + IntentId.GetHashCode();
            }

            return hash;
        }
    }
}
