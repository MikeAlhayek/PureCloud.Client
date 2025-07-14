using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Coretype
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// A positive integer denoting the core type&#39;s version
    /// </summary>
    /// <value>A positive integer denoting the core type&#39;s version</value>
    public int? Version { get; set; }

    /// <summary>
    /// The date the core type was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the core type was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The core type&#39;s built-in schema
    /// </summary>
    /// <value>The core type&#39;s built-in schema</value>
    public Schema Schema { get; set; }

    /// <summary>
    /// A boolean indicating if the core type&#39;s version is the current one in use by the system
    /// </summary>
    /// <value>A boolean indicating if the core type&#39;s version is the current one in use by the system</value>
    public bool? Current { get; set; }

    /// <summary>
    /// An array of strings naming the fields of the core type subject to validation.  Validation constraints are specified by a schema author using the core type.
    /// </summary>
    /// <value>An array of strings naming the fields of the core type subject to validation.  Validation constraints are specified by a schema author using the core type.</value>
    public IEnumerable<string> ValidationFields { get; set; }

    /// <summary>
    /// A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.
    /// </summary>
    /// <value>A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.</value>
    public ValidationLimits ValidationLimits { get; set; }

    /// <summary>
    /// Specific to the \&quot;tag\&quot; core type, this is an array of strings naming the tag item fields of the core type subject to validation
    /// </summary>
    /// <value>Specific to the \&quot;tag\&quot; core type, this is an array of strings naming the tag item fields of the core type subject to validation</value>
    public IEnumerable<string> ItemValidationFields { get; set; }

    /// <summary>
    /// A structure denoting the system-imposed minimum and maximum string length for string-array based core types such as \&quot;tag\&quot; and \&quot;enum\&quot;.  Forexample, the validationLimits for a schema field using a tag core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schema author on individual tags.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field&#39;s tags.
    /// </summary>
    public ItemValidationLimits ItemValidationLimits { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
