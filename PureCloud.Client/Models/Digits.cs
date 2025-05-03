using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Digits
/// </summary>

public partial class Digits : IEquatable<Digits>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Digits" /> class.
    /// </summary>
    /// <param name="_Digits">A string representing the digits pressed on phone..</param>
    public Digits(string _Digits = null)
    {
        this._Digits = _Digits;

    }



    /// <summary>
    /// A string representing the digits pressed on phone.
    /// </summary>
    /// <value>A string representing the digits pressed on phone.</value>
    [JsonPropertyName("digits")]
    public string _Digits { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Digits {\n");

        sb.Append("  _Digits: ").Append(_Digits).Append("\n");
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
        return Equals(obj as Digits);
    }

    /// <summary>
    /// Returns true if Digits instances are equal
    /// </summary>
    /// <param name="other">Instance of Digits to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Digits other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                _Digits == other._Digits ||
                _Digits != null &&
                _Digits.Equals(other._Digits)
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
            if (_Digits != null)
            {
                hash = hash * 59 + _Digits.GetHashCode();
            }

            return hash;
        }
    }
}
