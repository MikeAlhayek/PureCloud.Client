using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrustedCertificateInfo
/// </summary>

public partial class TrustedCertificateInfo : IEquatable<TrustedCertificateInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrustedCertificateInfo" /> class.
    /// </summary>
    /// <param name="Description">The description of the certificate.</param>
    /// <param name="SerialNumber">The serial number of the certificate.</param>
    /// <param name="Signature">The signature of the certificate.</param>
    public TrustedCertificateInfo(string Description = null, string SerialNumber = null, string Signature = null)
    {
        this.Description = Description;
        this.SerialNumber = SerialNumber;
        this.Signature = Signature;

    }



    /// <summary>
    /// The description of the certificate
    /// </summary>
    /// <value>The description of the certificate</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The serial number of the certificate
    /// </summary>
    /// <value>The serial number of the certificate</value>
    [JsonPropertyName("serialNumber")]
    public string SerialNumber { get; set; }



    /// <summary>
    /// The signature of the certificate
    /// </summary>
    /// <value>The signature of the certificate</value>
    [JsonPropertyName("signature")]
    public string Signature { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrustedCertificateInfo {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
        sb.Append("  Signature: ").Append(Signature).Append("\n");
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
        return Equals(obj as TrustedCertificateInfo);
    }

    /// <summary>
    /// Returns true if TrustedCertificateInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of TrustedCertificateInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrustedCertificateInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                SerialNumber == other.SerialNumber ||
                SerialNumber != null &&
                SerialNumber.Equals(other.SerialNumber)
            ) &&
            (
                Signature == other.Signature ||
                Signature != null &&
                Signature.Equals(other.Signature)
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
            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (SerialNumber != null)
            {
                hash = hash * 59 + SerialNumber.GetHashCode();
            }

            if (Signature != null)
            {
                hash = hash * 59 + Signature.GetHashCode();
            }

            return hash;
        }
    }
}
