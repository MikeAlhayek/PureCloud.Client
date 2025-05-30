using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Model for setting the launch configuration for Nuance bots available to Genesys Cloud
/// </summary>

public partial class NuanceBotLaunchSettings : IEquatable<NuanceBotLaunchSettings>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceBotLaunchSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NuanceBotLaunchSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceBotLaunchSettings" /> class.
    /// </summary>
    /// <param name="BotExecutionConfigurations">The list of Nuance bots that are configured as available to the Genesys Cloud system (required).</param>
    public NuanceBotLaunchSettings(List<BotExecutionConfiguration> BotExecutionConfigurations = null)
    {
        this.BotExecutionConfigurations = BotExecutionConfigurations;

    }



    /// <summary>
    /// The list of Nuance bots that are configured as available to the Genesys Cloud system
    /// </summary>
    /// <value>The list of Nuance bots that are configured as available to the Genesys Cloud system</value>
    [JsonPropertyName("botExecutionConfigurations")]
    public List<BotExecutionConfiguration> BotExecutionConfigurations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NuanceBotLaunchSettings {\n");

        sb.Append("  BotExecutionConfigurations: ").Append(BotExecutionConfigurations).Append("\n");
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
        return Equals(obj as NuanceBotLaunchSettings);
    }

    /// <summary>
    /// Returns true if NuanceBotLaunchSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of NuanceBotLaunchSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NuanceBotLaunchSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BotExecutionConfigurations == other.BotExecutionConfigurations ||
                BotExecutionConfigurations != null &&
                BotExecutionConfigurations.SequenceEqual(other.BotExecutionConfigurations)
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
            if (BotExecutionConfigurations != null)
            {
                hash = hash * 59 + BotExecutionConfigurations.GetHashCode();
            }

            return hash;
        }
    }
}
