using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ImportError
/// </summary>

public partial class ImportError : IEquatable<ImportError>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ImportError" /> class.
    /// </summary>
    /// <param name="Message">Message.</param>
    /// <param name="Line">Line.</param>
    public ImportError(string Message = null, int? Line = null)
    {
        this.Message = Message;
        this.Line = Line;

    }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets Line
    /// </summary>
    [JsonPropertyName("line")]
    public int? Line { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ImportError {\n");

        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Line: ").Append(Line).Append("\n");
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
        return Equals(obj as ImportError);
    }

    /// <summary>
    /// Returns true if ImportError instances are equal
    /// </summary>
    /// <param name="other">Instance of ImportError to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ImportError other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Line == other.Line ||
                Line != null &&
                Line.Equals(other.Line)
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
            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Line != null)
            {
                hash = hash * 59 + Line.GetHashCode();
            }

            return hash;
        }
    }
}
