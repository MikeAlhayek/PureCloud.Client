using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalImportOverallDeleteStatusResponse
/// </summary>

public partial class HistoricalImportOverallDeleteStatusResponse : IEquatable<HistoricalImportOverallDeleteStatusResponse>
{
    /// <summary>
    /// Property denoting overall status of the service.
    /// </summary>
    /// <value>Property denoting overall status of the service.</value>
    
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
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete
    }
    /// <summary>
    /// Property denoting overall status of the service.
    /// </summary>
    /// <value>Property denoting overall status of the service.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalImportOverallDeleteStatusResponse" /> class.
    /// </summary>
    /// <param name="Entities">List of all the delete jobs.</param>
    public HistoricalImportOverallDeleteStatusResponse(List<HistoricalDataJobEntityStatus> Entities = null)
    {
        this.Entities = Entities;

    }



    /// <summary>
    /// List of all the delete jobs
    /// </summary>
    /// <value>List of all the delete jobs</value>
    [JsonPropertyName("entities")]
    public List<HistoricalDataJobEntityStatus> Entities { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalImportOverallDeleteStatusResponse {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as HistoricalImportOverallDeleteStatusResponse);
    }

    /// <summary>
    /// Returns true if HistoricalImportOverallDeleteStatusResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalImportOverallDeleteStatusResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalImportOverallDeleteStatusResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
