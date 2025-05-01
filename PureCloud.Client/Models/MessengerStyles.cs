using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessengerStyles
/// </summary>
[DataContract]
public partial class MessengerStyles : IEquatable<MessengerStyles>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessengerStyles" /> class.
    /// </summary>
    /// <param name="PrimaryColor">The primary color of messenger in hexadecimal.</param>
    public MessengerStyles(string PrimaryColor = null)
    {
        this.PrimaryColor = PrimaryColor;

    }



    /// <summary>
    /// The primary color of messenger in hexadecimal
    /// </summary>
    /// <value>The primary color of messenger in hexadecimal</value>
    [DataMember(Name = "primaryColor", EmitDefaultValue = false)]
    public string PrimaryColor { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessengerStyles {\n");

        sb.Append("  PrimaryColor: ").Append(PrimaryColor).Append("\n");
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
        return Equals(obj as MessengerStyles);
    }

    /// <summary>
    /// Returns true if MessengerStyles instances are equal
    /// </summary>
    /// <param name="other">Instance of MessengerStyles to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessengerStyles other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PrimaryColor == other.PrimaryColor ||
                PrimaryColor != null &&
                PrimaryColor.Equals(other.PrimaryColor)
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
            if (PrimaryColor != null)
            {
                hash = hash * 59 + PrimaryColor.GetHashCode();
            }

            return hash;
        }
    }
}
