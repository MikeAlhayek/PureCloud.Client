using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkErrorDetail
{
    /// <summary>
    /// The name of the field which experienced an error.
    /// </summary>
    /// <value>The name of the field which experienced an error.</value>
    public string FieldName { get; set; }

    /// <summary>
    /// The field value from the request which caused the error.
    /// </summary>
    /// <value>The field value from the request which caused the error.</value>
    public string Value { get; set; }

    /// <summary>
    /// A field-specific error message describing why this operation was rejected.
    /// </summary>
    /// <value>A field-specific error message describing why this operation was rejected.</value>
    public string Message { get; set; }
}
