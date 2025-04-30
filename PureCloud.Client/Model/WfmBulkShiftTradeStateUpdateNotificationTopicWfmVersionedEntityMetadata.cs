using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata
    /// </summary>
    [DataContract]
    public partial class WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata :  IEquatable<WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata" /> class.
        /// </summary>
        /// <param name="Version">Version.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="DateModified">DateModified.</param>
        public WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata(long? Version = null, WfmBulkShiftTradeStateUpdateNotificationTopicUserReference ModifiedBy = null, DateTime? DateModified = null)
        {
            this.Version = Version;
            this.ModifiedBy = ModifiedBy;
            this.DateModified = DateModified;
            
        }
        


        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public WfmBulkShiftTradeStateUpdateNotificationTopicUserReference ModifiedBy { get; set; }



        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata {\n");

            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata);
        }

        /// <summary>
        /// Returns true if WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBulkShiftTradeStateUpdateNotificationTopicWfmVersionedEntityMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                return hash;
            }
        }
    }

}
