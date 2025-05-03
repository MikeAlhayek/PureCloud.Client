using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Model for setting the launch configuration for a Nuance bot available to Genesys Cloud
/// </summary>

public partial class BotExecutionConfiguration : IEquatable<BotExecutionConfiguration>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BotExecutionConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BotExecutionConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BotExecutionConfiguration" /> class.
    /// </summary>
    /// <param name="BotId">The Nuance bot ID (required).</param>
    /// <param name="ExecutionHost">The hostname to use when contacting Nuance to execute this bot (required).</param>
    /// <param name="BotCredentials">The bot&#39;s launch credentials (required).</param>
    public BotExecutionConfiguration(string BotId = null, string ExecutionHost = null, NuanceBotCredentials BotCredentials = null)
    {
        this.BotId = BotId;
        this.ExecutionHost = ExecutionHost;
        this.BotCredentials = BotCredentials;

    }



    /// <summary>
    /// The Nuance bot ID
    /// </summary>
    /// <value>The Nuance bot ID</value>
    [JsonPropertyName("botId")]
    public string BotId { get; set; }



    /// <summary>
    /// The hostname to use when contacting Nuance to execute this bot
    /// </summary>
    /// <value>The hostname to use when contacting Nuance to execute this bot</value>
    [JsonPropertyName("executionHost")]
    public string ExecutionHost { get; set; }



    /// <summary>
    /// The bot&#39;s launch credentials
    /// </summary>
    /// <value>The bot&#39;s launch credentials</value>
    [JsonPropertyName("botCredentials")]
    public NuanceBotCredentials BotCredentials { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BotExecutionConfiguration {\n");

        sb.Append("  BotId: ").Append(BotId).Append("\n");
        sb.Append("  ExecutionHost: ").Append(ExecutionHost).Append("\n");
        sb.Append("  BotCredentials: ").Append(BotCredentials).Append("\n");
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
        return Equals(obj as BotExecutionConfiguration);
    }

    /// <summary>
    /// Returns true if BotExecutionConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of BotExecutionConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BotExecutionConfiguration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BotId == other.BotId ||
                BotId != null &&
                BotId.Equals(other.BotId)
            ) &&
            (
                ExecutionHost == other.ExecutionHost ||
                ExecutionHost != null &&
                ExecutionHost.Equals(other.ExecutionHost)
            ) &&
            (
                BotCredentials == other.BotCredentials ||
                BotCredentials != null &&
                BotCredentials.Equals(other.BotCredentials)
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
            if (BotId != null)
            {
                hash = hash * 59 + BotId.GetHashCode();
            }

            if (ExecutionHost != null)
            {
                hash = hash * 59 + ExecutionHost.GetHashCode();
            }

            if (BotCredentials != null)
            {
                hash = hash * 59 + BotCredentials.GetHashCode();
            }

            return hash;
        }
    }
}
