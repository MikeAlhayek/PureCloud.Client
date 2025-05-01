using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PasswordRequirements
/// </summary>
[DataContract]
public partial class PasswordRequirements : IEquatable<PasswordRequirements>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordRequirements" /> class.
    /// </summary>
    /// <param name="MinimumLength">MinimumLength.</param>
    /// <param name="MinimumDigits">MinimumDigits.</param>
    /// <param name="MinimumLetters">MinimumLetters.</param>
    /// <param name="MinimumUpper">MinimumUpper.</param>
    /// <param name="MinimumLower">MinimumLower.</param>
    /// <param name="MinimumSpecials">MinimumSpecials.</param>
    /// <param name="MinimumAgeSeconds">MinimumAgeSeconds.</param>
    /// <param name="ExpirationDays">ExpirationDays.</param>
    public PasswordRequirements(int? MinimumLength = null, int? MinimumDigits = null, int? MinimumLetters = null, int? MinimumUpper = null, int? MinimumLower = null, int? MinimumSpecials = null, int? MinimumAgeSeconds = null, int? ExpirationDays = null)
    {
        this.MinimumLength = MinimumLength;
        this.MinimumDigits = MinimumDigits;
        this.MinimumLetters = MinimumLetters;
        this.MinimumUpper = MinimumUpper;
        this.MinimumLower = MinimumLower;
        this.MinimumSpecials = MinimumSpecials;
        this.MinimumAgeSeconds = MinimumAgeSeconds;
        this.ExpirationDays = ExpirationDays;

    }



    /// <summary>
    /// Gets or Sets MinimumLength
    /// </summary>
    [DataMember(Name = "minimumLength", EmitDefaultValue = false)]
    public int? MinimumLength { get; set; }



    /// <summary>
    /// Gets or Sets MinimumDigits
    /// </summary>
    [DataMember(Name = "minimumDigits", EmitDefaultValue = false)]
    public int? MinimumDigits { get; set; }



    /// <summary>
    /// Gets or Sets MinimumLetters
    /// </summary>
    [DataMember(Name = "minimumLetters", EmitDefaultValue = false)]
    public int? MinimumLetters { get; set; }



    /// <summary>
    /// Gets or Sets MinimumUpper
    /// </summary>
    [DataMember(Name = "minimumUpper", EmitDefaultValue = false)]
    public int? MinimumUpper { get; set; }



    /// <summary>
    /// Gets or Sets MinimumLower
    /// </summary>
    [DataMember(Name = "minimumLower", EmitDefaultValue = false)]
    public int? MinimumLower { get; set; }



    /// <summary>
    /// Gets or Sets MinimumSpecials
    /// </summary>
    [DataMember(Name = "minimumSpecials", EmitDefaultValue = false)]
    public int? MinimumSpecials { get; set; }



    /// <summary>
    /// Gets or Sets MinimumAgeSeconds
    /// </summary>
    [DataMember(Name = "minimumAgeSeconds", EmitDefaultValue = false)]
    public int? MinimumAgeSeconds { get; set; }



    /// <summary>
    /// Gets or Sets ExpirationDays
    /// </summary>
    [DataMember(Name = "expirationDays", EmitDefaultValue = false)]
    public int? ExpirationDays { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PasswordRequirements {\n");

        sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
        sb.Append("  MinimumDigits: ").Append(MinimumDigits).Append("\n");
        sb.Append("  MinimumLetters: ").Append(MinimumLetters).Append("\n");
        sb.Append("  MinimumUpper: ").Append(MinimumUpper).Append("\n");
        sb.Append("  MinimumLower: ").Append(MinimumLower).Append("\n");
        sb.Append("  MinimumSpecials: ").Append(MinimumSpecials).Append("\n");
        sb.Append("  MinimumAgeSeconds: ").Append(MinimumAgeSeconds).Append("\n");
        sb.Append("  ExpirationDays: ").Append(ExpirationDays).Append("\n");
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
        return Equals(obj as PasswordRequirements);
    }

    /// <summary>
    /// Returns true if PasswordRequirements instances are equal
    /// </summary>
    /// <param name="other">Instance of PasswordRequirements to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PasswordRequirements other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MinimumLength == other.MinimumLength ||
                MinimumLength != null &&
                MinimumLength.Equals(other.MinimumLength)
            ) &&
            (
                MinimumDigits == other.MinimumDigits ||
                MinimumDigits != null &&
                MinimumDigits.Equals(other.MinimumDigits)
            ) &&
            (
                MinimumLetters == other.MinimumLetters ||
                MinimumLetters != null &&
                MinimumLetters.Equals(other.MinimumLetters)
            ) &&
            (
                MinimumUpper == other.MinimumUpper ||
                MinimumUpper != null &&
                MinimumUpper.Equals(other.MinimumUpper)
            ) &&
            (
                MinimumLower == other.MinimumLower ||
                MinimumLower != null &&
                MinimumLower.Equals(other.MinimumLower)
            ) &&
            (
                MinimumSpecials == other.MinimumSpecials ||
                MinimumSpecials != null &&
                MinimumSpecials.Equals(other.MinimumSpecials)
            ) &&
            (
                MinimumAgeSeconds == other.MinimumAgeSeconds ||
                MinimumAgeSeconds != null &&
                MinimumAgeSeconds.Equals(other.MinimumAgeSeconds)
            ) &&
            (
                ExpirationDays == other.ExpirationDays ||
                ExpirationDays != null &&
                ExpirationDays.Equals(other.ExpirationDays)
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
            if (MinimumLength != null)
            {
                hash = hash * 59 + MinimumLength.GetHashCode();
            }

            if (MinimumDigits != null)
            {
                hash = hash * 59 + MinimumDigits.GetHashCode();
            }

            if (MinimumLetters != null)
            {
                hash = hash * 59 + MinimumLetters.GetHashCode();
            }

            if (MinimumUpper != null)
            {
                hash = hash * 59 + MinimumUpper.GetHashCode();
            }

            if (MinimumLower != null)
            {
                hash = hash * 59 + MinimumLower.GetHashCode();
            }

            if (MinimumSpecials != null)
            {
                hash = hash * 59 + MinimumSpecials.GetHashCode();
            }

            if (MinimumAgeSeconds != null)
            {
                hash = hash * 59 + MinimumAgeSeconds.GetHashCode();
            }

            if (ExpirationDays != null)
            {
                hash = hash * 59 + ExpirationDays.GetHashCode();
            }

            return hash;
        }
    }
}
