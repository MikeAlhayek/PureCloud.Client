using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ImportStatus
    /// </summary>
    [DataContract]
    public partial class ImportStatus :  IEquatable<ImportStatus>
    {
        /// <summary>
        /// current status of the import
        /// </summary>
        /// <value>current status of the import</value>
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
            /// Enum InProgress for "IN_PROGRESS"
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }
        /// <summary>
        /// current status of the import
        /// </summary>
        /// <value>current status of the import</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportStatus" /> class.
        /// </summary>
        public ImportStatus()
        {
            
        }
        




        /// <summary>
        /// total number of records to be imported
        /// </summary>
        /// <value>total number of records to be imported</value>
        [DataMember(Name="totalRecords", EmitDefaultValue=false)]
        public long? TotalRecords { get; private set; }



        /// <summary>
        /// number of records finished importing
        /// </summary>
        /// <value>number of records finished importing</value>
        [DataMember(Name="completedRecords", EmitDefaultValue=false)]
        public long? CompletedRecords { get; private set; }



        /// <summary>
        /// percentage of records finished importing
        /// </summary>
        /// <value>percentage of records finished importing</value>
        [DataMember(Name="percentComplete", EmitDefaultValue=false)]
        public int? PercentComplete { get; private set; }



        /// <summary>
        /// if the import has failed, the reason for the failure
        /// </summary>
        /// <value>if the import has failed, the reason for the failure</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public string FailureReason { get; private set; }



        /// <summary>
        /// The contact list Ids for target contact lists.
        /// </summary>
        /// <value>The contact list Ids for target contact lists.</value>
        [DataMember(Name="targetContactListIds", EmitDefaultValue=false)]
        public List<string> TargetContactListIds { get; private set; }



        /// <summary>
        /// The prefix for the contact list name
        /// </summary>
        /// <value>The prefix for the contact list name</value>
        [DataMember(Name="listNamePrefix", EmitDefaultValue=false)]
        public string ListNamePrefix { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportStatus {\n");

            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  CompletedRecords: ").Append(CompletedRecords).Append("\n");
            sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  TargetContactListIds: ").Append(TargetContactListIds).Append("\n");
            sb.Append("  ListNamePrefix: ").Append(ListNamePrefix).Append("\n");
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
            return this.Equals(obj as ImportStatus);
        }

        /// <summary>
        /// Returns true if ImportStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.TotalRecords == other.TotalRecords ||
                    this.TotalRecords != null &&
                    this.TotalRecords.Equals(other.TotalRecords)
                ) &&
                (
                    this.CompletedRecords == other.CompletedRecords ||
                    this.CompletedRecords != null &&
                    this.CompletedRecords.Equals(other.CompletedRecords)
                ) &&
                (
                    this.PercentComplete == other.PercentComplete ||
                    this.PercentComplete != null &&
                    this.PercentComplete.Equals(other.PercentComplete)
                ) &&
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) &&
                (
                    this.TargetContactListIds == other.TargetContactListIds ||
                    this.TargetContactListIds != null &&
                    this.TargetContactListIds.SequenceEqual(other.TargetContactListIds)
                ) &&
                (
                    this.ListNamePrefix == other.ListNamePrefix ||
                    this.ListNamePrefix != null &&
                    this.ListNamePrefix.Equals(other.ListNamePrefix)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.TotalRecords != null)
                    hash = hash * 59 + this.TotalRecords.GetHashCode();

                if (this.CompletedRecords != null)
                    hash = hash * 59 + this.CompletedRecords.GetHashCode();

                if (this.PercentComplete != null)
                    hash = hash * 59 + this.PercentComplete.GetHashCode();

                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();

                if (this.TargetContactListIds != null)
                    hash = hash * 59 + this.TargetContactListIds.GetHashCode();

                if (this.ListNamePrefix != null)
                    hash = hash * 59 + this.ListNamePrefix.GetHashCode();

                return hash;
            }
        }
    }

}
