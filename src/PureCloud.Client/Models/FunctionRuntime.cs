using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Action function runtime.
/// </summary>

public partial class FunctionRuntime : IEquatable<FunctionRuntime>
{
    /// <summary>
    /// Availability status of runtime
    /// </summary>
    /// <value>Availability status of runtime</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Available for "Available"
        /// </summary>
        [EnumMember(Value = "Available")]
        Available,

        /// <summary>
        /// Enum Deprecated for "Deprecated"
        /// </summary>
        [EnumMember(Value = "Deprecated")]
        Deprecated,

        /// <summary>
        /// Enum Unavailable for "Unavailable"
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable
    }
    /// <summary>
    /// Availability status of runtime
    /// </summary>
    /// <value>Availability status of runtime</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FunctionRuntime" /> class.
    /// </summary>
    public FunctionRuntime()
    {

    }



    /// <summary>
    /// Name of the function runtime.
    /// </summary>
    /// <value>Name of the function runtime.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Description of function runtime.
    /// </summary>
    /// <value>Description of function runtime.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }





    /// <summary>
    /// Optional end of life date. Present if the status is Deprecated. Date represents when support for runtime can no longer be guaranteed. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Optional end of life date. Present if the status is Deprecated. Date represents when support for runtime can no longer be guaranteed. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEndOfLife")]
    public string DateEndOfLife { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FunctionRuntime {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DateEndOfLife: ").Append(DateEndOfLife).Append("\n");
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
        return Equals(obj as FunctionRuntime);
    }

    /// <summary>
    /// Returns true if FunctionRuntime instances are equal
    /// </summary>
    /// <param name="other">Instance of FunctionRuntime to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FunctionRuntime other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                DateEndOfLife == other.DateEndOfLife ||
                DateEndOfLife != null &&
                DateEndOfLife.Equals(other.DateEndOfLife)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (DateEndOfLife != null)
            {
                hash = hash * 59 + DateEndOfLife.GetHashCode();
            }

            return hash;
        }
    }
}
