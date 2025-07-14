using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ItemValidationLimits
{
    /// <summary>
    /// A structure denoting the system-imposed minimum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.
    /// </summary>
    /// <value>A structure denoting the system-imposed minimum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.</value>
    public MinLength MinLength { get; set; }

    /// <summary>
    /// A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.
    /// </summary>
    /// <value>A structure denoting the system-imposed minimum and maximum string length (for text-based core types) or numeric values (for number-based) core types.  For example, the validationLimits for a text-based core type specify the min/max values for a minimum string length (minLength) constraint supplied by a schemaauthor on a text field.  Similarly, the maxLength&#39;s min/max specifies maximum string length constraint supplied by a schema author for the same field.</value>
    public MaxLength MaxLength { get; set; }
}
