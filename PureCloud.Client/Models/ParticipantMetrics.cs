using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ParticipantMetrics
/// </summary>
[DataContract]
public partial class ParticipantMetrics : IEquatable<ParticipantMetrics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ParticipantMetrics" /> class.
    /// </summary>
    /// <param name="AgentDurationPercentage">Percentage of Agent duration in the conversation.</param>
    /// <param name="CustomerDurationPercentage">Percentage of Customer duration in the conversation.</param>
    /// <param name="SilenceDurationPercentage">Percentage of Silence duration in the conversation.</param>
    /// <param name="IvrDurationPercentage">Percentage of IVR duration in the conversation.</param>
    /// <param name="AcdDurationPercentage">Percentage of ACD duration in the conversation.</param>
    /// <param name="OvertalkDurationPercentage">Percentage of Overtalk duration in the conversation.</param>
    /// <param name="OtherDurationPercentage">Percentage of Other events duration in the conversation.</param>
    /// <param name="OvertalkCount">Number of Overtalks in the conversation.</param>
    public ParticipantMetrics(double? AgentDurationPercentage = null, double? CustomerDurationPercentage = null, double? SilenceDurationPercentage = null, double? IvrDurationPercentage = null, double? AcdDurationPercentage = null, double? OvertalkDurationPercentage = null, double? OtherDurationPercentage = null, int? OvertalkCount = null)
    {
        this.AgentDurationPercentage = AgentDurationPercentage;
        this.CustomerDurationPercentage = CustomerDurationPercentage;
        this.SilenceDurationPercentage = SilenceDurationPercentage;
        this.IvrDurationPercentage = IvrDurationPercentage;
        this.AcdDurationPercentage = AcdDurationPercentage;
        this.OvertalkDurationPercentage = OvertalkDurationPercentage;
        this.OtherDurationPercentage = OtherDurationPercentage;
        this.OvertalkCount = OvertalkCount;

    }



    /// <summary>
    /// Percentage of Agent duration in the conversation
    /// </summary>
    /// <value>Percentage of Agent duration in the conversation</value>
    [DataMember(Name = "agentDurationPercentage", EmitDefaultValue = false)]
    public double? AgentDurationPercentage { get; set; }



    /// <summary>
    /// Percentage of Customer duration in the conversation
    /// </summary>
    /// <value>Percentage of Customer duration in the conversation</value>
    [DataMember(Name = "customerDurationPercentage", EmitDefaultValue = false)]
    public double? CustomerDurationPercentage { get; set; }



    /// <summary>
    /// Percentage of Silence duration in the conversation
    /// </summary>
    /// <value>Percentage of Silence duration in the conversation</value>
    [DataMember(Name = "silenceDurationPercentage", EmitDefaultValue = false)]
    public double? SilenceDurationPercentage { get; set; }



    /// <summary>
    /// Percentage of IVR duration in the conversation
    /// </summary>
    /// <value>Percentage of IVR duration in the conversation</value>
    [DataMember(Name = "ivrDurationPercentage", EmitDefaultValue = false)]
    public double? IvrDurationPercentage { get; set; }



    /// <summary>
    /// Percentage of ACD duration in the conversation
    /// </summary>
    /// <value>Percentage of ACD duration in the conversation</value>
    [DataMember(Name = "acdDurationPercentage", EmitDefaultValue = false)]
    public double? AcdDurationPercentage { get; set; }



    /// <summary>
    /// Percentage of Overtalk duration in the conversation
    /// </summary>
    /// <value>Percentage of Overtalk duration in the conversation</value>
    [DataMember(Name = "overtalkDurationPercentage", EmitDefaultValue = false)]
    public double? OvertalkDurationPercentage { get; set; }



    /// <summary>
    /// Percentage of Other events duration in the conversation
    /// </summary>
    /// <value>Percentage of Other events duration in the conversation</value>
    [DataMember(Name = "otherDurationPercentage", EmitDefaultValue = false)]
    public double? OtherDurationPercentage { get; set; }



    /// <summary>
    /// Number of Overtalks in the conversation
    /// </summary>
    /// <value>Number of Overtalks in the conversation</value>
    [DataMember(Name = "overtalkCount", EmitDefaultValue = false)]
    public int? OvertalkCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ParticipantMetrics {\n");

        sb.Append("  AgentDurationPercentage: ").Append(AgentDurationPercentage).Append("\n");
        sb.Append("  CustomerDurationPercentage: ").Append(CustomerDurationPercentage).Append("\n");
        sb.Append("  SilenceDurationPercentage: ").Append(SilenceDurationPercentage).Append("\n");
        sb.Append("  IvrDurationPercentage: ").Append(IvrDurationPercentage).Append("\n");
        sb.Append("  AcdDurationPercentage: ").Append(AcdDurationPercentage).Append("\n");
        sb.Append("  OvertalkDurationPercentage: ").Append(OvertalkDurationPercentage).Append("\n");
        sb.Append("  OtherDurationPercentage: ").Append(OtherDurationPercentage).Append("\n");
        sb.Append("  OvertalkCount: ").Append(OvertalkCount).Append("\n");
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
        return Equals(obj as ParticipantMetrics);
    }

    /// <summary>
    /// Returns true if ParticipantMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of ParticipantMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ParticipantMetrics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AgentDurationPercentage == other.AgentDurationPercentage ||
                AgentDurationPercentage != null &&
                AgentDurationPercentage.Equals(other.AgentDurationPercentage)
            ) &&
            (
                CustomerDurationPercentage == other.CustomerDurationPercentage ||
                CustomerDurationPercentage != null &&
                CustomerDurationPercentage.Equals(other.CustomerDurationPercentage)
            ) &&
            (
                SilenceDurationPercentage == other.SilenceDurationPercentage ||
                SilenceDurationPercentage != null &&
                SilenceDurationPercentage.Equals(other.SilenceDurationPercentage)
            ) &&
            (
                IvrDurationPercentage == other.IvrDurationPercentage ||
                IvrDurationPercentage != null &&
                IvrDurationPercentage.Equals(other.IvrDurationPercentage)
            ) &&
            (
                AcdDurationPercentage == other.AcdDurationPercentage ||
                AcdDurationPercentage != null &&
                AcdDurationPercentage.Equals(other.AcdDurationPercentage)
            ) &&
            (
                OvertalkDurationPercentage == other.OvertalkDurationPercentage ||
                OvertalkDurationPercentage != null &&
                OvertalkDurationPercentage.Equals(other.OvertalkDurationPercentage)
            ) &&
            (
                OtherDurationPercentage == other.OtherDurationPercentage ||
                OtherDurationPercentage != null &&
                OtherDurationPercentage.Equals(other.OtherDurationPercentage)
            ) &&
            (
                OvertalkCount == other.OvertalkCount ||
                OvertalkCount != null &&
                OvertalkCount.Equals(other.OvertalkCount)
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
            if (AgentDurationPercentage != null)
            {
                hash = hash * 59 + AgentDurationPercentage.GetHashCode();
            }

            if (CustomerDurationPercentage != null)
            {
                hash = hash * 59 + CustomerDurationPercentage.GetHashCode();
            }

            if (SilenceDurationPercentage != null)
            {
                hash = hash * 59 + SilenceDurationPercentage.GetHashCode();
            }

            if (IvrDurationPercentage != null)
            {
                hash = hash * 59 + IvrDurationPercentage.GetHashCode();
            }

            if (AcdDurationPercentage != null)
            {
                hash = hash * 59 + AcdDurationPercentage.GetHashCode();
            }

            if (OvertalkDurationPercentage != null)
            {
                hash = hash * 59 + OvertalkDurationPercentage.GetHashCode();
            }

            if (OtherDurationPercentage != null)
            {
                hash = hash * 59 + OtherDurationPercentage.GetHashCode();
            }

            if (OvertalkCount != null)
            {
                hash = hash * 59 + OvertalkCount.GetHashCode();
            }

            return hash;
        }
    }
}
