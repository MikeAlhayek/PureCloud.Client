using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Activation
/// </summary>

public partial class Activation : IEquatable<Activation>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Activation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Activation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Activation" /> class.
    /// </summary>
    /// <param name="Type">Type of activation. (required).</param>
    /// <param name="DelayInSeconds">Activation delay time amount..</param>
    public Activation(string Type = null, int? DelayInSeconds = null)
    {
        this.Type = Type;
        this.DelayInSeconds = DelayInSeconds;

    }



    /// <summary>
    /// Type of activation.
    /// </summary>
    /// <value>Type of activation.</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Activation delay time amount.
    /// </summary>
    /// <value>Activation delay time amount.</value>
    [JsonPropertyName("delayInSeconds")]
    public int? DelayInSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Activation {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  DelayInSeconds: ").Append(DelayInSeconds).Append("\n");
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
        return Equals(obj as Activation);
    }

    /// <summary>
    /// Returns true if Activation instances are equal
    /// </summary>
    /// <param name="other">Instance of Activation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Activation other)
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
                DelayInSeconds == other.DelayInSeconds ||
                DelayInSeconds != null &&
                DelayInSeconds.Equals(other.DelayInSeconds)
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

            if (DelayInSeconds != null)
            {
                hash = hash * 59 + DelayInSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
