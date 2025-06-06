using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactListDivisionView
/// </summary>

public partial class ContactListDivisionView : IEquatable<ContactListDivisionView>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactListDivisionView" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactListDivisionView() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactListDivisionView" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="ColumnNames">The names of the contact data columns. (required).</param>
    /// <param name="PhoneColumns">Indicates which columns are phone numbers..</param>
    /// <param name="EmailColumns">Indicates which columns are email addresses..</param>
    /// <param name="WhatsAppColumns">Indicates which columns are whatsApp contacts..</param>
    public ContactListDivisionView(string Name = null, Division Division = null, List<string> ColumnNames = null, List<ContactPhoneNumberColumn> PhoneColumns = null, List<EmailColumn> EmailColumns = null, List<WhatsAppColumn> WhatsAppColumns = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.ColumnNames = ColumnNames;
        this.PhoneColumns = PhoneColumns;
        this.EmailColumns = EmailColumns;
        this.WhatsAppColumns = WhatsAppColumns;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public Division Division { get; set; }



    /// <summary>
    /// The names of the contact data columns.
    /// </summary>
    /// <value>The names of the contact data columns.</value>
    [JsonPropertyName("columnNames")]
    public List<string> ColumnNames { get; set; }



    /// <summary>
    /// Indicates which columns are phone numbers.
    /// </summary>
    /// <value>Indicates which columns are phone numbers.</value>
    [JsonPropertyName("phoneColumns")]
    public List<ContactPhoneNumberColumn> PhoneColumns { get; set; }



    /// <summary>
    /// Indicates which columns are email addresses.
    /// </summary>
    /// <value>Indicates which columns are email addresses.</value>
    [JsonPropertyName("emailColumns")]
    public List<EmailColumn> EmailColumns { get; set; }



    /// <summary>
    /// Indicates which columns are whatsApp contacts.
    /// </summary>
    /// <value>Indicates which columns are whatsApp contacts.</value>
    [JsonPropertyName("whatsAppColumns")]
    public List<WhatsAppColumn> WhatsAppColumns { get; set; }



    /// <summary>
    /// The status of the import process.
    /// </summary>
    /// <value>The status of the import process.</value>
    [JsonPropertyName("importStatus")]
    public ImportStatus ImportStatus { get; set; }



    /// <summary>
    /// The number of contacts in the ContactList.
    /// </summary>
    /// <value>The number of contacts in the ContactList.</value>
    [JsonPropertyName("size")]
    public long? Size { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactListDivisionView {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
        sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
        sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
        sb.Append("  WhatsAppColumns: ").Append(WhatsAppColumns).Append("\n");
        sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
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
        return Equals(obj as ContactListDivisionView);
    }

    /// <summary>
    /// Returns true if ContactListDivisionView instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactListDivisionView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactListDivisionView other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                ColumnNames == other.ColumnNames ||
                ColumnNames != null &&
                ColumnNames.SequenceEqual(other.ColumnNames)
            ) &&
            (
                PhoneColumns == other.PhoneColumns ||
                PhoneColumns != null &&
                PhoneColumns.SequenceEqual(other.PhoneColumns)
            ) &&
            (
                EmailColumns == other.EmailColumns ||
                EmailColumns != null &&
                EmailColumns.SequenceEqual(other.EmailColumns)
            ) &&
            (
                WhatsAppColumns == other.WhatsAppColumns ||
                WhatsAppColumns != null &&
                WhatsAppColumns.SequenceEqual(other.WhatsAppColumns)
            ) &&
            (
                ImportStatus == other.ImportStatus ||
                ImportStatus != null &&
                ImportStatus.Equals(other.ImportStatus)
            ) &&
            (
                Size == other.Size ||
                Size != null &&
                Size.Equals(other.Size)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (ColumnNames != null)
            {
                hash = hash * 59 + ColumnNames.GetHashCode();
            }

            if (PhoneColumns != null)
            {
                hash = hash * 59 + PhoneColumns.GetHashCode();
            }

            if (EmailColumns != null)
            {
                hash = hash * 59 + EmailColumns.GetHashCode();
            }

            if (WhatsAppColumns != null)
            {
                hash = hash * 59 + WhatsAppColumns.GetHashCode();
            }

            if (ImportStatus != null)
            {
                hash = hash * 59 + ImportStatus.GetHashCode();
            }

            if (Size != null)
            {
                hash = hash * 59 + Size.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
