using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BaseMediaSettings
/// </summary>
[DataContract]
public partial class BaseMediaSettings : IEquatable<BaseMediaSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseMediaSettings" /> class.
    /// </summary>
    /// <param name="EnableAutoAnswer">Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings..</param>
    public BaseMediaSettings(bool? EnableAutoAnswer = null)
    {
        this.EnableAutoAnswer = EnableAutoAnswer;

    }



    /// <summary>
    /// Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.
    /// </summary>
    /// <value>Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.</value>
    [DataMember(Name = "enableAutoAnswer", EmitDefaultValue = false)]
    public bool? EnableAutoAnswer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BaseMediaSettings {\n");

        sb.Append("  EnableAutoAnswer: ").Append(EnableAutoAnswer).Append("\n");
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
        return this.Equals(obj as BaseMediaSettings);
    }

    /// <summary>
    /// Returns true if BaseMediaSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of BaseMediaSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BaseMediaSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.EnableAutoAnswer == other.EnableAutoAnswer ||
                this.EnableAutoAnswer != null &&
                this.EnableAutoAnswer.Equals(other.EnableAutoAnswer)
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
            if (this.EnableAutoAnswer != null)
            {
                hash = hash * 59 + this.EnableAutoAnswer.GetHashCode();
            }

            return hash;
        }
    }
}
