using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EventSetting
/// </summary>
[DataContract]
public partial class EventSetting : IEquatable<EventSetting>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EventSetting" /> class.
    /// </summary>
    /// <param name="Typing">Settings regarding typing events.</param>
    public EventSetting(TypingSetting Typing = null)
    {
        this.Typing = Typing;

    }



    /// <summary>
    /// Settings regarding typing events
    /// </summary>
    /// <value>Settings regarding typing events</value>
    [DataMember(Name = "typing", EmitDefaultValue = false)]
    public TypingSetting Typing { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventSetting {\n");

        sb.Append("  Typing: ").Append(Typing).Append("\n");
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
        return this.Equals(obj as EventSetting);
    }

    /// <summary>
    /// Returns true if EventSetting instances are equal
    /// </summary>
    /// <param name="other">Instance of EventSetting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventSetting other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Typing == other.Typing ||
                this.Typing != null &&
                this.Typing.Equals(other.Typing)
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
            if (this.Typing != null)
            {
                hash = hash * 59 + this.Typing.GetHashCode();
            }

            return hash;
        }
    }
}
