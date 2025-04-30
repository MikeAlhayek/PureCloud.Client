using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ExternalContactsContactChangedTopicInstagramId
    /// </summary>
    [DataContract]
    public partial class ExternalContactsContactChangedTopicInstagramId :  IEquatable<ExternalContactsContactChangedTopicInstagramId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicInstagramId" /> class.
        /// </summary>
        /// <param name="Ids">Ids.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Handle">Handle.</param>
        public ExternalContactsContactChangedTopicInstagramId(List<ExternalContactsContactChangedTopicInstagramScopedId> Ids = null, string DisplayName = null, string Handle = null)
        {
            this.Ids = Ids;
            this.DisplayName = DisplayName;
            this.Handle = Handle;
            
        }
        


        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<ExternalContactsContactChangedTopicInstagramScopedId> Ids { get; set; }



        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }



        /// <summary>
        /// Gets or Sets Handle
        /// </summary>
        [DataMember(Name="handle", EmitDefaultValue=false)]
        public string Handle { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsContactChangedTopicInstagramId {\n");

            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
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
            return this.Equals(obj as ExternalContactsContactChangedTopicInstagramId);
        }

        /// <summary>
        /// Returns true if ExternalContactsContactChangedTopicInstagramId instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsContactChangedTopicInstagramId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsContactChangedTopicInstagramId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Handle == other.Handle ||
                    this.Handle != null &&
                    this.Handle.Equals(other.Handle)
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
                if (this.Ids != null)
                    hash = hash * 59 + this.Ids.GetHashCode();

                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();

                if (this.Handle != null)
                    hash = hash * 59 + this.Handle.GetHashCode();

                return hash;
            }
        }
    }

}
