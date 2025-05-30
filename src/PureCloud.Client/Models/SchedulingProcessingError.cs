using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SchedulingProcessingError
/// </summary>

public partial class SchedulingProcessingError : IEquatable<SchedulingProcessingError>
{
    /// <summary>
    /// An internal code representing the type of error. BadJson for 'Unable to parse json.' NotFound for 'Resource not found.' Fail for 'An unexpected server error occured.'
    /// </summary>
    /// <value>An internal code representing the type of error. BadJson for 'Unable to parse json.' NotFound for 'Resource not found.' Fail for 'An unexpected server error occured.'</value>
    
    public enum InternalErrorCodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Badjson for "BadJson"
        /// </summary>
        [EnumMember(Value = "BadJson")]
        Badjson,

        /// <summary>
        /// Enum Notfound for "NotFound"
        /// </summary>
        [EnumMember(Value = "NotFound")]
        Notfound,

        /// <summary>
        /// Enum Fail for "Fail"
        /// </summary>
        [EnumMember(Value = "Fail")]
        Fail
    }
    /// <summary>
    /// An internal code representing the type of error. BadJson for 'Unable to parse json.' NotFound for 'Resource not found.' Fail for 'An unexpected server error occured.'
    /// </summary>
    /// <value>An internal code representing the type of error. BadJson for 'Unable to parse json.' NotFound for 'Resource not found.' Fail for 'An unexpected server error occured.'</value>
    [JsonPropertyName("internalErrorCode")]
    public InternalErrorCodeEnum? InternalErrorCode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulingProcessingError" /> class.
    /// </summary>
    public SchedulingProcessingError()
    {

    }





    /// <summary>
    /// A text description of the error
    /// </summary>
    /// <value>A text description of the error</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SchedulingProcessingError {\n");

        sb.Append("  InternalErrorCode: ").Append(InternalErrorCode).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as SchedulingProcessingError);
    }

    /// <summary>
    /// Returns true if SchedulingProcessingError instances are equal
    /// </summary>
    /// <param name="other">Instance of SchedulingProcessingError to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SchedulingProcessingError other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                InternalErrorCode == other.InternalErrorCode ||
                InternalErrorCode != null &&
                InternalErrorCode.Equals(other.InternalErrorCode)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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
            if (InternalErrorCode != null)
            {
                hash = hash * 59 + InternalErrorCode.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            return hash;
        }
    }
}
