using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentMaxUtilizationResponse
/// </summary>
[DataContract]
public partial class AgentMaxUtilizationResponse : IEquatable<AgentMaxUtilizationResponse>
{
    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LevelEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Agent for "Agent"
        /// </summary>
        [EnumMember(Value = "Agent")]
        Agent,

        /// <summary>
        /// Enum Organization for "Organization"
        /// </summary>
        [EnumMember(Value = "Organization")]
        Organization
    }
    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    [DataMember(Name = "level", EmitDefaultValue = false)]
    public LevelEnum? Level { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentMaxUtilizationResponse" /> class.
    /// </summary>
    /// <param name="Utilization">Map of media type to utilization settings..</param>
    /// <param name="LabelUtilizations">Map of label ids to utilization settings..</param>
    /// <param name="Level">Level.</param>
    public AgentMaxUtilizationResponse(Dictionary<string, MediaUtilization> Utilization = null, Dictionary<string, LabelUtilizationResponse> LabelUtilizations = null, LevelEnum? Level = null)
    {
        this.Utilization = Utilization;
        this.LabelUtilizations = LabelUtilizations;
        this.Level = Level;

    }



    /// <summary>
    /// Map of media type to utilization settings.
    /// </summary>
    /// <value>Map of media type to utilization settings.</value>
    [DataMember(Name = "utilization", EmitDefaultValue = false)]
    public Dictionary<string, MediaUtilization> Utilization { get; set; }



    /// <summary>
    /// Map of label ids to utilization settings.
    /// </summary>
    /// <value>Map of label ids to utilization settings.</value>
    [DataMember(Name = "labelUtilizations", EmitDefaultValue = false)]
    public Dictionary<string, LabelUtilizationResponse> LabelUtilizations { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentMaxUtilizationResponse {\n");

        sb.Append("  Utilization: ").Append(Utilization).Append("\n");
        sb.Append("  LabelUtilizations: ").Append(LabelUtilizations).Append("\n");
        sb.Append("  Level: ").Append(Level).Append("\n");
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
        return Equals(obj as AgentMaxUtilizationResponse);
    }

    /// <summary>
    /// Returns true if AgentMaxUtilizationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentMaxUtilizationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentMaxUtilizationResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Utilization == other.Utilization ||
                Utilization != null &&
                Utilization.SequenceEqual(other.Utilization)
            ) &&
            (
                LabelUtilizations == other.LabelUtilizations ||
                LabelUtilizations != null &&
                LabelUtilizations.SequenceEqual(other.LabelUtilizations)
            ) &&
            (
                Level == other.Level ||
                Level != null &&
                Level.Equals(other.Level)
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
            if (Utilization != null)
            {
                hash = hash * 59 + Utilization.GetHashCode();
            }

            if (LabelUtilizations != null)
            {
                hash = hash * 59 + LabelUtilizations.GetHashCode();
            }

            if (Level != null)
            {
                hash = hash * 59 + Level.GetHashCode();
            }

            return hash;
        }
    }
}
