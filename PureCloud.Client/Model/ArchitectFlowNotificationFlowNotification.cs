using System.Runtime.Serialization;
using System.Text;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ArchitectFlowNotificationFlowNotification
    /// </summary>
    [DataContract]
    public partial class ArchitectFlowNotificationFlowNotification : IEquatable<ArchitectFlowNotificationFlowNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectFlowNotificationFlowNotification" /> class.
        /// </summary>
        /// <param name="Id">The flow ID.</param>
        /// <param name="Name">The flow name.</param>
        /// <param name="Description">The flow description.</param>
        /// <param name="Deleted">The flow deleted state.</param>
        /// <param name="CheckedInVersion">CheckedInVersion.</param>
        /// <param name="SavedVersion">A bare-bones flow version object.</param>
        /// <param name="PublishedVersion">A bare-bones flow version object.</param>
        /// <param name="CurrentOperation">CurrentOperation.</param>
        public ArchitectFlowNotificationFlowNotification(string Id = null, string Name = null, string Description = null, bool? Deleted = null, ArchitectFlowNotificationFlowVersion CheckedInVersion = null, ArchitectFlowNotificationFlowVersion SavedVersion = null, ArchitectFlowNotificationFlowVersion PublishedVersion = null, ArchitectFlowNotificationArchitectOperation CurrentOperation = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Deleted = Deleted;
            this.CheckedInVersion = CheckedInVersion;
            this.SavedVersion = SavedVersion;
            this.PublishedVersion = PublishedVersion;
            this.CurrentOperation = CurrentOperation;

        }



        /// <summary>
        /// The flow ID
        /// </summary>
        /// <value>The flow ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }



        /// <summary>
        /// The flow name
        /// </summary>
        /// <value>The flow name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }



        /// <summary>
        /// The flow description
        /// </summary>
        /// <value>The flow description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }



        /// <summary>
        /// The flow deleted state
        /// </summary>
        /// <value>The flow deleted state</value>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public bool? Deleted { get; set; }



        /// <summary>
        /// Gets or Sets CheckedInVersion
        /// </summary>
        [DataMember(Name = "checkedInVersion", EmitDefaultValue = false)]
        public ArchitectFlowNotificationFlowVersion CheckedInVersion { get; set; }



        /// <summary>
        /// A bare-bones flow version object
        /// </summary>
        /// <value>A bare-bones flow version object</value>
        [DataMember(Name = "savedVersion", EmitDefaultValue = false)]
        public ArchitectFlowNotificationFlowVersion SavedVersion { get; set; }



        /// <summary>
        /// A bare-bones flow version object
        /// </summary>
        /// <value>A bare-bones flow version object</value>
        [DataMember(Name = "publishedVersion", EmitDefaultValue = false)]
        public ArchitectFlowNotificationFlowVersion PublishedVersion { get; set; }



        /// <summary>
        /// Gets or Sets CurrentOperation
        /// </summary>
        [DataMember(Name = "currentOperation", EmitDefaultValue = false)]
        public ArchitectFlowNotificationArchitectOperation CurrentOperation { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectFlowNotificationFlowNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  CheckedInVersion: ").Append(CheckedInVersion).Append("\n");
            sb.Append("  SavedVersion: ").Append(SavedVersion).Append("\n");
            sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
            sb.Append("  CurrentOperation: ").Append(CurrentOperation).Append("\n");
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
            return this.Equals(obj as ArchitectFlowNotificationFlowNotification);
        }

        /// <summary>
        /// Returns true if ArchitectFlowNotificationFlowNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectFlowNotificationFlowNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectFlowNotificationFlowNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) &&
                (
                    this.CheckedInVersion == other.CheckedInVersion ||
                    this.CheckedInVersion != null &&
                    this.CheckedInVersion.Equals(other.CheckedInVersion)
                ) &&
                (
                    this.SavedVersion == other.SavedVersion ||
                    this.SavedVersion != null &&
                    this.SavedVersion.Equals(other.SavedVersion)
                ) &&
                (
                    this.PublishedVersion == other.PublishedVersion ||
                    this.PublishedVersion != null &&
                    this.PublishedVersion.Equals(other.PublishedVersion)
                ) &&
                (
                    this.CurrentOperation == other.CurrentOperation ||
                    this.CurrentOperation != null &&
                    this.CurrentOperation.Equals(other.CurrentOperation)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();

                if (this.CheckedInVersion != null)
                    hash = hash * 59 + this.CheckedInVersion.GetHashCode();

                if (this.SavedVersion != null)
                    hash = hash * 59 + this.SavedVersion.GetHashCode();

                if (this.PublishedVersion != null)
                    hash = hash * 59 + this.PublishedVersion.GetHashCode();

                if (this.CurrentOperation != null)
                    hash = hash * 59 + this.CurrentOperation.GetHashCode();

                return hash;
            }
        }
    }

}
