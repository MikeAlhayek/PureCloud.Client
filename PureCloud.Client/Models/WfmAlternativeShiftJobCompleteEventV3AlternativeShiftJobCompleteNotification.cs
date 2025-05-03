using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification
/// </summary>

public partial class WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification : IEquatable<WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Listoffers for "ListOffers"
        /// </summary>
        [EnumMember(Value = "ListOffers")]
        Listoffers,

        /// <summary>
        /// Enum Searchoffers for "SearchOffers"
        /// </summary>
        [EnumMember(Value = "SearchOffers")]
        Searchoffers,

        /// <summary>
        /// Enum Listusertrades for "ListUserTrades"
        /// </summary>
        [EnumMember(Value = "ListUserTrades")]
        Listusertrades,

        /// <summary>
        /// Enum Searchtrades for "SearchTrades"
        /// </summary>
        [EnumMember(Value = "SearchTrades")]
        Searchtrades,

        /// <summary>
        /// Enum Bulkupdatetrades for "BulkUpdateTrades"
        /// </summary>
        [EnumMember(Value = "BulkUpdateTrades")]
        Bulkupdatetrades
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
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
        Complete,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Status">Status.</param>
    /// <param name="DownloadUrl">DownloadUrl.</param>
    /// <param name="Error">Error.</param>
    public WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification(string Id = null, TypeEnum? Type = null, StatusEnum? Status = null, string DownloadUrl = null, WfmAlternativeShiftJobCompleteEventV3ErrorBody Error = null)
    {
        this.Id = Id;
        this.Type = Type;
        this.Status = Status;
        this.DownloadUrl = DownloadUrl;
        this.Error = Error;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }







    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }



    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public WfmAlternativeShiftJobCompleteEventV3ErrorBody Error { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
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
        return Equals(obj as WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification);
    }

    /// <summary>
    /// Returns true if WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            return hash;
        }
    }
}
