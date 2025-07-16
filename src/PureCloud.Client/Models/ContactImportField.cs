using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactImportField
{
    /// <summary>
    /// Field name
    /// </summary>
    /// <value>Field name</value>
    public string Name { get; set; }

    /// <summary>
    /// Should we import this field
    /// </summary>
    /// <value>Should we import this field</value>
    public bool? Included { get; set; }
}
