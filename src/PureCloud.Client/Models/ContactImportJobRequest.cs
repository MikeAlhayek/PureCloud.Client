using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactImportJobRequest
{
    /// <summary>
    /// Settings id
    /// </summary>
    /// <value>Settings id</value>
    public string SettingsId { get; set; }
}
