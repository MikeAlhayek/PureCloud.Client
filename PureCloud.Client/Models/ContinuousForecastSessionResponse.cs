using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContinuousForecastSessionResponse
/// </summary>
[DataContract]
public partial class ContinuousForecastSessionResponse : IEquatable<ContinuousForecastSessionResponse>
{
    /// <summary>
    /// State of the requested session
    /// </summary>
    /// <value>State of the requested session</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// State of the requested session
    /// </summary>
    /// <value>State of the requested session</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContinuousForecastSessionResponse" /> class.
    /// </summary>
    /// <param name="SessionId">Session ID of the continuous forecast data.</param>
    /// <param name="State">State of the requested session.</param>
    /// <param name="Files">Link to the files containing data for requested session.</param>
    public ContinuousForecastSessionResponse(string SessionId = null, StateEnum? State = null, SessionFiles Files = null)
    {
        this.SessionId = SessionId;
        this.State = State;
        this.Files = Files;

    }



    /// <summary>
    /// Session ID of the continuous forecast data
    /// </summary>
    /// <value>Session ID of the continuous forecast data</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }





    /// <summary>
    /// Link to the files containing data for requested session
    /// </summary>
    /// <value>Link to the files containing data for requested session</value>
    [DataMember(Name = "files", EmitDefaultValue = false)]
    public SessionFiles Files { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContinuousForecastSessionResponse {\n");

        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Files: ").Append(Files).Append("\n");
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
        return Equals(obj as ContinuousForecastSessionResponse);
    }

    /// <summary>
    /// Returns true if ContinuousForecastSessionResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ContinuousForecastSessionResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContinuousForecastSessionResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Files == other.Files ||
                Files != null &&
                Files.Equals(other.Files)
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
            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Files != null)
            {
                hash = hash * 59 + Files.GetHashCode();
            }

            return hash;
        }
    }
}
