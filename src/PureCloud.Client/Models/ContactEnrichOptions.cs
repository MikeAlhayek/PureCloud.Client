using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactEnrichOptions
{
    /// <summary>
    /// If true, any matched contact will have its type updated to Curated. If false, any matched contact will keep its original type in the operation.
    /// </summary>
    /// <value>If true, any matched contact will have its type updated to Curated. If false, any matched contact will keep its original type in the operation.</value>
    public bool? Promote { get; set; }
}
