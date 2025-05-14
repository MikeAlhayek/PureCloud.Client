using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsUnresolvedContactChangedTopicPhoneNumber
{
    /// <summary>
    /// Gets or Sets Display
    /// </summary>
    public string Display { get; set; }

    /// <summary>
    /// Gets or Sets Extension
    /// </summary>
    public long? Extension { get; set; }

    /// <summary>
    /// Gets or Sets AcceptsSMS
    /// </summary>
    public bool? AcceptsSMS { get; set; }

    /// <summary>
    /// Gets or Sets UserInput
    /// </summary>
    public string UserInput { get; set; }

    /// <summary>
    /// Gets or Sets E164
    /// </summary>
    public string E164 { get; set; }

    /// <summary>
    /// Gets or Sets CountryCode
    /// </summary>
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or Sets NormalizationCountryCode
    /// </summary>
    public string NormalizationCountryCode { get; set; }
}
