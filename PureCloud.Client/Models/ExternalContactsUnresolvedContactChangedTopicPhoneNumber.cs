using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsUnresolvedContactChangedTopicPhoneNumber
/// </summary>
[DataContract]
public partial class ExternalContactsUnresolvedContactChangedTopicPhoneNumber : IEquatable<ExternalContactsUnresolvedContactChangedTopicPhoneNumber>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicPhoneNumber" /> class.
    /// </summary>
    /// <param name="Display">Display.</param>
    /// <param name="Extension">Extension.</param>
    /// <param name="AcceptsSMS">AcceptsSMS.</param>
    /// <param name="UserInput">UserInput.</param>
    /// <param name="E164">E164.</param>
    /// <param name="CountryCode">CountryCode.</param>
    /// <param name="NormalizationCountryCode">NormalizationCountryCode.</param>
    public ExternalContactsUnresolvedContactChangedTopicPhoneNumber(string Display = null, long? Extension = null, bool? AcceptsSMS = null, string UserInput = null, string E164 = null, string CountryCode = null, string NormalizationCountryCode = null)
    {
        this.Display = Display;
        this.Extension = Extension;
        this.AcceptsSMS = AcceptsSMS;
        this.UserInput = UserInput;
        this.E164 = E164;
        this.CountryCode = CountryCode;
        this.NormalizationCountryCode = NormalizationCountryCode;

    }



    /// <summary>
    /// Gets or Sets Display
    /// </summary>
    [DataMember(Name = "display", EmitDefaultValue = false)]
    public string Display { get; set; }



    /// <summary>
    /// Gets or Sets Extension
    /// </summary>
    [DataMember(Name = "extension", EmitDefaultValue = false)]
    public long? Extension { get; set; }



    /// <summary>
    /// Gets or Sets AcceptsSMS
    /// </summary>
    [DataMember(Name = "acceptsSMS", EmitDefaultValue = false)]
    public bool? AcceptsSMS { get; set; }



    /// <summary>
    /// Gets or Sets UserInput
    /// </summary>
    [DataMember(Name = "userInput", EmitDefaultValue = false)]
    public string UserInput { get; set; }



    /// <summary>
    /// Gets or Sets E164
    /// </summary>
    [DataMember(Name = "e164", EmitDefaultValue = false)]
    public string E164 { get; set; }



    /// <summary>
    /// Gets or Sets CountryCode
    /// </summary>
    [DataMember(Name = "countryCode", EmitDefaultValue = false)]
    public string CountryCode { get; set; }



    /// <summary>
    /// Gets or Sets NormalizationCountryCode
    /// </summary>
    [DataMember(Name = "normalizationCountryCode", EmitDefaultValue = false)]
    public string NormalizationCountryCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsUnresolvedContactChangedTopicPhoneNumber {\n");

        sb.Append("  Display: ").Append(Display).Append("\n");
        sb.Append("  Extension: ").Append(Extension).Append("\n");
        sb.Append("  AcceptsSMS: ").Append(AcceptsSMS).Append("\n");
        sb.Append("  UserInput: ").Append(UserInput).Append("\n");
        sb.Append("  E164: ").Append(E164).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  NormalizationCountryCode: ").Append(NormalizationCountryCode).Append("\n");
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
        return Equals(obj as ExternalContactsUnresolvedContactChangedTopicPhoneNumber);
    }

    /// <summary>
    /// Returns true if ExternalContactsUnresolvedContactChangedTopicPhoneNumber instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicPhoneNumber to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsUnresolvedContactChangedTopicPhoneNumber other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Display == other.Display ||
                Display != null &&
                Display.Equals(other.Display)
            ) &&
            (
                Extension == other.Extension ||
                Extension != null &&
                Extension.Equals(other.Extension)
            ) &&
            (
                AcceptsSMS == other.AcceptsSMS ||
                AcceptsSMS != null &&
                AcceptsSMS.Equals(other.AcceptsSMS)
            ) &&
            (
                UserInput == other.UserInput ||
                UserInput != null &&
                UserInput.Equals(other.UserInput)
            ) &&
            (
                E164 == other.E164 ||
                E164 != null &&
                E164.Equals(other.E164)
            ) &&
            (
                CountryCode == other.CountryCode ||
                CountryCode != null &&
                CountryCode.Equals(other.CountryCode)
            ) &&
            (
                NormalizationCountryCode == other.NormalizationCountryCode ||
                NormalizationCountryCode != null &&
                NormalizationCountryCode.Equals(other.NormalizationCountryCode)
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
            if (Display != null)
            {
                hash = hash * 59 + Display.GetHashCode();
            }

            if (Extension != null)
            {
                hash = hash * 59 + Extension.GetHashCode();
            }

            if (AcceptsSMS != null)
            {
                hash = hash * 59 + AcceptsSMS.GetHashCode();
            }

            if (UserInput != null)
            {
                hash = hash * 59 + UserInput.GetHashCode();
            }

            if (E164 != null)
            {
                hash = hash * 59 + E164.GetHashCode();
            }

            if (CountryCode != null)
            {
                hash = hash * 59 + CountryCode.GetHashCode();
            }

            if (NormalizationCountryCode != null)
            {
                hash = hash * 59 + NormalizationCountryCode.GetHashCode();
            }

            return hash;
        }
    }
}
