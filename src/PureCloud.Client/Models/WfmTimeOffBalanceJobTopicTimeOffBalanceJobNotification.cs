using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification
/// </summary>

public partial class WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification : IEquatable<WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification>
{
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
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Entities">Entities.</param>
    /// <param name="Status">Status.</param>
    /// <param name="Error">Error.</param>
    public WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification(string Id = null, List<WfmTimeOffBalanceJobTopicTimeOffBalance> Entities = null, StatusEnum? Status = null, WfmTimeOffBalanceJobTopicErrorBody Error = null)
    {
        this.Id = Id;
        this.Entities = Entities;
        this.Status = Status;
        this.Error = Error;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<WfmTimeOffBalanceJobTopicTimeOffBalance> Entities { get; set; }





    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public WfmTimeOffBalanceJobTopicErrorBody Error { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification);
    }

    /// <summary>
    /// Returns true if WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmTimeOffBalanceJobTopicTimeOffBalanceJobNotification other)
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
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            return hash;
        }
    }
}
