using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LockInfo
/// </summary>

public partial class LockInfo : IEquatable<LockInfo>
{
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Update for "UPDATE"
        /// </summary>
        [EnumMember(Value = "UPDATE")]
        Update,

        /// <summary>
        /// Enum Delete for "DELETE"
        /// </summary>
        [EnumMember(Value = "DELETE")]
        Delete,

        /// <summary>
        /// Enum Copy for "COPY"
        /// </summary>
        [EnumMember(Value = "COPY")]
        Copy,

        /// <summary>
        /// Enum Move for "MOVE"
        /// </summary>
        [EnumMember(Value = "MOVE")]
        Move,

        /// <summary>
        /// Enum Replace for "REPLACE"
        /// </summary>
        [EnumMember(Value = "REPLACE")]
        Replace,

        /// <summary>
        /// Enum Thumbnail for "THUMBNAIL"
        /// </summary>
        [EnumMember(Value = "THUMBNAIL")]
        Thumbnail,

        /// <summary>
        /// Enum TextExtraction for "TEXT_EXTRACTION"
        /// </summary>
        [EnumMember(Value = "TEXT_EXTRACTION")]
        TextExtraction
    }
    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LockInfo" /> class.
    /// </summary>
    /// <param name="LockedBy">LockedBy.</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateExpires">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Action">Action.</param>
    public LockInfo(DomainEntityRef LockedBy = null, DateTime? DateCreated = null, DateTime? DateExpires = null, ActionEnum? Action = null)
    {
        this.LockedBy = LockedBy;
        this.DateCreated = DateCreated;
        this.DateExpires = DateExpires;
        this.Action = Action;

    }



    /// <summary>
    /// Gets or Sets LockedBy
    /// </summary>
    [JsonPropertyName("lockedBy")]
    public DomainEntityRef LockedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateExpires")]
    public DateTime? DateExpires { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LockInfo {\n");

        sb.Append("  LockedBy: ").Append(LockedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
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
        return Equals(obj as LockInfo);
    }

    /// <summary>
    /// Returns true if LockInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of LockInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LockInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LockedBy == other.LockedBy ||
                LockedBy != null &&
                LockedBy.Equals(other.LockedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateExpires == other.DateExpires ||
                DateExpires != null &&
                DateExpires.Equals(other.DateExpires)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
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
            if (LockedBy != null)
            {
                hash = hash * 59 + LockedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateExpires != null)
            {
                hash = hash * 59 + DateExpires.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            return hash;
        }
    }
}
