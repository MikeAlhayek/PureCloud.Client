using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContinuousForecastGetSessionResponse
/// </summary>
[DataContract]
public partial class ContinuousForecastGetSessionResponse : IEquatable<ContinuousForecastGetSessionResponse>
{
    /// <summary>
    /// State of the latest session
    /// </summary>
    /// <value>State of the latest session</value>
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
    /// State of the latest session
    /// </summary>
    /// <value>State of the latest session</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContinuousForecastGetSessionResponse" /> class.
    /// </summary>
    /// <param name="SessionId">Latest session ID of the business unit.</param>
    /// <param name="LastSuccessfulSessionId">Last successful session ID of the business unit.</param>
    /// <param name="State">State of the latest session.</param>
    /// <param name="ErrorCode">Failed session error code.</param>
    public ContinuousForecastGetSessionResponse(string SessionId = null, string LastSuccessfulSessionId = null, StateEnum? State = null, string ErrorCode = null)
    {
        this.SessionId = SessionId;
        this.LastSuccessfulSessionId = LastSuccessfulSessionId;
        this.State = State;
        this.ErrorCode = ErrorCode;

    }



    /// <summary>
    /// Latest session ID of the business unit
    /// </summary>
    /// <value>Latest session ID of the business unit</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }



    /// <summary>
    /// Last successful session ID of the business unit
    /// </summary>
    /// <value>Last successful session ID of the business unit</value>
    [DataMember(Name = "lastSuccessfulSessionId", EmitDefaultValue = false)]
    public string LastSuccessfulSessionId { get; set; }





    /// <summary>
    /// Failed session error code
    /// </summary>
    /// <value>Failed session error code</value>
    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContinuousForecastGetSessionResponse {\n");

        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  LastSuccessfulSessionId: ").Append(LastSuccessfulSessionId).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
        return Equals(obj as ContinuousForecastGetSessionResponse);
    }

    /// <summary>
    /// Returns true if ContinuousForecastGetSessionResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ContinuousForecastGetSessionResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContinuousForecastGetSessionResponse other)
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
                LastSuccessfulSessionId == other.LastSuccessfulSessionId ||
                LastSuccessfulSessionId != null &&
                LastSuccessfulSessionId.Equals(other.LastSuccessfulSessionId)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
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

            if (LastSuccessfulSessionId != null)
            {
                hash = hash * 59 + LastSuccessfulSessionId.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            return hash;
        }
    }
}
