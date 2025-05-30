using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NuanceMixDlgSettings
/// </summary>

public partial class NuanceMixDlgSettings : IEquatable<NuanceMixDlgSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceMixDlgSettings" /> class.
    /// </summary>
    /// <param name="ChannelId">The Nuance channel ID to use when launching the Nuance bot, which must one of the code names of the bot&#39;s registered input channels..</param>
    /// <param name="InputParameters">Name/value pairs of input variables to be sent to the Nuance bot. The values must be in the appropriate format for the variable&#39;s type (see https://docs.mix.nuance.com/dialog-grpc/v1/#simple-variable-types for help).</param>
    public NuanceMixDlgSettings(string ChannelId = null, Dictionary<string, object> InputParameters = null)
    {
        this.ChannelId = ChannelId;
        this.InputParameters = InputParameters;

    }



    /// <summary>
    /// The Nuance channel ID to use when launching the Nuance bot, which must one of the code names of the bot&#39;s registered input channels.
    /// </summary>
    /// <value>The Nuance channel ID to use when launching the Nuance bot, which must one of the code names of the bot&#39;s registered input channels.</value>
    [JsonPropertyName("channelId")]
    public string ChannelId { get; set; }



    /// <summary>
    /// Name/value pairs of input variables to be sent to the Nuance bot. The values must be in the appropriate format for the variable&#39;s type (see https://docs.mix.nuance.com/dialog-grpc/v1/#simple-variable-types for help)
    /// </summary>
    /// <value>Name/value pairs of input variables to be sent to the Nuance bot. The values must be in the appropriate format for the variable&#39;s type (see https://docs.mix.nuance.com/dialog-grpc/v1/#simple-variable-types for help)</value>
    [JsonPropertyName("inputParameters")]
    public Dictionary<string, object> InputParameters { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NuanceMixDlgSettings {\n");

        sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
        sb.Append("  InputParameters: ").Append(InputParameters).Append("\n");
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
        return Equals(obj as NuanceMixDlgSettings);
    }

    /// <summary>
    /// Returns true if NuanceMixDlgSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of NuanceMixDlgSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NuanceMixDlgSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ChannelId == other.ChannelId ||
                ChannelId != null &&
                ChannelId.Equals(other.ChannelId)
            ) &&
            (
                InputParameters == other.InputParameters ||
                InputParameters != null &&
                InputParameters.SequenceEqual(other.InputParameters)
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
            if (ChannelId != null)
            {
                hash = hash * 59 + ChannelId.GetHashCode();
            }

            if (InputParameters != null)
            {
                hash = hash * 59 + InputParameters.GetHashCode();
            }

            return hash;
        }
    }
}
