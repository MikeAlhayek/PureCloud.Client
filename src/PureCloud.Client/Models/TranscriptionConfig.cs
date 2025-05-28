using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TranscriptionConfig
{
    /// <summary>
    /// The name of the vendor used for speech transcription.
    /// </summary>
    /// <value>The name of the vendor used for speech transcription.</value>
    public TranscriptionConfigVendorNameEnum? VendorName { get; set; }
}
