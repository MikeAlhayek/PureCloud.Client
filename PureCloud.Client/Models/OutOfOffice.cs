using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// OutOfOffice
/// </summary>
[DataContract]
public partial class OutOfOffice : IEquatable<OutOfOffice>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutOfOffice" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="User">User.</param>
    /// <param name="StartDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Active">Active.</param>
    /// <param name="Indefinite">Indefinite.</param>
    public OutOfOffice(string Name = null, User User = null, DateTime? StartDate = null, DateTime? EndDate = null, bool? Active = null, bool? Indefinite = null)
    {
        this.Name = Name;
        this.User = User;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.Active = Active;
        this.Indefinite = Indefinite;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public User User { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name = "active", EmitDefaultValue = false)]
    public bool? Active { get; set; }



    /// <summary>
    /// Gets or Sets Indefinite
    /// </summary>
    [DataMember(Name = "indefinite", EmitDefaultValue = false)]
    public bool? Indefinite { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutOfOffice {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  Indefinite: ").Append(Indefinite).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as OutOfOffice);
    }

    /// <summary>
    /// Returns true if OutOfOffice instances are equal
    /// </summary>
    /// <param name="other">Instance of OutOfOffice to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutOfOffice other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
            ) &&
            (
                Indefinite == other.Indefinite ||
                Indefinite != null &&
                Indefinite.Equals(other.Indefinite)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (Indefinite != null)
            {
                hash = hash * 59 + Indefinite.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
