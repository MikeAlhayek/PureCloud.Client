using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// InitiateScreenRecording
    /// </summary>
    [DataContract]
    public partial class InitiateScreenRecording :  IEquatable<InitiateScreenRecording>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateScreenRecording" /> class.
        /// </summary>
        /// <param name="RecordACW">RecordACW.</param>
        /// <param name="ArchiveRetention">ArchiveRetention.</param>
        /// <param name="DeleteRetention">DeleteRetention.</param>
        public InitiateScreenRecording(bool? RecordACW = null, ArchiveRetention ArchiveRetention = null, DeleteRetention DeleteRetention = null)
        {
            this.RecordACW = RecordACW;
            this.ArchiveRetention = ArchiveRetention;
            this.DeleteRetention = DeleteRetention;
            
        }
        


        /// <summary>
        /// Gets or Sets RecordACW
        /// </summary>
        [DataMember(Name="recordACW", EmitDefaultValue=false)]
        public bool? RecordACW { get; set; }



        /// <summary>
        /// Gets or Sets ArchiveRetention
        /// </summary>
        [DataMember(Name="archiveRetention", EmitDefaultValue=false)]
        public ArchiveRetention ArchiveRetention { get; set; }



        /// <summary>
        /// Gets or Sets DeleteRetention
        /// </summary>
        [DataMember(Name="deleteRetention", EmitDefaultValue=false)]
        public DeleteRetention DeleteRetention { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiateScreenRecording {\n");

            sb.Append("  RecordACW: ").Append(RecordACW).Append("\n");
            sb.Append("  ArchiveRetention: ").Append(ArchiveRetention).Append("\n");
            sb.Append("  DeleteRetention: ").Append(DeleteRetention).Append("\n");
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
            return this.Equals(obj as InitiateScreenRecording);
        }

        /// <summary>
        /// Returns true if InitiateScreenRecording instances are equal
        /// </summary>
        /// <param name="other">Instance of InitiateScreenRecording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateScreenRecording other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RecordACW == other.RecordACW ||
                    this.RecordACW != null &&
                    this.RecordACW.Equals(other.RecordACW)
                ) &&
                (
                    this.ArchiveRetention == other.ArchiveRetention ||
                    this.ArchiveRetention != null &&
                    this.ArchiveRetention.Equals(other.ArchiveRetention)
                ) &&
                (
                    this.DeleteRetention == other.DeleteRetention ||
                    this.DeleteRetention != null &&
                    this.DeleteRetention.Equals(other.DeleteRetention)
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
                if (this.RecordACW != null)
                    hash = hash * 59 + this.RecordACW.GetHashCode();

                if (this.ArchiveRetention != null)
                    hash = hash * 59 + this.ArchiveRetention.GetHashCode();

                if (this.DeleteRetention != null)
                    hash = hash * 59 + this.DeleteRetention.GetHashCode();

                return hash;
            }
        }
    }

}
