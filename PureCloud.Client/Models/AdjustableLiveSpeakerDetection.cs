using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdjustableLiveSpeakerDetection
/// </summary>
[DataContract]
public partial class AdjustableLiveSpeakerDetection : IEquatable<AdjustableLiveSpeakerDetection>
{
    /// <summary>
    /// Modes to tune between speed to live speaker detection vs accuracy.
    /// </summary>
    /// <value>Modes to tune between speed to live speaker detection vs accuracy.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Disabled for "disabled"
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,

        /// <summary>
        /// Enum Low for "low"
        /// </summary>
        [EnumMember(Value = "low")]
        Low,

        /// <summary>
        /// Enum Medium for "medium"
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,

        /// <summary>
        /// Enum High for "high"
        /// </summary>
        [EnumMember(Value = "high")]
        High
    }
    /// <summary>
    /// Modes to tune between speed to live speaker detection vs accuracy.
    /// </summary>
    /// <value>Modes to tune between speed to live speaker detection vs accuracy.</value>
    [DataMember(Name = "mode", EmitDefaultValue = false)]
    public ModeEnum? Mode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AdjustableLiveSpeakerDetection" /> class.
    /// </summary>
    /// <param name="Mode">Modes to tune between speed to live speaker detection vs accuracy..</param>
    /// <param name="PreconnectDuration">ISO 8601 formatted relative duration (e.g., PT30.8427419S for 30.8 seconds), calculated on line connect..</param>
    /// <param name="EventName">The name of the event that triggered the ALSD evaluation (e.g., line.connect, speech.generic)..</param>
    /// <param name="IsPersonLikely">The output of the ALSD detector, evaluating whether there is likely a person on the call based on the above inputs, and if so, a person is detected early (person disposition name and speech.person analyzer result) and the associated action taken (e.g., speech.person postconnect entry in the disposition table has the action to transfer to a queue)..</param>
    /// <param name="TotalRingbacks">Number of tone.ring.* analyzer events detected during the call (expected mostly during pre-connect but the last ringback tone detection could potentially complete after line connect, which will increment totalRingbacks still)..</param>
    /// <param name="LineConnected">Protocol line connect received (answered by a person, machine, busy, fax)..</param>
    public AdjustableLiveSpeakerDetection(ModeEnum? Mode = null, string PreconnectDuration = null, string EventName = null, bool? IsPersonLikely = null, int? TotalRingbacks = null, bool? LineConnected = null)
    {
        this.Mode = Mode;
        this.PreconnectDuration = PreconnectDuration;
        this.EventName = EventName;
        this.IsPersonLikely = IsPersonLikely;
        this.TotalRingbacks = TotalRingbacks;
        this.LineConnected = LineConnected;

    }





    /// <summary>
    /// ISO 8601 formatted relative duration (e.g., PT30.8427419S for 30.8 seconds), calculated on line connect.
    /// </summary>
    /// <value>ISO 8601 formatted relative duration (e.g., PT30.8427419S for 30.8 seconds), calculated on line connect.</value>
    [DataMember(Name = "preconnectDuration", EmitDefaultValue = false)]
    public string PreconnectDuration { get; set; }



    /// <summary>
    /// The name of the event that triggered the ALSD evaluation (e.g., line.connect, speech.generic).
    /// </summary>
    /// <value>The name of the event that triggered the ALSD evaluation (e.g., line.connect, speech.generic).</value>
    [DataMember(Name = "eventName", EmitDefaultValue = false)]
    public string EventName { get; set; }



    /// <summary>
    /// The output of the ALSD detector, evaluating whether there is likely a person on the call based on the above inputs, and if so, a person is detected early (person disposition name and speech.person analyzer result) and the associated action taken (e.g., speech.person postconnect entry in the disposition table has the action to transfer to a queue).
    /// </summary>
    /// <value>The output of the ALSD detector, evaluating whether there is likely a person on the call based on the above inputs, and if so, a person is detected early (person disposition name and speech.person analyzer result) and the associated action taken (e.g., speech.person postconnect entry in the disposition table has the action to transfer to a queue).</value>
    [DataMember(Name = "isPersonLikely", EmitDefaultValue = false)]
    public bool? IsPersonLikely { get; set; }



    /// <summary>
    /// Number of tone.ring.* analyzer events detected during the call (expected mostly during pre-connect but the last ringback tone detection could potentially complete after line connect, which will increment totalRingbacks still).
    /// </summary>
    /// <value>Number of tone.ring.* analyzer events detected during the call (expected mostly during pre-connect but the last ringback tone detection could potentially complete after line connect, which will increment totalRingbacks still).</value>
    [DataMember(Name = "totalRingbacks", EmitDefaultValue = false)]
    public int? TotalRingbacks { get; set; }



    /// <summary>
    /// Protocol line connect received (answered by a person, machine, busy, fax).
    /// </summary>
    /// <value>Protocol line connect received (answered by a person, machine, busy, fax).</value>
    [DataMember(Name = "lineConnected", EmitDefaultValue = false)]
    public bool? LineConnected { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdjustableLiveSpeakerDetection {\n");

        sb.Append("  Mode: ").Append(Mode).Append("\n");
        sb.Append("  PreconnectDuration: ").Append(PreconnectDuration).Append("\n");
        sb.Append("  EventName: ").Append(EventName).Append("\n");
        sb.Append("  IsPersonLikely: ").Append(IsPersonLikely).Append("\n");
        sb.Append("  TotalRingbacks: ").Append(TotalRingbacks).Append("\n");
        sb.Append("  LineConnected: ").Append(LineConnected).Append("\n");
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
        return Equals(obj as AdjustableLiveSpeakerDetection);
    }

    /// <summary>
    /// Returns true if AdjustableLiveSpeakerDetection instances are equal
    /// </summary>
    /// <param name="other">Instance of AdjustableLiveSpeakerDetection to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdjustableLiveSpeakerDetection other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Mode == other.Mode ||
                Mode != null &&
                Mode.Equals(other.Mode)
            ) &&
            (
                PreconnectDuration == other.PreconnectDuration ||
                PreconnectDuration != null &&
                PreconnectDuration.Equals(other.PreconnectDuration)
            ) &&
            (
                EventName == other.EventName ||
                EventName != null &&
                EventName.Equals(other.EventName)
            ) &&
            (
                IsPersonLikely == other.IsPersonLikely ||
                IsPersonLikely != null &&
                IsPersonLikely.Equals(other.IsPersonLikely)
            ) &&
            (
                TotalRingbacks == other.TotalRingbacks ||
                TotalRingbacks != null &&
                TotalRingbacks.Equals(other.TotalRingbacks)
            ) &&
            (
                LineConnected == other.LineConnected ||
                LineConnected != null &&
                LineConnected.Equals(other.LineConnected)
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
            if (Mode != null)
            {
                hash = hash * 59 + Mode.GetHashCode();
            }

            if (PreconnectDuration != null)
            {
                hash = hash * 59 + PreconnectDuration.GetHashCode();
            }

            if (EventName != null)
            {
                hash = hash * 59 + EventName.GetHashCode();
            }

            if (IsPersonLikely != null)
            {
                hash = hash * 59 + IsPersonLikely.GetHashCode();
            }

            if (TotalRingbacks != null)
            {
                hash = hash * 59 + TotalRingbacks.GetHashCode();
            }

            if (LineConnected != null)
            {
                hash = hash * 59 + LineConnected.GetHashCode();
            }

            return hash;
        }
    }
}
