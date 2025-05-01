using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Coretype
/// </summary>
[DataContract]
public partial class Coretype : IEquatable<Coretype>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Coretype" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">A positive integer denoting the core type&#39;s version.</param>
    /// <param name="DateCreated">The date the core type was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Schema">The core type&#39;s built-in schema.</param>
    /// <param name="Current">A boolean indicating if the core type&#39;s version is the current one in use by the system.</param>
    /// <param name="ValidationFields">An array of strings naming the fields of the core type subject to validation.  Validation constraints are specified by a schema author using the core type..</param>
    /// <param name="ValidationLimits">A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field..</param>
    /// <param name="ItemValidationFields">Specific to the \&quot;tag\&quot; core type, this is an array of strings naming the tag item fields of the core type subject to validation.</param>
    /// <param name="ItemValidationLimits">A structure denoting the system-imposed minimum and maximum string length for string-array based core types such as \&quot;tag\&quot; and \&quot;enum\&quot;.  Forexample, the validationLimits for a schema field using a tag core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schema author on individual tags.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field&#39;s tags..</param>
    public Coretype(string Name = null, int? Version = null, DateTime? DateCreated = null, Schema Schema = null, bool? Current = null, List<string> ValidationFields = null, ValidationLimits ValidationLimits = null, List<string> ItemValidationFields = null, ItemValidationLimits ItemValidationLimits = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.DateCreated = DateCreated;
        this.Schema = Schema;
        this.Current = Current;
        this.ValidationFields = ValidationFields;
        this.ValidationLimits = ValidationLimits;
        this.ItemValidationFields = ItemValidationFields;
        this.ItemValidationLimits = ItemValidationLimits;

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
    /// A positive integer denoting the core type&#39;s version
    /// </summary>
    /// <value>A positive integer denoting the core type&#39;s version</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// The date the core type was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the core type was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The core type&#39;s built-in schema
    /// </summary>
    /// <value>The core type&#39;s built-in schema</value>
    [DataMember(Name = "schema", EmitDefaultValue = false)]
    public Schema Schema { get; set; }



    /// <summary>
    /// A boolean indicating if the core type&#39;s version is the current one in use by the system
    /// </summary>
    /// <value>A boolean indicating if the core type&#39;s version is the current one in use by the system</value>
    [DataMember(Name = "current", EmitDefaultValue = false)]
    public bool? Current { get; set; }



    /// <summary>
    /// An array of strings naming the fields of the core type subject to validation.  Validation constraints are specified by a schema author using the core type.
    /// </summary>
    /// <value>An array of strings naming the fields of the core type subject to validation.  Validation constraints are specified by a schema author using the core type.</value>
    [DataMember(Name = "validationFields", EmitDefaultValue = false)]
    public List<string> ValidationFields { get; set; }



    /// <summary>
    /// A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.
    /// </summary>
    /// <value>A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.</value>
    [DataMember(Name = "validationLimits", EmitDefaultValue = false)]
    public ValidationLimits ValidationLimits { get; set; }



    /// <summary>
    /// Specific to the \&quot;tag\&quot; core type, this is an array of strings naming the tag item fields of the core type subject to validation
    /// </summary>
    /// <value>Specific to the \&quot;tag\&quot; core type, this is an array of strings naming the tag item fields of the core type subject to validation</value>
    [DataMember(Name = "itemValidationFields", EmitDefaultValue = false)]
    public List<string> ItemValidationFields { get; set; }



    /// <summary>
    /// A structure denoting the system-imposed minimum and maximum string length for string-array based core types such as \&quot;tag\&quot; and \&quot;enum\&quot;.  Forexample, the validationLimits for a schema field using a tag core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schema author on individual tags.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field&#39;s tags.
    /// </summary>
    /// <value>A structure denoting the system-imposed minimum and maximum string length for string-array based core types such as \&quot;tag\&quot; and \&quot;enum\&quot;.  Forexample, the validationLimits for a schema field using a tag core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schema author on individual tags.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field&#39;s tags.</value>
    [DataMember(Name = "itemValidationLimits", EmitDefaultValue = false)]
    public ItemValidationLimits ItemValidationLimits { get; set; }



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
        sb.Append("class Coretype {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  Current: ").Append(Current).Append("\n");
        sb.Append("  ValidationFields: ").Append(ValidationFields).Append("\n");
        sb.Append("  ValidationLimits: ").Append(ValidationLimits).Append("\n");
        sb.Append("  ItemValidationFields: ").Append(ItemValidationFields).Append("\n");
        sb.Append("  ItemValidationLimits: ").Append(ItemValidationLimits).Append("\n");
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
        return Equals(obj as Coretype);
    }

    /// <summary>
    /// Returns true if Coretype instances are equal
    /// </summary>
    /// <param name="other">Instance of Coretype to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Coretype other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                Schema == other.Schema ||
                Schema != null &&
                Schema.Equals(other.Schema)
            ) &&
            (
                Current == other.Current ||
                Current != null &&
                Current.Equals(other.Current)
            ) &&
            (
                ValidationFields == other.ValidationFields ||
                ValidationFields != null &&
                ValidationFields.SequenceEqual(other.ValidationFields)
            ) &&
            (
                ValidationLimits == other.ValidationLimits ||
                ValidationLimits != null &&
                ValidationLimits.Equals(other.ValidationLimits)
            ) &&
            (
                ItemValidationFields == other.ItemValidationFields ||
                ItemValidationFields != null &&
                ItemValidationFields.SequenceEqual(other.ItemValidationFields)
            ) &&
            (
                ItemValidationLimits == other.ItemValidationLimits ||
                ItemValidationLimits != null &&
                ItemValidationLimits.Equals(other.ItemValidationLimits)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (Current != null)
            {
                hash = hash * 59 + Current.GetHashCode();
            }

            if (ValidationFields != null)
            {
                hash = hash * 59 + ValidationFields.GetHashCode();
            }

            if (ValidationLimits != null)
            {
                hash = hash * 59 + ValidationLimits.GetHashCode();
            }

            if (ItemValidationFields != null)
            {
                hash = hash * 59 + ItemValidationFields.GetHashCode();
            }

            if (ItemValidationLimits != null)
            {
                hash = hash * 59 + ItemValidationLimits.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
