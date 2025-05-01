using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Represents the details of a parsed certificate.
/// </summary>
[DataContract]
public partial class CertificateDetails : IEquatable<CertificateDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CertificateDetails" /> class.
    /// </summary>
    /// <param name="Issuer">Information about the issuer of the certificate.  The value of this property is a comma separated key&#x3D;value format.  Each key is one of the attribute names supported by X.500..</param>
    /// <param name="Subject">Information about the subject of the certificate.  The value of this property is a comma separated key&#x3D;value format.  Each key is one of the attribute names supported by X.500..</param>
    /// <param name="ExpirationDate">The expiration date of the certificate. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="IssueDate">The issue date of the certificate. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Expired">True if the certificate is expired, false otherwise..</param>
    /// <param name="SignatureValid">SignatureValid.</param>
    /// <param name="Valid">Valid.</param>
    public CertificateDetails(string Issuer = null, string Subject = null, DateTime? ExpirationDate = null, DateTime? IssueDate = null, bool? Expired = null, bool? SignatureValid = null, bool? Valid = null)
    {
        this.Issuer = Issuer;
        this.Subject = Subject;
        this.ExpirationDate = ExpirationDate;
        this.IssueDate = IssueDate;
        this.Expired = Expired;
        this.SignatureValid = SignatureValid;
        this.Valid = Valid;

    }



    /// <summary>
    /// Information about the issuer of the certificate.  The value of this property is a comma separated key&#x3D;value format.  Each key is one of the attribute names supported by X.500.
    /// </summary>
    /// <value>Information about the issuer of the certificate.  The value of this property is a comma separated key&#x3D;value format.  Each key is one of the attribute names supported by X.500.</value>
    [DataMember(Name = "issuer", EmitDefaultValue = false)]
    public string Issuer { get; set; }



    /// <summary>
    /// Information about the subject of the certificate.  The value of this property is a comma separated key&#x3D;value format.  Each key is one of the attribute names supported by X.500.
    /// </summary>
    /// <value>Information about the subject of the certificate.  The value of this property is a comma separated key&#x3D;value format.  Each key is one of the attribute names supported by X.500.</value>
    [DataMember(Name = "subject", EmitDefaultValue = false)]
    public string Subject { get; set; }



    /// <summary>
    /// The expiration date of the certificate. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The expiration date of the certificate. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
    public DateTime? ExpirationDate { get; set; }



    /// <summary>
    /// The issue date of the certificate. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The issue date of the certificate. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "issueDate", EmitDefaultValue = false)]
    public DateTime? IssueDate { get; set; }



    /// <summary>
    /// True if the certificate is expired, false otherwise.
    /// </summary>
    /// <value>True if the certificate is expired, false otherwise.</value>
    [DataMember(Name = "expired", EmitDefaultValue = false)]
    public bool? Expired { get; set; }



    /// <summary>
    /// Gets or Sets SignatureValid
    /// </summary>
    [DataMember(Name = "signatureValid", EmitDefaultValue = false)]
    public bool? SignatureValid { get; set; }



    /// <summary>
    /// Gets or Sets Valid
    /// </summary>
    [DataMember(Name = "valid", EmitDefaultValue = false)]
    public bool? Valid { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CertificateDetails {\n");

        sb.Append("  Issuer: ").Append(Issuer).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
        sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
        sb.Append("  Expired: ").Append(Expired).Append("\n");
        sb.Append("  SignatureValid: ").Append(SignatureValid).Append("\n");
        sb.Append("  Valid: ").Append(Valid).Append("\n");
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
        return Equals(obj as CertificateDetails);
    }

    /// <summary>
    /// Returns true if CertificateDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of CertificateDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CertificateDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Issuer == other.Issuer ||
                Issuer != null &&
                Issuer.Equals(other.Issuer)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                ExpirationDate == other.ExpirationDate ||
                ExpirationDate != null &&
                ExpirationDate.Equals(other.ExpirationDate)
            ) &&
            (
                IssueDate == other.IssueDate ||
                IssueDate != null &&
                IssueDate.Equals(other.IssueDate)
            ) &&
            (
                Expired == other.Expired ||
                Expired != null &&
                Expired.Equals(other.Expired)
            ) &&
            (
                SignatureValid == other.SignatureValid ||
                SignatureValid != null &&
                SignatureValid.Equals(other.SignatureValid)
            ) &&
            (
                Valid == other.Valid ||
                Valid != null &&
                Valid.Equals(other.Valid)
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
            if (Issuer != null)
            {
                hash = hash * 59 + Issuer.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (ExpirationDate != null)
            {
                hash = hash * 59 + ExpirationDate.GetHashCode();
            }

            if (IssueDate != null)
            {
                hash = hash * 59 + IssueDate.GetHashCode();
            }

            if (Expired != null)
            {
                hash = hash * 59 + Expired.GetHashCode();
            }

            if (SignatureValid != null)
            {
                hash = hash * 59 + SignatureValid.GetHashCode();
            }

            if (Valid != null)
            {
                hash = hash * 59 + Valid.GetHashCode();
            }

            return hash;
        }
    }
}
