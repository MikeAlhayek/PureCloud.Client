using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// GDPRSubject
/// </summary>
[DataContract]
public partial class GDPRSubject : IEquatable<GDPRSubject>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GDPRSubject" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="UserId">UserId.</param>
    /// <param name="ExternalContactId">ExternalContactId.</param>
    /// <param name="DialerContactId">DialerContactId.</param>
    /// <param name="JourneyCustomer">JourneyCustomer.</param>
    /// <param name="SocialHandle">SocialHandle.</param>
    /// <param name="ExternalId">ExternalId.</param>
    /// <param name="Addresses">Addresses.</param>
    /// <param name="PhoneNumbers">PhoneNumbers.</param>
    /// <param name="EmailAddresses">EmailAddresses.</param>
    public GDPRSubject(string Name = null, string UserId = null, string ExternalContactId = null, DialerContactId DialerContactId = null, GDPRJourneyCustomer JourneyCustomer = null, SocialHandle SocialHandle = null, string ExternalId = null, List<string> Addresses = null, List<string> PhoneNumbers = null, List<string> EmailAddresses = null)
    {
        this.Name = Name;
        this.UserId = UserId;
        this.ExternalContactId = ExternalContactId;
        this.DialerContactId = DialerContactId;
        this.JourneyCustomer = JourneyCustomer;
        this.SocialHandle = SocialHandle;
        this.ExternalId = ExternalId;
        this.Addresses = Addresses;
        this.PhoneNumbers = PhoneNumbers;
        this.EmailAddresses = EmailAddresses;

    }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContactId
    /// </summary>
    [DataMember(Name = "externalContactId", EmitDefaultValue = false)]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// Gets or Sets DialerContactId
    /// </summary>
    [DataMember(Name = "dialerContactId", EmitDefaultValue = false)]
    public DialerContactId DialerContactId { get; set; }



    /// <summary>
    /// Gets or Sets JourneyCustomer
    /// </summary>
    [DataMember(Name = "journeyCustomer", EmitDefaultValue = false)]
    public GDPRJourneyCustomer JourneyCustomer { get; set; }



    /// <summary>
    /// Gets or Sets SocialHandle
    /// </summary>
    [DataMember(Name = "socialHandle", EmitDefaultValue = false)]
    public SocialHandle SocialHandle { get; set; }



    /// <summary>
    /// Gets or Sets ExternalId
    /// </summary>
    [DataMember(Name = "externalId", EmitDefaultValue = false)]
    public string ExternalId { get; set; }



    /// <summary>
    /// Gets or Sets Addresses
    /// </summary>
    [DataMember(Name = "addresses", EmitDefaultValue = false)]
    public List<string> Addresses { get; set; }



    /// <summary>
    /// Gets or Sets PhoneNumbers
    /// </summary>
    [DataMember(Name = "phoneNumbers", EmitDefaultValue = false)]
    public List<string> PhoneNumbers { get; set; }



    /// <summary>
    /// Gets or Sets EmailAddresses
    /// </summary>
    [DataMember(Name = "emailAddresses", EmitDefaultValue = false)]
    public List<string> EmailAddresses { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GDPRSubject {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  DialerContactId: ").Append(DialerContactId).Append("\n");
        sb.Append("  JourneyCustomer: ").Append(JourneyCustomer).Append("\n");
        sb.Append("  SocialHandle: ").Append(SocialHandle).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
        sb.Append("  Addresses: ").Append(Addresses).Append("\n");
        sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
        sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
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
        return Equals(obj as GDPRSubject);
    }

    /// <summary>
    /// Returns true if GDPRSubject instances are equal
    /// </summary>
    /// <param name="other">Instance of GDPRSubject to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GDPRSubject other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                DialerContactId == other.DialerContactId ||
                DialerContactId != null &&
                DialerContactId.Equals(other.DialerContactId)
            ) &&
            (
                JourneyCustomer == other.JourneyCustomer ||
                JourneyCustomer != null &&
                JourneyCustomer.Equals(other.JourneyCustomer)
            ) &&
            (
                SocialHandle == other.SocialHandle ||
                SocialHandle != null &&
                SocialHandle.Equals(other.SocialHandle)
            ) &&
            (
                ExternalId == other.ExternalId ||
                ExternalId != null &&
                ExternalId.Equals(other.ExternalId)
            ) &&
            (
                Addresses == other.Addresses ||
                Addresses != null &&
                Addresses.SequenceEqual(other.Addresses)
            ) &&
            (
                PhoneNumbers == other.PhoneNumbers ||
                PhoneNumbers != null &&
                PhoneNumbers.SequenceEqual(other.PhoneNumbers)
            ) &&
            (
                EmailAddresses == other.EmailAddresses ||
                EmailAddresses != null &&
                EmailAddresses.SequenceEqual(other.EmailAddresses)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (DialerContactId != null)
            {
                hash = hash * 59 + DialerContactId.GetHashCode();
            }

            if (JourneyCustomer != null)
            {
                hash = hash * 59 + JourneyCustomer.GetHashCode();
            }

            if (SocialHandle != null)
            {
                hash = hash * 59 + SocialHandle.GetHashCode();
            }

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            if (Addresses != null)
            {
                hash = hash * 59 + Addresses.GetHashCode();
            }

            if (PhoneNumbers != null)
            {
                hash = hash * 59 + PhoneNumbers.GetHashCode();
            }

            if (EmailAddresses != null)
            {
                hash = hash * 59 + EmailAddresses.GetHashCode();
            }

            return hash;
        }
    }
}
