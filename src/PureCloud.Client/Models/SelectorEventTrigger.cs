using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details about a selector event trigger
/// </summary>

public partial class SelectorEventTrigger : IEquatable<SelectorEventTrigger>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SelectorEventTrigger" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SelectorEventTrigger() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SelectorEventTrigger" /> class.
    /// </summary>
    /// <param name="Selector">Element that triggers event. (required).</param>
    /// <param name="EventName">Name of event triggered when element matching selector is interacted with. (required).</param>
    public SelectorEventTrigger(string Selector = null, string EventName = null)
    {
        this.Selector = Selector;
        this.EventName = EventName;

    }



    /// <summary>
    /// Element that triggers event.
    /// </summary>
    /// <value>Element that triggers event.</value>
    [JsonPropertyName("selector")]
    public string Selector { get; set; }



    /// <summary>
    /// Name of event triggered when element matching selector is interacted with.
    /// </summary>
    /// <value>Name of event triggered when element matching selector is interacted with.</value>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SelectorEventTrigger {\n");

        sb.Append("  Selector: ").Append(Selector).Append("\n");
        sb.Append("  EventName: ").Append(EventName).Append("\n");
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
        return Equals(obj as SelectorEventTrigger);
    }

    /// <summary>
    /// Returns true if SelectorEventTrigger instances are equal
    /// </summary>
    /// <param name="other">Instance of SelectorEventTrigger to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SelectorEventTrigger other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Selector == other.Selector ||
                Selector != null &&
                Selector.Equals(other.Selector)
            ) &&
            (
                EventName == other.EventName ||
                EventName != null &&
                EventName.Equals(other.EventName)
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
            if (Selector != null)
            {
                hash = hash * 59 + Selector.GetHashCode();
            }

            if (EventName != null)
            {
                hash = hash * 59 + EventName.GetHashCode();
            }

            return hash;
        }
    }
}
